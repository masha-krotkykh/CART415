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
        // Targeting GameObjects to get access to ttheir properties set in other scripts
        pills = GameObject.Find("pills");

        // Check if the object was aready collected on the previous visit
        if (PlayerPrefs.GetInt("pillsCollected") == 1)
        {

            // And destroy it from the scene 


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
