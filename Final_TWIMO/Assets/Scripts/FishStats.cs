using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class FishStats : ScriptableObject{
    
    public List<FishData> list = new List<FishData>();
    public int currentIndex;
    public bool unlockedToday = false;

    private void OnEnable() => hideFlags = HideFlags.DontUnloadUnusedAsset;
}
