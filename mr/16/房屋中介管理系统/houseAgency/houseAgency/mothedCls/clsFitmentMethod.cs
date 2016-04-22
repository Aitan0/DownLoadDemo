using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace houseAgency.mothedCls
{
    class clsFitmentMethod
    {
        ClsCon con = new ClsCon();
        public string insert_table(clsFitment cf)
        {
            try
            {
                con.ConDatabase();
                SqlCommand cmd = new SqlCommand("proc_fitment_insert", con.conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection.Open();
                cmd.Parameters.Add("@house_fitmentID", SqlDbType.VarChar, 50).Value = cf.id;
                cmd.Parameters.Add("@fitment_name", SqlDbType.VarChar, 50).Value = cf.name;
                cmd.Parameters.Add("@fitment_remark", SqlDbType.VarChar, 50).Value = cf.remark;
                SqlParameter sp = new SqlParameter();
                sp.ParameterName="@proc_info";
                sp.Direction = ParameterDirection.Output;
                sp.Size = 20;
                cmd.Parameters.Add(sp);
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

            #region
            //try
            //{
            //    con.ConDatabase();
            //    SqlCommand cmd = new SqlCommand("proc_fitment_insert", con.conn);
            //    cmd.CommandType = CommandType.StoredProcedure;
            //    cmd.Connection.Open();
            //    SqlParameter[] prams =
            //    {
            //            new SqlParameter("@house_fitmentID", SqlDbType.VarChar, 50),
            //            new SqlParameter("@fitment_name",  SqlDbType.VarChar, 50),
            //            new SqlParameter("@fitment_remark",  SqlDbType.VarChar, 50),
            //            new SqlParameter("@proc_info", SqlDbType.VarChar, 50, ParameterDirection.Output,true, 0, 0, string.Empty,DataRowVersion.Default, null)
            //    };
            //    prams[0].Value = cf.id;
            //    prams[1].Value = cf.name;
            //    prams[2].Value = cf.remark;
            //    // 添加参数
            //    foreach (SqlParameter parameter in prams)
            //    {
            //        cmd.Parameters.Add(parameter);
            //    }
            //    cmd.ExecuteNonQuery();
            //    string strResult = cmd.Parameters["@proc_info"].Value.ToString();
            //    con.closeCon();
            //    return strResult;
            //}
            //catch (Exception ey)
            //{
            //    con.closeCon();
            //    return ey.Message.ToString();
            //}
            #endregion
        }


        public bool update_table(clsFitment cf)
        {
            try
            {
                con.ConDatabase();
                SqlCommand cmd = new SqlCommand("proc_fitment_update", con.conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection.Open();
                SqlParameter[] prams =
                {
						new SqlParameter("@house_fitmentID", SqlDbType.VarChar, 50),
                		new SqlParameter("@fitment_name",  SqlDbType.VarChar, 50),
                		new SqlParameter("@fitment_remark",  SqlDbType.VarChar, 50)
                       
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
               
                con.closeCon();
                return true;
            }
            catch
            {
                con.closeCon();
                return false;
            }
        }


        public bool delete_table(clsFitment cf)
        {
            try
            {
                con.ConDatabase();
                SqlCommand cmd = new SqlCommand("proc_fitment_delete", con.conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection.Open();
                SqlParameter[] prams =
                {
						new SqlParameter("@house_fitmentID", SqlDbType.VarChar, 50)
                       
				};
                prams[0].Value = cf.id;
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
