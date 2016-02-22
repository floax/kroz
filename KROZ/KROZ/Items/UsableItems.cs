using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KROZ.Items
{
    class UsableItems : Items
    {
<<<<<<< HEAD
        string name;
        int restoredHP;
        int attackBoost;
        int defenseBoost;

        public UsableItems(int id, string name, int RHP, int AB, int DB)
            : base(id)
        {
            this.name = name;
            this.restoredHP = RHP;
            this.attackBoost = AB;
            this.defenseBoost = DB;
        }

        public override int getID()
        {
            return id;
        }
=======

>>>>>>> origin/master
    }
}
