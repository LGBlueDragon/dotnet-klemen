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
            Console.Write("Enter number of tickets you want: ");
            int numbtick = int.Parse(Console.ReadLine());

            for (int i = 0; i < numbtick; i++)
            {
                Ticket tmp = IssueTicket(rnd);
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
