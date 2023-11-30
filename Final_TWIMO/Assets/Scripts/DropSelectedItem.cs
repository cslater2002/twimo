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
    public Sprite image;
    public DialogueTrigger trigger;

    public void DropItem(){
        index = stats.currentIndex;
        List<Item> items = new List<Item>();
        if(canvas.GetComponent<FillInventory>().buttonType == 1){
            trigger.dialogue.sentences.Add("yummy");
            trigger.dialogue.sentences.Add("i love to eat!!!");
            trigger.TriggerDialogue();
            foreach(Item item in inventory.items){
                if(item.itemClass == "food" && item.quantityOwned > 0){
                    items.Add(item);
                }
            }
        }
        else if(canvas.GetComponent<FillInventory>().buttonType == 2){
            trigger.dialogue.sentences.Add("for me?");
            trigger.dialogue.sentences.Add("im so happy...");
            trigger.TriggerDialogue();
            foreach(Item item in inventory.items){
                if(item.itemClass == "gift" && item.quantityOwned > 0){
                    items.Add(item);
                }
            }
        }
        anim.Play("Close");
        foodButton.enabled = false;
        giftButton.enabled = false;

        if((int) transform.localPosition.x == -757){
                prefab.GetComponent<SpriteRenderer>().sprite = items[0].itemImage;
                items[0].decrementQuantity();
                if(canvas.GetComponent<FillInventory>().buttonType == 1){
                    stats.list[index].hunger +=  items[0].satiation;
                }
                else{
                    stats.list[index].happiness +=  items[0].satiation;
                }
        }
        else if((int) transform.localPosition.x == -407){
                prefab.GetComponent<SpriteRenderer>().sprite = items[1].itemImage;
                items[1].decrementQuantity();
                if(canvas.GetComponent<FillInventory>().buttonType == 1){
                    stats.list[index].hunger +=  items[1].satiation;
                }
                else{
                    stats.list[index].happiness +=  items[1].satiation;
                }
        }
        else if((int) transform.localPosition.x == -58){
                prefab.GetComponent<SpriteRenderer>().sprite = items[2].itemImage;
                items[2].decrementQuantity();
                if(canvas.GetComponent<FillInventory>().buttonType == 1){
                    stats.list[index].hunger +=  items[2].satiation;
                }
                else{
                    stats.list[index].happiness +=  items[2].satiation;
                }
        }
        else if((int) transform.localPosition.x == 291){
                prefab.GetComponent<SpriteRenderer>().sprite = items[3].itemImage;
                items[3].decrementQuantity();
                if(canvas.GetComponent<FillInventory>().buttonType == 1){
                    stats.list[index].hunger +=  items[3].satiation;
                }
                else{
                    stats.list[index].happiness +=  items[3].satiation;
                }
        }
        else if((int) transform.localPosition.x == 640){
                prefab.GetComponent<SpriteRenderer>().sprite = items[4].itemImage;
                items[4].decrementQuantity();
                if(canvas.GetComponent<FillInventory>().buttonType == 1){
                    stats.list[index].hunger +=  items[4].satiation;
                }
                else{
                    stats.list[index].happiness += items[4].satiation;
                }
        }
        stats.list[index].checkAfterIncrease();
        Instantiate(prefab, new Vector3(prefab.GetComponent<Transform>().localPosition.x, prefab.GetComponent<Transform>().localPosition.y, prefab.GetComponent<Transform>().localPosition.z), Quaternion.identity);
        foodButton.enabled = true;
        giftButton.enabled = true;
    }
}
