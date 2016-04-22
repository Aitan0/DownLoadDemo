using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using SMS.BaseClass;

namespace SMS
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        //窗体加载时为“用户名”文本框设置焦点
        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtLoginName.Focus();
        }

        //指定用户登录操作
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtLoginName.Text == "")
                {
                    MessageBox.Show("用户名不能为空");
                }
                else
                {
                    if (txtLoginPwd.Text == "")
                    {
                        MessageBox.Show("密码不能为空");
                    }
                    else
                    {
                        OleDbConnection conn = BaseClass.ConnClass.DataConn();
                        conn.Open();
                        OleDbCommand cmd = new OleDbCommand("select count(*) from tb_Admin where AdminUserName='" + txtLoginName.Text + "' and AdminUserPwd='" + MD5Encrypt.GetMD5Password(txtLoginPwd.Text) + "'", conn);
                        int i = Convert.ToInt32(cmd.ExecuteScalar());
                        if (i > 0)
                        {
                            frmMain main = new frmMain();
                            frmMain.adminname = txtLoginName.Text;//记录当前登录
                            main.admintime = DateTime.Now.ToShortDateString();
                            main.Show();//显示主窗体
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("用户名或者密码错误");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        //退出当前应用程序
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //按回车键时，将鼠标焦点移动到登录按钮上
        private void txtLoginPwd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnLogin_Click(sender,e);
            }
        }

        //按回车键时，将鼠标焦点移动到密码文本框中
        private void txtLoginName_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (e.KeyChar == 13)
            {
                txtLoginPwd.Focus();
            }
        }
    }
}