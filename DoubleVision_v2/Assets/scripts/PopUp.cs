using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopUp : MonoBehaviour
{
    public Text PopUpText;

    public void ShowPopUp(string text)
    {
        gameObject.SetActive(true);
        PopUpText.text = text;
        StartCoroutine("WaitForSec");
    }

    IEnumerator WaitForSec()
    {
        yield return new WaitForSeconds(5);
        gameObject.SetActive(false);
    }

    public void HidePopUp()
    {
        gameObject.SetActive(false);
    }
}
