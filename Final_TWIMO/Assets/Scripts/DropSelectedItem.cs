using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DropSelectedItem : MonoBehaviour
{
    [SerializeField] Animator anim;
    public Inventory inventory;
    [SerializeField] GameObject prefab;
    [SerializeField] Button foodButton;
    [SerializeField] Button giftButton;
    [SerializeField] Image canvas;
    // Start is called before the first frame update
    
    public void DropItem(){
        List<Item> list = new List<Item>();
        if(canvas.GetComponent<FillInventory>().buttonType == 1){
            foreach(Item item in inventory.items){
                if(item.itemClass == "food"){
                    list.Add(item);
                }
            }
        }
        else if(canvas.GetComponent<FillInventory>().buttonType == 2){
            foreach(Item item in inventory.items){
                if(item.itemClass == "gift"){
                    list.Add(item);
                }
            }
        }
        anim.Play("Close");
        //disable buttons
        foodButton.enabled = false;
        giftButton.enabled = false;

        if((int) transform.localPosition.x == -757){
            prefab.GetComponent<SpriteRenderer>().sprite = list[0].itemImage;
        }
        else if((int) transform.localPosition.x == -406){
            prefab.GetComponent<SpriteRenderer>().sprite = list[1].itemImage;
        }
        else if((int) transform.localPosition.x == -55){
            prefab.GetComponent<SpriteRenderer>().sprite = list[2].itemImage;
        }
        else if((int) transform.localPosition.x == 295){
            prefab.GetComponent<SpriteRenderer>().sprite = list[3].itemImage;
        }
        else if((int) transform.localPosition.x == 646){
            prefab.GetComponent<SpriteRenderer>().sprite = list[4].itemImage;
        }
        Instantiate(prefab, new Vector3(prefab.GetComponent<Transform>().localPosition.x, prefab.GetComponent<Transform>().localPosition.y, prefab.GetComponent<Transform>().localPosition.z), Quaternion.identity);
        foodButton.enabled = true;
        giftButton.enabled = true;
        //remove it from inventory
        
    }
}
