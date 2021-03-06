using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirtstPersonCam : MonoBehaviour
{
    GameObject player;
    GameObject head;
    public Camera playerPerspective;
    float turnSpeed;
    float xRotate = 0;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        head = GameObject.Find("Head_M");
        turnSpeed = 3;
    }

    // Update is called once per frame
    void Update()
    {


        //playerPerspective.transform.position = transform.position;

        // ?????? ?????? ???????? ?????? * ?????? ???? ???????? ?????? ?????? ?? ????
        float yRotateSize = Input.GetAxis("Mouse X") * turnSpeed;
        // ???? y?? ???????? ???? ?????? ???????? ????
        float yRotate = transform.eulerAngles.y + yRotateSize;

        // ???????? ?????? ???????? ?????? * ?????? ???? ???????? ?????? ?? ????(????, ?????? ???????? ????)
        float xRotateSize = -Input.GetAxis("Mouse Y") * turnSpeed;
        // ?????? ???????? ?????????? -45?? ~ 80???? ???? (-45:????????, 80:????????)
        // Clamp ?? ???? ?????? ???????? ????
        xRotate = Mathf.Clamp(xRotate + xRotateSize, -45, 80);

        // ?????? ???????? ???????? ????(X, Y???? ????)
        //transform.eulerAngles = new Vector3(0, yRotate % 360, 0);
        transform.eulerAngles = new Vector3(xRotate%360, yRotate % 360, 0);
        //head.transform.eulerAngles = new Vector3(0, xRotate % 360, 0);
        //Debug.Log(angle);
    }
}
