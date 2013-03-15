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

            LotoRandom rnd = new LotoRandom(39);
            while (true)
            {
                Console.WriteLine(rnd.Next());
                List<int> comb = rnd.NextCombintaton(7);
                Ticket t1 = new Ticket(comb);
                Ticket t2 = new Ticket(rnd.NextCombintaton(7));

                if (t1.Equals(t2))
                {
                    Console.WriteLine("!Enako!");
                }
            }
        }
    }
}
