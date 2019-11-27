﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pickup : InventoryManager
{
    public PopUp popup;

    public static string nameOfObject;
    public static string popupMessage;

    private Inventory inventory;
    public GameObject itemButton;

    public static int knifeCollected = 0;
    public static int nailCollected = 0;
    public static int pillsCollected = 0;
    public static int wallpaperCollected = 0;
    public static int crowbarCollected = 0;
    public static int keyCollected = 0;


    // Start is called before the first frame update
    private void Start()
        {
            inventory = GameObject.FindGameObjectWithTag("EventSystem").GetComponent<Inventory>();
        }

    // look through the array of inventory slots to check is each of themis full
    public void CollectItem()
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
        
            ShowPopup();

            // Destroy the game object from the scene
            Destroy(gameObject);


            // Set the state to "collected"
            if (nameOfObject == "knife")
            {
                knifeCollected = 1;
            }

            if (nameOfObject == "nail")
            {
                nailCollected = 1;
            }

            if (nameOfObject == "wallpaper")
            {
                wallpaperCollected = 1;
            }

            if (nameOfObject == "pills")
            {
                pillsCollected = 1;
            }

            if (nameOfObject == "crowbar")
            {
                crowbarCollected = 1;
            }

            if (nameOfObject == "key")
            {
                keyCollected = 1;
            }

                SaveVars();

            // and the loop stops
            break;
        }
      }

    }

    public void ShowPopup()
    {
        //Getting an individual message from gameObject to display in a popup
            popupMessage = gameObject.GetComponent<Text>().text;
            popup.ShowPopUp(popupMessage);
    }

    // Save variable values for future 
    public void SaveVars()
    {
        PlayerPrefs.SetInt("knifeCollected", knifeCollected);
        PlayerPrefs.SetInt("nailCollected", nailCollected);
        PlayerPrefs.SetInt("pillsCollected", pillsCollected);
        PlayerPrefs.SetInt("wallpaperCollected", wallpaperCollected);
        PlayerPrefs.SetInt("crowbarCollected", crowbarCollected);
        PlayerPrefs.SetInt("keyCollected", keyCollected);



        // -------------------- TEST REMOVE ON BUILD ------------------ //
        //PlayerPrefs.SetInt("knifeCollected", 0);
        //PlayerPrefs.SetInt("nailCollected", 0);
        //PlayerPrefs.SetInt("pillsCollected", 0);
        //PlayerPrefs.SetInt("wallpaperCollected", 0);
        //PlayerPrefs.SetInt("crowbarCollected", 0);
    }


}
