using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu]
public class SetLocation : ScriptableObject{
    public string prevLocationName;
    public int canGo = 0;

    private void OnEnable() => hideFlags = HideFlags.DontUnloadUnusedAsset;
}
