using UnityEngine;

public class InventoryTester : MonoBehaviour
{
    InventorySystem inventory;
    void Start()
    {
        inventory = new InventorySystem();

        inventory.AddItem(new Weapon("Zwaard", 10));
        inventory.AddItem(new Potion("`Health Potion", 25));
        inventory.AddItem(new Armor ("Shield", 5));

        inventory.ShowInventory();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            inventory.UseItem(0);
        }

        if (Input.GetKeyDown(KeyCode.P))
        {
            inventory.UseItem(1);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            inventory.UseItem(2);
        }
    }
}
