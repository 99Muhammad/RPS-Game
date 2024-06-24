using Lab4_Rock__Paper__Scissors;

namespace Game_Test
{
    public class UnitTest1
    {
        public UnitTest1()
        {
            // Reset static properties before each test
            clsPlayer.playerName = string.Empty;
            clsPlayer.playerChoosing = default;
            clsPlayer.AI_Choise = default;
        }
        [Fact]
        public void UpdatePlayerScore_Test()
        {
            clsRPSGame RPSGame = new clsRPSGame();

            clsPlayer.playerChoosing = clsPlayer.enPlayerChoosing.rock;
            clsPlayer.AI_Choise = clsPlayer.enPlayerChoosing.scissors;

            short playerScore = 0;
            short AiScore = 0;



            RPSGame.UpdateScore(ref playerScore, ref AiScore);

            Assert.Equal(1, playerScore);

        }

        [Fact]
        public void UpdateAI_Score_Test()
        {

            clsRPSGame RPSGame = new clsRPSGame();

            clsPlayer.playerChoosing = clsPlayer.enPlayerChoosing.scissors;
            clsPlayer.AI_Choise = clsPlayer.enPlayerChoosing.rock;

            short playerScore = 0;
            short AiScore = 0;


            RPSGame.UpdateScore(ref playerScore, ref AiScore);

            Assert.Equal(1, AiScore);

        }

        [Fact]
        public void NoUpdateScore_Test()
        {
            clsRPSGame RPSGame = new clsRPSGame();

            clsPlayer.playerChoosing = clsPlayer.enPlayerChoosing.rock;
            clsPlayer.AI_Choise = clsPlayer.enPlayerChoosing.rock;

            short playerScore = 0;
            short AiScore = 0;


            //clsPlayer player = new clsPlayer();


            RPSGame.UpdateScore(ref playerScore, ref AiScore);

            Assert.Equal(0, AiScore);

        }

        [Fact]
        public void DetemineNoWinner_Test()
        {


            //  clsPlayer player = new clsPlayer();

            short playerScore = 1;
            short AiScore = 1;

            clsRPSGame RPSGame = new clsRPSGame();

            string winner = RPSGame.WhoseCurrentWinner(playerScore, AiScore);

            Assert.Equal("No winner", winner);

        }
        [Fact]
        public void DetemineWinnerAi_Test()
        {

            // clsPlayer player = new clsPlayer();

            short playerScore = 0;
            short AiScore = 1;

            clsRPSGame RPSGame = new clsRPSGame();

            string winner = RPSGame.WhoseCurrentWinner(playerScore, AiScore);

            Assert.Equal("Ai Player", winner);

        }

        [Fact]
        public void DetemineWinnerPlayer_Test()
        {


            //  clsPlayer player = new clsPlayer();

            short playerScore = 1;
            short AiScore = 0;

            clsRPSGame RPSGame = new clsRPSGame();

            string winner = RPSGame.WhoseCurrentWinner(playerScore, AiScore);

            Assert.Equal(clsPlayer.playerName, winner);

        }

        public void Dispose()
        {

            clsPlayer.playerName = string.Empty;
            clsPlayer.playerChoosing = default;
            clsPlayer.AI_Choise = default;
        }
    }
}