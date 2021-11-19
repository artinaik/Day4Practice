using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{  
    class SnakeAndLadder
    {
        public const int playerStartPosition = 0,playerWinPosition=100;
        public static int nextPosition = 0;
        public const int noPlay = 1, ladder = 2, snake = 3;
        public void ChecksForOption()
        {
            Random randam = new Random();//for die
            Random random1 = new Random();//for switch case
            while(nextPosition!=playerWinPosition)
            {
                int answer = randam.Next(1, 7);//random variable for die
                int choice = random1.Next(1, 4);//random variable for choice for player option

                switch (choice)
                {
                    case noPlay:
                        nextPosition = playerStartPosition + nextPosition;//no play but nextposition is calculated
                        break;
                    case ladder:
                        nextPosition = nextPosition + answer;
                        nextPosition++;//next position increament by random die
                        break;
                    case snake:
                        int lastPosition = nextPosition - answer;//decramented by number of die
                        if (lastPosition > 0)// checking if position greater than 0
                            nextPosition = lastPosition;//assigned decreamented value to next position
                        else
                            nextPosition = 0;
                        break;
                }
            }
            //Console.WriteLine("Player won the game and position is "+nextPosition);//final win position is 100 
            if (nextPosition == playerWinPosition)
                Console.WriteLine("Player has got winning position  " + nextPosition);
        }

    }

}
