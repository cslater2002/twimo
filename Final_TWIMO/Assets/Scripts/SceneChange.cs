using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneChange : MonoBehaviour
{
    [SerializeField] string sceneName;
    public SetLocation setLocation;

    void OnTriggerEnter2D(Collider2D other){
        setLocation.prevLocationName = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(sceneName);
    }

    public void ChangeSceneOnClick(string sceneName){
        setLocation.prevLocationName = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(sceneName);
    }
}
