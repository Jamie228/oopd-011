using System;
using System.Collections.Generic;

namespace oopd_011
{
    class ItemList
    {
        List<Item> itemList = new List<Item>();
        public void CreateItemList()
        {

            Item ball = new Item("Ball", 5, 10, 5);
            Item toy = new Item("Toy", 10, 20, 10);

            itemList.Add(ball);
            itemList.Add(toy);
        }

        public void PrintShopList()
        {
            int x = 0;
            foreach (Item item in itemList)
            {
                Console.WriteLine(x + ". " + item.itemName);
                Console.WriteLine($"Cost: {item.cost} coins");
                Console.WriteLine($"Uses: {item.uses}");
                Console.WriteLine();
                x ++;
            }
        }
    }
}