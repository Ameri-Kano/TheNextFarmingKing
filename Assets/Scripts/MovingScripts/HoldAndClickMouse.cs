using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoldAndClickMouse : MonoBehaviour
{
    public GameObject hoe;
    public GameObject seed;
    public GameObject water;
    public GameObject basket;
    public float speed = 5;
    private Vector3 hoeHoldingRotation;
    private float num = 0;
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        hoeHoldingRotation = new Vector3(5.0f, 132.0f, 115.0f);

        anim = GetComponent<Animator>();
        anim.SetBool("useHoe", false);
        anim.SetBool("useWateringCan", false);
        anim.SetBool("useBasket", false);
    }

    // Update is called once per frame
    void Update()
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
                hoe.SetActive(true);
                seed.SetActive(false);
                water.SetActive(false);
                basket.SetActive(false);
                transform.Rotate(Vector3.forward * Time.deltaTime * speed);
                hoe.transform.localEulerAngles = hoeHoldingRotation;
                break;

            case 2:
                hoe.SetActive(false);
                seed.SetActive(true);
                water.SetActive(false);
                basket.SetActive(false);
                break;
            case 3:
                hoe.SetActive(false);
                seed.SetActive(false);
                water.SetActive(true);
                basket.SetActive(false);
                break;
            case 4:
                hoe.SetActive(false);
                seed.SetActive(false);
                water.SetActive(false);
                basket.SetActive(true);
                break;
            case 0:
                hoe.SetActive(false);
                seed.SetActive(false);
                water.SetActive(false);
                basket.SetActive(false);
                break;
        }

        
        // 1234?? ?????? ?????? ???? ?????????? ????
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
