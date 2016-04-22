using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace SMS.BaseClass
{
    
    class ConnClass
    {
        #region 连接Access数据库
        /// <summary>
        /// 连接Access数据库
        /// </summary>
        /// <returns></returns>
        public static OleDbConnection DataConn()
        {
            string strg = Application.StartupPath.ToString();
            strg = strg.Substring(0, strg.LastIndexOf("\\"));
            strg = strg.Substring(0, strg.LastIndexOf("\\"));
            strg += @"\DataBase";
            strg += @"\db_SMS.mdb";
            return new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + strg);
        }
        #endregion

        #region 执行SQL语句
        /// <summary>
        /// 执行SQL语句
        /// </summary>
        /// <param name="strSql">SQL语句</param>
        public void getCmd(string strSql)
        {
            OleDbConnection conn = DataConn();
            conn.Open();
            OleDbCommand cmd = new OleDbCommand(strSql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        #endregion

        #region 生成DataSet数据集
        /// <summary>
        /// 生成DataSet数据集
        /// </summary>
        /// <param name="strSql">SQL语句</param>
        /// <returns>DataSet数据集</returns>
        public DataSet geDs(string strSql)
        {
            OleDbConnection conn = DataConn();
            OleDbDataAdapter oda = new OleDbDataAdapter(strSql, conn);
            DataSet ds = new DataSet();
            oda.Fill(ds);
            return ds;
        }
        #endregion
    }
}
