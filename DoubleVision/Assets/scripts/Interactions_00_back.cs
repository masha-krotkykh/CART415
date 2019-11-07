using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Interactions_00_back : MonoBehaviour
{
    public int pillsCollected = 0;
    public int wallpaperCollected = 0;

    public GameObject pills;
    public GameObject wallpaper;



    // Start is called before the first frame update
    void Start()
    {

        pills = GameObject.Find("pills");
        if (PlayerPrefs.GetInt("pillsCollected") == 1)
        {
            // -------------------->>           Destroy(pills);


            // TEMPORARY REMOVE BEFORE BUILD

            Debug.Log("pills are already collected");
            pillsCollected = 0;

            //-----------------------------------//
        }

        wallpaper = GameObject.Find("wallpaper");
        if (PlayerPrefs.GetInt("wallpaperCollected") == 1)
        {
            // -------------------->>           Destroy(wallpaper);


            // TEMPORARY! REMOVE BEFORE BUILD

            Debug.Log("wallpaper is already collected");
            wallpaperCollected = 0;

            //-----------------------------------//
        }
    }

    public void GoFront()
    {
        SaveVars();
        SceneManager.LoadScene("room_00_front");
    }

    public void SaveVars()
    {
        if (pills != null)
        {
            Pickup pickup = pills.GetComponent<Pickup>();
            if (pickup.collected == true)
            {
                pillsCollected = 1;
            }
        }
        PlayerPrefs.SetInt("pillsCollected", pillsCollected);



        if (wallpaper != null)
        {
            Pickup pickup = wallpaper.GetComponent<Pickup>();
            if (pickup.collected == true)
            {
                wallpaperCollected = 1;
            }
        }
        PlayerPrefs.SetInt("wallpaperCollected", wallpaperCollected);
    }
}
