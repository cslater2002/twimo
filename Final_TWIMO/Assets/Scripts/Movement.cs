using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;
    [SerializeField] float speed = 5;
    [SerializeField] AnimationStateChanger asc;

    public void MoveRB(Vector3 vel){
        if(vel.magnitude == 0){
            asc.ChangeState("Idle");
        }
        rb.velocity = vel * speed;
    }
}
