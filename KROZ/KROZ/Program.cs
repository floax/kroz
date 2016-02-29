using KROZ.Items;
using KROZ.Characters;
using KROZ.Location;
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
            Controler.Writings wr = new Controler.Writings();
            wr.colors.writeBlue("!------------------------------------------!");
            wr.colors.writeBlue("`7MMF' `YMM'");
            wr.colors.writeBlue("  MM   .M'");
            wr.colors.writeBlue("  MM .d\"     `7Mb,od8,  pW\"Wq.  M\"\"\"MMV");
            wr.colors.writeBlue("  MMMMM.       MM'  \"'6W'   `Wb '  AMV");
            wr.colors.writeBlue("  MM  VMA      MM     8M     M8   AMV");
            wr.colors.writeBlue("  MM   `MM.    MM     YA.   ,A9  AMV  ,");
            wr.colors.writeBlue(".JMML.   MMb..JMML.    `Ybmd9'  AMMmmmM");
            wr.colors.writeBlue("!------------------------------------------!");
            wr.colors.writeBlue("                      -                     ");

            PrincipalMenu menu = new PrincipalMenu();
            menu.afficheIntro();

            Console.ReadLine();
        }
    }
}
