using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QQAutoLogin.CommonClass;
using Microsoft.Win32;

namespace QQAutoLogin
{
    public partial class frmSet : Form
    {
        public frmSet()
        {
            InitializeComponent();
        }

        private void frmSet_Load(object sender, EventArgs e)
        {
            txtQQPath.Text = GetQQRegistryValue(QQRegister.STR_QQ_REG_KEY_PRGRM_PATH);//获取QQ路径
        }

        private void btnBrowser_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();//实例化打开对话框对象
            openFileDialog.InitialDirectory = "c:\\";//设置打开对话框的初始路径
            openFileDialog.Filter = "exe files (*.exe)|*.exe";//设置打开对话框的文件筛选器
            openFileDialog.FileName = "QQ.exe";//设置打开对话框中的默认文件名称
            if (openFileDialog.ShowDialog() == DialogResult.OK)//判断是否选择了文件
            {
                txtQQPath.Text = openFileDialog.FileName;//显示选择的文件名
            }
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            SetQQRegistryValue(QQRegister.STR_QQ_REG_KEY_PRGRM_PATH, txtQQPath.Text);//将QQ路径写入到注册表中
            this.DialogResult = DialogResult.OK;//设置当前窗体的返回值
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();//关闭当前窗体
        }

        /// <summary>
        /// 获取QQ路径的注册表信息
        /// </summary>
        /// <param name="key">注册表键值</param>
        /// <returns>得到的QQ路径</returns>
        public static string GetQQRegistryValue(string key)
        {
            //实例化注册表键值对象
            RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(QQRegister.STR_QQ_REG_PATH, true);
            if (registryKey == null)//判断键值是否为空
            {
                registryKey = Registry.CurrentUser.CreateSubKey(QQRegister.STR_QQ_REG_PATH, RegistryKeyPermissionCheck.ReadWriteSubTree);//创建指定的注册表键值
            }
            object value = registryKey.GetValue(key);//获取指定的注册表键值
            registryKey.Close();//关闭注册表对象
            if (value == null)//判断注册表键值是否为null
            {
                return string.Empty;//返回空值
            }
            else
            {
                return value.ToString();//返回得到的注册表键值，即QQ路径
            }
        }

        /// <summary>
        /// 设置QQ路径注册信息
        /// </summary>
        /// <param name="key">注册表键</param>
        /// <param name="value">键值</param>
        public static void SetQQRegistryValue(string key, object value)
        {
            //打开指定的注册表键值
            RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(QQRegister.STR_QQ_REG_PATH, true);
            if (registryKey == null)//判断注册表键值是否为空
            {
                //创建指定的注册表键值
                registryKey = Registry.CurrentUser.CreateSubKey(QQRegister.STR_QQ_REG_PATH, RegistryKeyPermissionCheck.ReadWriteSubTree);
                registryKey.SetValue(key, string.Empty);//为注册表键设置控制
                registryKey.Close();//关闭注册表对象
            }
            else
            {
                registryKey.SetValue(key, value);//为注册表设置值
                registryKey.Close();//关闭注册表对象
            }
        }
    }
}
