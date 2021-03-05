using System;

namespace SnakeAndLadder
{
    class Program
    {
        public const int startPosition = 0;
        public const int endPosition = 100;
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME..!! Please Enter Your Name.");
            string user1 = Console.ReadLine();
            int userPosition = startPosition;
            Console.WriteLine("Your Current Position is:" + userPosition);
        }
    }
}
