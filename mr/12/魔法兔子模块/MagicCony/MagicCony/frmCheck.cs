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
    public partial class frmCheck : Form
    {
        public frmCheck()
        {
            InitializeComponent();
        }

        private void frmCheck_Load(object sender, EventArgs e)
        {
            string strg = Application.StartupPath.ToString();
            strg = strg.Substring(0, strg.LastIndexOf("\\"));
            strg = strg.Substring(0, strg.LastIndexOf("\\"));
            strg += @"\ConyData.mdb";
            OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data source=" + strg);
            conn.Open();
            OleDbCommand cmd = new OleDbCommand("select PassStr from tb_Admin where ID=1", conn);
            string flag = cmd.ExecuteScalar().ToString();
            if (flag == "ls")
            {
                this.Hide();
                frmCony cony = new frmCony();
                cony.Show();
            }
            else
            {
                this.Hide();
                frmLogin login = new frmLogin();
                login.Show();
            }
        }
    }
}