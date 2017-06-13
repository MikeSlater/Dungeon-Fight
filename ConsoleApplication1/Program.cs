using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameImages;
using GameProcesses;


namespace DungeonFight
{
    class Program
    {
        static void Main(string[] args)
        {
            bool gameOn = true;

            // Initialize the Player!
            Player currentPlayer = new Player();
            
            // Initialize the Monsters!
            Monster Slime = new Monster(2, "Slime", 1);
            Monster Ogre = new Monster(5, "Ogre", 2);
            Monster Dragon = new Monster(10, "Dragon", 3);

            do
            {
                // Reset stats to start in case player goes again!
                currentPlayer.Name = Player.GetPlayerName();
                currentPlayer.GameType = Player.GetGameType();
                currentPlayer.HP = 10;
                Slime.HP = 2;
                Ogre.HP = 5;
                Dragon.HP = 10;


                // Start the game!
                GameImages.GameImages.Cave();
                currentPlayer.HP = GameProcesses.GameProcesses.Fight(
                    currentPlayer.Name,
                    currentPlayer.HP,
                    currentPlayer.GameType,
                    Slime.Name,
                    Slime.HP,
                    Slime.Damage);

                if (currentPlayer.HP > 0)
                {
                    GameImages.GameImages.Cave();
                    currentPlayer.HP = GameProcesses.GameProcesses.Fight(
                        currentPlayer.Name,
                        currentPlayer.HP,
                        currentPlayer.GameType,
                        Ogre.Name,
                        Ogre.HP,
                        Ogre.Damage);
                }
                    
                if (currentPlayer.HP > 0)
                {
                    GameImages.GameImages.Cave();
                    currentPlayer.HP = GameProcesses.GameProcesses.Fight(
                        currentPlayer.Name,
                        currentPlayer.HP,
                        currentPlayer.GameType,
                        Dragon.Name,
                        Dragon.HP,
                        Dragon.Damage);
                }

                gameOn = GameProcesses.GameProcesses.EndGame(currentPlayer.HP);

            } while (gameOn == true);
            
        }
    }

    class Player
    {
        public int HP { get; set; }
        public string Name { get; set; }
        public string GameType { get; set; }

        public static string GetPlayerName()
        {
            Console.Clear();
            GameImages.GameImages.Logo();
            Console.WriteLine("");
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            return name;
        }
        public static string GetGameType()
        {
            Console.Clear();
            GameImages.GameImages.Logo();
            string game = null;
            do
            {
                Console.WriteLine("What kind of math will you use?");
                Console.WriteLine("1) Addition");
                Console.WriteLine("2) Subtraction");
                Console.WriteLine("3) Multiplication");
                string reply = Console.ReadLine();
                
                if (reply == "1")
                    game = "Addition";
                else if (reply == "2")
                    game = "Subtraction";
                else if (reply == "3")
                    game = "Multiplication";
                else
                {
                    Console.Clear();
                    Console.WriteLine("Invalid Answer. Try again!");
                }
            } while (game == null);
            return game;           
        }
    }

    class Monster
    {
        public int HP { get; set; }
        public string Name { get; set; }
        public int Damage { get; set; }
        public Monster(int hp, string name, int damage)
        {
            HP = hp;
            Name = name;
            Damage = damage;
        }
    }
}
