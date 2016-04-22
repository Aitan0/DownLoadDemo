using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace UpgradeServer
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        #region 定义公共变量，并实例化公共类对象
        public string FolderName = "";
        private string serverIp;
        private string serverUser;
        private string serverPwd;
        private static bool check = false;
        public string BDFolderName = "";
        UpgradeClass.OperateClass operateclass = new UpgradeClass.OperateClass();
        #endregion

        private void frmMain_Load(object sender, EventArgs e)
        {
            tstbPwd.TextBox.PasswordChar = '*';
            operateclass.listFolders(toolStripComboBox1);
            contextMenuStrip1.Items[0].Enabled = false;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (tstbHost.Text.Trim() == "")
                {
                    if (MessageBox.Show("输入主机名称", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        tstbHost.Focus();
                    }
                }
                else if (this.tstbUser.Text.Trim() == "")
                {
                    if (MessageBox.Show("输入用户名", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        tstbUser.Focus();
                    }
                }
                else
                {
                    if (this.tstbPwd.Text.Trim() == "")
                    {
                        if (MessageBox.Show("输入密码", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                        {
                            tstbPwd.Focus();
                        }
                    }
                    else
                    {
                        if (operateclass.CheckFtp(tstbHost.Text.Trim(), tstbUser.Text.Trim(), tstbPwd.Text.Trim()))
                        {
                            serverIp = tstbHost.Text.Trim();
                            serverUser = tstbUser.Text.Trim();
                            serverPwd = tstbPwd.Text.Trim();
                            tabControl2.TabPages[0].Text = "FTP服务器(" + tstbHost.Text.Trim() + ")";
                            listView2.Items.Clear();
                            operateclass.getFTPServerICO(imageList2, tstbHost.Text.Trim(), tstbUser.Text.Trim(), tstbPwd.Text.Trim(), listView2, "");
                            contextMenuStrip1.Items[0].Enabled = true;
                            this.Text = "升级文件发布-[" + tstbHost.Text + ",状态：已连接]";
                            toolStripStatusLabel3.Text = "[当前登录用户" + tstbUser.Text.Trim() + "]";

                            tscbServer.Items.Add("/" + tstbUser.Text.Trim());
                            tscbServer.SelectedIndex = 0;
                            check = true;
                        }
                        else
                        {
                            MessageBox.Show("FTP登录失败，请检查用户名和密码是否正确", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Text = "升级文件发布-[" + tstbHost.Text + ",状态：连接失败]";
                            toolStripStatusLabel3.Text = "";
                        }
                    }
                }
            }
            catch
            {
                contextMenuStrip1.Items[0].Enabled = true;
                this.Text = "升级文件发布-[" + tstbHost.Text + ",状态：已连接]";
            }
        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            operateclass.GetPath(toolStripComboBox1.Text, imageList1, listView1, 0);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            operateclass.GOBack(listView1, imageList1, toolStripComboBox1.Text);
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                string pp = listView1.SelectedItems[0].Text;
                operateclass.GetPath(pp.Trim(), imageList1, listView1, 1);
            }
            catch
            {
                MessageBox.Show("无法打开此文件", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tscbServer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tscbServer.Text == "/" + tstbUser.Text)
            {
                GetPath("", 0);
                operateclass.getFTPServerICO(imageList2, tstbHost.Text.Trim(), tstbUser.Text.Trim(), tstbPwd.Text.Trim(), listView2, servePath);
            }
            else
            {
                string path = tscbServer.Text.Trim().Remove(0, tstbUser.Text.Trim().Length + 2);
                operateclass.getFTPServerICO(imageList2, tstbHost.Text.Trim(), tstbUser.Text.Trim(), tstbPwd.Text.Trim(), listView2, path);
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (tscbServer.Text == "/" + serverUser || check == false)
            { }
            else
            {
                string path = servePath;
                string Path1 = path.Remove(path.LastIndexOf("/"));
                string NewPath = Path1.Remove(Path1.LastIndexOf("/") + 1);
                servePath = NewPath;
                if (NewPath.Length != 0)
                {
                    tscbServer.Text = "/" + serverUser + "/" + NewPath;
                    listView2.Items.Clear();
                    operateclass.getFTPServerICO(imageList2, tstbHost.Text.Trim(), tstbUser.Text.Trim(), tstbPwd.Text.Trim(), listView2, NewPath);
                }
                else
                {
                    tscbServer.Text = "/" + serverUser;
                    listView2.Items.Clear();
                    operateclass.getFTPServerICO(imageList2, tstbHost.Text.Trim(), tstbUser.Text.Trim(), tstbPwd.Text.Trim(), listView2, "");
                }
            }
        }

        public static string FolderN;
        public static string path1;
        private void 上传ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtVersion.Text=="")
                    MessageBox.Show("请输入更新的版本号！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else if (listView1.SelectedItems.Count == 0)
                {
                    MessageBox.Show("请选择文件", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    for (int i = 0; i < listView1.SelectedItems.Count; i++)
                    {
                        path1 = operateclass.Mpath() + listView1.SelectedItems[i].Text;
                        GFolder = Directory.GetParent(path1).FullName;
                        if (Directory.Exists(path1))
                        {
                            if (listView2.Items.Count == 0)
                            {
                                FolderN = listView1.SelectedItems[i].Text;
                                UpDir(path1);
                                NPath = servePath;
                            }
                            else
                            {
                                for (int j = 0; j < listView2.Items.Count; j++)
                                {
                                    if (listView2.Items[j].Text == listView1.SelectedItems[i].Text)
                                    {
                                        MessageBox.Show("服务器中已经存在此目录", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                    else
                                    {
                                        FolderN = listView1.SelectedItems[i].Text;
                                        UpDir(path1);
                                        NPath = servePath;
                                    }
                                }
                            }
                        }
                        else if (File.Exists(path1))
                        {
                            if (tscbServer.Text == "/" + serverUser)
                            {
                                toolStripProgressBar1.Visible = true;
                                operateclass.Upload(path1, serverIp, serverUser, serverPwd, toolStripProgressBar1, servePath);
                            }
                            else
                            {
                                toolStripProgressBar1.Visible = true;
                                operateclass.Upload(path1, tstbHost.Text, tstbUser.Text, tstbPwd.Text, toolStripProgressBar1, servePath);
                            }
                        }
                    }
                    toolStripProgressBar1.Visible = false;
                    listView2.Items.Clear();
                    operateclass.getFTPServerICO(imageList2, tstbHost.Text.Trim(), tstbUser.Text.Trim(), tstbPwd.Text.Trim(), listView2, servePath);
                    tscbServer.Text = "/" + serverUser + servePath;
                    //从FTP服务器上下载XML文件
                    operateclass.Download("C:\\", "Update.xml", tstbHost.Text, tstbUser.Text, tstbPwd.Text, "Update/");
                    //向XML文件中写入更新信息
                    operateclass.AddXML("C:\\Update.xml", txtVersion.Text.Trim(), txtInfo.Text.Trim());
                    //将最新的XML文件上传到FTP服务器上
                    operateclass.Upload("C:\\Update.xml", tstbHost.Text, tstbUser.Text, tstbPwd.Text, toolStripProgressBar1, "Update/");
                    //删除临时XML文件
                    File.Delete("C:\\Update.xml");
                }
            }
            catch { }
        }

        public static string servePath = "";
        public void GetPath(string path, int ppath)
        {
            if (ppath == 0)
            {
                if (servePath != path)
                {
                    servePath = path;
                }
            }
            else
            {
                servePath = servePath + path + "/";
            }
        }
        /// <summary>
        /// 遍历本地文件夹上传整个文件夹到FTP
        /// </summary>
        /// <param name="path"></param>
        public string NPath = "";
        public string GFolder;
        public void UpDir(string aimPath)
        {
            try
            {
                NPath = servePath;
                // 检查目标目录是否以目录分割字符结束如果不是则添加之
                if (aimPath[aimPath.Length - 1] != Path.DirectorySeparatorChar)
                    aimPath += Path.DirectorySeparatorChar;
                NPath = NPath + FolderN;
                operateclass.MakeDir(NPath, serverIp, serverUser, serverPwd);
                // 得到源目录的文件列表，里面是包含文件以及目录路径的一个数组
                string[] fileList = Directory.GetFileSystemEntries(aimPath);
                // 遍历所有的文件和目录
                foreach (string file in fileList)
                {
                    string[] a = file.Split('\\');
                    string fname = a[a.Length - 1];
                    NPath = file.Remove(0, GFolder.Length).Replace("\\", "//");
                    if (NPath.StartsWith("//"))
                    {
                        NPath = servePath + NPath.Remove(0, 2);
                    }
                    // 先当作目录处理如果存在这个目录就递归Delete该目录下面的文件
                    if (Directory.Exists(file))
                    {
                        string aa = file;
                        NPath = file.Remove(0, GFolder.Length).Replace("\\", "//");
                        if (NPath.StartsWith("//"))
                        {
                            NPath = NPath.Remove(0, 2);
                        }
                        operateclass.MakeDir(NPath, serverIp, serverUser, serverPwd);
                        UpDir(file);
                    }
                    else
                    {
                        operateclass.Upload(file, serverIp, serverUser, serverPwd, toolStripProgressBar1, NPath.Substring(0, NPath.LastIndexOf("/")));
                    }
                }
            }
            catch { }
        }

        private void listView2_DoubleClick(object sender, EventArgs e)
        {
            string filename = listView2.SelectedItems[0].Text;
            string filetype = listView2.SelectedItems[0].SubItems[1].Text;
            if (filetype == "文件夹")//文件夹
            {
                GetPath(filename.Trim(), 1);
                operateclass.getFTPServerICO(imageList2, tstbHost.Text.Trim(), tstbUser.Text.Trim(), tstbPwd.Text.Trim(), listView2, servePath);
                tscbServer.Items.Add("/" + tstbUser.Text.Trim() + "/" + servePath);
                tscbServer.Text = "/" + tstbUser.Text.Trim() + "/" + servePath;
            }
        }

        private void 新建文件夹ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNewFolder newFolder = new frmNewFolder();
            newFolder.Owner = this;
            newFolder.ShowDialog();
        }

        private void tstbPwd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                toolStripButton1_Click(sender, e);
        }

        private void frmMain_Activated(object sender, EventArgs e)
        {
            if (FolderName.Length != 0)
            {
                operateclass.MakeDir(servePath + FolderName, serverIp, serverUser, serverPwd);
                listView2.Items.Clear();
                operateclass.getFTPServerICO(imageList2, tstbHost.Text.Trim(), tstbUser.Text.Trim(), tstbPwd.Text.Trim(), listView2, servePath);
                FolderName = "";
            }
        }
    }
}