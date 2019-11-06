using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Interactions : MonoBehaviour
{
  public PopUp popup;
  public InventoryManager inventory;
  public int Delirious = 0;

    // Start is called before the first frame update
    void Start()
    {
        // if(PlayerPrefs.GetInt("Delirious")==1)
        // {
        //   ShowHidden();
        // }
        // else
        // {
        //   HideHidden();
        // }
    }

    public void goBack()
    {
    //  SaveVars();
      SceneManager.LoadScene("room_00_back");
    }

    public void goFront()
    {
      //SaveVars();
      SceneManager.LoadScene("room_00_front");
    }

    // public void ShowHidden()
    // {
    //   GameObject[] hiddenObjects = GameObject.FindGameObjectsWithTag ("Hidden");
    //       foreach (GameObject hiddenObject in hiddenObjects) {
    //           hiddenObject.SetActive(true);
    //       }
    // }


    // Update is called once per frame
    void Update()
    {

    }
}
