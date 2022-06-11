using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hoedFieldScript : MonoBehaviour
{
    private hoedFieldScript instance;

    // Renderer renderer;
    Vector3 currentPosition;
    GameObject grassObject;
    GameObject tomatoPlantObject;
    GameObject rottenTomatoPlantObject;
    int objNum;
    public bool isSeedPlanted = false;
    bool isWatered = false;
    // private bool isTomatoPlanted = false;
    public float elapsedTime;
    public AudioSource seeding;
    public AudioSource watering;

    void Start()
    {
        instance = this;
        // renderer = gameObject.GetComponent<Renderer>();
        currentPosition = transform.position;
        elapsedTime = 0;
        objNum = Convert.ToInt32(instance.name[9..]);
        grassObject = GrassObjectPool.grassObjectList[objNum - 1];
        tomatoPlantObject = TomatoPlantPool.tomatoPlantList[objNum - 1];
        rottenTomatoPlantObject = TomatoPlantPool.rottenTomatoPlantList[objNum - 1];
        
        //tomatoPlantObject = GameObject.Find("TomatoPlant" + objNum);
        //Debug.Log(tomatoPlantObject.name);
    }

    void Update()
    {
        if (isWatered)
        {
            elapsedTime += Time.deltaTime;
            if (elapsedTime >= 3.0f)
            {
                grassObject.SetActive(false);
                int rottenVariable = UnityEngine.Random.Range(0, 100);
                if (rottenVariable < 20)
                {
                    rottenTomatoPlantObject.transform.position = currentPosition;
                    rottenTomatoPlantObject.SetActive(true);
                }
                else
                {
                    tomatoPlantObject.transform.position = currentPosition;
                    tomatoPlantObject.SetActive(true);
                }
                isWatered = false;
                //isSeedPlanted = false;
                //elapsedTime = 0.0f;
            }
        }
    }

    private void OnMouseEnter()
    {
        //renderer.material.color = Color.red;
    }

    private void OnMouseExit()
    {
        //renderer.material.color = Color.white;
    }

    void OnMouseUpAsButton()
    {
        if (!isSeedPlanted && Change_Image.toolMode == 2)
        {
            grassObject.SetActive(true);
            grassObject.transform.position = transform.position;
            isSeedPlanted = true;
            seeding.Play();
        }
        else if (isSeedPlanted)
        {
            //Debug.Log(grassObject.name + "이 이미 심어져 있습니다.");
        }
        else if (Change_Image.toolMode != 2)
        {
            //Debug.Log("씨앗을 들고 있지 않습니다.");
        }

        if (isSeedPlanted && Change_Image.toolMode == 3)
        {
            isWatered = true;
            watering.Play();
        }
    }
}
