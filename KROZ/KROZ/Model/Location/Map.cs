using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KROZ.Location
{
    [Table("Map")]
    public class Map
    {
        protected const int SIZE = 20;
        [Key]
        public int ID { get; set; }
        [Required]
        [Column("Name")]
        public string name { get; set; }

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
