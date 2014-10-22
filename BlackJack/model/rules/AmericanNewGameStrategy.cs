using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack.model.rules
{
    class AmericanNewGameStrategy : NewGameStrategy
    {
        public bool NewGame(Deck a_deck, Dealer a_dealer, Player a_player)
        {
            PlayerCard(a_deck, a_player);
            DealerCardShown(a_deck, a_dealer);
            PlayerCard(a_deck, a_player);
            DealerCardHidden(a_deck, a_dealer);

            return true;
        }
    }
}
