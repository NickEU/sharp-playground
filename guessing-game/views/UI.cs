namespace guessing_game
{
    class UI
    {
        //public string type;
        public static void ShowPlayerGuessResult(int userInputNumber, bool success, bool lower = true)
        {
            CLI.PrintPlayerGuessResult(success, lower, userInputNumber);
        }
    }
}
