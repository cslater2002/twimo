using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioHandler : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] AudioSource audioSrc; 
    public void PlaySoundEffect(){
        audioSrc.time = 0.0075f;
        audioSrc.Play();
    }
}
