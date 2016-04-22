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
    public partial class frmRestore : Form
    {
        public frmRestore()
        {
            InitializeComponent();
        }

        private void frmRestore_Load(object sender, EventArgs e)
        {

        }

        #region//调用方法
        private void button1_Click(object sender, EventArgs e)
        {
            Restore();
        }
        #endregion

       
        public void Restore()
        {
            try
            {
                ofd.InitialDirectory = Application.StartupPath + "\\";
                ofd.Filter = "(*.bak)|*.bak|(所有文件)|*.*";
                ofd.FilterIndex = 1;
                ofd.RestoreDirectory = true;
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    textBox1.Text = ofd.FileName.ToString();

                    #region//
                    if (this.RestoreBase(".", "sa", "", "db_showHouse", ofd.FileName.ToString()) == true)
                    {
                        MessageBox.Show("还原成功！", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        ClsCon con = new ClsCon();
                        con.ConDatabase();
                        con.conn.Open();
                    }
                    else
                    {
                        //MessageBox.Show("Error");
                        this.button1.PerformClick();
                    }
                    #endregion
                }
            }
            catch (Exception ey)
            {
                MessageBox.Show(ey.Message);
            }
        }

        #region//
        private bool RestoreBase(string serverName, string uID, string pWD, string dataBase, string bakPath)
        {	//定义了五个变量是为了让以后可以动态的使用(第一个是服务器名,用户名,密码,数据库,还有还原文件的路径)
            SqlConnection RestoreCon = new SqlConnection("server=" + serverName + ";uid=" + uID + ";pwd=" + pWD + ";database=master");
            SqlCommand RestoreCmd = new SqlCommand("killspid", RestoreCon);						//调用存储过程
            RestoreCmd.CommandType = CommandType.StoredProcedure;								//这个存储过程是为了关闭所有打开的库
            RestoreCmd.Parameters.Add("@dbname",SqlDbType.VarChar,50);
            RestoreCmd.Parameters["@dbname"].Value ="'"+dataBase+"'";
            try
            {
                RestoreCon.Open();
                RestoreCmd.ExecuteNonQuery();
                SqlCommand RestoreCmd1 = new SqlCommand();
                RestoreCmd1.CommandText = "RESTORE DATABASE " + dataBase + " FROM DISK='" + bakPath + "'";
                RestoreCmd1.Connection = RestoreCon;
                RestoreCmd1.ExecuteNonQuery();
                RestoreCon.Close();
                return true;
            }
            catch(Exception ey)
            {
                MessageBox.Show(ey.Message);
                RestoreCon.Close();
                return false;
            }
        }
        #endregion
    }
}