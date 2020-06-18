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
        // Walk forward
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            this.animator.SetBool("walkForward", true);
        }
        else
        {
            this.animator.SetBool("walkForward", false);
        }

        // Walk backward
        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            this.animator.SetBool("walkBackward", true);
        }
        else
        {
            this.animator.SetBool("walkBackward", false);
        }

        // Run forward
        if (Input.GetKey(KeyCode.Space) && (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W)))
        {
            this.animator.SetBool("runForward", true);
        }
        else
        {
            this.animator.SetBool("runForward", false);
        }

        // Walk forward to left
        if ((Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W)) && (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A)))
        {
            this.transform.Rotate(0.0f, -200 * Time.deltaTime, 0.0f);
        }

        // Walk forward to right
        if ((Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W)) && (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D)))
        {
            this.transform.Rotate(0.0f, 200 * Time.deltaTime, 0.0f);
        }

        // Walk backward to left
        if ((Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S)) && (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A)))
        {
            this.transform.Rotate(0.0f, 200 * Time.deltaTime, 0.0f);
        }

        // Walk backward to right
        if ((Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S)) && (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D)))
        {
            this.transform.Rotate(0.0f, -200 * Time.deltaTime, 0.0f);
        }

        // Left
        if ((Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A)) && !(Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W)) && !(Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S)))
        {
            this.animator.SetBool("leftTurn", true);
            this.transform.Rotate(0.0f, -100 * Time.deltaTime, 0.0f);
        }
        else
        {
            this.animator.SetBool("leftTurn", false);
        }
           
        // Right
        if ((Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D)) && !(Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W)) && !(Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S)))
        {
            this.animator.SetBool("rightTurn", true);
            this.transform.Rotate(0.0f, 100 * Time.deltaTime, 0.0f);
        }
        else
        {
            this.animator.SetBool("rightTurn", false);
        }
    }
}
