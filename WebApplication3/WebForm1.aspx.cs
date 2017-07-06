using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        int countrer = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                TextBox1.Text = "0";
            }
        }
       
        protected void Button2_Click(object sender, EventArgs e)
        {
            if(ViewState["clicks"]!=null)
            {
                countrer =(int)ViewState["clicks"] + 1;
            }
           // countrer++;
            TextBox1.Text = countrer.ToString();
            ViewState["clicks"] = countrer;
        }
    }
}