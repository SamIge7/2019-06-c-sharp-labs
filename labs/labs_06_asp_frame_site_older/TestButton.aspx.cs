using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace labs_06_asp_frame_site_older
{
    public partial class TestButton : System.Web.UI.Page
    {
        public static int counter = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = "Welcome";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            counter++;
            Label1.Text = $"Welcome, {TextBox1.Text}---{counter}";
        }
    }
}