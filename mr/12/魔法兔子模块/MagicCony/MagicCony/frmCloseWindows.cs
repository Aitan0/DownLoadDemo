using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
namespace MagicCony
{
    public partial class frmCloseWindows : Form
    {
        public frmCloseWindows()
        {
            InitializeComponent();
        }
        [DllImport("user32.dll", EntryPoint = "ExitWindowsEx", CharSet = CharSet.Ansi)]
        private static extern int ExitWindowsEx(int uFlags, int dwReserved);
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)//×¢Ïú
        {
            ExitWindowsEx(0, 0);
        }

        private void button3_Click(object sender, EventArgs e)//¹Ø±Õ
        {
            System.Diagnostics.Process myProcess = new System.Diagnostics.Process();
            myProcess.StartInfo.FileName = "cmd.exe";
            myProcess.StartInfo.UseShellExecute = false;
            myProcess.StartInfo.RedirectStandardInput = true;
            myProcess.StartInfo.RedirectStandardOutput = true;
            myProcess.StartInfo.RedirectStandardError = true;
            myProcess.StartInfo.CreateNoWindow = true;
            myProcess.Start();
            myProcess.StandardInput.WriteLine("shutdown -s -t 0");
        }

        private void button4_Click(object sender, EventArgs e)//ÖØÆô
        {
            System.Diagnostics.Process myProcess = new System.Diagnostics.Process();
            myProcess.StartInfo.FileName = "cmd.exe";
            myProcess.StartInfo.UseShellExecute = false;
            myProcess.StartInfo.RedirectStandardInput = true;
            myProcess.StartInfo.RedirectStandardOutput = true;
            myProcess.StartInfo.RedirectStandardError = true;
            myProcess.StartInfo.CreateNoWindow = true;
            myProcess.Start();
            myProcess.StandardInput.WriteLine("shutdown -r -t 0");
        }

        private void frmCloseWindows_Load(object sender, EventArgs e)
        {
            button1.Select();
        }
    }
}