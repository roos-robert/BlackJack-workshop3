using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack.model.rules
{
    abstract class NewGameStrategy : INewGameStrategy
    {
        Card c;
        public void PlayerCard(Deck a_deck, Dealer a_dealer, Player a_player)
        {            
            c = a_deck.GetCard();
            c.Show(true);
            a_player.DealCard(c);
        }

        public void DealerCardShown(Deck a_deck, Dealer a_dealer, Player a_player)
        {
            c = a_deck.GetCard();
            c.Show(true);
            a_dealer.DealCard(c);
        }

        public void DealerCardHidden(Deck a_deck, Dealer a_dealer, Player a_player)
        {
            c = a_deck.GetCard();
            c.Show(false);
            a_dealer.DealCard(c);            
        }
    }
}
