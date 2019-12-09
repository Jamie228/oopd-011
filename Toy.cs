using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace oopd_011
{
    class Toy : Item
    {
        public int moodInc;

        public Toy(string itemName, int cost, int uses, int moodInc) : base(itemName, cost, uses)
        {
            this.itemName = itemName;
            this.cost = cost;
            this.uses = uses;

            this.moodInc = moodInc;
        }    
    }
}