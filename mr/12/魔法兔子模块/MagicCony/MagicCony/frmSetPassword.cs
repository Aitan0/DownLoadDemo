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
    public partial class frmSetPassword : Form
    {
        public frmSetPassword()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strg = Application.StartupPath.ToString();
            strg = strg.Substring(0, strg.LastIndexOf("\\"));
            strg = strg.Substring(0, strg.LastIndexOf("\\"));
            strg += @"\ConyData.mdb";
            OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data source=" + strg);
            
            string strSql = "";
            if (txtPass.Text.Trim() == "")
            {
                conn.Open();
                strSql = "update tb_Admin set PassStr='ls' where ID=1";
                OleDbCommand cmd = new OleDbCommand(strSql,conn);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    conn.Close();
                    this.Hide();
                    MessageBox.Show("注意:安全密码已经取消！","提示",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                conn.Open();
                strSql = "update tb_Admin set PassStr='"+txtPass.Text.Trim()+"' where ID=1";
                OleDbCommand cmd = new OleDbCommand(strSql, conn);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    conn.Close();
                    this.Hide();
                    MessageBox.Show("提示:设置安全密码成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
    }
}