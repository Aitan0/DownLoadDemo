using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace houseAgency.mothedCls
{
    class clsMoneyAndInfoMethod
    {
        ClsCon con = new ClsCon();
        public bool insert_table(clsMoneyAndInfo cf)
        {
            try
            {
                con.ConDatabase();
                SqlCommand cmd = new SqlCommand("proc_moneyandinfo_insert", con.conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection.Open();
                SqlParameter[] prams =
                {
						new SqlParameter("@moeny_ID", SqlDbType.VarChar, 10),
                		new SqlParameter("@Pay_Moeny",  SqlDbType.Float),
                        new SqlParameter("@emp_ID", SqlDbType.VarChar, 10),
                        new SqlParameter("@emp_name", SqlDbType.VarChar,20),
                		new SqlParameter("@house_ID",  SqlDbType.VarChar, 10),
                		new SqlParameter("@Pay_date",  SqlDbType.VarChar,50),
                        new SqlParameter("@moeny_remark", SqlDbType.VarChar, 100),
                        new SqlParameter("@lend_ID", SqlDbType.VarChar, 10),
                		new SqlParameter("@lend_Name",  SqlDbType.VarChar, 20),
                		new SqlParameter("@lend_Phone",  SqlDbType.VarChar, 20),
                        new SqlParameter("@want_ID", SqlDbType.VarChar, 10),
                		new SqlParameter("@want_Name",  SqlDbType.VarChar, 20),
                		new SqlParameter("@want_Phone",  SqlDbType.VarChar, 20)
                   
				};
                prams[0].Value = cf.MID;
                prams[1].Value = cf.PM;
                prams[2].Value = cf.EID;
                prams[3].Value = cf.EName;
                prams[4].Value = cf.HID;
                prams[5].Value = cf.Pday;
                prams[6].Value = cf.Mark;
                prams[7].Value = cf.LID;
                prams[8].Value = cf.LName;
                prams[9].Value = cf.LPhone;
                prams[10].Value = cf.WID;
                prams[11].Value = cf.WName;
                prams[12].Value = cf.Wphone;
                // Ìí¼Ó²ÎÊý
                foreach (SqlParameter parameter in prams)
                {
                    cmd.Parameters.Add(parameter);
                }
                cmd.ExecuteNonQuery();
                con.closeCon();
                return true;
            }
            catch(Exception ey)
            {
                Console.Write(ey.Message);
                con.closeCon();
                return false;
            }
        }
    }
}
