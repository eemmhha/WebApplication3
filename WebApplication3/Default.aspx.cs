using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TextBox1.Text = "0";
        }


        int counter = 0;
        protected void Button1_Click(object sender, EventArgs e)
        {
            counter++;
            TextBox1.Text = counter.ToString();
        }
    }
}