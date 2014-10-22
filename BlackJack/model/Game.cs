using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack.model
{
    class Game
    {
        private List<IDealCardListener> m_subscribers;

        private model.Dealer m_dealer;
        private model.Player m_player;

        public Game()
        {
            m_dealer = new Dealer(new rules.RulesFactory());
            m_player = new Player();
            m_subscribers = new List<IDealCardListener>();
        }

        public void Register(IDealCardListener a_subscriber)
        {
            m_subscribers.Add(a_subscriber);
        }

        public bool IsGameOver()
        {
            return m_dealer.IsGameOver();
        }

        public bool IsDealerWinner()
        {
            return m_dealer.IsDealerWinner(m_player, m_dealer);
        }

        public bool NewGame()
        {
            return m_dealer.NewGame(m_player);
        }

        public bool Hit()
        {
            //foreach (var item in m_subscribers)
            //{
            //    item.CardDealed();
            //}
            return m_dealer.Hit(m_player);
        }

        public bool Stand()
        {
            m_dealer.Stand();
            return true;
        }

        public IEnumerable<Card> GetDealerHand()
        {
            return m_dealer.GetHand();
        }

        public IEnumerable<Card> GetPlayerHand()
        {
            return m_player.GetHand();
        }

        public int GetDealerScore()
        {
            return m_dealer.CalcScore();
        }

        public int GetPlayerScore()
        {
            return m_player.CalcScore();
        }
    }
}
