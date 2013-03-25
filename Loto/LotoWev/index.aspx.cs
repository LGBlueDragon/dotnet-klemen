using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Loto;

namespace LotoWev
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            LotoRandom gen = new LotoRandom(7, 39);
            long textarea = Convert.ToInt64(TextBox1.Text);
            string text = "";
            for (int j = 0; j < textarea; j++)
            {
                List<int> ticket = gen.NextCombintaton();
                int i = 0;
                foreach (int a in ticket)
                {
                    if (i < ticket.Count() - 1)
                        text = text + a + ",";
                    else
                        text = text + a;
                    i++;
                }
                text += "</br>";
            }

            LabelLoToComb.Text = LabelLoToComb.Text + text + "</br>";
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox1.Checked)
                Label1.Text = "Checkbox was checked!";
            else
                Label1.Text = "Checkbox was not checked!";
        }
    }
}