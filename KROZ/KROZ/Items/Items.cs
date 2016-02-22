using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KROZ.Items
{
    abstract class Items
    {
        protected int id;

        public Items(int id)
        {
            this.id = id;
        }

        public abstract int getID();
    }
}
