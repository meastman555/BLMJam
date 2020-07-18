using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//authored by Mason Eastman, adapted from a Brackey's Unity youtube tutorial
public class DialogueController : MonoBehaviour
{
    public Text dialogueBox;
    public Image imageBox;
    private Queue<string> sentences;
    private GameObject displayDialogue;

    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<string>();
    }

    //used for "cinematic" dialogue
     public void StartDialogue(string[] dialogue, GameObject dialogueUI){
        displayDialogue = dialogueUI;
        loadSentences(dialogue);
        DisplayNextSentence();
    }

    //used for "interactive" dialogue
    public void StartDialogue(string[] dialogue, GameObject dialogueUI, Sprite image, bool isChoice, string[] choices){
        imageBox.sprite = image;
        displayDialogue = dialogueUI;
        loadChoices(isChoice, choices);
        loadSentences(dialogue);
        DisplayNextSentence();
    }

    private void loadChoices(bool isChoice, string[] choices){
        GameObject.Find("DialogueBox").transform.Find("Choice1").gameObject.SetActive(isChoice);
        GameObject.Find("DialogueBox").transform.Find("Choice2").gameObject.SetActive(isChoice);
        GameObject.Find("DialogueBox").transform.Find("Continue").gameObject.SetActive(!isChoice);
        if(isChoice){
            GameObject.Find("Choice1").transform.Find("Text").gameObject.GetComponent<Text>().text = choices[0];   
            GameObject.Find("Choice2").transform.Find("Text").gameObject.GetComponent<Text>().text = choices[1];   
        }
    }

    private void loadSentences(string[] dialogue){
        sentences.Clear();
        foreach(string sentence in dialogue){
            sentences.Enqueue(sentence);
        }
    }

    public void DisplayNextSentence(){
        if(sentences.Count != 0){
            dialogueBox.text = sentences.Dequeue();
        }
        else{
            displayDialogue.SetActive(false);
        }
    }
}
