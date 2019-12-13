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
            List<Food> invFood = new List<Food>();

            Console.WriteLine();
            Console.WriteLine("FOOD\n");

            foreach (Item item in inventory)
            {
                if (item.GetType() == typeof(Food))
                {
                    Food invFoodItem = (Food)item;
                    invFood.Add(invFoodItem);
                }
            }

            if (invFood.Count == 0)
            {
                Console.WriteLine("No food in the inventory");
            }
            else
            {
                foreach (Food food in invFood)
                {
                    int x = 0;
                    Console.WriteLine();
                    Console.WriteLine($"{x}. {food.itemName}");
                    Console.WriteLine($"Uses: {food.uses}");
                    x++;
                }

                int userStringSelection;

                Console.WriteLine("Make your selection: ");

                userStringSelection = Convert.ToInt32(Console.ReadLine());

                Food userSelectedItem = invFood.ElementAt(userStringSelection);

                if (userSelectedItem.uses - 1 < 0)
                {
                    Console.WriteLine($"{userSelectedItem.itemName} depleted");
                    invFood.Remove(userSelectedItem);
                    inventory.Remove(userSelectedItem);
                }
                else
                {
                    pet.EatFood(userSelectedItem);
                }
            }
        }

        public void DisplayToy(Pet pet)
        {
            List<Toy> invToy = new List<Toy>();

            Console.WriteLine();
            Console.WriteLine("TOYS\n");

            foreach (Item item in inventory)
            {
                if (item.GetType() == typeof(Toy))
                {
                    Toy invToyItem = (Toy)item;
                    invToy.Add(invToyItem);
                }
            }

            if (invToy.Count == 0)
            {
                Console.WriteLine("No toys in the inventory");
            }
            else
            {
                foreach (Toy toy in invToy)
                {
                    int x = 0;
                    Console.WriteLine();
                    Console.WriteLine($"{x}. {toy.itemName}");
                    Console.WriteLine($"Uses: {toy.uses}");
                    x++;
                }

                int userStringSelection;

                Console.WriteLine("Make your selection: ");

                userStringSelection = Convert.ToInt32(Console.ReadLine());

                Toy userSelectedItem = invToy.ElementAt(userStringSelection);

                if (userSelectedItem.uses - 1 < 0)
                {
                    Console.WriteLine($"{userSelectedItem.itemName} depleted");
                    invToy.Remove(userSelectedItem);
                    inventory.Remove(userSelectedItem);
                }
                else
                {
                    pet.PlayWithToy(userSelectedItem);
                }
            }
        }

        public void DisplayMedicine(Pet pet)
        {
            List<Medicine> invMedicine = new List<Medicine>();

            Console.WriteLine();
            Console.WriteLine("MEDICINE\n");

            foreach (Item item in inventory)
            {
                if (item.GetType() == typeof(Medicine))
                {
                    Medicine invMedicineItem = (Medicine)item;
                    invMedicine.Add(invMedicineItem);
                }
            }

            if (invMedicine.Count == 0)
            {
                Console.WriteLine("No medicine in the inventory");
            }
            else
            {
                foreach (Medicine medicine in invMedicine)
                {
                    int x = 0;
                    Console.WriteLine();
                    Console.WriteLine($"{x}. {medicine.itemName}");
                    Console.WriteLine($"Uses: {medicine.uses}");
                    x++;
                }

                int userStringSelection;

                Console.WriteLine("Make your selection: ");

                userStringSelection = Convert.ToInt32(Console.ReadLine());

                Medicine userSelectedItem = invMedicine.ElementAt(userStringSelection);

                if (userSelectedItem.uses - 1 < 0)
                {
                    Console.WriteLine($"{userSelectedItem.itemName} depleted");
                    invMedicine.Remove(userSelectedItem);
                    inventory.Remove(userSelectedItem);
                }
                else
                {
                    pet.TakeMedicine(userSelectedItem);
                }
            }
        }
    }
}