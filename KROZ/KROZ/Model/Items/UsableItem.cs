using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KROZ.Items
{
    [Table("UsableItem")]
    public class UsableItem : Item
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [Column("RestoreHP")]
        protected int restoreHP { get; set; }
        [Required]
        [Column("AttackBoost")]
        protected int attackBoost { get; set; }
        [Required]
        [Column("DefenseBoost")]
        protected int defenseBoost { get; set; }


        public UsableItem(string name, int RHP, int AB, int DB) : base(name)
        {
            this.restoreHP = RHP;
            this.attackBoost = AB;
            this.defenseBoost = DB;
        }

    }
}
