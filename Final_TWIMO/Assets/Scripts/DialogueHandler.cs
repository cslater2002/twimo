using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System;
using System.Linq;
public class DialogueHandler : MonoBehaviour
{
    // Start is called before the first frame update
    public static DialogueHandler singleton;
    private Queue<string> sentences;
    private Dictionary<Text,int> textBoxes;
    public int currentIndex = 0;
    [SerializeField] Text dialogueText1;
    [SerializeField] Text dialogueText2;
    [SerializeField] Text dialogueText3;
    [SerializeField] Text dialogueText4;
    [SerializeField] Text dialogueText5;
    [SerializeField] Text dialogueText6;
    [SerializeField] Text dialogueText7;
    [SerializeField] Text dialogueText8;
    [SerializeField] Text dialogueText9;
    [SerializeField] Text dialogueText10;
    [SerializeField] Text dialogueText11;
    [SerializeField] Text dialogueText12;
    [SerializeField] Text dialogueText13;
    [SerializeField] Text dialogueText14;
    [SerializeField] Text dialogueText15;
    [SerializeField] Text dialogueText16;
    [SerializeField] Text dialogueText17;
    [SerializeField] Text dialogueText18;
    [SerializeField] Text dialogueText19;
    [SerializeField] Text dialogueText20;
    [SerializeField] Text dialogueText21;
    [SerializeField] Text dialogueText22;
    [SerializeField] Text dialogueText23;
    [SerializeField] Text dialogueText24;
    [SerializeField] Text dialogueText25;
    [SerializeField] Text dialogueText26;
    [SerializeField] Scrollbar scrollbar;
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
        textBoxes = new Dictionary<Text, int>();
        textBoxes.Add(dialogueText1,0);
        textBoxes.Add(dialogueText2,0);
        textBoxes.Add(dialogueText3,0);
        textBoxes.Add(dialogueText4,0);
        textBoxes.Add(dialogueText5,0);
        textBoxes.Add(dialogueText6,0);
        textBoxes.Add(dialogueText7,0);
        textBoxes.Add(dialogueText8,0);
        textBoxes.Add(dialogueText9,0);
        textBoxes.Add(dialogueText10,0);
        textBoxes.Add(dialogueText11,0);
        textBoxes.Add(dialogueText12,0);
        textBoxes.Add(dialogueText13,0);
        textBoxes.Add(dialogueText14,0);
        textBoxes.Add(dialogueText15,0);
        textBoxes.Add(dialogueText16,0);
        textBoxes.Add(dialogueText17,0);
        textBoxes.Add(dialogueText18,0);
        textBoxes.Add(dialogueText19,0);
        textBoxes.Add(dialogueText20,0);
        textBoxes.Add(dialogueText21,0);
        textBoxes.Add(dialogueText22,0);
        textBoxes.Add(dialogueText23,0);
        textBoxes.Add(dialogueText24,0);
        textBoxes.Add(dialogueText25,0);
        textBoxes.Add(dialogueText26,0);
    }

    public void StartDialogue(Dialogue dialogue){
        
        foreach(string sentence in dialogue.sentences){
            sentences.Enqueue(sentence);
        }
        DisplayNextSentence(dialogue.color);
    }

    public void DisplayNextSentence(string color){
        if(sentences.Count == 0){
            return;
        }
        string sentence = sentences.Dequeue();
        StartCoroutine(TypeSentence(sentence, color));
    }
    IEnumerator TypeSentence(string sentence, string color){
        if(currentIndex >= 26){ // if all the text fields are full use field 0
            currentIndex = 0;
        }
        // this is so  if there is another dialogue triggered before this one
        // is finished typing it can go in the next box instead of in this one
        int index = currentIndex;
        currentIndex++; 

        // 0 = is empty, needs to be activated
        // 1 = has already been used, must be set as last sibling
        if(textBoxes[textBoxes.ElementAt(index).Key] == 0){
            textBoxes.ElementAt(index).Key.gameObject.SetActive(true);
            textBoxes[textBoxes.ElementAt(index).Key] = 1;
        }
        else{
            textBoxes.ElementAt(index).Key.transform.SetAsLastSibling();
        }
        textBoxes.ElementAt(index).Key.text = "";

        //entering letter by letter gives a typewriter effect
        foreach(char letter in sentence.ToCharArray()){
            scrollbar.value = 0; //otherwise the scrollbar keeps going up
            textBoxes.ElementAt(index).Key.text += "<color=#"+color+">"+letter+"</color>";
            yield return new WaitForSeconds(0.05f);
        }
        yield return new WaitForSeconds(5);
        DisplayNextSentence(color);
    }
}
