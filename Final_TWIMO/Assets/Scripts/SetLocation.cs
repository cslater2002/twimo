using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetLocation : MonoBehaviour
{
    [SerializeField] Transform location;
    public string prevScene;

    void Start()
    {
        if(prevScene == "Store"){
            location.position = new Vector3(-18.92f, -0.72f, 0);
        }
        else{
            
        }
    }

}
