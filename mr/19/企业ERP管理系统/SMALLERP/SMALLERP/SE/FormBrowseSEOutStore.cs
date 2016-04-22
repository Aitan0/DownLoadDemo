using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SMALLERP.DataClass;
using SMALLERP.ComClass;

namespace SMALLERP.SE
{
    public partial class FormBrowseSEOutStore : Form
    {

        DataBase db = new DataBase();
        CommonUse commUse = new CommonUse();
        FormSEGather formSEGather = null;

        public FormBrowseSEOutStore()
        {
            InitializeComponent();
        }

        /// <summary>
        /// DataGridView控件绑定到数据源
        /// </summary>
        /// <param name="strWhere">Where条件子句</param>
        private void BindDataGridView(string strWhere)
        {
            string strSql = null;

            strSql = "SELECT * ";
            strSql += "FROM SEOutStore " + strWhere;

            try
            {
                this.dgvSEOutStoreInfo.DataSource = db.GetDataSet(strSql, "SEOutStore").Tables["SEOutStore"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "软件提示");
                throw ex;
            }
        }

        private void FormBrowseSEOutStore_Load(object sender, EventArgs e)
        {

            formSEGather = (FormSEGather)this.Owner;

            commUse.BindComboBox(this.dgvSEOutStoreInfo.Columns["OperatorCode"], "OperatorCode", "OperatorName", "select OperatorCode,OperatorName from SYOperator", "SYOperator");
            commUse.BindComboBox(this.dgvSEOutStoreInfo.Columns["CustomerCode"], "CustomerCode", "CustomerName", "select CustomerCode,CustomerName from BSCustomer", "BSCustomer");
            commUse.BindComboBox(this.dgvSEOutStoreInfo.Columns["StoreCode"], "StoreCode", "StoreName", "select StoreCode,StoreName from BSStore", "BSStore");
            commUse.BindComboBox(this.dgvSEOutStoreInfo.Columns["InvenCode"], "InvenCode", "InvenName", "select InvenCode,InvenName from BSInven", "BSInven");
            commUse.BindComboBox(this.dgvSEOutStoreInfo.Columns["EmployeeCode"], "EmployeeCode", "EmployeeName", "select EmployeeCode,EmployeeName from BSEmployee", "BSEmployee");
            commUse.BindComboBox(this.dgvSEOutStoreInfo.Columns["IsFlag"], "Code", "Name", "select * from INCheckFlag", "INCheckFlag");

            this.BindDataGridView(" WHERE IsFlag = '1'");

            if (dgvSEOutStoreInfo.RowCount <= 0)
            {
                gbInfo.Text = "无已审核销售出库单";
            }
        }

        private void dgvSEOutStoreInfo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSEOutStoreInfo.RowCount > 0)
            {
                formSEGather.txtSEOutCode.Text = this.dgvSEOutStoreInfo["SEOutCode", this.dgvSEOutStoreInfo.CurrentCell.RowIndex].Value.ToString();
                formSEGather.dtpSEOutDate.Value = Convert.ToDateTime(this.dgvSEOutStoreInfo["SEOutDate", this.dgvSEOutStoreInfo.CurrentCell.RowIndex].Value);
                formSEGather.cbxCustomerCode.SelectedValue = this.dgvSEOutStoreInfo["CustomerCode", this.dgvSEOutStoreInfo.CurrentCell.RowIndex].Value;
                formSEGather.txtSEMoney.Text = this.dgvSEOutStoreInfo["SEMoney", this.dgvSEOutStoreInfo.CurrentCell.RowIndex].Value.ToString();
                this.Close();
            }
        }

        private void dgvSEOutStoreInfo_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
