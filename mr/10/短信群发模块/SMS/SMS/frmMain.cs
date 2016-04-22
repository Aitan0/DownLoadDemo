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

        #region ���幫��������������¼��¼�û����͵�¼ʱ��
        public static string adminname;
        public string admintime;
        #endregion

        //��������¼�����ʾ��ǰ��¼�û��������ݸ��û��ж������Ȩ��
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
                ��Ƭ����MToolStripMenuItem.Enabled = false;
                ���ż�¼SToolStripMenuItem.Enabled = false;
                ���ö���MToolStripMenuItem.Enabled = false;
            }
            conn.Close();
        }

        //��ʾ��ǰϵͳʱ��
        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel5.Text = DateTime.Now.ToString();
        }

        //��ʾ���ڶԻ��򣬲����丸��������Ϊ��ǰ���� 
        private void ����OToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 ab = new AboutBox1();
            ab.MdiParent = this;
            ab.Show();
        }

        //��ʾ���ж��ﴰ�壬�����丸��������Ϊ��ǰ���� 
        private void ���ж���GToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCydy fydy = new frmCydy();
            fydy.MdiParent = this;
            fydy.Show();
        }

        //��ʾ��Ӷ��ﴰ�壬�����丸��������Ϊ��ǰ����
        private void ��Ӷ���KToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddDy adddy = new frmAddDy();
            adddy.MdiParent = this;
            adddy.Show();
        }

        //��ʾ������ϵ�˴��壬�����丸��������Ϊ��ǰ����
        private void ������ϵ��CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTel tel = new frmTel();
            tel.MdiParent = this;
            tel.Show();
        }

        //��ʾ�ѷ��Ͷ��Ŵ��壬�����丸��������Ϊ��ǰ����
        private void �ѷ��Ͷ���FToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmYfxx yfxx = new frmYfxx();
            yfxx.MdiParent = this;
            yfxx.Show();
        }

        //��ʾ�ѽ��ն��ߴ��壬�����丸��������Ϊ��ǰ����
        private void �ѽ��ն���GToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmResvice res = new frmResvice();
            res.MdiParent = this;
            res.Show();
        }

        //�˳���ǰӦ�ó���
        private void �˳�ϵͳToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ȷ��Ҫ�˳���ϵͳ��", "����", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        //��ʾ�����޸Ĵ��壬�����丸��������Ϊ��ǰ����
        private void �����޸�ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChangePwd pwd = new frmChangePwd();
            pwd.MdiParent = this;
            pwd.Show();
        }

        //��ʾ������ϵ�˴��壬�����丸��������Ϊ��ǰ����
        private void ������ϵ��SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUser users = new frmAddUser();
            users.MdiParent = this;
            users.Show();
        }

        //��ʾ����ϵͳ���壬������ӵ��������Ϊ��ǰ����
        private void ����ϵͳToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLock formlock = new frmLock();
            formlock.Owner = this;
            formlock.ShowDialog();
        }

        //�˳���ǰӦ�ó���
        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (MessageBox.Show("ȷ��Ҫ�˳���ϵͳ��", "����", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                Application.Exit();
            }
            else
            {
                frmMain main = new frmMain();
                main.Show();
            }
        }

        //��ʾ����Ⱥ�����壬�����丸��������Ϊ��ǰ����
        private void ����Ⱥ��RToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSendSMS sendsms = new frmSendSMS();
            sendsms.MdiParent = this;
            sendsms.Show();
        }
    }
}