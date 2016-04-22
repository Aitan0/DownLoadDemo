using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_for_controlist
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.progressBar1.Visible = false;
        }

        private void 显示ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
                this.WindowState = FormWindowState.Minimized;
        }

        private void 设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new Form();
            frm.Text = "Set Panel";
            
            frm.Location = new Point(400, 200);
            frm.StartPosition = FormStartPosition.Manual;
            Button t1 = new Button();
            t1.Location = new Point(100, 50);
            t1.Text = "Set Font";
            
            frm.Controls.Add(t1);
            t1.Click += new EventHandler(setfont);
            frm.Show();
        }

        private void setfont(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            if(this.fontDialog1.ShowDialog()==DialogResult.OK)
            {
                this.menuStrip1.Font = this.fontDialog1.Font;
                this.menuStrip1.ForeColor = this.fontDialog1.Color;
              //  Form frm = new Form();
              //  frm.Close();
            }
        }

        private void 退出ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult qus = MessageBox.Show("WARNING","Are you sure to quit this app?",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning,MessageBoxDefaultButton.Button1);
            if(qus==DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void 改变菜单字体ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.改变菜单字体ToolStripMenuItem.Click += new EventHandler(设置ToolStripMenuItem_Click);
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            for(int i=0;i<=10;i++)
            {
                if(backgroundWorker1.CancellationPending==true)
                {
                    e.Cancel = true;
                    break;
                }
                else
                {
                    System.Threading.Thread.Sleep(500);
                    backgroundWorker1.ReportProgress((i * 10));
                }
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.progressBar1.Value = e.ProgressPercentage;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
if(e.Error==null)
{
    MessageBox.Show("Process Compeleted!");

}
            else
    MessageBox.Show(e.Error.Message.ToString());

        }

        private void start_Click(object sender, EventArgs e)
        {
            if(backgroundWorker1.IsBusy!=true)
            {
                backgroundWorker1.RunWorkerAsync();
                this.progressBar1.Visible = true;
            }
        }
    }
}
