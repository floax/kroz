using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KROZ.Items
{
    [Table("Item")]
    public class Item
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [MaxLength(50)]
        [Column("Name")]
        public string name { get; set; }

        //Relations
        public ICollection<Location.Cell> cells;
        public ICollection<Menus.Inventory> inventory;

        public Item(string name)
        {
            this.name = name;
        }
    }
}
