using System;
using System.Collections.Generic;

namespace oopd_011
{
    class Player
    {
        //public Inventory inventory = new Inventory();
        public int coins = 100;

        public void Update()
        {
            coins++;
        }

        public void DisplayCoins()
        {
            Console.WriteLine($"Coins: {coins}");
        }

        
    }
}