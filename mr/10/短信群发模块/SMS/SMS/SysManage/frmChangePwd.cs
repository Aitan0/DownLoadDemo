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
        //ʵ�������������
        SMS.BaseClass.ConnClass connclass = new SMS.BaseClass.ConnClass();

        //ִ���޸��������
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("���벻��λ��");
            }
            else
            {
                if (textBox2.Text == "" || textBox2.Text != textBox1.Text)
                {
                    MessageBox.Show("�������벻һ��");
                }
                else
                {
                    connclass.getCmd("update tb_Admin set [AdminUserPwd]='" + MD5Encrypt.GetMD5Password(textBox1.Text) + "' where AdminUserName='" + frmMain.adminname + "'");
                    if (MessageBox.Show("�����޸ĳɹ�", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Warning) == DialogResult.OK)
                    {
                        this.Close();
                    }
                }
            }
        }

        //�رյ�ǰ���� 
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}