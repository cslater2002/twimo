using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
public class PauseController : MonoBehaviour
{
    [SerializeField] Canvas canvas;
    [SerializeField] Canvas inventory;
    [SerializeField] Text moneyLabel;
    [SerializeField] GameObject item1;
    [SerializeField] GameObject item2;
    [SerializeField] GameObject item3;
    [SerializeField] GameObject item4;
    [SerializeField] GameObject item5;
    [SerializeField] GameObject item6;
    [SerializeField] GameObject item7;
    [SerializeField] GameObject item8;
    [SerializeField] GameObject item9;
    [SerializeField] GameObject item10;
    [SerializeField] GameObject item11;
    [SerializeField] GameObject item12;
    [SerializeField] GameObject item13;
    [SerializeField] GameObject item14;
    [SerializeField] GameObject item15;
    [SerializeField] GameObject item16;
    [SerializeField] Image optionsMenu;
    [SerializeField] Slider musicSlider;
    [SerializeField] Slider sfxSlider;
    [SerializeField] Slider ambienceSlider;
    [SerializeField] AudioMixer mixer;
    public Inventory playerInventory;

    void Start(){
        mixer.SetFloat("Music", Mathf.Log10(PlayerPrefs.GetFloat("musicvolume")) * 20);
        mixer.SetFloat("SFX", Mathf.Log10(PlayerPrefs.GetFloat("sfxvolume")) * 20);
        mixer.SetFloat("Ambient", Mathf.Log10(PlayerPrefs.GetFloat("ambientvolume")) * 20);
        musicSlider.value = PlayerPrefs.GetFloat("musicvolume");
        sfxSlider.value = PlayerPrefs.GetFloat("sfxvolume");
        ambienceSlider.value =  PlayerPrefs.GetFloat("ambientvolume");
        canvas.enabled = false;
        optionsMenu.gameObject.SetActive(false);
        if(inventory != null){        
            inventory.enabled = false;
        }

    }

    void Update()
    {
        if(Input.GetKey(KeyCode.Escape)){
            canvas.enabled = true;
            optionsMenu.gameObject.SetActive(false);
        }
        else if(Input.GetKeyDown(KeyCode.T) && SceneManager.GetActiveScene().name != "FishWorld" && SceneManager.GetActiveScene().name != "FishRoom"){
            if(inventory.enabled == false){
                var items = new List<GameObject> {item1, item2, item3, item4,item5,item6,item7,item8,item9,item10,item11,item12,item13,item14,item15,item16};
                foreach(GameObject item in items){
                    item.active = true;
                }
                moneyLabel.text = "$";
                moneyLabel.text += playerInventory.money;
                int filledSlotsCount = 0;
                for(int i = 0; i < playerInventory.items.Count; i++){
                    if(filledSlotsCount >= 16){
                        break;
                    }
                    if(playerInventory.items[i].quantityOwned > 0){
                        items[filledSlotsCount].GetComponent<SpriteRenderer>().sprite = playerInventory.items[i].itemImage;
                        items[filledSlotsCount].GetComponentInChildren<Text>().text = playerInventory.items[i].quantityOwned + "";
                        filledSlotsCount++;
                    }
                }
                inventory.enabled = true;
            }
            else{
                var items = new List<GameObject> {item1, item2, item3, item4,item5,item6,item7,item8,item9,item10,item11,item12,item13,item14,item15,item16};
                foreach(GameObject item in items){
                    item.active = false;
                }
                inventory.enabled = false;
            }
        }
    }

    public void PauseOn(){
        canvas.enabled = true;
    }
    public void PauseOff(){
        canvas.enabled = false;
    }

    public void OptionsMenuOn(){
        optionsMenu.gameObject.SetActive(true);
    }
    public void OptionsMenuOff(){
        optionsMenu.gameObject.SetActive(false);
    }

    public void SliderOnValueChanged(string slider){
        if(slider == "music"){
            mixer.SetFloat("Music", Mathf.Log10(musicSlider.value) * 20);
        }
        if(slider == "sfx"){
            mixer.SetFloat("SFX", Mathf.Log10(sfxSlider.value) * 20);
        }
        if(slider == "ambient"){
            mixer.SetFloat("Ambient", Mathf.Log10(ambienceSlider.value) * 20);
        }

    }
    public void SaveVolume(){
        PlayerPrefs.SetFloat("musicvolume", musicSlider.value);
        PlayerPrefs.SetFloat("sfxvolume", sfxSlider.value);
        PlayerPrefs.SetFloat("ambientvolume", ambienceSlider.value);
        PlayerPrefs.Save();
    }
}
