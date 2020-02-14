namespace guessing_game
{


    class Program
    {
        static void Main()
        {
            // TODO: 
            // a) implement the functionality of selecting a game type when first entering the program
            // b) decouple USER I/O from guessing logic
            // c) after the console view module is separated = add a web app I/O view
            GuessingGame game = new GuessingGame();
            game.Start();
        }
    }
}
