using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace SQL_Test
{
    class SqlHelp
    {
        public bool CntState = false;
        public SqlConnection SqlCnt = new SqlConnection();
        public SqlCommand SqlCmd = new SqlCommand();
        public SqlDataReader SqlRd;
        public string  SQL_connection()
        {
            string SqlCntStr = "Data Source=a-kgesm02.svae.visteon.com;Initial Catalog=Labview;Persist Security Info=True;User ID=labview;Password=Labview";
            //Data Source=a-kgesm02.svae.visteon.com;Initial Catalog=Labview;Persist Security Info=True;User ID=labview
            SqlCnt.ConnectionString = SqlCntStr;
            try
            {
                SqlCnt.Open();
                CntState = true;
                return "";
            }
            catch(Exception ex)
            {
                CntState = false;
                return ex.Message;
            }
        }
        public void InitSql()
        {
            if (CntState)
            {
                SqlCmd.Connection = SqlCnt;
                SqlCmd.CommandType = CommandType.Text;
                //SqlRd = SqlCmd.ExecuteReader();
            }

        }
        public string ExecuteCmd(string cmd)
        {
            try
            {
                SqlCmd.CommandText = cmd;
                SqlCmd.ExecuteNonQuery();
                SqlCnt.Close();
                return "success";

            }
            catch(Exception ex)
            {
                SqlCnt.Close();
                return ex.Message;
            }

         

        }

    }
}
