using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
            foreach(FishData fish in stats.list){
                moneyEarned += fish.happiness;
                moneyEarned += fish.hunger;
            }
            inventory.money += moneyEarned;
            character.position = new Vector3(character.position.x + 1.5f, character.position.y, character.position.z);
            overlay.GetComponent<Image>().color = new Color(overlay.color.r, overlay.color.g, overlay.color.b, 0);
            d.UpdateDay();  
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
