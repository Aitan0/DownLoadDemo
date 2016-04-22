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
                case"�����͹ػ�":
                    reg = Registry.CurrentUser;
                    reg = reg.CreateSubKey("SYSTEM\\CurrentControlSet\\Control");
                    reg.SetValue("WaitToKillServiceTimeout", 1000);
                    reg.Close();		
                    break;
                case "�˵�":
                    reg = Registry.CurrentUser;
                    reg = reg.CreateSubKey("Control Panel\\Desktop");
                    reg.SetValue("MenuShowDelay",40);
                    reg.Close();
                    break;
                case "����":
                    reg = Registry.LocalMachine;
                    reg = reg.CreateSubKey("SYSTEM\\CurrentControlSet\\Control\\FileSystem");
                    reg.SetValue("ConfigFileAllocSize","dword:000001f4");
                    reg.Close();
                    break;
                case "�ӿ�Ԥ������":
                    reg = Registry.LocalMachine;
                    reg = reg.CreateSubKey("SYSTEM\\CurrentControlSet\\Control\\Session Manager\\Memory Management\\PrefetchParameters");
                    reg.SetValue("EnablePrefetcher",4, RegistryValueKind.DWord);
                    reg.Close();
                    break;
                case "�Զ�����ڴ��ж����DLL����":
                    reg = Registry.LocalMachine;
                    reg = reg.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer");
                    reg.SetValue("AlwaysUnloadDLL", 1, RegistryValueKind.DWord);
                    reg.Close();
                    break;
                case "��ֹԶ���޸�ע���":
                    reg = Registry.LocalMachine;
                    reg = reg.CreateSubKey("SYSTEM\\CurrentControlSet\\Control\\SecurePipeServers\\winreg");
                    reg.SetValue("RemoteRegAccess", 1, RegistryValueKind.DWord);
                    reg.Close();
                    break;
                case "����ϵͳ��ԭ":
                    reg = Registry.LocalMachine;
                    reg = reg.CreateSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\SystemRestore");
                    reg.SetValue("DisableSR", 1, RegistryValueKind.DWord);
                    reg.Close();
                    break;
                case "����������ʾϵͳ�汾":
                    reg = Registry.CurrentUser;
                    reg = reg.CreateSubKey("Control Panel\\Desktop");
                    reg.SetValue("PaintDesktopVersion",1,RegistryValueKind.DWord);
                    reg.Close();
                    break;
                case "�ػ�ʱ�Զ��ر�ֹͣ��Ӧ�ĳ���":
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
                MessageBox.Show("ע����ݳɹ�", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("ע���ԭ�ɹ�", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (MessageBox.Show("�Ż�ϵͳ�ɹ�", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
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