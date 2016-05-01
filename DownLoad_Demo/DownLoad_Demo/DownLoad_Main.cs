using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace DownLoad_Demo
{
    public partial class DownLoad_Main : Form
    {

        public DownLoad_Main()
        {
            InitializeComponent();
        }

        private void DownLoad_Main_Load(object sender, EventArgs e)
        {
            this.label1.Text = "Scan PCBA SN";
            this.button1.Visible = false;
            if (Init.FileCheck().IndexOf("@") > 0)
            {
                this.toolStripStatusLabel1.ForeColor = Color.Red;
                MessageBox.Show("Invalid ConfigFile,Please Check!");
            }
            else
            {
                this.toolStripStatusLabel1.Text = "配置正常,准备自检中";
                this.toolStripStatusLabel1.ForeColor = Color.Black;
                //这里启动状态机线程
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string temp = this.textBox1.Text;
            if (temp.Length < 10)
            {
                this.label1.Text = "Invalid SN";
                // this.textBox1.Clear();
            }
            else
            {
                this.label1.Text = "Scan PCBA SN";
                if (!backgroundWorker1.IsBusy)
                {
                    this.backgroundWorker1.RunWorkerAsync();
                    this.backgroundWorker1.WorkerReportsProgress = true;
                    this.backgroundWorker1.WorkerSupportsCancellation = true;
                    this.backgroundWorker1.DoWork += new DoWorkEventHandler(DownLoadProcess);
                    this.backgroundWorker1.ProgressChanged += new ProgressChangedEventHandler(ProcessChange);
                    this.backgroundWorker1.RunWorkerCompleted += new RunWorkerCompletedEventHandler(ProcessComp);
                    this.button1.Visible = true;
                }

            }
        }

        private void ProcessComp(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                MessageBox.Show("Cancel Success!");
            }
            else
                MessageBox.Show("Process Comepleted!");
        }

        private void ProcessChange(object sender, ProgressChangedEventArgs e)
        {
            this.toolStripProgressBar1.Value = e.ProgressPercentage;
        }

        private void DownLoadProcess(object sender, DoWorkEventArgs e)
        {
            int process = 0;
            //执行下载操作
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(500);
                process = i;
                backgroundWorker1.ReportProgress(process);
                if (backgroundWorker1.CancellationPending)
                {
                    e.Cancel = true;
                    return;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            backgroundWorker1.CancelAsync();
        }
    }
}
