using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Cards
    {
        public Cards()
        {

        }
            
        public enum Values
        {
            TWO=2,THREE,FOUR,FIVE,SIX,SEVEN,EIGHT,NINE,TEN,JACK,QUEEN,KING,AS
        }

        public enum Names
        {
            HEARTS,SPADES,DIAMONDS,CLUBS
        }

        private Values myvalue;
        private Names myname;


        public Values MyValue { get { return myvalue; } set { myvalue = value; } }
        public Names MyName { get { return myname; } set { myname=value; } }

        public override string ToString()
        {
            return "        "+ myvalue + " OF " + myname;
        }

    }
}
