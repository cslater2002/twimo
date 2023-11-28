using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu]
public class Day : ScriptableObject{
    public int dayIndex;

     private void OnEnable() => hideFlags = HideFlags.DontUnloadUnusedAsset;
}
