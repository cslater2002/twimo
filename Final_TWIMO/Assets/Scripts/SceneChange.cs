using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneChange : MonoBehaviour
{
    [SerializeField] string sceneName;
    public SetLocation setLocation;
    [SerializeField] AudioSource audioSrc;
    void OnTriggerEnter2D(Collider2D other){
        if(sceneName != "FishWorld"){
            audioSrc.time = 0.1f;
            audioSrc.Play();
            //play door open animation
            //scene transition
        }
        setLocation.prevLocationName = SceneManager.GetActiveScene().name;
        if(sceneName == "FishWorld" && TankMusicController.singleton != null){
            TankMusicController.singleton.GetComponent<AudioSource>().Play();
            AmbianceController.singleton.GetComponent<AudioSource>().Play();
        }
        if(sceneName == "Store" || sceneName == "FishWorld"){
             RoomMusicHandler.singleton.GetComponent<AudioSource>().Stop();
        }
        if(sceneName == "Outside" && SceneManager.GetActiveScene().name == "Store"){
            RoomMusicHandler.singleton.GetComponent<AudioSource>().Play();
        }
        SceneManager.LoadScene(sceneName);
    }

    public void ChangeSceneOnClick(string sceneName){
        if(sceneName == "Bedroom"){
            TankMusicController.singleton.GetComponent<AudioSource>().Stop();
            AmbianceController.singleton.GetComponent<AudioSource>().Stop();
            RoomMusicHandler.singleton.GetComponent<AudioSource>().Play();
        }
        if((SceneManager.GetActiveScene().name == "FishWorld" || SceneManager.GetActiveScene().name == "FishRoom") && (sceneName == "Main_Menu")){
            TankMusicController.singleton.GetComponent<AudioSource>().Stop();
            AmbianceController.singleton.GetComponent<AudioSource>().Stop();
        }
        if((SceneManager.GetActiveScene().name == "Bedroom" || SceneManager.GetActiveScene().name == "Outside") && (sceneName == "Main_Menu")){
            RoomMusicHandler.singleton.GetComponent<AudioSource>().Stop();
        }
        
        setLocation.prevLocationName = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(sceneName);
    }
}
