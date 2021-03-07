using System;

namespace SnakeAndLadderReportStatus
{
    class Program
    {
        public const int noOfPlayers = 1;
        public const int startingPosition = 0;
        public const int winningPosition = 100;
        public const int noPlay = 0;
        public const int snake = 2;
        public const int ladder = 1;
        static void Main(string[] args)
        {
            int currentPosition = startingPosition;
            int moves = 0;
            Console.WriteLine("WELCOME..!!PLEASE ENTER YOUR NAME");
            Console.WriteLine("Yor are currently at starting position");
            while (currentPosition != winningPosition)
            {
                Random random = new Random();
                int diceVal = random.Next(1, 7);
                Console.WriteLine("User Rolled:-" + diceVal);
                int Action = random.Next(0, 3);
                if (Action == noPlay)
                {
                    Console.WriteLine("No Action Taken");
                }
                else if (Action == ladder)
                {
                    currentPosition += diceVal;
                    if (currentPosition > winningPosition)
                    {
                        currentPosition -= diceVal;
                    }
                }
                else
                {
                    currentPosition -= diceVal;
                    if (currentPosition < startingPosition)
                    {
                        currentPosition = startingPosition;
                    }
                }
                moves++;
                Console.WriteLine("The current position of user is:-" + currentPosition);
            }
            Console.WriteLine("The moves in which the user reaches the winning position is:" + moves);

        }
    }
}