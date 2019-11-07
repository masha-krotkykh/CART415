using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pickup : MonoBehaviour
{
  public PopUp popup;

  public static string nameOfObject;
  public static string popupMessage;

  private Inventory inventory;
  public GameObject itemButton;
  public bool collected = false;


    // Start is called before the first frame update
    private void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("EventSystem").GetComponent<Inventory>();
    }

    // on mouse click look through the array of inventory slots to check is each of themis full
    void OnMouseDown()
    {
      for (int i = 0; i < inventory.slots.Length; i++)
      { // once we find the slot that is not full, we set it to full since we're adding a new item to it
        if(inventory.isFull[i] == false)
        {
            // Item can be added
            inventory.isFull[i] = true;
            // make sure that the button spawns at the same position as the inventory slot
            Instantiate(itemButton, inventory.slots[i].transform, false);
            // Naming the object by its object name
            nameOfObject = gameObject.name;
            Debug.Log("You found " + nameOfObject);
            //Getting an individual message from gameObject to display in a popup
            popupMessage = gameObject.GetComponent<Text>().text;
            popup.ShowPopUp(popupMessage);
            // Destroy the game object from the scene
            // Destroy(gameObject);
            gameObject.SetActive(false);
            // Set the state to "collected"
            collected = true;
           // and the loop stops
           break;
        }
      }
    }
}
