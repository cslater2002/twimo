using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuHandler : MonoBehaviour
{
    [SerializeField] AudioSource audioSrc;

    public void PlayGame(string sceneName){
        audioSrc.time = 0.0080f;
        audioSrc.Play();
        //add delay with scene transition
        if(RoomMusicHandler.singleton != null){
            RoomMusicHandler.singleton.GetComponent<AudioSource>().Play();
        }
        SceneManager.LoadScene(sceneName);
    }

    public void QuitGame(){
        audioSrc.time = 0.008f;
        audioSrc.Play();
        //add delay with scene transition
        Application.Quit();
    }
}
