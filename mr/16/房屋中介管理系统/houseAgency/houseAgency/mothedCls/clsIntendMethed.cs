using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace houseAgency.mothedCls
{
    class clsIntendMethed
    {
        ClsCon con = new ClsCon();
        public DataTable insert_table(clsIntend cf)
        {
            try
            {
                con.ConDatabase();
                SqlDataAdapter da = new SqlDataAdapter("proc_intent_insert", con.conn);
                da.SelectCommand.CommandType= CommandType.StoredProcedure;
                SqlParameter[] prams =
                {
						new SqlParameter("@intend_ID", SqlDbType.VarChar, 50),
                		new SqlParameter("@user_id",  SqlDbType.VarChar, 50),
                		new SqlParameter("@huose_typeID",  SqlDbType.VarChar, 50),
                        new SqlParameter("@house_seatID", SqlDbType.VarChar, 50),
                		new SqlParameter("@house_fitmentID",  SqlDbType.VarChar, 50),
                		new SqlParameter("@house_floorID",  SqlDbType.VarChar, 50),
                        new SqlParameter("@house_favorID", SqlDbType.VarChar, 50),
                		new SqlParameter("@house_mothedID",  SqlDbType.VarChar, 50),
                		new SqlParameter("@house_price",  SqlDbType.Float),
                        new SqlParameter("@house_area",  SqlDbType.VarChar, 50),
				};
                prams[0].Value = cf.tend_id;
                prams[1].Value = cf.u_id;
                prams[2].Value = cf.ty_id;
                prams[3].Value = cf.se_ID;
                prams[4].Value = cf.fi_ID;
                prams[5].Value = cf.fl_ID;
                prams[6].Value = cf.fa_ID;
                prams[7].Value = cf.mo_ID;
                prams[8].Value = cf.price;
                prams[9].Value = cf.area;

                // Ìí¼Ó²ÎÊý
                foreach (SqlParameter parameter in prams)
                {
                    da.SelectCommand.Parameters.Add(parameter);
                }
                DataTable dt = new DataTable();
                da.Fill(dt);
                con.closeCon();
                return dt;
            }
            catch
            {
                con.closeCon();
                return null;
            }
        }
    }
}
