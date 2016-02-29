using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KROZ.Characters
{
    [Table("Monster")]
    public class PNJ : Character
    {
        public PNJ(string name, string genre, int maxHp, Menus.Inventory inventory = null, Location.Cell currentCell = null):base(name, genre, inventory, currentCell, maxHp)
        {
        }
    }
}

