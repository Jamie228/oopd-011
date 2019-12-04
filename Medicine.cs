using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace oopd_011
{
    class Medicine : Item
    {
        int healthInc;

        public Medicine(string itemName, int cost, int uses, int healthInc) : base(itemName, cost, uses)
        {
            this.itemName = itemName;
            this.cost = cost;
            this.uses = uses;
            this.healthInc = healthInc;
        }
    }
}