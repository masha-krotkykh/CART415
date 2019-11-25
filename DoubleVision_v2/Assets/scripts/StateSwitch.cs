using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StateSwitch : MonoBehaviour
{
    // Script to switch between "lucid" and "delirious" states

    // By default set to "lucid"
    bool showHidden = false;


    // An array of all hidden and real objects
    GameObject[] hiddenObjects;
    GameObject[] realObjects;
    GameObject hiddenBG;
    GameObject realBG;

    // After the script starts it starts listenning for the scene change event 
    private void Start()
    {
        SceneManager.sceneLoaded += OnSceneFinishedLoading;
    }

    // Update is called once per frame
    // Listens for th space bar press event
    public void SwitchLucid()
    {
        // Switch between two states
        showHidden = false;
        ShowObjects();
    }

    public void SwitchDelirious()
    {
        // Switch between two states
        showHidden = true;
        ShowObjects();
    }


// Since currently the state is not checked and resets to default when the scene changes.
// So, another event to trigger Switch methods is scene change. 
void OnSceneFinishedLoading(Scene scene, LoadSceneMode mode)
    {
        ShowObjects();
    }



    // Method describing switching between two typs of objects to be displayed 
    public void ShowObjects()
    {

        hiddenObjects = GameObject.FindGameObjectsWithTag("Hidden");
        realObjects = GameObject.FindGameObjectsWithTag("Real");

        hiddenBG = GameObject.FindGameObjectWithTag("HiddenBG");
        realBG = GameObject.FindGameObjectWithTag("RealBG");


        // If the current state is "delirious" player sees "hidden" interactable objects
        // If the current state is "delirious" player sees HiddenBG video
        // If the current state is "lucid" player sees RealBG video
        if (showHidden)
        {

            foreach (GameObject go in hiddenObjects)
            {
                if(go.GetComponent<BoxCollider2D>() != null)
                {
                    go.GetComponent<BoxCollider2D>().enabled = true;
                }

                if (go.GetComponent<SpriteRenderer>() != null)
                {
                    go.GetComponent<SpriteRenderer>().enabled = true;
                }


            }


            // but doesn't see "real" interactible objects

            foreach (GameObject go in realObjects)
            {
                if (go.GetComponent<BoxCollider2D>() != null)
                {
                    go.GetComponent<BoxCollider2D>().enabled = false;
                }

                if (go.GetComponent<SpriteRenderer>() != null)
                {
                    go.GetComponent<SpriteRenderer>().enabled = false;
                }
            }

            hiddenBG.GetComponent<UnityEngine.Video.VideoPlayer>().enabled = true;
            realBG.GetComponent<UnityEngine.Video.VideoPlayer>().enabled = false;
        }


        // Oposite situation in "lucid" state
        // "hidden" objects disappear and the "real" ones reappear
        else
        {

            foreach (GameObject go in hiddenObjects)
            {
                if (go.GetComponent<BoxCollider2D>() != null)
                {
                    go.GetComponent<BoxCollider2D>().enabled = false;
                }

                if (go.GetComponent<SpriteRenderer>() != null)
                {
                    go.GetComponent<SpriteRenderer>().enabled = false;
                }
            }


            foreach (GameObject go in realObjects)
            {
                if (go.GetComponent<BoxCollider2D>() != null)
                {
                    go.GetComponent<BoxCollider2D>().enabled = true;
                }

                if (go.GetComponent<SpriteRenderer>() != null)
                {
                    go.GetComponent<SpriteRenderer>().enabled = true;
                }
            }


            hiddenBG.GetComponent<UnityEngine.Video.VideoPlayer>().enabled = false;
            realBG.GetComponent<UnityEngine.Video.VideoPlayer>().enabled = true;
        }


    }

}

