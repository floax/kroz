using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KROZ.Menus
{
    class PrincipalMenu
    {
        Controler.Writings wr = new Controler.Writings();
        Characters.PJ joueur = new Characters.PJ();
        Location.Map map = new Location.Map("map");

        //Locale Vars
        GameStatus gameStatus = new GameStatus();

        public PrincipalMenu()
        {

        }

        public void afficheIntro()
        {
            Console.WriteLine("Que voulez-vous faire ?\nN. Nouvelle Partie\nC. Continuer\nQ. Quitter");
            string choice = Console.ReadLine();

            do
            {
                switch (choice.ToLower())
                {
                    case "n":
                        Console.Write("Vous souhaitez commencer une nouvelle partie");
                        startNewGame();
                        play();
                        break;
                    case "c":
                        Console.Write("Vous souhaitez continuer votre partie");
                        continueGame();
                        play();
                        break;

                    case "q":
                        Console.WriteLine("Aurevoir !");
                        break;
                    case "42":
                        wr.colors.writeYellow("GOD MODE");
                        break;
                    default:
                        wr.colors.writeRed("Je n'ai pas compris votre choix, répétez : ");
                        choice = Console.ReadLine();
                        break;
                }

            } while (choice.ToLower() != "n" && choice.ToLower() != "c" && choice.ToLower() != "q" && choice.ToLower() != "42");

            
        }

        public void play()
        {
            Boolean play = true;
            wr.writeTitle("Debut du jeu !");
            while (play)
            {
                play = showPlayerOptions();
            }
        }

        protected void startNewGame()
        {
            List<dynamic> tempList = new List<dynamic>();
            tempList = gameStatus.init();
            this.joueur = tempList[0];
            this.map = tempList[1];

            wr.writeTitle("Spécificité de votre personnage");
            wr.colors.writeWhite(this.joueur.characterInfo());
            wr.colors.writeGreen("Appuyer sur une touche pour commencer à jouer.");
            Console.ReadLine();
            
        }
        protected void continueGame()
        {
            gameStatus.gameResume();
        }

        public Boolean showPlayerOptions()
        {
            string choice;

            Console.WriteLine("=-- ACTIONS POSSIBLES --=\n1. Inventaire \n2. Navigation \n3. Informations du joueur (informations) \n4. Sauvegarder \n5. Quitter le jeu (quitter)");
            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    //Pour chaque objet dans l'inventaire, on va chercher le nom et on l'affiche
                    for (int i = 0; i < this.joueur.returnInventory().Count(); i++)
                    {
                        Console.WriteLine("Item" + i + 1 + " : " + this.joueur.returnInventory().ElementAt(i).name);
                    }

                    break;

                case "2":
                    /**
                    *Récupèrer la position du joueur
                    **/

                    Controler.Navigate nav = new Controler.Navigate(this.joueur);
                    nav.move();

                    break;

                case "3":
                    Console.WriteLine("Informations sur le joueur");
                    this.joueur.characterInfo();
                    break;

                case "4":
                    Console.WriteLine("Jeux sauvegardé");
                    break;

                case "5":
                    Console.WriteLine("Aurevoir !");
                    return false;
            }

            return true;
        }

    }
}
