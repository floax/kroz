using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KROZ.Characters
{
    [Table("Player")]
    class PJ : Character
    {
        [Required]
        [Column("XP")]
        public int xP { get; set; }

        public PJ(string name, string genre, ICollection<Items.Item> items, ICollection<Items.UsableItem> objects, Location.Cell currentCell, int maxHp) :base(name, genre, items, currentCell, maxHp)
        {
            this.xP = 0;
        }
    }
}
