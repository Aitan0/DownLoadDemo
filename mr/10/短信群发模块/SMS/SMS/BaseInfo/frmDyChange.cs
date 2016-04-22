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
        #region 实例化公共类对象并定义公共变量
        SMS.BaseClass.ConnClass connclass = new SMS.BaseClass.ConnClass();
        public string Stype;
        public string Scontent;
        public string Sid;
        #endregion

        //窗体加载时，在相应的文本框中显示短语信息
        private void frmDyChange_Load(object sender, EventArgs e)
        {
            txttype.Text = Stype;
            txtContent.Text = Scontent;
        }

        //执行修改短语信息操作
        private void btnSure_Click(object sender, EventArgs e)
        {
            if (txtContent.Text == "")
            {
                MessageBox.Show("请输入常用短语");
            }
            else
            {
                connclass.getCmd("update tb_note set [note]='" + txtContent.Text + "' where ID=" + Sid);
                this.Hide();
            }
        }

        //关闭当前窗体
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}