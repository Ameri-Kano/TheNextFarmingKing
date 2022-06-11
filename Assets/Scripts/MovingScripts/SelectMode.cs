using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectMode : MonoBehaviour
{
    // Start is called before the first frame update
    public static int mode = 1;
    void Start()
    {
        if (mode == 1)
        {
            gameObject.GetComponent<PlayerMove>().enabled = true;
            gameObject.GetComponent<HoldAndClick>().enabled = true;


        }
        else if (mode == 2)
        {
            gameObject.GetComponent<Control>().enabled = true;
            gameObject.GetComponent<Behavior>().enabled = true;
            gameObject.GetComponent<HoldAndClickMouse>().enabled = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (mode == 1)
        {
            gameObject.GetComponent<PlayerMove>().enabled = true;
            gameObject.GetComponent<HoldAndClick>().enabled = true;
        }
        else if (mode == 2)
        {
            gameObject.GetComponent<Control>().enabled = true;
            gameObject.GetComponent<Behavior>().enabled = true;
            gameObject.GetComponent<HoldAndClickMouse>().enabled = true;
        }
    }
}
