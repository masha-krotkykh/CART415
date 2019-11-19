using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Doors : MonoBehaviour
{
    public PopUp popup;

    // variable for defining a name for every game object
    public static string nameOfObject;
    public static string popupMessage;

    public static bool doorIsReady = false; 

   // public GameObject objectName;

   // functions to be called when a game object is clicked
    void OnMouseDown()
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
