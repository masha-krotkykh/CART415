using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pickable : MonoBehaviour
{
    public PopUp popup;

    // variable for defining a name for every game object
    public static string nameOfObject;
    public static string popupMessage;


   // functions to be called when a game object is clicked
    void OnMouseDown()
    {
        // naming an object by it's object name
        nameOfObject = gameObject.name;
        Debug.Log(nameOfObject);

        // getting individual message from game object component to display in a popup
        popupMessage = gameObject.GetComponent<Text>().text;
        popup.ShowPopUp(popupMessage);
        Destroy(gameObject);
    }
}
