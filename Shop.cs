using System;
using System.Collections.Generic;
using System.Linq;

namespace oopd_011
{
    class Shop
    {
        List<Item> shop = new List<Item>();
        public Shop()
        {
            Toy ball = new Toy("Ball", 10, 3, 5);
            Toy chewToy = new Toy("Chew Toy", 20, 5, 10);
            Food cheapFood = new Food("Basic Pet Food", 15, 1, 15);
            Food expFood = new Food("Luxury Pet Food", 75, 1, 45);
            Medicine medicine = new Medicine("Pet Medicine", 25, 1, 25, 25);

            shop.Add(ball);
            shop.Add(chewToy);
            shop.Add(cheapFood);
            shop.Add(expFood);
            shop.Add(medicine);
        }

        public void UpdateItems()
        {
            shop.Clear();

            Toy ball = new Toy("Ball", 10, 3, 5);
            Toy chewToy = new Toy("Chew Toy", 20, 5, 10);
            Food cheapFood = new Food("Basic Pet Food", 15, 1, 15);
            Food expFood = new Food("Luxury Pet Food", 75, 1, 45);
            Medicine medicine = new Medicine("Pet Medicine", 25, 1, 25, 25);

            shop.Add(ball);
            shop.Add(chewToy);
            shop.Add(cheapFood);
            shop.Add(expFood);
            shop.Add(medicine);
        }

        public void PrintShopList(Player player)
        {
            UpdateItems();
            Console.WriteLine();
            Console.WriteLine("--- SHOP ---");
            int x = 0;
            foreach (Item item in shop)
            {
                Console.WriteLine(x + ". " + item.itemName);
                Console.WriteLine(item.GetType());
                Console.WriteLine($"Cost: {item.cost} coins");
                Console.WriteLine();
                x ++;
            }
            Shopping(player);
        }

        public void Shopping(Player player)
        {
            Console.WriteLine("Enter your shop selection: ");
            int userShoppingChoice = Convert.ToInt32(Console.ReadLine());
            Item selectedItem = shop.ElementAt(userShoppingChoice);
            BuyItem(selectedItem, player);
        }

        public void BuyItem(Item selectedItem, Player player)
        {
            if (player.coins - selectedItem.cost < 0)
            {
                Console.WriteLine("Not enough coins");
                Shopping(player);
            }
            else
            {
                player.coins = player.coins - selectedItem.cost;
                player.inventory.AddToInventory(selectedItem); 
            }
        }

    }
}