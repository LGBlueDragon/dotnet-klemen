﻿using System;
using System.Collections.Generic;

namespace Loto
{
    public class LotoRandom
    {
        private static Random rnd = new Random();
        private int max;
        private int combLength;

        // Konstruktor
        // inicializiramo instanco z dolžino kombinacije in
        // največjo številko, ki se lahko pojavlja v kombinacijah.
        public LotoRandom(int combLength, int maxNumber)
        {
            this.max = maxNumber;
            this.combLength = combLength;
        }


        // Vrača naslednji (psevdo) naključno kombinacijo
        // samodejno skrbi, da se števila ne ponavljajo
        public List<int> NextCombintaton()
        {
            List<int> tmp = new List<int>();
            do
            {
                int newNumber = Next();
                if (tmp.Contains(newNumber))    // številka že obstaja, gremo znova
                    continue;
                else
                    tmp.Add(newNumber);
            } while (tmp.Count < this.combLength);

            tmp.Sort();
            return tmp;
        }

        // Vrača naslednje (psevdo) naključno število po naših pravilih
        private int Next()
        {
            return rnd.Next(this.max) + 1;
        }
    }
}
