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

            Characters.PJ joueur = new Characters.PJ();
            Location.Cell currentCell = new Location.Cell(0, 0, true);
            int cellID = 0;

            string ConnectionString = "Data Source="+_NAMEPC +";Initial Catalog=kroz;Integrated Security=True;Pooling=False";

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                //On crée l'utilisateur dans la DB, en lui assigant le cellule de départ numéro 1. Ce sera la même pour tous
                SqlCommand player = new SqlCommand("SELECT * FROM character WHERE name = '" + name + "'", conn);
                conn.Open();

                try
                {
                    player.Connection = conn;

                    SqlDataReader readerPlayer = player.ExecuteReader();


                    //On récupère les variables et on les attribuent
                    while (readerPlayer.Read())
                    {
                        joueur.name = (string)readerPlayer["name"];
                        joueur.genre = (string)readerPlayer["genre"];
                        joueur.hp = (int)readerPlayer["hp"];
                        joueur.maxHP = (int)readerPlayer["maxHP"];
                        joueur.level = (int)readerPlayer["level"];
                        cellID = (int)readerPlayer["currentCell_ID"];
                    }

                }

                finally
                {
                    conn.Close();
                }

                SqlCommand cell = new SqlCommand("SELECT * FROM Cell WHERE id = " + cellID + "");
                conn.Open();

                try
                {
                    cell.Connection = conn;

                    SqlDataReader readerCell = cell.ExecuteReader();
                    while (readerCell.Read())
                    {
                        currentCell.posX = (int)readerCell["PosX"];
                        currentCell.posY = (int)readerCell["PosY"];
                        currentCell.canMoveTo = (bool)readerCell["MoveTo"];
                        currentCell.monsterRate = (int)readerCell["MonsterRate"];
                        /* if(readerCell["Description"].GetType() != ) { 
                             currentCell.description = (string)readerCell["Description"];
                         }*/
                        currentCell.monsterGroup = (int)readerCell["MonsterGroup"];
                    }

                    joueur.currentCell = currentCell;
                }

                finally
                {
                    conn.Close();
                }
            }

            Console.WriteLine(joueur.name + ", " + joueur.genre + ", " + joueur.hp + ", " + joueur.maxHP + ", " + joueur.level + ", " + joueur.currentCell + " . ");

        }

        public List<dynamic> createCharacter(string name, string sexe)
        {
            /* Initialisation des variables */

            List<dynamic> tempList = new List<dynamic>();
            Inventory inventaire = new Inventory(); //Nouvel inventaire. Contient, de base, un couteau et une potion
            Location.Cell startCell = new Location.Cell(10, 10, true); //Cellule de départ. 10.10 correspond au milieu de la carte
            Characters.PJ joueur = new Characters.PJ(name, sexe, inventaire, startCell); //Nouveau héros
            Location.Map map = new Location.Map("Mon Monde"); //Nouvelle map, vide
            map.createMap(); //Génération aléatoire des cellules
            
            //Chaine de connexion à notre database "kroz"
            string ConnectionString = "Data Source="+_NAMEPC+";Initial Catalog=kroz;Integrated Security=True;Pooling=False";

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                //On crée l'utilisateur dans la DB, en lui assigant le cellule de départ numéro 1. Ce sera la même pour tous
                SqlCommand requete = new SqlCommand("INSERT INTO character (name, genre, HP, MaxHP, level, currentCell_ID) VALUES ('" + joueur.name + "', '" + joueur.genre + "' ,100, 100, 1," + startCell +");", conn);
                conn.Open();

                try
                {
                    SqlDataReader reader = requete.ExecuteReader();
                }

                finally
                {
                    conn.Close();
                }
            }
            
            //On veut récupérer la map et le joueur
            tempList.Add(joueur);
            tempList.Add(map);

            return tempList;
        }
    }
}
