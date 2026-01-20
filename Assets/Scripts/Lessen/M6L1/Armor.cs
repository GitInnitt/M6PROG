using System;
using UnityEngine;

public class Armor : InventoryItem
{
   public int Defense { get; set; }
    
    public Armor(string name, int defense) : base(name)
    {
         Defense = defense;
    }

    public override void Use()
    {
        Debug.Log($"{itemName} geeft {Defense} defense!");
    }
}
