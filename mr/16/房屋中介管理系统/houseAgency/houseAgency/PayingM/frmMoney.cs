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
    public partial class frmMoney : Form
    {
        ClsCon con = new ClsCon();
        public string[] M_str_info = new string[7];
        clsMoneyAndInfo cmai = new clsMoneyAndInfo();
        public frmMoney()
        {
            InitializeComponent();
            con.ConDatabase();
        }

        private void frmMoney_Load(object sender, EventArgs e)
        {
            showEmp();
        }
        private void showEmp()
        {
            SqlDataAdapter da = new SqlDataAdapter("select employee_name,employee_ID from tb_employee", con.conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            this.comboBox1.DataSource = dt.DefaultView;
            this.comboBox1.DisplayMember = "employee_name";
            this.comboBox1.ValueMember = "employee_ID";
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (M_str_info[3] != null)//任意拿出一个元素看是否有值
            {
                cmai.EID = this.comboBox1.SelectedValue.ToString();
                cmai.EName = this.comboBox1.Text.ToString();
                cmai.Pday = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                cmai.PM = Convert.ToSingle(this.textBox2.Text.Trim().ToString());
                cmai.Mark = this.richTextBox1.Text.ToString();

                cmai.LID = M_str_info[0];
                cmai.LName = M_str_info[1];
                cmai.LPhone = M_str_info[2];
                cmai.WID = M_str_info[3];
                cmai.WName = M_str_info[4];
                cmai.Wphone = M_str_info[5];
                cmai.HID = M_str_info[6];

                clsMoneyAndInfoMethod cm = new clsMoneyAndInfoMethod();
                if (cm.insert_table(cmai))
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand("update tb_house set house_state='success' where house_id='" + cmai.HID + "'", con.conn);
                        con.conn.Open();
                        cmd.ExecuteNonQuery();
                        con.closeCon();
                        MessageBox.Show("提交成功！！！");
                        this.Close();
                    }
                    catch
                    {
                        con.closeCon();
                        return;
                    }
                }
                else
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("这是为选定房源后交费而用的\n你的操作可能有问题", "提示");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}