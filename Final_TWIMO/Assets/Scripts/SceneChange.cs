using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneChange : MonoBehaviour
{
    [SerializeField] string sceneName;
    SetLocation setLocation;

    void Start(){
        setLocation = SetLocation.singleton;
    }

    void OnTriggerEnter2D(Collider2D other){
        if(sceneName == "Outside"){
            if(SceneManager.GetActiveScene().name == "Store"){
                setLocation.spawnLocation = new Vector3(-18.92f, -0.72f, 0);
            }
            else if(SceneManager.GetActiveScene().name == "Bedroom"){
                setLocation.spawnLocation = new Vector3(2.33f, 3.53f, 0);
            }
        }
        else if(sceneName == "Bedroom"){
            if(SceneManager.GetActiveScene().name == "Outside"){
                setLocation.spawnLocation = new Vector3(1.5f, 1.25f, 0);
            }
        }
        SceneManager.LoadScene(sceneName);
    }

    public void ChangeSceneOnClick(string sceneName){
        if(sceneName == "Bedroom"){
           if(SceneManager.GetActiveScene().name == "FishWorld"){
                setLocation.spawnLocation = new Vector3(4.5f, -0.25f, 0);
            }
        }
        SceneManager.LoadScene(sceneName);
    }
}
