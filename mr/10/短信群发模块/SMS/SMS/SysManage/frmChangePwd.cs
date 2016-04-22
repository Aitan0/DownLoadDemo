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
    public partial class frmChangePwd : Form
    {
        public frmChangePwd()
        {
            InitializeComponent();
        }
        //实例化公共类对象
        SMS.BaseClass.ConnClass connclass = new SMS.BaseClass.ConnClass();

        //执行修改密码操作
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("密码不能位空");
            }
            else
            {
                if (textBox2.Text == "" || textBox2.Text != textBox1.Text)
                {
                    MessageBox.Show("两次密码不一致");
                }
                else
                {
                    connclass.getCmd("update tb_Admin set [AdminUserPwd]='" + MD5Encrypt.GetMD5Password(textBox1.Text) + "' where AdminUserName='" + frmMain.adminname + "'");
                    if (MessageBox.Show("密码修改成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning) == DialogResult.OK)
                    {
                        this.Close();
                    }
                }
            }
        }

        //关闭当前窗体 
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}