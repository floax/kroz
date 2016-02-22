using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KROZ.Items
{
    class Component : Item
    {

        public Component(int id)
            : base(id)
        {

        }

        public override int getID()
        {
            return id;
        }
    }
}
