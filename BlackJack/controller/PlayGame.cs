using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BlackJack.model;

namespace BlackJack.controller
{
    class PlayGame : IDealCardListener
    {
        view.IView a_view;
        model.Game a_game;

        public bool Play(model.Game a_game, view.IView a_view)
        {
            this.a_view = a_view;
            this.a_game = a_game;

            a_view.DisplayWelcomeMessage();

            CardDealed();

            if (a_game.IsGameOver())
            {
                a_view.DisplayGameOver(a_game.IsDealerWinner());
            }

            int input = Console.In.Read();

            if (input == 'p')
            {
                a_game.NewGame();
            }
            else if (input == 'h')
            {
                a_game.Hit();
            }
            else if (input == 's')
            {
                a_game.Stand();
            }

            return input != 'q';
        }

        public void CardDealed() {        
            a_view.DisplayDealerHand(a_game.GetDealerHand(), a_game.GetDealerScore());
            a_view.DisplayPlayerHand(a_game.GetPlayerHand(), a_game.GetPlayerScore());
        }
    }
}