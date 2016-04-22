using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Express.Common;
using Express.UI.BaseSet;
using Express.UI.Express;

namespace Express
{
    public partial class AppForm : Form
    {
        CommClass cc = new CommClass();

        public AppForm()
        {
            InitializeComponent();
        }

        private void menuItemSetBill_Click(object sender, EventArgs e)
        {
            cc.ShowFormByMdiParent(typeof(FormBillType), this);
        }

        private void menuItemBillPrint_Click(object sender, EventArgs e)
        {
            cc.ShowFormByMdiParent(typeof(FormBillPrint), this);
        }

        private void menuItemSetOperator_Click(object sender, EventArgs e)
        {
            cc.ShowFormByMdiParent(typeof(FormOperator), this);
        }

        private void menuItemAmendPass_Click(object sender, EventArgs e)
        {
            cc.ShowFormByMdiParent(typeof(FormAmendPassword), this);
        }

        private void menuItemBillQuery_Click(object sender, EventArgs e)
        {
            cc.ShowFormByMdiParent(typeof(FormExpressBill), this);
        }

        private void menuItemExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AppForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
            this.Dispose();
        }
    }
}
