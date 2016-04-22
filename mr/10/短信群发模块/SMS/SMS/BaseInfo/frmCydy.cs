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
    public partial class frmCydy : Form
    {
        public frmCydy()
        {
            InitializeComponent();
        }
        private string str;//记录已选择的短语
        //实例化公共类对象
        SMS.BaseClass.ConnClass connclass = new SMS.BaseClass.ConnClass();

        #region 对DataGridView控件进行数据绑定
        /// <summary>
        /// 对DataGridView控件进行数据绑定
        /// </summary>
        public void BindData()
        {
            DataSet ds = connclass.geDs("select * from tb_note where type='" + str + "'");
            dgvShow.DataSource = ds.Tables[0];
        }
        #endregion

        //关闭当前窗体
        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //删除选中的短语
        private void pbDelete_Click(object sender, EventArgs e)
        {
           string id = dgvShow.SelectedCells[0].Value.ToString();
           connclass.getCmd("delete from tb_note where ID=" + id);
           MessageBox.Show("删除成功");
           BindData();
        }

        //显示选中短语的详细信息
        private void dgvShow_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = this.dgvShow.SelectedCells[0].Value.ToString();
            string content = this.dgvShow.SelectedCells[2].Value.ToString();
            string type = tvDy.SelectedNode.Text;
            frmDyChange dychange = new frmDyChange();
            dychange.Scontent = content;
            dychange.Sid = id;
            dychange.Stype = type;
            dychange.ShowDialog();
        }

        //窗体激活时显示所有短语信息
        private void frmCydy_Activated(object sender, EventArgs e)
        {
            BindData();
        }

        //显示指定类别的短语
        private void tvDy_AfterSelect(object sender, TreeViewEventArgs e)
        {
            str = tvDy.SelectedNode.Text;
            BindData();
        }
    }
}