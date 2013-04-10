using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Loto
{
    public class Lottery
    {
        private Dictionary<DateTime, List<int>> drawnnumbers = new Dictionary<DateTime,List<int>>();

        public Lottery()
        {
            StreamReader sr = new StreamReader(@"C:\VSProjects\dotnet-klemen\Loto\LotoWev\drawnnum.txt");
            while (!sr.EndOfStream)
            {
                string tmp = sr.ReadLine();
                tmp = tmp.Replace(" ","");
                string[] tmp2 = tmp.Split(';');
                string[] tmp3 = tmp2[1].Split(',');
                List<int> tmp4 = new List<int>();

                foreach (string i in tmp3)
                {
                    int j = Convert.ToInt16(i);
                    tmp4.Add(j);
                }
                DateTime date = DateTime.Parse(tmp2[0]);
                List<int> ncomb = tmp4;
                drawnnumbers.Add(date, ncomb);
            }

        }

        public List<int> FindDrawnNumbers(DateTime tmpd)
        {
            foreach (DateTime i in drawnnumbers.Keys)
            {
                TimeSpan td = tmpd - i;
                if (td.TotalDays < 7)
                    return drawnnumbers[i];
            }
            return null;
        }
    }
}
