using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Interactions_00_front : MonoBehaviour
{

    public int knifeCollected = 0;

    public GameObject knife;



    // Start is called before the first frame update
    void Start()
    {
        // Targeting GameObjects to get access to ttheir properties set in other scripts
        knife = GameObject.Find("knife");


        // Check if the object was aready collected on the previous visit
        if (PlayerPrefs.GetInt("knifeCollected")==1)
        {

            // And destroy it from the scene 
            // -------------------->>           Destroy(pills);


            // TEMPORARY! REMOVE BEFORE BUILD

            Debug.Log("knife is already collected");
            knifeCollected = 0;

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
        if (knife != null)
        {
            Pickup pickup = knife.GetComponent<Pickup>();
            if (pickup.collected == true)
            {
                knifeCollected = 1;
            }
        }
        PlayerPrefs.SetInt("knifeCollected", knifeCollected);
    }
}
