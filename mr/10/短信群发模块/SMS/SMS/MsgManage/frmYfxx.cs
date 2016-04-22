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
    public partial class frmYfxx : Form
    {
        public frmYfxx()
        {
            InitializeComponent();
        }

        //ʵ�������������
        SMS.BaseClass.ConnClass connclass = new SMS.BaseClass.ConnClass();
         
        //�������ʱ�����Զ��巽����ʾ�ѷ��͵Ķ�����Ϣ�������á���ѯ�����������Ĭ��ѡ��Ϊ���绰���롱
        private void frmYfxx_Load(object sender, EventArgs e)
        {
            BindSms();
            comboBox1.SelectedIndex = 0;
            comboBox1.SelectedText = "�绰����";
        }
        
        //ɾ��ѡ�еĶ�����Ϣ
        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ȷ��ɾ����", "����", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                if (dataGridView1.SelectedCells.Count > 0)
                {
                    string id = dataGridView1.SelectedCells[0].Value.ToString();
                    connclass.getCmd("delete from tb_TelSend where ID=" + id);
                    MessageBox.Show("ɾ���ɹ�");
                    BindSms();
                }
                else
                {
                    MessageBox.Show("��ѡ��Ҫɾ������Ϣ");
                }
            }
        }

        //ɾ�����ж�����Ϣ
        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ȷ��ɾ����", "����", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                connclass.getCmd("delete from tb_TelSend");
                MessageBox.Show("��Ϣ�Ѿ�ȫ�����", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                BindSms();
            }
        }

        //��ʾ���ж�����Ϣ
        private void button4_Click(object sender, EventArgs e)
        {
            BindSms();
        }
        
        //��ʾ����ָ�������Ķ�����Ϣ
        private void button3_Click(object sender, EventArgs e)
        {
            string strsql = "";
            if (textBox1.Text == "")
            {
                MessageBox.Show("������ؼ���");
            }
            else
            {
                string comstr=comboBox1.SelectedItem.ToString();
                switch(comstr)
                {
                    case "�ֻ�����": strsql = "select * from tb_TelSend where TelNum like '%" + textBox1.Text + "%'"; break;
                    case "��������": strsql = "select * from tb_TelSend where TelContent like '%" + textBox1.Text + "%'"; break;
                    case "����ʱ��": strsql = "select * from tb_TelSend where TelTime like '%" + textBox1.Text + "%'"; break;
                }
                DataSet ds = connclass.geDs(strsql);
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        #region ��ȡ�ѷ��͵Ķ�����Ϣ������ʾ��DataGridView�ؼ���
        /// <summary>
        /// ��ȡ�ѷ��͵Ķ�����Ϣ������ʾ��DataGridView�ؼ���
        /// </summary>
        private void BindSms()
        {
            DataSet ds = connclass.geDs("select * from tb_TelSend order by ID desc");
            dataGridView1.DataSource = ds.Tables[0];
        }
        #endregion
    }
}