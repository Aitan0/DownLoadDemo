using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using houseAgency.mothedCls;

namespace houseAgency
{
    public partial class frmBargin : Form
    {
        StringBuilder sb = new StringBuilder();
        StringBuilder sbwhere = new StringBuilder();
        ClsCon con = new ClsCon();

        public frmBargin()
        {
            InitializeComponent();
            con.ConDatabase();
        }

        private void frmBargin_Load(object sender, EventArgs e)
        {
            con.conn.Open();
            showEmp();
        }

        #region//员工信息绑定
        private void showEmp()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select employee_name,employee_ID from tb_employee", con.conn);
                DataTable dt = new DataTable();
                con.closeCon();
                con.conn.Open();
                da.Fill(dt);
                this.comboBox1.DataSource = dt.DefaultView;
                this.comboBox1.DisplayMember = "employee_name";
                this.comboBox1.ValueMember = "employee_ID";
            }
            catch { }

        }
        #endregion

        #region//日期转换方法
        private string date()
        {
            string date = this.dateTimePicker1.Text.Replace('年', '-').Replace('月', '-').Replace('日', ' ');
            string dateNew = string.Empty;
            char[] C ={ '-' };
            string[] dateinfo = date.Split(C);
            //if (dateinfo[1].Trim().ToString().Length <= 1)
            //{
            //    dateNew += dateinfo[0].ToString() + "-0" + dateinfo[1].ToString();
            //}
            //else
            //{
                dateNew += dateinfo[0].ToString() + "/" + dateinfo[1].ToString();
            //}

            //if (dateinfo[2].Trim().ToString().Length <= 1)
            //{
            //    dateNew += "-0" + dateinfo[2].ToString();
            //}
            //else
            //{
                dateNew += "/" + dateinfo[2].ToString();
            //}

            return dateNew;
        }
        #endregion 

        #region//统计信息
            private void button1_Click(object sender, EventArgs e)
            {

              
                sbwhere.Append(" where emp_name='" + this.comboBox1.Text.Trim().ToString() + "' and pay_date like '%" + date() + "%'");
                sb.Remove(0, sb.Length);
                sb.Append("select sum(Pay_Moeny) from tb_MoneyAndInfo ");
                sb.Append(sbwhere.ToString());

                SqlCommand cmd = new SqlCommand(sb.ToString(), con.conn);
                con.closeCon();
                cmd.Connection.Open();
                this.label5.Text = cmd.ExecuteScalar().ToString();
                con.closeCon();

                sb.Remove(0, sb.Length);
                sb.Append("select pay_moeny 本次收款,emp_name 收款人,pay_date 收款日期,");
                sb.Append("lend_name 房主姓名,want_name 客户姓名 from tb_MoneyAndInfo ");
                sb.Append(sbwhere.ToString());
                sbwhere.Remove(0, sbwhere.Length);

                SqlDataAdapter da = new SqlDataAdapter(sb.ToString(), con.conn);
                DataTable dtS = new DataTable();
                da.Fill(dtS);
                this.label6.Text = dtS.Rows.Count.ToString();
                this.dataGridView1.DataSource = dtS.DefaultView;
                con.closeCon();
             
            }  
    #endregion
    }
}