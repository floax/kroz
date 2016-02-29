using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KROZ.Menus
{
    class GameStatus
    {
        protected string _NAMEPC ="PC-LO";
        protected KrozDbContext db = new KrozDbContext();
        //Liste pour envoyer le nouveau joueur/joueur récupéré ailleurs dans le code
        List<dynamic> List = new List<dynamic>();

        public GameStatus()
        {

        }

        public List<dynamic> init()
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
                Console.WriteLine("\nQuel est votre pseudo? ");
                name = Console.ReadLine();
                do
                {
                    Console.WriteLine("\nJe vois que vous êtes humain. Etes-vous un homme ou une femme? (F/M)");
                    sexe = Console.ReadLine();

                } while (sexe.ToLower() != "f" && sexe.ToLower() != "m");


                Console.WriteLine("Nom : " + name + "\nSexe : " + sexe + " .\nEst-ce que j'ai bon ? (O/N)\n");
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

            if (sexe.ToLower() == "f")
            {
                personnage = "Votre personnage est une femme prénommée " + name + ".\n";
            }
            else
            {
                personnage = "Votre personnage est un homme prénommé " + name + ".\n";
            }

            this.List = createCharacter(name, sexe);
            return this.List;

        }

        public void gameResume(string name)
        {
            Console.WriteLine("Je viens de finir de télécharger votre jeu. Vous pouvez maintenant reprendre votre partie.");

            Characters.PJ joueur = (Characters.PJ)(from i in db.players where i.name == name select i).Single();

            Console.WriteLine(joueur.name + ", " + joueur.genre + ", " + joueur.hp + ", " + joueur.maxHP + ", " + joueur.level + ", " + joueur.currentCell + " . ");

        }

        public List<dynamic> createCharacter(string name, string sexe)
        {
            /* Initialisation des variables */

            List<dynamic> tempList = new List<dynamic>();
            Inventory inventaire = new Inventory(); //Nouvel inventaire. Contient, de base, un couteau et une potion
            Location.Cell startCell = new Location.Cell(10, 10, true); //Cellule de départ. 10.10 correspond au milieu de la carte
            Characters.PJ joueur = new Characters.PJ(name, sexe, inventaire, startCell); //Nouveau héros

            db.inventory.Add(inventaire);
            db.characters.Add(joueur);

            db.SaveChanges();
            //On veut récupérer le joueur
            tempList.Add(joueur);

            return tempList;
        }
    }
}
