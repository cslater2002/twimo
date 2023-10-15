using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiscreteMovement : MonoBehaviour
{
    
    [SerializeField] float upperBound;
    [SerializeField] float lowerBound; 
    [SerializeField] float distance; 
    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A)){
            if(transform.localPosition.x > lowerBound){
                transform.position += new Vector3(-distance, 0, 0);
            }
        }
        if(Input.GetKeyDown(KeyCode.D)){
            if(transform.localPosition.x < upperBound){
                transform.position += new Vector3(distance, 0, 0);
            }
        }
    }
}
