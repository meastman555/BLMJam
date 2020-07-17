using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//authored by Mason Eastman, adapted from a Brackey's Unity youtube tutorial
public class DialogueTrigger : MonoBehaviour
{
    [TextArea(3,5)]
    public string[] sentences;
    public GameObject dialogueBox;


    void Start(){
        dialogueBox.SetActive(false);
    }

    public void TriggerDialogue(){
        dialogueBox.SetActive(true);
        FindObjectOfType<DialogueController>().StartDialogue(sentences, dialogueBox);
    }
}
