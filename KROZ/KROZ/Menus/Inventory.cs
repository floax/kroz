using System.Collections.Generic;
using KROZ.Items;

namespace KROZ.Menus
{
    class Inventory
    {
        List<Items.Item> items = new List<Items.Item>();

        public Inventory()
        {
            Items.Weapon couteau = new Items.Weapon("couteau", 10, 70);
            items.Add(couteau);
        }
        public void setItems(List<Items.Item> newItems)
        {
            this.items = newItems;
        }

        public ICollection<Items.Item> getItems()
        {
            return this.items;
        }
    }
}
