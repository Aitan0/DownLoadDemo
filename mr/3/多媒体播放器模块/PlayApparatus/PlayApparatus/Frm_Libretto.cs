using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PlayApparatus
{
    public partial class Frm_Libretto : Form
    {
        public Frm_Libretto()
        {
            InitializeComponent();
            
        }

        #region  公共变量
        FrmClass Cla_FrmClass = new FrmClass();
        public static int nullCount = 0;//记录空格数
        public static int selectCount = 0;//记录当前选中的行数
        public static bool Lyroll = false;//歌词的滑动
        #endregion

        #region  "歌词"窗体接收的消息
        /// <summary>
        /// 获取歌词
        /// </summary>
        /// <param Tem_Str="string[]">记录歌词的列表</param>
        public void FrmMessage(string[] Tem_Str)
        {
            listBox_Lyric.Items.Clear();
            listBox_Lyric.HorizontalScrollbar = true;
            listBox_firstNull(listBox_Lyric);
            for (int i = 0; i < Tem_Str.Length; i++)
            {
                listBox_Lyric.Items.Add(Tem_Str[i].Substring(Tem_Str[i].IndexOf(Convert.ToChar("|")) + 1, Tem_Str[i].Length - Tem_Str[i].IndexOf(Convert.ToChar("|")) - 1));
            }
            listBox_firstNull(listBox_Lyric);
        }

        /// <summary>
        /// 对歌词进行控制的消息
        /// </summary>
        /// <param Sign="int">标识</param>
        /// <param n="int">歌词滚动的行数</param>
        public void FrmMessage(int Sign, int n)
        {
            switch (Sign)
            {
                case 0://清空歌词列表
                    {
                        listBox_Lyric.Items.Clear();
                        break;
                    }
                case 1://歌词滚动
                    {
                        if (Lyroll == true)
                            break;
                        listBox_Lyric.TopIndex = n + 1;
                        listBox_Lyric.SelectedIndex = listBox_Lyric.TopIndex + nullCount;
                        break;
                    }
            }

        }
        #endregion

        #region  设置空行，使歌词局中
        /// <summary>
        /// 设置空行，使歌词局中
        /// </summary>
        /// <param List_Box="ListBox">ListBox控件</param>
        public void listBox_firstNull(ListBox List_Box)
        {
            nullCount = (int)Math.Ceiling(Convert.ToDouble(List_Box.Height / 12 / 2));
            for (int i = 0; i <= nullCount; i++)
            {
                List_Box.Items.Add("");
            }
        }
        #endregion

        public void listBox_ADDNull(ListBox List_Box)
        {
            int Tem_n = 0;
            bool Tem_b = true;
            int Tem_Count = (int)Math.Ceiling(Convert.ToDouble(List_Box.Height / 12 / 2));
            if (Tem_Count != nullCount)
                Tem_n = Tem_Count - nullCount;
            if (Tem_n > 0)
                Tem_b = true;
            else
                Tem_b = false;
            for (int i = 0; i < Math.Abs(Tem_n); i++)
            {
                if (Tem_b)
                    List_Box.Items.Insert(0, "");
                else
                    List_Box.Items.RemoveAt(0);
            }
            nullCount = Tem_Count;
            if (List_Box.SelectedIndex!=-1)
                List_Box.SelectedIndex = nullCount;       
        }

        private void Frm_Libretto_Load(object sender, EventArgs e)
        {
            this.Top = FrmClass.Example_Play_Top;
            this.Left = FrmClass.Example_Play_Left + FrmClass.Example_Play_Width;
            Cla_FrmClass.FrmInitialize(this);
            this.BackColor = Color.Maroon;
            this.TransparencyKey = this.BackColor;

            listBox_Lyric.Width = panel_All.Width + 20;
            listBox_Lyric.Height = panel_All.Height;
        }

        private void pane_Title_MouseDown(object sender, MouseEventArgs e)
        {
            int Tem_X = -e.X;
            if (Convert.ToInt16(((Panel)sender).Tag.ToString())==2)
                Tem_X = -e.X - panel_TitleL.Width;
            if (Convert.ToInt16(((Panel)sender).Tag.ToString()) == 3)
                Tem_X = -(this.Width - ((Panel)sender).Width) - e.X;
            FrmClass.CPoint = new Point(Tem_X, -e.Y);
        }

        private void pane_Title_MouseMove(object sender, MouseEventArgs e)
        {
            FrmClass.Example_Assistant_AdhereTo = false;
            FrmClass.Example_Libretto_AdhereTo = false;
            Cla_FrmClass.FrmMove(this, e);
        }

        private void pane_Title_MouseUp(object sender, MouseEventArgs e)
        {
            Cla_FrmClass.FrmPlace(this);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Cla_FrmClass.Frm_ShowAndHide(this);
            this.Hide();
        }

        private void panel_Right_MouseDown(object sender, MouseEventArgs e)
        {
            Cla_FrmClass.FrmScreen_SizeInfo(this, (Panel)sender, e);
        }

        private void panel_Right_MouseMove(object sender, MouseEventArgs e)
        {
            Cla_FrmClass.FrmScreen_EnlargeSize(this, (Panel)sender, e, 290, 290);
        }

        private void panel_Right_MouseUp(object sender, MouseEventArgs e)
        {
            Cla_FrmClass.FrmScreen_FormerlySize(this, 290, 290);
            listBox_ADDNull(listBox_Lyric);
        }

        private void listView_Lyric_Resize(object sender, EventArgs e)
        {

        }

        private void panel_All_Resize(object sender, EventArgs e)
        {
            listBox_Lyric.Width = panel_All.Width + 20;
            listBox_Lyric.Height = panel_All.Height;
        }

        private void listBox_Lyric_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.listBox_Lyric.Cursor = Cursors.Hand;
                Lyroll = true;
                if (listBox_Lyric.Items.Count < 2)
                    Lyroll = false;
            }
        }

        private void listBox_Lyric_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (listBox_Lyric.Items.Count < 2)
                {
                    this.listBox_Lyric.Cursor = Cursors.Default;
                    return;
                }
                int Tem_n = 0;
                Tem_n = listBox_Lyric.SelectedIndex - nullCount;
                if ((listBox_Lyric.SelectedIndex - nullCount) > FrmClass.Example_ArrLyric.Count)
                    Tem_n = FrmClass.Example_ArrLyric.Count-1;
                if ((listBox_Lyric.SelectedIndex - nullCount) < 0)
                    Tem_n = 0;
                FrmClass.Example_LyC = 0;

                this.listBox_Lyric.Cursor = Cursors.Default;
                string Tem_upArr = FrmClass.Example_ArrLyric[Tem_n].ToString();
                double Example_DownD = Convert.ToDouble(Tem_upArr.Substring(0, Tem_upArr.IndexOf(Convert.ToChar("|")))) / 1000;
                ((Frm_Screen)FrmClass.F_Screen).axWindowsMediaPlayer1.Ctlcontrols.currentPosition = Example_DownD;
                ((Frm_Play)FrmClass.F_MPlay).pictureBox_Hold.Left = (int)(Example_DownD/FrmClass.Example_Barframe);
                Lyroll = false;
            }
        }

        private void listBox_Lyric_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && Lyroll == true)
            {
                Lyroll = true;
                listBox_Lyric.TopIndex = listBox_Lyric.SelectedIndex - nullCount;
                listBox_Lyric.SelectedIndex = listBox_Lyric.TopIndex + nullCount;
            }
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            Cla_FrmClass.ButtonChange((PictureBox)sender, Convert.ToInt16(((PictureBox)sender).Tag.ToString()), true);
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            Cla_FrmClass.ButtonChange((PictureBox)sender, Convert.ToInt16(((PictureBox)sender).Tag.ToString()), false);
        }
    }
}