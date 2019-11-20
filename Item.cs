using System;

namespace oopd_011
{
    class Item
    {
        public string itemName;
        public int moodModifier;
        public int cost;
        public int uses;
        public Item(string itemName, int moodModifier, int cost, int uses)
        {
            this.itemName = itemName;
            this.moodModifier = moodModifier;
            this.cost = cost;
            this.uses = uses;
        }
    }
}