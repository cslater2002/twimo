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
    public int isUnlocked;
    public int cost;
    public Dialogue dialogue;

    private void OnEnable() => hideFlags = HideFlags.DontUnloadUnusedAsset;


    public void checkAfterDecrease(){
        if(this.hunger < 0){
            this.hunger = 0;
        }
        if(this.happiness < 0){
            this.happiness = 0;
        }
        if(this.health < 0){
            this.health = 0;
        }
    }
    public void checkAfterIncrease(){
        if(this.hunger > 10){
            this.hunger = 10;
        }
        if(this.happiness > 10){
            this.happiness = 10;
        }
        if(this.health > 10){
            this.health = 10;
        }
    }
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
