using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class inventoryManager : MonoBehaviour
{

    [Header("Inventory Information")]
    [SerializeField] private GameObject blankInventorySlot;
    [SerializeField] private GameObject inventoryPanel;
    [SerializeField] private Text descriptionText;

    public void SetText(string description)
    {
      descriptionText.text = description;
    }

    // Start is called before the first frame update
    void Start()
    {
      SetText("");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
