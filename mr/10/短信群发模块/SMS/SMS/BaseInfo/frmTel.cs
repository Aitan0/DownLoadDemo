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
    public partial class frmTel : Form
    {
        public frmTel()
        {
            InitializeComponent();
        }
        //实例化公共类对象
        SMS.BaseClass.ConnClass connclass = new SMS.BaseClass.ConnClass();


        //窗体加载时，调用自定义方法显示所有联系人
        public void frmTel_Load(object sender, EventArgs e)
        {
            SetTelData();
        }

        //执行删除联系人操作
        private void pbDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定删除吗？", "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                string id = dgvAllUser.SelectedCells[0].Value.ToString();
                connclass.getCmd("delete from tb_tel where ID=" + id);
                MessageBox.Show("删除联系人成功");
                SetTelData();
            }
        }

        //关闭当前窗体
        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //双击查看联系人详细信息并修改
        private void dgvAllUser_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string Name = this.dgvAllUser.SelectedCells[1].Value.ToString();
            string Type = this.dgvAllUser.SelectedCells[2].Value.ToString();
            string Num = this.dgvAllUser.SelectedCells[3].Value.ToString();
            frmAddUser frmadduser = new frmAddUser();
            frmadduser.LinkmanName = Name;
            frmadduser.Type = Type;
            frmadduser.Num = Num;
            frmadduser.Text = "修改联系人";
            frmadduser.ShowDialog();
        }

        #region 对DataGridView控件进行数据绑定，显示所有联系人
        /// <summary>
        /// 对DataGridView控件进行数据绑定，显示所有联系人
        /// </summary>
        private void SetTelData()
        {
            DataSet ds = connclass.geDs("select * from tb_tel order by ID desc");
            dgvAllUser.DataSource = ds.Tables[0];
        }
        #endregion
    }
}