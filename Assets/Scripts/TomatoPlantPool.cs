using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TomatoPlantPool : MonoBehaviour
{
    public static TomatoPlantPool instance;

    public GameObject tomatoPlantPrefab;
    public GameObject rottenTomatoPlantPrefab;
    public static List<GameObject> tomatoPlantList = new List<GameObject>();
    public static List<GameObject> rottenTomatoPlantList = new List<GameObject>();

    void Start()
    {
        instance = this;

        for (int i = 0; i < 25; i++)
            tomatoPlantList.Add(CreateNewTomatoPlant(i));
        for (int i = 0; i < 25; i++)
            rottenTomatoPlantList.Add(CreateNewRottenTomatoPlant(i));
    }

    private GameObject CreateNewTomatoPlant(int index)
    {
        GameObject newObj = Instantiate(tomatoPlantPrefab);
        newObj.name = "TomatoPlant" + (index + 1).ToString();
        newObj.transform.position = new Vector3(0, -200.0f, 0);
        return newObj;
    }

    private GameObject CreateNewRottenTomatoPlant(int index)
    {
        GameObject newObj = Instantiate(rottenTomatoPlantPrefab);
        newObj.name = "RottenPlant" + (index + 1).ToString();
        newObj.transform.position = new Vector3(0, -200.0f, 10.0f);
        return newObj;
    }
}
