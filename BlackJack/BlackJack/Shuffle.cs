using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BlackJack
{
    static class Shuffle
    {
        private static Random random = new Random();

        public static void  Shufle<T>(this IList<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int x = random.Next(n + 1);
                T value = list[x];
                list[x] = list[n];
                list[n] = value;
            }
        }
    }


}
