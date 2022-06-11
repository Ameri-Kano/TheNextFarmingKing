using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Behavior : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 5;
    private Rigidbody rigid;

    Animator anim;
    void Start()
    {
        rigid = GetComponent<Rigidbody>();

        anim = GetComponent<Animator>();
        anim.SetBool("oneHandMove", false);
    }

    // Update is called once per frame
    void Update()
    {

    }
    public bool Run(Vector3 targetPos)
    {
        // ?????????????? ???? ???? ???? ?? ?????? ?????? ??????.
        float dis = Vector3.Distance(transform.position, targetPos);

        if (dis >= 2.2f) // ?????? ???? ??????
        {
            // ???????? ??????????.
            transform.position = Vector3.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);
            //SetAnim(PlayerAnim.ANIM_WALK); // ???? ?????????? ????
            //anim.SetBool("oneHandMove", true);
            return true;
        }
        return false;

    }

    public void Turn(Vector3 targetPos)
    {
        // ???????? ?????????? ???? ?????? ???????? ??????????
        Vector3 dir = targetPos - transform.position;
        Vector3 dirXZ = new Vector3(dir.x, 0f, dir.z);
        Quaternion targetRot = Quaternion.LookRotation(dirXZ);
        rigid.rotation = Quaternion.RotateTowards(transform.rotation, targetRot, 550.0f * Time.deltaTime);
    }
}
