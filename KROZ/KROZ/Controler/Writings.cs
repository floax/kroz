using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KROZ.Controler
{
    class Writings
    {
        public ColorWriting colors = new ColorWriting();
        public void writeTitle(string text)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("/!--------------------------------------------!\\");
            Console.WriteLine(text);
            Console.WriteLine("/!--------------------------------------------!\\");
            Console.ResetColor();
        }

        public void writeSubTitle(string text)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("/!------------"+ text +"-----------!\\");
            Console.ResetColor();
        }
    }
}
