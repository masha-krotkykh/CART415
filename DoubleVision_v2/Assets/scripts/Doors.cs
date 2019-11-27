using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Doors : Pickup
{

    public GameObject wpFloor;
    public GameObject keyFloor;
    public GameObject portal;

    public int wpInstalled;
    public int keyInstalled;
    public int doorIsReady;
    public int doorIsOpen;


    // functions to be called when a game object is clicked
    public void TryDoor()
    {
        // naming an object by it's object name
        nameOfObject = gameObject.name;

        if(InventoryManager.CurrentItem == "wallpaper")
        {
            wpInstalled = 1;
            PlayerPrefs.SetInt("wpInstalled", wpInstalled);

            doorIsReady = 1;
            PlayerPrefs.SetInt("doorIsReady", doorIsReady);

            DisplayWallpaper();
            popupMessage = "Now we're getting somewhere";
        }

        else if((InventoryManager.CurrentItem == "nail") && (PlayerPrefs.GetInt("doorIsReady") == 1))
        {
            keyInstalled = 1;
            PlayerPrefs.SetInt("keyInstalled", keyInstalled);

            DisplayKey();
        }

        else if(InventoryManager.CurrentItem == "key")
        {
            portal = GameObject.Find("portal");
            portal.GetComponent<SpriteRenderer>().enabled = true;
            doorIsOpen = 1;

            PlayerPrefs.SetInt("doorIsOpen", doorIsOpen);
            popupMessage = "Sweet smell of freedom!";
        }

        else
        {
            // getting individual message from game object component to display in a popup
            popupMessage = gameObject.GetComponent<Text>().text;
        }
        popup.ShowPopUp(popupMessage);
    }


    public void DisplayWallpaper()
    {
    
        wpFloor = GameObject.Find("wp_inv");
        wpFloor.GetComponent<SpriteRenderer>().enabled = true;

    }



    public void DisplayKey()
    {
        keyFloor = GameObject.Find("key");
        keyFloor.GetComponent<SpriteRenderer>().enabled = true;
        keyFloor.GetComponent<BoxCollider2D>().enabled = true;
        keyFloor.GetComponent<Button>().enabled = true;

    }

}
