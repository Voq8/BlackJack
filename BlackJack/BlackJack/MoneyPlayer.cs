using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class MoneyPlayer
    {
        private int moneykrupier;
        private int moneyplayer;
        private int bet;

        public MoneyPlayer(int Moneyplayer, int Moneykrupier)
        {
            moneyplayer = Moneyplayer;
            moneykrupier = Moneykrupier;
        }
        private int MoneyBank;
        public int _MoneyBank { get { return MoneyBank ; } }

        public int _MoneyKrupier
        {
            get { return moneykrupier; }
        }
        public int _MoneyPlayer
        {
            get { return moneyplayer; }
        }

        public int SetupBet(int value)
        {
            bet += value;
            return bet;
        }

        public void GiveMoneyTobank()
        {
            MoneyBank += (2 * bet);
            bet = 0;
        }

        public void WinKrupierAddToMoney()
        {
            moneyplayer -= bet;
            moneykrupier += MoneyBank;
            ResetMoney();
        }
        public void WinPlayerAddToPlayerMoney()
        {
            moneykrupier -= bet;
            moneyplayer += MoneyBank;
            ResetMoney();
        }
        private void ResetMoney()
        {
            MoneyBank = 0;
            bet = 0;
        }

    }
}
