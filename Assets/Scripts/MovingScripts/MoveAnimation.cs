using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAnimation : MonoBehaviour
{
    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        anim.SetBool("w", false);
        anim.SetBool("s", false);
        anim.SetBool("a", false);
        anim.SetBool("d", false);

    }

    // Update is called once per frame
    void Update()
    {
        // move forward
        if (Input.GetKey(KeyCode.W))
        {
            anim.SetBool("w", true);
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            anim.SetBool("w", false);
        }
        // move backward
        if (Input.GetKey(KeyCode.S))
        {
            anim.SetBool("s", true);
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            anim.SetBool("s", false);
        }
        // move left
        if (Input.GetKey(KeyCode.A))
        {
            anim.SetBool("a", true);
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            anim.SetBool("a", false);
        }
        // move right
        if (Input.GetKey(KeyCode.D))
        {
            anim.SetBool("d", true);
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            anim.SetBool("d", false);
        }
    }
}
