using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] float smoothSpeed = 0.0001f;

    void LateUpdate(){
        Follow();
    }

    public void Follow(){

        Vector3 targetPos = target.position;
        targetPos.z = -10;
        //Vector3 smoothFollow = Vector3.Lerp(transform.position, targetPos, smoothSpeed);
        targetPos.x = Mathf.Lerp(transform.position.x, targetPos.x, smoothSpeed);
        targetPos.y = Mathf.Lerp(transform.position.y, targetPos.y, smoothSpeed);
        transform.position = targetPos;
    }
}