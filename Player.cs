using System;
using System.Collections.Generic;

namespace oopd_011
{
    class Player
    {
        public int coins;
        public Inventory inventory = new Inventory();

        public Player(int coins)
        {
            this.coins = coins;
        }

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