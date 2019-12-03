using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BeginGame : MonoBehaviour
{

    public GameObject Panel;


    // Start is called before the first frame update
    void Start()
    {

        if (Panel != null)
        {
            Panel.SetActive(false);
        }

        PlayerPrefs.SetInt("currentState", 0);
        PlayerPrefs.SetInt("knifeCollected", 0);
        PlayerPrefs.SetInt("nailCollected", 0);
        PlayerPrefs.SetInt("pillsCollected", 0);
        PlayerPrefs.SetInt("wallpaperCollected", 0);
        PlayerPrefs.SetInt("crowbarCollected", 0);

        PlayerPrefs.SetInt("wpInstalled", 0);
        PlayerPrefs.SetInt("keyInstalled", 0);
        PlayerPrefs.SetInt("doorIsOpen", 0);
        PlayerPrefs.SetInt("doorIsReady", 0);

        SceneManager.LoadScene("room_00_front");
    }

}
