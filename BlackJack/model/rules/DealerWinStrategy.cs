using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack.model.rules
{
    class DealerWinStrategy : IWinGameStrategy
    {
        int g_maxScore = 21;
        public bool Winner(model.Player a_player, model.Dealer a_dealer)
        {
            if (a_player.CalcScore() > g_maxScore)
            {
                return true;
            }
            else if (a_dealer.CalcScore() > g_maxScore)
            {
                return false;
            }
            else if (a_dealer.CalcScore() >= a_player.CalcScore())
            {
                return true;
            }
            else
            {
                return true;
            }
        }
    }
}
