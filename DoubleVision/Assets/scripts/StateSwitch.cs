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
    void Update()
    {
        // For now on spacebar key press environment changes from "lucid" to "delirious" and back
        if (Input.GetKeyDown(KeyCode.Space))
        {
            showHidden = !showHidden;
            // Method to switch between background videos
            SwitchVideos();
            // Method to show and hide hidden and real objects 
            ShowObjects();

            //Debug.Log(showHidden);
        }
    }

    // Since currently only initiation of the script and spacebar press check for the current player state, the state is not checked and reset to default when the scene changes.
    // So, another event to trigger Switch methods is scene change. 
    void OnSceneFinishedLoading(Scene scene, LoadSceneMode mode)
    {
        SwitchVideos();
        ShowObjects();

        Debug.Log(scene.name);
    }


    // Method describing the switch between two types of background videos depending on players current state
    public void SwitchVideos()
    {
        hiddenBG = GameObject.FindGameObjectWithTag("HiddenBG");
        realBG = GameObject.FindGameObjectWithTag("RealBG");

        // If the current state is "delirious" player sees HiddenBG video
        // If the current state is "lucid" player sees RealBG video
        if (showHidden)
        {
            hiddenBG.GetComponent<UnityEngine.Video.VideoPlayer>().enabled = true;
            realBG.GetComponent<UnityEngine.Video.VideoPlayer>().enabled = false;
        }

        else
        {

            hiddenBG.GetComponent<UnityEngine.Video.VideoPlayer>().enabled = false;
            realBG.GetComponent<UnityEngine.Video.VideoPlayer>().enabled = true;
        }
    }


    // Method describing switching between two typs of objects to be displayed 
    public void ShowObjects()
    {
        hiddenObjects = GameObject.FindGameObjectsWithTag("Hidden");
        realObjects = GameObject.FindGameObjectsWithTag("Real");

        // If the current state is "delirious" player sees "hidden" interactable objects
        if (showHidden)
        {

            foreach (GameObject go in hiddenObjects)
            {
                go.GetComponent<SpriteRenderer>().enabled = true;
                go.GetComponent<BoxCollider2D>().enabled = true;
            }


            // but doesn't see "real" interactible objects

            foreach (GameObject go in realObjects)
            {
                go.GetComponent<SpriteRenderer>().enabled = false;
                go.GetComponent<BoxCollider2D>().enabled = false;
            }
        }


        // Oposite situation in "lucid" state
        // "hidden" objects disappear and the "real" ones reappear
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

