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
        protected static KrozDbContext db = new KrozDbContext();
        protected static Location.Map map;

        static void Main(string[] args)
        {
            
            Controler.Writings wr = new Controler.Writings();
            wr.colors.writeGray("Création de la carte...");
            initGame();
            Console.Clear();
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

            PrincipalMenu menu = new PrincipalMenu(map);
            menu.afficheIntro();

            Console.ReadLine();
        }

        public static void initGame()
        {
            if(db.maps.Count() == 0)
            {
                map = new Location.Map("Monde");
                map.createMap();
                db.maps.Add(map);
            }
            else
            {
                map = db.maps.Find(15);
            }
            db.SaveChanges();
        }
    }
}
