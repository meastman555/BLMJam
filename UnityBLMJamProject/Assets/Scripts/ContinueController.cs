using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ContinueController : MonoBehaviour
{

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
                GameObject.Find("People").transform.Find("InteractableKid2").gameObject.SetActive(true);
                break;
            case 7:
                GameObject.Find("InteractableKid2").gameObject.SetActive(false);
                GameObject.Find("People").transform.Find("InteractableKid3").gameObject.SetActive(true);
                break;
            case 8:
                SceneManager.LoadScene(2);
                break;
            default:
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
