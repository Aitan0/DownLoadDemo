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
    public partial class frmAddUser : Form
    {
        public frmAddUser()
        {
            InitializeComponent();
        }

        #region 实例化公共类对象并定义公共变量
        SMS.BaseClass.ConnClass connclass = new SMS.BaseClass.ConnClass();
        public string LinkmanName;
        public string Type;
        public string Num;
        #endregion

        //窗体加载时，设置“性别”下拉列表的默认选项为第一项
        private void frmAddUser_Load(object sender, EventArgs e)
        {
            if (this.Text == "增加联系人")
                cbbSex.SelectedIndex = 0;
            else
            {
                txtName.Text = LinkmanName;
                cbbSex.Text = Type;
                txtNum.Text = Num;
                txtName.ReadOnly = true;
                groupBox1.Text = "修改联系人";
            }
        }

        //判断“电话”文本框中的输入是否为数字
        private void txtNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar != 8 && !char.IsDigit(e.KeyChar)) && e.KeyChar != 13)
            {
                MessageBox.Show("请输入数字");
                e.Handled = true;
            }
        }

        //执行添加/修改联系人操作
        private void pbSubmit_Click(object sender, EventArgs e)
        {
            if (this.Text == "增加联系人")
            {
                if (txtName.Text == "")
                {
                    MessageBox.Show("请输入姓名");
                }
                else
                {
                    if (txtNum.Text.Length < 11)
                    {
                        MessageBox.Show("电话号码位11位");
                    }
                    else
                    {
                        DataSet ds = connclass.geDs("select * from tb_tel where [UserName]='" + txtName.Text + "'");
                        if (ds.Tables[0].Rows.Count > 0)
                            MessageBox.Show("该联系人已经存在");
                        else
                        {
                            connclass.getCmd("insert into tb_tel([UserName],[UserSex],[UserTel]) values('" + txtName.Text + "','" + cbbSex.SelectedItem.ToString() + "','" + txtNum.Text + "')");
                            MessageBox.Show("增加联系人成功");
                        }
                        txtName.Text = "";
                        txtNum.Text = "";
                    }
                }
            }
            else
            {
                connclass.getCmd("update tb_tel set [UserSex]='" + cbbSex.Text + "',[UserTel]='" + txtNum.Text + "' where [UserName]='" + txtName.Text + "'");
                MessageBox.Show("修改联系人成功");
                this.Hide();
            }
        }

        //清空文本框
        private void pbConcel_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtNum.Text = "";
        }
    }
}