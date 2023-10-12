using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu]
public class Inventory : ScriptableObject
{
    
    public List<Item> items = new();
    public int maxItems = 5; 

    public bool AddItem(Item itemToAdd)
    {
        for (int i = 0; i < items.Count; i++)
        {
            if (items[i] == null)
            {
                items[i] = itemToAdd;
                return true;
            }
        }
        if (items.Count < maxItems)
        {
            items.Add(itemToAdd);
            return true;
        }
        Debug.Log("No space in the inventory");
        return false;
    }
}



