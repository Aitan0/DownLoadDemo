using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using System.IO;
using System.Diagnostics;
using System.Collections;
using System.Management;
using System.Web;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Threading;
using IWshRuntimeLibrary;
using System.Data.OleDb;
namespace MagicCony
{
    public partial class frmCony : Form
    {
        public frmCony()
        {
            InitializeComponent();
        }
        [DllImport("shell32.dll")]
        public static extern int SHEmptyRecycleBin (IntPtr hwnd ,int pszRootPath,int dwFlags);
        [DllImport("kernel32")]
        public static extern int GetTempPath(int nBufferLength, ref StringBuilder lpBuffer);
        [DllImport("user32.dll", EntryPoint = "SystemParametersInfoA")]
        static extern Int32 SystemParametersInfo(Int32 uAction, Int32 uParam, string lpvparam, Int32 fuwinIni);
        private const int SPI_SETDESKWALLPAPER = 20;

        #region
        public class Win32
        {
            public const uint SHGFI_ICON = 0x100;
            public const uint SHGFI_LARGEICON = 0x0; // 'Large icon
            public const uint SHGFI_SMALLICON = 0x1; // 'Small icon
            [DllImport("shell32.dll", EntryPoint = "ExtractIcon")]
            public static extern int ExtractIcon(IntPtr hInst, string lpFileName, int nIndex);
            [DllImport("shell32.dll", EntryPoint = "SHGetFileInfo")]
            public static extern IntPtr SHGetFileInfo(string pszPath, uint dwFileAttribute, ref SHFILEINFO psfi, uint cbSizeFileInfo, uint Flags);
            [DllImport("User32.dll", EntryPoint = "DestroyIcon")]
            public static extern int DestroyIcon(IntPtr hIcon);
            [DllImport("shell32.dll")]
            public static extern uint ExtractIconEx(string lpszFile, int nIconIndex, int[] phiconLarge, int[] phiconSmall, uint nIcons);
            [StructLayout(LayoutKind.Sequential)]
            public struct SHFILEINFO
            {
                public IntPtr hIcon;
                public IntPtr iIcon;
                public uint dwAttributes;
                [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
                public string szDisplayName;
                [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 80)]
                public string szTypeName;
            }
        }
        public void GetListViewItem(string path, ImageList imglist, ListView lv)//获取指定路径下所有文件及其图标
        {
            lv.Items.Clear();
            Win32.SHFILEINFO shfi = new Win32.SHFILEINFO();
            try
            {
                string[] dirs = Directory.GetDirectories(path);
                string[] files = Directory.GetFiles(path);
                for (int i = 0; i < dirs.Length; i++)
                {
                    string[] info = new string[4];
                    DirectoryInfo dir = new DirectoryInfo(dirs[i]);
                    if (dir.Name == "RECYCLER" || dir.Name == "RECYCLED" || dir.Name == "Recycled" || dir.Name == "System Volume Information")
                    { }
                    else
                    {
                        //获得图标
                        Win32.SHGetFileInfo(dirs[i],
                                            (uint)0x80,
                                            ref shfi,
                                            (uint)System.Runtime.InteropServices.Marshal.SizeOf(shfi),
                                            (uint)(0x100 | 0x400)); //取得Icon和TypeName
                        //添加图标
                        imglist.Images.Add(dir.Name, (Icon)Icon.FromHandle(shfi.hIcon).Clone());
                        info[0] = dir.Name.Remove(dir.Name.LastIndexOf("."));
                        info[1] = "";
                        info[2] = "文件夹";
                        info[3] = dir.LastWriteTime.ToString();
                        ListViewItem item = new ListViewItem(info, dir.Name);
                        lv.Items.Add(item);
                        //销毁图标
                        Win32.DestroyIcon(shfi.hIcon);
                    }
                }
                for (int i = 0; i < files.Length; i++)
                {
                    string[] info = new string[4];
                    FileInfo fi = new FileInfo(files[i]);
                    string Filetype = fi.Name.Substring(fi.Name.LastIndexOf(".") + 1, fi.Name.Length - fi.Name.LastIndexOf(".") - 1);
                    string newtype = Filetype.ToLower();
                    if (newtype == "sys" || newtype == "ini" || newtype == "bin" || newtype == "log" || newtype == "com" || newtype == "bat" || newtype == "db")
                    { }
                    else
                    {


                        //获得图标
                        Win32.SHGetFileInfo(files[i],
                                            (uint)0x80,
                                            ref shfi,
                                            (uint)System.Runtime.InteropServices.Marshal.SizeOf(shfi),
                                            (uint)(0x100 | 0x400)); //取得Icon和TypeName
                        //添加图标
                        imglist.Images.Add(fi.Name, (Icon)Icon.FromHandle(shfi.hIcon).Clone());
                        info[0] = fi.Name.Remove(fi.Name.LastIndexOf("."));
                        info[1] = fi.Length.ToString();
                        info[2] = fi.Extension.ToString();
                        info[3] = fi.LastWriteTime.ToString();
                        ListViewItem item = new ListViewItem(info, fi.Name);
                        lv.Items.Add(item);
                        //销毁图标
                        Win32.DestroyIcon(shfi.hIcon);
                    }
                }
            }
            catch
            {
            }
        }
        #endregion

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSystemCheck systemcheck = new frmSystemCheck();
            systemcheck.ShowDialog();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSystemOptimize optimize = new frmSystemOptimize();
            optimize.ShowDialog();
        }
        string[] ImageInfo = new string[3];
        Image ig;
        ListViewItem lvi;
        string PicPath = "";
        private void toolStripButton4_Click(object sender, EventArgs e)//超级工具
        {
            tbcClear.Visible = true;
            tbcClear.Dock = DockStyle.Fill;
            tbcSY.Visible = false;
            tbcXX.Visible = false;
            tbcProcess.Visible = false;

            try
            {
                string b = Environment.GetFolderPath(Environment.SpecialFolder.SendTo);
                GetListViewItem(b, imageList1, listView5);

                listView4.Items.Clear();
                string a = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Microsoft";
                
                ImageInfo[0] = "当前墙纸";
                ig = Image.FromFile(a + "\\Wallpaper1.bmp");
                ImageInfo[1] = ig.Width.ToString() + "×" + ig.Height.ToString();
                ImageInfo[2] = a + "\\Wallpaper1.bmp";
                lvi = new ListViewItem(ImageInfo, "pic");
                listView4.Items.Add(lvi);

                listView4.Items[0].Focused=true;
                listView4.Items[0].Selected = true;

                PicPath = Environment.GetEnvironmentVariable("WinDir") + "\\Web\\Wallpaper";
                DirectoryInfo di = new DirectoryInfo(PicPath);
                FileSystemInfo[] fsi = di.GetFileSystemInfos();
                for (int i = 0; i < fsi.Length; i++)
                {
                    ImageInfo[0] = fsi[i].ToString().Remove(fsi[i].ToString().LastIndexOf("."));
                    ig = Image.FromFile(PicPath + "\\" + fsi[i].ToString());
                    ImageInfo[1] = ig.Width.ToString() + "×" + ig.Height.ToString();
                    ig.Dispose();
                    ImageInfo[2] = PicPath + "\\" + fsi[i].ToString();
                    lvi = new ListViewItem(ImageInfo, "pic");
                    listView4.Items.Add(lvi);
                }
            }
            catch 
            { }
        }

        private void toolStripButton5_Click(object sender, EventArgs e)//个性设置
        {
            tbcClear.Visible = false;
            tbcSY.Visible = false;
            tbcXX.Visible = false;
            tbcProcess.Visible = false;
        }

        private void toolStripButton7_Click(object sender, EventArgs e)//实用工具
        {
            tbcSY.Visible = true;
            tbcSY.Dock = DockStyle.Fill;
            tbcClear.Visible = false;
            tbcXX.Visible = false;
            tbcProcess.Visible = false;

            string strg = Application.StartupPath.ToString();
            strg = strg.Substring(0, strg.LastIndexOf("\\"));
            strg = strg.Substring(0, strg.LastIndexOf("\\"));
            strg += @"\HTMLPage1.htm";
            webBrowser1.Navigate(strg);
        }

        OleDbConnection conn;
        private void toolStripButton11_Click(object sender, EventArgs e)//选项设置
        {
            tbcXX.Visible = true;
            tbcXX.Dock = DockStyle.Fill;
            tbcSY.Visible = false;
            tbcClear.Visible = false;
            tbcProcess.Visible = false;

            string strg = Application.StartupPath.ToString();
            strg = strg.Substring(0, strg.LastIndexOf("\\"));
            strg = strg.Substring(0, strg.LastIndexOf("\\"));
            strg += @"\ConyData.mdb";
            conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data source=" + strg);
            conn.Open();
            OleDbCommand cmd = new OleDbCommand("select * from tb_check where ID=1", conn);
            OleDbDataReader sdr = cmd.ExecuteReader();
            sdr.Read();
            int kj = Convert.ToInt32(sdr["KJ"].ToString().Trim());
            int gp = Convert.ToInt32(sdr["GP"].ToString().Trim());
            sdr.Close();
            conn.Close();
            if (kj == 0)
            {
                checkBox2.Checked = false;
            }
            else
            {
                checkBox2.Checked = true;
            }

            if (gp == 0)
            {
                checkBox1.Checked = false;
            }
            else
            {
                checkBox1.Checked = true;
            }
            
        }

        #region 实用工具中的按钮
        private void toolStripButton21_MouseMove(object sender, MouseEventArgs e)//组策略
        {
            richTextBox2.Text = "可以对软件、Windows、硬\r件的设置进行修改，有很多特殊的功能。";
            toolStripButton21.ForeColor = Color.Red;
        }

        private void toolStripButton21_MouseLeave(object sender, EventArgs e)
        {
            toolStripButton21.ForeColor = Color.Black;
        }

        private void toolStripButton21_Click(object sender, EventArgs e)
        {
            string regeditstr = Environment.SystemDirectory.ToString() + "\\gpedit.msc";
            System.Diagnostics.Process.Start(regeditstr);  
        }

        private void toolStripButton20_MouseMove(object sender, MouseEventArgs e)//DirectX
        {
            richTextBox2.Text = "Windows自带的DirectX游\r戏支持系统检测工具。";
            toolStripButton20.ForeColor = Color.Red;
        }

        private void toolStripButton20_MouseLeave(object sender, EventArgs e)
        {
            toolStripButton20.ForeColor = Color.Black;
        }

        private void toolStripButton20_Click(object sender, EventArgs e)
        {
            string regeditstr = Environment.SystemDirectory.ToString() + "\\dxdiag.exe";
            System.Diagnostics.Process.Start(regeditstr);
        }

        private void toolStripButton19_MouseMove(object sender, MouseEventArgs e)//快速关机
        {
            richTextBox2.Text = "为Windows98/Me/2000系统\r提供的仿XP关机程序。";
            toolStripButton19.ForeColor = Color.Red;
        }

        private void toolStripButton19_MouseLeave(object sender, EventArgs e)
        {
            toolStripButton19.ForeColor = Color.Black;
        }

        private void toolStripButton19_Click(object sender, EventArgs e)
        {
            frmCloseWindows closewindows = new frmCloseWindows();
            closewindows.ShowDialog();
        }

        private void toolStripButton25_MouseMove(object sender, MouseEventArgs e)//计算机管理
        {
            richTextBox2.Text = "管理Windows的各种事件、\r后台服务和存储系统。";
            toolStripButton25.ForeColor = Color.Red;
        }

        private void toolStripButton25_MouseLeave(object sender, EventArgs e)
        {
            toolStripButton25.ForeColor = Color.Black;
        }

        private void toolStripButton25_Click(object sender, EventArgs e)
        {
            string regeditstr = Environment.SystemDirectory.ToString() + "\\compmgmt.msc";
            System.Diagnostics.Process.Start(regeditstr);  
        }

        private void toolStripButton24_MouseMove(object sender, MouseEventArgs e)//注册表
        {
            richTextBox2.Text = "Windows自带的注册表编辑\r器，可以查找、添加、修改、删除系统内的注册表项目。";
            toolStripButton24.ForeColor = Color.Red;
        }

        private void toolStripButton24_MouseLeave(object sender, EventArgs e)
        {
            toolStripButton24.ForeColor = Color.Black;
        }

        private void toolStripButton24_Click(object sender, EventArgs e)
        {
            string regeditstr = Environment.GetEnvironmentVariable("WinDir");
            System.Diagnostics.Process.Start(regeditstr + "\\regedit.exe");
        }

        private void toolStripButton23_Click(object sender, EventArgs e)//添加或删除程序
        {
            System.Diagnostics.Process.Start("appwiz.cpl");
        }
        private void toolStripButton23_MouseMove(object sender, MouseEventArgs e)
        {
            richTextBox2.Text = "Windows自带的添加或删\r除程序，通过此程序可以方便的对程序进行卸载或添加";
            toolStripButton23.ForeColor = Color.Red;
        }
        private void toolStripButton23_MouseLeave(object sender, EventArgs e)
        {
            toolStripButton23.ForeColor = Color.Black;
        }
        private void toolStripButton1_Click(object sender, EventArgs e)//系统属性
        {
            System.Diagnostics.Process.Start("sysdm.cpl");
        }
        private void toolStripButton1_MouseMove(object sender, MouseEventArgs e)
        {
            richTextBox2.Text = "查看系统的属性，其中包括常规选项、计算机名、硬件信息、高级、自动更新以及远程";
            toolStripButton1.ForeColor = Color.Red;
        }
        private void toolStripButton1_MouseLeave(object sender, EventArgs e)
        {
            toolStripButton1.ForeColor = Color.Black;
        }
        private void toolStripButton9_Click(object sender, EventArgs e)//显示属性
        {
            System.Diagnostics.Process.Start("desk.cpl");
        }
        private void toolStripButton9_MouseMove(object sender, MouseEventArgs e)
        {
            richTextBox2.Text = "查看系统的显示属性，其中\r包括主题、桌面、屏幕保护程序、外观以及设置";
            toolStripButton9.ForeColor = Color.Red;
        }
        private void toolStripButton9_MouseLeave(object sender, EventArgs e)
        {
            toolStripButton9.ForeColor = Color.Black;
        }

        private void toolStripButton22_Click(object sender, EventArgs e)//日期和时间
        {
            System.Diagnostics.Process.Start("timedate.cpl");
        }
        private void toolStripButton22_MouseMove(object sender, MouseEventArgs e)
        {
            richTextBox2.Text = "打开系统时间配置窗口，此窗口中可以配置系统的时间和日期，以及设置时区和Internet时间等";
            toolStripButton22.ForeColor = Color.Red;
        }
        private void toolStripButton22_MouseLeave(object sender, EventArgs e)
        {
            toolStripButton22.ForeColor = Color.Black;
        }
        [DllImport("shell32.dll", EntryPoint = "ShellExecute")]
        private static extern int ShellExecute(int hwnd, String lpOperation, String lpFile, String lpParameters, String lpDirectory, int nShowCmd);
        private void toolStripButton10_Click_1(object sender, EventArgs e)//搜索
        {
            ShellExecute(0, "find", "", "", "", 0);
        }
        private void toolStripButton10_MouseMove(object sender, MouseEventArgs e)
        {
            richTextBox2.Text = "打开系统自带的搜索窗口，通过此窗口可以查找制定关键字的所有文件及文件夹";
            toolStripButton10.ForeColor = Color.Red;
        }
        private void toolStripButton10_MouseLeave(object sender, EventArgs e)
        {
            toolStripButton10.ForeColor = Color.Black;
        }
        private void toolStripButton26_Click(object sender, EventArgs e)//网络连接
        {
            System.Diagnostics.Process.Start("ncpa.cpl");
        }
        private void toolStripButton26_MouseMove(object sender, MouseEventArgs e)
        {
            richTextBox2.Text = "打开系统自带的网络连接窗口，在此窗口中可以对网络连接和IP地址进行配置，";
            toolStripButton26.ForeColor = Color.Red;
        }
        private void toolStripButton26_MouseLeave(object sender, EventArgs e)
        {
            toolStripButton26.ForeColor = Color.Black;
        }
        private void toolStripButton27_Click(object sender, EventArgs e)//声音和音频设备
        {
            System.Diagnostics.Process.Start("mmsys.cpl");
        }
        private void toolStripButton27_MouseMove(object sender, MouseEventArgs e)
        {
            richTextBox2.Text = "打开系统自带的声音和音频设备窗口，在此窗口中可以对声音进行相应的设置";
            toolStripButton27.ForeColor = Color.Red;
        }

        private void toolStripButton27_MouseLeave(object sender, EventArgs e)
        {
            toolStripButton27.ForeColor = Color.Black;
        }
        #endregion

        private void getProcessInfo()
        {
            try
            {
                listView1.Items.Clear();
                Process[] MyProcesses = Process.GetProcesses();
                string[] Minfo = new string[6];
                foreach (Process MyProcess in MyProcesses)
                {
                    Minfo[0] = MyProcess.ProcessName;
                    Minfo[1] = MyProcess.Id.ToString();
                    Minfo[2] = MyProcess.Threads.Count.ToString();
                    Minfo[3] = MyProcess.BasePriority.ToString();
                    Minfo[4] = Convert.ToString(MyProcess.WorkingSet / 1024) + "K";
                    Minfo[5] = Convert.ToString(MyProcess.VirtualMemorySize / 1024) + "K";
                    ListViewItem lvi = new ListViewItem(Minfo, "process");
                    listView1.Items.Add(lvi);
                    tsslProcessCount.Text = "总进程数:" + listView1.Items.Count.ToString();
                }
            }
            catch { }
        }
        private void getWindowsInfo()
        {
            try
            {
                listView2.Items.Clear();
                Process[] MyProcesses = Process.GetProcesses();
                string[] Minfo = new string[6];
                foreach (Process MyProcess in MyProcesses)
                {
                    if (MyProcess.MainWindowTitle.Length > 0)
                    {
                        Minfo[0] = MyProcess.MainWindowTitle;
                        Minfo[1] = MyProcess.Id.ToString();
                        Minfo[2] = MyProcess.ProcessName;
                        Minfo[3] = MyProcess.StartTime.ToString();
                        ListViewItem lvi = new ListViewItem(Minfo, "process");
                        listView2.Items.Add(lvi);
                    }
                }
            }
            catch { }
        }
        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            tbcProcess.Visible = true;
            tbcProcess.Dock = DockStyle.Fill;
            tbcSY.Visible = false;
            tbcClear.Visible = false;
            tbcXX.Visible = false;
            getProcessInfo();
            getWindowsInfo();
        }

        private void 刷新ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            getProcessInfo();
        }

        private void 结束进程ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("警告:终止进程会导致不希望发生的结果，\r包括数据丢失和系统不稳定。在被终止前，\r进程将没有机会保存其状态和数据。确实\r想终止该进程吗?", "任务管理器警告", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    string ProcessName = listView1.SelectedItems[0].Text;
                    Process[] MyProcess = Process.GetProcessesByName(ProcessName);
                    MyProcess[0].Kill();
                    getProcessInfo();
                }
                else
                { }
            }
            catch
            {
                    string ProcessName = listView1.SelectedItems[0].Text;
                    Process[] MyProcess1 = Process.GetProcessesByName(ProcessName);
                    Process MyProcess = new Process();
                    //设定程序名
                    MyProcess.StartInfo.FileName = "cmd.exe";
                    //关闭Shell的使用
                    MyProcess.StartInfo.UseShellExecute = false;
                    //重定向标准输入
                    MyProcess.StartInfo.RedirectStandardInput = true;
                    //重定向标准输出
                    MyProcess.StartInfo.RedirectStandardOutput = true;
                    //重定向错误输出
                    MyProcess.StartInfo.RedirectStandardError = true;
                    //设置不显示窗口
                    MyProcess.StartInfo.CreateNoWindow = true;
                    //执行强制结束命令
                    MyProcess.Start();
                    MyProcess.StandardInput.WriteLine("ntsd -c q -p " + (MyProcess1[0].Id).ToString());
                    MyProcess.StandardInput.WriteLine("Exit");
                    getProcessInfo();
            }
        }
        PublicClass pc = new PublicClass();
        private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
        { 
            listView1.ListViewItemSorter=new ListViewItemComparer(e.Column);
            if (listView1.Sorting == SortOrder.Ascending)
            {
                listView1.Sorting = SortOrder.Descending;
            }
            else
            {
                listView1.Sorting = SortOrder.Ascending;
            }
        }
        #region 对ListView控件中的项进行排序
        /// <summary>
        /// 对ListView控件中的项进行排序
        /// </summary>
        class ListViewItemComparer : IComparer
        {
            private int col;
            public ListViewItemComparer()
            {
                col = 0;
            }
            public ListViewItemComparer(int column)
            {
                col = column;
            }
            public int Compare(object x, object y)
            {
                return String.Compare(((ListViewItem)x).SubItems[col].Text, ((ListViewItem)y).SubItems[col].Text);
            }
        }
        #endregion

        private void 刷新ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            getWindowsInfo();
        }

        private void 终止进程ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("警告:终止进程会导致不希望发生的结果，\r包括数据丢失和系统不稳定。在被终止前，\r进程将没有机会保存其状态和数据。确实\r想终止该进程吗?", "任务管理器警告", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    string ProcessName = listView2.SelectedItems[0].SubItems[2].Text.Trim();
                    Process[] MyProcess = Process.GetProcessesByName(ProcessName);
                    MyProcess[0].Kill();
                    listView2.Items.Clear();
                    getWindowsInfo();
                }
                else
                { }
            }
            catch
            {
                MessageBox.Show("请选择终止的进程");
            }
        }

        private void toolStripButton10_Click(object sender, EventArgs e)
        {
                string strg = Application.StartupPath.ToString();
                strg = strg.Substring(0, strg.LastIndexOf("\\"));
                strg = strg.Substring(0, strg.LastIndexOf("\\"));
                strg += @"\HTMLPage1.htm";
                webBrowser1.Navigate(strg);
        }
        private void toolStripButton5_Click_1(object sender, EventArgs e)//官方主页
        {
            System.Diagnostics.Process.Start("http://www.mrbccd.com");
        }

        string str = "";
        private void ClearSystem()
        {
            try
            {
                switch (str)
                {
                    case "清空回收站":
                        SHEmptyRecycleBin(this.Handle, 0, 7);
                        break;
                    case "清空IE缓存区":
                        string dir = Environment.GetFolderPath(Environment.SpecialFolder.InternetCache);
                        DirectoryInfo mDi = new DirectoryInfo(dir);
                        mDi.Delete(true);
                        mDi.Create();
                        break;
                    case "清空IE　Cookies":
                        string strx = Environment.GetFolderPath(Environment.SpecialFolder.Cookies);
                        DirectoryInfo dix = new DirectoryInfo(strx);
                        if (dix.Exists)
                        {
                            dix.Delete(true);
                            dix.Create();
                        }
                        break;
                    case "清空Windows临时文件夹":
                        string BufferStr = Environment.GetEnvironmentVariable("WinDir") + "\\Temp";
                        string BufferStr1 = Environment.GetEnvironmentVariable("TEMP");
                        DirectoryInfo di = new DirectoryInfo(BufferStr);
                        DirectoryInfo di2 = new DirectoryInfo(BufferStr1);
                        if (di.Exists)
                        {
                            di.Delete(true);
                            di.Create();

                        }
                        if (di2.Exists)
                        {
                            di2.Delete(true);
                            di2.Create();
                        }
                        break;
                    case "清空打开的文件记录":
                        string str1 = Environment.GetFolderPath(Environment.SpecialFolder.Recent);
                        DirectoryInfo dii = new DirectoryInfo(str1);
                        if (dii.Exists)
                        {
                            dii.Delete(true);
                            dii.Create();
                        }
                        break;
                    case"清除IE地址栏中的历史网址":
                        RegistryKey hklm = Registry.CurrentUser;
                        RegistryKey software = hklm.OpenSubKey(@"Software\Microsoft\Internet Explorer", true);
                        software.DeleteSubKeyTree("TypedURLs");
                        break;
                    case "清除运行对话框":
                        RegistryKey MyReg;
                        MyReg = Registry.CurrentUser;
                        MyReg = MyReg.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\RunMRU");
                        string MyMRU = (String)MyReg.GetValue("MRULIST");
                        for (int i = 0; i < MyMRU.Length; i++)
                        {
                            MyReg.DeleteValue(MyMRU[i].ToString());
                        }
                        MyReg.SetValue("MRUList", "");
                        MyReg.Close();
                        break;
                }
            }
            catch
            {
                
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listView3.Items.Count; i++)
            {
                if (listView3.Items[i].Checked==false)
                {}
                else
                {
                    if (listView3.Items[i].Checked == true)
                    {
                        str= listView3.Items[i].Text;
                        ClearSystem();
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmSetPassword setpass = new frmSetPassword();
            setpass.ShowDialog();
        }

        private void listView4_Click(object sender, EventArgs e)
        {
            if (listView4.SelectedItems.Count != 0)
            {
                if (listView4.SelectedItems[0].SubItems[2].Text == "")
                {
                    pictureBox1.Image = null;
                }
                else
                {
                    pictureBox1.Image = Image.FromFile(listView4.SelectedItems[0].SubItems[2].Text);
                }
            }
        }

        private void 添加ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox9_Click(sender, e);
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox8_Click(sender,e);
        }

        private void 打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string PPath = listView4.SelectedItems[0].SubItems[2].Text;
            System.Diagnostics.Process.Start(PPath);
        }

        private void 设为墙纸ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string a = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Microsoft";
                DirectoryInfo dix = new DirectoryInfo(a);
                FileSystemInfo[] fsix = dix.GetFileSystemInfos();
                string PPath = listView4.SelectedItems[0].SubItems[2].Text;
                //获取指定图片的扩展名
                string SFileType = PPath.Substring(PPath.LastIndexOf(".") + 1, (PPath.Length - PPath.LastIndexOf(".") - 1));
                //将扩展名转换成小写
                SFileType = SFileType.ToLower();
                //获取文件名
                string SFileName = PPath.Substring(PPath.LastIndexOf("\\") + 1, (PPath.LastIndexOf(".") - PPath.LastIndexOf("\\") - 1));
                //如果图片的类型是bmp则调用API中的方法将其设置为桌面背景
                if (SFileType == "bmp")
                {
                    PictureBox pb = new PictureBox();
                    pb.Image = Image.FromFile(PPath);
                    pb.Image.Save(a + "\\Wallpaper1.bmp", ImageFormat.Bmp);
                    pb.Dispose();
                    SystemParametersInfo(SPI_SETDESKWALLPAPER, 0, PPath, 1);

                }
                else
                {
                    string SystemPath = Environment.SystemDirectory;//获取系统路径
                    string path = SystemPath + "\\" + SFileName + ".bmp";
                    FileInfo fi = new FileInfo(path);
                    if (fi.Exists)
                    {
                        fi.Delete();
                        PictureBox pb = new PictureBox();
                        pb.Image = Image.FromFile(PPath);
                        pb.Image.Save(SystemPath + "\\" + SFileName + ".bmp", ImageFormat.Bmp);
                        pb.Image.Save(a + "\\Wallpaper1.bmp", ImageFormat.Bmp);
                        pb.Dispose();

                    }
                    else
                    {
                        PictureBox pb = new PictureBox();
                        pb.Image = Image.FromFile(PPath);
                        pb.Image.Save(SystemPath + "\\" + SFileName + ".bmp", ImageFormat.Bmp);
                        pb.Image.Save(a + "\\Wallpaper1.bmp", ImageFormat.Bmp);
                        pb.Dispose();
                    }
                    
                    SystemParametersInfo(SPI_SETDESKWALLPAPER, 0, path, 1);
                }
                toolStripButton4_Click(sender, e);
            }
            catch
            { 
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                string strName = Application.ExecutablePath;
                if (!System.IO.File.Exists(strName))
                    return;
                string strnewName = strName.Substring(strName.LastIndexOf("\\") + 1);
                RegistryKey RKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                if (RKey == null)
                    RKey = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run");
                RKey.SetValue(strnewName, strName);

                conn.Open();
                OleDbCommand cmd = new OleDbCommand("update tb_check set KJ=1 where ID=1", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            else
            {
                string strName = Application.ExecutablePath;
                if (!System.IO.File.Exists(strName))
                    return;
                string strnewName = strName.Substring(strName.LastIndexOf("\\") + 1);
                RegistryKey RKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                if (RKey == null)
                    RKey = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run");
                RKey.DeleteValue(strnewName,false);

                conn.Open();
                OleDbCommand cmd = new OleDbCommand("update tb_check set KJ=0 where ID=1", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }
        
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            RegistryKey reg;
            if (checkBox1.Checked == true)
            {
                reg = Registry.LocalMachine;
                reg = reg.CreateSubKey(@"SYSTEM\CurrentControlSet\Services\Cdrom");
                reg.SetValue("AutoRun", 0, RegistryValueKind.DWord);
                reg.Close();

                conn.Open();
                OleDbCommand cmd = new OleDbCommand("update tb_check set GP=1 where ID=1", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            else
            {
                reg = Registry.LocalMachine;
                reg = reg.CreateSubKey(@"SYSTEM\CurrentControlSet\Services\Cdrom");
                reg.SetValue("AutoRun", 1, RegistryValueKind.DWord);
                reg.Close();

                conn.Open();
                OleDbCommand cmd = new OleDbCommand("update tb_check set GP=0 where ID=1", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        private void frmCony_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)//新建发送到菜单
        {
            string sendtostr = Environment.GetFolderPath(Environment.SpecialFolder.SendTo);
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                string px = folderBrowserDialog1.SelectedPath;
                string FolderName = "";
                if (px.Length != 3)
                {
                    FolderName = px.Substring(px.LastIndexOf("\\") + 1);
                }
                else
                {
                    FolderName = "磁盘" + px.Remove(px.LastIndexOf(":"));
                }
                //创建快捷方式
                //建立对象
                WshShell shell = new WshShell();
                //生成快捷方式文件，指定路径及文件名
                IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(sendtostr + "\\" + FolderName + ".lnk");
                //快捷方式指向的目标
                shortcut.TargetPath = px;
                //起始目录
                shortcut.WorkingDirectory = System.Environment.CurrentDirectory;
                //窗口类型
                shortcut.WindowStyle = 1;
                //描述
                shortcut.Description = "my Application";
                //图标
                shortcut.IconLocation = System.Environment.SystemDirectory + "\\" + "shell32.dll, 165";
                //保存，注意一定要保存，否则无效
                shortcut.Save();
            }
            toolStripButton4_Click(sender, e);
        }

        private void pictureBox6_Click(object sender, EventArgs e)//删除发送到菜单
        {
            if (listView5.SelectedItems.Count == 0)
            { }
            else
            {
                string sendtostr = Environment.GetFolderPath(Environment.SpecialFolder.SendTo);
                string fname = listView5.SelectedItems[0].Text;
                ArrayList al = new ArrayList();
                DirectoryInfo di = new DirectoryInfo(sendtostr);
                FileSystemInfo[] fsi = di.GetFileSystemInfos();
                for (int i = 0; i < fsi.Length; i++)
                {
                    if (fsi[i].ToString().Substring(fsi[i].ToString().LastIndexOf(".") + 1) != "lnk")
                    {
                        al.Add(fsi[i].ToString().Remove(fsi[i].ToString().LastIndexOf(".")));
                    }
                }
                bool check = true;
                for (int j = 0; j < al.Count; j++)
                {
                    if (al[j].ToString() == fname)
                    {
                        check = false;
                    }
                }
                if (check)
                {
                    System.IO.FileInfo fi = new FileInfo(sendtostr + "\\" + fname + ".lnk");
                    fi.Delete();
                }
            }
            toolStripButton4_Click(sender, e);
        }

        private void pictureBox8_Click(object sender, EventArgs e)//删除桌面壁纸
        {
            if (listView4.SelectedItems.Count != 0)
            {
                try
                {
                    string DelFile = listView4.SelectedItems[0].SubItems[2].Text;
                    string fName = DelFile.Substring(DelFile.LastIndexOf("\\") + 1, DelFile.Length - DelFile.LastIndexOf("\\") - 1);
                    FileInfo fi = new FileInfo(PicPath + "\\" + fName);
                    if (fi.Exists)
                    {
                        fi.Delete();
                        toolStripButton4_Click(sender, e);
                    }
                    else
                    {
                        toolStripButton4_Click(sender, e);
                    }
                    pictureBox1.Image = null;
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)//添加桌面壁纸
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string MyPicPath = openFileDialog1.FileName;
                string MyPicName = MyPicPath.Substring(MyPicPath.LastIndexOf("\\") + 1, MyPicPath.Length - MyPicPath.LastIndexOf("\\") - 1);
                MyPicName = MyPicName.Remove(MyPicName.LastIndexOf("."));

                ig = Image.FromFile(MyPicPath);
                ImageInfo[0] = MyPicName;
                ImageInfo[1] = ig.Width.ToString() + "×" + ig.Height.ToString();
                ImageInfo[2] = MyPicPath;
                lvi = new ListViewItem(ImageInfo, "pic");
                listView4.Items.Add(lvi);
                System.IO.File.Copy(MyPicPath, PicPath + "\\" + MyPicPath.Substring(MyPicPath.LastIndexOf("\\") + 1, MyPicPath.Length - MyPicPath.LastIndexOf("\\") - 1), true);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)//任务管理器
        {
            tbcProcess.Visible = true;
            tbcProcess.Dock = DockStyle.Fill;
            tbcSY.Visible = false;
            tbcClear.Visible = false;
            tbcXX.Visible = false;
            getProcessInfo();
            getWindowsInfo();
        }

        private void pictureBox3_Click(object sender, EventArgs e)//重启电脑
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

        private void pictureBox4_Click(object sender, EventArgs e)//设置密码
        {
            frmSetPassword setpass = new frmSetPassword();
            setpass.ShowDialog();
        }

    }
}
