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
        public PNJ(string name, string genre, int maxHp, ICollection<Items.Item> items, Location.Cell currentCell):base(name, genre, items, currentCell, maxHp)
        {
        }
    }
}

