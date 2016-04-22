using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace Rendering
{
    public class MyDLL
    {
        #region  DLL文件中静态变量的设置
        private static string DataCom1 = "";//设置数据库的连接变量

        public static string DataCom//封装DataCom变量
        {
            get { return MyDLL.DataCom1; }
            set { MyDLL.DataCom1 = value; }
        }
        private static string DataType1 = "";//设置数据库的类型

        public static string DataType
        {
            get { return MyDLL.DataType1; }
            set { MyDLL.DataType1 = value; }
        }
        private static string DataSele1 = "";//设置要查询数据表的SQL语句

        public static string DataSele
        {
            get { return MyDLL.DataSele1; }
            set { MyDLL.DataSele1 = value; }
        }
        private static string DataTabn1 = "";//设置查询数据表的名称

        public static string DataTabn
        {
            get { return MyDLL.DataTabn1; }
            set { MyDLL.DataTabn1 = value; }
        }
        private static DataSet DataSets1 = null;//设置查询数据表的名称

        public static DataSet DataSets
        {
            get { return MyDLL.DataSets1; }
            set { MyDLL.DataSets1 = value; }
        }
        #endregion

        #region  DLL文件中各方法的设置

        /// <summary>
        /// 接收所有传递的参数值
        /// </summary>
        /// <param Dcom="string">连接数据库的字符串</param>
        /// <param Dtype="string">查询数据库的类型</param>
        /// <param Dsele="string">查询数据表的SQL语句</param>
        /// <param Dtabn="string">查询数据表的名称</param>
        public void SendOut(string Dcom, string Dtype, string Dsele, string Dtabn, DataSet Dset)
        {
            DataCom = Dcom;//获取连接数据库的字符串
            DataType = Dtype;//获取查询数据库的类型
            DataSele = Dsele;//获取查询数据表的SQL语句
            DataTabn = Dtabn;//获取查询数据表的名称
            DataSets = Dset;//获取DataSet对象中的信息
            Frm_Stat FrmStat = new Frm_Stat();//实例化查询窗体
            FrmStat.ShowDialog();//显示查询窗体
        }
        #endregion
    }
}
