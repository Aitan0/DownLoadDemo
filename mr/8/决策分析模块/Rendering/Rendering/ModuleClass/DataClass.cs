using System;
using System.Collections.Generic;
using System.Data;//添加DataSet对象的命名空间
using System.Data.SqlClient;//添加SqlConnection对象的命名空间
using System.Text;

namespace Rendering.ModuleClass
{
    class DataClass
    {
        #region  自定义变量
        public static SqlConnection My_con;  //定义一个SqlConnection类型的公共变量My_con，用于判断数据库是否连接成功
        public static string M_str_sqlcon = "";
        public static string OldSQL = "";
        #endregion

        #region  建立数据库连接
        /// <summary>
        /// 建立数据库连接.
        /// </summary>
        /// <returns>返回SqlConnection对象</returns>
        public SqlConnection getcon()
        {
            My_con = new SqlConnection(M_str_sqlcon);   //用SqlConnection对象与指定的数据库相连接
            My_con.Open();  //打开数据库连接
            return My_con;  //返回SqlConnection对象的信息
        }
        #endregion

        #region  关闭数据库连接
        /// <summary>
        /// 关闭于数据库的连接
        /// </summary>
        public int con_close()
        {
            int n = 0;
            if (My_con.State == ConnectionState.Open)   //判断是否打开与数据库的连接
            {
                My_con.Close();   //关闭数据库的连接
                My_con.Dispose();   //释放My_con变量的所有空间
                n = 0;
            }
            else
                n = 1;
            return n;
        }
        #endregion

        #region  读取指定表中的信息
        /// <summary>
        /// 读取指定表中的信息.
        /// </summary>
        /// <param SQLstr="string">SQL语句</param>
        /// <returns>返回SqlDataReader对象</returns>
        public void getcom(string SQLstr)
        {
            getcon();   //打开与数据库的连接
            SqlCommand My_com = My_con.CreateCommand(); //创建一个SqlCommand对象，用于执行SQL语句
            My_com.CommandText = SQLstr;    //获取指定的SQL语句
            SqlDataReader My_read = My_com.ExecuteReader(); //执行SQL语名句，生成一个SqlDataReader对象
        }
        #endregion

        #region  执行SQL语句
        /// <summary>
        /// 执行SQL语句
        /// </summary>
        /// <param M_str_sqlstr="string">SQL语句</param>
        /// <param M_str_table="string">表名</param>
        /// <returns>返回DataSet对象</returns>
        public DataSet getDataSet(string SQLstr, string tableName)
        {
            getcon();   //打开与数据库的连接
            SqlDataAdapter SQLda = new SqlDataAdapter(SQLstr, My_con);  //创建一个SqlDataAdapter对象，并获取指定数据表的信息
            DataSet My_DataSet = new DataSet(); //创建DataSet对象
            if (tableName == "")
                SQLda.Fill(My_DataSet);
            else
                SQLda.Fill(My_DataSet, tableName);  //通过SqlDataAdapter对象的的Fill()方法，将数据表信息添加到DataSet对象中
            con_close();    //关闭数据库的连接
            return My_DataSet;  //返回DataSet对象的信息
        }
        #endregion

        #region  删除生成透视表的存储过程
        /// <summary>
        /// 删除生成透视表的存储过程
        /// </summary>
        /// <returns>返回string对象</returns> 
        public string DROP_Pro()
        {
            string Memory = "";
            if (MyDLL.DataType == "2000")
            {
                Memory = "IF EXISTS (SELECT name FROM sysobjects WHERE name = 'Pro_DynamicRendering' AND type = 'P') DROP PROCEDURE Pro_DynamicRendering";
            }
            if (MyDLL.DataType == "2005")
            {
                Memory = "IF EXISTS (SELECT name FROM sys.objects WHERE name = 'Pro_DynamicRendering' AND type = 'P') DROP PROCEDURE Pro_DynamicRendering";
            }
            return Memory;
        }
        #endregion

        #region  创建生成透视表的存储过程
        /// <summary>
        /// 创建生成透视表的存储过程
        /// </summary>
        /// <returns>返回string对象</returns> 
        public string RenderingMemory()
        {
            string Memory = "";
            Memory = "CREATE PROCEDURE Pro_DynamicRendering";
            Memory = Memory + '\n';
            Memory = Memory + "@SelectSen as varchar(5000),                   --实现透视表依据的SQL语句";
            Memory = Memory + '\n';
            Memory = Memory + "@PageFieldByColumn as varchar(100),          --页字段依据的列名";
            Memory = Memory + '\n';
            Memory = Memory + "@PageFieldValue as varchar(1000),             --用来控制透视表页字段的数据";
            Memory = Memory + '\n';
            Memory = Memory + "@RowFieldByColumn as varchar(100),           --行字段依据的列名";
            Memory = Memory + '\n';
            Memory = Memory + "@RowFieldValue as varchar(1000),              --用来控制透视表行字段的数据";
            Memory = Memory + '\n';
            Memory = Memory + "@ColumnFieldByColumn as varchar(100),        --列字段依据的列名";
            Memory = Memory + '\n';
            Memory = Memory + "@ColumnFieldValue as varchar(1000),           --用来控制透视表列字段的数据";
            Memory = Memory + '\n';
            Memory = Memory + "@DataFieldByColumn as varchar(100),           --数据字段依据的列名";
            Memory = Memory + '\n';
            Memory = Memory + "@DataFieldOperateMethod as varchar(20)      --对数据字段的统计方式";
            Memory = Memory + '\n';
            Memory = Memory + "AS";
            Memory = Memory + '\n';
            Memory = Memory + "DECLARE  @SqlStr as varchar(5000),@Str as varchar(8000),@ColName as varchar(1000),";
            Memory = Memory + '\n';
            Memory = Memory + "@ColumnName as varchar(1000), @PageFieldData as varchar(1000), ";
            Memory = Memory + '\n';
            Memory = Memory + "@RowFieldData as varchar(1000), @ColumnFieldData as varchar(1000),";
            Memory = Memory + '\n';
            Memory = Memory + "@StrOne as varchar(500),@Temp as varchar(2000),@TemTab as varchar(3000)";
            Memory = Memory + '\n';
            Memory = Memory + "if(@PageFieldValue='')  --将页字段的信息生成SQL条件语句";
            Memory = Memory + '\n';
            Memory = Memory + "set @PageFieldData='('+@SelectSen+') as LB_Luna'";
            Memory = Memory + '\n';
            Memory = Memory + "else";
            Memory = Memory + '\n';
            Memory = Memory + "begin";
            Memory = Memory + '\n';
            Memory = Memory + "SET @Temp=@PageFieldValue";
            Memory = Memory + '\n';
            Memory = Memory + "SET @TemTab=''";
            Memory = Memory + '\n';
            Memory = Memory + "while (0=0) ";
            Memory = Memory + '\n';
            Memory = Memory + "begin";
            Memory = Memory + '\n';
            Memory = Memory + "--在添加的多字段获取第一个字段名";
            Memory = Memory + '\n';
            Memory = Memory + "SET @StrOne = substring(@Temp,1,CHARINDEX(',',@Temp)-1) ";
            Memory = Memory + '\n';
            Memory = Memory + "SET @TemTab=@TemTab+@PageFieldByColumn  +'='+''''+@StrOne+''''";
            Memory = Memory + '\n';
            Memory = Memory + "SET @Temp=substring(@Temp,CHARINDEX(',',@Temp)+1,1000 )";
            Memory = Memory + '\n';
            Memory = Memory + "if isnull(@Temp,'') <>''  ";
            Memory = Memory + '\n';
            Memory = Memory + "SET @TemTab=@TemTab+' or '";
            Memory = Memory + '\n';
            Memory = Memory + "else";
            Memory = Memory + '\n';
            Memory = Memory + "break";
            Memory = Memory + '\n';
            Memory = Memory + "end";
            Memory = Memory + '\n';
            Memory = Memory + "set @PageFieldData='(select * from '+'('+@SelectSen+') as LB_Luna where '+@TemTab+')'";
            Memory = Memory + '\n';
            Memory = Memory + "end";
            Memory = Memory + '\n';
            Memory = Memory + "if(@RowFieldValue='')  --将行字段的信息生成SQL条件语句";
            Memory = Memory + '\n';
            Memory = Memory + "set @RowFieldData=''";
            Memory = Memory + '\n';
            Memory = Memory + "else";
            Memory = Memory + '\n';
            Memory = Memory + "begin";
            Memory = Memory + '\n';
            Memory = Memory + "SET @Temp=@RowFieldValue";
            Memory = Memory + '\n';
            Memory = Memory + "SET @TemTab=''";
            Memory = Memory + '\n';
            Memory = Memory + "while (0=0) ";
            Memory = Memory + '\n';
            Memory = Memory + "begin";
            Memory = Memory + '\n';
            Memory = Memory + "--在添加的多字段获取第一个字段名";
            Memory = Memory + '\n';
            Memory = Memory + "SET @StrOne = substring(@Temp,1,CHARINDEX(',',@Temp)-1)";
            Memory = Memory + '\n';
            Memory = Memory + "SET @TemTab=@TemTab+''''+@StrOne+''''";
            Memory = Memory + '\n';
            Memory = Memory + "SET @Temp=substring(@Temp,CHARINDEX(',',@Temp)+1,1000 )";
            Memory = Memory + '\n';
            Memory = Memory + "if isnull(@Temp,'') <>''  ";
            Memory = Memory + '\n';
            Memory = Memory + "SET @TemTab=@TemTab+','";
            Memory = Memory + '\n';
            Memory = Memory + "else";
            Memory = Memory + '\n';
            Memory = Memory + "break";
            Memory = Memory + '\n';
            Memory = Memory + "end";
            Memory = Memory + '\n';
            Memory = Memory + "set @RowFieldData='where PageFieldData.'+@RowFieldByColumn+' in('+@TemTab+')'";
            Memory = Memory + '\n';
            Memory = Memory + "end";
            Memory = Memory + '\n';
            Memory = Memory + "if(@ColumnFieldValue='')  --将列字段的信息生成SQL条件语句";
            Memory = Memory + '\n';
            Memory = Memory + "set @ColumnFieldData=''";
            Memory = Memory + '\n';
            Memory = Memory + "else";
            Memory = Memory + '\n';
            Memory = Memory + "begin";
            Memory = Memory + '\n';
            Memory = Memory + "SET @Temp=@ColumnFieldValue";
            Memory = Memory + '\n';
            Memory = Memory + "SET @TemTab=''";
            Memory = Memory + '\n';
            Memory = Memory + "while (0=0) ";
            Memory = Memory + '\n';
            Memory = Memory + "begin";
            Memory = Memory + '\n';
            Memory = Memory + "--在添加的多字段获取第一个字段名";
            Memory = Memory + '\n';
            Memory = Memory + "SET @StrOne = substring(@Temp,1,CHARINDEX(',',@Temp)-1)";
            Memory = Memory + '\n';
            Memory = Memory + "SET @TemTab=@TemTab+''''+@StrOne+''''";
            Memory = Memory + '\n';
            Memory = Memory + "SET @Temp=substring(@Temp,CHARINDEX(',',@Temp)+1,1000 )";
            Memory = Memory + '\n';
            Memory = Memory + "if isnull(@Temp,'') <>''  ";
            Memory = Memory + '\n';
            Memory = Memory + "SET @TemTab=@TemTab+','";
            Memory = Memory + '\n';
            Memory = Memory + "else";
            Memory = Memory + '\n';
            Memory = Memory + "break";
            Memory = Memory + '\n';
            Memory = Memory + "end";
            Memory = Memory + '\n';
            Memory = Memory + "set @ColumnFieldData=' where '+@ColumnFieldByColumn+' in ('+@TemTab+')'";
            Memory = Memory + '\n';
            Memory = Memory + "end";
            Memory = Memory + '\n';
            Memory = Memory + "EXECUTE ('DECLARE Cursor_Cost  CURSOR FOR SELECT DISTINCT ' + @ColumnFieldByColumn ";
            Memory = Memory + '\n';
            Memory = Memory + "+ ' from ' + '('+@SelectSen+') as LB_Luna '+ @ColumnFieldData + ' for read only') --定义游标";
            Memory = Memory + '\n';
            Memory = Memory + "SET @Str='select '+@RowFieldByColumn+'=case grouping('+@RowFieldByColumn+') when 1 then '+''''+'汇总'+''''+' else '+@RowFieldByColumn+' end,'";
            Memory = Memory + '\n';
            Memory = Memory + "OPEN Cursor_Cost  --打开游标";
            Memory = Memory + '\n';
            Memory = Memory + "while (0=0)";
            Memory = Memory + '\n';
            Memory = Memory + "BEGIN --遍历游标";
            Memory = Memory + '\n';
            Memory = Memory + "FETCH NEXT FROM Cursor_Cost INTO @ColumnName --通过游标获取列头信息";
            Memory = Memory + '\n';
            Memory = Memory + "if (@@fetch_status<>0)";
            Memory = Memory + '\n';
            Memory = Memory + "break";
            Memory = Memory + '\n';
            Memory = Memory + "SET @Str = @Str + @DataFieldOperateMethod + '(CASE ' + @ColumnFieldByColumn";
            Memory = Memory + '\n';
            Memory = Memory + "+ ' WHEN ''' + @ColumnName + ''' THEN ' + @DataFieldByColumn + ' ELSE 0 END)";
            Memory = Memory + '\n';
            Memory = Memory + "AS [' + @ColumnName + '], ' --循环追加SQL语句";
            Memory = Memory + '\n';
            Memory = Memory + "END";
            Memory = Memory + '\n';
            Memory = Memory + "if(@PageFieldValue<>'')  --判断页字段的信息是否为空";
            Memory = Memory + '\n';
            Memory = Memory + "set @SqlStr=@PageFieldData";
            Memory = Memory + '\n';
            Memory = Memory + "else";
            Memory = Memory + '\n';
            Memory = Memory + "set @SqlStr=@SelectSen";
            Memory = Memory + '\n';
            Memory = Memory + "SET @Str = @Str + @DataFieldOperateMethod + '(' + @DataFieldByColumn + ') AS [汇总] from";
            Memory = Memory + '\n';
            Memory = Memory + "' +'('+@SqlStr+')'+ ' as PageFieldData ' + @RowFieldData";
            Memory = Memory + '\n';
            Memory = Memory + "+ ' group by PageFieldData.' + @RowFieldByColumn --定义SQL语句尾";
            Memory = Memory + '\n';
            Memory = Memory + "SET @Str=@Str+' with rollup'  ";
            Memory = Memory + '\n';
            Memory = Memory + "CLOSE Cursor_Cost";
            Memory = Memory + '\n';
            Memory = Memory + "DEALLOCATE Cursor_Cost";
            Memory = Memory + '\n';
            Memory = Memory + "EXEC(@Str)";
            return Memory;
        }
        #endregion
    }
}
