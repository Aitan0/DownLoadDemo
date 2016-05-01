using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SQL_Test;



namespace SQL_Test
{
    public partial class SQLTestMain : Form
    {
        private SqlHelp SqlPF = new SqlHelp();
       
        public SQLTestMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.textBox1.Text=SqlPF.SQL_connection()+"\r\n";
            SqlPF.InitSql();
          //  SqlPF.CntState = true;

            this.textBox1.Text += SqlPF.ExecuteCmd("CREATE TABLE [dbo].[SX5_FVT]( [ID] INT NOT NULL  PRIMARY KEY,[FGSN] TEXT NOT NULL, [PCBA] TEXT NOT NULL,[WIFI MAC] TEXT NULL,[BT MAC] NCHAR(10) NULL,[DATE] DATE NULL,[TIME] TIME NULL,[STATE] BIT NULL,[STATUS] TEXT NULL)");
        }

        private void SQLTestMain_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“labviewDataSet2.SX5_FVT”中。您可以根据需要移动或删除它。
            this.sX5_FVTTableAdapter.Fill(this.labviewDataSet2.SX5_FVT);
            this.dataGridView1.DataSource = labviewDataSet;
        }
    }
}
