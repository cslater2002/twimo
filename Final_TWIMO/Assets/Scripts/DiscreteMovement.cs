using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiscreteMovement : MonoBehaviour
{
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A)){
            if(transform.localPosition.x > -460){
                transform.position += new Vector3(-3.25f,0,0);
            }
        }
        if(Input.GetKeyDown(KeyCode.D)){
            if(transform.localPosition.x < 300.9){
                transform.position += new Vector3(3.25f,0,0);
            }
        }
    }
}
