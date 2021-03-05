using System;

namespace SnakeAndLadderDiceRoll
{
    class Program
    {
        public const int startPosition = 0;
        public const int endPosition = 100;
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME..!! Please Enter Your Name.");
            string user1 = Console.ReadLine();
            int rollDice = RollDice();
            Console.WriteLine("Dice roll:" + rollDice);
        }
        static int RollDice()
        {
            Random random = new Random();
            int randomNumber = random.Next(0, 7);
            return randomNumber;
        }
    }
}
