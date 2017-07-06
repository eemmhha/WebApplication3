using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                TextBox1.Text = "0";
            }
        }
        int c;
        protected void Button1_Click(object sender, EventArgs e)
        {

            //               c = (int)ViewState["clicks"] + 1;
            c = Convert.ToInt32(TextBox1.Text)+1;         
            // countrer++;
            TextBox1.Text = c.ToString();
            //ViewState["clicks"] = countrer;
        }
    }
}