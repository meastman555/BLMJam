using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BystanderAnimation : MonoBehaviour
{

    private Animator myAnimator;
    // Start is called before the first frame update
    void Start()
    {
        myAnimator = GetComponent<Animator>();
        myAnimator.Play("BystanderIdle");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
