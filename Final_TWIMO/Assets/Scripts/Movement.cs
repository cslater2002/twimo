using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;
    [SerializeField] float speed = 5;

    public void MoveRB(Vector3 vel){
        rb.velocity = vel * speed;
    }
}
