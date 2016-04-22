using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace SMS
{
    public partial class frmSmsXX : Form
    {
        public frmSmsXX()
        {
            InitializeComponent();
        }

        #region 定义公共变量，并实例化公共类对象
        public string content;
        public string ResviceNum;
        public static string NUM;
        public static string JQCOM;
        public static string BTL;
        public string Power = "YIWU-IJDD-CDQW-JDWG";
        public static int k = 0;
        public static int j = 0;
        public string Did;
        public string Dnum;
        public string Dcontent;
        SMS.BaseClass.ConnClass connclass = new SMS.BaseClass.ConnClass();
        #endregion

        //窗体加载事件中显示发送的短信来源、内容，并获取短信猫中的机器号码、COM端口号和波特率
        private void frmSmsXX_Load(object sender, EventArgs e)
        {
            txtFrom.Text = Dnum;
            txtContent.Text = Dcontent;
            NUM = BaseClass.GSM.GSMModemGetSnInfoNew(JQCOM, BTL);　//机器号码
            JQCOM = BaseClass.GSM.GSMModemGetDevice();　　//ＣＯＭ１
            BTL = BaseClass.GSM.GSMModemGetBaudrate();　　//波特率
        }

        //调用自定义方法回复短信
        private void btnReply_Click(object sender, EventArgs e)
        {
            if (txtSmsContent.Text == "")
            {
                MessageBox.Show("请输入短信内容");
            }
            else
            {
                content = txtSmsContent.Text;
                SendSms(JQCOM, BTL);
                this.Close();
            }
        }

        //关闭当前窗体
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region 将发送的短信信息添加到数据库中
        /// <summary>
        /// 将发送的短信信息添加到数据库中
        /// </summary>
        /// <param name="num">手机号码</param>
        /// <param name="strcontent">短信内容</param>
        /// <param name="sendtime">发送短信时间</param>
        private void AddMessage(string num, string strcontent, string sendtime)
        {
            connclass.getCmd("insert into tb_TelSend([TelNum],[TelContent],[TelTime]) values('" + num + "','" + strcontent + "','" + sendtime + "')");
        }
        #endregion

        #region 回复短信
        /// <summary>
        /// 回复短信
        /// </summary>
        /// <param name="strcom">COM端口号</param>
        /// <param name="strbtl">波特率</param>
        private void SendSms(string strcom, string strbtl)
        {
            //连接设备
            if (BaseClass.GSM.GSMModemInitNew(strcom, strbtl, null, null, false, Power) == false)
            {
                MessageBox.Show("设备连接失败!" + BaseClass.GSM.GSMModemGetErrorMsg(), "提示", MessageBoxButtons.OK);
                return;
            }
            // 发送短信
            AddMessage(txtFrom.Text, txtSmsContent.Text, DateTime.Now.ToString());
            if (BaseClass.GSM.GSMModemSMSsend(null, 8, content, Encoding.Default.GetByteCount(content), txtFrom.Text, false) == true)
                k++;
            MessageBox.Show("回复短信成功!", "提示", MessageBoxButtons.OK);
        }
        #endregion
    }
}