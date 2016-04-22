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

        UpgradeClass.OperateClass operateclass = new UpgradeClass.OperateClass();//ʵ�������������

        //���ݷ������˵Ŀɸ��°汾�Զ���Ӱ汾��壬����ʾ���µ���Ϣ
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
                    linklab.Text = "�������";
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
                this.Text = "û�������汾";
            }
            int Swidth = Screen.PrimaryScreen.WorkingArea.Width;//��ȡ��Ļ���
            int SHeight = Screen.PrimaryScreen.WorkingArea.Height;//��ȡ��Ļ�߶�
            this.DesktopLocation = new Point(Swidth - this.Width, SHeight - this.Height);//���ô������ʱλ��
        }

        //����ָ���İ汾
        private void linklab_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            progressBar1.Visible = true;
            try
            {
                string strXmlName = Application.StartupPath + "\\Update.xml";
                string strName = Application.StartupPath + "\\";//����Ҫ��ȡ�ı���XML�ļ�
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

        #region ��FTP�������������ļ���
        /// <summary>
        /// ��FTP�������������ļ���
        /// </summary>
        /// <param name="filePath">���ص��ı���·��</param>
        /// <param name="ftpServerIP">FTP��������ַ</param>
        /// <param name="ftpUserID">��¼�û���</param>
        /// <param name="ftpPassword">��¼����</param>
        /// <param name="Path">ָ����FTP������·��</param>
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
                    //�ȵ���Ŀ¼����,����������Ŀ¼�͵ݹ��Ŀ¼������ļ�
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