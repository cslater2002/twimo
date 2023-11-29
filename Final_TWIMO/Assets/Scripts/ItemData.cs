using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu]
public class Item : ScriptableObject{
    public string itemName;
    [TextArea]
    public string itemDesc;
    public Sprite itemImage;
    public string itemClass;
    public int quantityOwned;
    public int itemCost;
    public int satiation;

    public void incrementQuantity(){
         this.quantityOwned = this.quantityOwned + 1;
    }
    public void decrementQuantity(){
        if(this.quantityOwned != 0){
             this.quantityOwned = this.quantityOwned - 1;
         }
     }

     private void OnEnable() => hideFlags = HideFlags.DontUnloadUnusedAsset;
}

