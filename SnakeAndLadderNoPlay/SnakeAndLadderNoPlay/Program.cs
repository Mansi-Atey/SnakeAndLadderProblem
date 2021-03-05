using System;

namespace SnakeAndLadderNoPlay
{
    class Program
    {
        public const int startPosition = 0;
        public const int endPosition = 100;
        public const int noPlay = 0;
        public const int ladder = 2;
        public const int snake = 1;
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME..!! Please Enter Your Name.");
            string user1 = Console.ReadLine();
            int userPosition = startPosition;
            int rollDice = RollDice();
            Console.WriteLine("Dice Roll:" + rollDice);
            userPosition = userMove(rollDice, userPosition);
            Console.WriteLine("Your current position:" + userPosition);
        }
        static int RollDice()
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 7);
            return randomNumber;
        }
        static int userMove(int rolledNumber, int userPosition)
        {
            Random random = new Random();
            int move = random.Next(0, 3);
        switch (move)
            {
                case noPlay:
                    Console.WriteLine("No Play");
                    break;
                case snake:
                    Console.WriteLine("Snake");
                    userPosition = userPosition - rolledNumber;
                    break;
                case ladder:
                    Console.WriteLine("Ladder");
                    userPosition = userPosition + rolledNumber;
                    break;
            }
            return userPosition;
        }
    }
}
