using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlideDownInventory : MonoBehaviour
{
    [SerializeField] Animator anim;

    public void SlideInventoryDown(){
        anim.Play("Open");
    }

    public void SlideInventoryUp(){
        anim.Play("Close");
    }
    
    public void SlideStatsInventoryDown(){
        anim.Play("OpenStats");
    }

    public void SlideStatsUp(){
        anim.Play("CloseStats");
    }
}
