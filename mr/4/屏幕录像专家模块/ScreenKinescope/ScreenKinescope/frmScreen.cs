using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;
using System.Drawing.Imaging;
using System.IO;
using System.Collections;
using System.Data.OleDb;
using ScreenKinescope.ClassFolder;
namespace ScreenKinescope
{




    public partial class frmScreen : Form
    {
        public frmScreen()
        {
            InitializeComponent();
            
        }
        BaseClass bc = new BaseClass();

        #region 图片合成AVI
        public class AVIWriter
        {
            
            const string AVIFILE32 = "AVIFIL32";
            private int _pfile = 0;
            private IntPtr _ps = new IntPtr(0);
            private IntPtr _psCompressed = new IntPtr(0);
            private UInt32 _frameRate = 0;
            private int _count = 0;
            private UInt32 _width = 0;
            private UInt32 _stride = 0;
            private UInt32 _height = 0;
            //avi标识
            private UInt32 _fccType = 1935960438; // vids
            private UInt32 _fccHandler = 808810089;// IV50
            private Bitmap _bmp;
            [DllImport(AVIFILE32)]
            private static extern void AVIFileInit();
            [DllImport(AVIFILE32)]
            private static extern int AVIFileOpenW(ref int ptr_pfile, [MarshalAs(UnmanagedType.LPWStr)]string fileName, int flags, int dummy);
            [DllImport(AVIFILE32)]
            private static extern int AVIFileCreateStream(int ptr_pfile, out IntPtr ptr_ptr_avi, ref AVISTREAMINFOW ptr_streaminfo);
            [DllImport(AVIFILE32)]
            private static extern int AVIMakeCompressedStream(out IntPtr ppsCompressed, IntPtr aviStream, ref AVICOMPRESSOPTIONS ao, int dummy);
            [DllImport(AVIFILE32)]
            private static extern int AVIStreamSetFormat(IntPtr aviStream, Int32 lPos, ref BITMAPINFOHEADER lpFormat, Int32 cbFormat);
            [DllImport(AVIFILE32)]
            unsafe private static extern int AVISaveOptions(int hwnd, UInt32 flags, int nStreams, IntPtr* ptr_ptr_avi, AVICOMPRESSOPTIONS** ao);

            [DllImport(AVIFILE32)]
            private static extern int AVIStreamWrite(IntPtr aviStream, Int32 lStart, Int32 lSamples, IntPtr lpBuffer, Int32 cbBuffer, Int32 dwFlags, Int32 dummy1, Int32 dummy2);

            [DllImport(AVIFILE32)]
            private static extern int AVIStreamRelease(IntPtr aviStream);

            [DllImport(AVIFILE32)]
            private static extern int AVIFileRelease(int pfile);

            [DllImport(AVIFILE32)]
            private static extern void AVIFileExit();

            [StructLayout(LayoutKind.Sequential, Pack = 1)]
            private struct AVISTREAMINFOW
            {
                public UInt32 fccType;
                public UInt32 fccHandler;
                public UInt32 dwFlags;
                public UInt32 dwCaps;
                public UInt16 wPriority;
                public UInt16 wLanguage;
                public UInt32 dwScale;
                public UInt32 dwRate;
                public UInt32 dwStart;
                public UInt32 dwLength;
                public UInt32 dwInitialFrames;
                public UInt32 dwSuggestedBufferSize;
                public UInt32 dwQuality;
                public UInt32 dwSampleSize;
                public UInt32 rect_left;
                public UInt32 rect_top;
                public UInt32 rect_right;
                public UInt32 rect_bottom;
                public UInt32 dwEditCount;
                public UInt32 dwFormatChangeCount;
                public UInt16 szName0;
                public UInt16 szName1;
                public UInt16 szName2;
                public UInt16 szName3;
                public UInt16 szName4;
                public UInt16 szName5;
                public UInt16 szName6;
                public UInt16 szName7;
                public UInt16 szName8;
                public UInt16 szName9;
                public UInt16 szName10;
                public UInt16 szName11;
                public UInt16 szName12;
                public UInt16 szName13;
                public UInt16 szName14;
                public UInt16 szName15;
                public UInt16 szName16;
                public UInt16 szName17;
                public UInt16 szName18;
                public UInt16 szName19;
                public UInt16 szName20;
                public UInt16 szName21;
                public UInt16 szName22;
                public UInt16 szName23;
                public UInt16 szName24;
                public UInt16 szName25;
                public UInt16 szName26;
                public UInt16 szName27;
                public UInt16 szName28;
                public UInt16 szName29;
                public UInt16 szName30;
                public UInt16 szName31;
                public UInt16 szName32;
                public UInt16 szName33;
                public UInt16 szName34;
                public UInt16 szName35;
                public UInt16 szName36;
                public UInt16 szName37;
                public UInt16 szName38;
                public UInt16 szName39;
                public UInt16 szName40;
                public UInt16 szName41;
                public UInt16 szName42;
                public UInt16 szName43;
                public UInt16 szName44;
                public UInt16 szName45;
                public UInt16 szName46;
                public UInt16 szName47;
                public UInt16 szName48;
                public UInt16 szName49;
                public UInt16 szName50;
                public UInt16 szName51;
                public UInt16 szName52;
                public UInt16 szName53;
                public UInt16 szName54;
                public UInt16 szName55;
                public UInt16 szName56;
                public UInt16 szName57;
                public UInt16 szName58;
                public UInt16 szName59;
                public UInt16 szName60;
                public UInt16 szName61;
                public UInt16 szName62;
                public UInt16 szName63;
            }

            [StructLayout(LayoutKind.Sequential, Pack = 1)]
            private struct AVICOMPRESSOPTIONS
            {
                public UInt32 fccType;
                public UInt32 fccHandler;
                public UInt32 dwKeyFrameEvery;

                public UInt32 dwQuality;
                public UInt32 dwBytesPerSecond;

                public UInt32 dwFlags;
                public IntPtr lpFormat;
                public UInt32 cbFormat;
                public IntPtr lpParms;
                public UInt32 cbParms;
                public UInt32 dwInterleaveEvery;
            }

            [StructLayout(LayoutKind.Sequential, Pack = 1)]
            public struct BITMAPINFOHEADER
            {
                public UInt32 biSize;
                public Int32 biWidth;
                public Int32 biHeight;
                public Int16 biPlanes;
                public Int16 biBitCount;
                public UInt32 biCompression;
                public UInt32 biSizeImage;
                public Int32 biXPelsPerMeter;
                public Int32 biYPelsPerMeter;
                public UInt32 biClrUsed;
                public UInt32 biClrImportant;
            }

            public class AviException : ApplicationException
            {
                public AviException(string s) : base(s) { }
                public AviException(string s, Int32 hr): base(s)
                {

                    if (hr == AVIERR_BADPARAM)
                    {
                        err_msg = "AVIERR_BADPARAM";
                    }
                    else
                    {
                        err_msg = "unknown";
                    }
                }

                public string ErrMsg()
                {
                    return err_msg;
                }
                private const Int32 AVIERR_BADPARAM = -2147205018;
                private string err_msg;
            }

            public Bitmap Create(string fileName, UInt32 frameRate, int width, int height)
            {
                _frameRate = frameRate;
                _width = (UInt32)width;
                _height = (UInt32)height;
                _bmp = new Bitmap(width, height, PixelFormat.Format24bppRgb);
                //锁定为24位位图
                BitmapData bmpDat = _bmp.LockBits(new Rectangle(0, 0, width,height), ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
                _stride = (UInt32)bmpDat.Stride;
                _bmp.UnlockBits(bmpDat);
                AVIFileInit();
                int hr = AVIFileOpenW(ref _pfile, fileName, 4097, 0);
                if (hr != 0)
                {
                    throw new AviException("Create错误!");
                }
                CreateStream();
                SetOptions();
                return _bmp;
            }

            public void AddFrame()
            {

                BitmapData bmpDat = _bmp.LockBits(
                    new Rectangle(0, 0, (int)_width, (int)_height),
                    ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
                    int hr = AVIStreamWrite(_psCompressed, _count, 1,
                    bmpDat.Scan0,
                    (Int32)(_stride * _height),
                    0,
                    0,
                    0);

                if (hr != 0)
                {
                    throw new AviException("AVIStreamWrite");
                }

                _bmp.UnlockBits(bmpDat);
                
                _count++;
            }

            public void LoadFrame(Bitmap nextframe)
            {

                _bmp = new Bitmap(nextframe);
            }

            public void Close()
            {
                AVIStreamRelease(_ps);
                AVIStreamRelease(_psCompressed);
                AVIFileRelease(_pfile);
                AVIFileExit();
            }

            /**/
            /// <summary>
            /// 创建流文件
            /// </summary>
            private void CreateStream()
            {
                AVISTREAMINFOW strhdr = new AVISTREAMINFOW();
                strhdr.fccType = _fccType;
                strhdr.fccHandler = _fccHandler;
                strhdr.dwFlags = 0;
                strhdr.dwCaps = 0;
                strhdr.wPriority = 0;
                strhdr.wLanguage = 0;
                strhdr.dwScale = 1;
                strhdr.dwRate = 3;//pfs
                strhdr.dwStart = 0;
                strhdr.dwLength = 0;
                strhdr.dwInitialFrames = 0;
                strhdr.dwSuggestedBufferSize = _height * _stride;
                strhdr.dwQuality = 0xffffffff;
                strhdr.dwSampleSize = 0;
                strhdr.rect_top = 0;
                strhdr.rect_left = 0;
                strhdr.rect_bottom = _height;
                strhdr.rect_right = _width;
                strhdr.dwEditCount = 0;
                strhdr.dwFormatChangeCount = 0;
                strhdr.szName0 = 0;
                strhdr.szName1 = 0;

                int hr = AVIFileCreateStream(_pfile, out _ps, ref strhdr);

                if (hr != 0)
                {
                    throw new AviException("AVIFileCreateStream");
                }
            }

            /**/
            /// <summary>
            /// 设置参数
            /// </summary>
            unsafe private void SetOptions()
            {
                AVICOMPRESSOPTIONS opts = new AVICOMPRESSOPTIONS();
                opts.fccType = _fccType;
                opts.fccHandler = 1129730893;
                opts.dwQuality = 7500;
                opts.dwBytesPerSecond = 0;
                opts .dwFlags =12;
                opts.lpFormat = new IntPtr(0);
                opts.cbFormat = 0;
                opts.dwInterleaveEvery = 0;
                AVICOMPRESSOPTIONS* p = &opts;
                AVICOMPRESSOPTIONS** pp = &p;
                IntPtr x = _ps;
                IntPtr* ptr_ps = &x;
                //AVISaveOptions(0, 0, 1, ptr_ps, pp);
                int hr = AVIMakeCompressedStream(out _psCompressed, _ps, ref opts, 0);
                if (hr != 0)
                {
                    throw new AviException("AVIMakeCompressedStream");
                }
                BITMAPINFOHEADER bi = new BITMAPINFOHEADER();
                bi.biSize = 40;
                bi.biWidth = (Int32)_width;
                bi.biHeight = (Int32)_height;
                bi.biPlanes = 1;
                bi.biBitCount = 24;
                bi.biCompression = 0;
                bi.biSizeImage = _stride * _height;
                bi.biXPelsPerMeter = 0;
                bi.biYPelsPerMeter = 0;
                bi.biClrUsed = 0;
                bi.biClrImportant = 0;
                hr = AVIStreamSetFormat(_psCompressed, 0, ref bi, 40);
                if (hr != 0)
                {
                    throw new AviException("AVIStreamSetFormat", hr);
                }
            }
        }
        #endregion

        #region 定义快捷键
        //如果函数执行成功，返回值不为0。       
        //如果函数执行失败，返回值为0。要得到扩展错误信息，调用GetLastError。        
        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool RegisterHotKey(
        IntPtr hWnd,                //要定义热键的窗口的句柄            
        int id,                     //定义热键ID（不能与其它ID重复）                       
        KeyModifiers fsModifiers,   //标识热键是否在按Alt、Ctrl、Shift、Windows等键时才会生效         
        Keys vk                     //定义热键的内容            
    );
        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool UnregisterHotKey(
            IntPtr hWnd,                //要取消热键的窗口的句柄            
            int id                      //要取消热键的ID            
        );
        //定义了辅助键的名称（将数字转变为字符以便于记忆，也可去除此枚举而直接使用数值）        
        [Flags()]
        public enum KeyModifiers
        {
            None = 0,
            Alt = 1,
            Ctrl = 2,
            Shift = 4,
            WindowsKey = 8
        }
        #endregion

        #region 抓取带鼠标的桌面图片
        private int _X, _Y;
        [StructLayout(LayoutKind.Sequential)]
        private struct ICONINFO
        {
            public bool fIcon;
            public Int32 xHotspot;
            public Int32 yHotspot;
            public IntPtr hbmMask;
            public IntPtr hbmColor;
        }
        [StructLayout(LayoutKind.Sequential)]
        private struct CURSORINFO
        {
            public Int32 cbSize;
            public Int32 flags;
            public IntPtr hCursor;
            public Point ptScreenPos;
        }
        [DllImport("user32.dll", EntryPoint = "GetSystemMetrics")]
        private static extern int GetSystemMetrics(int mVal);
        [DllImport("user32.dll", EntryPoint = "GetCursorInfo")]
        private static extern bool GetCursorInfo(ref CURSORINFO cInfo);
        [DllImport("user32.dll", EntryPoint = "CopyIcon")]
        private static extern IntPtr CopyIcon(IntPtr hIcon);
        [DllImport("user32.dll", EntryPoint = "GetIconInfo")]
        private static extern bool GetIconInfo(IntPtr hIcon,out ICONINFO iInfo);

        AVIWriter aviWriter;
        Bitmap avi_frame;

        public int SHeight;
        public int SWidth;
        public static ArrayList al=new ArrayList();
        private Bitmap CaptureDesktop()//
        {
            try
            {
                int _CX = 0, _CY = 0;
                Bitmap _Source = new Bitmap(GetSystemMetrics(0), GetSystemMetrics(1));
                using (Graphics g = Graphics.FromImage(_Source))
                {

                        g.CopyFromScreen(0, 0, 0, 0, _Source.Size);
                        g.DrawImage(CaptureCursor(ref _CX, ref _CY), _CX, _CY);
                        g.Dispose();
                }
                _X = (800 - _Source.Width) / 2;
                _Y = (600 - _Source.Height) / 2;
                return _Source;
            }
            catch
            {
                return null;
            }
        }

        private Bitmap CaptureNoCursor()//抓取没有鼠标的桌面
        {
            Bitmap _Source = new Bitmap(GetSystemMetrics(0), GetSystemMetrics(1));
            using (Graphics g = Graphics.FromImage(_Source))
            {
                g.CopyFromScreen(0, 0, 0, 0, _Source.Size);
                g.Dispose();
            }
            return _Source;
        }

        private Bitmap CaptureCursor(ref int _CX,ref int _CY)
        {
            IntPtr _Icon;
            CURSORINFO _CursorInfo = new CURSORINFO();
            ICONINFO _IconInfo;
            _CursorInfo.cbSize = Marshal.SizeOf(_CursorInfo);
            if (GetCursorInfo(ref _CursorInfo))
            {
                if (_CursorInfo.flags == 0x00000001)
                {
                    _Icon = CopyIcon(_CursorInfo.hCursor);

                    if (GetIconInfo(_Icon, out _IconInfo))
                    {
                        _CX = _CursorInfo.ptScreenPos.X - _IconInfo.xHotspot;
                        _CY = _CursorInfo.ptScreenPos.Y - _IconInfo.yHotspot;
                        return Icon.FromHandle(_Icon).ToBitmap();
                    }
                }
            }
            return null;
        }

        #endregion

        #region 常用方法
        string strg1;
        public bool CheckCursor=true;

        public void Lx()//单击录像按钮
        {
            try
            {
                i = 0;
                al.Clear();
                strg1 = Application.StartupPath.ToString();
                strg1 = strg1.Substring(0, strg1.LastIndexOf("\\"));
                strg1 = strg1.Substring(0, strg1.LastIndexOf("\\"));
                strg1 += @"\MyPictures";
                DirectoryInfo DInfo = new DirectoryInfo(strg1);
                if (!DInfo.Exists)
                {
                    DInfo.Create();
                }
                OleDbConnection conn = bc.GetConn();
                conn.Open();
                OleDbCommand cmd = new OleDbCommand("select * from tb_VideoPath where ID=1", conn);
                OleDbDataReader sdr = cmd.ExecuteReader();
                sdr.Read();
                string Mycursor = sdr["CursorYN"].ToString().Trim();
                if (Mycursor == "显示光标")
                {
                    CheckCursor = true;
                }
                else
                {
                    CheckCursor = false;
                }
                string strg = Application.StartupPath.ToString();
                strg = strg.Substring(0, strg.LastIndexOf("\\"));
                strg = strg.Substring(0, strg.LastIndexOf("\\"));
                strg += @"\Images";
                strg += @"\录像.ico";
                this.WindowState = FormWindowState.Minimized;
                this.ShowInTaskbar = false;//使窗体不在任务栏中显示
                toolStripButton1.Enabled = false;//禁用“录制”按钮
                contextMenuStrip1.Items[0].Enabled = false;//禁用右键菜单中的“录制”按钮
                notifyIcon1.Icon = new Icon(strg);
                toolStripButton3.Enabled = true;
                timer1.Start();
                ButtonStartStatus();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ButtonStopStatus()
        {
            停止ToolStripMenuItem.Enabled = false;
            停止ToolStripMenuItem1.Enabled = false;
        }
        private void ButtonStartStatus()
        {
            停止ToolStripMenuItem.Enabled = true;
            停止ToolStripMenuItem1.Enabled = true;
        }

        private void LxStop()//停止录制
        {
            try
            {
                string strg = Application.StartupPath.ToString();
                strg = strg.Substring(0, strg.LastIndexOf("\\"));
                strg = strg.Substring(0, strg.LastIndexOf("\\"));
                strg += @"\Images";
                strg += @"\图标 (30).ico";
                notifyIcon1.Icon = new Icon(strg);
                contextMenuStrip1.Items[0].Enabled = true;
                this.ShowInTaskbar = true;
                menuStrip1.Visible = true;
                statusStrip1.Visible = true;
                this.StartPosition = FormStartPosition.CenterScreen;
                toolStripButton1.Enabled = true;
                toolStripButton3.Enabled = false;

                timer1.Stop();
                aviSaveAs();
                ButtonStopStatus();
                DeleteFolder();
                MessageBox.Show("视频保存成功！","提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DeleteFolder()
        {
            try
            {
                string str;
                str = Application.StartupPath.ToString();
                str = str.Substring(0, str.LastIndexOf("\\"));
                str = str.Substring(0, str.LastIndexOf("\\"));
                str += @"\MyPictures";
                
                DirectoryInfo DInfo = new DirectoryInfo(str);
                FileSystemInfo[] dinfo = DInfo.GetFileSystemInfos();
                for (int i = 0; i < dinfo.Length; i++)
                {
                    Scripting.FileSystemObject fso = new Scripting.FileSystemObject();
                    fso.DeleteFile(str + "\\" + dinfo[i].ToString(), true);
                }
            }
            catch
            {
                DeleteFolder();
            }
        }

        private void aviSaveAs()
        {
            try
            {
                OleDbConnection conn = bc.GetConn();
                conn.Open();
                OleDbCommand cmd = new OleDbCommand("select strPath from tb_VideoPath where ID=1", conn);
                string str = cmd.ExecuteScalar().ToString().Trim();
                FileInfo fi = new FileInfo(str);
                if (fi.Exists)
                {
                    fi.Delete();
                }
                conn.Close();
                aviWriter = new AVIWriter();
                //avi中所有图像皆不能小于width及height
                avi_frame = aviWriter.Create(str, 1, SWidth, SHeight);
                for (int i = 0; i < al.Count; i++)
                {
                    //获得图像
                    Bitmap cache = new Bitmap(Image.FromFile(al[i].ToString()));
                    //由于转化为avi后呈现相反，所以翻转
                    cache.RotateFlip(RotateFlipType.Rotate180FlipX);
                    //载入图像
                    aviWriter.LoadFrame(cache);
                    aviWriter.AddFrame();
                }
                aviWriter.Close();
                avi_frame.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        static int i = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                Bitmap a;
                if (CheckCursor)
                {
                    a = CaptureDesktop();
                }
                else
                {
                    a = CaptureNoCursor();
                }
                string picpath = strg1 + "\\" + i + ".bmp";
                if (i == 0)
                {
                    SWidth = a.Width;
                    SHeight = a.Height;
                }
                a.Save(picpath);
                al.Add(picpath);
                i++;
                RegisterHotKey(Handle, 83, KeyModifiers.Shift, Keys.E);
            }
            catch
            {}
        }

        private void toolStripButton1_Click(object sender, EventArgs e)//工具栏中的“开始录制”按钮
        {
            Lx();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)//工具栏中的“停止录制”按钮
        {
            LxStop();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            常规选项ToolStripMenuItem_Click(sender, e);
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton4_Click(object sender, EventArgs e)//工具栏中的“抓图”按钮
        {
            this.Opacity = 0;
            DirectoryInfo di = new DirectoryInfo("c:\\MyPicture");
            if (!di.Exists)
            {
                Directory.CreateDirectory("c:\\MyPicture");
            }
            string PicPath = "c:\\MyPicture\\" + DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString() + ".bmp";
            Bitmap bt = CaptureNoCursor();
            bt.Save(PicPath);
            this.Opacity = 100;
            toolStripStatusLabel1.Text = "图片保存位置：" + PicPath;
        }

        private void toolStripButton8_Click(object sender, EventArgs e)//工具栏中的“打开图片文件夹”按钮
        {
            DirectoryInfo di = new DirectoryInfo("c:\\MyPicture");
            if (!di.Exists)
            {
                Directory.CreateDirectory("c:\\MyPicture");
            }
            System.Diagnostics.Process.Start("c:\\MyPicture");
        }

        #region 菜单栏
        private void 录制ToolStripMenuItem1_Click(object sender, EventArgs e)//菜单栏中的“录制”选项
        {
            toolStripButton1_Click(sender,e);
        }

        private void 停止ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            toolStripButton3_Click(sender,e);
        }

        private void 常规选项ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGeneral general = new frmGeneral();
            general.ShowDialog();
        }
        private void 退出ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            DeleteFolder();
            Application.Exit();
        }

        private void 工具栏ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (工具栏ToolStripMenuItem.CheckState == CheckState.Checked)
            {
                工具栏ToolStripMenuItem.CheckState = CheckState.Unchecked;
                toolStrip1.Visible = false;
            }
            else
            {
                工具栏ToolStripMenuItem.CheckState = CheckState.Checked;
                toolStrip1.Visible = true;
            }
        }

        private void 状态栏ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (状态栏ToolStripMenuItem.CheckState == CheckState.Checked)
            {
                状态栏ToolStripMenuItem.CheckState = CheckState.Unchecked;
                statusStrip1.Visible = false;
            }
            else
            {
                状态栏ToolStripMenuItem.CheckState = CheckState.Checked;
                statusStrip1.Visible = true;
            }
        }

        #endregion

        protected override void WndProc(ref Message m)
        {
            const int WM_HOTKEY = 0x0312;
            //按快捷键     
            switch (m.Msg)
            {
                case WM_HOTKEY:
                    switch (m.WParam.ToInt32())
                    {
                        case 81:    //按下的是Shift+Q                   
                            Lx();
                            break;
                        case 83:    //按下的是Shift+E  
                            LxStop();
                            break;
                    }
                    break;
            }
            base.WndProc(ref m);
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            this.Activate();
            this.Show();
        }

        #region 任务栏中图标的右键菜单

        private void 录制ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripButton1_Click(sender, e);
        }

        private void 停止ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripButton3_Click(sender, e);
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteFolder();
            Application.Exit();
        }

        #endregion

        private void toolStrip1_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "就绪";
        }

        private void 打开视频文件OToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "avi文件|*.avi|wmv文件|*.wmv|所有文件|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string str = openFileDialog1.FileName;
                System.Diagnostics.Process.Start(str);
            }
        }

        private void frmScreen_Load(object sender, EventArgs e)
        {
            RegisterHotKey(Handle, 81, KeyModifiers.Shift, Keys.Q);
            ButtonStopStatus();
            this.Opacity = 0;
            Bitmap bt = CaptureNoCursor();
            pictureBox1.Image = bt;
            this.Opacity = 100;
        }

        private void frmScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            DeleteFolder();
            Application.Exit();
            notifyIcon1.Dispose();
        }

        private void frmScreen_Activated(object sender, EventArgs e)
        {
            this.Opacity=0;
            Bitmap bt = CaptureNoCursor();
            pictureBox1.Image = bt;
            this.Opacity = 100;
            RegisterHotKey(Handle, 81, KeyModifiers.Shift, Keys.Q);
        }

        private void 视频管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVideoManager manager = new frmVideoManager();
            manager.ShowDialog();
        }

        private void frmScreen_StyleChanged(object sender, EventArgs e)
        {
            RegisterHotKey(Handle, 81, KeyModifiers.Shift, Keys.Q);
        }

        private void frmScreen_Leave(object sender, EventArgs e)
        {
            //注销Id号为81的热键设定    
            UnregisterHotKey(Handle, 81);
            //注销Id号为82的热键设定       
            UnregisterHotKey(Handle, 83);
        }
    }
}