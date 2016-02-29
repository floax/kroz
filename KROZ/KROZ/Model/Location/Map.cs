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
            cells = new List<Cell>();
        }

        public void createMap()
        {
            for(int i = 0; i <= SIZE;i++)
            {
                for(int j = 0; j <= SIZE; j++)
                {
                    cells.Add(new Cell(i,j, true));
                }
            }
        }

        public void saveMap()
        {

        }

        public void showMap(Characters.Character character)
        {
            for (int j = 0; j <= SIZE; j++)
            {
                for (int i = 0; i <= SIZE; i++)
                {
                    if(character.currentCell.posX != i || character.currentCell.posY != j)
                    {
                        if (i == 0 && j <= 20)
                        {
                            Console.Write("|");
                        }
                        else if (i < 20 && j == 0)
                        {
                            Console.Write("-");
                        }
                        else if (i < 20 && j == 20)
                        {
                            Console.Write("_");
                        }
                        else if (i == 20 && j <= 20)
                        {
                            Console.WriteLine("|");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    else if (character.currentCell.posX == i && character.currentCell.posY == j)
                    {
                        if (i == 20 && j <= 20)
                        {
                            Console.WriteLine("0");
                        }
                        else
                        {
                            Console.Write("0");
                        }
                    }
                }
            }
        }
    }
}
