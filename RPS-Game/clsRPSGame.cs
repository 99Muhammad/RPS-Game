using static Lab4_Rock__Paper__Scissors.clsPlayer;

namespace Lab4_Rock__Paper__Scissors
{
    public class clsRPSGame
    {
        clsPlayer Player = new clsPlayer();

        public void StartGameScreen()
        {
            Console.WriteLine("\t\t--------------------------------------\n");
            Console.WriteLine("\t\t\tRock , Paper , Sissors Game Screen\n");
            Console.WriteLine("\t\t--------------------------------------\n");

            Console.Write("\t\tEnter Your Name ,please?");
            clsPlayer.playerName = Console.ReadLine();

            while (int.TryParse(clsPlayer.playerName, out int number))

            {
                Console.WriteLine("\t\tYou entered invalid data ,try again please");
                Console.Write("\t\tEnter Your Name ,please?");
                clsPlayer.playerName = Console.ReadLine();

            }
            Player.playerScore = 0;
        }

        public void UpdateScore(ref short playerScore, ref short AiScore)
        {
            playerScore = 0;
            AiScore = 0;

            if (playerChoosing == AI_Choise)
            {
                playerScore = 0;
                AiScore = 0;
            }
            else if (playerChoosing == enPlayerChoosing.rock && AI_Choise == enPlayerChoosing.scissors)
            {
                ++Player.playerScore;
                ++playerScore;
            }
            else if (playerChoosing == enPlayerChoosing.scissors && AI_Choise == enPlayerChoosing.paper)
            {
                ++Player.playerScore;
                ++playerScore;
            }
            else if (playerChoosing == enPlayerChoosing.paper && AI_Choise == enPlayerChoosing.rock)
            {
                ++Player.playerScore;
                ++playerScore;
            }
            else
            {
                ++Player.Ai_Score;
                ++AiScore;
            }

        }

        public void ResultForEachRound(short playerScore, short AiScore)
        {
            Console.WriteLine("\n\t\t{ Round Info }");
            Console.WriteLine($"\n\t\t-The choise for Player {clsPlayer.playerName}: {clsPlayer.playerChoosing} ");
            Console.WriteLine($"\t\t-The choise for AI Player : {clsPlayer.AI_Choise} ");
            Console.WriteLine($"\t\t-The score for Player {clsPlayer.playerName} : {playerScore}");
            Console.WriteLine($"\t\t-The score for AI Player : {AiScore}");
        }

        public string WhoseCurrentWinner(short playerScore, short AiScore)
        {
            if (playerScore > AiScore)
            {
                ResultForEachRound(playerScore, AiScore);
                Console.WriteLine($"\t\tPlayer {clsPlayer.playerName} win ");
                return clsPlayer.playerName;
            }
            else if (playerScore < AiScore)

            {
                ResultForEachRound(playerScore, AiScore);
                Console.WriteLine($"\t\tAi win ");
                return "Ai Player";
            }
            else if (playerScore == AiScore)
            {
                ResultForEachRound(playerScore, AiScore);
                Console.WriteLine($"\t\tNo winner ");
                return "No winner";
            }
            return "";
        }

        public void ShowFinalResult()
        {
            Console.WriteLine("\n\t\t--------------------------------------\n");
            Console.WriteLine($"\t\t\tFinal Result \n");
            Console.WriteLine("\t\t--------------------------------------\n");
            Console.WriteLine($"\t\tThe score for Player {clsPlayer.playerName} : {Player.playerScore} ");
            Console.WriteLine($"\t\tThe score for AI Player : {Player.Ai_Score} ");

        }
        public void CountFinalResult()
        {
            if (Player.playerScore > Player.Ai_Score)
            {
                ShowFinalResult();
                Console.WriteLine($"\t\tPlayer {clsPlayer.playerName} win ");
            }
            else if (Player.playerScore < Player.Ai_Score)

            {
                ShowFinalResult();
                Console.WriteLine($"\t\tAi win ");
            }
            else
            {
                ShowFinalResult();
                Console.WriteLine($"\t\tNo winner ");
            }
        }

        public void ImplementSingleRound(ushort RoundNumber)
        {

            short playerScore = 0;
            short AiScore = 0;
            Console.WriteLine("\t\t--------------------------------------\n");
            Console.WriteLine($"\t\t\tRound ( {RoundNumber} ) \n");
            Console.WriteLine("\t\t--------------------------------------\n");

            clsPlayer.playerChoosing = clsPlayer.GetPlayerChoosing();
            clsPlayer.AI_Choise = clsPlayer.GetRandomChoising();

            UpdateScore(ref playerScore, ref AiScore);
            WhoseCurrentWinner(playerScore, AiScore);


        }

        public void Rounds(ushort RoundNumber = 0)
        {
            Console.Clear();
            Console.WriteLine("\t\t--------------------------------------\n");
            Console.WriteLine("\t\t\tRounds Screen \n");
            Console.WriteLine("\t\t--------------------------------------\n\n\n");


            while (++RoundNumber <= 3)
            {
                ImplementSingleRound(RoundNumber);
            }
            CountFinalResult();

        }
    }
}
