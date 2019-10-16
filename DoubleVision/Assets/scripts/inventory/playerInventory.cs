using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Inventory", menuName = "Inventory/Player Inventory")]
public class playerInventory : ScriptableObject
{
    public List<inventoryItem> currentInventory = new List<inventoryItem>();
}
