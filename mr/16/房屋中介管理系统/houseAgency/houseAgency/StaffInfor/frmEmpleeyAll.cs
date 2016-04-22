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
    public partial class frmEmpleeyAll : Form
    {
        ClsCon con = new ClsCon();
        string strTemp = string.Empty;
        public frmEmpleeyAll()
        {
            InitializeComponent();
        }

        private void frmEmpleeyAll_Load(object sender, EventArgs e)
        {
            showAll();
            this.cobPower.Items.Add("员工");
            this.cobPower.Items.Add("经理");
        }

        #region //表示层的调用
        private void tp_OK_Click(object sender, EventArgs e)
        {
            string power = string.Empty;
            if (this.cobPower.Text == "员工")
            {
                power = "0";
            }
            else if (this.cobPower.Text == "经理")
            {
                power = "1";
            }

            #region//调用触发器去更新
            if (strTemp == "Update")
            {
                float fmoney = Convert.ToSingle(this.txtBasePay.Text.Trim().ToString());
                SqlCommand cmd = new SqlCommand("update view_empleey set 权限='" + power + "',电话='" + this.txtPhone.Text.Trim().ToString() + "',工资='" +fmoney+ "' where 姓名='" + this.txtName.Text.Trim().ToString() + "'", con.conn);
                con.conn.Open();
                cmd.ExecuteNonQuery();
                con.closeCon();
                showAll();
                MessageBox.Show("成功更改");
                strTemp = string.Empty;

            }
            else if( strTemp ==string.Empty)
            {
                MessageBox.Show("没有选取要对谁操作");
            }
            #endregion

        }
        private void tsAll_Click(object sender, EventArgs e)
        {
            showAll();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            selectInfo();
        }


        private void tb_delete_Click(object sender, EventArgs e)
        {
            #region//触发器删除
            if (MessageBox.Show("确定删除这个员工吗？", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                //按员工的名删同时删两个表有关于视图的触发器
                
                SqlCommand cmd = new SqlCommand("delete from view_empleey where 姓名='" + this.txtName.Text.Trim().ToString() + "'", con.conn);
                con.conn.Open();
                cmd.ExecuteNonQuery();
                con.closeCon();
                showAll();
                MessageBox.Show("成功删除");
            }
            #endregion
            showAll();

        }

        private void tb_update_Click(object sender, EventArgs e)
        {
            //按员工的名改同时删两个表有关于视图的触发器
            strTemp = "Update";
        }

        private void tp_cancel_Click(object sender, EventArgs e)
        {
            this.strTemp = string.Empty;
            this.Close();
        }
        #endregion

        #region//操作数字信息
        /*
         * 这个应用写在一一个方法里每次都去调用就可以
         *
         * 
         * */
        private void IsNum(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8)
            {
                return;
            }
            else if (e.KeyChar > '9' || e.KeyChar < '0' )
            {
                e.Handled = true;
                MessageBox.Show("无效字符");
            }
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 13)
            {
                IsNum(sender, e);
            }
            else
            {
                SendKeys.Send("{Tab}");
            }
        }

        private void txtBasePay_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar== '.')
            {
               
            }
            else
            {
                IsNum(sender, e);
            }
        }
        #endregion

        #region//反写信息与显示方法
        private void selectInfo()
        {
            try
            {
                string str = this.dataGridView1.SelectedCells[0].Value.ToString();
                //再来个反添信息
                SqlCommand cmd = new SqlCommand("select 姓名,电话,权限,工资 from view_empleey where 员工编号='" + str + "'", con.conn);
                cmd.Connection.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    txtName.Text = dr[0].ToString();
                    txtPhone.Text = dr[1].ToString();
                    txtBasePay.Text = dr[3].ToString();

                    if (dr[2].ToString() == "0")
                    {
                        cobPower.Text = "员工";
                    }
                    else
                    {
                        cobPower.Text = "经理";
                    }
                }
                dr.Close();
                con.closeCon();
            }
            catch
            {//have hide error
            }
        }

        private void showAll()
        {
            con.ConDatabase();
            SqlDataAdapter da = new SqlDataAdapter("select * from view_empleey", con.conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            this.dataGridView1.DataSource = dt.DefaultView;
        }
        #endregion
    }
}