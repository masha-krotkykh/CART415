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
        // Targeting GameObjects to get access to ttheir properties set in other scripts
        hatchet = GameObject.Find("hatchet");


        // Check if the object was aready collected on the previous visit
        if (PlayerPrefs.GetInt("hatchetCollected")==1)
        {

            // And destroy it from the scene 
            // -------------------->>           Destroy(pills);


            // TEMPORARY! REMOVE BEFORE BUILD

            Debug.Log("hatchet is already collected");
            hatchetCollected = 0;

            //-----------------------------------//
        }
    }


    // Instruct the button to take player to another scene "back of the room"
    public void GoBack()
    {
      SaveVars();
      SceneManager.LoadScene("room_00_back");
    }


    // Access "Pickup" component of the GamObject to check if it's been collected and if so, set it's state to 1
    // and save this value for future visits
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
