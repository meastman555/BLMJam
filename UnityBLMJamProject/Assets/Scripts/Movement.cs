using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//authored by Mason Eastman
public class Movement : MonoBehaviour
{
    [SerializeField] float moveLength;
    [SerializeField] float yLevel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        checkForInput();
        //TODO: check for changes in floor height? Stairs, etc.
    }

    void checkForInput(){
        if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)){
            transform.position = new Vector3(transform.position.x - moveLength, yLevel, transform.position.z);
        }
        if(Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)){
            transform.position = new Vector3(transform.position.x + moveLength, yLevel, transform.position.z);
        }
    }
}
