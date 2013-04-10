using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Loto;

namespace LotoWev
{
    public partial class validator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Parse(Date.Text);
            List<int> comb = new List<int>();
            comb.Add(int.Parse(TextBox1.Text));
            comb.Add(int.Parse(TextBox2.Text));
            comb.Add(int.Parse(TextBox3.Text));
            comb.Add(int.Parse(TextBox4.Text));
            comb.Add(int.Parse(TextBox5.Text));
            comb.Add(int.Parse(TextBox6.Text));
            comb.Add(int.Parse(TextBox7.Text));
            
            Ticket ticket = new Ticket(date,comb);

            Lottery lottery = new Lottery();

            List<int> correct = lottery.FindDrawnNumbers(date);

            int correctcount = ticket.CorrectNumbersCount(correct);

            PrintNum.Text = String.Format("You have {0} correct combinations." + correct.ToString(),correctcount);
        }
    }
}