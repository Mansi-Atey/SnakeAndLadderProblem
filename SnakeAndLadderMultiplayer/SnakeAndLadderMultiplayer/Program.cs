using System;

namespace SnakeAndLadderMultiplayer
{
    class Program
    {
        public const int noOfPlayers = 1;
        public const int noPlay = 0;
        public const int snake = 2;
        public const int ladder = 1;
        public const int startingPosition = 0;
        public const int winningPosition = 100;
        static void Main(string[] args)
        {
            int user1Position = startingPosition;
            int user2Position = startingPosition;
            bool user1 = true;
            Console.WriteLine("WELCOME...!!!");
            Console.WriteLine("Both the players are at starting point");
           while (user1Position != winningPosition && user2Position != winningPosition)
            {
                if (user1)
                {
                    Random random = new Random();
                    int diceVal = random.Next(1, 7);
                    Console.WriteLine("User Rolled:-" + diceVal);
                    int Action = random.Next(0, 3);
                    if (Action == noPlay)
                    {
                        user1 = false;
                    }
                    else if (Action == ladder)
                    {
                        user1Position += diceVal;
                        if (user1Position > winningPosition)
                        {
                            user1Position -= diceVal;
                        }
                    }
                    else
                    {
                        user1 = false;
                        user1Position -= diceVal;
                        if (user1Position < startingPosition)
                        {
                            user1Position = startingPosition;
                        }
                    }
                }
                else
                {
                    Random random = new Random();
                    int diceVal = random.Next(1, 7);
                    Console.WriteLine("User Rolled:-" + diceVal);
                    int Action = random.Next(0, 3);
                    if (Action == noPlay)
                    {
                        user1 = true;
                    }
                    else if (Action == ladder)
                    {
                        user2Position += diceVal;
                        if (user2Position > 100)
                        {
                            user2Position -= diceVal;
                        }
                    }
                    else
                    {
                        user1 = true;
                        user2Position -= diceVal;
                        if (user2Position < startingPosition)
                        {
                            user2Position = startingPosition;
                        }
                    }
                }
            }
           if (user1Position == winningPosition)
            {
                Console.WriteLine("PLAYER 1 IS THE WINNER..!!");
            }
           else
            {
                Console.WriteLine("PLAYER 2 IS THE WINNER..!!");
            }
        }
    }
}
