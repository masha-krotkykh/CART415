﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Interactions_00_back : MonoBehaviour
{
    public int pillsCollected = 0;
    public int wallpaperCollected = 0;
    public int crowbarCollected = 0;

    public GameObject pills;
    public GameObject wallpaper;
    public GameObject crowbar;




    // Start is called before the first frame update
    void Start()
    {
		// Targeting GameObjects to get access to their properties set in other scripts
		wallpaper = GameObject.Find("wallpaper");
		pills = GameObject.Find("pills");
        crowbar = GameObject.Find("crowbar");

        wallpaperCollected = 0;
        pillsCollected = 0;
        crowbarCollected = 0;


        // Check if the object was aready collected on the previous visit
        if (PlayerPrefs.GetInt("pillsCollected") == 1)
		{
			pillsCollected = 1;
			// And destroy it from the scene 
			// -------------------->>
            Destroy(pills);

		}


		else
		{
			pillsCollected = 0;
		}





		if (PlayerPrefs.GetInt("wallpaperCollected") == 1)
		{
			wallpaperCollected = 1;
			// And destroy it from the scene 
			// -------------------->
            Destroy(wallpaper);
		}

		else
		{
			wallpaperCollected = 0;
		}




        if (PlayerPrefs.GetInt("crowbarCollected") == 1)
        {
            crowbarCollected = 1;
            // And destroy it from the scene 
            // -------------------->
            Destroy(crowbar);
        }

        else
        {
            crowbarCollected = 0;
        }
    }




    // Instruct the button to take player to another scene "front of the room"
    public void GoFront()
    {
        SaveVars();
        SceneManager.LoadScene("room_00_front");
    }

    // Access "Pickup" component of the GamObject to check if it's been collected and if so, set it's state to 1
    // and save this value for future visits
    public void SaveVars()
    {
        //if (pills != null)
        //{
        //    Pickup pickup = pills.GetComponent<Pickup>();
        //    if (pickup.collected == true)
        //    {
        //        pillsCollected = 1;
        //    }
        //}




        //if (wallpaper != null)
        //{
        //    Pickup pickup = wallpaper.GetComponent<Pickup>();
        //    if (pickup.collected == true)
        //    {
        //        wallpaperCollected = 1;
        //    }
        //}


        //----------------------------------------------//
        //-----------for TESTING ONLY REMOVE BEFORE BUILD

        wallpaperCollected = 0;
        pillsCollected = 0;
        crowbarCollected = 0;

        //----------------------------------------------//

        PlayerPrefs.SetInt("pillsCollected", pillsCollected);
        PlayerPrefs.SetInt("wallpaperCollected", wallpaperCollected);
        PlayerPrefs.SetInt("crowbarCollected", crowbarCollected);

    }
}