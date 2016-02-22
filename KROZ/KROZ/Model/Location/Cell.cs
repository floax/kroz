using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KROZ.Location
{
    public class Cell
    {
        protected const int MAX_MONSTER_RATE = 25;

        //Unnullable fields
        public int posX { get; set; }
        public int posY { get; set; }
        public Boolean canMoveTo { get; set; }
        public int monsterRate { get; set; }

        //Nullable Fields
        public string description { get; set; }
        public int monsterGroup { get; set; }

        //Relations
        ICollection<Characters.Character> charaters;
        ICollection<Items.Item> items;

        public Cell(int posX, int posY, Boolean canMoveTo)
        {
            this.posX = posX;
            this.posY = posY;
            this.canMoveTo = canMoveTo;

            Random rnd = new Random();
            this.monsterRate = rnd.Next(MAX_MONSTER_RATE);
        }
    }
}
