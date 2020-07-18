using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChoiceContoller : MonoBehaviour
{

    public GameObject TextBox;
    public GameObject Choice1;
    public GameObject Choice2;
    private int choice;
    private string[] scenarios;

    void Start(){
        scenarios = new string[]{"Make conversation with the patron.", "Ask the kid what they're looking for."};
    }

    public void ChoseOption1(){
        string option = Choice1.transform.Find("Text").GetComponent<Text>().text;
        if(option.Equals(scenarios[0])){
            GameObject.Find("ThirstyPatron").GetComponent<DialogueTrigger>().TriggerDialogue();
        }
    }

    public void ChoseOption2(){
        string option = Choice2.transform.Find("Text").GetComponent<Text>().text;
        if(option.Equals(scenarios[1])){
            GameObject.Find("Kid").GetComponent<DialogueTrigger>().TriggerDialogue();
            Debug.Log("activating game object");
            GameObject.Find("InteractableObjects").transform.Find("Medicine").gameObject.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(choice >= 1){
            Choice1.SetActive(false);
            Choice2.SetActive(false);
        }
    }
}
