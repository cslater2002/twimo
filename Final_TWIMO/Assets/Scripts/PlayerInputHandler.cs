using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovementHandler : MonoBehaviour
{
    [SerializeField] Movement movement;
    [SerializeField] Canvas canvas;
    SetLocation setLocation;
    // Start is called before the first frame update
    void Awake()
    { 
        if(SceneManager.GetActiveScene().name != "FishWorld"){
            movement = GetComponent<Movement>();
        }
        setLocation = SetLocation.singleton;
    }

    void Start(){
        if(SceneManager.GetActiveScene().name == "Outside" || SceneManager.GetActiveScene().name == "Bedroom"){
            if(setLocation.spawnLocation != new Vector3(0,0,0)){
                transform.position = setLocation.spawnLocation;
            }
        }
        //transform.position = setLocation.spawnLocation;
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 vel = Vector3.zero;
        if(canvas.enabled == false && SceneManager.GetActiveScene().name != "FishWorld"){
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
