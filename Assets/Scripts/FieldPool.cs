using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FieldPool : MonoBehaviour
{
    public static List<GameObject> fieldList = new List<GameObject>();
    public static List<GameObject> hoedFieldList = new List<GameObject>();

    void Start()
    {
        for (int i = 1; i <= 25; i++)
        {
            GameObject tmpField = GameObject.Find("Field" + i);
            if (tmpField != null)
                fieldList.Add(tmpField);
            else
                Debug.Log("null");
        }
        //for (int i = 1; i <= 25; i++) hoedFieldList.Add(GameObject.Find("hoedField" + i));
    }
}
