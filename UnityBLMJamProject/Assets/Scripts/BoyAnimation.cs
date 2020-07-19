using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoyAnimation : MonoBehaviour
{

    private Animator myAnimator;
    // Start is called before the first frame update
    void Start()
    {
        myAnimator = GetComponent<Animator>();
        myAnimator.Play("BoyIdle");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
