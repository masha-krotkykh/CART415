using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Pills : Pickup
{
    // functions to be called when a game object is clicked
    public void PickupPills()
    {

        // naming an object by it's object name
        nameOfObject = gameObject.name;

        if (knifeCollected == 1)
        {
            CollectItem();
            popupMessage = gameObject.GetComponent<Text>().text;
        }

        else
        {
            // getting individual message from game object component to display in a popup
            popupMessage = "It's not the safest place to go right now. I'm not getting there unarmed.";
        }
        popup.ShowPopUp(popupMessage);
        Debug.Log(knifeCollected);
    }
}
