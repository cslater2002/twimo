using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FillInventory : MonoBehaviour
{
    [SerializeField] GameObject item1;
    [SerializeField] GameObject item2;
    [SerializeField] GameObject item3;
    [SerializeField] GameObject item4;
    [SerializeField] GameObject item5;
    [SerializeField] int slots = 5;
    public Inventory inventory;
    public int buttonType = 0;

    public void FillMiniFoodInventory(){
        buttonType = 1;
        var items = new List<GameObject> {item1, item2, item3, item4, item5};
        for(int i = 0; i < items.Count; i++){
            items[i].GetComponent<SpriteRenderer>().sprite = null;
        }
        int invInc = 0;
        for(int i = 0; i < slots; i++){
            if(i < inventory.items.Count && string.Compare(inventory.items[i].itemClass, "food") == 0 && inventory.items[i].quantityOwned > 0){
                items[invInc].GetComponent<SpriteRenderer>().sprite = inventory.items[i].itemImage; 
                invInc++;
            }
        }
    }
    public void FillMiniGiftInventory(){
        buttonType = 2;
        var items = new List<GameObject> {item1, item2, item3, item4, item5};
        for(int i = 0; i < items.Count; i++){
            items[i].GetComponent<SpriteRenderer>().sprite = null;
        }
        int invInc = 0;
        for(int i = 0; i < slots; i++){
            if(i < inventory.items.Count){
                if(string.Compare(inventory.items[i].itemClass, "gift") == 0  && inventory.items[i].quantityOwned > 0){
                    items[invInc].GetComponent<SpriteRenderer>().sprite = inventory.items[i].itemImage; 
                    invInc++;
                }
            }
        }
    }

}
