using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using houseAgency.mothedCls;
using System.Data.SqlClient;

namespace houseAgency
{
    public partial class frmHouse : Form
    {
        public string M_str_Show = String.Empty;
        public string M_str_temp = string.Empty;
        //public string M_str_tend = string.Empty;
        string strResult = string.Empty;
        string strPath = string.Empty;
        string strSatae = string.Empty;
        ClsCon con=new ClsCon();
        ClsHouse ch = new ClsHouse();
        ClsHouseMethed chm = new ClsHouseMethed();
        public frmHouse()
        {
            InitializeComponent();
        }
        #region//load
        private void frmHouse_Load(object sender, EventArgs e)
        {
            string strHouseState = string.Empty;
            con.ConDatabase();
            flushFaove();
            flushfitment();
            flushfloor();
            flushmothed();
            flushseat();
            flushtype();

            if (M_str_Show == String.Empty)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("select Max(house_ID) from tb_house", con.conn);
                    cmd.Connection.Open();
                    strResult = cmd.ExecuteScalar().ToString();
                    con.closeCon();
                    if (strResult == "")
                    {
                        strResult = "hou1001";
                    }
                    else
                    {
                        string strTemp = strResult.Substring(3);
                        strResult = "hou" + Convert.ToString(Int32.Parse(strTemp) + 1);
                    }
                    this.lblHouseID.Text = "您的房屋编号为：" + strResult;

                }
                catch (Exception ey)
                {
                    con.closeCon();
                    MessageBox.Show(ey.Message);
                }
            }
            else
            {
                this.button8.Visible = false;
                this.butOK.Visible = false;
                Visable();
                SqlCommand cmd = new SqlCommand("select * from tb_house where house_ID='" + M_str_Show + "' ", con.conn);
                con.conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        lblHouseID.Text = dr[0].ToString();
                        this.txtName.Text = dr[1].ToString();
                        this.picHouse.ImageLocation = dr[8].ToString();
                        txtPrice.Text = dr[9].ToString();
                        this.nudYear.Value = Convert.ToDecimal(dr[11].ToString());
                        this.txtArea.Text = dr[12].ToString();
                        this.ttbRemark.Text = dr[13].ToString();
                        strHouseState = dr[4].ToString();
                        this.cboXing.SelectedValue = dr[2].ToString();
                        this.cobDong.SelectedValue = dr[3].ToString();
                        this.cboFavoe.SelectedValue = dr[6].ToString();
                        this.cobZhuang.SelectedValue = dr[5].ToString();
                        this.cobUser.SelectedValue = dr[7].ToString();
                        this.cobFlood.SelectedValue = dr[10].ToString();
                    }
                }
                con.closeCon();
                if (strHouseState == "none")
                {
                    //什么时候出显
                    button1.Visible = true;
                    button2.Visible = true;
                }
            }        
        }
        #endregion

        #region//支持回车
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                SendKeys.Send("{Tab}");
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.IsNum(sender, e);
        }
        #endregion

        #region//fulsh method
        private void flushFaove()
        {
            con.ConDatabase();
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
            con.ConDatabase();
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
            con.ConDatabase();
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
            con.ConDatabase();
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
            con.ConDatabase();
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
            con.ConDatabase();
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

        #region//返回典表
        private void button5_Click(object sender, EventArgs e)
        {
            frmFavor ff = new frmFavor();
            if (ff.ShowDialog() == DialogResult.OK)
            {
               
                flushFaove();//重新刷信息
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            frmType ft = new frmType();
          
            if (ft.ShowDialog() == DialogResult.OK)
            {
               
                flushtype();
            }
        }

        private void butSeat_Click(object sender, EventArgs e)
        {
            frmSeat ft = new frmSeat();
        
            if (ft.ShowDialog() == DialogResult.OK)
            {
               
                flushseat();
            }
        }

        private void butFloor_Click(object sender, EventArgs e)
        {
            frmFloor ft = new frmFloor();
           
            if (ft.ShowDialog() == DialogResult.OK)
            {
               
                flushfloor();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmMothed ft = new frmMothed();
      
            if (ft.ShowDialog() == DialogResult.OK)
            {
               
                flushmothed();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmFitment ft = new frmFitment();
           
            if (ft.ShowDialog() == DialogResult.OK)
            {
               
                flushfitment();
            }
        }

        #endregion
        
        #region//写入房源信息
        private void butOK_Click(object sender, EventArgs e)
        {
            if (txtArea.Text.ToString() != "" && txtPrice.Text.ToString() != "")
            {
                ch.id = strResult;
                ch.name = this.txtName.Text.Trim().ToString();
                ch.typeID = this.cboXing.SelectedValue.ToString();
                ch.seatID = this.cobDong.SelectedValue.ToString();
                ch.state = "none";
                ch.favorID = this.cboFavoe.SelectedValue.ToString();
                ch.fitmentID = this.cobZhuang.SelectedValue.ToString();
                ch.mothedID = this.cobUser.SelectedValue.ToString();
                ch.floorID = this.cobFlood.SelectedValue.ToString();
                ch.map = strPath;
                ch.price = txtPrice.Text.Trim().ToString();
            
                ch.buildYear = this.nudYear.Value.ToString();
                ch.area = this.txtArea.Text.Trim().ToString();
                ch.remark = this.ttbRemark.Text;
                ch.urids = this.M_str_temp;
                
                DataTable dt =chm.insert_table(ch);
                if (dt.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dt.DefaultView;
                    this.groupBox4.Visible = true;
                    this.butOK.Enabled = false;
                }
                else
                {
               
                    strSatae = "haveinto";
                    MessageBox.Show("成功录入房源");
                    this.Close();
                    this.butOK.Enabled = false;
                
                }
            }
            else if (txtArea.Text.ToString()== "")
            {
                label12.Visible = true;
            }
            else if (txtPrice.Text.ToString() == "")
            {
                label11.Visible = true;
            }

        }
        #endregion

        private void Visable()
        {
            foreach (Control ct in this.groupBox1.Controls)
            {
                if (ct.GetType().ToString() == "System.Windows.Forms.Button")
                    ct.Visible = false;
            
            }

        }

        private void VisableTrue()
        {
            foreach (Control ct in this.groupBox1.Controls)
            {
                if (ct.GetType().ToString() == "System.Windows.Forms.Button")
                    ct.Visible = true;

            }

        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            //只可以是数字和小字数和退格键的方法
            this.IsNum(sender, e);
        }
       
        private void picHouse_DoubleClick(object sender, EventArgs e)
        {
            opFile();
        }
       
        #region//method
        private void IsNum(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8)
            {
                return;
            }
            else if (e.KeyChar == 13)
            {
                SendKeys.Send("{Tab}");
            }
            else if (e.KeyChar > '9' || e.KeyChar < '0' && e.KeyChar != '.')
            {
                e.Handled = true;
                MessageBox.Show("无效字符");
            }
        }

       private void opFile()
        {
            this.opImage.Filter = "图片文件(*.bmp)|*.bmp|所有文件(*.*)|*.*";
            if (this.opImage.ShowDialog() == DialogResult.OK)
            {
                strPath = this.opImage.FileName.ToString();
                this.picHouse.ImageLocation = strPath;
            }
        }
        #endregion

        private void button1_Click_1(object sender, EventArgs e)
        {
            frmOk fo = new frmOk();
            fo.M_str_IDofHouse = this.lblHouseID.Text.Trim().ToString();
            this.Close();
            fo.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VisableTrue();//字典表信息显示
            if (this.button2.Text == "修改")
            {
                button2.Text = "确定";
            }
            else
            {
                if (txtArea.Text.ToString() != "" && txtPrice.Text.ToString() != "")
                {
                    ch.id = lblHouseID.Text;
                    ch.name = this.txtName.Text.Trim().ToString();
                    ch.typeID = this.cboXing.SelectedValue.ToString();
                    ch.seatID = this.cobDong.SelectedValue.ToString();
                    ch.favorID = this.cboFavoe.SelectedValue.ToString();
                    ch.fitmentID = this.cobZhuang.SelectedValue.ToString();
                    ch.mothedID = this.cobUser.SelectedValue.ToString();
                    ch.floorID = this.cobFlood.SelectedValue.ToString();
                    ch.map = strPath;
                    ch.price = txtPrice.Text.Trim().ToString();
                    ch.buildYear = this.nudYear.Value.ToString();
                    ch.area = this.txtArea.Text.Trim().ToString();
                    ch.remark = this.ttbRemark.Text;

                    if (chm.update_table(ch))
                    {
                        this.button2.Text ="修改";
                        this.Visable();
                        MessageBox.Show("修改成功");
                    }
                }
            }
        }
    }
}