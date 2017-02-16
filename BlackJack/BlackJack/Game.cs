using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Game
    {
        Deal game = new Deal();
        MoneyPlayer players = new MoneyPlayer(30,300);
        private string line;
        public void ada()
        {
            game.ShowCard();
        }

        public void LetsStartGame()
        {
            while (players._MoneyKrupier != 0)
            {
                Opis(0);
                Choose();
                Opis(4);
                Console.WriteLine("Aktualnie posiadasz: " + players._MoneyPlayer);
                ReadMoney();
                while(Checkmoney() == false)
                {
                    Console.WriteLine("Aktualnie posiadasz: " + players._MoneyPlayer + " Podaj mniejszą lub równą wartość twoich pieniedzy");
                    ReadMoney();
                }

                players.SetupBet(moneybet);
                players.GiveMoneyTobank();
                Console.Clear();
                Console.WriteLine("kasa w banku "+players._MoneyBank);
                game.StartAndGiveCards();
                Opis(2);
                game.ShowCardsPlayer();
                game.AddScoreToPlayer();

                Space();
                Opis(3);

                game.ShowCardsKrupier();
                Console.WriteLine("??????????");
                Console.ReadKey();
            }
        }
        private string opis;

        private void Space()
        {
            Console.WriteLine();
        }
        private string Opis(int number)
        {
            opis = "";
           switch(number)
            {
                case 0:
                    opis += "Czy chciałbyś zagrać  (y/n)?";
                    break;
                case 1:
                    opis += "Tylko odp y albo n, wpisz jeszcze raz";
                    break;
                case 2:
                    opis += "O to twoje karty: ";
                    break;
                case 3:
                    opis += "O to karta krupiera (jedna zakryta): ";
                    break;
                case 4:
                    opis += "Ile chciałbyś obstawić ?? (Podaj liczbe)";
                    break;
            }
            Console.WriteLine(opis);
            return opis;
        }
        
        private string Choose()
        {

            while (line != "y")
            {
                line = Console.ReadLine();
                if (line == "n")
                {
                    Console.Clear();
                    Console.WriteLine("Dzięki za gre");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
                else if(line == "y")
                {
                    Console.Clear();
                    return line;
                }
                else
                {
                    Console.Clear();
                    Opis(1);
                    line = "";
                }

            }
            return line;
        }
        private int moneybet;
        private void ReadMoney()
        {
            string xline = Console.ReadLine();
            moneybet = Convert.ToInt32(xline);
        }
        private bool Checkmoney()
        {
            if (moneybet <= players._MoneyPlayer)
                return true;
            else
            return false;   
        }
    }
}

