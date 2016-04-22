using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Express.Common;
using Express.DAL;

namespace Express.UI.BaseSet
{
    public partial class FormOperator : Form
    {
        DataOperate dataOper = new DataOperate();
        CommClass cc = new CommClass();

        public FormOperator()
        {
            InitializeComponent();
        }

        private void FormOperator_Load(object sender, EventArgs e)
        {
            bsOperator.DataSource = cc.GetDataTable("tb_Operator", "");
            dgvOperator.DataSource = bsOperator;
        }

        private void toolAdd_Click(object sender, EventArgs e)
        {
            cc.ShowDialogForm(typeof(FormOperatorInput), "Add", this);
        }

        private void toolAmend_Click(object sender, EventArgs e)
        {
            if (dgvOperator.RowCount > 0)
            {
                cc.ShowDialogForm(typeof(FormOperatorInput), "Edit", this);
            }
        }

        private void toolDelete_Click(object sender, EventArgs e)
        {
            if (dgvOperator.RowCount == 0 || dgvOperator.CurrentRow.Cells["IsFlag"].Value.ToString() == "1")
            {
                return;
            }
            if (MessageBox.Show("确定要删除吗？", "软件提示", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                DataGridViewRow dgvr = dgvOperator.CurrentRow;
                dgvOperator.Rows.Remove(dgvr);
                if (cc.Commit(dgvOperator,bsOperator))
                {
                    MessageBox.Show("删除成功！", "软件提示");
                }
                else
                {
                    MessageBox.Show("删除失败！", "软件提示");
                }
            }
        }

        private void toolExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvOperator_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            toolAmend_Click(sender, e);
        }
    }
}
