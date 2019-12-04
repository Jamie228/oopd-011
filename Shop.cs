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
            Item ball = new Item("Ball", 10);
            Item toy = new Item("Toy", 20);

            shop.Add(ball);
            shop.Add(toy);
        }

        public void PrintShopList(Player player)
        {
            int x = 0;
            foreach (Item item in shop)
            {
                Console.WriteLine(x + ". " + item.itemName);
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
                //player.inventory.AddToInventory(item); 
            }
        }

    }
}