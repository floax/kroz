using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KROZ.Characters
{
    [Table("Character")]
    public abstract class Character
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [Column("Name")]
        [MaxLength(50)]
        public string name { get; set; }
        [Required]
        [Column("Genre")]
        [MaxLength(50)]
        public string genre { get; set; }
        [Required]
        [Column("HP")]
        public int hp { get; set; }
        [Required]
        [Column("MaxHP")]
        public int maxHP { get; set; }
        [Required]
        [Column("Level")]
        public int level { get; set; }
        [Required]
        [Column("CurrentCell")]
        public Location.Cell currentCell { get; set; }

        //Relations
        public ICollection<Items.Item> items { get; set; }

        public Character(string name, string genre, ICollection<Items.Item> items, Location.Cell currentCell, int maxHp = 100, int level = 1)
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
