using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.OleDb;

namespace SMS
{
    public partial class frmSendSMS : Form
    {
        public frmSendSMS()
        {
            InitializeComponent();
        }

        #region 实例化公共类对象并声明公共变量
        SMS.BaseClass.ConnClass connclass = new SMS.BaseClass.ConnClass();
        public string content;
        public string ResviceNum;
        public static string NUM;
        public static string JQCOM;
        public static string BTL;
        public string Power="YIWU-IJDD-CDQW-JDWG";
        public static int k = 0;
        public static int j = 0;
        #endregion

        //窗体加载时，读取短信猫的机器号码、COM端口号和波特率
        private void frmSendSMS_Load(object sender, EventArgs e)
        {
            txtaddnum.Focus();
            NUM = BaseClass.GSM.GSMModemGetSnInfoNew(JQCOM, BTL);　//机器号码
            JQCOM = BaseClass.GSM.GSMModemGetDevice();　　//ＣＯＭ１
            BTL = BaseClass.GSM.GSMModemGetBaudrate();　　//波特率
        }

        //判断“手机号码”文本框中的输入是否为数字
        private void txtaddnum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar != 8 && !char.IsDigit(e.KeyChar)) && e.KeyChar != 13)
            {
                MessageBox.Show("请输入数字");
                e.Handled = true;
            }
        }

        //调用自定义方法执行发送短信操作
        private void btnSend_Click(object sender, EventArgs e)
        {
            if (lvInceptNum.Items.Count > 0)
            {
                if (ckbselect.Checked)
                {
                    content = "老朋友：" + txtSmsContent.Text;
                }
                else
                {
                    content = txtSmsContent.Text;
                }
                if (this.lvInceptNum.Items.Count <= 0)
                {
                    MessageBox.Show("手机号码不能为空！", "提示", MessageBoxButtons.OK);
                    this.txtaddnum.Focus();
                    return;
                }
                if (txtSmsContent.Text == "")
                {
                    MessageBox.Show("短信内容不能为空！", "提示", MessageBoxButtons.OK);
                    txtSmsContent.Focus();
                    return;
                }
                SendSms(JQCOM, BTL);
            }
            else
            {
                MessageBox.Show("请输入接收的电话号码");
            }
        }

        //关闭当前窗体
        private void btnCancol_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //打开“选择短语”对话框
        private void btnInsert_Click(object sender, EventArgs e)
        {
            frmDy frmd = new frmDy();
            frmd.Owner = this;
            frmd.ShowDialog();
        }

        //执行添加手机号码操作
        private void btnIncept_Click(object sender, EventArgs e)
        {
            if (txtaddnum.Text == "")
            {
                MessageBox.Show("电话号码不能为空！");
                return;
            }
            else
            {
                if (txtaddnum.Text.Length < 11)
                {
                    MessageBox.Show("手机号码为11位");
                    return;
                }
            }
            if (lvInceptNum.Items.Count > 0)
            {
                for (int i = 0; i < lvInceptNum.Items.Count; i++)
                {
                    if (lvInceptNum.Items[i].Text == txtaddnum.Text)
                    {
                        MessageBox.Show("号码已经添加过了！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                lvInceptNum.Items.Add(txtaddnum.Text);
                txtaddnum.Text = "";
            }
            else
            {
                lvInceptNum.Items.Add(txtaddnum.Text);
                txtaddnum.Text = "";
            }
        }

        //删除手机号码
        private void btnDelIncept_Click(object sender, EventArgs e)
        {
            if (lvInceptNum.Items.Count > 0)
            {
                foreach (ListViewItem it in lvInceptNum.SelectedItems)
                {
                    lvInceptNum.Items.Remove(it);
                }
            }
            else
            {
                MessageBox.Show("没有电话号码");
            }
        }

        //打开“选择电话号码”对话框
        private void btnSelTel_Click(object sender, EventArgs e)
        {
            frmTelNote telnote = new frmTelNote();
            telnote.Owner = this;
            telnote.ShowDialog();
        }

        #region 将发送的短信信息添加到数据库中
        /// <summary>
        /// 将发送的短信信息添加到数据库中
        /// </summary>
        /// <param name="num">手机 号码</param>
        /// <param name="strcontent">短信内容</param>
        /// <param name="sendtime">发送短信时间</param>
        private void AddMessage(string num, string strcontent, string sendtime)
        {
            connclass.getCmd("insert into tb_TelSend([TelNum],[TelContent],[TelTime]) values('" + num + "','" + strcontent + "','" + sendtime + "')");
        }
        #endregion

        #region 使用短信猫发送短信
        /// <summary>
        /// 使用短信猫发送短信
        /// </summary>
        /// <param name="strcom">端口号</param>
        /// <param name="strbtl">波特率</param>
        private void SendSms(string strcom, string strbtl)
        {
            try
            {
                //连接设备
                if (BaseClass.GSM.GSMModemInitNew(strcom, strbtl, null, null, false, Power) == false)
                {
                    MessageBox.Show("设备连接失败!" + BaseClass.GSM.GSMModemGetErrorMsg(), "提示", MessageBoxButtons.OK);
                    return;
                }
                // 发送短信
                j = lvInceptNum.Items.Count;
                for (int i = 0; i < lvInceptNum.Items.Count; i++)
                {
                    AddMessage(lvInceptNum.Items[i].Text, txtSmsContent.Text, DateTime.Now.ToString());
                    if (BaseClass.GSM.GSMModemSMSsend(null, 8, content, Encoding.Default.GetByteCount(content), lvInceptNum.Items[i].Text, false) == true)
                        k++;
                }
                if (k == j)
                {
                    MessageBox.Show("短信发送成功!", "提示", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
    }
}
