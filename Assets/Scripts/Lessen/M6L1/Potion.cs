using UnityEngine;

public class Potion : InventoryItem
{
    public int healAmount;

    public Potion(string name, int healAmount) : base(name)
    {
        this.healAmount = healAmount;
    }

    public override void Use()
    {
        Debug.Log(itemName + "Healt" + healAmount + "HP");
    }
}
