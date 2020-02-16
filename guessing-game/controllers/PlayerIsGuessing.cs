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
                    UI.ShowPlayerGuessResult(userInputInt, false, userInputInt > targetNumber);
                    GetNumberFromUser();
                }
                else
                {
                    UI.ShowPlayerGuessResult(userInputInt, true);
                    gameOver = true;
                }

            }

        }
    }
}
