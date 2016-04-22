using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;//添加SqlConnection对象的命名空间
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Rendering; //添加决策分析的命名空间

namespace TransferFormality
{
    public partial class MyMain : Form
    {
        public MyMain()
        {
            InitializeComponent();
        }


        #region  数据库连接的变量
        //静态变量DataCom、DataType、DataSele、DataTabN是向调用模块传的参数值
        public string DataCom = "Data Source=mr-nxt\\xt;Database=MR_Distribution;User id=sa;PWD=";//连接数据库的字符串
        public string DataType = "2005";//数据库的类型
        //要查询表的SQL语句
        public string DataSele = "select Give_ID as 编号,Give_Date as 生产月份,Give_Plant as 生产车间,Give_Group as 生产组,Give_Model as 生产型号,Give_Count as 生产数量,DData as 生产日期 from tb_AppearTab";
        public string DataTabN = "tb_AppearTab";//要查询的表名

        public DataSet Fds = new DataSet();
        public MyDLL MDLL = new MyDLL();//实例化调用模块的DLL文件
        #endregion

        #region  数据库的连接

        public static SqlConnection My_con;  //定义一个SqlConnection类型的公共变量My_con，用于判断数据库是否连接成功
        /// <summary>
        /// 建立数据库连接.
        /// </summary>
        /// <returns>返回SqlConnection对象</returns>
        public SqlConnection getcon()
        {
            My_con = new SqlConnection(DataCom);   //用SqlConnection对象与指定的数据库相连接
            My_con.Open();  //打开数据库连接
            return My_con;  //返回SqlConnection对象的信息
        }

        /// <summary>
        /// 关闭于数据库的连接
        /// </summary>
        public int con_close()
        {
            int n = 0;
            if (My_con.State == ConnectionState.Open)   //判断是否打开与数据库的连接
            {
                My_con.Close();   //关闭数据库的连接
                My_con.Dispose();   //释放My_con变量的所有空间
                n = 0;
            }
            else
                n = 1;
            return n;
        }

        /// <summary>
        /// 创建一个DataSet对象
        /// </summary>
        /// <param M_str_sqlstr="string">SQL语句</param>
        /// <param M_str_table="string">表名</param>
        /// <returns>返回DataSet对象</returns>
        public DataSet getDataSet(string SQLstr, string tableName)
        {
            getcon();   //打开与数据库的连接
            SqlDataAdapter SQLda = new SqlDataAdapter(SQLstr, My_con);  //创建一个SqlDataAdapter对象，并获取指定数据表的信息
            DataSet My_DataSet = new DataSet(); //创建DataSet对象
            if (tableName == "")
                SQLda.Fill(My_DataSet);
            else
                SQLda.Fill(My_DataSet, tableName);  //通过SqlDataAdapter对象的的Fill()方法，将数据表信息添加到DataSet对象中
            con_close();    //关闭数据库的连接
            return My_DataSet;  //返回DataSet对象的信息
        }
        #endregion

        private void MyMain_Shown(object sender, EventArgs e)
        {
            Fds = getDataSet(DataSele, DataTabN);
            dataGridView1.DataSource = Fds.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MDLL.SendOut(DataCom, DataType, DataSele, DataTabN, Fds);//向DLL文件中传递参数
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}