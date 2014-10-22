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

        public bool Play()
        {
            a_view.DisplayWelcomeMessage();
            
            ShowBlackJack(a_game.IsGameOver());

            int input = Console.In.Read();

            if (input == 'p')
            {
                System.Threading.Thread.Sleep(1000);
                a_game.NewGame();
            }
            else if (input == 'h')
            {
                System.Threading.Thread.Sleep(1000);
                a_game.Hit();
            }
            else if (input == 's')
            {
                System.Threading.Thread.Sleep(1000);
                a_game.Stand();
            }

            return input != 'q';
        }

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

        public void CardDealed() {
            a_view.DisplayWelcomeMessage();
            ShowBlackJack(a_game.IsGameOver());
            System.Threading.Thread.Sleep(3000);
            Console.Clear();
        }
    }
}