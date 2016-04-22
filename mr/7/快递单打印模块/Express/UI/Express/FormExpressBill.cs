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

namespace Express.UI.Express
{
    public partial class FormExpressBill : Form
    {
        IDictionary<int, object> dicKeyValue = new Dictionary<int, object>(); //实例化IDictionary泛型
        DataOperate dataOper = new DataOperate();
        CommClass cc = new CommClass();
        string strExpressBillCodeColumn = null;
        public FormExpressBill()
        {
            InitializeComponent();
        }

        private string m_BillTypeCode;
        public string BillTypeCode
        {
            get
            {
                return m_BillTypeCode;
            }
        }

        private string m_ExpressBillCode;
        public string ExpressBillCode
        {
            get
            {
                return m_ExpressBillCode;
            }
        }

        private void FormExpressBill_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = dataOper.GetDataTable("Select BillTypeCode,BillTypeName From tb_BillType", "tb_BillType");
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    toolcbxBillTypeCode.Items.Insert(i, dt.Rows[i]["BillTypeName"]);
                    dicKeyValue.Add(i, dt.Rows[i]["BillTypeCode"]); //使用IDictionary泛型封装“客户基础分类”信息
                }
                if (toolcbxBillTypeCode.Items.Count > 0)
                {
                    toolcbxBillTypeCode.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "软件提示");
                throw ex;
            }
        }

        private void toolcbxBillType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (toolcbxBillTypeCode.Items.Count > 0)
            {
                //清除现有列
                dgvExpressBill.DataSource = null;
                dgvExpressBill.Columns.Clear();
                //设置快递单类型代码变量
                m_BillTypeCode = dicKeyValue[toolcbxBillTypeCode.SelectedIndex].ToString();//某个具体的类别表(共有两个字段：*BillTypeCode和*BillTypeName)
                DataTable dt = dataOper.GetDataTable("Select * From tb_BillTemplate Where BillTypeCode = '" + m_BillTypeCode + "'", "tb_BillTemplate");
                if (dt.Rows.Count > 0)
                {
                    DataRow drBillCode = dt.AsEnumerable().FirstOrDefault(itm => itm.Field<string>("IsFlag") == "1");
                    if (drBillCode != null)
                    {
                        strExpressBillCodeColumn = drBillCode["ControlId"].ToString();
                        dgvExpressBill.Columns.Add(strExpressBillCodeColumn, drBillCode["ControlName"].ToString());
                        dgvExpressBill.Columns[strExpressBillCodeColumn].DataPropertyName = strExpressBillCodeColumn;
                        dgvExpressBill.Columns[strExpressBillCodeColumn].ReadOnly = true;
                        foreach (DataRow dr in dt.Rows)
                        {
                            //添加代码列
                            if (dr["IsFlag"].ToString() == "0")
                            {
                                string strColumnName = dr["ControlId"].ToString();
                                dgvExpressBill.Columns.Add(strColumnName, dr["ControlName"].ToString());
                                dgvExpressBill.Columns[strColumnName].DataPropertyName = strColumnName;
                                dgvExpressBill.Columns[strColumnName].ReadOnly = true;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("该单据的模板未设置快递单号输入框，无法查询！","信息提示");
                    }
                }
            }
        }

        private void toolQuery_Click(object sender, EventArgs e)
        {
            if (dgvExpressBill.Columns.Count > 0)
            {
                cc.ShowDialogForm(typeof(FormBrowseBill), "Query", this);
            }
        }

        private void toolPrint_Click(object sender, EventArgs e)
        {
            if (dgvExpressBill.RowCount > 0)
            {
                m_ExpressBillCode = dgvExpressBill.CurrentRow.Cells[strExpressBillCodeColumn].Value.ToString();
                cc.ShowDialogForm(typeof(FormBrowseBill), "Print", this);
            }
        }

        private void toolDelete_Click(object sender, EventArgs e)
        {
            if (dgvExpressBill.RowCount > 0)
            {
                if (MessageBox.Show("确定要删除吗？", "软件提示", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    m_ExpressBillCode = dgvExpressBill.CurrentRow.Cells[strExpressBillCodeColumn].Value.ToString();
                    string strSql = "Delete From tb_BillText Where BillTypeCode = '" + m_BillTypeCode + "' and ExpressBillCode = '" + m_ExpressBillCode + "'";
                    if (dataOper.ExecDataBySql(strSql) > 0)
                    {
                        dgvExpressBill.Rows.Remove(dgvExpressBill.CurrentRow);
                        MessageBox.Show("删除成功！", "软件提示");
                    }
                    else
                    {
                        MessageBox.Show("删除失败！", "软件提示");
                    }
                }
            }
        }

        private void toolExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvExpressBill_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            toolPrint_Click(sender, e);
        }
    }
}
