using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;

namespace 进销存管理系统
{
    class DataBase
    {
        SqlConnection con = new SqlConnection();
        
        private void Open()
        {
            if(con==null)
            {
                con=new SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\\Users\\aliu2197\\Documents\\db_EMS.mdf;Integrated Security=True;Connect Timeout=30");

            }
            if(con.State==System.Data.ConnectionState.Closed)
                con.Open();
        }
        private void Close()
        {
            if(con!=null)
con.Close();
            
        }
       
    }
}
