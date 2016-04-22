using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace houseAgency.mothedCls
{
    class ClsCon
    {
        public SqlConnection conn;
        /// <summary>
        /// Connection method
        /// </summary>
        public void ConDatabase()
        {
          //  conn = new SqlConnection("server=.;pwd=;uid=sa;database=db_showHouse_Data");
           //  conn = new SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=@"C:\Users\aliu2197\Documents\Visual Studio 2013\Projects\mr\16\房屋中介管理系统\houseAgency\houseAgency\Database\db_showHouse_Data.MDF";Integrated Security=True;Connect Timeout=30");
        }
        /// <summary>
        /// close Connection method
        /// </summary>
        /// <returns></returns>
        public bool closeCon()
        {
            try
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                    
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
