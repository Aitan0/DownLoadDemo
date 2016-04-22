using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ScreenKinescope.ClassFolder;
namespace ScreenKinescope
{
    public partial class frmGeneral : Form
    {
        public frmGeneral()
        {
            InitializeComponent();
        }
        BaseClass bc = new BaseClass();
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (this.saveFileDialog1.ShowDialog() == DialogResult.OK)//判断是否选择了文件
            {
                txtPath.Text = saveFileDialog1.FileName;//显示选择的文件
            }
        }

        private void frmGeneral_Load(object sender, EventArgs e)
        {
            OleDbConnection conn=bc.GetConn();
            conn.Open();
            OleDbCommand cmd = new OleDbCommand("select * from tb_VideoPath where ID=1", conn);
            OleDbDataReader sdr = cmd.ExecuteReader();
            sdr.Read();
            string str = sdr["strPath"].ToString().Trim();
            txtPath.Text = str;
            string Mycursor=sdr["CursorYN"].ToString().Trim();
            if (Mycursor == "显示光标")
            {
                radioButton1.Checked = true;
            }
            else
            {
                radioButton2.Checked = true;
            }
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtPath.Text == "")
            { }
            else
            {
                string strUpdate = "update tb_VideoPath set strPath='"+txtPath.Text.Trim()+"' where ID=1";
                OleDbConnection conn = bc.GetConn();
                conn.Open();
                OleDbCommand cmd = new OleDbCommand(strUpdate, conn);
                cmd.ExecuteNonQuery();
                string strCursor;
                if (radioButton1.Checked)
                {
                    strCursor = "update tb_VideoPath set CursorYN='显示光标' where ID=1";
                }
                else
                {
                    strCursor = "update tb_VideoPath set CursorYN='隐藏光标' where ID=1";
                }
                cmd = new OleDbCommand(strCursor,conn);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    conn.Close();
                    this.Close();
                }
            }
        }
    }
}