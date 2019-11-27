using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Navigation : MonoBehaviour
{

    public GameObject pills;
    public GameObject wallpaper;
    public GameObject crowbar;


    public GameObject knife;
    public GameObject nail;


    public GameObject wpFloor;
    public GameObject keyFloor;
    public GameObject portal;


    public void Start()
    {
        pills = GameObject.Find("pills");
        wallpaper = GameObject.Find("wallpaper");
        crowbar = GameObject.Find("crowbar");

        knife = GameObject.Find("knife");
        nail = GameObject.Find("nail");

        wpFloor = GameObject.Find("wp_inv");
        keyFloor = GameObject.Find("key");
        portal = GameObject.Find("portal");


        if ((pills != null) && (PlayerPrefs.GetInt("pillsCollected") == 1))
        {
            Destroy(pills);
        }

        if ((wallpaper != null) && (PlayerPrefs.GetInt("wallpaperCollected") == 1))
        {
            Destroy(wallpaper);
        }

        if ((crowbar != null) && (PlayerPrefs.GetInt("crowbarCollected") == 1))
        {
            Destroy(crowbar);
        }


        if ((knife != null) && (PlayerPrefs.GetInt("knifeCollected") == 1))
        {
            Destroy(knife);
        }

        if ((nail != null) && (PlayerPrefs.GetInt("nailCollected") == 1))
        {
            Destroy(nail);
        }



        if ((wpFloor != null) && (PlayerPrefs.GetInt("wpInstalled") == 1))
        {

            wpFloor.GetComponent<SpriteRenderer>().enabled = true;
        }

        if((keyFloor != null) && (PlayerPrefs.GetInt("keyInstalled") == 1) && (PlayerPrefs.GetInt("keyCollected") == 0))
        {
            keyFloor.GetComponent<SpriteRenderer>().enabled = true;
            keyFloor.GetComponent<BoxCollider2D>().enabled = true;
            keyFloor.GetComponent<Button>().enabled = true;
        }

        if((portal != null) && (PlayerPrefs.GetInt("doorIsOpen") == 1))
        {
            portal.GetComponent<SpriteRenderer>().enabled = true;
        }

    }

    public void GoBack00()
    {
        //SaveVars();
        SceneManager.LoadScene("room_00_back");
    }



    // Instruct the button to take player to another scene "front of the room"
    public void GoFront00()
    {
        //SaveVars();
        SceneManager.LoadScene("room_00_front");

    }



}
