using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviourScript : MonoBehaviour
{
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        this.animator = this.gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.UpArrow))
        {
            this.animator.SetBool("walkForward", true);
        }
        else
        {
            this.animator.SetBool("walkForward", false);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            this.animator.SetBool("walkBackward", true);
        }
        else
        {
            this.animator.SetBool("walkBackward", false);
        }
    }
}
