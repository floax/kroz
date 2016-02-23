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
        protected int ID { get; set; }
        [Required]
        [Column("Name")]
        [MaxLength(50)]
        protected string name { get; set; }
        [Required]
        [Column("Genre")]
        [MaxLength(50)]
        protected string genre { get; set; }
        [Required]
        [Column("HP")]
        protected int hp { get; set; }
        [Required]
        [Column("MaxHP")]
        protected int maxHP { get; set; }
        [Required]
        [Column("Level")]
        protected int level { get; set; }
        [Required]
        [Column("CurrentCell")]
        protected Location.Cell currentCell { get; set; }

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
