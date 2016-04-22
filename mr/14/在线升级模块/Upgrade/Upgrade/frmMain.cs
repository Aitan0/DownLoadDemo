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

        #region 实例化公共类对象，并定义公共变量
        UpgradeClass.OperateClass operateclass = new UpgradeClass.OperateClass();//实例化公共类对象
        string strName = Application.StartupPath + "\\UpgradeSet.ini";  //定义要读取的INI文件
        public static string strServer = "";                                   //记录升级服务器
        public static string strUserID = "";                                   //记录升级频率
        public static string strPwd = "";                                      //记录升级密码
        static string strFrequency = "";                                //记录升级频率
        static int intHour = 0;                                         //记录升级小时
        static int intMin = 0;                                          //记录升级分钟
        static string strWeek = "";                                     //记录升级星期
        static string strDate = "";                                     //记录升级日期
        string strOldVersion = "";                                      //记录当前版本
        string strOldXmlName = Application.StartupPath + "\\Update.xml";//定义要读取的本地XML文件
        string strNewXmlName = Application.StartupPath + "\\NewXml\\Update.xml";//定义要读取的服务器端XML文件
        public static ArrayList list = new ArrayList();                 //记录要升级的版本
        public static Hashtable HTable1;                                //存取本地软件版本及信息
        public static Hashtable HTable2;                                //存取服务器端软件版本及信息
        #endregion

        //窗体加载时，读取INI定时升级文件，并且下载最新的XML文件，以判断是否有新版本
        private void frmMain_Load(object sender, EventArgs e)
        {
            timer.Start();//启动计时器
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

        //在计时器中监视定时升级状态
        private void timer_Tick(object sender, EventArgs e)
        {
            switch (strFrequency)
            {
                case "不升级":
                    timer.Enabled = false;
                    break;
                case "每天一次":
                    timer.Enabled = true;
                    if (DateTime.Now.Hour == intHour && DateTime.Now.Minute == intMin)
                        ControlUpdate();
                    break;
                case "每周一次":
                    timer.Enabled = true;
                    if (getWeek() == strWeek && DateTime.Now.Hour == intHour && DateTime.Now.Minute == intMin)
                        ControlUpdate();
                    break;
                case "每月一次":
                    timer.Enabled = true;
                    if (DateTime.Now.Month == Convert.ToInt32(strDate) && DateTime.Now.Hour == intHour && DateTime.Now.Minute == intMin)
                        ControlUpdate();
                    break;
            }
        }

        //弹出升级窗口
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmUpdate frmupdate = new frmUpdate();
            frmupdate.Show();
        }

        //弹出定时升级设置窗体
        private void btnSet_Click(object sender, EventArgs e)
        {
            frmSet frmset = new frmSet();
            frmset.ShowDialog();
        }

        #region  判断星期几
        /// <summary>
        /// 判断星期几
        /// </summary>
        /// <returns></returns>
        public string getWeek()
        {
            string str = DateTime.Now.DayOfWeek.ToString();
            string strWeek = "";
            switch (str)
            {
                case "Monday":
                    strWeek = "星期一";
                    break;
                case "Tuesday":
                    strWeek = "星期二";
                    break;
                case "Wednesday":
                    strWeek = "星期三";
                    break;
                case "Thursday":
                    strWeek = "星期四";
                    break;
                case "Friday":
                    strWeek = "星期五";
                    break;
                case "Saturday":
                    strWeek = "星期六";
                    break;
                case "Sunday":
                    strWeek = "星期日";
                    break;
            }
            return strWeek;
        }
        #endregion

        #region 控制版本升级
        /// <summary>
        /// 控制版本升级
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
            //获取本地机器的最新版本
            if (str.IndexOf("\n") != -1)
                strOldVersion = str.Substring(str.LastIndexOf("\n") + 1, str.Length - str.LastIndexOf("\n") - 1);
            else
                strOldVersion = str;
            //使用本地机器上的最新版本与服务器上的新版本进行比较
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
                MessageBox.Show("当前版本已经是最新版本，不需要升级！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion
    }
}