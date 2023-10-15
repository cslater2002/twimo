using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiscreteMovement : MonoBehaviour
{
    // Start is called before the first frame update

    // Update is called once per frame
    [SerializeField] float upperBound;// = -460
    [SerializeField] float lowerBound; //= 300.9
    [SerializeField] float distance; //= 3.25
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A)){
            if(transform.localPosition.x > lowerBound){
                transform.position += new Vector3(-distance,0,0);
            }
        }
        if(Input.GetKeyDown(KeyCode.D)){
            if(transform.localPosition.x < upperBound){
                transform.position += new Vector3(distance,0,0);
            }
        }
    }
}
