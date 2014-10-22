using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack.view
{
    interface IView
    {
        void DisplayWelcomeMessage();
        void DisplayCard(model.Card a_card);
        void DisplayPlayerHand(IEnumerable<model.Card> a_hand, int a_score);
        void DisplayDealerHand(IEnumerable<model.Card> a_hand, int a_score);
        void DisplayGameOver(bool a_dealerIsWinner);
        // TODO optimize, a base view should  be added, since functionality is the same for all views for this method.
        void ShowBlackJack(IEnumerable<model.Card> dealerHand, IEnumerable<model.Card> playerHand, int dealerScore, int playerScore, bool gameOver, bool a_dealerIsWinner);
    }
}
