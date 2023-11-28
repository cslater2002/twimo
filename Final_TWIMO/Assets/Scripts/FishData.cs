using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class FishData : ScriptableObject{
    [TextArea]
    public string fishName;
    public Sprite fishImage;
    public int happiness;
    public int hunger;
    public Color color;
    public int level;
    public int levelProgress;
    public int health;

    private void OnEnable() => hideFlags = HideFlags.DontUnloadUnusedAsset;

    public void incrementHunger(){
        if(this.hunger < 10){
            this.hunger = this.hunger + 1;
        }
    }
    public void decrementHunger(){
        if(this.hunger > 0){
             this.hunger = this.hunger - 1;
         }
     }
     public void incrementHappiness(){
        if(this.happiness < 10){
         this.happiness = this.happiness + 1;
        }
    }
    public void decrementHappiness(){
        if(this.happiness > 0){
             this.happiness = this.happiness - 1;
         }
     }
}
