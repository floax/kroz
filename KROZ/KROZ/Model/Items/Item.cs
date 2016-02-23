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
    public abstract class Item
    {
        [Key]
        protected int ID { get; set; }
        [Required]
        [MaxLength(50)]
        [Column("Name")]
        protected string name { get; set; }

        //Relations
        public ICollection<Characters.Character> characters;
        public ICollection<Location.Cell> cells;

        public Item(string name)
        {
            this.name = name;
        }
    }
}
