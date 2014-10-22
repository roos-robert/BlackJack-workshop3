using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack.model.rules
{
    class InternationalNewGameStrategy : NewGameStrategy
    {

        public override bool NewGame(Deck a_deck, Dealer a_dealer, Player a_player)
        {
            PlayerCard(a_deck, a_player);
            DealerCardShown(a_deck, a_dealer);
            PlayerCard(a_deck, a_player);

            return true;
        }
    }
}
