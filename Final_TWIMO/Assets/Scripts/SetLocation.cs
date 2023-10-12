using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetLocation : MonoBehaviour
{
    public Vector3 spawnLocation;
    public string prevSceneName;
    public static SetLocation singleton { get; set; }

    void Awake(){
        if(singleton == null){
            singleton = this;
            spawnLocation = Vector3.zero;
        }
        else{
            Destroy(this.gameObject);
        }
    }

}
