using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KROZ.Items
{
    class Weapons : Items
    {
        string name { set; get; }
        int attackRate { set; get; }
        int missedRate { set; get; }

        public Weapons(string name, int id, int attackrate = 20, int missedrate = 50)
            : base(id)
        {
    
            this.name = name;
            this.attackRate = attackrate;
            this.missedRate = missedrate;
        }
            
        public override int getID()
        {
            return id;
        }
        public void showInfos()
        {
            Console.WriteLine("Arme: "+name+", ses dommages sont de "+attackRate+", et elle a "+missedRate+"% de chances de rater sa cible. \n Info supp : ID = "+id+"\n");
            Console.ReadLine();
        }

    }
}
