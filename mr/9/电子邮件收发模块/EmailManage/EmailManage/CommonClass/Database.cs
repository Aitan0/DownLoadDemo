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
        private static string strname = "";   //��¼��¼�û�������
        /// <summary>
        /// �û�������ʵ��
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
        /// �������ݿ�
        /// </summary>
        /// <returns>����SqlConnection����</returns>
        public SqlConnection getCon()
        {
            string strDataSource = "Data Source=mr-nxt\\xt;Database=db_EmailManage;Uid=sa;Pwd=;";
            sqlcon = new SqlConnection(strDataSource);
            return sqlcon;
        }
        /// <summary>
        /// ִ��SQL���
        /// </summary>
        /// <param name="strCon">SQL���</param>
        public void getCom(string strCon)
        {
            sqlcon = getCon();
            sqlcom = new SqlCommand(strCon, sqlcon);
            sqlcon.Open();
            sqlcom.ExecuteNonQuery();
            sqlcon.Close();
        }
        /// <summary>
        /// ����DataSet���ݼ�
        /// </summary>
        /// <param name="strCon">SQL���</param>
        /// <param name="tbname">���ݱ���</param>
        /// <returns>����DataSet���ݼ�</returns>
        public DataSet getDs(string strCon, string tbname)
        {
            sqlcon = getCon();
            sqlda = new SqlDataAdapter(strCon, sqlcon);
            ds = new DataSet();
            sqlda.Fill(ds, tbname);
            return ds;
        }

        #region  ��֤����ΪEmail
        /// <summary>
        /// ��֤����ΪEmail
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
