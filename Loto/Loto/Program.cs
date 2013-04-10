using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Loto;

namespace LotoConsoleApp
{
    class Program
    {
        static Dictionary<string,List<Ticket>> tickets = new Dictionary<string,List<Ticket>>();

        static void Main(string[] args)
        {
            LotoRandom rnd = new LotoRandom(combLength: 7, maxNumber: 39);
            Lottery lot = new Lottery();
            List<int> tmp2 = new List<int>();

            List<int> numbers = rnd.NextCombintaton();
            
            Ticket ticket = new Ticket(numbers);

            tmp2 = lot.FindDrawnNumbers(DateTime.UtcNow);

            if (tmp2 == null)
            {
                Console.WriteLine("NONE FOUND!");
            }
            else
            {
                int wc = ticket.CorrectNumbersCount(tmp2);
                Console.WriteLine(wc);
            }

            Console.WriteLine("Total ticket issued: " + Ticket.TotalCount());
            Console.ReadKey();
        }

        static Ticket IssueTicket(LotoRandom rnd)
        {
            Ticket temp = new Ticket(rnd.NextCombintaton());
            /*Console.Write("Enter ticket owner: ");
            temp.Owner = Console.ReadLine();*/
            Console.WriteLine(temp.ToString());

            return temp;
        }
    }
}
