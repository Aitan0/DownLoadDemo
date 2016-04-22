using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;
using System.Collections;

namespace firstWebApp
{
    public partial class MainWebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                ArrayList arrlist = new ArrayList();
                arrlist.Add("White");
                arrlist.Add("Red");
                arrlist.Add("Green");
                arrlist.Add("Blue");
                arrlist.Add("LightGray");
                this.DropDownList1.DataSource = arrlist;
                this.DropDownList1.DataBind();
            }
        }
        public bool IsNumeric(object expression)
        {
            bool isnumber;
            double retnum;
            isnumber = Double.TryParse(Convert.ToString(expression), System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.InvariantInfo, out retnum);
            return isnumber;
        }
        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            if(this.TextBox1.Text.Length==0)
            {
                Page.RegisterClientScriptBlock("", "please insert a num");
            }
            else
            {
                int result;
                bool n1 = IsNumeric(this.TextBox1.Text.Trim());
                if(n1)
                {
                    result = int.Parse(this.TextBox1.Text.Trim()) % 2;
                    if(result==0)
                    {
                        this.TextBox2.Text = "偶数";

                    }
                    else
                    {
                        this.TextBox2.Text = "奇数";
                    }
                }
                else
                {
                    Page.RegisterClientScriptBlock("", "please insert a num");
                }
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            this.TextBox3.ForeColor = Color.Black;
            this.TextBox3.Text = "Chinese Dream is the minzu Dream,at same time is the dream erverone chinese";
            this.Button1.Focus();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            this.TextBox3.ForeColor = Color.Red;
            this.TextBox3.Text = "Chinese Dream is the minzu Dream,at same time is the dream erverone chinese";
            this.Button1.Focus();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            this.TextBox4.Text = "";
            if (this.CheckBox2.Checked == true)
                this.TextBox4.Text += this.CheckBox2.Text + "\n";
            if (this.CheckBox3.Checked == true)
                this.TextBox4.Text += this.CheckBox3.Text + "\n";
            if (this.CheckBox4.Checked == true)
                this.TextBox4.Text += this.CheckBox4.Text + "\n";
            if (this.CheckBox5.Checked == true)
                this.TextBox4.Text += this.CheckBox5.Text + "\n";
            if (this.CheckBox6.Checked == true)
                this.TextBox4.Text += this.CheckBox6.Text + "\n";
            if (this.CheckBox7.Checked == true)
                this.TextBox4.Text += this.CheckBox7.Text + "\n";
            if (this.CheckBox8.Checked == true)
                this.TextBox4.Text += this.CheckBox8.Text + "\n";
            if (this.CheckBox9.Checked == true)
                this.TextBox4.Text += this.CheckBox9.Text + "\n";
            if (this.CheckBox10.Checked == true)
                this.TextBox4.Text += this.CheckBox10.Text + "\n";
        }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb2 = this.CheckBox2;
            CheckBox cb3 = this.CheckBox3;
            CheckBox cb4 = this.CheckBox4;
            CheckBox cb5 = this.CheckBox5;
            CheckBox cb6 = this.CheckBox6;
            CheckBox cb7 = this.CheckBox7;
            CheckBox cb8 = this.CheckBox8;
            CheckBox cb9 = this.CheckBox9;
            CheckBox cb10 = this.CheckBox10;
            if(this.CheckBox1.Checked==true)
            {
                cb2.Checked = true;
                cb3.Checked = true;
                cb4.Checked = true;
                cb5.Checked = true;
                cb6.Checked = true;
                cb7.Checked = true;
                cb8.Checked = true;
                cb9.Checked = true;
                cb10.Checked = true;
            }
            else
            {
                cb2.Checked = false;
                cb3.Checked = false;
                cb4.Checked = false;
                cb5.Checked = false;
                cb6.Checked = false;
                cb7.Checked = false;
                cb8.Checked = false;
                cb9.Checked = false;
                cb10.Checked = false;
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string color = this.DropDownList1.SelectedItem.Value;
            switch(color)
            {
                case "Red":
                    this.Label1.BackColor = System.Drawing.Color.Red;
                    break;
                case "Green":
                    this.Label1.BackColor = System.Drawing.Color.Green;
                    break;
                case "LightGray":
                    this.Label1.BackColor = System.Drawing.Color.LightGray;
                    break;
                default:
                    this.Label1.BackColor = System.Drawing.Color.Black;
                    break;

            }   
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Write("<script>window.open('Login.aspx','_blank')</script>");
           
           
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Response.Write("<script>window.open('Request.aspx','_blank')</script>");
        }
    }
}