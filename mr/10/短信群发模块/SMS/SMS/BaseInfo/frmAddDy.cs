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

        //实例化公共类对象
        SMS.BaseClass.ConnClass connclass = new SMS.BaseClass.ConnClass();

        //窗体加载时，设置“选择短语类型”下拉列表的默认选项为第一项
        private void frmAddDy_Load(object sender, EventArgs e)
        {
            cbbType.SelectedIndex = 0;
        }

        //添加短语
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string strtype = cbbType.SelectedItem.ToString();
            string strnote = txtDy.Text;
            connclass.getCmd("insert into tb_note([type],[note]) values('" + strtype + "','" + strnote + "')");
            txtDy.Text = "";
            MessageBox.Show("添加成功");
        }

        //关闭当前窗体
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}