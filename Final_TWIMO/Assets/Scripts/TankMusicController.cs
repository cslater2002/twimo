using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class TankMusicController : MonoBehaviour
{
    
    [SerializeField] AudioSource audioSrc;
    public static TankMusicController singleton;
    
    void Awake()
    {
         if(singleton == null){
             singleton = this;
             DontDestroyOnLoad(gameObject);
         }
         else{
             Destroy(this.gameObject);
         }
    }

    void Start(){
        PlayMusic();
    }

    public void PlayMusic(){
        TankMusicController.singleton.GetComponent<AudioSource>().Play();
    }
}
