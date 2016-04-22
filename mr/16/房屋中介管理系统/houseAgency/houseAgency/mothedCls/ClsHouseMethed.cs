using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace houseAgency.mothedCls
{
    class ClsHouseMethed
    {
        ClsCon con = new ClsCon();
        public DataTable insert_table(ClsHouse cf)
        {
            try
            {
                con.ConDatabase();
                SqlDataAdapter da = new SqlDataAdapter("proc_house_insert", con.conn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter[] prams =
                {
						new SqlParameter("@house_ID", SqlDbType.VarChar, 10),
                		new SqlParameter("@house_companyName",  SqlDbType.VarChar, 50),
                		new SqlParameter("@huose_typeID",  SqlDbType.VarChar, 10),

                        new SqlParameter("@house_seatID", SqlDbType.VarChar, 10),
                		new SqlParameter("@house_state",  SqlDbType.VarChar, 50),
                		new SqlParameter("@house_fitmentID",  SqlDbType.VarChar, 10),

                        new SqlParameter("@house_favorID", SqlDbType.VarChar, 10),
                		new SqlParameter("@house_mothedID",  SqlDbType.VarChar, 10),
                		new SqlParameter("@huose_map",  SqlDbType.VarChar, 10),

                        new SqlParameter("@house_price", SqlDbType.Float),
                		new SqlParameter("@house_floorID",  SqlDbType.VarChar, 10),
                		new SqlParameter("@house_buildYear",  SqlDbType.Int),

                         new SqlParameter("@house_area", SqlDbType.VarChar, 20),
                		new SqlParameter("@house_remark",  SqlDbType.VarChar, 50),
                        new SqlParameter("@user_ids",  SqlDbType.VarChar, 10)
                       

				};
                prams[0].Value = cf.id;
                prams[1].Value = cf.name;
                prams[2].Value = cf.typeID;

                prams[3].Value = cf.seatID;
                prams[4].Value = cf.state;
                prams[5].Value = cf.fitmentID;
 
                prams[6].Value = cf.favorID;
                prams[7].Value = cf.mothedID;
                prams[8].Value = cf.map;

                prams[9].Value = cf.price;
                prams[10].Value = cf.floorID;
                prams[11].Value = cf.buildYear;

                prams[12].Value = cf.area;
                prams[13].Value = cf.remark;
                prams[14].Value = cf.urids;
                // 添加参数
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


        public bool update_table(ClsHouse cf)
        {
            try
            {
                con.ConDatabase();
                SqlCommand cmd = new SqlCommand("proc_house_update", con.conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection.Open();
                SqlParameter[] prams =
                {
						new SqlParameter("@house_ID", SqlDbType.VarChar, 10),
                		new SqlParameter("@house_companyName",  SqlDbType.VarChar, 50),
                		new SqlParameter("@huose_typeID",  SqlDbType.VarChar, 10),

                        new SqlParameter("@house_seatID", SqlDbType.VarChar, 10),
                		new SqlParameter("@house_fitmentID",  SqlDbType.VarChar, 10),
                        new SqlParameter("@house_favorID", SqlDbType.VarChar, 10),
                		
                        new SqlParameter("@house_mothedID",  SqlDbType.VarChar, 10),
                		new SqlParameter("@huose_map",  SqlDbType.VarChar, 10),
                        new SqlParameter("@house_price", SqlDbType.Float),
                		
                        new SqlParameter("@house_floorID",  SqlDbType.VarChar, 10),
                		new SqlParameter("@house_buildYear",  SqlDbType.Int),
                        new SqlParameter("@house_area", SqlDbType.VarChar, 20),
                		
                        new SqlParameter("@house_remark",  SqlDbType.VarChar, 50)

				};
                prams[0].Value = cf.id;
                prams[1].Value = cf.name;
                prams[2].Value = cf.typeID;

                prams[3].Value = cf.seatID;
                prams[4].Value = cf.fitmentID;

                prams[5].Value = cf.favorID;
                prams[6].Value = cf.mothedID;
                prams[7].Value = cf.map;

                prams[8].Value = cf.price;
                prams[9].Value = cf.floorID;
                prams[10].Value = cf.buildYear;

                prams[11].Value = cf.area;
                prams[12].Value = cf.remark;
               
                // 添加参数
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
