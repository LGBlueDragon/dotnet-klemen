using System;
using System.Collections.Generic;

namespace Loto
{
    public class LotoRandom
    {
        private static Random rnd = new Random();
        private int max;

        // Konstruktor, inicializiramo instanco z največjo številko, ki se lahko pojavlja v kombinacijah.
        public LotoRandom(int maxNumber)
        {
            this.max = maxNumber;
        }


        // Vrača naslednje (psevdo) naključno število
        public int Next()
        {
            return rnd.Next(this.max) + 1;
        }


        // Vrača naslednji (psevdo) naključno kombinacijo
        // samodejno skrbi, da se števila ne ponavljajo
        public List<int> NextCombintaton(int len)
        {
            List<int> tmp = new List<int>();
            do
            {
                int newNumber = Next();
                if (tmp.Contains(newNumber))
                    continue;
                else
                    tmp.Add(newNumber);
            } while (tmp.Count < len);

            tmp.Sort();
            return tmp;
        }
    }
}
