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
    public partial class frmMoneyRemark : Form
    {
        ClsCon con = new ClsCon();

        public int PintCount = 0;
        public frmMoneyRemark()
        {
            InitializeComponent();
            con.ConDatabase();
        }

        private void frmMoneyRemark_Load(object sender, EventArgs e)
        {
            
            this.load();
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PintCount += 1;
            if (PintCount % 2 == 0)
            {
                this.button2.Text = "取消查询";
                this.groupBox2.Enabled = true;
            }
            else
            {
                this.button2.Text = "开始查询";
                this.groupBox2.Enabled = false;
            }
            this.groupBox2.Text ="查询信息";
        }

        private void load()
        {
            SqlDataAdapter da = new SqlDataAdapter("select employee_id,employee_name from tb_employee", con.conn);
            DataTable dt = new DataTable();
            con.conn.Open();
            da.Fill(dt);
            this.comboBox1.DataSource = dt.DefaultView;
            comboBox1.DisplayMember = "employee_name";
            comboBox1.ValueMember = "employee_id";
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            string strid = this.comboBox1.SelectedValue.ToString();
            this.dataGridView1.DataSource = this.dtsorce(strid,date()).DefaultView;
        }

        private DataTable dtsorce(string strid,string date)
        {
         
            StringBuilder sb = new StringBuilder();
            sb.Append("select moeny_ID '业务编号',Pay_Moeny '手续费',");
            sb.Append(" house_ID '房屋编号',Pay_date '收费日期',lend_Name '甲方姓名',lend_Phone '甲方电话',");
            sb.Append(" want_Name '乙方姓名',want_Phone '乙方电话'");
            sb.Append(" from tb_MoneyAndInfo where emp_ID='" + strid + "' and ");
            sb.Append(" Pay_date like '%" + date + "%' ");

            SqlDataAdapter da = new SqlDataAdapter(sb.ToString(), con.conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt; 
        }

        private string date()
        {
            string date = this.dateTimePicker1.Text.Replace('年', '-').Replace('月', '-').Replace('日', ' ');
            string dateNew = string.Empty;
            char[] C ={ '-' };
            string []dateinfo=date.Split(C);
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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            string strid = this.comboBox1.SelectedValue.ToString();
            this.dataGridView1.DataSource = this.dtsorce(strid, date()).DefaultView;
        }
    }
}