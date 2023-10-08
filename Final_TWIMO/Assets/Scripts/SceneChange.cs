using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneChange : MonoBehaviour
{
    [SerializeField] string sceneName;
    [SerializeField] GameObject test;

    
    void OnTriggerEnter2D(Collider2D other){
        if(sceneName == "Outside"){
            test = GameObject.FindWithTag("PrevScene");
            if(test != null){
                test.GetComponent<SetLocation>().prevScene = SceneManager.GetActiveScene().name;
            }
            
        }
        SceneManager.LoadScene(sceneName);
    }

    public void ChangeSceneOnClick(string sceneName){
        SceneManager.LoadScene(sceneName);
    }
}
