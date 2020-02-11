using System;

namespace guessing_game
{
    class Helpers
    {
        public static int GetRandomNumber(int min, int max)
        {
            Random rand = new Random();
            return rand.Next(min, max);
        }
    }
}
