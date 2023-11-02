using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayAnimationOnInput : MonoBehaviour
{
    
    [SerializeField] Animator anim;
    [SerializeField] AudioSource audioSrc;
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
            audioSrc.time = 0.0089f;
            audioSrc.Play();
            anim.Play("Animation");
        }
    }
    
}
