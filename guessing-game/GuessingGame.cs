using System;

namespace guessing_game
{
    class GuessingGame
    {
        int userInputInt;
        bool userWantsAnotherTry;
        const int rangeMin = 1, rangeMax = 10;
        int targetNumber;
        bool playerIsGuessing;
        bool gameChangeIncoming;

        public void Start()
        {
            playerIsGuessing = GetGameType();
            do
            {
                if (gameChangeIncoming)
                {
                    gameChangeIncoming = false;
                    playerIsGuessing = !playerIsGuessing;
                }
                
                if (playerIsGuessing)
                {
                    Console.WriteLine("Welcome! Try to guess my number!");
                    targetNumber = Helpers.GetRandomNumber(rangeMin, rangeMax);
                    GetNumberFromUser();
                    PlayerGuessingLoop();
                } else
                {
                    ComputerGuessingLoop();
                }
                userWantsAnotherTry = QuitOrPlay();
            } while (userWantsAnotherTry);
        }

        private bool GetGameType()
        {
            return true;
        }

        bool QuitOrPlay()
        {
            Console.WriteLine("Enter 1 if you want to play again. Enter 2 if you wanna play a different game.");
            string input = Console.ReadLine();
            if (input == "2")
            {
                gameChangeIncoming = true;
                return true;
            }
            return input == "1";
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

        private void ComputerGuessingLoop()
        {
            bool gameOver = false;

            while (!gameOver)
            {
                gameOver = true;
            }

            Console.WriteLine("Computer has won! Thanks for playing!");
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
