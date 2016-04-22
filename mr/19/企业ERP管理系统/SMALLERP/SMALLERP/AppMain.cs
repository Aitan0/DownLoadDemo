using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SMALLERP.DataClass;
using SMALLERP.ComClass;

namespace SMALLERP
{
    public partial class AppMain : Form
    {
        DataBase db = null;
      
        public AppMain()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.statusLabelTime.Text = "当前时间：" + DateTime.Now.ToString();
        }

        private void AppMain_Load(object sender, EventArgs e)
        {
            db = new DataBase();
            this.timerTime.Start();
            this.statusLabelOperator.Text = "当前操作员："+PropertyClass.OperatorName;
        }

        private void Menu_Click(object sender, EventArgs e)
        {
            CommonUse commUse = new CommonUse();
            commUse.ShowForm((ToolStripMenuItem)sender, this);
        }

        private void AppMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("确定要退出吗？", "软件提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void AppMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
            this.Dispose();
        }
    }
}
