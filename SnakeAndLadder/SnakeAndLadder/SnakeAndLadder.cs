using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{   
    class SnakeAndLadder
    {
        public const int playerStartPosition = 0;
        public static int nextPosition = 0;
        public const int noPlay = 1, ladder = 2, snake = 3;
        public void CheckCondition()
        {
            Random randam = new Random();
            int answer = randam.Next(1, 7);
            Random random1 = new Random();
            int choice = random1.Next(1, 4);
            switch (choice)
            {
                case noPlay:
                    nextPosition = playerStartPosition;
                    break;
                case ladder:
                    nextPosition = playerStartPosition + answer;
                    break;
                case snake:
                    int lastPosition = playerStartPosition - answer;
                    if (lastPosition > 0)
                        nextPosition = lastPosition;
                    else
                        nextPosition = 0;
                    break;
            }
            Console.WriteLine("Current Position of player is " + nextPosition);
        }
    }

}
