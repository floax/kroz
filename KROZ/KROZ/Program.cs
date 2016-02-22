using KROZ.Items;
using KROZ.Characters;
using KROZ.Map;
using KROZ.Menus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KROZ
{
    class Program
    {
        static void Main(string[] args)
        {
            PrincipalMenu menu = new PrincipalMenu();
            menu.afficheIntro();

            Console.ReadLine();
        }
    }
}
