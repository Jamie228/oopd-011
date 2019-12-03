using System;
using System.Collections.Generic;

namespace oopd_011
{
    class Inventory
    {
        List<Item> inventory = new List<Item>();

        public void AddToInventory(Item item)
        {
            inventory.Add(item);
        }

        public void DisplayInventory()
        {
            int x = 0;
            foreach (Item item in inventory)
            {
                Console.WriteLine(x + ". " + item.itemName);
                x++;
            }
        }
    }
}