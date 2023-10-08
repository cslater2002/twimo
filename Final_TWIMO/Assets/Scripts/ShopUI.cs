using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopUI : MonoBehaviour
{
    [SerializeField] Animator anim;
    void Awake()
    {
        //anim = GetComponent<Animator>();
    }

    void OnTriggerEnter2D(Collider2D other){
        Debug.Log("in");
        anim.Play("ShopOpen");
    }

    void OnTriggerExit2D(Collider2D other){
        Debug.Log("out");
        anim.Play("ShopClose");
    }
    
    public void SlideShopDown(){
        
    }

    public void SlideShopUp(){
        anim.Play("ShopClose");
    }
}
