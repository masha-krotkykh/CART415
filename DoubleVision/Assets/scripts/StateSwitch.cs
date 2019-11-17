using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateSwitch : MonoBehaviour
{
    // Script to switch between "lucid" and "delirious" states
    bool showHidden = false;

    GameObject[] hiddenObjects;
    GameObject[] realObjects;
    GameObject hiddenBG;
    GameObject realBG;

    private void Start()
    {
        SwitchVideos();
        ShowObjects();
    }

    // Update is called once per frame
    void Update()
    {

        // For now on spacebar key press
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // switch between the two states back and forth
            showHidden = !showHidden;
        }

        SwitchVideos();
        ShowObjects();
        Debug.Log(showHidden);


    }

    public void SwitchVideos()
    {
        hiddenBG = GameObject.FindGameObjectWithTag("HiddenBG");
        realBG = GameObject.FindGameObjectWithTag("RealBG");

        // If the current state is "delirious" player sees what's hidden
        if (showHidden)
        {
            // Same for the environment. Turn the "delirious" environment on
            // and the "lucid" environment off through videoplayer component


            hiddenBG.GetComponent<UnityEngine.Video.VideoPlayer>().enabled = true;
            realBG.GetComponent<UnityEngine.Video.VideoPlayer>().enabled = false;
        }


        // Oposite situation in "lucid" state
        else
        {

            hiddenBG.GetComponent<UnityEngine.Video.VideoPlayer>().enabled = false;
            realBG.GetComponent<UnityEngine.Video.VideoPlayer>().enabled = true;
        }
    }



    public void ShowObjects()
    {
        hiddenObjects = GameObject.FindGameObjectsWithTag("Hidden");
        realObjects = GameObject.FindGameObjectsWithTag("Real");

        // If the current state is "delirious" player sees what's hidden
        if (showHidden)
        {

            foreach (GameObject go in hiddenObjects)
            {
                go.GetComponent<SpriteRenderer>().enabled = true;
                go.GetComponent<BoxCollider2D>().enabled = true;
            }


            // but doesn't see real interactible objects


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

            foreach (GameObject go in hiddenObjects)
            {
                go.GetComponent<SpriteRenderer>().enabled = false;
                go.GetComponent<BoxCollider2D>().enabled = false;
            }


            foreach (GameObject go in realObjects)
            {
                go.GetComponent<SpriteRenderer>().enabled = true;
                go.GetComponent<BoxCollider2D>().enabled = true;
            }

        }
    }


}

