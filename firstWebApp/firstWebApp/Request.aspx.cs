using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace firstWebApp
{
    public partial class Request : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.RadioButton1.Checked = true;
            this.TextBox1.Text += Request.Browser.Version.ToString();
        }

        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
if(this.RadioButton1.Checked==true)
{
    this.TextBox1.Text += Request.Browser.Version.ToString();
}
        }

        protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (this.RadioButton2.Checked == true)
            {
                this.TextBox1.Text += Request.Browser.Platform.ToString();
            }

        }

        protected void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (this.RadioButton3.Checked == true)
            {
                this.TextBox1.Text += Request.UrlReferrer.Authority.ToString();
            }
        }

        protected void RadioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (this.RadioButton4.Checked == true)
            {
                this.TextBox1.Text += Request.UserHostAddress.ToString();
            }
        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {
            this.Label1.Text = "Now the time is:" + DateTime.Now.ToString();
        }
    }
}