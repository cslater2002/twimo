using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform target;
    public float smoothSpeed = 0.001f;

    void LateUpdate(){
        Follow();
    }

    public void Follow(){
        Vector3 targetPos = target.position;
        targetPos.z = -10;
        targetPos.x = Mathf.Lerp(transform.position.x, targetPos.x, smoothSpeed);
        targetPos.y = Mathf.Lerp(transform.position.y, targetPos.y, smoothSpeed);
        transform.position = targetPos;
    }
}
