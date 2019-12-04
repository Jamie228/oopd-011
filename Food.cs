using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace oopd_011
{
    class Food : Item
    {
        int hungerInc;

        public Food(string itemName, int cost, int uses, int hungerInc) : base(itemName, cost, uses)
        {
            this.itemName = itemName;
            this.cost = cost;
            this.uses = uses;
            this.hungerInc = hungerInc;
        }


    }
}