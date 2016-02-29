﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KROZ.Menus
{
    class PrincipalMenu
    {
        protected string _NAMEPC = "PC-LO";
        KrozDbContext db = new KrozDbContext();
        Controler.Writings wr = new Controler.Writings();
        Characters.PJ joueur = new Characters.PJ();
        Location.Map map;

        //Locale Vars
        GameStatus gameStatus = new GameStatus();

        public PrincipalMenu(Location.Map map)
        {
            this.map = map;
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

            wr.writeTitle("Spécificité de votre personnage");
            wr.colors.writeWhite(this.joueur.characterInfo());
            wr.colors.writeGreen("Appuyer sur une touche pour commencer à jouer.");
            Console.ReadLine();
            
        }
        protected void continueGame()
        {
            string name;

            Console.WriteLine("Veuillez choisir un personnage parmi la liste existante : \n________________________________\n");

            foreach(Characters.PJ player in (from i in db.players select i).ToList<Characters.PJ>())
            {
                wr.colors.writeWhite(player.name);
            }

            name = Console.ReadLine();

            gameStatus.gameResume(name);
        }

        public Boolean showPlayerOptions()
        {
            string choice;

            wr.writeTitle("MENU PRINCIPAL");
            Console.WriteLine("L. Inventaire \nN. Navigation \nI. Informations du joueur (informations) \nS. Sauvegarder \nQ. Quitter le jeu (quitter)");
            choice = Console.ReadLine();

            switch (choice.ToLower())
            {
                case "l":
                    //Pour chaque objet dans l'inventaire, on va chercher le nom et on l'affiche
                    wr.writeTitle(this.joueur.name + "'s LOOT");
                    for (int i = 0; i < this.joueur.inventory.getInventory().Count(); i++)
                    {
                       wr.colors.writeWhite("Objet " + i + " : " + this.joueur.inventory.getInventory().ElementAt(i).name);
                    }

                    break;

                case "n":
                    /**
                    *Récupèrer la position du joueur
                    **/

                    Controler.Navigate nav = new Controler.Navigate(this.joueur, this.map);
                    nav.move();

                    break;

                case "i":
                    Console.WriteLine("Informations sur le joueur");
                    this.joueur.characterInfo();
                    break;

                case "s":
                    Console.WriteLine("Jeux sauvegardé");
                    break;

                case "q":
                    Console.WriteLine("Aurevoir !");
                    return false;
            }

            return true;
        }

    }
}
