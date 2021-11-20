using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{  
    class SnakeAndLadder
    {
        
        public void ChecksForOption()
        {

            Random randam = new Random();//for die
            Random random1 = new Random();//for switch case
             const int playerStartPosition = 0, playerWinPosition = 100;
              int nextPosition = 0;
             const int noPlay = 1, ladder = 2, snake = 3;
            int count = 0; 
            while(nextPosition<playerWinPosition)
            {
                
                int answer = randam.Next(1, 7);//random variable for die
                int choice = random1.Next(1, 4);//random variable for choice for player option

                switch (choice)
                {
                    case noPlay:
                         //nextPosition = playerStartPosition + nextPosition;//no play but nextposition is calculated
                        Console.WriteLine("[No Play] Position of player is " + nextPosition);
                        break;
                    case ladder:
                        int newPosition = nextPosition + answer;
                        //nextPosition = nextPosition + answer;
                        if (newPosition > playerWinPosition)
                            newPosition = nextPosition;
                        else
                            nextPosition = newPosition;
                        //nextPosition++;//next position increament by random die
                        Console.WriteLine("[Ladder]  Position of player " +nextPosition);
                        break;
                    case snake:
                        newPosition = nextPosition - answer;//decramented by number of die
                        if (newPosition > 0)// checking if position greater than 0
                            nextPosition = newPosition;//assigned decreamented value to next position
                        else
                            nextPosition = 0;
                        Console.WriteLine("[Snake] Position of player is "+nextPosition);
                        break;
                }
                count++;

            }
            Console.WriteLine("\nNumber of time dice was played is " + count);
            Console.WriteLine("\nPlayer won the game and position is "+nextPosition);//final win position is 100 
        }

    }

}
