using System;
using System.Collections.Generic;

namespace oopd_011
{
    class Inventory
    {
        List<Item> inventory = new List<Item>();

        public void AddToInventory(Item item)
        {
            Player.inventory.Add(item);
        }

        public void DisplayInventory()
        {
            foreach (Item item in inventory)
            {
                Console.WriteLine(item.itemName);
            }
        }
    }
}