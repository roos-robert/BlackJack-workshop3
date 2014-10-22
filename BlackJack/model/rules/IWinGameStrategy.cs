using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack.model.rules
{
    interface IWinGameStrategy
    {
        bool Winner(model.Player a_player, model.Dealer a_dealer);
    }
}
