using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace oopd_011
{
    class Item
    {
        public string itemName;
        public int cost;

       

        //Player player = new Player();

        public Item(string itemName, int cost)
        {
            this.itemName = itemName;
            this.cost = cost;
        }


    }
}