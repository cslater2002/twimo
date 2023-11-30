using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Dialogue{
    [TextArea]
    public List<string> sentences = new List<string>();
    public string color;
}
