using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Change_Image : MonoBehaviour
{
    private GameManager gameManager;
    private float num = 0;
    public float mode;
    public Image img1;
    public Image img2;
    public Image img3;
    public Image img4;
    public Sprite Img1;
    public Sprite Img2;
    public Sprite Img3;
    public Sprite Img4;
    public Sprite change_img1;
    public Sprite change_img2;
    public Sprite change_img3;
    public Sprite change_img4;

    public static int toolMode;

    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        mode = SelectMode.mode;
        toolMode = 0;
    }

    void Update()
    {
        //Debug.Log(toolMode);
        if (mode == 1)
        {
            /*
            switch (Input.inputString)
            {
                case "1":
                    img1.sprite = change_img1;
                    img2.sprite = Img2;
                    img3.sprite = Img3;
                    img4.sprite = Img4;
                    toolMode = 1;
                    break;

                case "2":
                    img1.sprite = Img1;
                    img2.sprite = change_img2;
                    img3.sprite = Img3;
                    img4.sprite = Img4;
                    toolMode = 2;
                    break;
                case "3":
                    img1.sprite = Img1;
                    img2.sprite = Img2;
                    img3.sprite = change_img3;
                    img4.sprite = Img4;
                    toolMode = 3;
                    break;
                case "4":
                    img1.sprite = Img1;
                    img2.sprite = Img2;
                    img3.sprite = Img3;
                    img4.sprite = change_img4;
                    toolMode = 4;
                    break;
                case "`":
                    img1.sprite = Img1;
                    img2.sprite = Img2;
                    img3.sprite = Img3;
                    img4.sprite = Img4;
                    toolMode = 0;
                    break;

            }
            */
            if (Input.GetKey(KeyCode.Alpha1))
            {
                img1.sprite = change_img1;
                img2.sprite = Img2;
                img3.sprite = Img3;
                img4.sprite = Img4;
                toolMode = 1;
            }
            else if (Input.GetKey(KeyCode.Alpha2))
            {
                img1.sprite = Img1;
                img2.sprite = change_img2;
                img3.sprite = Img3;
                img4.sprite = Img4;
                toolMode = 2;
            }
            else if (Input.GetKey(KeyCode.Alpha3))
            {
                img1.sprite = Img1;
                img2.sprite = Img2;
                img3.sprite = change_img3;
                img4.sprite = Img4;
                toolMode = 3;
            }
            else if (Input.GetKey(KeyCode.Alpha4))
            {
                img1.sprite = Img1;
                img2.sprite = Img2;
                img3.sprite = Img3;
                img4.sprite = change_img4;
                toolMode = 4;
            }
            else if (Input.GetKey(KeyCode.BackQuote))
            {
                img1.sprite = Img1;
                img2.sprite = Img2;
                img3.sprite = Img3;
                img4.sprite = Img4;
                toolMode = 0;
            }
        }
        else if (mode == 2)
        {
            float wheelInput = Input.GetAxis("Mouse ScrollWheel");
            if (wheelInput > 0)
            {
                // ???? ???? ?????? ???? ???? ??
                num -= 1;
                //Debug.Log(num);
                if (num < 0)
                {
                    num = 4.0f;
                }
            }
            else if (wheelInput < 0)
            {
                // ???? ???? ?????? ???? ???? ??

                num += 1;
                if (num > 4)
                {
                    num = num % 5;
                }
            }
            switch (num)
            {
                case 1:
                    img1.sprite = change_img1;
                    img2.sprite = Img2;
                    img3.sprite = Img3;
                    img4.sprite = Img4;
                    toolMode = 1;
                    break;
                case 2:
                    img1.sprite = Img1;
                    img2.sprite = change_img2;
                    img3.sprite = Img3;
                    img4.sprite = Img4;
                    toolMode = 2;
                    break;
                case 3:
                    img1.sprite = Img1;
                    img2.sprite = Img2;
                    img3.sprite = change_img3;
                    img4.sprite = Img4;
                    toolMode = 3;
                    break;
                case 4:
                    img1.sprite = Img1;
                    img2.sprite = Img2;
                    img3.sprite = Img3;
                    img4.sprite = change_img4;
                    toolMode = 4;
                    break;
                case 0:
                    img1.sprite = Img1;
                    img2.sprite = Img2;
                    img3.sprite = Img3;
                    img4.sprite = Img4;
                    toolMode = 0;
                    break;

            }
        }

    }
}