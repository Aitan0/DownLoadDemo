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

        #region ���幫����������ʵ�������������
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
                    if (MessageBox.Show("������������", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        tstbHost.Focus();
                    }
                }
                else if (this.tstbUser.Text.Trim() == "")
                {
                    if (MessageBox.Show("�����û���", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        tstbUser.Focus();
                    }
                }
                else
                {
                    if (this.tstbPwd.Text.Trim() == "")
                    {
                        if (MessageBox.Show("��������", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
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
                            tabControl2.TabPages[0].Text = "FTP������(" + tstbHost.Text.Trim() + ")";
                            listView2.Items.Clear();
                            operateclass.getFTPServerICO(imageList2, tstbHost.Text.Trim(), tstbUser.Text.Trim(), tstbPwd.Text.Trim(), listView2, "");
                            contextMenuStrip1.Items[0].Enabled = true;
                            this.Text = "�����ļ�����-[" + tstbHost.Text + ",״̬��������]";
                            toolStripStatusLabel3.Text = "[��ǰ��¼�û�" + tstbUser.Text.Trim() + "]";

                            tscbServer.Items.Add("/" + tstbUser.Text.Trim());
                            tscbServer.SelectedIndex = 0;
                            check = true;
                        }
                        else
                        {
                            MessageBox.Show("FTP��¼ʧ�ܣ������û����������Ƿ���ȷ", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Text = "�����ļ�����-[" + tstbHost.Text + ",״̬������ʧ��]";
                            toolStripStatusLabel3.Text = "";
                        }
                    }
                }
            }
            catch
            {
                contextMenuStrip1.Items[0].Enabled = true;
                this.Text = "�����ļ�����-[" + tstbHost.Text + ",״̬��������]";
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
                MessageBox.Show("�޷��򿪴��ļ�", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        private void �ϴ�ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtVersion.Text=="")
                    MessageBox.Show("��������µİ汾�ţ�", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else if (listView1.SelectedItems.Count == 0)
                {
                    MessageBox.Show("��ѡ���ļ�", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                                        MessageBox.Show("���������Ѿ����ڴ�Ŀ¼", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    //��FTP������������XML�ļ�
                    operateclass.Download("C:\\", "Update.xml", tstbHost.Text, tstbUser.Text, tstbPwd.Text, "Update/");
                    //��XML�ļ���д�������Ϣ
                    operateclass.AddXML("C:\\Update.xml", txtVersion.Text.Trim(), txtInfo.Text.Trim());
                    //�����µ�XML�ļ��ϴ���FTP��������
                    operateclass.Upload("C:\\Update.xml", tstbHost.Text, tstbUser.Text, tstbPwd.Text, toolStripProgressBar1, "Update/");
                    //ɾ����ʱXML�ļ�
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
        /// ���������ļ����ϴ������ļ��е�FTP
        /// </summary>
        /// <param name="path"></param>
        public string NPath = "";
        public string GFolder;
        public void UpDir(string aimPath)
        {
            try
            {
                NPath = servePath;
                // ���Ŀ��Ŀ¼�Ƿ���Ŀ¼�ָ��ַ�����������������֮
                if (aimPath[aimPath.Length - 1] != Path.DirectorySeparatorChar)
                    aimPath += Path.DirectorySeparatorChar;
                NPath = NPath + FolderN;
                operateclass.MakeDir(NPath, serverIp, serverUser, serverPwd);
                // �õ�ԴĿ¼���ļ��б������ǰ����ļ��Լ�Ŀ¼·����һ������
                string[] fileList = Directory.GetFileSystemEntries(aimPath);
                // �������е��ļ���Ŀ¼
                foreach (string file in fileList)
                {
                    string[] a = file.Split('\\');
                    string fname = a[a.Length - 1];
                    NPath = file.Remove(0, GFolder.Length).Replace("\\", "//");
                    if (NPath.StartsWith("//"))
                    {
                        NPath = servePath + NPath.Remove(0, 2);
                    }
                    // �ȵ���Ŀ¼��������������Ŀ¼�͵ݹ�Delete��Ŀ¼������ļ�
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
            if (filetype == "�ļ���")//�ļ���
            {
                GetPath(filename.Trim(), 1);
                operateclass.getFTPServerICO(imageList2, tstbHost.Text.Trim(), tstbUser.Text.Trim(), tstbPwd.Text.Trim(), listView2, servePath);
                tscbServer.Items.Add("/" + tstbUser.Text.Trim() + "/" + servePath);
                tscbServer.Text = "/" + tstbUser.Text.Trim() + "/" + servePath;
            }
        }

        private void �½��ļ���ToolStripMenuItem_Click(object sender, EventArgs e)
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