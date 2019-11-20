using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Interactions_00_front : MonoBehaviour
{

    public int knifeCollected;
    public int nailCollected;

    public GameObject knife;
    public GameObject nail;


    // Start is called before the first frame update
    void Start()
    {
		// Targeting GameObjects to get access to their properties set in other scripts
		knife = GameObject.Find("knife");
        nail = GameObject.Find("nail");


		// Check if the object was aready collected on the previous visit
		if (PlayerPrefs.GetInt("knifeCollected") == 1)
		{
			knifeCollected = 1;
			// And destroy it from the scene 
			// --------------------> Destroy(knife);

			// TEMPORARY! REMOVE BEFORE BUILD

			//Debug.Log("knife is already collected");
			knifeCollected = 0;


			//-----------------------------------//
		}

        else
		{
			knifeCollected = 0;
		}


        if (PlayerPrefs.GetInt("nailCollected") == 1)
        {
            nailCollected = 1;
            // And destroy it from the scene 
            // --------------------> Destroy(nail);

            // TEMPORARY! REMOVE BEFORE BUILD

            //Debug.Log("nail is already collected");
            nailCollected = 0;


            //-----------------------------------//
        }

        else
        {
            nailCollected = 0;
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
        if (knife != null)
        {
            Pickup pickup = knife.GetComponent<Pickup>();
            if (pickup.collected == true)
            {
                knifeCollected = 1;
            }
        }

        else if (knife == null)
		{
			knifeCollected = 1;
		}


        if (nail != null)
        {
            Pickup pickup = nail.GetComponent<Pickup>();
            if (pickup.collected == true)
            {
                nailCollected = 1;
            }
        }

        else if (nail == null)
        {
            nailCollected = 1;
        }



        PlayerPrefs.SetInt("knifeCollected", knifeCollected);
        PlayerPrefs.SetInt("nailCollected", nailCollected);



    }
}



