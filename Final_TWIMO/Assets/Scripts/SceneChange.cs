using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneChange : MonoBehaviour
{
    [SerializeField] string sceneName;
    public SetLocation setLocation;

    void Start(){
        //setLocation = SetLocation.singleton;
    }

    void OnTriggerEnter2D(Collider2D other){
        // if(sceneName == "Outside"){
        //     if(setLocation.prevSceneName == "Store"){
        //         setLocation.spawnLocation = new Vector3(-18.92f, -0.72f, 0);
        //     }
        //     else if(setLocation.prevSceneName == "Bedroom"){
        //         setLocation.spawnLocation = new Vector3(2.33f, 3.53f, 0);
        //     }
        // }
        // else if(sceneName == "Bedroom"){
        //     if(setLocation.prevSceneName == "Outside"){
        //         setLocation.spawnLocation = new Vector3(1.5f, 1.25f, 0);
        //     }
        //     else if(setLocation.prevSceneName == "FishWorld"){
        //         setLocation.spawnLocation = new Vector3(4.5f, -0.25f, 0);
        //     }
        // }
        // Debug.Log("Scene change" + setLocation.spawnLocation);
        setLocation.prevLocationName = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(sceneName);
    }

    public void ChangeSceneOnClick(string sceneName){
        // Debug.Log("Scene change" + setLocation.spawnLocation);
        // setLocation.spawnLocation = new Vector3(4.5f, -0.25f, 0);
        setLocation.prevLocationName = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(sceneName);
    }
}
