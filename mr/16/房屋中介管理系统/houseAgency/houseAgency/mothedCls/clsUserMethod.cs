using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace houseAgency.mothedCls
{
    class clsUserMethod
    {
        ClsCon con = new ClsCon();
        public bool insert_table(clsUser cf)
        {
            try
            {
                con.ConDatabase();
                SqlCommand cmd = new SqlCommand("proc_User_insert", con.conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection.Open();
                SqlParameter[] prams =
                {
						new SqlParameter("@User_IDS", SqlDbType.VarChar, 50),
                		new SqlParameter("@User_names",  SqlDbType.VarChar, 50),
                        new SqlParameter("@User_sex", SqlDbType.VarChar, 50),
                        new SqlParameter("@User_birth", SqlDbType.DateTime),
                		new SqlParameter("@User_phone",  SqlDbType.VarChar, 50),
                		new SqlParameter("@User_homePhone",  SqlDbType.VarChar, 50),
                        new SqlParameter("@User_email", SqlDbType.VarChar, 50),
                        new SqlParameter("@User_cardID", SqlDbType.VarChar, 50),
                		new SqlParameter("@User_type",  SqlDbType.VarChar, 50),
                		new SqlParameter("@house_ID",  SqlDbType.VarChar, 50),
                        new SqlParameter("@User_recordDate", SqlDbType.DateTime)
				};
                prams[0].Value = cf.id;
                prams[1].Value = cf.name;
                prams[2].Value = cf.sex;
                prams[3].Value = cf.birth;
                prams[4].Value = cf.phone;
                prams[5].Value = cf.homePhone;
                prams[6].Value = cf.email;
                prams[7].Value = cf.cardID;
                prams[8].Value = cf.type;
                prams[9].Value = cf.hID;
                prams[10].Value = cf.recordDate;
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
