using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KROZ.Characters
{
    public abstract class Character
    {
        protected int id { get; set; }
        protected string name { get; set; }
        protected string genre { get; set; }
        protected int hp { get; set; }
        protected int maxHP { get; set; }
        protected int level { get; set; }
        protected Location.Cell currentCell { get; set; }

        //Relations
        public ICollection<Items.Item> items { get; set; }

        public Character(string name, string genre, ICollection<Items.Item> items, Location.Cell currentCell, int maxHp = 100)
        {
            this.name = name;
            this.genre = genre;
            this.maxHP = maxHp;
            this.items = items;
            this.currentCell = currentCell;
            
            //Init Default
            this.hp = maxHP;
            this.level = 1;
        }
    }
}
