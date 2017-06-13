using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameImages;

namespace GameProcesses
{
    public class GameProcesses
    { 
        public static int Fight(string playerName, int playerHP, string mathType, string monsterName, int monsterHP, int monsterDamage)
        {
            do
            {
                GameImages.GameImages.DrawMonster(monsterName);
                Console.WriteLine(monsterName + " HP: {0}0", monsterHP);
                for (int i = 0; i < monsterHP; i++)
                    Console.Write("█");
                Console.WriteLine("");
                Console.WriteLine(playerName + " HP: {0}0", playerHP);
                for (int i = 0; i < playerHP; i++)
                    Console.Write("█");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Solve the problems correctly to hit the " + monsterName + "!");
                Random random = new Random();
                int randomNumber1 = random.Next(0, 10);
                int randomNumber2 = random.Next(0, 10);
                int answerKey;

                if (mathType == "Addition")
                {
                    answerKey = randomNumber1 + randomNumber2;
                    if (randomNumber1 > randomNumber2)
                        Console.Write("Solve for: {0} + {1} = ", randomNumber1, randomNumber2);
                    else
                        Console.Write("Solve for: {1} + {0} = ", randomNumber1, randomNumber2);
                }
                else if (mathType == "Subtraction")
                {
                    if (randomNumber1 > randomNumber2)
                    {
                        answerKey = randomNumber1 - randomNumber2;
                        Console.Write("Solve for {0} - {1} = ", randomNumber1, randomNumber2);
                    }
                    else
                    {
                        answerKey = randomNumber2 - randomNumber1;
                        Console.Write("Solve for {0} - {1} = ", randomNumber2, randomNumber1);
                    }
                }
                else if (mathType == "Multiplication")
                {
                    answerKey = randomNumber1 * randomNumber2;
                    if (randomNumber1 > randomNumber2)
                        Console.Write("Solve for: {0} x {1} = ", randomNumber1, randomNumber2);
                    else
                        Console.Write("Solve for: {1} x {0} = ", randomNumber1, randomNumber2);
                }
                else
                {
                    answerKey = 100;
                    Console.WriteLine("Something BROKE!!!!! Your math type is invalid!");
                }

                string answer = Console.ReadLine();

                while (answer == "")
                {
                    answer = Console.ReadLine();
                }

                bool result = int.TryParse(answer, out int playerAnswer);
                
                while (result == false)
                {
                    Console.WriteLine("Numbers only!");
                    answer = Console.ReadLine();
                    while (answer == "")
                    {
                        answer = Console.ReadLine();
                    }
                    result = int.TryParse(answer, out playerAnswer);
                }
                if (playerAnswer == answerKey)
                {
                    monsterHP -= 1;
                    GameImages.GameImages.Hit();
                }
                else
                {
                    playerHP -= monsterDamage;
                    GameImages.GameImages.Ouch(monsterName);
                }
                    
            } while (playerHP > 0 && monsterHP > 0);
            
            return playerHP;
        }

        public static bool EndGame(int playerHP)
        {
            bool playagain = false;

            if (playerHP > 0)
                GameImages.GameImages.Victory();
            else
                GameImages.GameImages.Defeat();

            Console.WriteLine("Do you want to play again?");
            Console.WriteLine("1) Yes");
            Console.WriteLine("2) No");
            string answer = Console.ReadLine();
            if (answer == "1")
                playagain = true;

            return playagain;
        }
    }
}
