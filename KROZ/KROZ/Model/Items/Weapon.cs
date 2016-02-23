using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KROZ.Items
{
    [Table("Weapon")]
    public class Weapon : Item
    {
        [Required]
        [Column("AttackRate")]
        public int attackRate { set; get; }
        [Required]
        [Column("MissedRate")]
        public int missedRate { set; get; }

        public Weapon(string name, int attackrate = 20, int missedrate = 50):base(name)
        {
            this.attackRate = attackrate;
            this.missedRate = missedrate;
        }
     
        public void showInfos()
        {
            Console.WriteLine("Arme: "+name+", ses dommages sont de "+attackRate+", et elle a "+missedRate+"% de chances de rater sa cible. \n Info supp : ID = "+ID+"\n");
            Console.ReadLine();
        }

    }
}
