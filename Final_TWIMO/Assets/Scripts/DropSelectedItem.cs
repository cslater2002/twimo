using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropSelectedItem : MonoBehaviour
{
    [SerializeField] Animator anim;
    public Inventory inventory;
    [SerializeField] GameObject prefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
    public void DropItem(){

        anim.Play("Close");
        //disable buttons
        if((int) transform.localPosition.x == -757){
            prefab.GetComponent<SpriteRenderer>().sprite = inventory.items[0].itemImage;
        }
        else if((int) transform.localPosition.x == -406){
            prefab.GetComponent<SpriteRenderer>().sprite = inventory.items[1].itemImage;
        }
        else if((int) transform.localPosition.x == -55){
            prefab.GetComponent<SpriteRenderer>().sprite = inventory.items[2].itemImage;
        }
        else if((int) transform.localPosition.x == 295){
            prefab.GetComponent<SpriteRenderer>().sprite = inventory.items[3].itemImage;
        }
        else if((int) transform.localPosition.x == 646){
            prefab.GetComponent<SpriteRenderer>().sprite = inventory.items[4].itemImage;
        }
        Instantiate(prefab, new Vector3(prefab.GetComponent<Transform>().localPosition.x, prefab.GetComponent<Transform>().localPosition.y, prefab.GetComponent<Transform>().localPosition.z), Quaternion.identity);
        //remove it from inventory
        
    }
}
