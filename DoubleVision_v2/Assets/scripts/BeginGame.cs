using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BeginGame : MonoBehaviour
{

    public GameObject Panel;


    // Start is called before the first frame update
    void Start()
    {

        if (Panel != null)
        {
            Panel.SetActive(false);
        }


        SceneManager.LoadScene("room_00_front");
    }

}
