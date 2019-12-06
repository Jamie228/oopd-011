using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace oopd_011
{
    class Medicine : Item
    {
        public int healthInc;
        public int hungerInc;

        public Medicine(string itemName, int cost, int uses, int healthInc, int hungerInc) : base(itemName, cost, uses)
        {
            this.itemName = itemName;
            this.cost = cost;
            this.uses = uses;
            this.healthInc = healthInc;
            this.hungerInc = hungerInc;
        }
    }
}