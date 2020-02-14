using System;

namespace guessing_game
{
    class ComputerIsGuessing : GameBase
    {
        public override void Start()
        {
            Console.WriteLine($"Welcome! Please choose a number between {rangeMin} to {rangeMax}");
            Console.WriteLine("I will be trying to guess the number! Wish me luck!");
            ComputerGuessingLoop();
        }

        void ComputerGuessingLoop()
        {
            bool gameOver = false;
            int cutoff = rangeMax / 2;
            int cutoffPrev = rangeMax;

            while (!gameOver)
            {
                // TODO: fix algo going outside of upper bound
                // this if check fixes it for now. something to do with using ceiling?
                if (cutoff > rangeMax)
                {
                    cutoff = rangeMax;
                }
                Console.WriteLine($"Is it {cutoff}? Enter 3 if it is! Enter 2 if it is bigger. 1 if smaller!");
                string userInputStr = Console.ReadLine();
                if (cutoff <= rangeMin && userInputStr == "1" || cutoff == rangeMax && userInputStr == "2")
                {
                    Console.WriteLine("Liar liar pants on fire!");
                    break;
                }
                int temp = cutoff;
                int step = (int)Math.Ceiling(Math.Abs(cutoffPrev - cutoff) / 2d);
                switch (userInputStr)
                {
                    case "1":
                        cutoff -= step;
                        cutoffPrev = temp; 
                        break;
                    case "2":
                        cutoff += step;
                        cutoffPrev = temp;
                        break;
                    case "3":
                        gameOver = true;
                        break;
                }
            }

            Console.WriteLine("TEH SKYNET has won! Thanks for playing!");
        }
    }
}
