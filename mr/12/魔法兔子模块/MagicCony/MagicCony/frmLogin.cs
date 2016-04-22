using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
namespace MagicCony
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strg = Application.StartupPath.ToString();
            strg = strg.Substring(0, strg.LastIndexOf("\\"));
            strg = strg.Substring(0, strg.LastIndexOf("\\"));
            strg += @"\ConyData.mdb";
            OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data source=" + strg);
            if (txtUserPassword.Text.Trim() == "")
            {
                txtUserPassword.Focus();
            }
            else
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand("select * from tb_Admin where PassStr='"+txtUserPassword.Text.Trim()+"'", conn);
                OleDbDataReader sdr = cmd.ExecuteReader();
                sdr.Read();
                if (sdr.HasRows)
                {
                    sdr.Close();
                    conn.Close();
                    this.Hide();
                    frmCony cony = new frmCony();
                    cony.Show();
                }
                else
                {
                    this.Text = "°²È«ÃÜÂë´íÎó";
                }
            }
        }
    }
}