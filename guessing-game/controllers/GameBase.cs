using System;

namespace guessing_game
{
    class GameBase
    {
        protected const int rangeMin = 1, rangeMax = 10;
        protected int userInputInt;

        protected void GetNumberFromUser()
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
        public virtual void Start()
        {

        }
    }
}
