using System;
namespace SnakeAndLadder
{
    public class Play
    {
        int playerPosition = 0;
        Random random = new Random();
        public void RollDie()
        {
            int die = random.Next(1,7);
            Console.WriteLine(die);
        }
    }
}
