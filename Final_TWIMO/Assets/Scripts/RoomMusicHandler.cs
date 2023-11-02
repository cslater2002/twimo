using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomMusicHandler : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] AudioSource audioSrc;
    public static RoomMusicHandler singleton;
    
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
        RoomMusicHandler.singleton.GetComponent<AudioSource>().Play();
    }
}
