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
    public partial class frmDyChange : Form
    {
        public frmDyChange()
        {
            InitializeComponent();
        }
        #region ʵ������������󲢶��幫������
        SMS.BaseClass.ConnClass connclass = new SMS.BaseClass.ConnClass();
        public string Stype;
        public string Scontent;
        public string Sid;
        #endregion

        //�������ʱ������Ӧ���ı�������ʾ������Ϣ
        private void frmDyChange_Load(object sender, EventArgs e)
        {
            txttype.Text = Stype;
            txtContent.Text = Scontent;
        }

        //ִ���޸Ķ�����Ϣ����
        private void btnSure_Click(object sender, EventArgs e)
        {
            if (txtContent.Text == "")
            {
                MessageBox.Show("�����볣�ö���");
            }
            else
            {
                connclass.getCmd("update tb_note set [note]='" + txtContent.Text + "' where ID=" + Sid);
                this.Hide();
            }
        }

        //�رյ�ǰ����
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}