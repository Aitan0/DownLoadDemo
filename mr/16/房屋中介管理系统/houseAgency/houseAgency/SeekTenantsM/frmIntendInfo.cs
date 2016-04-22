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
    public partial class frmIntendInfo : Form
    {
        ClsCon con = new ClsCon();
        public string M_str_userID = string.Empty;
        public frmIntendInfo()
        {
            InitializeComponent();
            con.ConDatabase();
        }

        private void frmIntendInfo_Load(object sender, EventArgs e)
        {
            flushFaove();
            flushfitment();
            flushfloor();
            flushmothed();
            flushseat();
            flushtype();
           
        }

        #region//fulsh method
        private void flushFaove()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from tb_favor", con.conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cboFavoe.DataSource = dt.DefaultView;
                cboFavoe.DisplayMember = "favor_name";
                cboFavoe.ValueMember = "house_favorID";
            }
            catch (Exception ey)
            {
                MessageBox.Show(ey.Message);
            }
        }

        private void flushfitment()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from tb_fitment", con.conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cobZhuang.DataSource = dt.DefaultView;
                cobZhuang.DisplayMember = "fitment_name";
                cobZhuang.ValueMember = "house_fitmentID";
            }
            catch (Exception ey)
            {
                MessageBox.Show(ey.Message);
            }
        }

        private void flushfloor()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from tb_floor", con.conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cobFlood.DataSource = dt.DefaultView;
                cobFlood.DisplayMember = "floor_name";
                cobFlood.ValueMember = "house_floorID";
            }
            catch (Exception ey)
            {
                MessageBox.Show(ey.Message);
            }
        }

        private void flushmothed()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from tb_mothed", con.conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cobUser.DataSource = dt.DefaultView;
                cobUser.DisplayMember = "mothed_name";
                cobUser.ValueMember = "house_mothedID";
            }
            catch (Exception ey)
            {
                MessageBox.Show(ey.Message);
            }
        }


        private void flushseat()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from tb_seat", con.conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cobDong.DataSource = dt.DefaultView;
                cobDong.DisplayMember = "seat_name";
                cobDong.ValueMember = "house_seatID";
            }
            catch (Exception ey)
            {
                MessageBox.Show(ey.Message);
            }
        }

        private void flushtype()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from tb_type", con.conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cboXing.DataSource = dt.DefaultView;
                cboXing.DisplayMember = "type_names";
                cboXing.ValueMember = "huose_typeID";
            }
            catch (Exception ey)
            {
                MessageBox.Show(ey.Message);
            }
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.txtArea.Text.Trim().ToString() != "" && this.txtPrice.Text.Trim().ToString() != "")
            {
                clsIntendMethed cim = new clsIntendMethed();
                clsIntend cf = new clsIntend();
                cf.tend_id = null;
                cf.u_id = M_str_userID.ToString();
                cf.ty_id = this.cboXing.SelectedValue.ToString();
                cf.se_ID = this.cobDong.SelectedValue.ToString();
                cf.fi_ID = this.cobZhuang.SelectedValue.ToString();
                cf.fl_ID = this.cobFlood.SelectedValue.ToString();
                cf.fa_ID = this.cboFavoe.SelectedValue.ToString();
                cf.mo_ID = this.cobUser.SelectedValue.ToString();
                cf.area = this.txtArea.Text.Trim().ToString();
                cf.price = Convert.ToSingle(this.txtPrice.Text.Trim().ToString());
                DataTable dt=cim.insert_table(cf);
                if (dt.Rows.Count > 0)
                {
                    groupBox2.Visible = true;
                    dataGridView1.DataSource = dt.DefaultView;
                    this.button1.Enabled = false;
                    //这里只取一个如果有必要则可以都找到
                }
                else
                { 
                    MessageBox.Show("谢谢操作欢迎下次再来光顾"); 
                }
                this.button1.Enabled = false;
            }
            else
            {
                MessageBox.Show("请写入完整信息");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void IsNum(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8)
            {
                return;
            }
            else if (e.KeyChar > '9' || e.KeyChar < '0')
            {
                e.Handled = true;
                MessageBox.Show("无效字符");
            }
        }
        private void txtArea_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar!='.')
                IsNum(sender, e);
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '.')
                IsNum(sender, e);
        }
    }
}