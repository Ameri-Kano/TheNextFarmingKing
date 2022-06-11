using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{

    private Behavior behavior; // ???????? ???? ????????
    private Camera mainCamera; // ???? ??????
    private Vector3 targetPos = new Vector3(17.6700001f, 5, -11.6499996f);// ???????? ???? ???? ????

    public Camera playerPerspective;

    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        behavior = GetComponent<Behavior>();
        //mainCamera = GameObject.Find("Main Camera").GetComponent<Camera>();

        anim = GetComponent<Animator>();
        anim.SetBool("oneHandMove", false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonUp(1))
        {
            // ???????? ???? ?????? ???? ???? ????????
            //Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
            Ray ray = playerPerspective.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                targetPos = hit.point;
            }
        }
        // Debug.Log(targetPos);
        // ???????? ???????? ??????
        if (behavior.Run(targetPos))
        {
            // ?????? ???? ????????
            behavior.Turn(targetPos);
            anim.SetBool("oneHandMove", true);
        }
        else
        {
            // ?????? ??????????(???? ????)
            //behavior.SetAnim(PlayerAnim.ANIM_IDLE);
            anim.SetBool("oneHandMove", false);
        }
    }
}
