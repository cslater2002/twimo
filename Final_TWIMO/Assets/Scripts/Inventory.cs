using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

[CreateAssetMenu]
public class Inventory : ScriptableObject
{
    public List<Item> items = new();
    public List<Item> shopSelection = new();
    public int maxItems = 5; 
    public int money;
    public void setShopInventory(){
        System.Random random = new System.Random();
        shopSelection.Clear();
        var lowerBound = 0;
        var upperBound = items.Count;
        for( int i = 0; i < maxItems; i++){
            var randomIndex = random.Next(lowerBound, upperBound);
            shopSelection.Add(items[randomIndex]);
        }
    }
    private void OnEnable() => hideFlags = HideFlags.DontUnloadUnusedAsset;
}



