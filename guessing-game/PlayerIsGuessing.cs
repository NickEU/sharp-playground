using System;

namespace guessing_game
{
    class PlayerIsGuessing : GameBase
    {
        int targetNumber;
        public override void Start() 
        {
            Console.WriteLine("Welcome! Try to guess my number!");
            targetNumber = Helpers.GetRandomNumber(rangeMin, rangeMax);
            GetNumberFromUser();
            PlayerGuessingLoop();
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
