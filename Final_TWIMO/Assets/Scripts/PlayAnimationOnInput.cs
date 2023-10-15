using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayAnimationOnInput : MonoBehaviour
{
    
    [SerializeField] Animator anim;

    void Update()
    {
        if(Input.GetKey(KeyCode.Space)){
            anim.Play("Animation");
        }
    }
    
}
