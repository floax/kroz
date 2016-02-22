using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KROZ.Menus
{
    class PrincipalMenu
    {
        public PrincipalMenu()
        {
         
        }

        public void afficheIntro()
        {
            Console.WriteLine("Que voulez-vous faire ?\nNouvelle Partie\nContinuer\nQuitter");
            string choice = Console.ReadLine();

            do
            {
                switch (choice.ToLower())
                {
                    case "nouvelle partie":
                        Console.Write("Vous souhaitez commencer une nouvelle partie");
                        break;
                        

                    case "continuer":
                        Console.Write("Vous souhaitez continuer votre partie");
                        break;

                    case "quitter":
                        Console.WriteLine("Aurevoir !");
                        break;

                    default:
                        Console.WriteLine("Choix invalide : ");
                        choice = Console.ReadLine();
                        break;
                }

            } while (choice.ToLower() != "nouvelle partie" && choice.ToLower() != "continuer" && choice.ToLower() != "quitter");


            GameStatus gameStatus = new GameStatus();

            if (choice.ToLower() == "nouvelle partie")
            {
                gameStatus.init();
            }
            else if (choice.ToLower() == "continuer")
            {
                gameStatus.gameResume();
            }

        }
            
    }
}
