using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class FieldScript : MonoBehaviour
{
    Renderer fieldColor;
    GameObject currentField;
    public Camera playerPerspective;
    public AudioSource hoeing;

    void Start()
    { 
        this.fieldColor = gameObject.GetComponent<Renderer>();
        // this.currentField = GameObject.Find(instance.name);
    }

    private void OnMouseEnter()
    {
        fieldColor.material.color = Color.green;
    }

    private void OnMouseExit()
    {
        fieldColor.material.color = Color.white;
    }

    private void OnMouseUpAsButton()
    {
        if (Change_Image.toolMode == 1)
        {
            RaycastHit hit;
            //Ray touchray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Ray touchray = playerPerspective.ScreenPointToRay(Input.mousePosition);
            Physics.Raycast(touchray, out hit);
            if (hit.collider != null)
                currentField = hit.collider.gameObject;
            hoeing.Play();

            currentField.SetActive(false);
        }
    }
}
