using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace houseAgency
{
    public partial class frmStock : Form
    {
        public frmStock()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            beifenInfo();
        }

        public void beifenInfo()
        {
            try
            {
                sd.InitialDirectory = Application.StartupPath + "\\";//默认路径为D：//
                sd.Filter = "备份文件 (*.bak)|*.bak|所有文件 (*.*)|*.*";//筛选器，定义文件类型
                sd.FilterIndex = 1;								//默认值为第一个
                sd.RestoreDirectory = true;						//重新定位保存路径
                if (sd.ShowDialog() == DialogResult.OK)
                {
                    if (!File.Exists(sd.FileName.ToString()))
                    {
                        SqlConnection con = new SqlConnection();		//利用代码实现连接数据库
                        con.ConnectionString = "server=.;uid=sa;pwd=;database=db_showHouse";
                        con.Open();
                        SqlCommand com = new SqlCommand();
                        this.textBox1.Text = sd.FileName.ToString();
                        com.CommandText = "BACKUP DATABASE db_showHouse TO DISK = '" + sd.FileName.ToString() + "'";
                        com.Connection = con;							//连接
                        com.ExecuteNonQuery();						    //执行
                        con.Close();
                        con.Close();
                        con = null;
                        MessageBox.Show("数据备份成功！");
                    }
                    else
                    {
                        MessageBox.Show("请重新命名！");
                    }
                }
            }
            catch (Exception k)
            {
                MessageBox.Show(k.Message);
                return;
            }
        }
    }
}