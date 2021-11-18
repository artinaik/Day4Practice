using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    class Program
    {
        static void Main(string[] args)
        {
            int playerPosition = 0;
            Random randam = new Random();
            int answer = randam.Next(1, 7);
            playerPosition = playerPosition + answer;
            Console.WriteLine("Player position is " + playerPosition);
            Console.ReadKey();
        }
    }
}
