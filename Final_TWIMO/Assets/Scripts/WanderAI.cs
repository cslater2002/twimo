using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WanderAI : MonoBehaviour
{
    [SerializeField] float speed = 1f;
    [SerializeField] SpriteRenderer body;
    [SerializeField] GameObject item;
    public bool isWandering = false;
    public bool goingLeft = false;
    public bool goingRight = false;
    public bool goingLeftDown = false;
    public bool goingRightDown = false;
    public bool isCatching = false;

    // Update is called once per frame
    void Update()
    {
        Debug.Log(item.activeInHierarchy);
        // if(Vector3.Distance(transform.position, item.transform.position) < 5){
        //     isCatching = true;
        //     Vector3 direction = item.position - transform.position;
        //     direction = Vector3.Normalize(direction);
        //     transform.position += direction;
        // }
        if(!isWandering && !isCatching){
            StartCoroutine(Wander());
        }
        else if(isWandering){
            if(goingLeft){
            transform.position += new Vector3(-1,1,1) * Time.deltaTime;
            }
            if(goingRight){
                transform.position += new Vector3(1,1,1) * Time.deltaTime;
            }
            if(goingLeftDown){
                transform.position += new Vector3(-1,-1,1) * Time.deltaTime;
            }
            if(goingRightDown){
                transform.position += new Vector3(1,-1,1) * Time.deltaTime;
            }
        }

        
        //if there is a wall change directions
    }

    IEnumerator Wander()
    {
        isWandering = true;
       int yChange = Random.Range(1,3); //if 1 go up if 2 go down
       int leftChange = Random.Range(1,5);
       int rightChange = 5 - leftChange;
        body.flipX = false;
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

        body.flipX = true;
        
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
