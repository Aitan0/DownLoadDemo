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
    public partial class frmAddDy : Form
    {
        public frmAddDy()
        {
            InitializeComponent();
        }

        //ʵ�������������
        SMS.BaseClass.ConnClass connclass = new SMS.BaseClass.ConnClass();

        //�������ʱ�����á�ѡ��������͡������б��Ĭ��ѡ��Ϊ��һ��
        private void frmAddDy_Load(object sender, EventArgs e)
        {
            cbbType.SelectedIndex = 0;
        }

        //��Ӷ���
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string strtype = cbbType.SelectedItem.ToString();
            string strnote = txtDy.Text;
            connclass.getCmd("insert into tb_note([type],[note]) values('" + strtype + "','" + strnote + "')");
            txtDy.Text = "";
            MessageBox.Show("��ӳɹ�");
        }

        //�رյ�ǰ����
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}