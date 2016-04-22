using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EmailManage.CommonClass;

namespace EmailManage
{
    public partial class frmLogin : Form
    {
        Database database = new Database();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                errorProName.SetError(txtUser, "用户名不能为空!");
            }
            else
            {
                errorProName.Clear();
                string strSql = "select * from tb_User where (Name='" + txtUser.Text + "' or Email='" + txtUser.Text + "') and Pwd='" + txtPwd.Text + "'";
                DataSet ds = database.getDs(strSql, "tb_User");
                if (ds.Tables[0].Rows.Count > 0)
                {
                    Database.StrName = txtUser.Text;
                    frmMain frmmain = new frmMain();
                    this.Hide();
                    frmmain.Show();
                }
                else
                {
                    MessageBox.Show("用户名或密码错误！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                txtPwd.Focus();
        }

        private void txtPwd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                btnLogin.Focus();
        }
    }
}