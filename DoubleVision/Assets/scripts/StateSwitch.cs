using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateSwitch : MonoBehaviour
{

    bool showHidden = false;


    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            showHidden = !showHidden;
            if(showHidden)
            {
                GameObject[] hiddenObjects = GameObject.FindGameObjectsWithTag("Hidden");

                foreach(GameObject go in hiddenObjects)
                {
                    go.GetComponent<SpriteRenderer>().enabled = true;
                    go.GetComponent<BoxCollider2D>().enabled = true;
                }

                GameObject[] realObjects = GameObject.FindGameObjectsWithTag("Real");

                foreach (GameObject go in realObjects)
                {
                    go.GetComponent<SpriteRenderer>().enabled = false;
                    go.GetComponent<BoxCollider2D>().enabled = false;
                }
            }

            else
            {
                GameObject[] hiddenObjects = GameObject.FindGameObjectsWithTag("Hidden");

                foreach (GameObject go in hiddenObjects)
                {
                    go.GetComponent<SpriteRenderer>().enabled = false;
                    go.GetComponent<BoxCollider2D>().enabled = false;
                }

                GameObject[] realObjects = GameObject.FindGameObjectsWithTag("Real");

                foreach (GameObject go in realObjects)
                {
                    go.GetComponent<SpriteRenderer>().enabled = true;
                    go.GetComponent<BoxCollider2D>().enabled = true;
                }
            }
        }
    }
}
