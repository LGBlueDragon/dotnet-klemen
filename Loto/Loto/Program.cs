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
            LotoRandom rnd = new LotoRandom(combLength: 7, maxNumber: 39);
            Ticket t1 = new Ticket(rnd.NextCombintaton(7));
            Console.WriteLine(t1.ToString());

            List<int> drawn = rnd.NextCombintaton(7);
            Ticket t2 = new Ticket(drawn);
            Console.WriteLine(t2.ToString());

            Console.WriteLine("Total ticket issued: " + Ticket.TotalCount());

            int c = t2.CorrectNumbersCount(drawn);
            
        }
    }
}
