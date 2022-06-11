using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionDirector : MonoBehaviour
{
    public List<GameObject> fieldList;
    public List<GameObject> hoedFieldList;
    GameObject currentTomatoPlant;
    GameObject player;
    GameObject gameManager;

    public GameObject tomato;
    public GameObject rottenTomato;
    GameObject tmpTomato;
    Vector3 tmpTomatoSpawnPosition;

    public Camera playerPerspective;
    public GameObject currentHF;
    public AudioSource Harvest;
    public AudioSource fail;

    RaycastHit hit;
    Ray touchRay;

    void Start()
    {
        player = GameObject.Find("Player");
        gameManager = GameObject.Find("GameManager");
    }

    void Update()
    {
        for (int i = 0; i < 25; i++)
        {
            if (Vector3.Distance(player.transform.position, fieldList[i].transform.position) <= 3.0f)
            {
                fieldList[i].GetComponent<MeshCollider>().enabled = true;
                fieldList[i].GetComponent<FieldScript>().enabled = true;
                hoedFieldList[i].GetComponent<MeshCollider>().enabled = true;
                //hoedFieldList[i].GetComponent<hoedFieldScript>().enabled = true;
            }
            else
            {
                fieldList[i].GetComponent<MeshCollider>().enabled = false;
                fieldList[i].GetComponent<FieldScript>().enabled = false;
                hoedFieldList[i].GetComponent<MeshCollider>().enabled = false;
                //hoedFieldList[i].GetComponent<hoedFieldScript>().enabled = false;
            }
        }

        if (Input.GetMouseButtonDown(0))
        {
            //touchRay = Camera.main.ScreenPointToRay(Input.mousePosition);
            touchRay = playerPerspective.ScreenPointToRay(Input.mousePosition);
            Physics.Raycast(touchRay, out hit);
            if (hit.collider != null && hit.collider.gameObject.name.Contains("Rotten") && Change_Image.toolMode == 4)
            {
                currentTomatoPlant = hit.collider.gameObject;
                currentTomatoPlant.SetActive(false);
                currentHF = GameObject.Find("hoedField" + currentTomatoPlant.name[11..]);

                fail.Play();

                int rand = Random.Range(2, 6);
                for (int i = 0; i < rand; i++)
                {
                    tmpTomatoSpawnPosition = new Vector3(Random.Range(-1.0f, 1.0f), 1.0f, Random.Range(-1.0f, 1.0f));
                    tmpTomato = Instantiate(rottenTomato, currentTomatoPlant.transform.position + tmpTomatoSpawnPosition, Quaternion.identity);
                    Destroy(tmpTomato, 3.0f);
                }
                currentHF.GetComponent<hoedFieldScript>().isSeedPlanted = false;
                currentHF.GetComponent<hoedFieldScript>().elapsedTime = 0.0f;

                //gameManager.GetComponent<GameManager>().crops_num += rand;

                //Debug.Log(GameManager.crops_num);
                //GameManager.harvested_crops.text = "Harvested Crops : " + GameManager.crops_num;
            }
            else if (hit.collider != null && hit.collider.gameObject.name.Contains("Tomato") && Change_Image.toolMode == 4)
            {
                currentTomatoPlant = hit.collider.gameObject;
                currentTomatoPlant.SetActive(false);
                currentHF = GameObject.Find("hoedField" + currentTomatoPlant.name[11..]);

                Harvest.Play();

                int rand = Random.Range(2, 6);
                for (int i = 0; i < rand; i++)
                {
                    tmpTomatoSpawnPosition = new Vector3(Random.Range(-1.0f, 1.0f), 1.0f, Random.Range(-1.0f, 1.0f));
                    tmpTomato = Instantiate(tomato, currentTomatoPlant.transform.position + tmpTomatoSpawnPosition, Quaternion.identity);
                    Destroy(tmpTomato, 3.0f);
                }
                currentHF.GetComponent<hoedFieldScript>().isSeedPlanted = false;
                currentHF.GetComponent<hoedFieldScript>().elapsedTime = 0.0f;

                gameManager.GetComponent<GameManager>().crops_num += rand;

                //Debug.Log(GameManager.crops_num);
                //GameManager.harvested_crops.text = "Harvested Crops : " + GameManager.crops_num;
            }
        }
    }
}
