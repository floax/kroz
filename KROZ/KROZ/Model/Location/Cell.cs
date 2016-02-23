using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KROZ.Location
{
    [Table("Cell")]
    public class Cell
    {
        protected const int MAX_MONSTER_RATE = 25;
        [Key]
        public int ID { get; set; }
        //Unnullable fields
        [Required]
        [Column("PosX")]
        public int posX { get; set; }
        [Required]
        [Column("PosY")]
        public int posY { get; set; }
        [Required]
        [Column("MoveTo")]
        public Boolean canMoveTo { get; set; }
        [Required]
        [Column("MonsterRate")]
        public int monsterRate { get; set; }

        //Nullable Fields
        [Column("Description")]
        public string description { get; set; }
        [Column("MonsterGroup")]
        public int monsterGroup { get; set; }

        //Relations
        ICollection<Characters.Character> charaters;
        ICollection<Items.Item> items;
        public ICollection<Map> maps { get; set; }

        public Cell(int posX, int posY, Boolean canMoveTo)
        {
            this.posX = posX;
            this.posY = posY;
            this.canMoveTo = canMoveTo;

            //Création aléatoire du pourcentage de chance de rencontre avec un monstre
            Random rnd = new Random();
            this.monsterRate = rnd.Next(MAX_MONSTER_RATE);
        }
    }
}
