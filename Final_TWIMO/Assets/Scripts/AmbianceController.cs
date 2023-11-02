using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmbianceController : MonoBehaviour
{
    
    [SerializeField] AudioSource audioSrc;
    public static AmbianceController singleton;
    
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
        AmbianceController.singleton.GetComponent<AudioSource>().Play();
    }
    
}
