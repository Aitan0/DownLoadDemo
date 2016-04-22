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
        //实例化公共类对象
        SMS.BaseClass.ConnClass connclass = new SMS.BaseClass.ConnClass();
        public string stringSedn = "";//记录选择的短语

        //窗体加载时，将“选择短语类型”下拉列表中的默认选择项设置为第一项
        private void frmDy_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }

        //显示指定类别的所有短语
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds = connclass.geDs("select * from tb_note where type='" + comboBox1.SelectedItem.ToString() + "'");
            dgvShow.DataSource = ds.Tables[0];
        }

        //选择短语，并添加到“短信群发”窗体中的“短信内容”文本框中
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            stringSedn+=dgvShow.SelectedCells[0].Value.ToString();
            frmSendSMS frmsend = (frmSendSMS)this.Owner;
            frmsend.txtSmsContent.Text = stringSedn;
        }

        //关闭当前窗体
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}