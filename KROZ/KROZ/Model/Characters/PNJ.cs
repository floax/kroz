using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KROZ.Characters
{
    public class PNJ : Character
    {
        public PNJ(string name, string genre, int maxHp, ICollection<Items.Item> items, Location.Cell currentCell):base(name, genre, maxHp, items, currentCell)
        {
            init();
        }

        void init()
        {
            level = 1;
        }
    }
}

