using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Wallpaper : Pickup
{

    // functions to be called when a game object is clicked
    public void CutWallpaper()
    {
        // naming an object by it's object name
        nameOfObject = gameObject.name;

        if (InventoryManager.CurrentItem == "knife")
        {
            CollectItem();
            popupMessage = "This bloody dogear has been bugging me for years!";
        }

        else
        {
            // getting individual message from game object component to display in a popup
            popupMessage = gameObject.GetComponent<Text>().text;
        }
        popup.ShowPopUp(popupMessage);
    }
}
