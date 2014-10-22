using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack.model.rules
{
    class PlayerWinStrategy : IWinGameStrategy
    {
        int g_maxScore = 21;
        bool Winner(model.Player a_player, model.Dealer a_dealer)
        {
            if (a_player.CalcScore() > g_maxScore)
            {
                return false;
            }
            else if (a_dealer.CalcScore() > g_maxScore)
            {
                return true;
            }
            return a_player.CalcScore() >= a_dealer.CalcScore();
        }
    }
}
