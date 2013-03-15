using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Loto;

namespace LotoConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Loto");

            LotoRandom rnd = new LotoRandom(combLength: 7, maxNumber: 39);
            while (true)
            {
                Ticket t1 = new Ticket(rnd.NextCombintaton(7));
                List<int> drawn = rnd.NextCombintaton(7);
                Ticket t2 = new Ticket(drawn);
                int c = t2.CorrectNumbersCount(drawn);


            }
        }
    }
}
