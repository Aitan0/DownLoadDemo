using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace Upgrade
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        #region ʵ������������󣬲����幫������
        UpgradeClass.OperateClass operateclass = new UpgradeClass.OperateClass();//ʵ�������������
        string strName = Application.StartupPath + "\\UpgradeSet.ini";  //����Ҫ��ȡ��INI�ļ�
        public static string strServer = "";                                   //��¼����������
        public static string strUserID = "";                                   //��¼����Ƶ��
        public static string strPwd = "";                                      //��¼��������
        static string strFrequency = "";                                //��¼����Ƶ��
        static int intHour = 0;                                         //��¼����Сʱ
        static int intMin = 0;                                          //��¼��������
        static string strWeek = "";                                     //��¼��������
        static string strDate = "";                                     //��¼��������
        string strOldVersion = "";                                      //��¼��ǰ�汾
        string strOldXmlName = Application.StartupPath + "\\Update.xml";//����Ҫ��ȡ�ı���XML�ļ�
        string strNewXmlName = Application.StartupPath + "\\NewXml\\Update.xml";//����Ҫ��ȡ�ķ�������XML�ļ�
        public static ArrayList list = new ArrayList();                 //��¼Ҫ�����İ汾
        public static Hashtable HTable1;                                //��ȡ��������汾����Ϣ
        public static Hashtable HTable2;                                //��ȡ������������汾����Ϣ
        #endregion

        //�������ʱ����ȡINI��ʱ�����ļ��������������µ�XML�ļ������ж��Ƿ����°汾
        private void frmMain_Load(object sender, EventArgs e)
        {
            timer.Start();//������ʱ��
            strServer = operateclass.ReadString("UpgradeSet", "Server", "", strName);
            strUserID = operateclass.ReadString("UpgradeSet", "UserID", "", strName);
            strPwd = operateclass.ReadString("UpgradeSet", "Pwd", "", strName);
            strFrequency = operateclass.ReadString("UpgradeSet", "Frequency", "", strName);
            intHour = Convert.ToInt32(operateclass.ReadString("UpgradeSet", "Hour", "", strName));
            intMin = Convert.ToInt32(operateclass.ReadString("UpgradeSet", "Min", "", strName));
            strWeek = operateclass.ReadString("UpgradeSet", "Week", "", strName);
            strDate = operateclass.ReadString("UpgradeSet", "Date", "", strName);
            operateclass.Download(Application.StartupPath + "\\NewXml\\", "Update.xml", strServer, strUserID, strPwd, "Update/");
            ControlUpdate();
        }

        //�ڼ�ʱ���м��Ӷ�ʱ����״̬
        private void timer_Tick(object sender, EventArgs e)
        {
            switch (strFrequency)
            {
                case "������":
                    timer.Enabled = false;
                    break;
                case "ÿ��һ��":
                    timer.Enabled = true;
                    if (DateTime.Now.Hour == intHour && DateTime.Now.Minute == intMin)
                        ControlUpdate();
                    break;
                case "ÿ��һ��":
                    timer.Enabled = true;
                    if (getWeek() == strWeek && DateTime.Now.Hour == intHour && DateTime.Now.Minute == intMin)
                        ControlUpdate();
                    break;
                case "ÿ��һ��":
                    timer.Enabled = true;
                    if (DateTime.Now.Month == Convert.ToInt32(strDate) && DateTime.Now.Hour == intHour && DateTime.Now.Minute == intMin)
                        ControlUpdate();
                    break;
            }
        }

        //������������
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmUpdate frmupdate = new frmUpdate();
            frmupdate.Show();
        }

        //������ʱ�������ô���
        private void btnSet_Click(object sender, EventArgs e)
        {
            frmSet frmset = new frmSet();
            frmset.ShowDialog();
        }

        #region  �ж����ڼ�
        /// <summary>
        /// �ж����ڼ�
        /// </summary>
        /// <returns></returns>
        public string getWeek()
        {
            string str = DateTime.Now.DayOfWeek.ToString();
            string strWeek = "";
            switch (str)
            {
                case "Monday":
                    strWeek = "����һ";
                    break;
                case "Tuesday":
                    strWeek = "���ڶ�";
                    break;
                case "Wednesday":
                    strWeek = "������";
                    break;
                case "Thursday":
                    strWeek = "������";
                    break;
                case "Friday":
                    strWeek = "������";
                    break;
                case "Saturday":
                    strWeek = "������";
                    break;
                case "Sunday":
                    strWeek = "������";
                    break;
            }
            return strWeek;
        }
        #endregion

        #region ���ư汾����
        /// <summary>
        /// ���ư汾����
        /// </summary>
        private void ControlUpdate()
        {
            HTable1 = operateclass.SelectXML(strOldXmlName);
            HTable2 = operateclass.SelectXML(strNewXmlName);
            IDictionaryEnumerator IDEnumerator1 = HTable1.GetEnumerator();
            IDictionaryEnumerator IDEnumerator2 = HTable2.GetEnumerator();
            string str = "";
            while (IDEnumerator1.MoveNext())
            {
                if (str == "")
                    str = IDEnumerator1.Key.ToString();
                else
                    str += "\n" + IDEnumerator1.Key.ToString();
            }
            //��ȡ���ػ��������°汾
            if (str.IndexOf("\n") != -1)
                strOldVersion = str.Substring(str.LastIndexOf("\n") + 1, str.Length - str.LastIndexOf("\n") - 1);
            else
                strOldVersion = str;
            //ʹ�ñ��ػ����ϵ����°汾��������ϵ��°汾���бȽ�
            while (IDEnumerator2.MoveNext())
            {
                if (string.Compare(strOldVersion, IDEnumerator2.Key.ToString()) < 0)
                    list.Add(IDEnumerator2.Key.ToString());
            }
            if (list.Count > 0)
            {
                frmUpdate frmupdate = new frmUpdate();
                frmupdate.Show();
            }
            else
                MessageBox.Show("��ǰ�汾�Ѿ������°汾������Ҫ������", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion
    }
}