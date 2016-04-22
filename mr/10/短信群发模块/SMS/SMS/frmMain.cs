using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace SMS
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        #region 定义公共变量，用来记录登录用户名和登录时间
        public static string adminname;
        public string admintime;
        #endregion

        //窗体加载事件，显示当前登录用户，并根据该用户判断其操作权限
        private void Form1_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel5.Text = DateTime.Now.ToString();
            toolStripStatusLabel2.Text = adminname;
            toolStripStatusLabel8.Text = admintime;
            OleDbConnection conn = BaseClass.ConnClass.DataConn();
            OleDbCommand cmd = new OleDbCommand("select power from tb_Admin where AdminUserName='"+adminname+"'",conn);
            conn.Open();
            string userPower = Convert.ToString(cmd.ExecuteScalar());
            if (userPower == "0")
            {
                名片管理MToolStripMenuItem.Enabled = false;
                短信记录SToolStripMenuItem.Enabled = false;
                常用短语MToolStripMenuItem.Enabled = false;
            }
            conn.Close();
        }

        //显示当前系统时间
        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel5.Text = DateTime.Now.ToString();
        }

        //显示关于对话框，并将其父窗体设置为当前窗体 
        private void 关于OToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 ab = new AboutBox1();
            ab.MdiParent = this;
            ab.Show();
        }

        //显示所有短语窗体，并将其父窗体设置为当前窗体 
        private void 所有短语GToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCydy fydy = new frmCydy();
            fydy.MdiParent = this;
            fydy.Show();
        }

        //显示添加短语窗体，并将其父窗体设置为当前窗体
        private void 添加短语KToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddDy adddy = new frmAddDy();
            adddy.MdiParent = this;
            adddy.Show();
        }

        //显示所有联系人窗体，并将其父窗体设置为当前窗体
        private void 所有联系人CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTel tel = new frmTel();
            tel.MdiParent = this;
            tel.Show();
        }

        //显示已发送短信窗体，并将其父窗体设置为当前窗体
        private void 已发送短信FToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmYfxx yfxx = new frmYfxx();
            yfxx.MdiParent = this;
            yfxx.Show();
        }

        //显示已接收短线窗体，并将其父窗体设置为当前窗体
        private void 已接收短信GToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmResvice res = new frmResvice();
            res.MdiParent = this;
            res.Show();
        }

        //退出当前应用程序
        private void 退出系统ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要退出本系统吗？", "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        //显示密码修改窗体，并将其父窗体设置为当前窗体
        private void 密码修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChangePwd pwd = new frmChangePwd();
            pwd.MdiParent = this;
            pwd.Show();
        }

        //显示增加联系人窗体，并将其父窗体设置为当前窗体
        private void 增加联系人SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUser users = new frmAddUser();
            users.MdiParent = this;
            users.Show();
        }

        //显示锁定系统窗体，并将其拥有者设置为当前窗体
        private void 锁定系统ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLock formlock = new frmLock();
            formlock.Owner = this;
            formlock.ShowDialog();
        }

        //退出当前应用程序
        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (MessageBox.Show("确定要退出本系统吗？", "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                Application.Exit();
            }
            else
            {
                frmMain main = new frmMain();
                main.Show();
            }
        }

        //显示短信群发窗体，并将其父窗体设置为当前窗体
        private void 短信群发RToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSendSMS sendsms = new frmSendSMS();
            sendsms.MdiParent = this;
            sendsms.Show();
        }
    }
}