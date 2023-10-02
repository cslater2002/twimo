using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayAnimationOnInput : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Animator anim;
    void Awake()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Space)){
            anim.Play("Animation");
        }
    }
    
}
