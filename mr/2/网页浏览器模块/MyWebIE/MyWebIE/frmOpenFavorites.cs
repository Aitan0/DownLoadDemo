using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using IWshRuntimeLibrary;

namespace MyWebIE
{
    public partial class frmOpenFavorites : Form
    {
        public frmOpenFavorites()
        {
            InitializeComponent();
        }
        public string IUrl;
        public string ITitle;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                addFavorites(IUrl, ITitle, "Favorites");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// 首先要添加应用，选择COM组件中的“Windows Script Host Object Model”
        /// </summary>
        /// <param name="url"></param>
        /// <param name="filename"></param>
        /// <param name="savepath"></param>
        private void addFavorites(string url, string filename, string savepath)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Favorites);
            if (!System.IO.File.Exists(path + "\\" + filename + savepath + ".url"))
            {
                IWshShell_Class shell = new IWshShell_ClassClass();
                IWshURLShortcut shortcut = null;
                if (savepath == "Favorites")
                {
                    shortcut = shell.CreateShortcut(Environment.GetFolderPath(Environment.SpecialFolder.Favorites) + "\\" + filename + ".url") as IWshURLShortcut;
                    if (MessageBox.Show("网址已经添加到收藏夹", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        this.Close();
                    }
                }
                else
                {
                    shortcut = shell.CreateShortcut(Environment.GetFolderPath(Environment.SpecialFolder.Favorites) + "\\" + savepath + "\\" + filename + ".url") as IWshURLShortcut;
                }
                shortcut.TargetPath = url;
                shortcut.Save();
            }
        }

        private void frmOpenFavorites_Load(object sender, EventArgs e)
        {
            textBox1.Text = ITitle;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}