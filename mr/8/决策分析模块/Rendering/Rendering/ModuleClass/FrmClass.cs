using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Drawing;//����������ɫ�������ռ�
using System.Windows.Forms;

namespace Rendering.ModuleClass
{
    class FrmClass
    {
        #region  ��������
        public static string TabName = "";//���ݱ���
        public static string TabSelect = "";//SQL���
        public static string TabType = "";//���ݱ�����ͣ�2000��2005��
        ModuleClass.DataClass DClass = new DataClass();//ʵ����DataClass��
        public static int filterSign = 0;
        public static string[] RowField;
        public static string[] ColumnField;
        //���ɱ��ʱ�����ڼ�¼�ֶ���Ϣ
        public static string C1 = "";
        public static string V1 = "";
        public static string C2 = "";
        public static string V2 = "";
        public static string C3 = "";
        public static string V3 = "";
        public static string C4 = "";
        public static string C5 = "";
        public static int[] YMD;//��¼�����ֶε�����ֵ
        public static string AxisX = "";//��¼ͳ���ֶ�
        public static string AxisY = "";//��¼ͳ�Ƶ������ֶ�

        #endregion

        #region  ����ֵ�ĳ�ʼ����ʾ
        /// <summary>
        /// ����ֵ�ĳ�ʼ����ʾ
        /// </summary>
        /// <param TabN="string">���ݱ�����</param>
        /// <param SQLType="string">���ݿ�����</param>
        public void ProInitialize(ComboBox Cbox, int Sign)
        {
            Cbox.SelectedIndex = Sign;
        }
        #endregion

        #region  ����ͼ��ؼ�������
        /// <summary>
        /// ����ͼ��ؼ�������
        /// </summary>
        /// <param TFont="Font">ͼ�������ı�</param>
        /// <param Csign="int">��ʶ</param>
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
        /// ����ͼ��ؼ�������
        /// </summary>
        /// <param TFont="Font">ͼ������������ʽ</param>
        /// <param Csign="int">��ʶ</param>
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
        /// ����ͼ��ؼ�������
        /// </summary>
        /// <param TFont="Font">ͼ��������ɫ</param>
        /// <param Csign="int">��ʶ</param>
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
        /// ����ͼ��ؼ�������
        /// </summary>
        /// <param TFont="Font">ͼ���������������</param>
        /// <param Csign="int">��ʶ</param>
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

        #region  ��ȡָ�����е����ֻ������ֶ�
        /// <summary>
        /// ��ȡָ�����е����ֻ������ֶ�
        /// </summary>
        /// <param DSet="DataSet">DataSet����</param>
        /// <param comBox="ComboBox">ComboBox�ؼ�</param>
        /// <param Sign="int">��ʶ</param>
        public void FieldStyle(DataSet DSet, ComboBox comBox, int Sign)
        {
            comBox.Items.Clear();
            Type TColumn;//����һ�����ͱ���
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
            for (int i = 0; i < DSet.Tables[0].Columns.Count; i++)//����DataSet�����е���
            {
                TColumn = DSet.Tables[0].Columns[i].DataType;//��ȡ��ǰ�е�����
                if (Sign == 0 || Sign == 2)//�����ʶΪ0����ʾ��ȡ�����ַ��������ڵ��ֶ�
                {
                    if (TColumn.ToString() == "System.String" || TColumn.ToString() == "System.DateTime")
                    {

                        comBox.Items.Add(DSet.Tables[0].Columns[i].Caption);//��ӷ����������б�����
                        if (Sign == 2 && TColumn.ToString() == "System.DateTime")
                        {
                            YMD[ymdi] = ymdSign;
                            ymdi = ymdi + 1;
                        }
                        ymdSign = ymdSign + 1;
                    }

                }
                if (Sign == 1)//��ʾ��ȡ���������͵��ֶ�(���͡��������͡�˫�����͡������͡�ʵ����)
                {
                    if (TColumn.ToString() == "System.Int32" || TColumn.ToString() == "System.Double" || TColumn.ToString() == "System.Decimal" || TColumn.ToString() == "System.Single")
                        comBox.Items.Add(DSet.Tables[0].Columns[i].Caption);
                }
            }
        }
        #endregion

        #region  �������ֶν��и�ʽ��
        /// <summary>
        /// �������ֶν��и�ʽ��
        /// </summary>
        /// <param DSet="DataSet">DataSet����</param>
        /// <param SqlStr="string">SQL���</param>
        /// <returns>����string����</returns>
        public string DataFormat(DataSet DSet, string SqlStr)
        {
            string temSql = SqlStr;
            Type TColumn;//����һ�����ͱ���
            for (int i = 0; i < DSet.Tables[0].Columns.Count; i++)//����DataSet�����е���
            {
                TColumn = DSet.Tables[0].Columns[i].DataType;//��ȡ��ǰ�е�����
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

        #region  �滻���ַ���
        /// <summary>
        /// �滻���ַ���
        /// </summary>
        /// <param Str="string">�ַ���</param>
        /// <param SubStr="string">���ַ���</param>
        /// <returns>����int����</returns>
        public string LookupSubStr(string Str, string SubStr)
        {
            string temStr = "";
            string temfield = "";
            int n = 0;//�ַ���ǰ���ŵ�λ��
            int Subindex = Str.IndexOf(SubStr, 0, Str.Length);//�������ַ�����λ��
            int f = 0;
            if (Subindex != -1)//������ҵ����ַ���
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

        #region  ComboBox�ؼ��ĸ���
        /// <summary>
        /// ComboBox�ؼ��ĸ���
        /// </summary>
        /// <param OcomBox="ComboBox">ԭ�ؼ�</param>
        /// <param DcomBox="ComboBox">Ŀ�ؿؼ�</param>
        public void CopyComboBox(ComboBox OcomBox, ComboBox DcomBox)
        {
            DcomBox.Items.Clear();
            for (int i = 0; i < OcomBox.Items.Count; i++)
            {
                DcomBox.Items.Add(OcomBox.Items[i].ToString());
            }
        }
        #endregion

        #region  ������ComboBox�ؼ���ѡ��
        /// <summary>
        /// ������ComboBox�ؼ���ѡ��
        /// </summary>
        /// <param OcomBox="ComboBox">ԭʼ��Ϣ</param>
        /// <param DcomBox="ComboBox">��ǰѡ�еĿؼ�</param>
        /// <param DcomBox="ComboBox">������Ŀؼ�1</param>
        /// <param DcomBox="ComboBox">������Ŀؼ�2</param>
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

        #region  �Ƴ�ָ������Ϣ
        /// <summary>
        /// �Ƴ�ָ������Ϣ
        /// </summary>
        /// <param DelStr1="string">�Ƴ�����Ϣ1</param>
        /// <param DelStr2="string">�Ƴ�����Ϣ2</param>
        /// <param DcomBox="ComboBox">ComboBox�ؼ�</param>
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

        #region  �洢�к��е��ֶ���Ϣ
        /// <summary>
        /// �洢�к��е��ֶ���Ϣ
        /// </summary>
        /// <param DGridView="DataGridView">DataGridView�ؼ�</param>
        public void SaveDataGridView(DataGridView DGridView)
        {
            V1 = ""; V2 = ""; V3 = "";
            RowField = new string[DGridView.RowCount - 2];
            for (int i = 0; i < DGridView.RowCount - 2; i++)
            {
                RowField[i] = DGridView[0, i].Value.ToString().Trim();//��¼���ֶ�
            }
            ColumnField = new string[DGridView.Columns.Count - 2];
            for (int i = 1; i < DGridView.Columns.Count - 1; i++)
            {
                ColumnField[i-1] = DGridView.Columns[i].HeaderText.Trim();//��¼���ֶ�
            }
        }
        #endregion

        #region  ��ʾ�С��С�ҳ�е��ֶ�
        /// <summary>
        /// ��ʾ�С����е��ֶ�
        /// </summary>
        /// <param LV="ListView">ListView�ؼ�</param>
        /// <param DGridView="DataGridView">DataGridView�ؼ�</param>
        /// <param n="int">��ʶ</param>
        public void Data_List(ListView LV, int n)  //Form��MouseEventArgs��������ռ�using System.Windows.Forms;
        {
            LV.Items.Clear();//���������ļ���
            LV.Columns.Clear();//��������еļ���
            LV.View = View.Details;//��ʾ������
            LV.FullRowSelect = true;//�ڵ���ĳ��ʱ���������ѡ��
            LV.CheckBoxes = true;
            ListViewItem lvi = new ListViewItem();
            string Titname = "";
            filterSign = n;
            if (n == 0)
            {
                Titname = "͸�ӱ���б���";
                LV.Columns.Add(Titname, LV.Parent.Width - 3, HorizontalAlignment.Center);//�����б�ͷ�����Ƽ���С
                //���ָ���е���Ϣ
                for (int i = 0; i < RowField.Length; i++)
                {
                    lvi = new ListViewItem(RowField[i]);//ʵ����һ����
                    lvi.Tag = i;
                    LV.Items.Add(lvi);//�������Ϣ
                    LV.Items[i].Checked = true;
                }
            }
            if (n == 1)
            {
                Titname = "͸�ӱ���б���";
                LV.Columns.Add(Titname, LV.Parent.Width - 3, HorizontalAlignment.Center);//�����б�ͷ�����Ƽ���С
                //���ָ���е���Ϣ
                for (int i = 0; i < ColumnField.Length; i++)
                {
                    lvi = new ListViewItem(ColumnField[i]);//ʵ����һ����
                    lvi.Tag = i;
                    LV.Items.Add(lvi);//�������Ϣ
                    LV.Items[i].Checked = true;
                }
            }
        }

        /// <summary>
        /// ��ʾҳ�е��ֶ�
        /// </summary>
        /// <param LV="ListView">ListView�ؼ�</param>
        /// <param DGridView="DataGridView">DataGridView�ؼ�</param>
        /// <param n="int">��ʶ</param>
        public void Data_List(ListView LV, string PageN, int n)  //Form��MouseEventArgs��������ռ�using System.Windows.Forms;
        {
            LV.Items.Clear();//���������ļ���
            LV.Columns.Clear();//��������еļ���
            LV.View = View.Details;//��ʾ������
            LV.FullRowSelect = true;//�ڵ���ĳ��ʱ���������ѡ��
            LV.CheckBoxes = true;
            string Titname = "";
            ListViewItem lvi = new ListViewItem();
            DataSet TitDSet = new DataSet();
            filterSign = n;
            if (n == 2 && PageN != "")
            {
                Titname = "͸�ӱ��ҳ����";
                LV.Columns.Add(Titname, LV.Parent.Width - 3, HorizontalAlignment.Center);//�����б�ͷ�����Ƽ���С
                TitDSet = DClass.getDataSet("select Distinct LB_Luna." + PageN.Trim() + " from (" + ModuleClass.DataClass.OldSQL + ") as LB_Luna", "");
                for (int i = 0; i < TitDSet.Tables[0].Rows.Count; i++)
                {
                    lvi = new ListViewItem(TitDSet.Tables[0].Rows[i][0].ToString());//ʵ����һ����
                    lvi.Tag = i;
                    LV.Items.Add(lvi);//�������Ϣ
                    LV.Items[i].Checked = true;
                }
            }
        }
        #endregion

        #region  ��ȡɸѡ����ֶ���
        /// <summary>
        /// ��ȡɸѡ����ֶ���
        /// </summary>
        /// <param LV="ListView">ListView�ؼ�</param>
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
