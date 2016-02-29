using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KROZ.Controler
{
    class Navigate
    {
        Writings wr = new Writings();
        Characters.PJ player;
        Location.Map map;
        public Navigate(Characters.PJ player, Location.Map map)
        {
            this.player = player;
            this.map = map;
        }

        public void move()
        {
            //Variables
            string choice;
            bool end = false;
            Random rnd = new Random();

            //Gestion des déplacements selon le choix rentré
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("=-- NAVGATION --=");
            sb.AppendLine("Choissiez une direction : ");
            sb.AppendLine("N. Nord");
            sb.AppendLine("S. Sud");
            sb.AppendLine("O. Ouest");
            sb.AppendLine("E. Est");
            sb.AppendLine("_______");
            sb.AppendLine("M. Retour au Menu");

            wr.colors.writeGray(sb.ToString());
            wr.colors.writeGreen("Votre personnage se situe à X: " + player.currentCell.posX + ", Y: " + player.currentCell.posY);
            wr.colors.writeGray("Direction suivante (N/S/E/O/M):");

            do
            {
                choice = Console.ReadLine();
                switch (choice.ToLower())
                {
                    case "n":
                    case "s":
                        goY(choice.ToLower());
                        break;
                    case "e":
                    case "o":
                        goX(choice.ToLower());
                        break;
                    case "m":
                        end = true;
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Vous êtes joueur, vous voulez vous déplacer aléatoirement? C'est parti !");
                        Console.ResetColor();
                        string text = "nseo";
                        text = text[rnd.Next(4)].ToString();
                        if(text.Equals("n") || text.Equals("s"))
                        {
                            goY(text);
                        }
                        else
                        {
                            goX(text);
                        }
                        break;

                }

                wr.colors.writeGreen("Votre personnage se situe à X: " + player.currentCell.posX + ", Y: " + player.currentCell.posY);
                map.showMap(player);

                if (rnd.Next(100) <= player.currentCell.monsterRate)
                {
                    this.combat();
                }

                wr.colors.writeGray("Direction suivante (N/S/E/O/M):");
            } while (end == false);

            /**
            *Sauvegarder dans la base la nouvelle position du joueur
            **/
        }

        public void combat()
        {
            wr.colors.writeYellow("Vous avez rencontré un monstre ! PREPARE TO FIGHT");
            Controler.Fight fg = new Fight(player, new Characters.PNJ("Monstre 1", "Troll", 45, null, player.currentCell));
            Characters.Character winner = fg.startFight();
            wr.colors.writeBlue(winner.name +" a gagné le combat !");
            if (!winner.Equals(player))
            {
                wr.writeTitle("G A M E   O V E R");
                wr.colors.writeRed("Retour au début de la carte !");
                player.hp = player.maxHP;
            }
        }

        public void goY(string direction)
        {
            switch (direction)
            {
                case "s":
                    if (player.currentCell.posY <= 20)
                    {
                        if (player.currentCell.posY < 20)
                        {
                            player.currentCell.posY += 1;
                            wr.colors.writeGreen("Déplacement vers le nord.");
                        }
                        else
                        {
                            wr.colors.writeYellow("Vous êtes arrivé au bord de la carte, il n'y a rien plus au nord !\n");
                        }
                    }
                    
                    break;
                case "n":
                    if (player.currentCell.posY >= 0)
                    {
                        if (player.currentCell.posY > 0)
                        {
                            player.currentCell.posY -= 1;
                            wr.colors.writeGreen("Déplacement vers le sud.");
                        }
                        else
                        {
                            wr.colors.writeRed("Vous êtes arrivé au bord de la carte, il n'y a rien plus au nord !\n");
                        }
                    }
                    break;
            }
        }

        public void goX(string direction)
        {
            switch (direction)
            {
                case "e":
                    if (player.currentCell.posX <= 20)
                    {
                        if (player.currentCell.posX < 20)
                        {
                            player.currentCell.posX += 1;
                            wr.colors.writeGreen("Déplacement vers l'est.");
                        }
                        else
                        {
                            wr.colors.writeRed("Vous êtes arrivé au bord de la carte, il n'y a rien plus à l'est !\n");
                        }
                    }
                    
                    break;
                case "o":
                    if (player.currentCell.posX >= 0)
                    {
                        if (player.currentCell.posX > 0)
                        {
                            player.currentCell.posX -= 1;
                            wr.colors.writeGreen("Déplacement vers l'ouest.");
                        }
                        else
                        {
                            wr.colors.writeRed("Vous êtes arrivé au bord de la carte, il n'y a rien plus à l'ouest !\n");
                        }
                    }
                    break;
            } 
        }
    }
}
