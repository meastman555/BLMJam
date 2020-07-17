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


    public void ChoseOption1(){
        TextBox.GetComponent<Text>().text = "You chose option 1.";
        choice = 1;
    }

    public void ChoseOption2(){
        TextBox.GetComponent<Text>().text = "You chose option 2.";
        choice = 2;
    }

    // Start is called before the first frame update
    void Start()
    {
        
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
