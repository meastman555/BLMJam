using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//authored by Mason Eastman
public class Interact : MonoBehaviour
{

    [SerializeField] GameObject player;
    [SerializeField] float radius;
    [SerializeField] bool isChoice;
    public string[] choices;
    [SerializeField] GameObject interactButton; 
    public Sprite image;

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
        //checkPlayerPosition();
        if(closeEnough && Input.GetKeyDown(KeyCode.E)){
            trigger.TriggerDialogue(image, isChoice, choices);
        }
    }

    //try and get this working again? for some reason collisions worked but dialogue box didn't 
    // void checkPlayerPosition(){
    //     if(Mathf.Abs(player.transform.position.x - transform.position.x) <= radius){
    //         interactButton.SetActive(true);
    //         closeEnough = true;
    //     }
    //     else{
    //         interactButton.SetActive(false);
    //         closeEnough = false;
    //         trigger.dialogueBox.SetActive(false);
    //     }
    // }

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
