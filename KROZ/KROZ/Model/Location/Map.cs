using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KROZ.Location
{
    public class Map
    {
        protected const int SIZE = 20;
        protected int id { get; set; }
        protected string name { get; set; }

        public ICollection<Cell> cells;

        public Map(string name)
        {
            this.name = name;
        }

        void createMap()
        {
            for(int i = 0; i <= SIZE;i++)
            {
                for(int j = 0; j <= SIZE; j++)
                {
                    cells.Add(new Cell(i,j, true));
                }
            }
        }
    }
}
