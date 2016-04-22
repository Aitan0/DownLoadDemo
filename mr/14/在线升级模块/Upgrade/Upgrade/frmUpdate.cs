using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.IO;
using System.Threading;

namespace Upgrade
{
    public partial class frmUpdate : Form
    {
        public frmUpdate()
        {
            InitializeComponent();
        }

        UpgradeClass.OperateClass operateclass = new UpgradeClass.OperateClass();//实例化公共类对象

        //根据服务器端的可更新版本自动添加版本面板，并显示更新的信息
        private void frmUpdate_Load(object sender, EventArgs e)
        {
            if (frmMain.list.Count > 0)
            {
                for (int i = 0; i < frmMain.list.Count; i++)
                {
                    TabPage mypage = new TabPage();
                    mypage.Text = frmMain.list[i].ToString();
                    mypage.ToolTipText = frmMain.HTable2[mypage.Text].ToString();
                    Label lab = new Label();
                    lab.Text = frmMain.HTable2[mypage.Text].ToString();
                    lab.AutoSize = true;
                    lab.Location = new System.Drawing.Point(20, 20);
                    LinkLabel linklab = new LinkLabel();
                    linklab.Text = "点击下载";
                    linklab.Location = new Point(300, 155);
                    linklab.LinkArea = new LinkArea(0, linklab.Text.Length);
                    linklab.LinkClicked += new LinkLabelLinkClickedEventHandler(this.linklab_LinkClicked);
                    mypage.Controls.Add(lab);
                    mypage.Controls.Add(linklab);
                    tabControl1.TabPages.Add(mypage);
                }
            }
            else
            {
                this.Text = "没有升级版本";
            }
            int Swidth = Screen.PrimaryScreen.WorkingArea.Width;//获取屏幕宽度
            int SHeight = Screen.PrimaryScreen.WorkingArea.Height;//获取屏幕高度
            this.DesktopLocation = new Point(Swidth - this.Width, SHeight - this.Height);//设置窗体加载时位置
        }

        //下载指定的版本
        private void linklab_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            progressBar1.Visible = true;
            try
            {
                string strXmlName = Application.StartupPath + "\\Update.xml";
                string strName = Application.StartupPath + "\\";//定义要读取的本地XML文件
                string strVersion = tabControl1.TabPages[tabControl1.SelectedIndex].Text;
                string strInfo = tabControl1.TabPages[tabControl1.SelectedIndex].ToolTipText;
                DownLoadDir(strName, frmMain.strServer, frmMain.strUserID, frmMain.strPwd, "Update/" + strVersion + "/");
                operateclass.AddXML(strXmlName, strVersion, strInfo);
                System.Diagnostics.Process.Start(strName + "Update\\" + strVersion + "\\Debug\\setup.exe");
                Application.Exit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #region 从FTP服务器上下载文件夹
        /// <summary>
        /// 从FTP服务器上下载文件夹
        /// </summary>
        /// <param name="filePath">下载到的本地路径</param>
        /// <param name="ftpServerIP">FTP服务器地址</param>
        /// <param name="ftpUserID">登录用户名</param>
        /// <param name="ftpPassword">登录密码</param>
        /// <param name="Path">指定的FTP服务器路径</param>
        public void DownLoadDir(string filePath, string ftpServerIP, string ftpUserID, string ftpPassword, string Path)
        {
            DirectoryInfo di;
            filePath = Application.StartupPath + "\\";
            string strNewPath = "";
            strNewPath = filePath + Path.Remove(Path.LastIndexOf("/"));
            di = new DirectoryInfo(strNewPath);
            if (!di.Exists)
                di.Create();
            string[] fileList = operateclass.GetFTPList(ftpServerIP, ftpUserID, ftpPassword, Path);
            if (fileList != null)
                progressBar1.Maximum = fileList.Length;
            if (fileList == null)
            { }
            else
            {
                foreach (string file in fileList)
                {
                    //先当作目录处理,如果存在这个目录就递归该目录下面的文件
                    string[] f = file.Split(' ');
                    string m = f[f.Length - 1];
                    strNewPath = Path + m;
                    strNewPath = strNewPath.Replace("//", "\\");
                    strNewPath = filePath + strNewPath;
                    strNewPath = strNewPath.Replace("/", "\\");
                    if (file.IndexOf("DIR") != -1)
                    {
                        di = new DirectoryInfo(strNewPath);
                        di.Create();
                        DownLoadDir(strNewPath, ftpServerIP, ftpUserID, ftpPassword, Path + m + "/");
                    }
                    else
                    {
                        operateclass.Download(strNewPath.Remove(strNewPath.LastIndexOf("\\")) + "\\", m, ftpServerIP, ftpUserID, ftpPassword, Path);
                    }
                    if (progressBar1.Value < progressBar1.Maximum)
                        progressBar1.Value += 1;
                }
            }
        }
        #endregion
    }
}