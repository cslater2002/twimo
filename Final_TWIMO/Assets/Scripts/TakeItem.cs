using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeItem : MonoBehaviour
{
    public FishStats stats;
    public int index;
    // Start is called before the first frame update
    void Start()
    {
        index = stats.currentIndex;
        GetComponent<SpriteRenderer>().sprite = stats.list[index].fishImage;           
    }
    public void OnTriggerEnter2D(Collider2D other){
    }
}
