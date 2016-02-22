using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KROZ.Items
{
    public class UsableItem : Item
    {
        protected int restoreHP { get; set; }
        protected int attackBoost { get; set; }
        protected int defenseBoost { get; set; }


        public UsableItem(string name, int RHP, int AB, int DB) : base(name)
        {
            this.restoreHP = RHP;
            this.attackBoost = AB;
            this.defenseBoost = DB;
        }

    }
}
