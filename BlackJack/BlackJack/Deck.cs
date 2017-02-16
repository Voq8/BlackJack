using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Deck : Cards
    {
        private List<Cards> deck;

        public Deck()
        {
            deck = new List<Cards>();  
        }

        public List<Cards> getdeck {
            get { return deck; }
        }


        public void InsertCard()
        {
            foreach(Values V in Enum.GetValues(typeof(Values)))
            {
                foreach(Names N in Enum.GetValues(typeof(Names)))
                { 
                        deck.Add(new Cards { MyValue = V, MyName = N });
                }
            }
           deck.Shufle();
        }

        public void ShowCountDeck()
        {
            Console.WriteLine(deck.Count());
        }
        public void ShowCard2()
        {
            var q = getdeck.Where(card => card.MyValue == Values.KING );


            foreach(var k in q)
            {
                Console.WriteLine(k);
            }
        }
        public void ShowCard()
        {
            foreach(var q in getdeck)
            {
                Console.WriteLine(q);
            }
        }
        


    }
}
