using System;

namespace guessing_game
{
    class PlayerIsGuessing : GameType
    {
        int userInputInt;
        const int rangeMin = 1, rangeMax = 10;
        int targetNumber;

        public override void Start() 
        {
            Console.WriteLine("Welcome! Try to guess my number!");
            targetNumber = Helpers.GetRandomNumber(rangeMin, rangeMax);
            GetNumberFromUser();
            PlayerGuessingLoop();
        }
        void GetNumberFromUser()
        {
            string userInputStr;
            bool success;

            do
            {
                Console.WriteLine("Enter a number from {0} to {1}. Enter 0 if you want to quit.", rangeMin, rangeMax);
                userInputStr = Console.ReadLine();
                if (userInputStr == "0")
                {
                    Environment.Exit(0);
                }
                success = Int32.TryParse(userInputStr, out userInputInt);

                if (success && (userInputInt > rangeMax || userInputInt < rangeMin))
                {
                    success = false;
                }
            }
            while (!success);
        }

        void PlayerGuessingLoop()
        {
            bool gameOver = false;

            while (!gameOver)
            {
                if (userInputInt != targetNumber)
                {
                    if (userInputInt > targetNumber)
                    {
                        Console.WriteLine("Lower...");
                    }
                    else
                    {
                        Console.WriteLine("Higher...");
                    }
                    GetNumberFromUser();
                }
                else
                {
                    Console.WriteLine("Congrats! The answer is {0}", userInputInt);
                    gameOver = true;
                }

            }

        }
    }
}
