using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KROZ.Items
{
    public abstract class Item
    {
        protected int id{ get; set; }
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
