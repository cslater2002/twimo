using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class FishStats : ScriptableObject{
    public List<FishData> list = new List<FishData>();
    public int currentIndex;
}
