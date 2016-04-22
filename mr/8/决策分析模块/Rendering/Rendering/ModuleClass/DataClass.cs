using System;
using System.Collections.Generic;
using System.Data;//���DataSet����������ռ�
using System.Data.SqlClient;//���SqlConnection����������ռ�
using System.Text;

namespace Rendering.ModuleClass
{
    class DataClass
    {
        #region  �Զ������
        public static SqlConnection My_con;  //����һ��SqlConnection���͵Ĺ�������My_con�������ж����ݿ��Ƿ����ӳɹ�
        public static string M_str_sqlcon = "";
        public static string OldSQL = "";
        #endregion

        #region  �������ݿ�����
        /// <summary>
        /// �������ݿ�����.
        /// </summary>
        /// <returns>����SqlConnection����</returns>
        public SqlConnection getcon()
        {
            My_con = new SqlConnection(M_str_sqlcon);   //��SqlConnection������ָ�������ݿ�������
            My_con.Open();  //�����ݿ�����
            return My_con;  //����SqlConnection�������Ϣ
        }
        #endregion

        #region  �ر����ݿ�����
        /// <summary>
        /// �ر������ݿ������
        /// </summary>
        public int con_close()
        {
            int n = 0;
            if (My_con.State == ConnectionState.Open)   //�ж��Ƿ�������ݿ������
            {
                My_con.Close();   //�ر����ݿ������
                My_con.Dispose();   //�ͷ�My_con���������пռ�
                n = 0;
            }
            else
                n = 1;
            return n;
        }
        #endregion

        #region  ��ȡָ�����е���Ϣ
        /// <summary>
        /// ��ȡָ�����е���Ϣ.
        /// </summary>
        /// <param SQLstr="string">SQL���</param>
        /// <returns>����SqlDataReader����</returns>
        public void getcom(string SQLstr)
        {
            getcon();   //�������ݿ������
            SqlCommand My_com = My_con.CreateCommand(); //����һ��SqlCommand��������ִ��SQL���
            My_com.CommandText = SQLstr;    //��ȡָ����SQL���
            SqlDataReader My_read = My_com.ExecuteReader(); //ִ��SQL�����䣬����һ��SqlDataReader����
        }
        #endregion

        #region  ִ��SQL���
        /// <summary>
        /// ִ��SQL���
        /// </summary>
        /// <param M_str_sqlstr="string">SQL���</param>
        /// <param M_str_table="string">����</param>
        /// <returns>����DataSet����</returns>
        public DataSet getDataSet(string SQLstr, string tableName)
        {
            getcon();   //�������ݿ������
            SqlDataAdapter SQLda = new SqlDataAdapter(SQLstr, My_con);  //����һ��SqlDataAdapter���󣬲���ȡָ�����ݱ����Ϣ
            DataSet My_DataSet = new DataSet(); //����DataSet����
            if (tableName == "")
                SQLda.Fill(My_DataSet);
            else
                SQLda.Fill(My_DataSet, tableName);  //ͨ��SqlDataAdapter����ĵ�Fill()�����������ݱ���Ϣ��ӵ�DataSet������
            con_close();    //�ر����ݿ������
            return My_DataSet;  //����DataSet�������Ϣ
        }
        #endregion

        #region  ɾ������͸�ӱ�Ĵ洢����
        /// <summary>
        /// ɾ������͸�ӱ�Ĵ洢����
        /// </summary>
        /// <returns>����string����</returns> 
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

        #region  ��������͸�ӱ�Ĵ洢����
        /// <summary>
        /// ��������͸�ӱ�Ĵ洢����
        /// </summary>
        /// <returns>����string����</returns> 
        public string RenderingMemory()
        {
            string Memory = "";
            Memory = "CREATE PROCEDURE Pro_DynamicRendering";
            Memory = Memory + '\n';
            Memory = Memory + "@SelectSen as varchar(5000),                   --ʵ��͸�ӱ����ݵ�SQL���";
            Memory = Memory + '\n';
            Memory = Memory + "@PageFieldByColumn as varchar(100),          --ҳ�ֶ����ݵ�����";
            Memory = Memory + '\n';
            Memory = Memory + "@PageFieldValue as varchar(1000),             --��������͸�ӱ�ҳ�ֶε�����";
            Memory = Memory + '\n';
            Memory = Memory + "@RowFieldByColumn as varchar(100),           --���ֶ����ݵ�����";
            Memory = Memory + '\n';
            Memory = Memory + "@RowFieldValue as varchar(1000),              --��������͸�ӱ����ֶε�����";
            Memory = Memory + '\n';
            Memory = Memory + "@ColumnFieldByColumn as varchar(100),        --���ֶ����ݵ�����";
            Memory = Memory + '\n';
            Memory = Memory + "@ColumnFieldValue as varchar(1000),           --��������͸�ӱ����ֶε�����";
            Memory = Memory + '\n';
            Memory = Memory + "@DataFieldByColumn as varchar(100),           --�����ֶ����ݵ�����";
            Memory = Memory + '\n';
            Memory = Memory + "@DataFieldOperateMethod as varchar(20)      --�������ֶε�ͳ�Ʒ�ʽ";
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
            Memory = Memory + "if(@PageFieldValue='')  --��ҳ�ֶε���Ϣ����SQL�������";
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
            Memory = Memory + "--����ӵĶ��ֶλ�ȡ��һ���ֶ���";
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
            Memory = Memory + "if(@RowFieldValue='')  --�����ֶε���Ϣ����SQL�������";
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
            Memory = Memory + "--����ӵĶ��ֶλ�ȡ��һ���ֶ���";
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
            Memory = Memory + "if(@ColumnFieldValue='')  --�����ֶε���Ϣ����SQL�������";
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
            Memory = Memory + "--����ӵĶ��ֶλ�ȡ��һ���ֶ���";
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
            Memory = Memory + "+ ' from ' + '('+@SelectSen+') as LB_Luna '+ @ColumnFieldData + ' for read only') --�����α�";
            Memory = Memory + '\n';
            Memory = Memory + "SET @Str='select '+@RowFieldByColumn+'=case grouping('+@RowFieldByColumn+') when 1 then '+''''+'����'+''''+' else '+@RowFieldByColumn+' end,'";
            Memory = Memory + '\n';
            Memory = Memory + "OPEN Cursor_Cost  --���α�";
            Memory = Memory + '\n';
            Memory = Memory + "while (0=0)";
            Memory = Memory + '\n';
            Memory = Memory + "BEGIN --�����α�";
            Memory = Memory + '\n';
            Memory = Memory + "FETCH NEXT FROM Cursor_Cost INTO @ColumnName --ͨ���α��ȡ��ͷ��Ϣ";
            Memory = Memory + '\n';
            Memory = Memory + "if (@@fetch_status<>0)";
            Memory = Memory + '\n';
            Memory = Memory + "break";
            Memory = Memory + '\n';
            Memory = Memory + "SET @Str = @Str + @DataFieldOperateMethod + '(CASE ' + @ColumnFieldByColumn";
            Memory = Memory + '\n';
            Memory = Memory + "+ ' WHEN ''' + @ColumnName + ''' THEN ' + @DataFieldByColumn + ' ELSE 0 END)";
            Memory = Memory + '\n';
            Memory = Memory + "AS [' + @ColumnName + '], ' --ѭ��׷��SQL���";
            Memory = Memory + '\n';
            Memory = Memory + "END";
            Memory = Memory + '\n';
            Memory = Memory + "if(@PageFieldValue<>'')  --�ж�ҳ�ֶε���Ϣ�Ƿ�Ϊ��";
            Memory = Memory + '\n';
            Memory = Memory + "set @SqlStr=@PageFieldData";
            Memory = Memory + '\n';
            Memory = Memory + "else";
            Memory = Memory + '\n';
            Memory = Memory + "set @SqlStr=@SelectSen";
            Memory = Memory + '\n';
            Memory = Memory + "SET @Str = @Str + @DataFieldOperateMethod + '(' + @DataFieldByColumn + ') AS [����] from";
            Memory = Memory + '\n';
            Memory = Memory + "' +'('+@SqlStr+')'+ ' as PageFieldData ' + @RowFieldData";
            Memory = Memory + '\n';
            Memory = Memory + "+ ' group by PageFieldData.' + @RowFieldByColumn --����SQL���β";
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
