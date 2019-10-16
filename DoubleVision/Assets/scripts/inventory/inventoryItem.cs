using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "New Item", menuName = "Inventory/Items")]
public class inventoryItem : ScriptableObject
{
  public string itemName;
  public string itemDescription;
  public Sprite itemImage;
  public bool usable;
}
