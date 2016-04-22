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

        //实例化公共类对象
        SMS.BaseClass.ConnClass connclass = new SMS.BaseClass.ConnClass();
         
        //窗体加载时调用自定义方法显示已发送的短信信息，并设置“查询类别”下拉类表的默认选项为“电话号码”
        private void frmYfxx_Load(object sender, EventArgs e)
        {
            BindSms();
            comboBox1.SelectedIndex = 0;
            comboBox1.SelectedText = "电话号码";
        }
        
        //删除选中的短信信息
        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定删除吗？", "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                if (dataGridView1.SelectedCells.Count > 0)
                {
                    string id = dataGridView1.SelectedCells[0].Value.ToString();
                    connclass.getCmd("delete from tb_TelSend where ID=" + id);
                    MessageBox.Show("删除成功");
                    BindSms();
                }
                else
                {
                    MessageBox.Show("请选择要删除的信息");
                }
            }
        }

        //删除所有短信信息
        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定删除吗？", "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                connclass.getCmd("delete from tb_TelSend");
                MessageBox.Show("信息已经全部清空", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                BindSms();
            }
        }

        //显示所有短信信息
        private void button4_Click(object sender, EventArgs e)
        {
            BindSms();
        }
        
        //显示符合指定条件的短信信息
        private void button3_Click(object sender, EventArgs e)
        {
            string strsql = "";
            if (textBox1.Text == "")
            {
                MessageBox.Show("请输入关键字");
            }
            else
            {
                string comstr=comboBox1.SelectedItem.ToString();
                switch(comstr)
                {
                    case "手机号码": strsql = "select * from tb_TelSend where TelNum like '%" + textBox1.Text + "%'"; break;
                    case "短信内容": strsql = "select * from tb_TelSend where TelContent like '%" + textBox1.Text + "%'"; break;
                    case "发送时间": strsql = "select * from tb_TelSend where TelTime like '%" + textBox1.Text + "%'"; break;
                }
                DataSet ds = connclass.geDs(strsql);
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        #region 获取已发送的短信信息，并显示在DataGridView控件中
        /// <summary>
        /// 获取已发送的短信信息，并显示在DataGridView控件中
        /// </summary>
        private void BindSms()
        {
            DataSet ds = connclass.geDs("select * from tb_TelSend order by ID desc");
            dataGridView1.DataSource = ds.Tables[0];
        }
        #endregion
    }
}