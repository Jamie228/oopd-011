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

        public void DisplayFood(Pet pet)
        {
            foreach(Food item in inventory)
            {
                int x = 0;
                Console.WriteLine($"{x}. {item.itemName}");
                Console.WriteLine();
                x ++;
            }
            Console.WriteLine("Enter your selection:");

            int userSelectedFood = Convert.ToInt32(Console.ReadLine());
            Food selectedFood = (Food)inventory.ElementAt(userSelectedFood);

            if (selectedFood.uses -1 < 0)
            {
                Console.WriteLine($"Your {selectedFood.itemName} is depleted");
                inventory.Remove(selectedFood);
            }
            else
            {
                pet.EatFood(selectedFood);
            }
        }

        public void DisplayToys(Pet pet)
        {
            foreach(Toy item in inventory)
            {
                int x = 0;
                Console.WriteLine($"{x}. {item.itemName}");
                Console.WriteLine();
                x ++;
            }
            Console.WriteLine("Enter your selection:");

            int userSelectedFood = Convert.ToInt32(Console.ReadLine());
            Toy selectedToy = (Toy)inventory.ElementAt(userSelectedFood);

            if (selectedToy.uses -1 < 0)
            {
                Console.WriteLine($"Your {selectedToy.itemName} is depleted");
                inventory.Remove(selectedToy);
            }
            else
            {
                pet.PlayWithToy(selectedToy);
            }
        }


        public void DisplayMedicine(Pet pet)
        {
            foreach(Medicine item in inventory)
            {
                int x = 0;
                Console.WriteLine($"{x}. {item.itemName}");
                Console.WriteLine();
                x ++;
            }
            Console.WriteLine("Enter your selection:");

            int userSelectedMed = Convert.ToInt32(Console.ReadLine());
            Medicine selectedMed = (Medicine)inventory.ElementAt(userSelectedMed);

            if (selectedMed.uses -1 < 0)
            {
                Console.WriteLine($"Your {selectedMed.itemName} is depleted");
                inventory.Remove(selectedMed);
            }
            else
            {
                pet.TakeMedicine(selectedMed);
            }
        }
    }
}