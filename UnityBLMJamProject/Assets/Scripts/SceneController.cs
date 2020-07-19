using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//authored by Mason Eastman
public class SceneController : MonoBehaviour
{
    [SerializeField] GameObject startButton;
    [SerializeField] GameObject quitButton;
    [SerializeField] GameObject mainCamera;
    [SerializeField] GameObject credits;

    private Scene currScene;

    private int numClicks;
    // Start is called before the first frame update
    void Start()
    {
        currScene = SceneManager.GetActiveScene();
        numClicks = 0;
    }

    //this makes me cringe really hard but I can't think of a better way to do it
    public void addClick(){
        Debug.Log("Adding click");
        numClicks++;
        if(numClicks == 3 && currScene.buildIndex == 0){
            SceneManager.LoadScene(1);
        }
        if(numClicks == 3 && currScene.buildIndex == 2){
            mainCamera.transform.position = new Vector3(credits.transform.position.x, credits.transform.position.y, mainCamera.transform.position.z);
        }
    }

    public void removeButtons(){
        startButton.SetActive(false);
        quitButton.SetActive(false);
    }

    public void returnToMenu(){
        SceneManager.LoadScene(0);
    }

    public void quitGame(){
        Application.Quit();
    }
}
