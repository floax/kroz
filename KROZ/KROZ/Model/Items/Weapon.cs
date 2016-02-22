using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KROZ.Items
{
    public class Weapon : Item
    { 
        int attackRate { set; get; }
        int missedRate { set; get; }

        public Weapon(string name, int attackrate = 20, int missedrate = 50):base(name)
        {
            this.attackRate = attackrate;
            this.missedRate = missedrate;
        }
     
        public void showInfos()
        {
            Console.WriteLine("Arme: "+name+", ses dommages sont de "+attackRate+", et elle a "+missedRate+"% de chances de rater sa cible. \n Info supp : ID = "+id+"\n");
            Console.ReadLine();
        }

    }
}
