using System;

namespace SnakeAndLadderEnsureWinPosition
{
    class Program
    {
        public const int startPosition = 0;
        public const int endPosition = 100;
        public const int noPlay = 0;
        public const int snake = 1;
        public const int ladder = 2;
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME..!!ENTER YOUR NAME:");
            string user1 = Console.ReadLine();
            int currentUserPosition = startPosition;
            for (int noOfTimeDiceRolled = 1; currentUserPosition < 100; noOfTimeDiceRolled++)
            {
                int rollDice = RollDice();
                Console.WriteLine("You Rolled:-" + rollDice);
                currentUserPosition = userMovement(rollDice, currentUserPosition);
                Console.WriteLine("Your position is:-" + currentUserPosition);
                if (currentUserPosition == 100)
                {
                    Console.WriteLine("GAME OVER");
                    break;
                }
                Console.ReadLine();
            }
        }
        static int RollDice()
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 7);
            return randomNumber;
        }
        static int userMovement(int rolledNumber, int userPosition)
        {
            Random random = new Random();
            int move = random.Next(0, 3);
            switch (move)
            {
                case noPlay:
                    Console.WriteLine("NO PLAY");
                    break;
                case snake:
                    Console.WriteLine("SNAKE");
                    if (userPosition - rolledNumber >= 0)
                    {
                        userPosition = userPosition - rolledNumber;
                        break;
                    }
                    else
                    {
                        userPosition = startPosition;
                        break;
                    }
                case ladder:
                    Console.WriteLine("LADDER");
                    if (userPosition + rolledNumber <= 100)
                    {
                        userPosition = userPosition + rolledNumber;
                        break;
                    }
                    else
                    {
                        break;
                    }
            }
            return userPosition;
        }
    }
}
    

