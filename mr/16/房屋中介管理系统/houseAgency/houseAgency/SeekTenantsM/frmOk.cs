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
    public partial class frmOk : Form
    {
        ClsCon con = new ClsCon();
        clsMoneyAndInfo cmai = new clsMoneyAndInfo();
        public string M_str_IDofHouse = string.Empty;
        public frmOk()
        {
            InitializeComponent();
            con.ConDatabase();
        }

        private void frmOk_Load(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("proc_select_IwantHouse", con.conn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;

                SqlParameter prams = new SqlParameter("@huoseID", SqlDbType.VarChar, 20);
                prams.Value = M_str_IDofHouse;
                da.SelectCommand.Parameters.Add(prams);

                // 依次把参数传入命令文本
                DataTable dt = new DataTable();
                da.Fill(dt);
                int Num = dt.Rows.Count;

                if (Num > 0)
                {
                    cmai.LID = dt.Rows[0][0].ToString();
                    cmai.LName = dt.Rows[0][1].ToString();
                    cmai.LPhone = dt.Rows[0][2].ToString();
                    lbllendName.Text = cmai.LName;
                    lblPhone.Text = cmai.LPhone;
                }
            }
            catch (Exception ey)
            {
                MessageBox.Show(ey.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("proc_select_IwantUser", con.conn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            SqlParameter pa = new SqlParameter("@userPhone", this.textBox1.Text.Trim().ToString());
            da.SelectCommand.Parameters.Add(pa);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count == 1)
            {

                cmai.WID = dt.Rows[0][0].ToString();
                cmai.WName = dt.Rows[0][1].ToString();
                cmai.Wphone = dt.Rows[0][2].ToString();
                lblwnatName.Text = cmai.WName;
                this.button1.Enabled = true;
            }
            else if (dt.Rows.Count < 1)
            {
                MessageBox.Show("没有找到信息");
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==13)
            this.button2.PerformClick();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("您确定要这个房子吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                frmMoney fm = new frmMoney();

                fm.M_str_info[0] = cmai.LID;
                fm.M_str_info[1] = cmai.LName;
                fm.M_str_info[2] = cmai.LPhone;
                fm.M_str_info[3] = cmai.WID;
                fm.M_str_info[4] = cmai.WName;
                fm.M_str_info[5] = cmai.Wphone;
                fm.M_str_info[6] = M_str_IDofHouse;
                fm.Show();
                this.Close();
            }
        }
    }
}
