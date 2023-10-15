using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopUI : MonoBehaviour
{
    [SerializeField] Animator anim;
    
    void OnTriggerEnter2D(Collider2D other){
        anim.Play("ShopOpen");
    }

    void OnTriggerExit2D(Collider2D other){
        anim.Play("ShopClose");
    }
}
