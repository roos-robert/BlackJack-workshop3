using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack.model.rules
{
    class RulesFactory
    {
        public IHitStrategy GetHitRule()
        {
            return new HitSoft17(); // BasicHitStrategy();
        }
        public INewGameStrategy GetNewGameRule()
        {
            return new AmericanNewGameStrategy();
        }
        public IWinGameStrategy GetWinRule()
        {
            return new PlayerWinStrategy();
        }
    }
}
