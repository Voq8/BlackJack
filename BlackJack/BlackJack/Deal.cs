using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Deal : Deck
    {

        private List<Cards> player;
        private List<Cards> krupier;

        public Deal()
        {
            player = new List<Cards>(5);
            krupier = new List<Cards>(5);
        }
        public List<Cards> getcadsplayer { get { return player; } }
        public List<Cards> getcadskrupier { get { return krupier; } }

        public void StartAndGiveCards()
        {
            InsertCard();
            AddCardPlayer();
            AddCardPlayer();

            AddCardKrupier();
        }

        public void ShowCardsPlayer()
        {
            for(int i = 0; i<player.Count;i++)
            {
                Console.WriteLine(player[i].ToString());
            }
        }
        public void ShowCardsKrupier()
        {
            for (int i = 0; i < krupier.Count; i++)
            {
                Console.WriteLine(krupier[i].ToString());
            }
        }
        //----------------------------------------
        public void AddCardPlayer()
        {
            AddCardTO(player);
        }
        public void AddCardKrupier()
        {
            AddCardTO(krupier);
        }
        private void AddCardTO(List<Cards> seclist)
        {
            Cards a;
            a = getdeck.First();
            seclist.Add(a);
            getdeck.Remove(a);
        }
        
        
        //-------- TUTAJ TRZEBA DOPRACOWAC!!!!!!!!!! wybranie!
        private int scoreplayer;
        private int scorekrupier;
        private int score;

        public int ScoreFor(List<Cards> Someone)
        {
            score = 0;
                foreach (Cards k in Someone)
                {
                    int c = (int)k.MyValue;
                    if (c > 10)
                    {
                        switch (c)
                        {
                            case 11:
                                score += 10;
                                break;
                            case 12:
                                score += 10;
                                break;
                            case 13:
                                score += 10;
                                break;
                            case 14:
                                score += 10;
                                break;
                        }
                    }
                    else
                    {
                        score += c;
                    }
    
            }
            return score;   
        }

        public void AddScoreToPlayer()
        {
            ScoreFor(player);
            scoreplayer += score;
            MSG(scoreplayer);
        }
        public void AddScoreToKrupier()
        {
            scorekrupier += score;
        }

        public void ResetScore()
        {
            scorekrupier = 0;
            scoreplayer = 0;
        }
        public void MSG(int count)
        {
            Console.WriteLine("Wartość kart = " + count);
        }

    }
}
