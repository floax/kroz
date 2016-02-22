using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KROZ.Characters
{
    class PJ : Character
    {
        protected int xP { get; set; }

        public PJ(string name, string genre, ICollection<Items.Item> items, ICollection<Items.UsableItem> objects, Location.Cell currentCell, int maxHp) :base(name, genre, items, currentCell, maxHp)
        {
            this.xP = 0;
        }
    }
}
