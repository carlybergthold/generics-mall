using System.Collections.Generic;

namespace TheMall
{
    public class DollarStore : IStore<DollarItem>
    {
        private Dictionary<string, DollarItem> _inventory = new Dictionary<string, DollarItem>();
        private double _price = 1.00;

        public void AddToInventory(string name, DollarItem item)
        {
            _inventory.Add(name, item);
        }

        public DollarItem GetFromInventory(string name)
        {
            return _inventory[name];
        }

    }
}