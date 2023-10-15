using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovementHandler : MonoBehaviour
{
    [SerializeField] Movement movement;
    [SerializeField] Canvas canvas;
    public SetLocation setLocation;

    void Start(){
        if (setLocation.prevLocationName == "FishWorld" && SceneManager.GetActiveScene().name == "Bedroom"){
            transform.position = new Vector3(4.5f, -0.25f, 0);
        }
        else if(setLocation.prevLocationName == "Store" && SceneManager.GetActiveScene().name == "Outside"){
            transform.position = new Vector3(-18.92f, -0.72f, 0);
        }
    }
    
    void FixedUpdate()
    {
        Vector3 vel = Vector3.zero;
        if(canvas.enabled == false && SceneManager.GetActiveScene().name != "FishWorld" && SceneManager.GetActiveScene().name != "FishRoom"){
            if(Input.GetKey(KeyCode.A)){
                vel.x = -1;
            }
            if(Input.GetKey(KeyCode.D)){
                vel.x = 1;
            }
            if(Input.GetKey(KeyCode.W)){
                vel.y = 1;
            }
            if(Input.GetKey(KeyCode.S)){
                vel.y = -1;
            }
            movement.MoveRB(vel);
        }
    }
}
