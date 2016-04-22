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

        //�������ʱΪ���û������ı������ý���
        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtLoginName.Focus();
        }

        //ָ���û���¼����
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtLoginName.Text == "")
                {
                    MessageBox.Show("�û�������Ϊ��");
                }
                else
                {
                    if (txtLoginPwd.Text == "")
                    {
                        MessageBox.Show("���벻��Ϊ��");
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
                            frmMain.adminname = txtLoginName.Text;//��¼��ǰ��¼
                            main.admintime = DateTime.Now.ToShortDateString();
                            main.Show();//��ʾ������
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("�û��������������");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        //�˳���ǰӦ�ó���
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //���س���ʱ������꽹���ƶ�����¼��ť��
        private void txtLoginPwd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnLogin_Click(sender,e);
            }
        }

        //���س���ʱ������꽹���ƶ��������ı�����
        private void txtLoginName_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (e.KeyChar == 13)
            {
                txtLoginPwd.Focus();
            }
        }
    }
}