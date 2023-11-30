using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class MainMenuHandler : MonoBehaviour
{
    [SerializeField] HoleSceneTransition hst;
    [SerializeField] AudioMixer mixer;
    public Inventory inventory;
    public FishStats stats;
    public Day day;

    void Start(){
        
        mixer.SetFloat("Music", (Mathf.Log10(PlayerPrefs.GetFloat("musicvolume")) * 20));
        mixer.SetFloat("SFX", (Mathf.Log10(PlayerPrefs.GetFloat("sfxvolume")) * 20));
        mixer.SetFloat("Ambient", (Mathf.Log10(PlayerPrefs.GetFloat("ambientvolume")) * 20));
        LoadGame();
    }

    public void LoadGame(){
        //load money
        if(PlayerPrefs.HasKey("money")){
            inventory.money = PlayerPrefs.GetInt("money");
        }
        else{
            inventory.money = 100;
        }
        //load day index
        day.dayIndex = (PlayerPrefs.GetInt("day"));
        // load each items quantity owned
        string[] qtokens = PlayerPrefs.GetString("quantities").Split(",");
        int index = 0;
        foreach(Item item in inventory.items){
            item.quantityOwned = int.Parse(qtokens[index]);
            index++;
        }
        // load each fishes :happiness, hunger, level, health, levelProgress, isUnlocked
        if(PlayerPrefs.HasKey("fishstats")){
            string[] fishes = PlayerPrefs.GetString("fishstats").Split(",");
            index = 0;
            foreach(FishData fish in stats.list){
                string[] stats = fishes[index].Split("-");
                fish.happiness = int.Parse(stats[0]);
                fish.hunger = int.Parse(stats[1]);
                fish.level = int.Parse(stats[2]);
                fish.levelProgress = int.Parse(stats[3]);
                fish.health = int.Parse(stats[4]);
                fish.isUnlocked = int.Parse(stats[5]);
                index++;
            }
        }
        else{
            foreach(FishData fish in stats.list){
                if(fish.cost == 15){
                    fish.happiness = 5;
                    fish.hunger = 5;
                    fish.level = 3;
                    fish.levelProgress = 0;
                    fish.health = 9;
                    fish.isUnlocked = 0;
                }
            }
        }
        // load shop selection
        if(PlayerPrefs.HasKey("shopinv")){
            string[] shopinv = PlayerPrefs.GetString("shopinv").Split(",");
            inventory.shopSelection.Clear();
            inventory.shopSelection.Add(inventory.items[inventory.items.FindIndex(x => x.id == int.Parse(shopinv[0]))]);
            inventory.shopSelection.Add(inventory.items[inventory.items.FindIndex(x => x.id == int.Parse(shopinv[1]))]);
            inventory.shopSelection.Add(inventory.items[inventory.items.FindIndex(x => x.id == int.Parse(shopinv[2]))]);
            inventory.shopSelection.Add(inventory.items[inventory.items.FindIndex(x => x.id == int.Parse(shopinv[3]))]);
            inventory.shopSelection.Add(inventory.items[inventory.items.FindIndex(x => x.id == int.Parse(shopinv[4]))]);
        }
        else{
            inventory.setShopInventory();
        }
    }
    public void PlayGame(){
        //add delay with scene transition
        hst.ClosingTransition();
        if(RoomMusicHandler.singleton != null){
            RoomMusicHandler.singleton.GetComponent<AudioSource>().Play();
        }
        Invoke("Go",1.5f);
    }

    public void QuitGame(){
        hst.ClosingTransition();
        Invoke("Quit",1.5f);
    }

    public void Quit(){
        Application.Quit();
    }
    public void Go(){
         SceneManager.LoadScene("Bedroom");
    }
}
