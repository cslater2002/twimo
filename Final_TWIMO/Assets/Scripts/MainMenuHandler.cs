using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuHandler : MonoBehaviour
{
    [SerializeField] HoleSceneTransition hst;
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
