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
        [Required]
        [Column("RestoreHP")]
        public int restoreHP { get; set; }
        [Required]
        [Column("AttackBoost")]
        public int attackBoost { get; set; }
        [Required]
        [Column("DefenseBoost")]
        public int defenseBoost { get; set; }


        public UsableItem(string name, int RHP, int AB, int DB) : base(name)
        {
            this.restoreHP = RHP;
            this.attackBoost = AB;
            this.defenseBoost = DB;
        }

    }
}
