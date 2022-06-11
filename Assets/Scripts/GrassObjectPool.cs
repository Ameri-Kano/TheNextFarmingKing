using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrassObjectPool : MonoBehaviour
{
    public static GrassObjectPool instance;

    [SerializeField]
    private GameObject grassPrefab;

    public static List<GameObject> grassObjectList = new List<GameObject>();

    void Start()
    {
        instance = this;

        for (int i = 0; i < 25; i++)
            grassObjectList.Add(CreateNewObject(i));
    }

    private GameObject CreateNewObject(int index)
    {
        GameObject newObj = Instantiate(grassPrefab);
        //newObj.gameObject.SetActive(false);
        newObj.name = "Grass" + (index + 1).ToString();
        newObj.transform.position = new Vector3(0, -150.0f, 0);
        return newObj;
    }




}
