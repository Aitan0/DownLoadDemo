using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace EmailManage.CommonClass
{
    class Database
    {
        private static string strname = "";   //记录登录用户或邮箱
        /// <summary>
        /// 用户或邮箱实体
        /// </summary>
        public static string StrName
        {
            get
            {
                return strname;
            }
            set
            {
                strname = value;
            }
        }
        SqlConnection sqlcon;
        SqlCommand sqlcom;
        SqlDataAdapter sqlda;
        DataSet ds;
        /// <summary>
        /// 连接数据库
        /// </summary>
        /// <returns>返回SqlConnection类型</returns>
        public SqlConnection getCon()
        {
            string strDataSource = "Data Source=mr-nxt\\xt;Database=db_EmailManage;Uid=sa;Pwd=;";
            sqlcon = new SqlConnection(strDataSource);
            return sqlcon;
        }
        /// <summary>
        /// 执行SQL语句
        /// </summary>
        /// <param name="strCon">SQL语句</param>
        public void getCom(string strCon)
        {
            sqlcon = getCon();
            sqlcom = new SqlCommand(strCon, sqlcon);
            sqlcon.Open();
            sqlcom.ExecuteNonQuery();
            sqlcon.Close();
        }
        /// <summary>
        /// 生成DataSet数据集
        /// </summary>
        /// <param name="strCon">SQL语句</param>
        /// <param name="tbname">数据表名</param>
        /// <returns>返回DataSet数据集</returns>
        public DataSet getDs(string strCon, string tbname)
        {
            sqlcon = getCon();
            sqlda = new SqlDataAdapter(strCon, sqlcon);
            ds = new DataSet();
            sqlda.Fill(ds, tbname);
            return ds;
        }

        #region  验证输入为Email
        /// <summary>
        /// 验证输入为Email
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public bool validateEmail(string str)
        {
            return Regex.IsMatch(str, @"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");
        }
        #endregion
    }
}
