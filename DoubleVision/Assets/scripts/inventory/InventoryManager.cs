using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour
{
    public Transform KnifeItem; //you need one prefab like this for each tiem
    public Transform PillsItem;
    public Transform WallpaperItem;
    public Transform NailItem;



    public Text ItemLabel; //this is only for debug, ideally you would have an image following the cursor
   


    // Creating static vars to be accessed from across multiple scenes

    public static string CurrentItem = ""; //this is the public variable that you can check to see if the current item is selected.



    void Start()
    {
        UpdateInventory(); //Display what we have right now.
    }

    // Update is called once per frame
    void Update()
    {
        //Remove current selected object with right click
        if (Input.GetMouseButtonDown(1))
        {
            SelectItem("none");
        }



    }

    public void SelectItem(string ItemName)
    {
        //Register the name of selected object and updates the debug label.
        CurrentItem = ItemName;
        ItemLabel.text = ItemName;
    }
    public void RemoveItem(string ItemName)
    {
        //We remove the item from playerprefs and select nothing
        PlayerPrefs.SetInt(ItemName, 0);
        SelectItem("none");
        //Update the visual inventory
        UpdateInventory();
    }

    public void AddItem(string ItemName)
    {
        //We add the item to playerprefs and select the item
        PlayerPrefs.SetInt(ItemName, 1);
        SelectItem(ItemName);
        //Update the visual inventory
        UpdateInventory();
    }

    public void UpdateInventory()
    {
        //First we clear all the grandchildren of the inventory objects (the items)
        foreach (Transform child in transform)
        {

          foreach (Transform grandChild in child)
            Destroy(grandChild.gameObject);
        }

        //Then we add all the items we have. You need of these for each of your item
        if (PlayerPrefs.GetInt("knife")==1)
        {
            Instantiate(KnifeItem, this.transform);
        }

        if (PlayerPrefs.GetInt("pills")==1)
        {
            Instantiate(PillsItem, this.transform);
        }

        if (PlayerPrefs.GetInt("wallpaper") == 1)
        {
            Instantiate(WallpaperItem, this.transform);
        }

        if (PlayerPrefs.GetInt("nail") == 1)
        {
            Instantiate(NailItem, this.transform);
        }
    }

}
