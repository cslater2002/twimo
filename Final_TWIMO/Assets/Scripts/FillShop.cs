using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FillShop : MonoBehaviour
{
    [SerializeField] GameObject item1;
    [SerializeField] GameObject item2;
    [SerializeField] GameObject item3;
    [SerializeField] GameObject item4;
    [SerializeField] GameObject item5;
    public Inventory inventory;
    [SerializeField] DialogueTrigger trigger;
    
    void Start()
    {
        var list = new List<GameObject> {item1, item2, item3, item4, item5};
        int shopIndex = 0;
        foreach(GameObject item in list){
            item.GetComponent<SpriteRenderer>().sprite = inventory.shopSelection[shopIndex].itemImage; 
            item.transform.GetChild(0).gameObject.GetComponent<Text>().text = "$" + inventory.shopSelection[shopIndex].itemCost;
            shopIndex++;
        }
    }

}
