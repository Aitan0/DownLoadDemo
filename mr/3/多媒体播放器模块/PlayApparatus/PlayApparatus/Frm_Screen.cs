using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PlayApparatus
{
    public partial class Frm_Screen : Form
    {
        public Frm_Screen()
        {
            InitializeComponent();
        }

        #region  公共变量
        FrmClass Cla_FrmClass = new FrmClass();
        public static double Example_frame = 0;//帧
        public static int Example_PauseMove = 0;
        #endregion

        #region  "显示"窗体接收的消息
        /// <summary>
        /// "显示"窗体接收的消息
        /// </summary>
        /// <param Sign="int">标识</param>
        /// <param Tem_Str="string">播放状态</param>
        /// <param F_Main="Form">播放窗体</param>
        public void FrmMessage(int Sign, string Tem_Str,Form F_Main)
        {
            switch (Sign)
            {
                case 0://获取目录并播放
                    {
                        axWindowsMediaPlayer1.URL = Tem_Str;
                        axWindowsMediaPlayer1.Ctlcontrols.play();
                        ((Frm_Play)F_Main).timer_ShowTime.Interval = 100;
                        ((Frm_Play)F_Main).timer_ShowTime.Enabled = true;
                        Example_PauseMove = 0;
                        if (FrmClass.Example_PlayPath.Substring(Tem_Str.LastIndexOf("."), Tem_Str.Length - Tem_Str.LastIndexOf(".")).ToLower() != ".mp3".ToLower())
                        {
                            FrmClass.Example_ScreenShow = false;
                            this.Show();
                            if (axWindowsMediaPlayer1.currentMedia.duration == 0)
                            {
                                timer1.Interval = 50;
                                timer1.Enabled = true;
                            }
                        }
                        else
                            this.Hide();
                        break;
                    }
                case 1://暂停
                    {
                        Example_frame = axWindowsMediaPlayer1.Ctlcontrols.currentPosition;
                        axWindowsMediaPlayer1.Ctlcontrols.pause();
                        ((Frm_Play)F_Main).timer_ShowTime.Interval = 100;
                        ((Frm_Play)F_Main).timer_ShowTime.Enabled = false;
                        Example_PauseMove = 1;
                        break;
                    }
                case 2://继续
                    {
                        if (Example_PauseMove == 1)
                            axWindowsMediaPlayer1.Ctlcontrols.currentPosition = Example_frame;
                        else
                            axWindowsMediaPlayer1.Ctlcontrols.currentPosition = (FrmClass.Example_BarLeft * FrmClass.Example_Barframe);
                        axWindowsMediaPlayer1.Ctlcontrols.play();
                        ((Frm_Play)F_Main).timer_ShowTime.Interval = 100;
                        ((Frm_Play)F_Main).timer_ShowTime.Enabled = true;
                        break;
                    }
                case 3://停止
                    {
                        axWindowsMediaPlayer1.Ctlcontrols.currentPosition = 0;
                        axWindowsMediaPlayer1.Ctlcontrols.stop();
                        ((Frm_Play)F_Main).timer_ShowTime.Interval = 100;
                        ((Frm_Play)F_Main).timer_ShowTime.Enabled = false;
                        break;
                    }
                case 4://移动
                    {
                        double TemBarMove = (FrmClass.Example_BarLeft * FrmClass.Example_Barframe);
                        axWindowsMediaPlayer1.Ctlcontrols.currentPosition = TemBarMove;
                        switch (Tem_Str)
                        {
                            case "0":
                            case "2":
                                axWindowsMediaPlayer1.Ctlcontrols.play();
                                break;
                            case "1":
                                axWindowsMediaPlayer1.Ctlcontrols.pause();
                                Example_PauseMove = 2;
                                break;
                        }
                        break;
                    }
            }
        }
        #endregion

        private void Frm_Screen_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            Cla_FrmClass.FrmInitialize(this);
            this.BackColor = Color.Maroon;
            this.TransparencyKey = this.BackColor;
        }

        private void panel_Top_MouseMove(object sender, MouseEventArgs e)
        {
            FrmClass.Example_Assistant_AdhereTo = false;
            FrmClass.Example_Libretto_AdhereTo = false;
            Cla_FrmClass.FrmMove(this, e);
        }

        private void panel_Top_MouseDown(object sender, MouseEventArgs e)
        {
            FrmClass.CPoint = new Point(-e.X, -e.Y);
        }

        private void panel_Top_MouseUp(object sender, MouseEventArgs e)
        {
            Cla_FrmClass.FrmPlace(this);
        }

        private void panel_Right_MouseDown(object sender, MouseEventArgs e)
        {
            Cla_FrmClass.FrmScreen_SizeInfo(this, (Panel)sender, e);
        }

        private void panel_Right_MouseMove(object sender, MouseEventArgs e)
        {
            Cla_FrmClass.FrmScreen_EnlargeSize(this, (Panel)sender, e, 300, 200);
        }

        private void panel_Right_MouseUp(object sender, MouseEventArgs e)
        {
            Cla_FrmClass.FrmScreen_FormerlySize(this, 300, 200);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.play();
            if (axWindowsMediaPlayer1.currentMedia.duration > 0)
            {
                FrmClass.Example_TimeSizeD = axWindowsMediaPlayer1.currentMedia.duration;
                
                ((Frm_Play)FrmClass.F_MPlay).pictureBox_Hold.Left = 0;
                FrmClass.Example_FileInfoL.Add("文件名称:" + axWindowsMediaPlayer1.currentMedia.getItemInfo("Title"));
                FrmClass.Example_FileInfoL.Add(axWindowsMediaPlayer1.currentMedia.getItemInfo("Duration"));
                FrmClass.Example_FileInfoL.Add("文件类型:" + axWindowsMediaPlayer1.currentMedia.getItemInfo("FileType"));
                timer1.Enabled = false;
            }
        }

        private void Frm_Screen_FormClosed(object sender, FormClosedEventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            timer1.Enabled = false;
        }

        private void pictureBox_Min_MouseEnter(object sender, EventArgs e)
        {
            Cla_FrmClass.ButtonChange((PictureBox)sender, Convert.ToInt16(((PictureBox)sender).Tag.ToString()), true);
        }

        private void pictureBox_Min_MouseLeave(object sender, EventArgs e)
        {
            Cla_FrmClass.ButtonChange((PictureBox)sender, Convert.ToInt16(((PictureBox)sender).Tag.ToString()), false);
        }

        private void pictureBox_Min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox_Close_Click(object sender, EventArgs e)
        {
            Cla_FrmClass.Frm_ShowAndHide(FrmClass.F_Screen);
        }

    }
}