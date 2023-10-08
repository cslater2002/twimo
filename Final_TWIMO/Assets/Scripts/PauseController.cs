using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseController : MonoBehaviour
{
    [SerializeField] Canvas canvas;
    [SerializeField] Canvas inventory;
    void Awake(){
        canvas.enabled = false;
        inventory.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Escape)){
            canvas.enabled = true;
        }
        else if(Input.GetKeyDown(KeyCode.T)){
            if(inventory.enabled == false){
                inventory.enabled = true;
            }
            else{
                inventory.enabled = false;
            }
        }
    }

    public void PauseOn(){
        canvas.enabled = true;
    }
    public void PauseOff(){
        canvas.enabled = false;
    }
}
