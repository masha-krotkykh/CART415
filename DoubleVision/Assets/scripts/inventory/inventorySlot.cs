using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class inventorySlot : MonoBehaviour
{
    [Header("UI fields to change")]
    [SerializeField] private Image itemImage;

    [Header("Values from the item")]
    public inventoryItem thisItem;
    public inventoryManager thisManager;

    public void Setup(inventoryItem newItem, inventoryManager newManager)
    {
      thisItem = newItem;
      thisManager = newManager;
      if(thisItem != null)
      {
        itemImage.sprite = thisItem.itemImage;
      }
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
