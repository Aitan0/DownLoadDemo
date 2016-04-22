using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace firstWebApp
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {

        }

        protected void LoginButton_Click(object sender, EventArgs e)
        {
            if(Login1.UserName.ToString()==""||Login1.Password.ToString() =="")
            {
                Response.Write("<script>alert('请输入必要信息')</script>");

            }
            else
            {
                if(Login1.UserName.ToString()=="123456"&&Login1.Password.ToString() =="123456")
                {
                    Response.Write("<script>alert('登陆成功，将返回打开界面')</script>");
                    Response.Write("<script>window.open('MainWebForm.aspx','_blank')</script>");
                }
                else
                {
                    Response.Write("<script>alert('登陆失败，请重新登陆')</script>");
                }
            }
        }
    }
}