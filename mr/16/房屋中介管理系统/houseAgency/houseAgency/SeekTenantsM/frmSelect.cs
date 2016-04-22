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
    public partial class frmSelect : Form
    {
        StringBuilder strSql = new StringBuilder();
        string strMidle = string.Empty;
        string strWhere = string.Empty;//生成where语句
        ClsCon con = new ClsCon();
        public frmSelect()
        {
            InitializeComponent();
        }
        
        private void frmSelect_Load(object sender, EventArgs e)
        {
            #region//加载时列出所有房源信息
            try
            {
                con.ConDatabase();
                SqlDataAdapter da = new SqlDataAdapter("select * from view_house", con.conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                this.dataGridView1.DataSource = dt.DefaultView;
            }
            catch
            {
            }

            flushFaove();
            flushfitment();
            flushfloor();
            flushmothed();
            flushseat();
            flushtype();
            unAble();
            #endregion
        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region//生成SQL 

                #region//生成where条件字符串
                strSql.Append("select * from view_house where ");


                if (strMidle.IndexOf("house_companyName")!=-1)
                {
                    if (strWhere != string.Empty)
                    {
                        strWhere += "and " + "物业名称 like '%" + this.txtName.Text.Trim().ToString() + "%'" ;
                    }
                    else
                    {
                        strWhere += "物业名称 like '%" + this.txtName.Text.Trim().ToString() + "%'";
                    }
                    strMidle=strMidle.Replace("house_companyName", "#");
                 
                }
                if (strMidle.IndexOf("huose_typeID")!= -1)
                {
                    if (strWhere != string.Empty)
                    {
                        strWhere += "and " + "类型='" + this.cboXing.Text.ToString() + "'" ;
                    }
                    else
                    {
                        strWhere += "类型='" + this.cboXing.Text.ToString() + "'" ;
                    }
                    strMidle=strMidle.Replace("huose_typeID", "#");

                }
                if (strMidle.IndexOf("house_seatID") != -1)
                {
                    if (strWhere != string.Empty)
                    {
                        strWhere += "and " + "幢座='" + this.cobDong.Text.ToString() + "'" ;
                    }
                    else
                    {
                        strWhere += "幢座='" + this.cobDong.Text.ToString() + "'" ;
                    }
                    strMidle=strMidle.Replace("house_seatID", "#");

                }
                if (strMidle.IndexOf("house_favorID") != -1)
                {
                    if (strWhere != string.Empty)
                    {
                        strWhere += "and " + "朝向='" + this.cboFavoe.Text.ToString() + "'" ;
                    }
                    else
                    {
                        strWhere += "朝向='" + this.cboFavoe.Text.ToString() + "'" ;
                    }
                    strMidle=strMidle.Replace("house_favorID", "#");
                  
                }
              

                if (strMidle.IndexOf("house_fitmentID") != -1)
                {
                    if (strWhere != string.Empty)
                    {
                        strWhere += "and " + "装修='" + this.cobZhuang.Text.ToString() + "'" ;
                    }
                    else
                    {
                        strWhere += "装修='" + this.cobZhuang.Text.ToString() + "'" ;
                    }
                    strMidle = strMidle.Replace("house_fitmentID", "#");
                   
                }
                if (strMidle.IndexOf("house_mothedID") != -1)
                {
                    if (strWhere != string.Empty)
                    {
                        strWhere += "and " + "用途='" + this.cobUser.Text.ToString() + "'";
                    }
                    else
                    {
                        strWhere += "用途='" + this.cobUser.Text.ToString() + "'";
                    }
                    strMidle = strMidle.Replace("house_mothedID", "#");
                    //tbho.house_mothedID=tbmo.house_mothedID and 

                }
                if (strMidle.IndexOf("house_floorID") != -1)
                {
                    if (strWhere != string.Empty)
                    {
                        strWhere += "and " + "楼层='" + this.cobFlood.Text.ToString() + "'";
                    }
                    else
                    {
                        strWhere += "楼层='" + this.cobFlood.Text.ToString() + "'" ;
                    }
                    strMidle = strMidle.Replace("house_floorID", "#");
                }
               
                if (strMidle.IndexOf("house_buildYear") != -1)
                {
                    if (strWhere != string.Empty)
                    {
                        strWhere += "and " + "建筑年限='" + this.nudYear.Text.Trim().ToString() + "'" ;
                    }
                    else
                    {
                        strWhere += "建筑年限='" + this.nudYear.Text.Trim().ToString() + "'";
                    }
                    strMidle = strMidle.Replace("house_buildYear", "#");
     
                }
                if (strMidle.IndexOf("house_area") != -1)
                {
                    if (strWhere != string.Empty)
                    {
                        strWhere += "and " + "建筑面积 like '%" + this.txtArea.Text.Trim().ToString() + "%' ";
                    }
                    else
                    {
                        strWhere += "建筑面积 like '%" + this.txtArea.Text.Trim().ToString() + "%'";
                    }
                    strMidle = strMidle.Replace("house_area", "#");

                }
                if (strMidle.IndexOf("house_price") != -1)
                {
                    if (strWhere != string.Empty)
                    {
                        strWhere += "and " + "价钱 like '%" + this.textBox1.Text.Trim().ToString() + "%'" ;
                    }
                    else
                    {
                        strWhere += "价钱 like '%" + this.textBox1.Text.Trim().ToString() + "%'";
                    }
                    strMidle = strMidle.Replace("house_price", "#");
                }

                if (strMidle.IndexOf("house_ID") != -1)
                {
                    if (strWhere != string.Empty)
                    {
                        strWhere += "and " + "房屋编号 like '%" + this.textBox2.Text.Trim().ToString() + "%'";
                    }
                    else
                    {
                        strWhere += "房屋编号 like '%" + this.textBox2.Text.Trim().ToString() + "%'";
                    }
                    strMidle = strMidle.Replace("house_ID", "#");
                }
                #endregion 
                //******************************************************************//
                #region//生成数源
                try
                {
                    string strS = strWhere.Substring(strWhere.Length - 4);
                    if (strS.Trim() == "and")
                    {
                        strWhere = strWhere.Substring(0, strWhere.Length - 4);//去掉尾and
                    }
                }
                catch { return; }
                
                strSql.Append(strWhere);
                string strK = strSql.ToString();
                try
                {
                        SqlDataAdapter da = new SqlDataAdapter(strK, con.conn);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        this.dataGridView1.DataSource = dt.DefaultView;

                        ChuShiHua();
                        clearAll();
                        this.button1.Enabled = false;
                }
                catch (Exception ey)
                {
                    MessageBox.Show(ey.Message);
                }
                strWhere = string.Empty;
                strMidle = string.Empty;
                strSql.Remove(0,strSql.ToString().Length);
                
                #endregion
            #endregion

            button1.Enabled = false;
            this.textBox2.Text = "";
            this.textBox2.Enabled = false;
            checkBox11.Checked = false;
        }
      
        private void button2_Click(object sender, EventArgs e)
        {
            ChuShiHua();
            clearAll();
            this.button1.Enabled = false;
        } 
        
        private void button4_Click(object sender, EventArgs e)
        {
            CheckAll();
            this.button1.Enabled = true;
        }

        #region//取清与全选
        private void clearAll()
        {
            this.checkBox1.Checked = false;
            this.checkBox2.Checked = false; 
            this.checkBox3.Checked = false;
            this.checkBox4.Checked = false;
            this.checkBox5.Checked = false;
            this.checkBox6.Checked = false;
            this.checkBox7.Checked = false;
            this.checkBox8.Checked = false;
            this.checkBox9.Checked = false;
            this.checkBox10.Checked = false;

        }

        private void CheckAll()
        {
            this.checkBox1.Checked = true;
            this.checkBox2.Checked = true;
            this.checkBox3.Checked = true;
            this.checkBox4.Checked = true;
            this.checkBox5.Checked = true;
            this.checkBox6.Checked = true;
            this.checkBox7.Checked = true;
            this.checkBox8.Checked = true;
            this.checkBox9.Checked = true;
            this.checkBox10.Checked = true;

        }
        #endregion

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

        #region//after where string 

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox1.Checked)
            {
                txtName.Enabled = true;
                if (strMidle == string.Empty)
                {
                    strMidle += "@"+"house_companyName" + "@";
                }
                else
                {
                    strMidle += "house_companyName" + "@";
                }
                this.button1.Enabled = true;
            }
            else
            {
                txtName.Enabled = false;
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox8.Checked)
            {
                nudYear.Enabled = true;
                if (strMidle == string.Empty)
                {
                    strMidle += "@" + "house_buildYear" + "@";
                }
                else
                {
                    strMidle += "house_buildYear" + "@";
                }
                this.button1.Enabled = true;
            }
            else
            {
                nudYear.Enabled = false;
            }
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox10.Checked)
            {
                txtArea.Enabled = true;
                if (strMidle == string.Empty)
                {
                    strMidle += "@" + "house_area" + "@";
                }
                else
                {
                    strMidle += "house_area" + "@";
                }
                this.button1.Enabled = true;
  
            }
            else
            {
                txtArea.Enabled = false;
            }  
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox2.Checked)
            {
                cobFlood.Enabled = true;

                if (strMidle == string.Empty)
                {
                    strMidle += "@" + "house_floorID" + "@";
                }
                else
                {
                    strMidle += "house_floorID" + "@";
                }
                this.button1.Enabled = true;
            }
            else
            {
                cobFlood.Enabled = false;
            }  
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox7.Checked)
            {
                cboXing.Enabled = true;
                  if (strMidle == string.Empty)
                {
                    strMidle += "@" +"huose_typeID" + "@";
                }
                else
                {
                    strMidle += "huose_typeID" + "@";
                }
                this.button1.Enabled = true;
               
            }
            else
            {
                cboXing.Enabled = false;
            }  
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox9.Checked)
            {
                cobDong.Enabled = true;
                
                if (strMidle == string.Empty)
                {
                    strMidle += "@" + "house_seatID" + "@";
                }
                else
                {
                    strMidle += "house_seatID" + "@";
                }
                this.button1.Enabled = true;
                
            }
            else
            {
                cobDong.Enabled = false;
            }  
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox3.Checked)
            {
                cboFavoe.Enabled = true;
               
                 if (strMidle == string.Empty)
                {
                    strMidle += "@" + "house_favorID" + "@";
                }
                else
                {
                    strMidle += "house_favorID" + "@";
                }
                this.button1.Enabled = true;
            }
            else
            {
                cboFavoe.Enabled = false;
            }  
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox6.Checked)
            {
                cobZhuang.Enabled = true;
                
                if (strMidle == string.Empty)
                {
                    strMidle += "@" + "house_fitmentID" + "@";
                }
                else
                {
                    strMidle += "house_fitmentID" + "@";
                }
                this.button1.Enabled = true;
            }
            else
            {
                cobZhuang.Enabled = false;
            }  
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox5.Checked)
            {
                cobUser.Enabled = true;
                if (strMidle == string.Empty)
                {
                    strMidle += "@" + "house_mothedID" + "@";
                }
                else
                {
                    strMidle += "house_mothedID" + "@";
                }
                this.button1.Enabled = true;
                
            }
            else
            {
                cobUser.Enabled = false;
            }  
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox4.Checked)
            {
                textBox1.Enabled = true;
                 if (strMidle == string.Empty)
                {
                    strMidle += "@" + "house_price" + "@";
                }
                else
                {
                    strMidle += "house_price" + "@";
                }
                this.button1.Enabled = true;
            }
            else
            {
                textBox1.Enabled = false;
            }
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox11.Checked)
            {
                textBox2.Enabled = true;
                if (strMidle == string.Empty)
                {
                    strMidle += "@" + "house_ID" + "@";
                }
                else
                {
                    strMidle += "house_ID" + "@";
                }
                this.button1.Enabled = true;
            }
            else
            {
                textBox2.Enabled = false;
            }
        }
        #endregion

        #region//user controls to control
        private void ChuShiHua()
        {
            foreach (Control cont in this.groupBox1.Controls)
            {
                if (cont.GetType().ToString() == "System.Windows.Forms.TextBox")
                {
                    cont.Text = string.Empty;
                }
                if (cont.GetType().ToString() == "System.Windows.Forms.ComboBox")
                {
                    cont.Enabled = false;
                }
            }
        }

        private void unAble()
        {
            foreach (Control cont in this.groupBox1.Controls)
            {
                if ((cont.GetType().ToString() == "System.Windows.Forms.TextBox") || (cont.GetType().ToString() == "System.Windows.Forms.ComboBox"))
                {
                    cont.Enabled = false;
                }
            }
        }
        #endregion


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

        private void txtArea_KeyPress(object sender, KeyPressEventArgs e)
        {
            IsNum(sender, e);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            IsNum(sender, e);
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            Int32 selectedRowCount = dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {
                try
                {
                    string str = this.dataGridView1.SelectedCells[0].Value.ToString();
                    if (str.IndexOf("hou") != -1)
                    {
                        frmHouse fh = new frmHouse();
                        fh.M_str_Show = str;
                        fh.ShowDialog(this);
                    }
                    str = string.Empty;
                }
                catch {}
            }  
        }
    }
}