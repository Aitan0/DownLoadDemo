using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Express.Common;

namespace Express.UI.BaseSet
{
    public partial class FormBillType : Form
    {
        CommClass cc = new CommClass();

        public FormBillType()
        {
            InitializeComponent();
        }

        private void FormBillType_Load(object sender, EventArgs e)
        {
           bsBillType.DataSource = cc.GetDataTable("tb_BillType", "");
           dgvBillType.DataSource = bsBillType;
        }

        private void toolAdd_Click(object sender, EventArgs e)
        {
            cc.ShowDialogForm(typeof(FormBillTypeInput), "Add", this);
        }

        private void toolAmend_Click(object sender, EventArgs e)
        {
            if (dgvBillType.RowCount > 0)
            {
                cc.ShowDialogForm(typeof(FormBillTypeInput), "Edit", this);
            }
        }

        private void toolDelete_Click(object sender, EventArgs e)
        {
            if (dgvBillType.RowCount == 0)
            {
                return;
            }
            if (MessageBox.Show("确定要删除吗？", "软件提示", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {

                if (cc.IsExistConstraint("tb_BillType", dgvBillType.CurrentRow.Cells["BillTypeCode"].Value.ToString()))
                {
                    if (MessageBox.Show("此种快递单已生成模板，若删除将级联删除对应的模板和快递单记录，是否继续？", "软件提示", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                    {
                        return;
                    }
                }
                DataGridViewRow dgvr = dgvBillType.CurrentRow;
                dgvBillType.Rows.Remove(dgvr);
                if (cc.Commit(dgvBillType,bsBillType))
                {
                    MessageBox.Show("删除成功！", "软件提示");
                }
                else
                {
                    MessageBox.Show("删除失败！", "软件提示");
                }
            }
        }

        private void dgvBillType_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            toolSetting_Click(sender, e);
        }

        private void toolSetting_Click(object sender, EventArgs e)
        {
            if (dgvBillType.RowCount > 0)
            {
                cc.ShowDialogForm(typeof(FormSetTemplate), "", this);
            }
        }

        private void toolExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
