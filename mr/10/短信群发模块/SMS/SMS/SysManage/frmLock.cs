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
    public partial class frmLock : Form
    {
        public frmLock()
        {
            InitializeComponent();
        }

        //�����ı����а��»س���ʱ������꽹���ƶ�������������ť��
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                pictureBox1_Click(sender, e);
            }
        }

        //ִ�н�������
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = BaseClass.ConnClass.DataConn();
            conn.Open();
            OleDbCommand cmd = new OleDbCommand("select count(*) from tb_Admin where AdminUserPwd='" + textBox1.Text.Trim() + "' and AdminUserName='" + frmMain.adminname + "'", conn);
            int i = Convert.ToInt32(cmd.ExecuteScalar());
            if (i > 0)
            {
                this.Close();
            }
            else
            {
                if (MessageBox.Show("�������", "����", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    textBox1.Text = "";
                    textBox1.Focus();
                }
            }
        }
    }
}