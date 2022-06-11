using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoldAndClick : MonoBehaviour
{
    public GameObject hoe;
    public GameObject seed;
    public GameObject water;
    public GameObject basket;
    public float speed = 5;
    private Vector3 hoeHoldingRotation;
    //private Vector3 hoeHoldingPosition;

    // 1234 애니메이션
    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        hoeHoldingRotation = new Vector3(5.0f, -58.0f, 115.0f);
        //hoeHoldingRhotation = new Vector3(5.0f, 132.0f, 115.0f);
        //hoeHoldingPosition = new Vector3(-0.12f,0.1f,0.02f);
        anim = GetComponent<Animator>();
        anim.SetBool("useHoe", false);
        anim.SetBool("useWateringCan", false);
        anim.SetBool("useBasket", false);
        anim.SetBool("useSeed", false);
    }

    // Update is called once per frame
    void Update()
    {
        /*switch (Input.inputString)
        {
            case "1":
                hoe.SetActive(true);
                seed.SetActive(false);
                water.SetActive(false);
                basket.SetActive(false);
                //transform.Rotate(Vector3.forward * Time.deltaTime * speed);
                hoe.transform.localEulerAngles = hoeHoldingRotation;
                //hoe.transform.position += hoeHoldingPosition;
                break;
            case "2":
                hoe.SetActive(false);
                seed.SetActive(true);
                water.SetActive(false);
                basket.SetActive(false);
                break;
            case "3":
                hoe.SetActive(false);
                seed.SetActive(false);
                water.SetActive(true);
                basket.SetActive(false);
                break;
            case "4":
                hoe.SetActive(false);
                seed.SetActive(false);
                water.SetActive(false);
                basket.SetActive(true);
                break;
            case "`":
                hoe.SetActive(false);
                seed.SetActive(false);
                water.SetActive(false);
                basket.SetActive(false);
                break;
        }*/


        // input.string -> getkey(keycode.alpha#)
        if (Input.GetKey(KeyCode.Alpha1))
        {
            hoe.SetActive(true);
            seed.SetActive(false);
            water.SetActive(false);
            basket.SetActive(false);
            //transform.Rotate(Vector3.forward * Time.deltaTime * speed);
            hoe.transform.localEulerAngles = hoeHoldingRotation;
            //hoe.transform.position += hoeHoldingPosition;
        }
        if (Input.GetKey(KeyCode.Alpha2))
        {
            hoe.SetActive(false);
            seed.SetActive(true);
            water.SetActive(false);
            basket.SetActive(false);
        }
        if (Input.GetKey(KeyCode.Alpha3))
        {
            hoe.SetActive(false);
            seed.SetActive(false);
            water.SetActive(true);
            basket.SetActive(false);
        }
        if (Input.GetKey(KeyCode.Alpha4))
        {
            hoe.SetActive(false);
            seed.SetActive(false);
            water.SetActive(false);
            basket.SetActive(true);
        }
        if (Input.GetKey(KeyCode.BackQuote))
        {
            hoe.SetActive(false);
            seed.SetActive(false);
            water.SetActive(false);
            basket.SetActive(false);
        }

        // 1234별 마우스 클릭에 따른 애니메이션 설정
        if (hoe.activeSelf)
        {
            if (Input.GetMouseButtonDown(0))
            {
                anim.SetBool("useHoe", true);
            }
            if (Input.GetMouseButtonUp(0))
            {
                anim.SetBool("useHoe", false);
            }
        }
        if (seed.activeSelf)
        {
            if (Input.GetMouseButtonDown(0))
            {
                anim.SetBool("useSeed", true);
            }
            if (Input.GetMouseButtonUp(0))
            {
                anim.SetBool("useSeed", false);
            }
        }
        if (water.activeSelf)
        {
            if (Input.GetMouseButtonDown(0))
            {
                anim.SetBool("useWateringCan", true);
            }
            if (Input.GetMouseButtonUp(0))
            {
                anim.SetBool("useWateringCan", false);
            }
        }
        if (basket.activeSelf)
        {
            if (Input.GetMouseButtonDown(0))
            {
                anim.SetBool("useBasket", true);
            }
            if (Input.GetMouseButtonUp(0))
            {
                anim.SetBool("useBasket", false);
            }
        }
    }

}
