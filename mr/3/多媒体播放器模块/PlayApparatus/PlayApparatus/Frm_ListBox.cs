using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;//为ArrayList添加命名空间
using System.IO;

namespace PlayApparatus
{
    public partial class Frm_ListBox : Form
    {
        public Frm_ListBox()
        {
            InitializeComponent();
        }

        #region  公共变量
        FrmClass Cla_FrmClass = new FrmClass();
        public static string Tem_Dir = "";
        #endregion

        #region  "列表"窗体接收的消息
        /// <summary>
        /// "列表"窗体接收的消息
        /// </summary>
        /// <param Sign="int">标识</param>
        /// <param Tem_Str="string">播放文件的路径</param>
        public void FrmMessage(int Sign, string Tem_Str)
        {
            switch (Sign)
            {
                case 0:
                    {
                        string Tem_Artist = "";//艺术家
                        string Tem_Caption = "";//标题
                        string Tem_BendName = "";//名称
                        string Tem_Time = "";//时间
                        string Tem_str = "";
                        //Cla_FrmClass.GetFileDouble(Tem_Str);//获取当前播放文件的所有信息
                        if (Tem_Str.Substring(Tem_Str.LastIndexOf("."), Tem_Str.Length - Tem_Str.LastIndexOf(".")).ToLower() == ".rmvb".ToLower() || Tem_Str.Substring(Tem_Str.LastIndexOf("."), Tem_Str.Length - Tem_Str.LastIndexOf(".")).ToLower() == ".rm".ToLower() || Tem_Str.Substring(Tem_Str.LastIndexOf("."), Tem_Str.Length - Tem_Str.LastIndexOf(".")).ToLower() == ".dat".ToLower())
                        {
                            Cla_FrmClass.Data_List(this.listView_List, Tem_Str, Tem_Time, Tem_Str);
                            if (listView_List.Items.Count > 0)
                            {
                                listView_List.Items[FrmClass.Example_ListMark].BackColor = Color.DarkSeaGreen;
                            }
                            FrmClass.Example_ListMark = listView_List.Items.Count - 1;
                            listView_List.Items[FrmClass.Example_ListMark].BackColor = Color.DarkGreen;

                            break;
                        }
                        Tem_Artist = Cla_FrmClass.GetFileInfo(Tem_Str, 16);
                        Tem_Caption = Cla_FrmClass.GetFileInfo(Tem_Str, 10);
                        Tem_BendName = Cla_FrmClass.GetFileInfo(Tem_Str, 0);
                        if (Tem_Caption != "" && Tem_Artist != "")
                        {
                            Tem_str = Tem_Artist + "-" + Tem_Caption;
                        }
                        else
                        {
                            Tem_str = Tem_BendName;
                            if (Tem_Caption != "")
                                Tem_str = Tem_Caption;
                        }
                        Tem_Time = Cla_FrmClass.GetFileTime(Cla_FrmClass.LongTime(Tem_Str));
                        if (listView_List.Items.Count > 0)
                        {
                            listView_List.Items[FrmClass.Example_ListMark].BackColor = Color.DarkSeaGreen;
                        }
                        FrmClass.Example_ListMark = listView_List.Items.Count - 1;
                        Cla_FrmClass.Data_List(this.listView_List, Tem_str, Tem_Time, Tem_Str);
                        FrmClass.Example_ListMark = listView_List.Items.Count - 1;
                        listView_List.Items[FrmClass.Example_ListMark].BackColor = Color.DarkGreen;
                        
                        break;
                    }
                case 1:
                    {
                        string Tem_Artist = "";//艺术家
                        string Tem_Caption = "";//标题
                        string Tem_BendName = "";//名称
                        string Tem_Time = "";//时间
                        string Tem_str = "";
                        if (Tem_Str.Substring(Tem_Str.LastIndexOf("."), Tem_Str.Length - Tem_Str.LastIndexOf(".")).ToLower() == ".rmvb".ToLower() || Tem_Str.Substring(Tem_Str.LastIndexOf("."), Tem_Str.Length - Tem_Str.LastIndexOf(".")).ToLower() == ".rm".ToLower() || Tem_Str.Substring(Tem_Str.LastIndexOf("."), Tem_Str.Length - Tem_Str.LastIndexOf(".")).ToLower() == ".dat".ToLower())
                        {
                            Cla_FrmClass.Data_List(this.listView_List, Tem_Str, Tem_Time, Tem_Str);
                            break;
                        }
                        Tem_Artist = Cla_FrmClass.GetFileInfo(Tem_Str, 16);
                        Tem_Caption = Cla_FrmClass.GetFileInfo(Tem_Str, 10);
                        Tem_BendName = Cla_FrmClass.GetFileInfo(Tem_Str, 0);
                        if (Tem_Caption != "" && Tem_Artist != "")
                        {
                            Tem_str = Tem_Artist + "-" + Tem_Caption;
                        }
                        else
                        {
                            Tem_str = Tem_BendName;
                            if (Tem_Caption != "")
                                Tem_str = Tem_Caption;
                        }
                        Tem_Time = Cla_FrmClass.GetFileTime(Cla_FrmClass.LongTime(Tem_Str));
                        Cla_FrmClass.Data_List(this.listView_List, Tem_str, Tem_Time, Tem_Str);
                        break;
                    }
            }
        }
        #endregion

        #region  获取播放模式的信息
        /// <summary>
        /// 获取播放模式的信息
        /// </summary>
        /// <param sender="object">类</param>
        public void GetModeInfo(object sender)
        {
            ToolS_Mode01.Checked = false;
            ToolS_Mode02.Checked = false;
            ToolS_Mode03.Checked = false;
            ToolS_Mode04.Checked = false;
            ToolS_Mode05.Checked = false;

            switch (Convert.ToInt32(((ToolStripMenuItem)sender).Tag.ToString()))
            {
                case 1:
                    {
                        ToolS_Mode01.Checked = true;
                        FrmClass.Example_Mode = 1;
                        break;
                    }
                case 2:
                    {
                        ToolS_Mode02.Checked = true;
                        FrmClass.Example_Mode = 2;
                        break;
                    }
                case 3:
                    {
                        ToolS_Mode03.Checked = true;
                        FrmClass.Example_Mode = 3;
                        break;
                    }
                case 4:
                    {
                        ToolS_Mode04.Checked = true;
                        FrmClass.Example_Mode = 4;
                        break;
                    }
                case 5:
                    {
                        ToolS_Mode05.Checked = true;
                        FrmClass.Example_Mode = 5;
                        break;
                    }
            }
        }
        #endregion

        #region  删除列表中的内容
        /// <summary>
        /// 删除列表中的内容
        /// </summary>
        /// <param LV="ListView">ListView控件</param>
        /// <param n="int">标识</param>
        private void List_DeleteFile(ListView LV, int n)
        {
            switch (n)
            {
                case 0://删除选中的
                    {
                        if (FrmClass.Example_ListMark >= LV.SelectedIndices[0])
                            FrmClass.Example_ListMark = FrmClass.Example_ListMark - 1;
                        LV.Items[LV.SelectedIndices[0]].Remove();
                        break;
                    }
                case 1://删除重复制的
                    {
                        string Tem_name = "";
                        for (int i = 0; i < LV.Items.Count - 1; i++)
                        {
                            if (i < 0)
                                i = 0;
                            Tem_name = LV.Items[i].SubItems[1].Text;
                            for (int j = i + 1; j < LV.Items.Count; j++)
                            {
                                if (Tem_name == LV.Items[j].SubItems[1].Text)
                                {
                                    if (j < FrmClass.Example_ListMark)
                                    {
                                        if (j >= LV.Items.Count)
                                            break;
                                        FrmClass.Example_ListMark = FrmClass.Example_ListMark - 1;
                                        LV.Items[j].Remove();
                                    }
                                    if (j == FrmClass.Example_ListMark)
                                    {
                                        if (j >= LV.Items.Count)
                                            break;
                                        FrmClass.Example_ListMark = FrmClass.Example_ListMark - 1;
                                        LV.Items[i].Remove();
                                    }
                                    if (j > FrmClass.Example_ListMark)
                                    {
                                        if (j >= LV.Items.Count)
                                            //j = LV.Items.Count-1;
                                            break;
                                        LV.Items[j].Remove();
                                    }
                                    i = i - 1;
                                    j = j - 1;
                                }
                            }
                        }
                            break;
                    }
                case 2://删除所有
                    {
                        LV.Items.Clear();
                        FrmClass.Example_ListMark = -1;
                        break;
                    }
            }
            if (n >= 0 && n <= 1)
            {
                int Tem_i = 0;
                for (int i = 0; i < LV.Items.Count; i++)
                {
                    Tem_i = i + 1;
                    LV.Items[i].SubItems[0].Text = Tem_i.ToString();
                }
            }

        }
        #endregion

        private void Frm_ListBox_Load(object sender, EventArgs e)
        {
            string Tem_Path = "";
            string Tem_Name = "";
            ToolS_Mode03.Checked = true;
            this.Left = FrmClass.Example_Play_Left;
            this.Top = FrmClass.Example_Play_Top + FrmClass.Example_Play_Height;
            Cla_FrmClass.Format_ListV(listView_List);
            Cla_FrmClass.FrmInitialize(this);

            Cla_FrmClass.Format_ListN(listView_Fname);
            Tem_Dir = Cla_FrmClass.UpAndDown_Dir(System.AppDomain.CurrentDomain.BaseDirectory);
            Tem_Path = Tem_Dir;
            Tem_Dir = Tem_Dir + "\\默认.m3u";
            FrmClass.Example_ListNameDir = Tem_Dir;
            if (File.Exists(Tem_Dir))
            {
                Cla_FrmClass.m3uRead(Tem_Dir);
                if (FrmClass.AList.Count > 1)
                {
                    Cla_FrmClass.ListAddFile(listView_Fname, listView_List, FrmClass.AList);
                }
            }
            else
            {
                Cla_FrmClass.m3uCreate(Tem_Dir);
            }
            
            Cla_FrmClass.Data_List(listView_Fname,"默认",Tem_Dir);
            FrmClass.Example_ListNameNark = 0;
            listView_Fname.Items[0].BackColor = Color.DarkGreen;
            string Tem_Play = "";
            DirectoryInfo dir = new DirectoryInfo(Tem_Path);
            FileSystemInfo[] files = dir.GetFileSystemInfos();//获取文件夹中所有文件和文件夹
            //对单个FileSystemInfo进行判断,如果是文件夹则进行递归操作
            foreach (FileSystemInfo FSys in files)
            {
                FileInfo file = FSys as FileInfo;
                if (file != null)
                {
                    Tem_Name = file.DirectoryName + "\\" + file.Name;
                    Tem_Name = Tem_Name.Substring(Tem_Name.LastIndexOf(Convert.ToChar(".")) + 1, Tem_Name.Length - Tem_Name.LastIndexOf(Convert.ToChar(".")) - 1);
                    if (Tem_Name.ToLower() == "m3u")
                    {
                        if (file.Name.Substring(0, file.Name.Length-4) != "默认")
                        {
                            Tem_Play = file.DirectoryName + "\\" + file.Name;
                            Cla_FrmClass.Data_List(listView_Fname, file.Name.Substring(0, file.Name.Length - 4), Tem_Play);
                        }

                    }
                }
            }



        }

        private void panel_Title_MouseDown(object sender, MouseEventArgs e)
        {
            int Tem_X = -e.X;
            if (Convert.ToInt16(((Panel)sender).Tag.ToString()) == 2)
                Tem_X = -e.X - panel_TitL.Width;
            if (Convert.ToInt16(((Panel)sender).Tag.ToString()) == 3)
                Tem_X = -(this.Width - ((Panel)sender).Width) - e.X;
            FrmClass.CPoint = new Point(Tem_X, -e.Y);
        }

        private void panel_Title_MouseMove(object sender, MouseEventArgs e)
        {
            FrmClass.Example_Assistant_AdhereTo = false;
            FrmClass.Example_List_AdhereTo = false;
            Cla_FrmClass.FrmMove(this, e);
        }

        private void panel_Title_MouseUp(object sender, MouseEventArgs e)
        {
            Cla_FrmClass.FrmPlace(this);
        }

        private void panel_Hide_Click(object sender, EventArgs e)
        {
            if (panel_Move.Visible)
                panel_Move.Visible = false;
            else
                panel_Move.Visible = true;
            Cla_FrmClass.Format_ListSize(listView_List);
        }

        private void pictureBox_Close_Click(object sender, EventArgs e)
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
            Cla_FrmClass.FrmScreen_EnlargeSize(this, (Panel)sender, e, 290, 145);
        }

        private void panel_Right_MouseUp(object sender, MouseEventArgs e)
        {
            Cla_FrmClass.FrmScreen_FormerlySize(this, 290, 145);
            Cla_FrmClass.Format_ListSize(listView_List);
        }

        private void ToolS_File_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "AVI文件(*.AVI)|*.avi|MP3文件(*.MP3)|*.mp3|DAT文件(*.DAT)|*.dat|WAV文件(*.WAV)|*.wav|RMVB文件(*.RMVB)|*.rmvb|RM文件(*.RM)|*.rm|ALL文件(*.*)|*.*";
            openFileDialog1.Title = "请选择播放文件";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (FrmClass.Example_ListMark < 0)
                    FrmClass.Example_ListMark = 0;
                if (listView_List.Items.Count > 0)
                {
                    listView_List.Items[FrmClass.Example_ListMark].BackColor = Color.DarkSeaGreen;
                    listView_List.Items[FrmClass.Example_ListMark].Selected = false;
                    listView_List.Items[FrmClass.Example_ListMark].Focused = false;
                }
                FrmClass.Example_AddFileSign = 1;
                FrmClass.Example_PlayPath = openFileDialog1.FileName;
                FrmMessage(0, FrmClass.Example_PlayPath);
                ((Frm_Play)FrmClass.F_MPlay).FrmMessage(0, FrmClass.Example_PlayPath);
                ((Frm_Play)FrmClass.F_MPlay).Show_BendInfo(FrmClass.Example_PlayPath);
                listView_List.Items[listView_List.Items.Count - 1].Selected = true;
                listView_List.Items[listView_List.Items.Count - 1].Focused = true;
                listView_List.Items[listView_List.Items.Count - 1].BackColor = Color.DarkGreen;
                FrmClass.Example_ListMark = listView_List.Items.Count - 1;
                
            }
        }

        private void listView_List_DoubleClick(object sender, EventArgs e)
        {
            if (listView_List.SelectedItems.Count > 0)
            {
                
                FrmClass.Example_PlayPath = listView_List.SelectedItems[0].SubItems[3].Text.Trim();
                if (!File.Exists(FrmClass.Example_PlayPath))
                {
                    MessageBox.Show("没有找到该媒体文件。");
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
                ((Frm_Play)FrmClass.F_MPlay).FrmMessage(0,FrmClass.Example_PlayPath);
                ((Frm_Play)FrmClass.F_MPlay).Show_BendInfo(FrmClass.Example_PlayPath);
                if (FrmClass.Example_ListMark < 0)
                    FrmClass.Example_ListMark = 0;
                listView_List.Items[FrmClass.Example_ListMark].BackColor = Color.DarkSeaGreen;
                listView_List.SelectedItems[0].BackColor = Color.DarkGreen;
                FrmClass.Example_ListMark = listView_List.SelectedItems[0].Index;

            }
        }

        private void ToolS_Mode01_Click(object sender, EventArgs e)
        {
            GetModeInfo(sender);
        }

        private void ToolS_Dir_Click(object sender, EventArgs e)
        {
            string Tem_Path = "";
            int Tem_Mark = 0;
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                Tem_Path = folderBrowserDialog1.SelectedPath;
            }
            if (Tem_Path.Length > 0)
            {
                string Tem_Name = "";
                bool Tem_ListBool = false;
                if (listView_List.Items.Count == 0)
                    Tem_ListBool = true;
                else
                    Tem_Mark = FrmClass.Example_ListMark;
                string Tem_Play = "";
                DirectoryInfo dir = new DirectoryInfo(Tem_Path);
                FileSystemInfo[] files = dir.GetFileSystemInfos();//获取文件夹中所有文件和文件夹
                //对单个FileSystemInfo进行判断,如果是文件夹则进行递归操作
                foreach (FileSystemInfo FSys in files)
                {
                    FileInfo file = FSys as FileInfo;
                    if (file != null)
                    {
                        Tem_Name = file.DirectoryName + "\\" + file.Name;
                        Tem_Name = Tem_Name.Substring(Tem_Name.LastIndexOf(Convert.ToChar(".")) + 1, Tem_Name.Length - Tem_Name.LastIndexOf(Convert.ToChar(".")) - 1);
                        if (Tem_Name.ToLower() == "mp3" || Tem_Name.ToLower() == "avi" || Tem_Name.ToLower() == "wav" || Tem_Name.ToLower() == "dat" || Tem_Name.ToLower() == "rmvb" || Tem_Name.ToLower() == "rm")
                        {
                            FrmClass.Example_AddFileSign = 1;
                            if (Tem_ListBool == true && Tem_Play.Length == 0)
                                Tem_Play = file.DirectoryName + "\\" + file.Name;
                            FrmMessage(1, file.DirectoryName + "\\" + file.Name);
                        }
                    }
                }

                if (Tem_ListBool == true)//如果列表中没有播放文件
                {
                    FrmClass.Example_PlayPath = Tem_Play;
                    ((Frm_Play)FrmClass.F_MPlay).FrmMessage(0, FrmClass.Example_PlayPath);
                    ((Frm_Play)FrmClass.F_MPlay).Show_BendInfo(FrmClass.Example_PlayPath);
                    listView_List.Items[0].Selected = true;
                    listView_List.Items[0].Focused = true;
                    listView_List.SelectedItems[0].BackColor = Color.DarkGreen;
                    FrmClass.Example_ListMark = 0;
                }
                else
                {
                    if (Tem_Mark < 0)
                        Tem_Mark = 0;
                    listView_List.Items[Tem_Mark].Selected = true;
                    listView_List.Items[Tem_Mark].Focused = true;
                    listView_List.SelectedItems[0].BackColor = Color.DarkGreen;
                    FrmClass.Example_ListMark = Tem_Mark;
                }
            }
        }

        private void ToolS_SelectFile_Click(object sender, EventArgs e)
        {
            List_DeleteFile(listView_List, Convert.ToInt32(((ToolStripMenuItem)sender).Tag.ToString()));
            Cla_FrmClass.m3uDelete(listView_Fname.Items[FrmClass.Example_ListNameNark].SubItems[1].Text);
            Cla_FrmClass.m3uCreate(listView_Fname.Items[FrmClass.Example_ListNameNark].SubItems[1].Text);
            string Local_Name = "";
            string Local_Time = "";
            string Local_Path = "";
            for (int i = 0; i < listView_List.Items.Count; i++)
            {
                Local_Name = listView_List.Items[i].SubItems[1].Text;
                Local_Time = listView_List.Items[i].SubItems[2].Text;
                Local_Path = listView_List.Items[i].SubItems[3].Text;
                Local_Time = Cla_FrmClass.BuildSec(Local_Time);
                Cla_FrmClass.m3uWrite(Local_Name, Local_Time, Local_Path, FrmClass.Example_ListNameDir);
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Cla_FrmClass.Frm_ShowAndHide(this);
            this.Hide();
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            Cla_FrmClass.ButtonChange((PictureBox)sender, Convert.ToInt16(((PictureBox)sender).Tag.ToString()), true);
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            Cla_FrmClass.ButtonChange((PictureBox)sender, Convert.ToInt16(((PictureBox)sender).Tag.ToString()), false);
        }

        private void listView_Fname_DoubleClick(object sender, EventArgs e)
        {
            FrmClass.Example_ListFClick = listView_Fname.SelectedIndices[0];
            int tem_n = 0;
            if (listView_Fname.SelectedIndices[0] != FrmClass.Example_ListNameNark)
            {
                tem_n = listView_Fname.SelectedIndices[0];
                Cla_FrmClass.Format_ListN(listView_List);
                Cla_FrmClass.Format_ListV(listView_List);

                listView_Fname.Items[listView_Fname.SelectedIndices[0]].Selected = false;
                listView_Fname.Items[FrmClass.Example_ListNameNark].Selected = true;
                listView_Fname.SelectedItems[0].BackColor = Color.DarkSeaGreen;
                listView_Fname.Items[FrmClass.Example_ListNameNark].Selected = false;
                FrmClass.Example_ListNameNark = tem_n;
                listView_Fname.Items[FrmClass.Example_ListNameNark].Selected = true;
                listView_Fname.SelectedItems[0].BackColor = Color.DarkGreen;

                FrmClass.Example_ListNameDir = listView_Fname.Items[FrmClass.Example_ListNameNark].SubItems[1].Text;
                Cla_FrmClass.m3uRead(listView_Fname.Items[FrmClass.Example_ListNameNark].SubItems[1].Text);
                if (FrmClass.AList.Count > 1)
                {
                    Cla_FrmClass.ListAddFile(listView_Fname, listView_List, FrmClass.AList);
                }
                FrmClass.Example_ListMark = -1;
            }
        }

        private void listView_Fname_AfterLabelEdit(object sender, LabelEditEventArgs e)
        {
            if (listView_Fname.SelectedItems[0].Text != e.Label)
            {
                string Tem_s = Cla_FrmClass.Folder_Handle(listView_Fname.SelectedItems[0].SubItems[1].Text, "", e.Label, 6);
                if (Tem_s!="")
                    listView_Fname.SelectedItems[0].SubItems[1].Text = Tem_s;
            }
            
        }

        private void ToolS_NewList_Click(object sender, EventArgs e)
        {
             Cla_FrmClass.List_ADDName(listView_Fname, Convert.ToInt16(((ToolStripMenuItem)sender).Tag.ToString()));
        }

        private void listView_Fname_Click(object sender, EventArgs e)
        {
            FrmClass.Example_ListFClick = listView_Fname.SelectedIndices[0];
        }

    }
}