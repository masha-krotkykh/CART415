using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Interactions_00_front : MonoBehaviour
{

    public int hatchetCollected = 0;

    public GameObject hatchet;



    // Start is called before the first frame update
    void Start()
    {

        hatchet = GameObject.Find("hatchet");

        if (PlayerPrefs.GetInt("hatchetCollected")==1)
        {
            // -------------------->>           Destroy(pills);


            // TEMPORARY REMOVE BEFORE BUILD

            Debug.Log("hatchet is already collected");
            hatchetCollected = 0;

            //-----------------------------------//
        }
    }

    public void GoBack()
    {
      SaveVars();
      SceneManager.LoadScene("room_00_back");
    }

    public void SaveVars()
    {
        if (hatchet != null)
        {
            Pickup pickup = hatchet.GetComponent<Pickup>();
            if (pickup.collected == true)
            {
                hatchetCollected = 1;
            }
        }
        PlayerPrefs.SetInt("hatchetCollected", hatchetCollected);
    }
}
