//using RPS_Game;

namespace Lab4_Rock__Paper__Scissors
{
    public class Program
    {
        static void Main(string[] args)
        {
            clsRPSGame clsRPS = new clsRPSGame();

            clsRPS.StartGameScreen();
            clsRPS.Rounds();
        }
    }
}
