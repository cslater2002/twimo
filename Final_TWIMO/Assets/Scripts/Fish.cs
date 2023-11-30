using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class TakeItem : MonoBehaviour
{
    public FishStats stats;
    public int index;
    [SerializeField] DialogueTrigger trigger;
    void Start()
    {
        index = stats.currentIndex;
        GetComponent<SpriteRenderer>().sprite = stats.list[index].fishImage; 
        GetComponent<SpriteRenderer>().color = stats.list[index].color;    
        trigger.dialogue.color = ColorUtility.ToHtmlStringRGBA( stats.list[index].color );
    }

    
    
}
