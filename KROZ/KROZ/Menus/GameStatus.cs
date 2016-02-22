using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KROZ.Menus
{
    class GameStatus
    {


        public GameStatus()
        {
            
        }

        public void init()
        {
            string name;
            string sexe;
            bool OK = false;
            string answer;
            string personnage;

            
            Console.Clear();
            Console.WriteLine("=-- NOUVELLE PARTIE --= !");

            do
            {
                Console.WriteLine("\nChoissiez un pseudo: ");
                name = Console.ReadLine();
                do
                {
                    Console.WriteLine("\nChoissez votre sexe. (F/M)");
                    sexe = Console.ReadLine();

                } while (sexe.ToLower() != "f" && sexe.ToLower() != "m");


                Console.WriteLine("Nom : "+name+"\nSexe : "+sexe+" .\nCela est-il juste ? (O/N)\n");
                answer = Console.ReadLine();
                if (answer.ToLower() == "oui" || answer.ToLower() == "o")
                {
                    OK = true;
                }
                else if (answer.ToLower() == "non" || answer.ToLower() == "n")
                {
                    OK = false;
                }


            } while (OK == false);

            if (sexe == "f")
            {
                personnage = "Votre personnage est une femme prénommée " + name + ".\n";
            }
            else {
                personnage = "Votre personnage est un homme prénommé " + name + ".\n";
            }
            Console.WriteLine(personnage);

            createCharacter(name, sexe);
        }

        public void gameResume()
        {
            Console.WriteLine("You're resuming your game!");
        }

        public void createCharacter(string name, string sexe)
        {
            /**
            *Ajout des datas à la BDD
            **/
            Console.WriteLine("Votre personnage a été créé !");
        }
    }
}
