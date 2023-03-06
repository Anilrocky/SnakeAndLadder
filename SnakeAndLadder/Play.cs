using System;
namespace SnakeAndLadder
{
    public class Play
    {
        const int NO_PLAY = 0, LADDER = 1, SNAKE = 2;
        int playerPosition = 0;
        Random random = new Random();
        public int RollDie()
        {
            int die = random.Next(1,7);
            return die;
        }
        public void Game()
        {
            int option = random.Next(0,3);
            switch (option)
            {
                case NO_PLAY:
                    break;
                case LADDER:
                    this.playerPosition += RollDie();
                    Console.WriteLine(this.playerPosition);
                    break;
                case SNAKE:
                    this.playerPosition -= RollDie();
                    Console.WriteLine(this.playerPosition);
                    break;
            }
        }
    }
}
