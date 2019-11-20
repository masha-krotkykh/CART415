using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Doors : Pickup
{
    public static bool doorIsReady = false; 

   // functions to be called when a game object is clicked
    public void TryDoor()
    {
        // naming an object by it's object name
        nameOfObject = gameObject.name;

        if(InventoryManager.CurrentItem == "wallpaper")
        {
            doorIsReady = true;
            Debug.Log("doors, Doors, DOORS!!!");

        }

        else if((InventoryManager.CurrentItem == "nail") && (doorIsReady == true))
        {
            Debug.Log("You're free to go");
        }

        else
        {
            // getting individual message from game object component to display in a popup
            popupMessage = gameObject.GetComponent<Text>().text;
            popup.ShowPopUp(popupMessage);
        }

    }
}
