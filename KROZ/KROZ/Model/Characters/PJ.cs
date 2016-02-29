using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KROZ.Items;
using KROZ.Location;

namespace KROZ.Characters
{
    [Table("Player")]
    class PJ : Character
    {
        [Required]
        [Column("XP")]
        public int xP { get; set; }

        public PJ(string name = "Jerry", string genre = "M", Menus.Inventory inventory = null, Location.Cell currentCell = null, int maxHp = 100, int level = 1) : base(name, genre, inventory, currentCell, maxHp, level)
        {
            this.xP = 0;
        }
    }
}