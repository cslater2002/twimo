using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public Dialogue dialogue;

    public void TriggerDialogue(){
        //replace with singleton?
        DialogueHandler.singleton.StartDialogue(dialogue);
        //FindObjectOfType<DialogueHandler>().StartDialogue(dialogue);
    }
}
