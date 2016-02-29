using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using KROZ.Items;

namespace KROZ.Menus
{
    [Table("Inventory")]
    public class Inventory
    {

        [Key]
        public int ID { get; set; }
        public List<Items.Item> weapons { get; set; }
        public List<Items.Item> usableItems { get; set; }

        public ICollection<Characters.Character> character { get; set; }

        public Inventory()
        {
            weapons = new List<Items.Item>();
            usableItems = new List<Items.Item>();

            init();
        }

        public void init()
        {
            Items.Weapon couteau = new Items.Weapon("couteau", 10, 70);
            Items.UsableItem potion = new Items.UsableItem("potion", 10, 0, 0);
            weapons.Add(couteau);
            usableItems.Add(potion);
        }

        public List<Items.Item> getInventory()
        {
            List<Items.Item> inventory = new List<Items.Item>();
            inventory.AddRange(weapons);
            inventory.AddRange(usableItems);

            return inventory;
        }
    }
}
