using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeItem : MonoBehaviour
{
    public FishStats stats;
    public int index;
    
    void Start()
    {
        index = stats.currentIndex;
        GetComponent<SpriteRenderer>().sprite = stats.list[index].fishImage; 
        GetComponent<SpriteRenderer>().color = stats.list[index].color;          
    }
}
