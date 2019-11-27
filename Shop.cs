using System;
using System.Collections.Generic;
using System.Linq;

namespace oopd_011
{
    class Shop
    {
        Player player = new Player();
        List<Item> shop = new List<Item>();
        public Shop()
        {
            Item ball = new Item("Ball", 10);
            Item toy = new Item("Toy", 20);

            shop.Add(ball);
            shop.Add(toy);
        }

        public void PrintShopList()
        {
            int x = 0;
            foreach (Item item in shop)
            {
                Console.WriteLine(x + ". " + item.itemName);
                Console.WriteLine($"Cost: {item.cost} coins");
                Console.WriteLine();
                x ++;
            }
            Shopping();
        }

        public void Shopping()
        {
            Console.WriteLine("Enter your shop selection: ");
            int userShoppingChoice = Convert.ToInt32(Console.ReadLine());
            Item selectedItem = shop.ElementAt(userShoppingChoice);
            BuyItem(selectedItem);
        }

        public void BuyItem(Item item)
        {
            if (player.coins - item.cost < 0)
            {
                Console.WriteLine("Not enough coins");
                Shopping();
            }
            else
            {
                player.coins = player.coins - item.cost;
                player.inventory.AddToInventory(item);
                player.inventory.DisplayInventory();
                
            }
            
        }
    }
}