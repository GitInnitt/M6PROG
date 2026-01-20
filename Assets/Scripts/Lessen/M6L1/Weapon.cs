using UnityEngine;

public class Weapon : InventoryItem
{
    public int damage;

    public Weapon(string name, int damage) : base(name)
    {
        this.damage = damage;
    }

    public override void Use()
    {
        Debug.Log(itemName + "Doet" + damage + "damage");
    }
}
