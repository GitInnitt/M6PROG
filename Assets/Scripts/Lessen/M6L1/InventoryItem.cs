using UnityEngine;

public class InventoryItem : MonoBehaviour
{
    public string itemName;

    public InventoryItem(string name)
    {
        itemName = name;
    }

    public virtual void Use()
    {
        Debug.Log("Je gebruikt" + itemName);
    }
}
  