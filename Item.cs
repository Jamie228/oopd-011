using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace oopd_011
{
    abstract class Item
    {
        public string itemName { get; set; }
        public int cost { get; set; }
        public int uses { get; set; }

        public Item(string itemName, int cost, int uses)
        {
            this.itemName = itemName;
            this.cost = cost;
            this.uses = uses;
        }

        public void UseItem(Item item)
        {
            if (item is Toy)
            {
                
            }
            else if (item is Food)
            {

            }
            else if (item is Medicine)
            {

            }
        }
    }
}