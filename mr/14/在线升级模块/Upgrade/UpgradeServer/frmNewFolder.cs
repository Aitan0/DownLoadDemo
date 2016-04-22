using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UpgradeServer
{
    public partial class frmNewFolder : Form
    {
        public frmNewFolder()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtNewFolderName.Text == "")
            {
                MessageBox.Show("文件夹名称不能为空", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (txtNewFolderName.Text.Trim().EndsWith("."))
                {
                    MessageBox.Show("文件夹名不规范", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    frmMain main = (frmMain)this.Owner;
                    main.FolderName = txtNewFolderName.Text.Trim();
                    this.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNewFolderName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                button1_Click(sender, e);
        }
    }
}