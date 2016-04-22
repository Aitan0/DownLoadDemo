using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using System.Collections;
using System.Threading;
using System.Data.OleDb;
using ScreenKinescope.ClassFolder;
namespace ScreenKinescope
{
    public partial class frmVideoManager : Form
    {
        BaseClass bc = new BaseClass();
        public class AVIUtil
        { 
             [StructLayout(LayoutKind.Sequential, Pack = 1)] 
             struct BITMAPFILEHEADER 
             { 
                 public ushort bfType; 
                 public uint bfSize; 
                 public ushort bfReserved1; 
                 public ushort bfReserved2; 
                 public uint bfOffBits; 
             } 
             [StructLayout(LayoutKind.Sequential, Pack = 1)] 
             struct BITMAPINFOHEADER 
             { 
                 public uint biSize; 
                 public int biWidth; 
                 public int biHeight; 
                 public ushort biPlanes; 
                 public ushort biBitCount; 
                 public uint biCompression; 
                 public uint biSizeImage; 
                 public int biXPelsPerMeter; 
                 public int biYPelsPerMeter; 
                 public uint biClrUsed; 
                 public uint biClrImportant; 
                 public const int BI_RGB = 0; 
             } 
             const uint DIB_RGB_COLORS = 0; 
             const uint DIB_PAL_COLORS = 1;  
            /**//// <summary> 
            /// 对象转换 
            /// </summary> 
            /// <param name="pBITMAPINFOHEADER"></param> 
            /// <returns></returns> 
                   public static Bitmap ToBitmap(IntPtr pBITMAPINFOHEADER) 
                   { 
                       unsafe 
                       { 
                           BITMAPINFOHEADER* pbmi = (BITMAPINFOHEADER*)pBITMAPINFOHEADER; 
                           BITMAPFILEHEADER pbmfi; 
                           pbmfi.bfType = (int)'M' << 8 | (int)'B'; 
                           pbmfi.bfOffBits = (uint)(sizeof(BITMAPFILEHEADER) + sizeof(BITMAPINFOHEADER)); 
                           pbmfi.bfSize = pbmfi.bfOffBits + pbmi->biSizeImage; 

                           MemoryStream stream = new MemoryStream(); 
                           BinaryWriter bw = new BinaryWriter(stream); 
                           byte[] data = new byte[sizeof(BITMAPFILEHEADER)]; 
                           Marshal.Copy((IntPtr)(&pbmfi), data, 0, data.Length); 
                           bw.Write(data); 

                           data = new byte[sizeof(BITMAPINFOHEADER)]; 
                           Marshal.Copy(pBITMAPINFOHEADER, data, 0, data.Length); 
                           bw.Write(data); 

                           data = new byte[pbmi->biSizeImage]; 
                           ++pbmi; 
                           Marshal.Copy((IntPtr)pbmi, data, 0, data.Length); 
                           bw.Write(data); 
                           bw.Flush(); 
                           bw.BaseStream.Position = 0; 

                           return new Bitmap(bw.BaseStream); 
                       } 
                   } 
               } 

        /**//// <summary> 
        /// AviFile,用于AVI文件处理 
        /// </summary> 
        public class AviFile : IDisposable 
        { 
            const string AVIFILE32 = "AVIFIL32"; 
            const int AVIGETFRAMEF_BESTDISPLAYFMT = 1; 

            internal enum OpenFileFlags : uint 
            { 
                OF_READ = 0x00000000, 
                OF_WRITE = 0x00000001, 
                OF_READWRITE = 0x00000002, 
                OF_SHARE_COMPAT = 0x00000000, 
                OF_SHARE_EXCLUSIVE = 0x00000010, 
                OF_SHARE_DENY_WRITE = 0x00000020, 
                OF_SHARE_DENY_READ = 0x00000030, 
                OF_SHARE_DENY_NONE = 0x00000040, 
                OF_PARSE = 0x00000100, 
                OF_DELETE = 0x00000200, 
                OF_VERIFY = 0x00000400, 
                OF_CANCEL = 0x00000800, 
                OF_CREATE = 0x00001000, 
                OF_PROMPT = 0x00002000, 
                OF_EXIST = 0x00004000, 
                OF_REOPEN = 0x00008000, 
            } 
            [DllImport(AVIFILE32)] 
            extern internal static void AVIFileInit(); 
            [DllImport(AVIFILE32)] 
            extern internal static void AVIFileExit(); 
            [DllImport(AVIFILE32)] 
            extern internal static uint AVIFileOpen(out IntPtr ppfile, string szFile, OpenFileFlags mode, IntPtr pclsidHandler); 
            [DllImport(AVIFILE32)] 
            extern internal static int AVIFileRelease(IntPtr pfile); 
            [DllImport(AVIFILE32)] 
            extern internal static uint AVIFileGetStream(IntPtr pfile, out IntPtr ppavi, uint fccType, int lParam); 
            [DllImport(AVIFILE32)] 
            extern internal static int AVIStreamRelease(IntPtr pavi); 
            [DllImport(AVIFILE32)] 
            extern internal static IntPtr AVIStreamGetFrameOpen(IntPtr pavi, int lpbiWanted); 
            [DllImport(AVIFILE32)] 
            extern internal static IntPtr AVIStreamGetFrame(IntPtr pgf, int lPos); 
            [DllImport(AVIFILE32)] 
            extern internal static int AVIStreamLength(IntPtr pavi); 
            [DllImport(AVIFILE32)] 
            extern internal static uint AVIStreamGetFrameClose(IntPtr pget); 
            static uint mmioFOURCC(char c0, char c1, char c2, char c3) 
            { 
                return (uint)c3 << 24 | (uint)c2 << 16 | (uint)c1 << 8 | (uint)c0; 
            } 
            static readonly uint streamtypeVIDEO = mmioFOURCC('v', 'i', 'd', 's'); 
            static readonly uint streamtypeAUDIO = mmioFOURCC('a', 'u', 'd', 's'); 
            static readonly uint streamtypeMIDI = mmioFOURCC('m', 'i', 'd', 's'); 
            static readonly uint streamtypeTEXT = mmioFOURCC('t', 'x','t', 's'); 
            IntPtr aviFile = IntPtr.Zero; 
            IntPtr aviStream = IntPtr.Zero; 
            bool disposed = false; 
            public static void Initialize() 
            { 
                AVIFileInit(); 
            } 
            public static void Terminate() 
            { 
                AVIFileExit(); 
            } 
            public AviFile(string filename) 
            { 
                uint result; 
                result = AVIFileOpen(out aviFile, filename, OpenFileFlags.OF_READ, IntPtr.Zero); 
                if (result != 0) 
                { 
                    Release(); 
                    throw new Exception("AVIFileOpen failure."); 
                } 

                result = AVIFileGetStream(aviFile, out aviStream, streamtypeVIDEO, 0); 
                if (result != 0) 
                { 
                    Release(); 
                    throw new Exception("AVIFileGetStream failure."); 
                } 
            } 
            AviFile() 
            { 
                Dispose(false); 
            } 
            void Release() 
            { 
                if (aviStream != IntPtr.Zero) 
                { 
                    AVIStreamRelease(aviStream); 
                    aviStream = IntPtr.Zero; 
                } 

                if (aviFile != IntPtr.Zero) 
                { 
                    AVIFileRelease(aviFile); 
                    aviFile = IntPtr.Zero; 
                } 
            } 
            public int GetMaxFrameCount() 
            { 
                if (aviStream == IntPtr.Zero) 
                    throw new InvalidOperationException(); 
                return AVIStreamLength(aviStream); 
            } 
            public Bitmap GetFrame(int no) 
            { 
                if (aviStream == IntPtr.Zero) 
                    throw new InvalidOperationException(); 

                IntPtr frame = IntPtr.Zero; 
                try 
                { 
                    frame = AVIStreamGetFrameOpen(aviStream, AVIGETFRAMEF_BESTDISPLAYFMT); 
                    IntPtr pbmi = AVIStreamGetFrame(frame, no); 
                    return AVIUtil.ToBitmap(pbmi); 

                } 
                finally 
                { 
                    if (frame != IntPtr.Zero) 
                        AVIStreamGetFrameClose(frame); 
                } 
            } 
            protected void Dispose(bool disposing) 
            { 
                if (disposed) 
                    return; 
                disposed = true; 
                Release(); 
            } 
            public void Dispose() 
            { 
                //不让垃圾回收器终止指定对象(即不将指定对象调入终止序列中) 
                GC.SuppressFinalize(this); 
                Dispose(true); 
            } 
        } 

        public frmVideoManager()
        {
            InitializeComponent();
        }

        private void frmVideoManager_Load(object sender, EventArgs e)
        {
            
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)//判断是否选择了文件
            {
                tstbPath.Text = openFileDialog1.FileName;//显示选择的视频文件
                toolStripButton7.Enabled = true;//将分解按钮设置为可用
            }
        }
        int playcheck = 0;
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            td.Abort();
            if (playcheck == 0)
            {
                toolStripButton3.Enabled = true;
                toolStripButton4.Enabled = true;
                toolStripButton2.Enabled = false;
                toolStripButton5.Enabled = true;
                toolStripButton6.Enabled = true;
                trackBar1.Value = 0;
                flag = 1;
                timer1.Start();
            }
            else
            {
                toolStripButton3.Enabled = true;
                toolStripButton4.Enabled = true;
                toolStripButton2.Enabled = false;
                toolStripButton5.Enabled = true;
                toolStripButton6.Enabled = true;
                timer1.Start();
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            toolStripButton3.Enabled = false;
            toolStripButton2.Enabled = true;
            timer1.Stop();
            playcheck = 1;
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            tlsNow.Text = tslframe.Text;
            trackBar1.Value = ls;
            timer1.Stop();
            toolStripButton3.Enabled = false;
            toolStripButton4.Enabled = false;
            toolStripButton2.Enabled = true;
            flag = 1;
             
        }
        public static ArrayList al = new ArrayList();
        private void delfolder()
        {
            try
            {
                string strg = Application.StartupPath.ToString();
                strg = strg.Substring(0, strg.LastIndexOf("\\"));
                strg = strg.Substring(0, strg.LastIndexOf("\\"));
                strg += @"\ConverrtAviToBmp";
                DirectoryInfo DInfo = new DirectoryInfo(strg);
                FileSystemInfo[] dinfo = DInfo.GetFileSystemInfos();
                for (int i = 0; i < dinfo.Length; i++)
                {
                    string filepath = strg + "\\" + dinfo[i].ToString();
                    Scripting.FileSystemObject fso=new Scripting.FileSystemObject();
                    fso.DeleteFile(filepath,true);
                }
            }
            catch
            {
                delfolder();
            }
        }

        public int ss = 0;
        
        private void convertavi()
        {
            try
            {
                string strg = Application.StartupPath.ToString();
                strg = strg.Substring(0, strg.LastIndexOf("\\"));
                strg = strg.Substring(0, strg.LastIndexOf("\\"));
                strg += @"\ConverrtAviToBmp";
                al.Clear();
                AviFile.Initialize();
                string filename = tstbPath.Text.Trim();
                using (AviFile avi = new AviFile(filename))
                {
                    int max = avi.GetMaxFrameCount();
                    for (int i = 0; i < max; ++i)
                    {
                        Thread.Sleep(50);
                        Bitmap bmp = avi.GetFrame(i);
                        bmp.Save(strg + "\\" + i + ".bmp");
                        
                        al.Add(strg + "\\" + i + ".bmp");
                        bmp.Dispose();
                        tslfenjie.Text ="正在解析..."+(i+1)* 100 /max+ "%";
                        ss++;
                    }
                    
                }
                AviFile.Terminate();
                tslfenjie.Visible = false;
                
                toolStripButton2.Enabled = true;
            }
            catch
            {
                //convertavi();
            }
        }
        public int ls;
        private void tstbPath_TextChanged(object sender, EventArgs e)
        {
            toolStripButton7.Enabled = true;
        }
        static int flag = 1;

        public string AllTime;

        private void timer1_Tick(object sender, EventArgs e)
        {
            tslframe.Text = ls.ToString();
            trackBar1.Minimum = 0;
            trackBar1.Maximum = ls;
            if (flag <=al.Count)
            {
                trackBar1.Value = flag;
                int aaa = al.Count;
                pictureBox1.Image = Image.FromFile(al[flag-1].ToString());
                tlsNow.Text = trackBar1.Value.ToString();
            }
            flag++;
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            numericUpDown1.Value = trackBar1.Value;
            
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            numericUpDown2.Value = trackBar1.Value;
        }
        BaseClass.AVIWriter aviWriter;
        Bitmap avi_frame;

        private void HCAvi()
        {
            tslfenjie.Visible = true;
            aviWriter = new BaseClass.AVIWriter();
            Image a = Image.FromFile(al[0].ToString());
            avi_frame = aviWriter.Create(strpath, 1, a.Width,a.Height);
            for (int i = (int)(numericUpDown1.Value - 1); i <numericUpDown2.Value; i++)
            {
                Thread.Sleep(30);
                //获得图像
                Bitmap cache = new Bitmap(Image.FromFile(al[i].ToString()));
                //由于转化为avi后呈现相反，所以翻转
                cache.RotateFlip(RotateFlipType.Rotate180FlipX);
                //载入图像
                aviWriter.LoadFrame(cache);
                aviWriter.AddFrame();
                cache.Dispose();
                tslfenjie.Text = "正在分割..." + (int)((i - numericUpDown1.Value)* 100 / (numericUpDown2.Value  - numericUpDown1.Value)) + "%";
            }
            a.Dispose();
            aviWriter.Close();
            avi_frame.Dispose();
            tslfenjie.Text = "分割成功";
        }
       

        Thread td;
        private void toolStripButton7_Click(object sender, EventArgs e)
        {

            try
            {
                AviFile avi = new AviFile(tstbPath.Text.Trim());
                ls = avi.GetMaxFrameCount();
                td = new Thread(new ThreadStart(convertavi));
                td.Start();
                tslfenjie.Visible = true;
                numericUpDown1.Maximum = ls;
                numericUpDown1.Minimum = 0;

                numericUpDown2.Maximum = ls;
                numericUpDown2.Value = ls;
                numericUpDown2.Minimum = 0;

                numericUpDown3.Maximum = ls;
                numericUpDown3.Minimum = 0;

                tslframe.Text = ls.ToString();
                toolStripButton7.Enabled = false;
                lblDuration.Text = ls.ToString() + "帧";
                FileInfo fi = new FileInfo(tstbPath.Text.Trim());
                double x = fi.Length / 1024;
                lblFileSize.Text = x.ToString() + "KB";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            timer1.Stop();
            flag = trackBar1.Value;
            timer1.Start();
        }
        string strpath = "";
        private void pictureBox2_Click(object sender, EventArgs e)//分割
        {
            try
            {
                if (numericUpDown2.Value == 0 && numericUpDown1.Value == 0 || numericUpDown2.Value == ls && numericUpDown1.Value == 0||numericUpDown1.Value==0)
                { }
                else
                {
                    if (numericUpDown2.Value - numericUpDown1.Value < 0)
                    {
                        MessageBox.Show("选择结束帧", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else
                    {
                        if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                        {
                            strpath = saveFileDialog1.FileName;
                            FileInfo fi = new FileInfo(strpath);
                            if (fi.Exists)
                            {
                                MessageBox.Show("文件存在", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            }
                            else
                            {
                                Thread td = new Thread(new ThreadStart(HCAvi));
                                td.Start();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)//关闭
        {
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)//定位
        {
            if (trackBar1.Value == 0)
            { }
            else
            {
                flag = (int)numericUpDown3.Value;
                trackBar1.Value = (int)numericUpDown3.Value;
                int i = al.Count;
                pictureBox1.Image = Image.FromFile(al[flag - 1].ToString());
                tlsNow.Text = flag.ToString();
                timer1.Stop();
                toolStripButton3_Click(sender, e);
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)//前一帧
        {
            if (trackBar1.Value != 0)
            {
                trackBar1.Value -= 1;
                flag = trackBar1.Value;
                pictureBox1.Image = Image.FromFile(al[flag - 1].ToString());
                tlsNow.Text = flag.ToString();
                timer1.Stop();
                toolStripButton3_Click(sender, e);

            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)//后一帧
        {
            if (trackBar1.Value != ls)
            {
                trackBar1.Value += 1;
                flag = trackBar1.Value;
                pictureBox1.Image = Image.FromFile(al[flag - 1].ToString());
                tlsNow.Text = flag.ToString();
                timer1.Stop();
                toolStripButton3_Click(sender, e);
            }
        }

        private void frmVideoManager_FormClosed(object sender, FormClosedEventArgs e)
        {
            pictureBox1.Image = null;
            delfolder();
        }
    }
}