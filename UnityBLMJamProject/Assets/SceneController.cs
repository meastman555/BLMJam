using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//authored by Mason Eastman
public class SceneController : MonoBehaviour
{

    private int numClicks;
    // Start is called before the first frame update
    void Start()
    {
        numClicks = 0;
    }

    //this makes me cringe really hard but I can't think of a better way to do it
    public void addClick(){
        numClicks++;
        if(numClicks == 3){
            SceneManager.LoadScene("Bodega");
        }
    }

    public void quitGame(){
        Application.Quit();
    }

    public void showCredits(){
        //TODO transform over to credits splash screen
    }

    public void returnToMenu(){
        //TODO transform back to the main menu
    }


}
