namespace Loto
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Ticket
    {
        private DateTime date;
        private string owner;
        private List<int> comb;


        // Konstruktorji
        public Ticket()
        {
            this.date = DateTime.Now;
        }

        public Ticket(List<int> comb)
        {
            this.comb = comb;
            this.date = DateTime.Now;
        }


        // Metode
        public int CorrectNumbersCount(List<int> numbers)
        {
            int correct = 0;
            foreach (int number in numbers)
                if (this.comb.Contains(number))
                    correct++;
            return correct;
        }

    }
}
