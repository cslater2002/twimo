using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BuyFish : MonoBehaviour
{
    [SerializeField] DialogueTrigger trigger;
    [SerializeField] Animator anim;
    [SerializeField] Image image;
    public Inventory inventory;
    public FishStats stats;

    void OnTriggerEnter2D(Collider2D other){
        if(stats.unlockedToday){
            trigger.dialogue.sentences.Add("come back next");
            trigger.dialogue.sentences.Add("week okay?");
            trigger.TriggerDialogue();
        }
        else{
            int fishIndex = -1;
            for(int i=0; i<stats.list.Count;i++){
                if(stats.list[i].isUnlocked == 0){
                    fishIndex = i;
                    break;
                }
            }
            image.sprite = stats.list[fishIndex].fishImage;
            anim.Play("FishShopUp");
            string sentence = "It's $" + stats.list[fishIndex].cost;
            trigger.dialogue.sentences.Add(sentence);
            trigger.TriggerDialogue();
        }
    }

    void OnTriggerExit2D(Collider2D other){
        anim.Play("FishShopDown");
        trigger.dialogue.sentences.Add("bye bye");
        trigger.TriggerDialogue();
        
    }

    public void PurchaseFish(){
        int fishIndex = -1;
        for(int i=0; i<stats.list.Count;i++){
            if(stats.list[i].isUnlocked == 0){
                fishIndex = i;
                break;
            }
        }
        if(inventory.money >= stats.list[fishIndex].cost){
            inventory.money -= stats.list[fishIndex].cost;
           inventory.checkAfterDecrease();
            stats.list[fishIndex].isUnlocked = 1;
            stats.unlockedToday = true;
            trigger.dialogue.sentences.Clear();
            trigger.dialogue.sentences.Add("thank you :)");
            trigger.TriggerDialogue();
            anim.Play("FishShopDown");
        }
        else{
            anim.Play("FishShopDown");
            trigger.dialogue.sentences.Clear();
            trigger.dialogue.sentences.Add("you dont have");
            trigger.dialogue.sentences.Add("enough money!!!");
            trigger.TriggerDialogue();
        }
    }

    public void RejectPurchase(){
            trigger.dialogue.sentences.Add("...");
            trigger.TriggerDialogue();
        anim.Play("FishShopDown");
    }
}
