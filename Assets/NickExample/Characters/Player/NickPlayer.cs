using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NickPlayer : MonoBehaviour
{
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // this is BAD and needs to be improved

        //get input
        // look left
        if (Input.GetAxis("Horizontal") < 0)
        {
            animator.SetBool("Left", true);
        }
        // look right
        else if (Input.GetAxis("Horizontal") > 0)
        {
            animator.SetBool("Right", true);
        }
        // reset
        else
        {
            animator.SetBool("Right", false);
            animator.SetBool("Left", false);
        }

        //look up/down
        if (Input.GetAxis("Vertical") < 0)
        {
            animator.SetBool("Down", true);
        }
        else if (Input.GetAxis("Vertical") > 0)
        {
            animator.SetBool("Up", true);
        }
        else
        {
            animator.SetBool("Down", false);
            animator.SetBool("Up", false);
        }
    }
}
