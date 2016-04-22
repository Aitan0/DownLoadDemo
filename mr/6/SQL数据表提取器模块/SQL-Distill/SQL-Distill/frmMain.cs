using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;
namespace SQL_Distill
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        public string strDataName = "";
        public string strUser = "";
        public string strPwd = "";
        public string strServerName = "";
        frmBackup bu = new frmBackup();
        frmRevert rt = new frmRevert();
        frmAppend ad = new frmAppend();
        #region  主窗体加载
        private void frmMain_Load(object sender, EventArgs e)
        {
            //加载所有的服务器名称
            getSQLServer();
            cbbSqlServerName.SelectedIndex = 0;

        }
        #endregion
        #region  检索网络中的服务器并将其添加到ComboBox
        private void getSQLServer()
        {
            SQLDMO.Application SQLServer = new SQLDMO.Application();
            SQLDMO.NameList strServerList = SQLServer.ListAvailableSQLServers();
            
            if (strServerList.Count > 0)
            {
                for (int i = 0; i < strServerList.Count; i++)
                {
                    cbbSqlServerName.Items.Add(strServerList.Item(i+1));
                }
            }
        }
        #endregion
        #region  登录
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                    cbbSqlData.Items.Clear();
                    SqlConnection conn = new SqlConnection("Server=" + cbbSqlServerName.Text.Trim() + ";DataBase=master;uid=" + txtSqlName.Text.Trim() + ";pwd=" + txtSqlPwd.Text.Trim());
                    conn.Open();
                    bu.strserver = cbbSqlServerName.Text.Trim();
                    rt.strserver = cbbSqlServerName.Text.Trim();
                    ad.strserver = cbbSqlServerName.Text.Trim();
                    if (conn.State == ConnectionState.Open)
                    {
                        //状态
                        tsslStatus.Text = "连接成功！";
                        //获取服务器中数据库信息
                        SqlCommand cmd = new SqlCommand("sp_helpdb", conn);
                        SqlDataReader sdr = cmd.ExecuteReader();
                        while (sdr.Read())
                        {
                            if (sdr[0].ToString() == "master" || sdr[0].ToString() == "model" || sdr[0].ToString() == "msdb" || sdr[0].ToString() == "Northwind" || sdr[0].ToString() == "pubs" || sdr[0].ToString() == "tempdb")
                            { }
                            else
                            {
                                cbbSqlData.Items.Add(sdr[0].ToString());
                            }
                        }
                        cbbSqlData.SelectedIndex = 0;
                        strUser = txtSqlName.Text.Trim();
                        strPwd = txtSqlPwd.Text.Trim();
                        strServerName = cbbSqlServerName.Text.Trim();
                        cbbDataTable.SelectedIndex = 0;
                        sdr.Close();
                        conn.Close();

                    }
                    else if (conn.State == ConnectionState.Closed)
                    {
                        conn.Close();
                    }
            }
            catch
            {
                button1_Click(sender, e);
            }
        }
        #endregion
        #region  获取数据表
        private void cbbSqlData_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection DBcon = new SqlConnection("Server=" + cbbSqlServerName.Text.Trim() + ";DataBase=" + cbbSqlData.Text.Trim() + ";uid=" + txtSqlName.Text.Trim() + ";pwd=" + txtSqlPwd.Text.Trim());
            strDataName = cbbSqlData.Text.Trim();
            listBox1.DataSource = null;
            listBox1.Items.Clear();
            SqlDataAdapter da = new SqlDataAdapter("SELECT name FROM sysobjects WHERE type = 'U' and name<>'dtproperties'", DBcon);
            DataTable dt = new DataTable("sysobjects");
            da.Fill(dt);
            listBox1.DataSource = dt.DefaultView;
            listBox1.DisplayMember = "name";
            listBox1.ValueMember = "name";
        }
        #endregion
        #region  显示表结构
        private void listBox1_Click(object sender, EventArgs e)
        {
            try
            {
                string strTableName = listBox1.SelectedValue.ToString();
                using (SqlConnection con = new SqlConnection("Server=" + strServerName + ";database=" + strDataName + ";Uid=" + strUser + ";Pwd=" + strPwd))
                {

                    //SqlCommand com = new SqlCommand();
                    //com.Connection = con;
                    //com.CommandText = "select name from sysobjects where  name='hy_linshibiao'";
                    //int i = com.ExecuteNonQuery();
                    //com.CommandText = "select name from sysobjects where name='angel_linshibiao'";
                    //int j = com.ExecuteNonQuery();
                    //if (i == 1)
                    //{
                    //    com.CommandText = "drop table hy_Linshibiao";
                    //    com.ExecuteNonQuery();
                    //}
                    //if (j == 1)
                    //{
                    //    com.CommandText = "drop table angel_linshibiao";
                    //    com.ExecuteNonQuery();
                    //}


                    string strSql = "select  name 字段名, xusertype 类型编号, length 长度 into hy_Linshibiao from  syscolumns  where id=object_id('" + strTableName + "') ";
                    strSql += "select name 类型,xusertype 类型编号 into angel_Linshibiao from systypes where xusertype in (select xusertype from syscolumns where id=object_id('" + strTableName + "'))";
                    con.Open();
                    SqlCommand cmd = new SqlCommand(strSql, con);
                    cmd.ExecuteNonQuery();
                    SqlDataAdapter da = new SqlDataAdapter("select 字段名,类型,长度 from hy_Linshibiao t,angel_Linshibiao b where t.类型编号=b.类型编号", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    this.dataGridView1.DataSource = dt.DefaultView;
                    SqlCommand cmdnew = new SqlCommand("drop table hy_Linshibiao,angel_Linshibiao", con);
                    cmdnew.ExecuteNonQuery();
                    con.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        #endregion
        #region  按提取信息显示
        private void cbbDataTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbDataTable.Text.Trim() == "视图")
            {
                using (SqlConnection con = new SqlConnection("Server=" + strServerName + ";database=" + strDataName + ";Uid=" + strUser + ";Pwd=" + strPwd))
                {
                    SqlDataAdapter da = new SqlDataAdapter("select name from sysobjects where xtype='v'", con);
                    DataTable dt = new DataTable("sysobjects");
                    da.Fill(dt);
                    listBox1.DataSource = dt.DefaultView;
                    listBox1.DisplayMember = "name";
                    listBox1.ValueMember = "name";
                }

            }
            if (cbbDataTable.Text.Trim() == "数据表")
            {
                strDataName = cbbSqlData.Text.Trim();
                listBox1.DataSource = null;
                listBox1.Items.Clear();
                SqlConnection conn = new SqlConnection("Server=" + cbbSqlServerName.Text.Trim() + ";DataBase=" + cbbSqlData.Text.Trim() + ";uid=" + txtSqlName.Text.Trim() + ";pwd=" + txtSqlPwd.Text.Trim());
                SqlDataAdapter da = new SqlDataAdapter("SELECT name FROM sysobjects WHERE type = 'U' and name<>'dtproperties' ", conn);
                DataTable dt = new DataTable("sysobjects");
                da.Fill(dt);
                listBox1.DataSource = dt.DefaultView;
                listBox1.DisplayMember = "name";
            }
            if (cbbDataTable.Text.Trim() == "存储过程")
            {
                strDataName = cbbSqlData.Text.Trim();
                listBox1.DataSource = null;
                listBox1.Items.Clear();
                using (SqlConnection conn = new SqlConnection("Server=" + cbbSqlServerName.Text.Trim() + ";DataBase=" + cbbSqlData.Text.Trim() + ";uid=" + txtSqlName.Text.Trim() + ";pwd=" + txtSqlPwd.Text.Trim()))
                {
                    SqlDataAdapter da = new SqlDataAdapter("SELECT name FROM sysobjects WHERE xtype='p'", conn);
                    DataTable dt = new DataTable("sysobjects");
                    da.Fill(dt);
                    listBox1.DataSource = dt.DefaultView;
                    listBox1.DisplayMember = "name";
                    listBox1.ValueMember = "name";
                }
            }
        }
        #endregion
        #region  退出系统
        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion
        #region  调用备份
        private void toolStripButton1_Click(object sender, EventArgs e)//备份数据库
        {
            if (strServerName== "")
            {
                MessageBox.Show("注意：您还未登录！","警告",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            else
            {
                frmBackup backup = new frmBackup();
                backup.strserver = strServerName;
                backup.struser = strUser;
                backup.strpwd = strPwd;
                backup.ShowDialog();
            }
        }
        #endregion
        #region  调用还原
        private void toolStripButton2_Click(object sender, EventArgs e)//还原数据库
        {
            if (strServerName == "")
            {
                MessageBox.Show("注意：您还未登录！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                frmRevert revert = new frmRevert();
                revert.strserver = strServerName;
                revert.struser = strUser;
                revert.strpwd = strPwd;
                revert.ShowDialog();
            }
        }
        #endregion
        #region  调用附加
        private void toolStripButton3_Click(object sender, EventArgs e)//附加数据库
        {
            if (strServerName == "")
            {
                MessageBox.Show("注意：您还未登录！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                frmAppend append = new frmAppend();
                append.strserver = strServerName;
                append.struser = strUser;
                append.strpwd = strPwd;
                append.ShowDialog();
            }
        }
        #endregion
        #region  分离
        private void toolStripButton4_Click(object sender, EventArgs e)//分离数据库
        {
            if (strServerName == "")
            {
                MessageBox.Show("注意：您还未登录！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (MessageBox.Show("注意：确定要分离数据库" + cbbSqlData.Text.Trim() + "吗？", "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
                {
                    using (SqlConnection con = new SqlConnection("server="+cbbSqlServerName.Text.Trim().ToString ()+";pwd=" + strPwd + ";uid=" + strUser + ";database=master"))
                    {
                        try
                        {
                            con.Open();
                            string sql = "exec sp_detach_db @dbname='" + cbbSqlData.Text.Trim() + "'";
                            string single = "alter database "+cbbSqlData.Text.Trim()+" set single_user with rollback immediate " + sql;
                            SqlCommand cmd = new SqlCommand();
                            cmd.Connection = con;
                            cmd.CommandText = single;
                            cmd.ExecuteNonQuery();
                            con.Close();
                            MessageBox.Show("提示：分离成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            button1_Click(sender, e);
                        }
                        catch (Exception ey)
                        {
                            MessageBox.Show(ey.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                }
                else
                { }
            }
        }
        #endregion
        #region 导出数据
        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            if (strServerName == "")
            {
                MessageBox.Show("注意：您还未登录！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (listBox1.SelectedItems.Count == 0)
                {
                    MessageBox.Show("注意：您还没有选择数据表！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    frmOutData outdata = new frmOutData();
                    outdata.OutData = cbbSqlData.Text.Trim();
                    outdata.OutTable = listBox1.SelectedValue.ToString();
                    outdata.strserver = strServerName;
                    outdata.struser = strUser;
                    outdata.strpwd = strPwd;
                    outdata.ShowDialog();
                }
            }
        }
        #endregion
        #region  导出表结构
        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            if (strServerName == "")
            {
                MessageBox.Show("注意：您还未登录！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (listBox1.SelectedItems.Count == 0)
                {
                    MessageBox.Show("注意：您还没有选择数据表！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    frmDataExport dataexport = new frmDataExport();
                    dataexport.OutData = cbbSqlData.Text.Trim();
                    dataexport.OutTable = listBox1.SelectedValue.ToString();
                    dataexport.strserver = strServerName;
                    dataexport.struser = strUser;
                    dataexport.strpwd = strPwd;
                    dataexport.ShowDialog();
                }
            }
        }
        #endregion
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}