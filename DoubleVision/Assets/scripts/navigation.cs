using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class navigation : MonoBehaviour
{

   // functions to change locations
   public void goBack()
   {
      SceneManager.LoadScene("room_00_back");
   }

   public void goFront()
   {
     SceneManager.LoadScene("room_00_front");
   }

   public void goLeft()
   {
     SceneManager.LoadScene("room_00_left");
   }

   // functions to be called when a game object is clicked
    void OnMouseDown()
    {

    }
}
