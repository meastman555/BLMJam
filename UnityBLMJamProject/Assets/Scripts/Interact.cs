using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//authored by Mason Eastman
public class Interact : MonoBehaviour
{

    [SerializeField] GameObject interactButton; 

    private DialogueTrigger trigger;
    private bool closeEnough;
    // Start is called before the first frame update
    void Start()
    {
        trigger = GetComponent<DialogueTrigger>();
        interactButton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(closeEnough && Input.GetKey(KeyCode.E)){
            trigger.TriggerDialogue();
        }
    }

    void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.tag.Equals("Player")){
            interactButton.SetActive(true);
            closeEnough = true;
        }
    }

    void OnCollisionExit2D(Collision2D collision){
        if(collision.gameObject.tag.Equals("Player")){
            interactButton.SetActive(false);
            closeEnough = false;
            trigger.dialogueBox.SetActive(false);
        }
    }
}
