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
    public partial class frmDy : Form
    {
        public frmDy()
        {
            InitializeComponent();
        }
        //ʵ�������������
        SMS.BaseClass.ConnClass connclass = new SMS.BaseClass.ConnClass();
        public string stringSedn = "";//��¼ѡ��Ķ���

        //�������ʱ������ѡ��������͡������б��е�Ĭ��ѡ��������Ϊ��һ��
        private void frmDy_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }

        //��ʾָ���������ж���
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds = connclass.geDs("select * from tb_note where type='" + comboBox1.SelectedItem.ToString() + "'");
            dgvShow.DataSource = ds.Tables[0];
        }

        //ѡ��������ӵ�������Ⱥ���������еġ��������ݡ��ı�����
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            stringSedn+=dgvShow.SelectedCells[0].Value.ToString();
            frmSendSMS frmsend = (frmSendSMS)this.Owner;
            frmsend.txtSmsContent.Text = stringSedn;
        }

        //�رյ�ǰ����
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}