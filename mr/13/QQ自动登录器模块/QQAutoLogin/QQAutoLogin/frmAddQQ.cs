using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Security;
using System.Security.Cryptography;
using QQAutoLogin.CommonClass;

namespace QQAutoLogin
{
    public partial class frmAddQQ : Form
    {
        public frmAddQQ()
        {
            InitializeComponent();
        }

        private void txtQQ_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetterOrDigit(e.KeyChar))//判断输入的QQ号码是不是十进制数
            {
                if (!char.IsNumber(e.KeyChar))//判断输入的QQ号码是不是数字
                {
                    e.Handled = true;//处理KeyPress事件
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string strAddNum = txtQQ.Text;//记录QQ账号
            string strAddPwd = txtPwd.Text;//记录QQ密码
            if (string.IsNullOrEmpty(strAddNum) || string.IsNullOrEmpty(strAddPwd))//判断账号或密码是否为空
            {
                MessageBox.Show("账号或密码未输入", "输入错误");
                return;
            }
            Regex qqRegex = new Regex("[1-9][0-9]{4,}");//定义正则表达式，用来判断QQ账号
            if (!qqRegex.Match(strAddNum).Success)//判断QQ账号是否符合规则
            {
                MessageBox.Show("QQ号码必须是纯数字，长度要大于4个字符");
                txtQQ.Focus();//使QQ账号文本框获得焦点
                return;
            }
            this.DialogResult = DialogResult.OK;//设置当前窗体的返回值
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();//关闭当前窗体
        }

        /// <summary>
        /// 取得添加的QQ账号信息
        /// </summary>
        /// <returns></returns>
        public QQInfo GetQQInfo()
        {
            //使用QQInfo类的有参构造函数获取QQ账号信息
            return new QQInfo(txtQQ.Text, HashBase64(txtPwd.Text), DateTime.Now.ToString(), ckboxStatus.Checked, true);
        }

        /// <summary>
        /// 控制窗体标题和控件状态
        /// </summary>
        /// <param name="qqNum"></param>
        public void ControlsStatus(string qqNum)
        {
            this.Text = "修改密码和状态";//设置窗体标题
            txtQQ.Text = qqNum;//显示QQ账号
            txtQQ.ReadOnly = true;//设置QQ账号只读
        }

        /// <summary>
        /// 获取QQ密码的哈希值
        /// </summary>
        /// <param name="str">QQ密码</param>
        /// <returns>QQ密码的哈希值</returns>
        public static string HashBase64(string str)
        {
            byte[] result = new byte[str.Length];//定义一个字节数组
            try
            {
                MD5 md = new MD5CryptoServiceProvider();//实例化MD5加密对象
                result = md.ComputeHash(System.Text.Encoding.UTF8.GetBytes(str));//将QQ密码转换为字节数组，并获取其哈希值
                return Convert.ToBase64String(result);//返回获取到的哈希值
            }
            catch
            {
                return "";//返回空字符串
            }
        }
    }
}
