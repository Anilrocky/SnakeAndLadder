using System;
namespace SnakeAndLadder
{
    public class Play
    {
        const int NO_PLAY = 0, LADDER = 1, SNAKE = 2, WINNING_POSITION = 100;
        int playerPosition = 0, count = 0;
        Random random = new Random();
        public int RollDie()
        {
            int die = random.Next(1,7);
            Console.WriteLine("Die Vlaue " + die);
            count++;
            return die;
        }
        public int Game()
        {
            while (this.playerPosition < WINNING_POSITION)
            {
                int option = random.Next(0, 3);
                switch (option)
                {
                    case NO_PLAY:
                        break;
                    case LADDER:
                        this.playerPosition += RollDie();
                        Console.WriteLine(this.playerPosition);
                        break;
                    case SNAKE:
                        int rollDie = RollDie();
                        if (this.playerPosition- rollDie > 0)
                            this.playerPosition -= rollDie;
                        if (this.playerPosition- rollDie < 0)
                            this.playerPosition = 0;
                        break;
                }
                Console.WriteLine("Player Position--->  " + playerPosition);
            }
            if (this.playerPosition == WINNING_POSITION)
            {
                Console.WriteLine("Player Position--->  " + playerPosition);
                Console.WriteLine("Die Count " + count);
            }
            return playerPosition;
        }
        public void TwoPlayers(int player1,int player2)
        {
            if (player1 == WINNING_POSITION)
                Console.WriteLine("Player 1 Won the Game");
            if (player2 == WINNING_POSITION)
                Console.WriteLine("Player 2 Won the Game");
        }
    }
}
