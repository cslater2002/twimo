using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class MainMenuHandler : MonoBehaviour
{
    [SerializeField] HoleSceneTransition hst;
    [SerializeField] AudioMixer mixer;

    void Start(){
        mixer.SetFloat("Music", Mathf.Log10(PlayerPrefs.GetFloat("musicvolume")) * 20);
        mixer.SetFloat("SFX", Mathf.Log10(PlayerPrefs.GetFloat("sfxvolume")) * 20);
        mixer.SetFloat("Ambient", Mathf.Log10(PlayerPrefs.GetFloat("ambientvolume")) * 20);
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
