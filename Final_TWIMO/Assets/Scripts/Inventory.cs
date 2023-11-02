using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu]
public class Inventory : ScriptableObject
{
    public List<Item> items = new();
    public List<Item> shopSelection = new();
    public int maxItems = 5; 
    public int money;

    private void OnEnable() => hideFlags = HideFlags.DontUnloadUnusedAsset;
}



