using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab4_Rock__Paper__Scissors
{
    public class clsPlayer
    {

        private static string PlayerName;
        private int PlayerScore;
        private int AI_Score;

        Random random = new Random();
        public enum enPlayerChoosing { paper = 1, rock = 2, scissors = 3 }

        public static enPlayerChoosing AI_Choise;
        public static enPlayerChoosing playerChoosing;

        public static string playerName { get { return PlayerName; } set { PlayerName = value; } }
        public int playerScore { get { return PlayerScore; } set { PlayerScore = value; } }

        public int Ai_Score { get { return AI_Score; } set { AI_Score = value; } }


        public static enPlayerChoosing GetPlayerChoosing()
        {
            Console.Write("\t\t[1] {0,-10} [2] {1,-10} [3] {2,-10}", "Paper", "Rock", "Scissors" +
               "\n\t\tWtite one of three choises or write from 1 - 3 ?");

            /*
        
             * When the text lengths are not equal, the tab characters won't align the text correctly,
             * and the output may not look as expected.
            
              Console.WriteLine("\t\t[1]Paper\t[2]Rock\t[3]Scissors\n\t\tWtite one of three choises" +
              "or write from 1 - 3 ?");

            Alternatively, you can use the PadRight() method to achieve the same result:

            Console.WriteLine("[1] {0} [2] {1} [3] {2}", "Paper".PadRight(10), 
            "Rock".PadRight(10), "Scissors".PadRight(10));

             */


            bool validInput = false;

            while (!validInput)
            {
                Console.Write("");
                string userInput = Console.ReadLine().Trim().ToUpper();


                if (Enum.TryParse(userInput, true, out playerChoosing))
                {
                    // this if condition to prevent player to enter any number rahter than 1,2,3 
                    if (playerChoosing == enPlayerChoosing.paper || playerChoosing == enPlayerChoosing.scissors ||
                        playerChoosing == enPlayerChoosing.rock)
                    {
                        validInput = true;
                        return playerChoosing;
                    }
                    else
                    {
                        Console.Write("\t\tInvalid input. Please try again: ");
                    }
                }
                else
                {
                    Console.Write("\t\tInvalid input. Please try again: ");
                }
            }
            return playerChoosing;

        }

        public static enPlayerChoosing GetRandomChoising()
        {
            Random random = new Random();

            enPlayerChoosing[] arrAiChoising = new enPlayerChoosing[]
            { enPlayerChoosing.paper,enPlayerChoosing.rock,enPlayerChoosing.scissors};

            int RandomNumber = random.Next(1, 3);

            AI_Choise = arrAiChoising[RandomNumber];
            return AI_Choise;

        }
    }
}
