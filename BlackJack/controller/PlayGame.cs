using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BlackJack.model;

namespace BlackJack.controller
{
    class PlayGame : IDealCardListener
    {
        private view.IView a_view;
        private model.Game a_game;

        public PlayGame(model.Game a_game, view.IView a_view)
        {
            this.a_view = a_view;
            this.a_game = a_game;
        }

        // Run on first init of program.
        public bool Play()
        {
            a_view.DisplayWelcomeMessage();
            
            ShowBlackJack(a_game.IsGameOver());

            int input = a_view.GetInput();

            if (input == a_view.GetNewGame())
            {
                System.Threading.Thread.Sleep(1000);
                a_game.NewGame();
            }
            else if (input == a_view.GetHit())
            {
                System.Threading.Thread.Sleep(1000);
                a_game.Hit();
            }
            else if (input == a_view.GetStand())
            {
                System.Threading.Thread.Sleep(1000);
                a_game.Stand();
            }

            return input != a_view.GetQuit();
        }

        // Method for showing the hands, called on by CardDeal() on new data
        public void ShowBlackJack(bool isGameOver)
        {
            if (isGameOver == true)
            {
                a_view.ShowBlackJack(a_game.GetDealerHand(), a_game.GetPlayerHand(), a_game.GetDealerScore(), a_game.GetPlayerScore(), true, a_game.IsDealerWinner());
            }
            else
            {
                a_view.ShowBlackJack(a_game.GetDealerHand(), a_game.GetPlayerHand(), a_game.GetDealerScore(), a_game.GetPlayerScore(), false, false);
            }
        }

        // Handles what to do on new data, here presenting and then pausing for EXTRA DRAMA DURR DURR DUUUUR!
        public void CardDealed() {
            a_view.DisplayWelcomeMessage();
            ShowBlackJack(a_game.IsGameOver());
            System.Threading.Thread.Sleep(3000);
            Console.Clear();
        }
    }
}