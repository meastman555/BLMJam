using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ContinueController : MonoBehaviour
{
    public Sprite psyImage;

    private int dialogueNumber;

    public void Advance(){
        dialogueNumber++;
        Debug.Log(dialogueNumber);
        switch(dialogueNumber){
            //TODO add psychiatrist intervention by having case statements trigger that dialogue
            case 5:
                GameObject.Find("StaticKid").gameObject.SetActive(false);
                GameObject.Find("People").transform.Find("InteractableKid").gameObject.SetActive(true);
                break;
            case 6:
                GameObject.Find("InteractableKid").gameObject.SetActive(false);
                GameObject.Find("Psychiatrist").transform.Find("Interlude1").GetComponent<DialogueTrigger>().TriggerDialogue(psyImage, false, null);
                break;
            case 7:
                GameObject.Find("People").transform.Find("InteractableKid2").gameObject.SetActive(true);
                break;
            case 8:
                GameObject.Find("InteractableKid2").gameObject.SetActive(false);
                GameObject.Find("People").transform.Find("InteractableKid3").gameObject.SetActive(true);
                break;
            case 9:
                SceneManager.LoadScene(2);
                break;
            default:
                Debug.Log("Before scripted events or after and a bug lol " + dialogueNumber);
                break;     
        }
    }

    // public void ContinueBranch(string nameOfDialogue){
    //     switch(nameOfDialogue){
    //         case "Static Kid":
    //             GameObject.Find("StaticKid").gameObject.SetActive(false);
    //             GameObject.Find("People").transform.Find("InteractableKid").gameObject.SetActive(true);
    //             break;
    //         default:
    //             break;
    //     }
    // }

    // Start is called before the first frame update
    void Start()
    {
        dialogueNumber = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
