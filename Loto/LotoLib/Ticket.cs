namespace Loto
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Ticket
    {
        private static int count = 0;

        private int serial;         // serijska številka srečke
        private DateTime date;      // datum izdaje srečke
        private string owner;       // lastnik
        private List<int> comb;     // kombinacija številk


        // Konstruktorji
        public Ticket()
        {
            this.serial = ++count;
            this.date = DateTime.Now;
        }

        public Ticket(List<int> comb)
        {
            this.serial = ++count;
            this.date = DateTime.Now;
            this.comb = comb;
        }


        // Accessorji
        public int Serial
        {
            get { return this.serial; }
        }

        public DateTime Date
        {
            get { return this.date; }
        }

        public string GetOwner()
        {
            return "This ticket is owned by: " + this.owner;
        }

        public void SetOwner(string tempOwner)
        {
            this.owner = tempOwner + " " +DateTime.UtcNow;
        }

        public string Owner
        {
            get { return this.owner; }
            set { this.owner = value; }
        }

        // Metode

        // Vrne število vseh izdanih srečk
        public static int TotalCount()
        {
            return count;
        }


        // Vrne število pravilnih številk v kombinaciji
        public int CorrectNumbersCount(List<int> numbers)
        {
            int correct = 0;
            foreach (int number in numbers)
                if (this.comb.Contains(number))
                    correct++;
            return correct;
        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            /*sb.AppendFormat("Serial number: {0}\n", this.serial);
            sb.AppendFormat("Issue date: {0}\n", this.date.ToShortDateString());
            sb.AppendFormat("Ticket owner: {0}\n", this.Owner);
            sb.Append("Combination: ");*/
            int count = 0;
            foreach (int num in this.comb)
            {
                sb.Append(num);
                if (++count < this.comb.Count)
                    sb.Append(", ");
            }
            return sb.ToString();
        }
    }
}
