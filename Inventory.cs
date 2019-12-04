using System;
using System.Collections.Generic;
using System.Linq;

namespace oopd_011
{
    class Inventory
    {
        List<Item> inventory = new List<Item>();

        public void AddToInventory(Item item)
        {
            inventory.Add(item);
        }

        public void DisplayInventory(Pet pet)
        {
            int x = 0;
            foreach (Item item in inventory)
            {
                Console.WriteLine(x + ". " + item.itemName);
                Console.WriteLine();
                x++;
            }
            SelectItem(pet);
        }

        public void SelectItem(Pet pet)
        {
            Console.WriteLine();
            Console.WriteLine("Enter your selection:    ");
            int userSelection = Convert.ToInt32(Console.ReadLine());
            Item selectedInvItem = inventory.ElementAt(userSelection);
            //selectedInvItem.UseItem(pet);
        }
    }
}