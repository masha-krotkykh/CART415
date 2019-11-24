using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Nail : Pickup
{

    public StateSwitch stateSwitch;

    // functions to be called when a game object is clicked
    public void PullNail()
    {
        // naming an object by it's object name
        nameOfObject = gameObject.name;

        if (InventoryManager.CurrentItem == "crowbar")
        {
            CollectItem();
            stateSwitch.SwitchDelirious();
            popupMessage = "Who knew this would come in handy!";
        }

        else
        {
            // getting individual message from game object component to display in a popup
            popupMessage = gameObject.GetComponent<Text>().text;

        }
        popup.ShowPopUp(popupMessage);
    }
}