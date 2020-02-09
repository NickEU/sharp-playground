using System;

namespace guessing_game
{
    class GuessingGame
    {
        int userInputInt;
        bool userWantsAnotherTry;
        const int rangeMin = 1, rangeMax = 10;
        int targetNumber;

        public void Start()
        {
            do
            {
                targetNumber = Helpers.GetRandomNumber(rangeMin, rangeMax);
                GetNumberFromUser();
                GuessingLoop();
                userWantsAnotherTry = QuitOrPlay();
            } while (userWantsAnotherTry);
        }

        bool QuitOrPlay()
        {
            Console.WriteLine("Enter 1 if you want to play again.");
            return Console.ReadLine() == "1";
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

        void GuessingLoop()
        {
            bool gameOver = false;

            while (!gameOver)
            {
                if (userInputInt != targetNumber)
                {
                    if (userInputInt > targetNumber)
                    {
                        Console.WriteLine("Lower...");
                    } else
                    {
                        Console.WriteLine("Higher...");
                    }
                    GetNumberFromUser();
                } else
                {
                    Console.WriteLine("Congrats! The answer is {0}", userInputInt);
                    gameOver = true;
                }

            }

        }

    }
}
