using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//authored by Mason Eastman, adapted from a Brackey's Unity youtube tutorial
public class DialogueController : MonoBehaviour
{
    public Text dialogueBox;
    private Queue<string> sentences;
    private GameObject displayDialogue;

    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<string>();
    }

    public void StartDialogue(string[] dialogue, GameObject dialogueUI){
        displayDialogue = dialogueUI;
        sentences.Clear();
        foreach(string sentence in dialogue){
            sentences.Enqueue(sentence);
        }
        DisplayNextSentence();
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
