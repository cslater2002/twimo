using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
public class Sleep : MonoBehaviour
{
    
    [SerializeField] Image overlay;
    [SerializeField] Transform character;
    [SerializeField] bool sleeping = false;
    [SerializeField] int moneyEarned = 0;
    [SerializeField] DialogueTrigger trigger;
    public FishStats stats;
    [SerializeField] DayHandler d;
    public Inventory inventory;

    
    public void OnTriggerEnter2D(Collider2D other){
        trigger.TriggerDialogue();
        sleeping = true;
    }

    public void OnTriggerExit2D(){
        sleeping = false;
    }

    void Update(){
        if(overlay.GetComponent<Image>().color.a > 2){
            System.Random rand = new System.Random();
            foreach(FishData fish in stats.list){
                if(fish.isUnlocked == 1){
                    moneyEarned += (fish.happiness * fish.level);
                    fish.levelProgress += (fish.happiness * fish.level);
                    if(fish.levelProgress >= (10 * fish.level)){
                        fish.level++;
                        fish.levelProgress = (fish.levelProgress - (10 * fish.level));
                    }
                    if(fish.happiness <= 5 || fish.hunger <= 5){
                        fish.health -= rand.Next(1, 4);
                        if(fish.health < 5){
                            fish.happiness--;
                        }
                    }
                    if(fish.happiness == 10 && fish.hunger == 10){
                        fish.health++;
                    }
                    fish.happiness -= rand.Next(0,3);
                    fish.hunger -= rand.Next(1,4);
                }
            }
            inventory.money += moneyEarned;
            character.position = new Vector3(character.position.x + 1.5f, character.position.y, character.position.z);
            overlay.GetComponent<Image>().color = new Color(overlay.color.r, overlay.color.g, overlay.color.b, 0);
            d.UpdateDay();  
            if(d.dayIndex.dayIndex == 4){
                inventory.money -= 100;
            }
            inventory.setShopInventory(); 
            sleeping = false;
            character.gameObject.GetComponent<DialogueTrigger>().TriggerDialogue();
        }
        if(sleeping == true){
            overlay.GetComponent<Image>().color = new Color(overlay.color.r, overlay.color.g, overlay.color.b, overlay.color.a + (1 * Time.deltaTime));
        }
        if(sleeping == false && overlay.GetComponent<Image>().color.a != 0){
            overlay.GetComponent<Image>().color = new Color(overlay.color.r, overlay.color.g, overlay.color.b, overlay.color.a - (1 * Time.deltaTime));
        }

    }
}
