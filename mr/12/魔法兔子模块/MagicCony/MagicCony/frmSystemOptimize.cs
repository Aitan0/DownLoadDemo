using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
namespace MagicCony
{
    public partial class frmSystemOptimize : Form
    {
        public frmSystemOptimize()
        {
            InitializeComponent();
        }
        private void SetRegValue(string str)
        {
            RegistryKey reg;
            switch (str)
            {
                case"开机和关机":
                    reg = Registry.CurrentUser;
                    reg = reg.CreateSubKey("SYSTEM\\CurrentControlSet\\Control");
                    reg.SetValue("WaitToKillServiceTimeout", 1000);
                    reg.Close();		
                    break;
                case "菜单":
                    reg = Registry.CurrentUser;
                    reg = reg.CreateSubKey("Control Panel\\Desktop");
                    reg.SetValue("MenuShowDelay",40);
                    reg.Close();
                    break;
                case "程序":
                    reg = Registry.LocalMachine;
                    reg = reg.CreateSubKey("SYSTEM\\CurrentControlSet\\Control\\FileSystem");
                    reg.SetValue("ConfigFileAllocSize","dword:000001f4");
                    reg.Close();
                    break;
                case "加快预读能力":
                    reg = Registry.LocalMachine;
                    reg = reg.CreateSubKey("SYSTEM\\CurrentControlSet\\Control\\Session Manager\\Memory Management\\PrefetchParameters");
                    reg.SetValue("EnablePrefetcher",4, RegistryValueKind.DWord);
                    reg.Close();
                    break;
                case "自动清除内存中多余的DLL资料":
                    reg = Registry.LocalMachine;
                    reg = reg.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer");
                    reg.SetValue("AlwaysUnloadDLL", 1, RegistryValueKind.DWord);
                    reg.Close();
                    break;
                case "禁止远程修改注册表":
                    reg = Registry.LocalMachine;
                    reg = reg.CreateSubKey("SYSTEM\\CurrentControlSet\\Control\\SecurePipeServers\\winreg");
                    reg.SetValue("RemoteRegAccess", 1, RegistryValueKind.DWord);
                    reg.Close();
                    break;
                case "禁用系统还原":
                    reg = Registry.LocalMachine;
                    reg = reg.CreateSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\SystemRestore");
                    reg.SetValue("DisableSR", 1, RegistryValueKind.DWord);
                    reg.Close();
                    break;
                case "在桌面上显示系统版本":
                    reg = Registry.CurrentUser;
                    reg = reg.CreateSubKey("Control Panel\\Desktop");
                    reg.SetValue("PaintDesktopVersion",1,RegistryValueKind.DWord);
                    reg.Close();
                    break;
                case "关机时自动关闭停止响应的程序":
                    reg = Registry.CurrentUser;
                    reg = reg.CreateSubKey("Control Panel\\Desktop");
                    reg.SetValue("AutoEndTasks", 1, RegistryValueKind.DWord);
                    reg.Close();
                    break;
            }
        }

        private void frmSystemOptimize_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            frmCony main = new frmCony();
            main.Show();
        }

        private void frmSystemOptimize_Load(object sender, EventArgs e)
        {
            //RegistryKey a;
            //a = Registry.CurrentUser;
            //a = a.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
            //a.SetValue("DisableRegistryTools",0);
            //a.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process myProcess = new System.Diagnostics.Process();
                myProcess.StartInfo.FileName = "cmd.exe";
                myProcess.StartInfo.UseShellExecute = false;
                myProcess.StartInfo.RedirectStandardInput = true;
                myProcess.StartInfo.RedirectStandardOutput = true;
                myProcess.StartInfo.RedirectStandardError = true;
                myProcess.StartInfo.CreateNoWindow = true;
                myProcess.Start();
                string pp = "regedit /e " + Environment.SystemDirectory.ToString() + "\\backup.reg";
                myProcess.StandardInput.WriteLine(pp);
                MessageBox.Show("注册表备份成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                System.Diagnostics.Process myProcess = new System.Diagnostics.Process();
                myProcess.StartInfo.FileName = "cmd.exe";
                myProcess.StartInfo.UseShellExecute = false;
                myProcess.StartInfo.RedirectStandardInput = true;
                myProcess.StartInfo.RedirectStandardOutput = true;
                myProcess.StartInfo.RedirectStandardError = true;
                myProcess.StartInfo.CreateNoWindow = true;
                myProcess.Start();
                string pp = "regedit /e " + Environment.SystemDirectory.ToString() + "\\backup.reg";
                myProcess.StandardInput.WriteLine(pp);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process myProcess = new System.Diagnostics.Process();
                myProcess.StartInfo.FileName = "cmd.exe";
                myProcess.StartInfo.UseShellExecute = false;
                myProcess.StartInfo.RedirectStandardInput = true;
                myProcess.StartInfo.RedirectStandardOutput = true;
                myProcess.StartInfo.RedirectStandardError = true;
                myProcess.StartInfo.CreateNoWindow = true;
                myProcess.Start();
                string pp = "regedit /s " + Environment.SystemDirectory.ToString() + "\\backup.reg";
                myProcess.StandardInput.WriteLine(pp);
                MessageBox.Show("注册表还原成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                System.Diagnostics.Process myProcess = new System.Diagnostics.Process();
                myProcess.StartInfo.FileName = "cmd.exe";
                myProcess.StartInfo.UseShellExecute = false;
                myProcess.StartInfo.RedirectStandardInput = true;
                myProcess.StartInfo.RedirectStandardOutput = true;
                myProcess.StartInfo.RedirectStandardError = true;
                myProcess.StartInfo.CreateNoWindow = true;
                myProcess.Start();
                string pp = "regedit /s " + Environment.SystemDirectory.ToString() + "\\backup.reg";
                myProcess.StandardInput.WriteLine(pp);
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                if (listView1.Items[i].Checked == true)
                {
                    SetRegValue(listView1.Items[i].Text);
                }
            }
            if (MessageBox.Show("优化系统成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}