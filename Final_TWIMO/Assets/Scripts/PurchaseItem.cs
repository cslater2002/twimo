using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurchaseItem : MonoBehaviour
{
    public Inventory inventory;
    
    public void PurchaseSelectedItem(){
        if((int) transform.localPosition.x == -757){
            if(inventory.money < inventory.shopSelection[0].itemCost){
                return;
            }
           inventory.shopSelection[0].incrementQuantity();
           inventory.money -= inventory.shopSelection[0].itemCost;
        }
        else if((int) transform.localPosition.x == -406){
            if(inventory.money < inventory.shopSelection[1].itemCost){
                return;
            }
            inventory.shopSelection[1].incrementQuantity();
           inventory.money -= inventory.shopSelection[1].itemCost;
        }
        else if((int) transform.localPosition.x == -55){
            if(inventory.money < inventory.shopSelection[2].itemCost){
                return;
            }
            inventory.shopSelection[2].incrementQuantity();
           inventory.money -= inventory.shopSelection[2].itemCost;
        }
        else if((int) transform.localPosition.x == 295){
            if(inventory.money < inventory.shopSelection[3].itemCost){
                return;
            }
            inventory.shopSelection[3].incrementQuantity();
           inventory.money -= inventory.shopSelection[3].itemCost;
        }
        else if((int) transform.localPosition.x == 646){
            if(inventory.money < inventory.shopSelection[4].itemCost){
                return;
            }
           inventory.shopSelection[4].incrementQuantity();
           inventory.money -= inventory.shopSelection[4].itemCost;
        }
    }
}
