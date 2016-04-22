using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace houseAgency.mothedCls
{
    class clsEmpleeyMethed
    {
        ClsCon con = new ClsCon();
        public bool insert_table(clsEmpleey cf)
        {
            try
            {
                con.ConDatabase();
                SqlCommand cmd = new SqlCommand("proc_employee_insert", con.conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection.Open();
                SqlParameter[] prams =
                {
						new SqlParameter("@employee_ID", SqlDbType.VarChar, 50),
                		new SqlParameter("@employee_name",  SqlDbType.VarChar, 50),
                        new SqlParameter("@employee_sex", SqlDbType.VarChar, 50),
                        new SqlParameter("@employee_birthday", SqlDbType.DateTime),
                		new SqlParameter("@employee_phone",  SqlDbType.VarChar, 50),
                		new SqlParameter("@employee_cardID",  SqlDbType.VarChar, 50),
                        new SqlParameter("@employee_address", SqlDbType.VarChar, 50),
                        new SqlParameter("@gov_id", SqlDbType.VarChar, 50),
                		new SqlParameter("@employee_study",  SqlDbType.VarChar, 50),
                		new SqlParameter("@employee_basepay",  SqlDbType.Float)
                   
				};
                prams[0].Value = cf.eID;
                prams[1].Value = cf.eName;
                prams[2].Value = cf.eSex;
                prams[3].Value = cf.eDay;
                prams[4].Value = cf.ePhone;
                prams[5].Value = cf.eIDCard;
                prams[6].Value = cf.eAddress;
                prams[7].Value = cf.eGID;
                prams[8].Value = cf.eStuID;
                prams[9].Value = cf.EPay;

                // Ìí¼Ó²ÎÊý
                foreach (SqlParameter parameter in prams)
                {
                    cmd.Parameters.Add(parameter);
                }
                cmd.ExecuteNonQuery();
                con.closeCon();
                return true;

            }
            catch
            {
                con.closeCon();
                return false;
            }
        }
    }
}
