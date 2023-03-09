using System;
namespace SnakeAndLadder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake and Ladder Game");
            Play play1 = new Play();
            play1.RollDie();
            int player1 = play1.Game();
            Play play2 = new Play();
            play2.RollDie();
            int player2 = play2.Game();
            play2.TwoPlayers(player1, player2);
        }
    }
}
