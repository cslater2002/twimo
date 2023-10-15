using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chase : MonoBehaviour
{
    [SerializeField] GameObject fish;
    [SerializeField] Collider2D item;
    [SerializeField] Camera cam;
    public bool isWandering = false;
    public bool goingLeft = false;
    public bool goingRight = false;
    public bool goingLeftDown = false;
    public bool goingRightDown = false;
    public bool isCatching = false;


    void OnTriggerEnter2D(Collider2D other){
        if(other.name != "Fish"){
            item = other;
            isCatching = true;
            cam.GetComponent<CameraMovement>().target = item.gameObject.GetComponent<Transform>();
            cam.GetComponent<CameraMovement>().smoothSpeed = 1;
        }
    }

    void Update()
    {
        if(isCatching){
            if(item.IsTouching(fish.GetComponent<BoxCollider2D>())){
                cam.GetComponent<CameraMovement>().target = fish.GetComponent<Transform>();
                cam.GetComponent<CameraMovement>().smoothSpeed = .001f;
                Destroy(item.gameObject);
                isCatching = false;
            }
             Vector3 direction = item.transform.position - fish.transform.position;
             direction = Vector3.Normalize(direction);
             if(direction.x < 0){
                fish.GetComponent<SpriteRenderer>().flipX = false;
             }
             else{
                fish.GetComponent<SpriteRenderer>().flipX = true;
             }
             fish.transform.position += direction;
         }
        if(!isWandering && !isCatching){
            StartCoroutine(Wander());
        }
        else if(isWandering){
            if(goingLeft){
            fish.transform.position += new Vector3(-1,1,1) * Time.deltaTime;
            }
            if(goingRight){
                fish.transform.position += new Vector3(1,1,1) * Time.deltaTime;
            }
            if(goingLeftDown){
                fish.transform.position += new Vector3(-1,-1,1) * Time.deltaTime;
            }
            if(goingRightDown){
                fish.transform.position += new Vector3(1,-1,1) * Time.deltaTime;
            }
        }
    }

    IEnumerator Wander()
    {
        isWandering = true;
        int yChange = Random.Range(1,3); 
        int leftChange = Random.Range(1,5);
        int rightChange = 5 - leftChange;
        fish.GetComponent<SpriteRenderer>().flipX = false;
        if(yChange == 1){
            goingLeft = true;
            yield return new WaitForSeconds(leftChange);
            goingLeft = false;
        }
        if(yChange == 2){
            goingLeftDown = true;
            yield return new WaitForSeconds(leftChange);
            goingLeftDown = false;
        }
        fish.GetComponent<SpriteRenderer>().flipX = true;
        if(yChange == 1){
            goingRight = true;
            yield return new WaitForSeconds(rightChange);
            goingRight = false;
        }
        if(yChange == 2){
            goingRightDown = true;
            yield return new WaitForSeconds(rightChange);
            goingRightDown = false;
        }
        isWandering = false;
    }
}


