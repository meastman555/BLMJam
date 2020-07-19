using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//authored by Mason Eastman, adapted from a Brackey's Unity youtube tutorial
public class DialogueTrigger : MonoBehaviour
{
    [TextArea(3,5)]
    public string[] sentences;
    public GameObject dialogueBox;

    //used for "cinematic" dialogue -- no pictures, no choice
    public void TriggerDialogue(){
        dialogueBox.SetActive(true);
        FindObjectOfType<DialogueController>().StartDialogue(sentences, dialogueBox);
    }

    //used for "interactive" dialogue -- picture and possible choice
    public void TriggerDialogue(Sprite image, bool isChoice, string[] choices){
        dialogueBox.SetActive(true);
        FindObjectOfType<DialogueController>().StartDialogue(sentences, dialogueBox, image, isChoice, choices);
    }
}
