using System;

namespace guessing_game
{
    class ComputerIsGuessing : GameType
    {
        const int rangeMin = 1, rangeMax = 10;
        public override void Start()
        {
            Console.WriteLine($"Welcome! Please choose a number from {rangeMin} to {rangeMax}");
            Console.WriteLine("I will be trying to guess the number! Wish me luck!");
            ComputerGuessingLoop();
        }

        private void ComputerGuessingLoop()
        {
            bool gameOver = false;

            while (!gameOver)
            {
                gameOver = true;
            }

            Console.WriteLine("TEH SKYNET has won! Thanks for playing!");
        }
    }
}
