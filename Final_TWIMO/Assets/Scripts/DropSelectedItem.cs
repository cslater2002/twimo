using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DropSelectedItem : MonoBehaviour
{
    [SerializeField] Animator anim;
    [SerializeField] GameObject prefab;
    [SerializeField] Button foodButton;
    [SerializeField] Button giftButton;
    [SerializeField] Image canvas;
    public Inventory inventory;
    public FishStats stats;
    public int index;
    
    public void DropItem(){
        index = stats.currentIndex;
        List<Item> list = new List<Item>();
        if(canvas.GetComponent<FillInventory>().buttonType == 1){
            foreach(Item item in inventory.items){
                if(item.itemClass == "food" && item.quantityOwned > 0){
                    list.Add(item);
                    stats.list[index].incrementHunger();
                }
            }
        }
        else if(canvas.GetComponent<FillInventory>().buttonType == 2){
            foreach(Item item in inventory.items){
                if(item.itemClass == "gift" && item.quantityOwned > 0){
                    list.Add(item);
                    stats.list[index].incrementHappiness();
                }
            }
        }
        anim.Play("Close");
        foodButton.enabled = false;
        giftButton.enabled = false;

        if((int) transform.localPosition.x == -757){
                prefab.GetComponent<SpriteRenderer>().sprite = list[0].itemImage;
                list[0].decrementQuantity();
        }
        else if((int) transform.localPosition.x == -406){
                prefab.GetComponent<SpriteRenderer>().sprite = list[1].itemImage;
                list[1].decrementQuantity();
        }
        else if((int) transform.localPosition.x == -55){
                prefab.GetComponent<SpriteRenderer>().sprite = list[2].itemImage;
                list[2].decrementQuantity();
        }
        else if((int) transform.localPosition.x == 295){
                prefab.GetComponent<SpriteRenderer>().sprite = list[3].itemImage;
                list[3].decrementQuantity();
        }
        else if((int) transform.localPosition.x == 646){
                prefab.GetComponent<SpriteRenderer>().sprite = list[4].itemImage;
                list[4].decrementQuantity();
        }
        Instantiate(prefab, new Vector3(prefab.GetComponent<Transform>().localPosition.x, prefab.GetComponent<Transform>().localPosition.y, prefab.GetComponent<Transform>().localPosition.z), Quaternion.identity);
        foodButton.enabled = true;
        giftButton.enabled = true;
    }
}
