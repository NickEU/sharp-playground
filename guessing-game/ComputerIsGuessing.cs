using System;
using System.Collections.Generic;
using System.Text;

namespace guessing_game
{
    class ComputerIsGuessing
    {
        public void Start()
        {
            ComputerGuessingLoop();
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
    }
}
