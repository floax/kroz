using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KROZ.Controler
{
    class Fight
    {
        Controler.Writings wr = new Controler.Writings();
        protected Characters.Character player, monster;
        protected Boolean tour = true;

        public Fight(Characters.Character player, Characters.Character monster)
        {
            this.player = player;
            this.monster = monster;
        }

        public Characters.Character startFight()
        {
            wr.writeTitle("Début du combat");
            while(player.hp > 0 && monster.hp > 0)
            {
                if (tour)
                {
                    wr.writeSubTitle("C'est au tour de "+player.name+" de jouer !");
                    playerPlay();
                    tour = false;
                }
                else
                {
                    wr.writeSubTitle("C'est au tour de " + monster.name + " de jouer !");
                    monsterPlay();
                    
                    tour = true;
                }
                wr.colors.writeGray("Appuyer sur une touche pour continuer le combat");
                Console.ReadLine();
            }
            
            if (player.hp == 0)
            {
                return monster;
            }
            else
            {
                return player;
            }
        }

        protected void playerPlay()
        {
            int attack;

            Random rnd = new Random();
            attack = rnd.Next(monster.hp+1);
            monster.hp -= attack;

            wr.colors.writeWhite(monster.name + " a perdu "+attack+" point de vie !");
            if(attack >= (monster.hp / 2)){
                wr.colors.writeGreen("Quelle attaque !" + monster.name + " est destabilisé !");
                wr.colors.writeYellow(monster.name + " n'a plus que " + monster.hp + " point de vie !");
            }
            else
            {
                wr.colors.writeYellow(monster.name + " a encore " + monster.hp + " point de vie !");
            }
            
        }

        protected void monsterPlay()
        {
            int attack;

            Random rnd = new Random();
            attack = rnd.Next(player.hp+1);
            player.hp -= attack;

            wr.colors.writeWhite(player.name + " a perdu " + attack + " point de vie !");
            if (attack >= (monster.hp / 2))
            {
                wr.colors.writeGreen("Quelle attaque !" + player.name + " est destabilisé !");
                wr.colors.writeYellow(player.name + " n'a plus que " + player.hp + " point de vie !");
            }
            else
            {
                wr.colors.writeYellow(player.name + " a encore " + player.hp + " point de vie !");
            }
        }
    }
}
