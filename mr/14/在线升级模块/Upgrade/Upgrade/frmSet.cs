using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Upgrade
{
    public partial class frmSet : Form
    {
        public frmSet()
        {
            InitializeComponent();
        }

        UpgradeClass.OperateClass operateclass = new UpgradeClass.OperateClass();//实例化公共类对象
        string strName = Application.StartupPath + "\\UpgradeSet.ini";//定义要读取的INI文件

        //窗体加载时读取INI设置文件中的内容，并显示在相应的文本框及下拉列表中
        private void frmSet_Load(object sender, EventArgs e)
        {
            timer.Start();//启动计时器
            for (int i = 1; i < 31; i++)
            {
                cboxDate.Items.Add(i);//给日期下拉列表赋值
            }
            txtServer.Text = operateclass.ReadString("UpgradeSet", "Server", "", strName);
            txtUser.Text = operateclass.ReadString("UpgradeSet", "UserID", "", strName);
            txtPwd.Text = operateclass.ReadString("UpgradeSet", "Pwd", "", strName);
            cboxUpgrade.Text = operateclass.ReadString("UpgradeSet", "Frequency", "", strName);
            NUDownHour.Value = Convert.ToDecimal(operateclass.ReadString("UpgradeSet", "Hour", "", strName));
            NUDownMin.Value = Convert.ToDecimal(operateclass.ReadString("UpgradeSet", "Min", "", strName));
            cboxWeek.Text = operateclass.ReadString("UpgradeSet", "Week", "", strName);
            cboxDate.Text = operateclass.ReadString("UpgradeSet", "Date", "", strName);
        }

        //单击“确定”按钮，修改INI设置文件的内容
        private void btnSure_Click(object sender, EventArgs e)
        {
            UpgradeClass.OperateClass.WritePrivateProfileString("UpgradeSet", "Server", txtServer.Text, strName);
            UpgradeClass.OperateClass.WritePrivateProfileString("UpgradeSet", "UserID", txtUser.Text, strName);
            UpgradeClass.OperateClass.WritePrivateProfileString("UpgradeSet", "Pwd", txtPwd.Text, strName);
            UpgradeClass.OperateClass.WritePrivateProfileString("UpgradeSet", "Frequency", cboxUpgrade.Text, strName);
            UpgradeClass.OperateClass.WritePrivateProfileString("UpgradeSet", "Hour", NUDownHour.Value.ToString(), strName);
            UpgradeClass.OperateClass.WritePrivateProfileString("UpgradeSet", "Min", NUDownMin.Value.ToString(), strName);
            UpgradeClass.OperateClass.WritePrivateProfileString("UpgradeSet", "Week", cboxWeek.Text, strName);
            UpgradeClass.OperateClass.WritePrivateProfileString("UpgradeSet", "Date", cboxDate.Text, strName);
            MessageBox.Show("定时升级设置成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //在计时器中调用自定义方法监控各控件可用状态
        private void timer_Tick(object sender, EventArgs e)
        {
            ControlState();
        }

        //关闭当前窗体
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region 根据升级频率下拉列表框中的选择项控制其他控件的可用状态
        /// <summary>
        /// 根据升级频率下拉列表框中的选择项控制其他控件的可用状态
        /// </summary>
        private void ControlState()
        {
            int index = cboxUpgrade.SelectedIndex;
            switch (index)
            {
                case 0:
                    NUDownHour.Enabled = NUDownMin.Enabled = cboxWeek.Enabled = cboxDate.Enabled = false;
                    break;
                case 1:
                    NUDownHour.Enabled = NUDownMin.Enabled = true;
                    cboxWeek.Enabled = cboxDate.Enabled = false;
                    break;
                case 2:
                    NUDownHour.Enabled = NUDownMin.Enabled = cboxWeek.Enabled = true;
                    cboxDate.Enabled = false;
                    break;
                case 3:
                    NUDownHour.Enabled = NUDownMin.Enabled = cboxDate.Enabled = true;
                    cboxWeek.Enabled = false;
                    break;
            }
        }
        #endregion
    }
}