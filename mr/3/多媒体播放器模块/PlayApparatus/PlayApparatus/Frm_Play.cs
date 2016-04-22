using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;//sleep的命名空间
using System.IO;//文件及文件夹的命名空间
using System.Collections;//为ArrayList添加命名空间

namespace PlayApparatus
{
    public partial class Frm_Play : Form
    {
        public Frm_Play()
        {
            InitializeComponent();
        }

        #region  公共变量
        FrmClass Cla_FrmClass = new FrmClass();

        public static int Example_PlayPause = 0;
        public static int Example_NoncePause = 0;
        public static Point Example_BarPoint;

        public static double Example_UpD = 0;
        public static double Example_DownD = 0;
        public static string Example_UpS = "";

        public static bool Example_BarMove = false;//播放进度条是否移动

        public static bool Example_LyMove = false;
        public static bool Example_Tly = true;
        public static int Example_BendC = 0;

        public static Point Example_MusicBarPoint;//鼠标在音量按钮的位置
        public static double Example_MusicToler = 0;//声间的度量单位
        public static bool Example_MusicBarMove = false;

        public static bool Example_Rest = false;//是否静音
        public static int Example_FormShow = 0;//窗体显示
        Random rand = new Random();//定义随机变量
        #endregion

        #region  "播放"窗体接收的消息
        /// <summary>
        /// "播放"窗体接收的消息
        /// </summary>
        /// <param FileN="string">播放文件的路径</param>
        public void FrmMessage(int Sign, string Tem_Str)
        {
            switch (Sign)
            {

                case 0:
                    {
                        timer_Bend.Enabled = false;
                        timer_ShowTime.Enabled = false;
                        Example_PlayPause = 1;
                        pictureBox_Play.Image = null;
                        pictureBox_Play.Image = (Image)Properties.Resources.播放按钮;
                        pictureBox_Play.Tag = 8;

                        ((Frm_Libretto)FrmClass.F_Libretto).FrmMessage(0, 0);
                        string Tem_Lyric = FrmClass.Example_PlayPath;
                        Tem_Lyric = Tem_Lyric.Substring(0, Tem_Lyric.LastIndexOf(Convert.ToChar("."))) + ".lrc";
                        FileInfo SFInfo = new FileInfo(Tem_Lyric);

                        if (SFInfo.Exists == true)
                        {
                            FrmClass.Example_ifLy = true;
                            Cla_FrmClass.ArrayList_Close(FrmClass.Example_ArrLyric);
                            FrmClass.Example_ArrLyric = new System.Collections.ArrayList(Cla_FrmClass.LRC_Lyric(Tem_Lyric));

                            FrmClass.Example_LyC = 0;
                            string Tem_upArr = FrmClass.Example_ArrLyric[FrmClass.Example_LyC].ToString();
                            Example_UpD = Convert.ToInt32(Tem_upArr.Substring(0, Tem_upArr.IndexOf(Convert.ToChar("|")))) / 1000;
                            Example_UpS = Tem_upArr.Substring(Tem_upArr.IndexOf(Convert.ToChar("|")) + 1, Tem_upArr.Length - Tem_upArr.IndexOf(Convert.ToChar("|")) - 1);
                            Tem_upArr = FrmClass.Example_ArrLyric[FrmClass.Example_LyC + 1].ToString();
                            Example_DownD = Convert.ToInt32(Tem_upArr.Substring(0, Tem_upArr.IndexOf(Convert.ToChar("|")))) / 1000;

                            ((Frm_Libretto)FrmClass.F_Libretto).FrmMessage(Cla_FrmClass.LRC_Lyric(Tem_Lyric));
                        }
                        Example_NoncePause = 2;
                        ((Frm_Screen)FrmClass.F_Screen).FrmMessage(0, FrmClass.Example_PlayPath, this);
                        Show_BendInfo(FrmClass.Example_PlayPath);
                        Bend_State(2);
                        break;
                    }
                case 1:
                    {
                        Show_BendInfo(FrmClass.Example_PlayPath);
                        break;
                    }
            }
        }
        #endregion

        #region  显示当前文件的基本信息
        /// <summary>
        /// 显示当前文件的基本信息
        /// </summary>
        /// <param FileN="string">播放文件的路径</param>
        public void Show_BendInfo(string FileN)
        {
            Example_BendC = 0;
            listBox_BendInfo.Items.Clear();
            ArrayList Tem_ArrayBend = new ArrayList(Cla_FrmClass.GetFileDouble(FileN));
            for (int i = 0; i < Tem_ArrayBend.Count; i++)
            {
                listBox_BendInfo.Items.Add(Tem_ArrayBend[i].ToString());
            }
            timer_Bend.Enabled = true;
        }
        #endregion

        #region  显示当前的播放状态
        /// <summary>
        /// 显示当前的播放状态
        /// </summary>
        /// <param n="int">标识</param>
        public void Bend_State(int n)
        {
            switch (n)
            {
                case 0:
                case 2:
                    {
                        label_State.Text = "播放";
                        break;
                    }
                case 1:
                    {
                        label_State.Text = "暂停";
                        break;
                    }
                case 3:
                    {
                        label_State.Text = "停止";
                        break;
                    }
            }
        }
        #endregion

        #region  播放文件的上下移动
        /// <summary>
        /// 播放文件的上下移动
        /// </summary>
        /// <param n="int">标识是前进按钮还是后退按钮</param>
        public void MovePlayFile(int n)
        {
            int Tem_n = 0;
            int Tem_count = ((Frm_ListBox)FrmClass.F_List).listView_List.Items.Count - 1;
            if (!(n == 7 || n == 10))
                return;
            if (n == 7)
            {
                Tem_n = FrmClass.Example_ListMark - 1;
                if (Tem_n < 0)
                    return;
            }
            if (n == 10)
            {
                Tem_n = FrmClass.Example_ListMark + 1;
                if (Tem_n > Tem_count)
                    return;
            }
            timer_Bend.Enabled = false;
            timer_ShowTime.Enabled = false;
            if (FrmClass.Example_ListMark < 0)
                FrmClass.Example_ListMark = 0;
            if (FrmClass.Example_ListMark > ((Frm_ListBox)FrmClass.F_List).listView_List.Items.Count-1)
                FrmClass.Example_ListMark = ((Frm_ListBox)FrmClass.F_List).listView_List.Items.Count - 1;
            ((Frm_ListBox)FrmClass.F_List).listView_List.Items[FrmClass.Example_ListMark].BackColor = Color.DarkSeaGreen;
            ((Frm_ListBox)FrmClass.F_List).listView_List.Items[FrmClass.Example_ListMark].Selected = false;
            ((Frm_ListBox)FrmClass.F_List).listView_List.Items[Tem_n].Selected = true;
            ((Frm_ListBox)FrmClass.F_List).listView_List.SelectedItems[0].BackColor = Color.DarkGreen;
            FrmClass.Example_PlayPath = ((Frm_ListBox)FrmClass.F_List).listView_List.SelectedItems[0].SubItems[3].Text.Trim();
            
            if (!File.Exists(FrmClass.Example_PlayPath))
            {
                MessageBox.Show("没有找到该媒体文件。");
                FrmClass.Example_ListMark = ((Frm_ListBox)FrmClass.F_List).listView_List.SelectedItems[0].Index;
                return;
            }

            ((Frm_Libretto)FrmClass.F_Libretto).FrmMessage(0, 0);
            string Tem_Lyric = FrmClass.Example_PlayPath;
            Tem_Lyric = Tem_Lyric.Substring(0, Tem_Lyric.LastIndexOf(Convert.ToChar("."))) + ".lrc";
            FileInfo SFInfo = new FileInfo(Tem_Lyric);
            if (SFInfo.Exists == true)
            {
                FrmClass.Example_ifLy = true;
                Cla_FrmClass.ArrayList_Close(FrmClass.Example_ArrLyric);
                FrmClass.Example_ArrLyric = new System.Collections.ArrayList(Cla_FrmClass.LRC_Lyric(Tem_Lyric));

                FrmClass.Example_LyC = 0;
                ((Frm_Libretto)FrmClass.F_Libretto).FrmMessage(Cla_FrmClass.LRC_Lyric(Tem_Lyric));
            }
            else
                FrmClass.Example_ifLy = false;

            FrmClass.Example_LyC = 0;
            ((Frm_Play)FrmClass.F_MPlay).FrmMessage(0, FrmClass.Example_PlayPath);
            ((Frm_Play)FrmClass.F_MPlay).Show_BendInfo(FrmClass.Example_PlayPath);
            //Bend_State(2);
            FrmClass.Example_ListMark = ((Frm_ListBox)FrmClass.F_List).listView_List.SelectedItems[0].Index;
        }
        #endregion

        public void SetPlayMode(int n)
        {
            switch (n)
            {
                case 2:
                    {
                        FrmMessage(0, FrmClass.Example_PlayPath);
                        break;
                    }
                case 3:
                case 4:
                    {
                        ListView Tem_List = ((Frm_ListBox)FrmClass.F_List).listView_List;
                        int tem_n = 0;
                        if (FrmClass.Example_ListMark < 0)
                            tem_n = 0;
                        else
                            tem_n = FrmClass.Example_ListMark;
                        if (FrmClass.Example_ListMark < (Tem_List.Items.Count - 1))
                        {
                            Tem_List.Items[tem_n].BackColor = Color.DarkSeaGreen;
                            Tem_List.Items[tem_n].Selected = false;
                            Tem_List.Items[tem_n].Focused = false;
                            if (FrmClass.Example_ListMark < 0)
                                tem_n = -1;
                            Tem_List.Items[tem_n + 1].Selected = true;
                            Tem_List.Items[tem_n + 1].Focused = true;
                            Tem_List.SelectedItems[0].BackColor = Color.DarkGreen;
                            FrmClass.Example_PlayPath = Tem_List.SelectedItems[0].SubItems[3].Text.Trim();
                            if (FrmClass.Example_ListMark < 0)
                                FrmClass.Example_ListMark = 0;
                            else
                                FrmClass.Example_ListMark = FrmClass.Example_ListMark + 1;
                            FrmMessage(0, FrmClass.Example_PlayPath);
                        }
                        if (n == 4 && FrmClass.Example_ListMark == (Tem_List.Items.Count - 1))
                        {
                            Tem_List.Items[tem_n].BackColor = Color.DarkSeaGreen;
                            Tem_List.Items[tem_n].Selected = false;
                            Tem_List.Items[tem_n].Focused = false;
                            Tem_List.Items[0].Selected = true;
                            Tem_List.Items[0].Focused = true;
                            Tem_List.SelectedItems[0].BackColor = Color.DarkGreen;
                            FrmClass.Example_PlayPath = Tem_List.SelectedItems[0].SubItems[3].Text.Trim();
                            FrmClass.Example_ListMark = 0;
                            FrmMessage(0, FrmClass.Example_PlayPath);
                        }
                        break;
                    }
                case 5:
                    {
                        ListView Tem_List = ((Frm_ListBox)FrmClass.F_List).listView_List;
                        int Tem_RD = rand.Next(0, Tem_List.Items.Count - 1);
                        if (Tem_RD == FrmClass.Example_ListMark)
                        {
                            FrmMessage(0, FrmClass.Example_PlayPath);
                        }
                        else
                        {
                            Tem_List.Items[FrmClass.Example_ListMark].BackColor = Color.DarkSeaGreen;
                            Tem_List.Items[FrmClass.Example_ListMark].Selected = false;
                            Tem_List.Items[FrmClass.Example_ListMark].Focused = false;
                            Tem_List.Items[Tem_RD].Selected = true;
                            Tem_List.Items[Tem_RD].Focused = true;
                            Tem_List.SelectedItems[0].BackColor = Color.DarkGreen;
                            FrmClass.Example_PlayPath = Tem_List.SelectedItems[0].SubItems[3].Text.Trim();
                            FrmClass.Example_ListMark = Tem_RD;
                            FrmMessage(0, FrmClass.Example_PlayPath);

                        }
                        break;
                    }
            }
            if (n >= 2 && n <= 5)
                Bend_State(2);
        }

        private void Frm_Play_Load(object sender, EventArgs e)
        {
            //窗体位置的初始化
            Cla_FrmClass.ImageDir();
            FrmClass.ImgDir =  FrmClass.ImgDir+ "\\Image";
            Cla_FrmClass.FrmInitialize(this);
            FrmClass.F_MPlay = this;
            Example_MusicToler = 100.0 / (panel_Sound.Width - pictureBox_SoundHold.Width);
        }

        private void Frm_Play_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void panel_Title_MouseDown(object sender, MouseEventArgs e)
        {
            int Tem_Y = 0;
            if (e.Button == MouseButtons.Left)
            {
                Cla_FrmClass.FrmBackCheck();
                Tem_Y = e.Y;
                FrmClass.FrmPoint = new Point(e.X, Tem_Y);
                FrmClass.CPoint = new Point(-e.X, -Tem_Y);
                if (FrmClass.Example_List_AdhereTo)
                {
                    Cla_FrmClass.FrmDistanceJob(this, FrmClass.F_List);
                    if (FrmClass.Example_Assistant_AdhereTo)
                    {
                        Cla_FrmClass.FrmDistanceJob(this, FrmClass.F_Libretto);
                    }
                }
                if (FrmClass.Example_Libretto_AdhereTo)
                {
                    Cla_FrmClass.FrmDistanceJob(this, FrmClass.F_Libretto);
                    if (FrmClass.Example_Assistant_AdhereTo)
                    {
                        Cla_FrmClass.FrmDistanceJob(this, FrmClass.F_List);
                    }
                }
                if (!(this.Focused == true || FrmClass.F_List.Focused == true || FrmClass.F_Libretto.Focused == true))
                {
                    FrmClass.F_Screen.Focus();
                    FrmClass.F_List.Focus();
                    FrmClass.F_Libretto.Focus();
                    this.Focus();
                }
            }
        }

        private void panel_Title_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {

                Cla_FrmClass.FrmMove(this, e);
                if (FrmClass.Example_List_AdhereTo)
                {

                    Cla_FrmClass.ManyFrmMove(this, e, FrmClass.F_List);
                    Cla_FrmClass.FrmInitialize(FrmClass.F_List);
                    if (FrmClass.Example_Assistant_AdhereTo)
                    {
                        Cla_FrmClass.ManyFrmMove(this, e, FrmClass.F_Libretto);
                        Cla_FrmClass.FrmInitialize(FrmClass.F_Libretto);
                    }
                }

                if (FrmClass.Example_Libretto_AdhereTo)
                {
                    Cla_FrmClass.ManyFrmMove(this, e, FrmClass.F_Libretto);
                    Cla_FrmClass.FrmInitialize(FrmClass.F_Libretto);
                    if (FrmClass.Example_Assistant_AdhereTo)
                    {
                        Cla_FrmClass.ManyFrmMove(this, e, FrmClass.F_List);
                        Cla_FrmClass.FrmInitialize(FrmClass.F_List);
                    }
                }
                Cla_FrmClass.FrmInitialize(this);
            }
        }

        private void panel_Title_MouseUp(object sender, MouseEventArgs e)
        {
            Cla_FrmClass.FrmPlace(this);
        }

        private void pictureBox_Close_Click(object sender, EventArgs e)
        {
            timer_ShowTime.Enabled = false;
            FrmClass.F_List.Close();
            FrmClass.F_List.Dispose();
            FrmClass.F_Libretto.Close();
            FrmClass.F_Libretto.Dispose();
            FrmClass.F_Screen.Close();
            FrmClass.F_Screen.Dispose();
            timer_Bend.Enabled = false;
            this.Close();
            this.Dispose();
        }

        private void pictureBox_List_Click(object sender, EventArgs e)
        {
            Cla_FrmClass.Frm_ShowAndHide(FrmClass.F_List);
        }

        private void pictureBox_Libretto_Click(object sender, EventArgs e)
        {
            Cla_FrmClass.Frm_ShowAndHide(FrmClass.F_Libretto);
        }

        private void Frm_Play_Shown(object sender, EventArgs e)
        {
            //显示列表窗体
            FrmClass.F_List = new Frm_ListBox();
            FrmClass.F_List.ShowInTaskbar = false;
            FrmClass.Example_ListShow = true;
            FrmClass.F_List.Show();
            //显示歌词窗体
            FrmClass.F_Libretto = new Frm_Libretto();
            FrmClass.F_Libretto.ShowInTaskbar = false;
            FrmClass.Example_LibrettoShow = true;
            FrmClass.F_Libretto.Show();
            FrmClass.F_Libretto.Left = this.Left + this.Width;
            FrmClass.F_Libretto.Top = this.Top;
            //显示影象窗体
            FrmClass.F_Screen = new Frm_Screen();
            FrmClass.Example_ScreenShow = false;
            FrmClass.F_Screen.Hide();
            //FrmClass.F_Screen.Show();
            //各窗体位置的初始化
            Cla_FrmClass.FrmInitialize(FrmClass.F_List);
            Cla_FrmClass.FrmInitialize(FrmClass.F_Libretto);
        }

        private void pictureBox_File_Click(object sender, EventArgs e)
        {
            FrmClass.Example_ifLy = false;
            openFileDialog1.Filter = "AVI文件(*.AVI)|*.avi|MP3文件(*.MP3)|*.mp3|DAT文件(*.DAT)|*.dat|WAV文件(*.WAV)|*.wav|RMVB文件(*.RMVB)|*.rmvb|RM文件(*.RM)|*.rm|ALL文件(*.*)|*.*";
            openFileDialog1.Title = "请选择播放文件";
            openFileDialog1.FileName = "";
            if (FrmClass.Example_ListMark < 0)
                FrmClass.Example_ListMark = 0;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ((Frm_Libretto)FrmClass.F_Libretto).FrmMessage(0, 0);
                string Tem_Lyric = openFileDialog1.FileName;
                if (!File.Exists(Tem_Lyric))
                {
                    MessageBox.Show("没有找到该媒体文件。");
                    return;
                }
                Tem_Lyric = Tem_Lyric.Substring(0, Tem_Lyric.LastIndexOf(Convert.ToChar("."))) + ".lrc";
                FileInfo SFInfo = new FileInfo(Tem_Lyric);
                if (SFInfo.Exists == true)
                {
                    FrmClass.Example_ifLy = true;
                    Cla_FrmClass.ArrayList_Close(FrmClass.Example_ArrLyric);
                    FrmClass.Example_ArrLyric = new System.Collections.ArrayList(Cla_FrmClass.LRC_Lyric(Tem_Lyric));

                    FrmClass.Example_LyC = 0;
                    ((Frm_Libretto)FrmClass.F_Libretto).FrmMessage(Cla_FrmClass.LRC_Lyric(Tem_Lyric));
                }
                else
                    FrmClass.Example_ifLy = false;
                FrmClass.Example_AddFileSign = 1;
                ((Frm_ListBox)FrmClass.F_List).FrmMessage(0, openFileDialog1.FileName);
                FrmClass.Example_PlayPath = openFileDialog1.FileName;
                Example_PlayPause = 0;

                pictureBox_Play_Click(sender, e);
                Bend_State(2);
                if (FrmClass.Example_PlayPath.Substring(FrmClass.Example_PlayPath.LastIndexOf("."), FrmClass.Example_PlayPath.Length - FrmClass.Example_PlayPath.LastIndexOf(".")).ToLower() != ".rmvb".ToLower() && FrmClass.Example_PlayPath.Substring(FrmClass.Example_PlayPath.LastIndexOf("."), FrmClass.Example_PlayPath.Length - FrmClass.Example_PlayPath.LastIndexOf(".")).ToLower() != ".rm".ToLower())
                    Show_BendInfo(openFileDialog1.FileName);
            }
        }

        private void pictureBox_Play_Click(object sender, EventArgs e)
        {
            if (FrmClass.Example_PlayPath == "")
            {
                if (((Frm_ListBox)FrmClass.F_List).listView_List.Items.Count > 0)
                {
                    FrmClass.Example_PlayPath = ((Frm_ListBox)FrmClass.F_List).listView_List.Items[0].SubItems[3].Text;
                    ((Frm_ListBox)FrmClass.F_List).listView_List.Items[0].BackColor = Color.DarkGreen;
                }
                else
                {
                    pictureBox_File_Click(sender, e);
                    return;
                }
            }
            if (pictureBox_Hold.Left==0)
                Example_PlayPause = 0;
            Example_NoncePause = Example_PlayPause;

            if (!File.Exists(FrmClass.Example_PlayPath))
            {
                MessageBox.Show("没有找到该媒体文件。");
                return;
            }

            if (timer_Bend.Enabled == false)
            {
                Show_BendInfo(FrmClass.Example_PlayPath);
                ((Frm_Screen)FrmClass.F_Screen).FrmMessage(0, FrmClass.Example_PlayPath, this);
            }

            if (Example_PlayPause == 0)
                Example_PlayPause = 1;
            else
            {
                if (Example_PlayPause == 1)
                {
                    pictureBox_Play.Tag = 12;
                    pictureBox_Play.Image = null;
                    pictureBox_Play.Image = Properties.Resources.暂停按钮变;

                    Example_PlayPause = 2;
                }
                else
                {
                    pictureBox_Play.Tag = 8;
                    pictureBox_Play.Image = null;
                    pictureBox_Play.Image = Properties.Resources.播放按钮变;

                    Example_PlayPause = 1;
                }
            }
            if (Example_NoncePause == 0)
            {
                string Tem_Lyric = FrmClass.Example_PlayPath;
                Tem_Lyric = Tem_Lyric.Substring(0, Tem_Lyric.LastIndexOf(Convert.ToChar("."))) + ".lrc";
                FileInfo SFInfo = new FileInfo(Tem_Lyric);

                if (SFInfo.Exists == true)
                {
                    FrmClass.Example_ifLy = true;
                    Cla_FrmClass.ArrayList_Close(FrmClass.Example_ArrLyric);
                    FrmClass.Example_ArrLyric = new System.Collections.ArrayList(Cla_FrmClass.LRC_Lyric(Tem_Lyric));
                    FrmClass.Example_LyC = 0;
                    ((Frm_Libretto)FrmClass.F_Libretto).FrmMessage(Cla_FrmClass.LRC_Lyric(Tem_Lyric));
                }
            }
            Bend_State(Example_NoncePause);
            ((Frm_Screen)FrmClass.F_Screen).FrmMessage(Example_NoncePause, FrmClass.Example_PlayPath, this);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmClass.Example_ifLy = false;

            timer_Bend.Enabled = false;
            listBox_BendInfo.Items.Clear();

            ((Frm_Libretto)FrmClass.F_Libretto).FrmMessage(0, 0);
            ((Frm_Screen)FrmClass.F_Screen).FrmMessage(3, FrmClass.Example_PlayPath, this);
            Example_PlayPause = 0;
            Example_NoncePause = 3;
            label_Time.Text = "00:00";
            pictureBox_Hold.Left = 0;
            Bend_State(Example_NoncePause);
            FrmClass.Example_ifLy = false;
            if (((Frm_ListBox)FrmClass.F_List).listView_List.Items.Count == 0)
                FrmClass.Example_PlayPath = "";
        }

        private void pictureBox_Hold_MouseDown(object sender, MouseEventArgs e)
        {
            Example_BarMove = true;
            Example_BarPoint = new Point(e.X, e.Y);
        }

        private void pictureBox_Hold_MouseMove(object sender, MouseEventArgs e)
        {
            Point Tem_BPoint;
            Point Tem_BPoint1;
            if (e.Button == MouseButtons.Left)
            {
                if (Example_NoncePause == 3)
                    return;
                if (Example_BarMove == false)
                    return;
                if (Example_BarMove)
                {
                    Tem_BPoint1 = Example_BarPoint;
                    Tem_BPoint = new Point(e.X, e.Y);

                    if (pictureBox_Hold.Left >= 0 && pictureBox_Hold.Left <= (panel_Trough.Width - pictureBox_Hold.Width))
                    {
                        pictureBox_Hold.Left = pictureBox_Hold.Left + Tem_BPoint.X - Tem_BPoint1.X;
                    }
                    else
                    {
                        if (pictureBox_Hold.Left < 0)
                        {
                            pictureBox_Hold.Left = 0;
                            pictureBox_Bar.Width = 0;
                        }
                        if (pictureBox_Hold.Left > (panel_Trough.Width - pictureBox_Hold.Width))
                        {
                            pictureBox_Hold.Left = (panel_Trough.Width - pictureBox_Hold.Width);
                            pictureBox_Bar.Width = (panel_Trough.Width - pictureBox_Hold.Width);
                        }
                        Example_BarMove = false;
                    }
                }
                Example_LyMove = true;
            }
        }

        private void pictureBox_Hold_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (Example_LyMove == true)
                    Example_LyMove = true;
                else
                    Example_LyMove = false;

                if (FrmClass.Example_PlayPath == "" || Example_NoncePause == 3)
                {
                    Example_BarMove = false;
                    FrmClass.Example_BarLeft = 0;
                    pictureBox_Hold.Left = 0;
                    pictureBox_Bar.Width = 0;
                    return;
                }
                Example_BarMove = false;
                FrmClass.Example_BarLeft = pictureBox_Hold.Left;
                if (pictureBox_Hold.Left < 0)
                {
                    pictureBox_Hold.Left = 0;
                    pictureBox_Bar.Width = 0;
                }
                if (pictureBox_Hold.Left > (panel_Trough.Width - pictureBox_Hold.Width))
                {
                    pictureBox_Hold.Left = (panel_Trough.Width - pictureBox_Hold.Width);
                    pictureBox_Bar.Width = (panel_Trough.Width - pictureBox_Hold.Width);
                }
                ((Frm_Screen)FrmClass.F_Screen).FrmMessage(4, Example_NoncePause.ToString(), this);
                FrmClass.Example_LyC = 0;
                Example_LyMove = false;
            }
        }

        private void timer_ShowTime_Tick(object sender, EventArgs e)
        {
            if (((Frm_Screen)FrmClass.F_Screen).axWindowsMediaPlayer1.currentMedia == null)
                return;
            if (((Frm_Screen)FrmClass.F_Screen).axWindowsMediaPlayer1.currentMedia.duration == 0)
            {
                return;
            }
            if (FrmClass.Example_TimeSizeD == 0)
            {
                FrmClass.Example_Barframe = 0;
                FrmClass.Example_TimeSizeD = ((Frm_Screen)FrmClass.F_Screen).axWindowsMediaPlayer1.currentMedia.duration;
                label_Time.Text = ((Frm_Screen)FrmClass.F_Screen).axWindowsMediaPlayer1.Ctlcontrols.currentPositionString;
                FrmClass.Example_Barframe = (FrmClass.Example_TimeSizeD / (panel_Trough.Width - pictureBox_Hold.Width));
            }
            else
            {
                if (FrmClass.Example_Barframe == 0)
                {
                    FrmClass.Example_Barframe = (FrmClass.Example_TimeSizeD / (panel_Trough.Width - pictureBox_Hold.Width));
                }
                if (FrmClass.Example_TimeSizeD != ((Frm_Screen)FrmClass.F_Screen).axWindowsMediaPlayer1.currentMedia.duration)
                {
                    FrmClass.Example_TimeSizeD = ((Frm_Screen)FrmClass.F_Screen).axWindowsMediaPlayer1.currentMedia.duration;
                    FrmClass.Example_Barframe = (FrmClass.Example_TimeSizeD / (panel_Trough.Width - pictureBox_Hold.Width));
                }

                string Tem_upArr = "";
                if (Example_BarMove==false)
                {
                    for (int i = FrmClass.Example_LyC; i < FrmClass.Example_ArrLyric.Count - 1; i++)
                    {
                        Tem_upArr = FrmClass.Example_ArrLyric[i].ToString();
                        Example_UpD = Convert.ToDouble(Tem_upArr.Substring(0, Tem_upArr.IndexOf(Convert.ToChar("|")))) / 1000;
                        if ((i + 1) == FrmClass.Example_ArrLyric.Count)
                            Tem_upArr = FrmClass.Example_ArrLyric[i].ToString();
                        else
                            Tem_upArr = FrmClass.Example_ArrLyric[i + 1].ToString();
                        Example_DownD = Convert.ToDouble(Tem_upArr.Substring(0, Tem_upArr.IndexOf(Convert.ToChar("|")))) / 1000;


                        if (FrmClass.Example_ifLy)
                        {
                            if (((Frm_Screen)FrmClass.F_Screen).axWindowsMediaPlayer1.Ctlcontrols.currentPosition >= Example_UpD && ((Frm_Screen)FrmClass.F_Screen).axWindowsMediaPlayer1.Ctlcontrols.currentPosition < Example_DownD)
                            {
                                ((Frm_Libretto)FrmClass.F_Libretto).FrmMessage(1, i);
                                FrmClass.Example_LyC = i;
                                break;
                            }

                            Tem_upArr = FrmClass.Example_ArrLyric[FrmClass.Example_ArrLyric.Count - 1].ToString();
                            Example_DownD = Convert.ToDouble(Tem_upArr.Substring(0, Tem_upArr.IndexOf(Convert.ToChar("|")))) / 1000;
                            if (((Frm_Screen)FrmClass.F_Screen).axWindowsMediaPlayer1.Ctlcontrols.currentPosition > Example_DownD)
                            {
                                ((Frm_Libretto)FrmClass.F_Libretto).FrmMessage(1, FrmClass.Example_ArrLyric.Count - 1);
                                FrmClass.Example_LyC = FrmClass.Example_ArrLyric.Count - 1;
                                break;
                            }
                        }
                    }
                }

                label_Time.Text = ((Frm_Screen)FrmClass.F_Screen).axWindowsMediaPlayer1.Ctlcontrols.currentPositionString;
                pictureBox_Hold.Left = (int)Math.Floor(((Frm_Screen)FrmClass.F_Screen).axWindowsMediaPlayer1.Ctlcontrols.currentPosition / FrmClass.Example_Barframe);
                if (((Frm_Screen)FrmClass.F_Screen).axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsStopped)
                {
                    FrmClass.Example_ifLy = false;
                    ((Frm_Libretto)FrmClass.F_Libretto).FrmMessage(0, 0);
                    pictureBox_Hold.Left = 0;
                    pictureBox_Bar.Width = 0;
                    timer_ShowTime.Enabled = false;
                    timer_Bend.Enabled = false;
                    listBox_BendInfo.Items.Clear();
                    Bend_State(3);
                    SetPlayMode(FrmClass.Example_Mode);

                }
            }
            
        }

        private void pictureBox_Hold_LocationChanged(object sender, EventArgs e)
        {
            pictureBox_Bar.Width = pictureBox_Hold.Left;
        }

        private void timer_Bend_Tick(object sender, EventArgs e)
        {
            panel_Title.Select();
            if (Example_BendC <= listBox_BendInfo.Items.Count)
            {
                listBox_BendInfo.TopIndex = Example_BendC;
                Example_BendC = Example_BendC + 1;
            }
            else
            {
                Example_BendC = 0;
                listBox_BendInfo.TopIndex = Example_BendC;
            }
        }

        private void pictureBox_SoundHold_MouseDown(object sender, MouseEventArgs e)
        {
            Example_MusicBarPoint = new Point(e.X, e.Y);
            Example_MusicBarMove = true;
        }

        private void pictureBox_SoundHold_MouseMove(object sender, MouseEventArgs e)
        {
            Point Tem_BPoint;
            Point Tem_BPoint1;
            if (e.Button == MouseButtons.Left)
            {
                if (Example_MusicBarMove == false)
                    return;
                if (Example_MusicBarMove)
                {
                    Tem_BPoint1 = Example_MusicBarPoint;
                    Tem_BPoint = new Point(e.X, e.Y);

                    if (pictureBox_SoundHold.Left >= 0 && pictureBox_SoundHold.Left <= (panel_Sound.Width - pictureBox_SoundHold.Width))
                    {
                        pictureBox_SoundHold.Left = pictureBox_SoundHold.Left + Tem_BPoint.X - Tem_BPoint1.X;
                        pictureBox_SoundBar.Width = pictureBox_SoundHold.Left;
                    }
                    else
                    {
                        if (pictureBox_SoundHold.Left < 0)
                        {
                            pictureBox_SoundHold.Left = 0;
                            pictureBox_SoundBar.Width = 0;
                        }
                        if (pictureBox_SoundHold.Left > (panel_Sound.Width - pictureBox_SoundHold.Width))
                        {
                            pictureBox_SoundHold.Left = (panel_Sound.Width - pictureBox_SoundHold.Width);
                            pictureBox_SoundBar.Width = (panel_Sound.Width - pictureBox_SoundHold.Width);
                        }
                        Example_MusicBarMove = false;
                    }
                }
                ((Frm_Screen)FrmClass.F_Screen).axWindowsMediaPlayer1.settings.volume = (int)Math.Floor(Example_MusicToler * pictureBox_SoundHold.Left);
                //Example_MusicToler*pictureBox_SoundHold.Left
            }
        }

        private void pictureBox_SoundHold_MouseUp(object sender, MouseEventArgs e)
        {
            Example_MusicBarMove = false;
        }

        private void pictureBox_Rest_Click(object sender, EventArgs e)
        {
            ((PictureBox)sender).Image = null;
            if (Example_Rest)
            {
                Example_Rest = false;
                ((PictureBox)sender).Image = Properties.Resources.音量按钮;
            }
            else
            {
                Example_Rest = true;
                ((PictureBox)sender).Image = Properties.Resources.音量按钮变色;
            }
            ((Frm_Screen)FrmClass.F_Screen).axWindowsMediaPlayer1.settings.mute = Example_Rest;
        }

        private void pictureBox_Min_MouseEnter(object sender, EventArgs e)
        {
            Cla_FrmClass.ButtonChange((PictureBox)sender, Convert.ToInt16(((PictureBox)sender).Tag.ToString()), true);
        }

        private void pictureBox_Min_MouseLeave(object sender, EventArgs e)
        {
            Cla_FrmClass.ButtonChange((PictureBox)sender, Convert.ToInt16(((PictureBox)sender).Tag.ToString()), false);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MovePlayFile(Convert.ToInt16(((PictureBox)sender).Tag.ToString()));
        }

        private void pictureBox_Min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            ((Frm_ListBox)FrmClass.F_List).WindowState = FormWindowState.Minimized;
            ((Frm_Libretto)FrmClass.F_Libretto).WindowState = FormWindowState.Minimized;
            Example_FormShow = 1;
        }

        private void Frm_Play_Activated(object sender, EventArgs e)
        {
            if (Example_FormShow == 1)
            {
                ((Frm_ListBox)FrmClass.F_List).WindowState = FormWindowState.Normal;
                ((Frm_Libretto)FrmClass.F_Libretto).WindowState = FormWindowState.Normal;
                this.WindowState = FormWindowState.Normal;
                Example_FormShow = 0;
            }
        }

        private void pictureBox_WF_Click(object sender, EventArgs e)
        {
            Cla_FrmClass.Frm_ShowAndHide(FrmClass.F_Screen);
        }
    }
}