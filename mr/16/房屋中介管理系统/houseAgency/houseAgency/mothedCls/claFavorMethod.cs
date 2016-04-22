using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace houseAgency.mothedCls
{
    class claFavorMethod
    {
        ClsCon con = new ClsCon();
        public string insert_table(clsFavor cf)
        {
            try
            {
                con.ConDatabase();
                SqlCommand cmd = new SqlCommand("proc_favor_insert", con.conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection.Open();
                SqlParameter[] prams =
                {
						new SqlParameter("@house_favorID", SqlDbType.VarChar, 50),
                		new SqlParameter("@favor_name",  SqlDbType.VarChar, 50),
                		new SqlParameter("@favor_remark",  SqlDbType.VarChar, 50),
                        new SqlParameter("@proc_info", SqlDbType.VarChar, 50, ParameterDirection.Output,true, 0, 0, string.Empty,DataRowVersion.Default, null)
				
                };
                prams[0].Value = cf.id;
                prams[1].Value = cf.name;
                prams[2].Value = cf.remark;
                // 添加参数
                foreach (SqlParameter parameter in prams)
                {
                    cmd.Parameters.Add(parameter);
                }
                cmd.ExecuteNonQuery();
                string strResult=cmd.Parameters["@proc_info"].Value.ToString(); 
                con.closeCon();
                return strResult;
            }
            catch (Exception ey)
            {
                con.closeCon();
                return ey.Message.ToString();
            }
        }


        public string update_table(clsFavor cf)
        {
            try
            {
                con.ConDatabase();
                SqlCommand cmd = new SqlCommand("proc_favor_update", con.conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection.Open();
                SqlParameter[] prams =
                {
						new SqlParameter("@house_favorID", SqlDbType.VarChar, 50),
                		new SqlParameter("@favor_name",  SqlDbType.VarChar, 50),
                		new SqlParameter("@favor_remark",  SqlDbType.VarChar, 50),
                        new SqlParameter("@proc_info", SqlDbType.VarChar, 50, ParameterDirection.Output,true, 0, 0, string.Empty,DataRowVersion.Default, null)
				};
                prams[0].Value = cf.id;
                prams[1].Value = cf.name;
                prams[2].Value = cf.remark;
                // 添加参数
                foreach (SqlParameter parameter in prams)
                {
                    cmd.Parameters.Add(parameter);
                }
                cmd.ExecuteNonQuery();
                string strResult = cmd.Parameters["@proc_info"].Value.ToString();
                con.closeCon();
                return strResult;
            }
            catch (Exception ey)
            {
                con.closeCon();
                return ey.Message.ToString();
            }
        }


        public string delete_table(clsFavor cf)
        {
            try
            {
                con.ConDatabase();
                SqlCommand cmd = new SqlCommand("proc_favor_delete", con.conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection.Open();
                SqlParameter[] prams =
                {
						new SqlParameter("@house_favorID", SqlDbType.VarChar, 50),
                        new SqlParameter("@proc_info", SqlDbType.VarChar, 50, ParameterDirection.Output,true, 0, 0, string.Empty,DataRowVersion.Default, null)
				};
                prams[0].Value = cf.id;
                // 添加参数
                foreach (SqlParameter parameter in prams)
                {
                    cmd.Parameters.Add(parameter);
                }
                cmd.ExecuteNonQuery();
                string strResult = cmd.Parameters["@proc_info"].Value.ToString();
                con.closeCon();
                return strResult;
            }
            catch (Exception ey)
            {
                return ey.Message.ToString();
            }
        }
    }
}
