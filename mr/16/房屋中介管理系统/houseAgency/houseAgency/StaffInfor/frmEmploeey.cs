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
    public partial class frmEmploeey : Form
    {
        ClsCon con = new ClsCon();
        public frmEmploeey()
        {
            InitializeComponent();
        }

        private void btnGov_Click(object sender, EventArgs e)
        {
            frmGov fg = new frmGov();
            if (fg.ShowDialog() == DialogResult.OK)
            {
                flushGov();
            }
        }

        private void btnSutdy_Click(object sender, EventArgs e)
        {
            frmStudyDegree fs = new frmStudyDegree();
            if (fs.ShowDialog() == DialogResult.OK)
            {
                flushStudy();
            }
        }

        private void frmEmploeey_Load(object sender, EventArgs e)
        {
            con.ConDatabase();
            flushGov();
            flushStudy();
            this.cbSex.Items.Add("ÄÐ");
            this.cbSex.Items.Add("Å®");
            this.cbSex.SelectedIndex = 0;

        }

        private void flushGov()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from tb_gov", con.conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cobGov.DataSource = dt.DefaultView;
                cobGov.DisplayMember = "gov_name";
                cobGov.ValueMember = "gov_id";
            }
            catch (Exception ey)
            {
                MessageBox.Show(ey.Message);
            }
        }

        private void flushStudy()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from tb_studyDegree", con.conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                this.cobStudy.DataSource = dt.DefaultView;
                this.cobStudy.DisplayMember = "studyDegree_name";
                this.cobStudy.ValueMember = "studyDegree_ID";
            }
            catch (Exception ey)
            {
                MessageBox.Show(ey.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                clsEmpleey ce = new clsEmpleey();
                ce.eName = this.txtName.Text.Trim().ToString();
                ce.eSex = this.cbSex.Text.ToString();
                ce.eDay = this.dtBirthday.Text.ToString();
                ce.eAddress = this.txtAddress.Text.Trim().ToString();
                ce.eIDCard = this.txtIDCard.Text.Trim().ToString();
                ce.ePhone = this.txtPhone.Text.Trim().ToString();
                ce.EPay = Convert.ToSingle(this.txtBasePay.Text.Trim().ToString());
                ce.eGID = this.cobGov.SelectedValue.ToString();
                ce.eStuID = this.cobStudy.SelectedValue.ToString();
                clsEmpleeyMethed cem = new clsEmpleeyMethed();
                if (cem.insert_table(ce))
                {
                    MessageBox.Show("ok");
                    this.Close();

                }
            }
            catch (Exception ey)
            {
                MessageBox.Show(ey.Message);
            }
            
            
        }
     
        private void IsNum(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8)
            {
                return;
            }
            else if (e.KeyChar > '9' || e.KeyChar < '0' )
            {
                e.Handled = true;
                MessageBox.Show("ÎÞÐ§×Ö·û");
            }
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
           IsNum(sender, e);
        }

        private void txtBasePay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar!='.')
                IsNum(sender, e);
        }

        private void txtIDCard_KeyPress(object sender, KeyPressEventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        } 
    }
}