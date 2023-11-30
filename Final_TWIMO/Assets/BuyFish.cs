using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyFish : MonoBehaviour
{
    [SerializeField] DialogueTrigger trigger;
    void OnTriggerEnter2D(Collider2D other){
        //ui menu appear
        string sentence = "It's $100";
        trigger.dialogue.sentences.Add(sentence);
        trigger.TriggerDialogue();
    }
}
