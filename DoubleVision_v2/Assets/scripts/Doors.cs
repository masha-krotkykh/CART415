using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Doors : Pickup
{
    public static bool doorIsReady = false;

    public GameObject wpFloor;
    public GameObject keyFloor;

    // functions to be called when a game object is clicked
    public void TryDoor()
    {
        // naming an object by it's object name
        nameOfObject = gameObject.name;

        if(InventoryManager.CurrentItem == "wallpaper")
        {
            doorIsReady = true;
            Debug.Log("doors, Doors, DOORS!!!");
            wpFloor = GameObject.Find("wp_inv");
            wpFloor.GetComponent<SpriteRenderer>().enabled = true;
            popupMessage = "Now we're getting somewhere";

        }

        else if((InventoryManager.CurrentItem == "nail") && (doorIsReady == true))
        {
            Debug.Log("You're free to go");
            keyFloor = GameObject.Find("key");
            keyFloor.GetComponent<SpriteRenderer>().enabled = true;
            keyFloor.GetComponent<BoxCollider2D>().enabled = true;
            keyFloor.GetComponent<Button>().enabled = true;
        }

        else if(InventoryManager.CurrentItem == "key")
        {
            popupMessage = "Sweet smell of freedom!";
        }

        else
        {
            // getting individual message from game object component to display in a popup
            popupMessage = gameObject.GetComponent<Text>().text;
        }
        popup.ShowPopUp(popupMessage);
    }
}
