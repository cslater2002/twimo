using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AnimationStateChanger : MonoBehaviour
{
    [SerializeField] Animator anim;
    [SerializeField] string currentState = "Idle";


    void Start(){
        ChangeState(currentState);
    }

    public void ChangeState(string newState){
        if(currentState == newState){
            return;
        }
        if(currentState == "Walk2" && newState == "Idle"){
            newState = "Idle2";
        }
        if(currentState == "Idle2" && newState == "Idle"){
            return;
        }
        currentState = newState;
        anim.Play(newState);
    }
}
