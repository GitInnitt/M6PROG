using UnityEngine;
using System.Collections.Generic;
using Unity.VisualScripting;
using JetBrains.Annotations;

public class InventorySystem
{
    public List<InventoryItem> items = new List<InventoryItem>();

    public void AddItem(InventoryItem item)
    {
        items.Add(item);
        Debug.Log(item.itemName + "toegevoegd aan inventory");
    }

    public void RemoveItem(int index)
    {
        if (index >= 0 && index < items.Count)
        {
            Debug.Log(items[index].itemName + "verwijderd uit inventory");
            items.RemoveAt(index);
        }
    }

    public void ShowInventory()
    {
        Debug.Log("Inventory:");
        for (int i = 0; i < items.Count; i++)
        {
            Debug.Log(i + ": " + items[i].itemName);
        }
    }

    public void UseItem(int index)
    {
        if (index >= 0 && index < items.Count)
        {
            items[index].Use();
        }
    }
}
