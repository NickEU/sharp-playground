using System;

namespace guessing_game
{
    class GuessingGame
    {
        bool userWantsAnotherTry;
        bool playerIsGuessing;
        bool gameChangeIncoming;

        public void Start()
        {
            playerIsGuessing = GetGameType();
            do
            {
                if (gameChangeIncoming)
                {
                    gameChangeIncoming = false;
                    playerIsGuessing = !playerIsGuessing;
                }
                
                if (playerIsGuessing)
                {
                    PlayerIsGuessing game = new PlayerIsGuessing();
                    game.Start();
                } else
                {
                    ComputerIsGuessing game = new ComputerIsGuessing();
                    game.Start();
                }
                userWantsAnotherTry = QuitOrPlay();
            } while (userWantsAnotherTry);
        }

        private bool GetGameType()
        {
            // TODO: implement the functionality of selecting a game type
            // when first entering the program
            return true;
        }

        bool QuitOrPlay()
        {
            Console.WriteLine("Enter 1 if you want to play again. Enter 2 if you wanna play a different game.");
            string input = Console.ReadLine();
            if (input == "2")
            {
                gameChangeIncoming = true;
                return true;
            }
            return input == "1";
        }
    }
}
