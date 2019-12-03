using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryOpener : MonoBehaviour
{
    public GameObject Panel;

    bool isActive;

    public void OpenPanel()
    {
        if (Panel != null)
        {
            isActive = Panel.activeSelf;
            Panel.SetActive(!isActive);
        }
    }

   
    public void HidePanel()
    {
        Panel.SetActive(false);
    }

}
