using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject maincam;
    public GameObject titlecam;
    public GameObject gameDirector;
    public GameObject Player;

    public GameObject gamepanel;
    public GameObject TutorialPanel0;
    public GameObject TutorialPanel1;
    public GameObject TutorialPanel2;
    public GameObject TutorialPanel3;
    public GameObject TutorialPanel4;
    public GameObject TutorialPanel5;
    public int panel_num = 0;

    public Text harvested_crops;
    public Text onehand_text;
    public int crops_num;
    public Image Item1;
    public Image Item2;
    public Image Item3;
    public Image Item4;

    public AudioSource background;
    public AudioSource startbutton;
    public AudioSource onehandbutton;
    public AudioSource mainsound;

    void Awake()
    {
        
    }
    /*
    public float GetMode()
    {
        return mode;
    }
    */

    public void InvokeGameStart()
    {
        Player.SetActive(true);
        titlecam.SetActive(false);
        maincam.SetActive(true);
        

        TutorialPanel0.SetActive(false);
        gamepanel.SetActive(true);

        gameDirector.GetComponent<FieldPool>().enabled = true;
        gameDirector.GetComponent<InteractionDirector>().enabled = true;
        Cursor.lockState = CursorLockMode.Locked;

        mainsound.volume = 0.3f;
    }

    public void InvokeBackSound()
    {
        background.Play();
    }

    public void GameStart()
    {
        startbutton.Play();

        Invoke("InvokeGameStart", 1f);
        Invoke("InvokeBackSound", 2f);
    }

    public void NextPanel()
    {
        switch (panel_num)
        {
            case 0:
                onehandbutton.Play();
                TutorialPanel0.SetActive(false);
                TutorialPanel1.SetActive(true);
                break;
            case 1:
                onehandbutton.Play();
                TutorialPanel1.SetActive(false);
                TutorialPanel2.SetActive(true);
                break;
            case 2:
                onehandbutton.Play();
                TutorialPanel2.SetActive(false);
                TutorialPanel3.SetActive(true);
                break;
            case 3:
                onehandbutton.Play();
                TutorialPanel3.SetActive(false);
                TutorialPanel4.SetActive(true);
                break;
            case 4:
                onehandbutton.Play();
                TutorialPanel4.SetActive(false);
                TutorialPanel5.SetActive(true);
                break;
        }
        panel_num++;
    }

    public void BackPanel()
    {
        switch (panel_num)
        {
            case 1:
                onehandbutton.Play();
                TutorialPanel1.SetActive(false);
                TutorialPanel0.SetActive(true);
                break;
            case 2:
                onehandbutton.Play();
                TutorialPanel2.SetActive(false);
                TutorialPanel1.SetActive(true);
                break;
            case 3:
                onehandbutton.Play();
                TutorialPanel3.SetActive(false);
                TutorialPanel2.SetActive(true);
                break;
            case 4:
                onehandbutton.Play();
                TutorialPanel4.SetActive(false);
                TutorialPanel3.SetActive(true);
                break;
            case 5:
                onehandbutton.Play();
                TutorialPanel5.SetActive(false);
                TutorialPanel4.SetActive(true);
                break;
        }
        panel_num--;
    }

    public void HomePanel()
    {
        panel_num = 0;
        TutorialPanel1.SetActive(false);
        TutorialPanel2.SetActive(false);
        TutorialPanel3.SetActive(false);
        TutorialPanel4.SetActive(false);
        TutorialPanel5.SetActive(false);
        TutorialPanel0.SetActive(true);
    }

    public void Quit()
    {
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif

    }

    public void onehand_Mode()
    {
        if (SelectMode.mode == 1) {
            onehandbutton.Play();
            onehand_text.GetComponent<Text>().text = "One-Hand Mode : On";
            SelectMode.mode = 2;
        }
        else if (SelectMode.mode == 2)
        {
            onehandbutton.Play();
            onehand_text.GetComponent<Text>().text = "One-Hand Mode : Off";
            SelectMode.mode = 1;
        }

    }

    void LateUpdate()
    {
        harvested_crops.text = "Harvested Crops : " + crops_num;
    }

}
