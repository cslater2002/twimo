using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DialogueHandler : MonoBehaviour
{
    // Start is called before the first frame update
    public static DialogueHandler singleton;
    private Queue<string> sentences;
    [SerializeField] Text dialogueText;

    void Awake(){
        if(singleton == null){
            singleton = this;
        }
        else{
            Destroy(this.gameObject);
        }
    }

    void Start()
    {
        sentences = new Queue<string>();
    }

    // Update is called once per frame
    public void StartDialogue(Dialogue dialogue){
        //Debug.Log("start");
        sentences.Clear();
        foreach(string sentence in dialogue.sentences){
            sentences.Enqueue(sentence);
        }
        DisplayNextSentence(dialogue.color);
    }

    public void DisplayNextSentence(string color){
        if(sentences.Count==0){
            EndDialogue();
            return;
        }
        string sentence = sentences.Dequeue();
        StartCoroutine(TypeSentence(sentence, color));
    }
    IEnumerator TypeSentence(string sentence, string color){
        dialogueText.text = "";
        foreach(char letter in sentence.ToCharArray()){
            dialogueText.text += "<color=#"+color+">"+letter+"</color>";
            yield return new WaitForSeconds(0.05f);
        }
        dialogueText.text += "\n";
    }
    void EndDialogue(){
        //Debug.Log("done");
    }
    public void ClearDialogue(){
        dialogueText.text = "";
    }
}
