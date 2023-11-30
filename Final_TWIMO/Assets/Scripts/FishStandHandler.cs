using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishStandHandler : MonoBehaviour
{
    [SerializeField] DayHandler dh;

    void Start()
    {
        if(dh.dayIndex.dayIndex == 0){
            
        }
        else{
            transform.gameObject.SetActive(false);
        }    
    }
}
