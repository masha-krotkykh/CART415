using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateSwitch : MonoBehaviour
{
    // Script to switch between "lucid" and "delirious" states
    bool showHidden = false;


    // Update is called once per frame
    void Update()
    {

        // For now on spacebar key press
        if(Input.GetKeyDown(KeyCode.Space))
        {
            // switch between the two states back and forth
            showHidden = !showHidden;

            // If the current state is "delirious" player sees what's hidden
            if(showHidden)
            {
                GameObject[] hiddenObjects = GameObject.FindGameObjectsWithTag("Hidden");

                foreach(GameObject go in hiddenObjects)
                {
                    go.GetComponent<SpriteRenderer>().enabled = true;
                    go.GetComponent<BoxCollider2D>().enabled = true;
                }


                // but doesn't see real interactible objects
                GameObject[] realObjects = GameObject.FindGameObjectsWithTag("Real");

                foreach (GameObject go in realObjects)
                {
                    go.GetComponent<SpriteRenderer>().enabled = false;
                    go.GetComponent<BoxCollider2D>().enabled = false;
                }
            }


            // Oposite situation in "lucid" state
            // hidden objects disappear and the real ones reappear
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
