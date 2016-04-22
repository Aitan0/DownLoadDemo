using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Drawing;//添加字体和颜色的命名空间
using System.Windows.Forms;

namespace Rendering.ModuleClass
{
    class FrmClass
    {
        #region  公共变量
        public static string TabName = "";//数据表名
        public static string TabSelect = "";//SQL语句
        public static string TabType = "";//数据表的类型（2000、2005）
        ModuleClass.DataClass DClass = new DataClass();//实例化DataClass类
        public static int filterSign = 0;
        public static string[] RowField;
        public static string[] ColumnField;
        //生成表格时，用于记录字段信息
        public static string C1 = "";
        public static string V1 = "";
        public static string C2 = "";
        public static string V2 = "";
        public static string C3 = "";
        public static string V3 = "";
        public static string C4 = "";
        public static string C5 = "";
        public static int[] YMD;//记录日期字段的索引值
        public static string AxisX = "";//记录统计字段
        public static string AxisY = "";//记录统计的数据字段

        #endregion

        #region  属性值的初始化显示
        /// <summary>
        /// 属性值的初始化显示
        /// </summary>
        /// <param TabN="string">数据表名称</param>
        /// <param SQLType="string">数据库类型</param>
        public void ProInitialize(ComboBox Cbox, int Sign)
        {
            Cbox.SelectedIndex = Sign;
        }
        #endregion

        #region  设置图表控件的属性
        /// <summary>
        /// 设置图表控件的属性
        /// </summary>
        /// <param TFont="Font">图表标题的文本</param>
        /// <param Csign="int">标识</param>
        public void GetChartProperty(ChartComponent.ChartPanel ChartP, string TitleText, int Csign)
        {
            switch (Csign)
            {
                case 0:
                    {
                        ChartP.TitleName = TitleText;
                        break;
                    }
            }
        }

        /// <summary>
        /// 设置图表控件的属性
        /// </summary>
        /// <param TFont="Font">图表标题的字体样式</param>
        /// <param Csign="int">标识</param>
        public void GetChartProperty(ChartComponent.ChartPanel ChartP, Font TFont, int Csign)
        {
            switch (Csign)
            {
                case 1:
                    {
                        ChartP.TitleFont = TFont;
                        break;
                    }
            }
        }

        /// <summary>
        /// 设置图表控件的属性
        /// </summary>
        /// <param TFont="Font">图表标题的颜色</param>
        /// <param Csign="int">标识</param>
        public void GetChartProperty(ChartComponent.ChartPanel ChartP, Color TColor, int Csign)
        {
            switch (Csign)
            {
                case 2:
                    {
                        ChartP.TitleColor = TColor;
                        break;
                    }
            }
        }

        /// <summary>
        /// 设置图表控件的属性
        /// </summary>
        /// <param TFont="Font">图表的其它属性设置</param>
        /// <param Csign="int">标识</param>
        public void GetChartProperty(ChartComponent.ChartPanel ChartP, int CValue, int Csign)
        {
            switch (Csign)
            {
                case 3:
                    {
                        ChartP.Chartmark = Convert.ToBoolean(CValue);
                        break;
                    }
                case 4:
                    {
                        ChartP.LabelSay = Convert.ToBoolean(CValue);
                        break;
                    }
                case 5:
                    {
                        ChartP.ChartWearColor = Convert.ToBoolean(CValue);
                        break;
                    }
                case 6:
                    {
                        if (CValue == 0)
                            ChartP.RowWeave = ChartComponent.ChartPanel.CharRowWeaveStyle.Side;
                        else
                            ChartP.RowWeave = ChartComponent.ChartPanel.CharRowWeaveStyle.Stavked;
                        break;
                    }
                case 7:
                    {
                        switch (CValue)
                        {
                            case 0:
                                {
                                    ChartP.ChartStyle = ChartComponent.ChartPanel.CharMode.Bar;
                                    break;
                                }
                            case 1:
                                {
                                    ChartP.ChartStyle = ChartComponent.ChartPanel.CharMode.Line;
                                    break;
                                }
                            case 2:
                                {
                                    ChartP.ChartStyle = ChartComponent.ChartPanel.CharMode.Mark;
                                    break;
                                }
                            case 3:
                                {
                                    ChartP.ChartStyle = ChartComponent.ChartPanel.CharMode.Area;
                                    break;
                                }
                        }
                        break;
                    }

            }
        }
        #endregion

        #region  获取指定表中的数字或日期字段
        /// <summary>
        /// 获取指定表中的数字或日期字段
        /// </summary>
        /// <param DSet="DataSet">DataSet对象</param>
        /// <param comBox="ComboBox">ComboBox控件</param>
        /// <param Sign="int">标识</param>
        public void FieldStyle(DataSet DSet, ComboBox comBox, int Sign)
        {
            comBox.Items.Clear();
            Type TColumn;//定义一个类型变量
            if (Sign == 2)
            {
                YMD = new int[DSet.Tables[0].Columns.Count];
                for (int i = 0; i < YMD.Length; i++)
                {
                    YMD[i] = YMD.Length + 2;
                }
            }
            int ymdSign = 0;
            int ymdi = 0;
            for (int i = 0; i < DSet.Tables[0].Columns.Count; i++)//遍历DataSet对象中的列
            {
                TColumn = DSet.Tables[0].Columns[i].DataType;//获取当前列的类型
                if (Sign == 0 || Sign == 2)//如果标识为0，表示获取的是字符串和日期的字段
                {
                    if (TColumn.ToString() == "System.String" || TColumn.ToString() == "System.DateTime")
                    {

                        comBox.Items.Add(DSet.Tables[0].Columns[i].Caption);//添加符合条件的列标题名
                        if (Sign == 2 && TColumn.ToString() == "System.DateTime")
                        {
                            YMD[ymdi] = ymdSign;
                            ymdi = ymdi + 1;
                        }
                        ymdSign = ymdSign + 1;
                    }

                }
                if (Sign == 1)//表示获取的是数字型的字段(整型、单精度型、双精度型、货币型、实数型)
                {
                    if (TColumn.ToString() == "System.Int32" || TColumn.ToString() == "System.Double" || TColumn.ToString() == "System.Decimal" || TColumn.ToString() == "System.Single")
                        comBox.Items.Add(DSet.Tables[0].Columns[i].Caption);
                }
            }
        }
        #endregion

        #region  对日期字段进行格式化
        /// <summary>
        /// 对日期字段进行格式化
        /// </summary>
        /// <param DSet="DataSet">DataSet对象</param>
        /// <param SqlStr="string">SQL语句</param>
        /// <returns>返回string对象</returns>
        public string DataFormat(DataSet DSet, string SqlStr)
        {
            string temSql = SqlStr;
            Type TColumn;//定义一个类型变量
            for (int i = 0; i < DSet.Tables[0].Columns.Count; i++)//遍历DataSet对象中的列
            {
                TColumn = DSet.Tables[0].Columns[i].DataType;//获取当前列的类型
                if (TColumn.ToString() == "System.DateTime")
                {
                    for (int j = 0; j < DSet.Tables[0].Rows.Count - 1; j++)
                    {
                        if (DSet.Tables[0].Rows[j][i].ToString().Length > 10)
                        { 
                            temSql = LookupSubStr(temSql, DSet.Tables[0].Columns[i].Caption);
                            break;
                        }
                    }
                }
            }
            return temSql;
        }
        #endregion

        #region  替换子字符串
        /// <summary>
        /// 替换子字符串
        /// </summary>
        /// <param Str="string">字符串</param>
        /// <param SubStr="string">子字符串</param>
        /// <returns>返回int对象</returns>
        public string LookupSubStr(string Str, string SubStr)
        {
            string temStr = "";
            string temfield = "";
            int n = 0;//字符串前逗号的位置
            int Subindex = Str.IndexOf(SubStr, 0, Str.Length);//查找子字符串的位置
            int f = 0;
            if (Subindex != -1)//如果查找到子字符串
            {
                temStr = Str.Substring(0, Subindex);
                n = temStr.LastIndexOf(",");
                if (n == -1)
                    n = 5;
                temStr = Str.Substring(Subindex - (Subindex - n) + 1, Subindex - n);

                f = temStr.LastIndexOf(" as ");
                if (f == -1)
                {
                    temfield = Str.Substring(Subindex, SubStr.Length);
                    temStr = Str.Replace(temfield, " convert(char(10)," + temfield + ",121) as " + temfield + " ");
                }
                else
                {
                    temfield = Str.Substring(n + 1, f + 1);
                    temStr = Str.Replace(temfield, " convert(char(10)," + temfield + ",121) ");
                }
            }
            return temStr;
        }
        #endregion

        #region  ComboBox控件的复制
        /// <summary>
        /// ComboBox控件的复制
        /// </summary>
        /// <param OcomBox="ComboBox">原控件</param>
        /// <param DcomBox="ComboBox">目地控件</param>
        public void CopyComboBox(ComboBox OcomBox, ComboBox DcomBox)
        {
            DcomBox.Items.Clear();
            for (int i = 0; i < OcomBox.Items.Count; i++)
            {
                DcomBox.Items.Add(OcomBox.Items[i].ToString());
            }
        }
        #endregion

        #region  多个相关ComboBox控件的选择
        /// <summary>
        /// 多个相关ComboBox控件的选择
        /// </summary>
        /// <param OcomBox="ComboBox">原始信息</param>
        /// <param DcomBox="ComboBox">当前选中的控件</param>
        /// <param DcomBox="ComboBox">相关联的控件1</param>
        /// <param DcomBox="ComboBox">相关联的控件2</param>
        public void FieldStyle(ComboBox OcomBox, ComboBox ScomBox, ComboBox comBox1, ComboBox comBox2)
        {
            string Sel = ScomBox.Text;
            ScomBox.Items.Clear();
            ScomBox.Text = Sel;
            for (int i = 0; i < OcomBox.Items.Count; i++)
            {
                if (OcomBox.Items[i].ToString().Trim() != comBox1.Text.Trim() && OcomBox.Items[i].ToString().Trim() != comBox2.Text.Trim())
                {
                    ScomBox.Items.Add(OcomBox.Items[i].ToString());
                }
            }
        }
        #endregion

        #region  移除指定的信息
        /// <summary>
        /// 移除指定的信息
        /// </summary>
        /// <param DelStr1="string">移除的信息1</param>
        /// <param DelStr2="string">移除的信息2</param>
        /// <param DcomBox="ComboBox">ComboBox控件</param>
        public void RemoveComboBox(string DelStr1,string DelStr2, ComboBox DcomBox)
        {
            if (DelStr1!="")
                for (int i = 0; i < DcomBox.Items.Count; i++)
                {
                    if (DcomBox.Items[i].ToString() == DelStr1)
                        DcomBox.Items.RemoveAt(i);
                }
            if (DelStr2!="")
                for (int i = 0; i < DcomBox.Items.Count; i++)
                {
                    if (DcomBox.Items[i].ToString() == DelStr2)
                        DcomBox.Items.RemoveAt(i);
                }
        }
        #endregion

        #region  存储行和列的字段信息
        /// <summary>
        /// 存储行和列的字段信息
        /// </summary>
        /// <param DGridView="DataGridView">DataGridView控件</param>
        public void SaveDataGridView(DataGridView DGridView)
        {
            V1 = ""; V2 = ""; V3 = "";
            RowField = new string[DGridView.RowCount - 2];
            for (int i = 0; i < DGridView.RowCount - 2; i++)
            {
                RowField[i] = DGridView[0, i].Value.ToString().Trim();//记录行字段
            }
            ColumnField = new string[DGridView.Columns.Count - 2];
            for (int i = 1; i < DGridView.Columns.Count - 1; i++)
            {
                ColumnField[i-1] = DGridView.Columns[i].HeaderText.Trim();//记录列字段
            }
        }
        #endregion

        #region  显示行、列、页中的字段
        /// <summary>
        /// 显示行、列中的字段
        /// </summary>
        /// <param LV="ListView">ListView控件</param>
        /// <param DGridView="DataGridView">DataGridView控件</param>
        /// <param n="int">标识</param>
        public void Data_List(ListView LV, int n)  //Form或MouseEventArgs添加命名空间using System.Windows.Forms;
        {
            LV.Items.Clear();//清空所有项的集合
            LV.Columns.Clear();//清空所有列的集合
            LV.View = View.Details;//显示列名称
            LV.FullRowSelect = true;//在单击某项时，对其进行选中
            LV.CheckBoxes = true;
            ListViewItem lvi = new ListViewItem();
            string Titname = "";
            filterSign = n;
            if (n == 0)
            {
                Titname = "透视表的行标题";
                LV.Columns.Add(Titname, LV.Parent.Width - 3, HorizontalAlignment.Center);//设置列标头的名称及大小
                //添加指定列的信息
                for (int i = 0; i < RowField.Length; i++)
                {
                    lvi = new ListViewItem(RowField[i]);//实例化一个项
                    lvi.Tag = i;
                    LV.Items.Add(lvi);//添加列信息
                    LV.Items[i].Checked = true;
                }
            }
            if (n == 1)
            {
                Titname = "透视表的列标题";
                LV.Columns.Add(Titname, LV.Parent.Width - 3, HorizontalAlignment.Center);//设置列标头的名称及大小
                //添加指定列的信息
                for (int i = 0; i < ColumnField.Length; i++)
                {
                    lvi = new ListViewItem(ColumnField[i]);//实例化一个项
                    lvi.Tag = i;
                    LV.Items.Add(lvi);//添加列信息
                    LV.Items[i].Checked = true;
                }
            }
        }

        /// <summary>
        /// 显示页中的字段
        /// </summary>
        /// <param LV="ListView">ListView控件</param>
        /// <param DGridView="DataGridView">DataGridView控件</param>
        /// <param n="int">标识</param>
        public void Data_List(ListView LV, string PageN, int n)  //Form或MouseEventArgs添加命名空间using System.Windows.Forms;
        {
            LV.Items.Clear();//清空所有项的集合
            LV.Columns.Clear();//清空所有列的集合
            LV.View = View.Details;//显示列名称
            LV.FullRowSelect = true;//在单击某项时，对其进行选中
            LV.CheckBoxes = true;
            string Titname = "";
            ListViewItem lvi = new ListViewItem();
            DataSet TitDSet = new DataSet();
            filterSign = n;
            if (n == 2 && PageN != "")
            {
                Titname = "透视表的页标题";
                LV.Columns.Add(Titname, LV.Parent.Width - 3, HorizontalAlignment.Center);//设置列标头的名称及大小
                TitDSet = DClass.getDataSet("select Distinct LB_Luna." + PageN.Trim() + " from (" + ModuleClass.DataClass.OldSQL + ") as LB_Luna", "");
                for (int i = 0; i < TitDSet.Tables[0].Rows.Count; i++)
                {
                    lvi = new ListViewItem(TitDSet.Tables[0].Rows[i][0].ToString());//实例化一个项
                    lvi.Tag = i;
                    LV.Items.Add(lvi);//添加列信息
                    LV.Items[i].Checked = true;
                }
            }
        }
        #endregion

        #region  获取筛选后的字段名
        /// <summary>
        /// 获取筛选后的字段名
        /// </summary>
        /// <param LV="ListView">ListView控件</param>
        public void filterField(ListView LV)
        {
            string TemStr = "";
            if (LV.Items.Count > 1)
            {
                for (int i = 0; i < LV.Items.Count; i++)
                {
                    if (LV.Items[i].Checked)
                        TemStr = TemStr + LV.Items[i].Text.Trim() + ",";
                }
                TemStr = TemStr.Trim();
                switch (filterSign)
                {
                    case 0:
                        {
                            V2 = TemStr;
                            break;
                        }
                    case 1:
                        {
                            V3 = TemStr;
                            break;
                        }
                    case 2:
                        {
                            V1 = TemStr;
                            break;
                        }
                }
            }
        }
        #endregion
    }
}
