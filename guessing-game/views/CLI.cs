using System;

namespace guessing_game
{
    class CLI : UI
    {
        public static void PrintPlayerGuessResult(bool success, bool lower, int userInputNumber)
        {
            string HiLo = lower ? "LOWER" : "HIGHER";
            string printOutput = success 
                ? $"Congrats! {userInputNumber} is the right answer! Good job" 
                : $"The target number is {HiLo} than {userInputNumber}";
            Console.WriteLine(printOutput);
        }

    }
}
