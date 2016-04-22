using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;//添加控件及窗体的命名空间
using System.Drawing;//添加Point的命名空间
using System.Collections;//为ArrayList添加命名空间
using System.Runtime.InteropServices;//API函数的命名空间
using System.IO;//文件操作的命名空间
//应用Scripting,在“添加引用”对话框中选中"COM"选项卡，然后选中Microsoft Scripting Runtime，单击“确定”按钮
//应用Shell32,在“添加引用”对话框中选中"COM"选项卡，然后选中Microsoft Shell Controls And Automation，单击“确定”按钮


namespace PlayApparatus
{
    class FrmClass
    {
        #region  记录窗体的实例化信息-公共变量
        public static Form F_List = new Form();
        public static Form F_Libretto = new Form();
        public static Form F_Screen = new Form();
        public static Form F_MPlay = new Form();
        #endregion

        #region  磁性窗体-公共变量
        //记录窗体的隐藏与显示
        public static bool Example_ListShow = false;
        public static bool Example_LibrettoShow = false;
        public static bool Example_ScreenShow = false;

        //记录鼠标的当前位置
        public static Point CPoint;  //添加命名空间using System.Drawing;
        public static Point FrmPoint;
        public static int Example_FSpace = 10;//设置窗体间的距离

        //Frm_Play窗体的位置及大小
        public static int Example_Play_Top = 0;
        public static int Example_Play_Left = 0;
        public static int Example_Play_Width = 0;
        public static int Example_Play_Height = 0;
        public static bool Example_Assistant_AdhereTo = false;//辅助窗体是否磁性在一起

        //Frm_ListBos窗体的位置及大小
        public static int Example_List_Top = 0;
        public static int Example_List_Left = 0;
        public static int Example_List_Width = 0;
        public static int Example_List_Height = 0;
        public static bool Example_List_AdhereTo = false;//辅助窗体是否与主窗体磁性在一起

        //Frm_Libretto窗体的位置及大小
        public static int Example_Libretto_Top = 0;
        public static int Example_Libretto_Left = 0;
        public static int Example_Libretto_Width = 0;
        public static int Example_Libretto_Height = 0;
        public static bool Example_Libretto_AdhereTo = false;//辅助窗体是否与主窗体磁性在一起

        //窗体之间的距离差
        public static int Example_List_space_Top = 0;
        public static int Example_List_space_Left = 0;
        public static int Example_Libretto_space_Top = 0;
        public static int Example_Libretto_space_Left = 0;
        #endregion

        #region  视频播放-公共变量
        public static bool Example_Size = false;
        public static int Example_X = 0;
        public static int Example_Y = 0;
        public static int Example_CursotX = 0;
        public static int Example_CursotY = 0;
        public static int Example_Width = 0;
        public static int Example_Height = 0;
        public static int Example_Right = 0;
        public static string Example_File_Size = "";
        public static double Example_TimeSizeD = 0;
        public static string Example_TimeSizeS = "";
        public static double Example_Barframe = 0;//移动条的帧数
        public static int Example_BarLeft = 0;
        public static string Example_PlayPath = "";//播放文件的路径
        public static ArrayList Example_ArrLyric = new ArrayList();
        public static int Example_LyC = 0;//存储字幕滚动的位置
        public static bool Example_ifLy = false;//是否有歌词文件
        public static ArrayList Example_FileInfoL = new ArrayList();
        public static int Example_Mode = 3;//播放模式的序号
        public static int Example_ListMark = 0;//当前列表的播放序号
        public static int Example_ListNameNark = 0;//列表中的列表名号
        public static string Example_ListNameDir = "";//当前m3u文件的路径
        public static string ImgDir = "";//图片的路径
        public static int Example_AddFileSign = 0;//添加文件的标识
        public static int Example_ListFClick = -1;//删除获取焦点的列表名称
        #endregion

        #region  检测各窗体是否连接在一起
        /// <summary>
        /// 检测各窗体是否连接在一起
        /// </summary>
        public void FrmBackCheck()
        {
            bool Tem_Magnetism = false;
            //Frm_ListBos与主窗体
            Tem_Magnetism = false;
            if ((Example_Play_Top - Example_List_Top) == 0)
                Tem_Magnetism = true;
            if ((Example_Play_Left - Example_List_Left) == 0)
                Tem_Magnetism = true;
            if ((Example_Play_Left - Example_List_Left - Example_List_Width) == 0)
                Tem_Magnetism = true;
            if ((Example_Play_Left - Example_List_Left + Example_List_Width) == 0)
                Tem_Magnetism = true;
            if ((Example_Play_Top - Example_List_Top - Example_List_Height) == 0)
                Tem_Magnetism = true;
            if ((Example_Play_Top - Example_List_Top + Example_List_Height) == 0)
                Tem_Magnetism = true;
            if (Tem_Magnetism)
                Example_List_AdhereTo = true;

            //Frm_Libretto与主窗体
            Tem_Magnetism = false;
            if ((Example_Play_Top - Example_Libretto_Top) == 0)
                Tem_Magnetism = true;
            if ((Example_Play_Left - Example_Libretto_Left) == 0)
                Tem_Magnetism = true;
            if ((Example_Play_Left - Example_Libretto_Left - Example_Libretto_Width) == 0)
                Tem_Magnetism = true;
            if ((Example_Play_Left - Example_Libretto_Left + Example_Libretto_Width) == 0)
                Tem_Magnetism = true;
            if ((Example_Play_Top - Example_Libretto_Top - Example_Libretto_Height) == 0)
                Tem_Magnetism = true;
            if ((Example_Play_Top - Example_Libretto_Top + Example_Libretto_Height) == 0)
                Tem_Magnetism = true;
            if (Tem_Magnetism)
                Example_Libretto_AdhereTo = true;

            //两个辅窗体
            Tem_Magnetism = false;
            if ((Example_List_Top - Example_Libretto_Top) == 0)
                Tem_Magnetism = true;
            if ((Example_List_Left - Example_Libretto_Left) == 0)
                Tem_Magnetism = true;
            if ((Example_List_Left - Example_Libretto_Left - Example_Libretto_Width) == 0)
                Tem_Magnetism = true;
            if ((Example_List_Left - Example_Libretto_Left + Example_Libretto_Width) == 0)
                Tem_Magnetism = true;
            if ((Example_List_Top - Example_Libretto_Top - Example_Libretto_Height) == 0)
                Tem_Magnetism = true;
            if ((Example_List_Top - Example_Libretto_Top + Example_Libretto_Height) == 0)
                Tem_Magnetism = true;
            if (Tem_Magnetism)
                Example_Assistant_AdhereTo = true;
        }
        #endregion

        #region  利用窗体上的控件移动窗体
        /// <summary>
        /// 利用控件移动窗体
        /// </summary>
        /// <param Frm="Form">窗体</param>
        /// <param e="MouseEventArgs">控件的移动事件</param>
        public void FrmMove(Form Frm, MouseEventArgs e)  //Form或MouseEventArgs添加命名空间using System.Windows.Forms;
        {
            if (e.Button == MouseButtons.Left)
            {
                Point myPosittion = Control.MousePosition;//获取当前鼠标的屏幕坐标
                myPosittion.Offset(CPoint.X, CPoint.Y);//重载当前鼠标的位置
                Frm.DesktopLocation = myPosittion;//设置当前窗体在屏幕上的位置
            }
        }
        #endregion

        #region  计算窗体之间的距离差
        /// <summary>
        /// 计算窗体之间的距离差
        /// </summary>
        /// <param Frm="Form">窗体</param>
        /// <param Follow="Form">跟随窗体</param>
        public void FrmDistanceJob(Form Frm, Form Follow)
        {
            switch (Follow.Name)
            {
                case "Frm_ListBox"://"列表"窗体
                    {
                        Example_List_space_Top = Follow.Top - Frm.Top;
                        Example_List_space_Left = Follow.Left - Frm.Left;
                        break;
                    }
                case "Frm_Libretto"://"歌词"窗体
                    {
                        Example_Libretto_space_Top = Follow.Top - Frm.Top;
                        Example_Libretto_space_Left = Follow.Left - Frm.Left;
                        break;
                    }
            }
        }
        #endregion

        #region  磁性窗体的移动
        /// <summary>
        /// 磁性窗体的移动
        /// </summary>
        /// <param Frm="Form">窗体</param>
        /// <param e="MouseEventArgs">控件的移动事件</param>
        /// <param Follow="Form">跟随窗体</param>
        public void ManyFrmMove(Form Frm, MouseEventArgs e, Form Follow)  //Form或MouseEventArgs添加命名空间using System.Windows.Forms;
        {
            if (e.Button == MouseButtons.Left)
            {
                int Tem_Left = 0;
                int Tem_Top = 0;
                Point myPosittion = Control.MousePosition;//获取当前鼠标的屏幕坐标
                switch (Follow.Name)
                {
                    case "Frm_ListBox":
                        {
                            Tem_Top = Example_List_space_Top - FrmPoint.Y;
                            Tem_Left = Example_List_space_Left - FrmPoint.X;
                            break;
                        }
                    case "Frm_Libretto":
                        {
                            Tem_Top = Example_Libretto_space_Top - FrmPoint.Y;
                            Tem_Left = Example_Libretto_space_Left - FrmPoint.X;
                            break;
                        }
                }
                myPosittion.Offset(Tem_Left, Tem_Top);
                Follow.DesktopLocation = myPosittion;
            }
        }
        #endregion

        #region  对窗体的位置进行初始化
        /// <summary>
        /// 对窗体的位置进行初始化
        /// </summary>
        /// <param Frm="Form">窗体</param>
        public void FrmInitialize(Form Frm)
        {
            switch (Frm.Name)
            {
                case "Frm_Play":
                    {
                        Example_Play_Top = Frm.Top;
                        Example_Play_Left = Frm.Left;
                        Example_Play_Width = Frm.Width;
                        Example_Play_Height = Frm.Height;
                        break;
                    }
                case "Frm_ListBox":
                    {
                        Example_List_Top = Frm.Top;
                        Example_List_Left = Frm.Left;
                        Example_List_Width = Frm.Width;
                        Example_List_Height = Frm.Height;
                        break;
                    }
                case "Frm_Libretto":
                    {
                        Example_Libretto_Top = Frm.Top;
                        Example_Libretto_Left = Frm.Left;
                        Example_Libretto_Width = Frm.Width;
                        Example_Libretto_Height = Frm.Height;
                        break;
                    }
            }

        }
        #endregion

        #region  存储各窗体的当前信息
        /// <summary>
        /// 存储各窗体的当前信息
        /// </summary>
        /// <param Frm="Form">窗体</param>
        /// <param e="MouseEventArgs">控件的移动事件</param>
        public void FrmPlace(Form Frm)
        {
            FrmInitialize(Frm);
            FrmMagnetism(Frm);
        }
        #endregion

        #region  窗体的磁性设置
        /// <summary>
        /// 窗体的磁性设置
        /// </summary>
        /// <param Frm="Form">窗体</param>
        public void FrmMagnetism(Form Frm)
        {
            if (Frm.Name != "Frm_Play")
            {
                FrmMagnetismCount(Frm, Example_Play_Top, Example_Play_Left, Example_Play_Width, Example_Play_Height, "Frm_Play");
            }
            if (Frm.Name != "Frm_ListBox")
            {
                FrmMagnetismCount(Frm, Example_List_Top, Example_List_Left, Example_List_Width, Example_List_Height, "Frm_ListBox");
            }
            if (Frm.Name != "Frm_Libretto")
            {
                FrmMagnetismCount(Frm, Example_Libretto_Top, Example_Libretto_Left, Example_Libretto_Width, Example_Libretto_Height, "Frm_Libretto");
            }
            FrmInitialize(Frm);
        }
        #endregion

        #region  磁性窗体的计算
        /// <summary>
        /// 磁性窗体的计算
        /// </summary>
        /// <param Frm="Form">子窗体</param>
        /// <param top="int">主窗体上边距</param>
        /// <param left="int">主窗体左边距</param>
        /// <param width="int">主窗体的宽度</param>
        /// <param height="int">主窗体的高度</param>
        /// <param Mforms="string">主窗体</param>
        public void FrmMagnetismCount(Form Frm, int top, int left, int width, int height, string Mforms)
        {
            bool Tem_Magnetism = false;//判断是否有磁性发生
            string Tem_MainForm = "";//临时记录主窗体
            string Tem_AssistForm = "";//临时记录辅窗体

            //上面进行磁性窗体
            if ((Frm.Top + Frm.Height - top) <= Example_FSpace && (Frm.Top + Frm.Height - top) >= -Example_FSpace)
            {
                //当一个主窗体不包含辅窗体时
                if ((Frm.Left >= left && Frm.Left <= (left + width)) || ((Frm.Left + Frm.Width) >= left && (Frm.Left + Frm.Width) <= (left + width)))
                {
                    Frm.Top = top - Frm.Height;
                    if ((Frm.Left - left) <= Example_FSpace && (Frm.Left - left) >= -Example_FSpace)
                        Frm.Left = left;
                    Tem_Magnetism = true;
                }
                //当一个主窗体包含辅窗体时
                if (Frm.Left <= left && (Frm.Left + Frm.Width) >= (left + width))
                {
                    Frm.Top = top - Frm.Height;
                    if ((Frm.Left - left) <= Example_FSpace && (Frm.Left - left) >= -Example_FSpace)
                        Frm.Left = left;
                    Tem_Magnetism = true;
                }

                if (Tem_Magnetism == true)
                {
                    if (Frm.Left == left)
                        Tem_Magnetism = false;
                }

            }
            else
                Tem_Magnetism = false;

            //下面进行磁性窗体
            if ((Frm.Top - (top + height)) <= Example_FSpace && (Frm.Top - (top + height)) >= -Example_FSpace)
            {
                //当一个主窗体不包含辅窗体时
                if ((Frm.Left >= left && Frm.Left <= (left + width)) || ((Frm.Left + Frm.Width) >= left && (Frm.Left + Frm.Width) <= (left + width)))
                {
                    Frm.Top = top + height;
                    if ((Frm.Left - left) <= Example_FSpace && (Frm.Left - left) >= -Example_FSpace)
                        Frm.Left = left;
                    Tem_Magnetism = true;
                }
                //当一个主窗体包含辅窗体时
                if (Frm.Left <= left && (Frm.Left + Frm.Width) >= (left + width))
                {
                    Frm.Top = top + height;
                    if ((Frm.Left - left) <= Example_FSpace && (Frm.Left - left) >= -Example_FSpace)
                        Frm.Left = left;
                    Tem_Magnetism = true;
                }

                if (Tem_Magnetism == true)
                {
                    if (Frm.Left == left)
                        Tem_Magnetism = false;
                }
            }
            else
                Tem_Magnetism = false;

            //左面进行磁性窗体
            if ((Frm.Left + Frm.Width - left) <= Example_FSpace && (Frm.Left + Frm.Width - left) >= -Example_FSpace)
            {
                //当一个主窗体不包含辅窗体时
                if ((Frm.Top > top && Frm.Top <= (top + height)) || ((Frm.Top + Frm.Height) >= top && (Frm.Top + Frm.Height) <= (top + height)))
                {
                    Frm.Left = left - Frm.Width;
                    if ((Frm.Top - top) <= Example_FSpace && (Frm.Top - top) >= -Example_FSpace)
                        Frm.Top = top;
                    Tem_Magnetism = true;
                }
                //当一个主窗体包含辅窗体时
                if (Frm.Top <= top && (Frm.Top + Frm.Height) >= (top + height))
                {
                    Frm.Left = left - Frm.Width;
                    if ((Frm.Top - top) <= Example_FSpace && (Frm.Top - top) >= -Example_FSpace)
                        Frm.Top = top;
                    Tem_Magnetism = true;
                }
            }
            else
                Tem_Magnetism = false;

            //右面进行磁性窗体
            if ((Frm.Left - (left + width)) <= Example_FSpace && (Frm.Left - (left + width)) >= -Example_FSpace)
            {
                //当一个主窗体不包含辅窗体时
                if ((Frm.Top > top && Frm.Top <= (top + height)) || ((Frm.Top + Frm.Height) >= top && (Frm.Top + Frm.Height) <= (top + height)))
                {
                    Frm.Left = left + width;
                    if ((Frm.Top - top) <= Example_FSpace && (Frm.Top - top) >= -Example_FSpace)
                        Frm.Top = top;
                    Tem_Magnetism = true;
                }
                //当一个主窗体包含辅窗体时
                if (Frm.Top <= top && (Frm.Top + Frm.Height) >= (top + height))
                {
                    Frm.Left = left + width;
                    if ((Frm.Top - top) <= Example_FSpace && (Frm.Top - top) >= -Example_FSpace)
                        Frm.Top = top;
                    Tem_Magnetism = true;
                }
            }
            else
                Tem_Magnetism = false;

            //if (Frm.Left == (left-Frm.Width) || Frm.Left == ((left + width)))
            //{
            //    if ((Frm.Top + Frm.Height - top) > Example_FSpace || (Frm.Top + Frm.Height - top) < -Example_FSpace)
            //        Tem_Magnetism = false;
            //}

            //if (Frm.Top == (top-Frm.Height) || Frm.Top == ((top + height)))
            //{
            //    if ((Frm.Left + Frm.Width - left) > Example_FSpace || (Frm.Left + Frm.Width - left) < -Example_FSpace)
            //        Tem_Magnetism = false;
            //}


            if (Frm.Name == "Frm_Play")
                Tem_MainForm = "Frm_Play";
            else
                Tem_AssistForm = Frm.Name;
            if (Mforms == "Frm_Play")
                Tem_MainForm = "Frm_Play";
            else
                Tem_AssistForm = Mforms;
            if (Tem_MainForm == "")
            {
                Example_Assistant_AdhereTo = Tem_Magnetism;
            }
            else
            {
                switch (Tem_AssistForm)
                {
                    case "Frm_ListBox":
                        Example_List_AdhereTo = Tem_Magnetism;
                        break;
                    case "Frm_Libretto":
                        Example_Libretto_AdhereTo = Tem_Magnetism;
                        break;
                }
            }
        }
        #endregion

        #region  获取播放窗体的信息
        /// <summary>
        /// 获取播放窗体的信息(用于鼠标的按下事件)
        /// </summary>
        /// <param Frm="Form">窗体</param>
        /// <param e="MouseEventArgs">窗体上有关鼠标的一些信息</param>
        public void FrmScreen_SizeInfo(Form Frm, Panel Pan, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Example_Size = true;
                Example_X = e.X;
                Example_Y = e.Y;
                Example_Width = Frm.Width;
                Example_Height = Frm.Height;
                Example_CursotX = Cursor.Position.X;
                Example_CursotY = Cursor.Position.Y;
                Example_Right = Frm.Width + Frm.Left;
            }
        }
        #endregion

        #region  改变播放窗体的大小
        /// <summary>
        /// 改变播放窗体的大小(用于鼠标的移动事件)
        /// </summary>
        /// <param Frm="Form">窗体</param>
        /// <param e="MouseEventArgs">窗体上有关鼠标的一些信息</param>
        public void FrmScreen_EnlargeSize(Form Frm, Panel Pan, MouseEventArgs e, int PWidth, int PHeight)
        {
            string panelName = "";
            if (e.Button == MouseButtons.Left)
            {
                if (Example_Size == false)
                    return;
                panelName = Pan.Name;
                if (Pan.Name == "panel_BL" || Pan.Name == "panel_BZ" || Pan.Name == "panel_BR")
                    panelName = "panel_Bottom";
                switch (panelName)
                {
                    case "panel_Right":
                        {
                            if (Frm.Width >= PWidth)
                            {
                                Frm.Width = Cursor.Position.X - Frm.Left + (Pan.Width - Example_X);
                                Frm.Height = PHeight + Frm.Width - PWidth;
                                Example_CursotX = Cursor.Position.X;

                            }
                            else
                            {
                                if (Cursor.Position.X > Example_CursotX)
                                {
                                    Frm.Width = Cursor.Position.X - Frm.Left + (Pan.Width - Example_X);
                                    Frm.Height = PHeight + Frm.Width - PWidth;
                                    Example_CursotX = Cursor.Position.X;
                                }
                                else
                                {
                                    Frm.Width = PWidth;
                                    Frm.Height = PHeight;
                                    Example_Size = false;
                                }
                            }
                            break;
                        }
                    case "panel_Bottom":
                        {
                            if (Frm.Height >= PHeight)
                            {
                                Frm.Height = Cursor.Position.Y - Frm.Top + (Pan.Height - Example_Y);
                                Frm.Width = 300 + Frm.Height - PHeight;
                                Example_CursotY = Cursor.Position.Y;
                            }
                            else
                            {
                                if (Cursor.Position.Y > Example_CursotY)
                                {
                                    Frm.Height = Cursor.Position.Y - Frm.Top + (Pan.Height - Example_Y);
                                    Frm.Width = PWidth + Frm.Height - PHeight;
                                    Example_CursotY = Cursor.Position.Y;
                                }
                                else
                                {
                                    Frm.Height = PHeight;
                                    Frm.Width = PWidth;
                                    Example_Size = false;
                                }
                            }
                            break;
                        }
                }

            }
        }
        #endregion

        #region  恢复窗体的初始大小
        /// <summary>
        /// 恢复窗体的初始大小(当松开鼠标时，如果窗体的大小小于300*200,恢复初始状态)
        /// </summary>
        /// <param Frm="Form">窗体</param>
        public void FrmScreen_FormerlySize(Form Frm, int PWidth, int PHeight)
        {
            if (Frm.Width < PWidth || Frm.Height < PHeight)
            {
                Frm.Width = PWidth;
                Frm.Height = PHeight;
                Example_Size = false;
            }
        }
        #endregion

        #region  窗体的隐藏与显示
        /// <summary>
        /// 窗体的隐藏与显示
        /// </summary>
        /// <param Frm="Form">窗体</param>
        public void Frm_ShowAndHide(Form Frm)
        {
            bool Tem_Bool = false;
            if (Frm.Name == "Frm_ListBox")
                Tem_Bool = Example_ListShow;
            if (Frm.Name == "Frm_Libretto")
                Tem_Bool = Example_LibrettoShow;
            if (Frm.Name == "Frm_Screen")
                Tem_Bool = Example_ScreenShow;
            if (Tem_Bool)
            {
                if (Frm.Name != "Frm_Screen")
                    for (double d = 1; d > 0; d -= 0.2)
                    {
                        System.Threading.Thread.Sleep(1);
                        Application.DoEvents();
                        Frm.Opacity = d;
                        Frm.Refresh();
                    }
                Frm.Opacity = 0;

                Frm.Hide();
                Tem_Bool = false;
            }
            else
            {
                Frm.Opacity = 0;
                Frm.Show();
                if (Frm.Name != "Frm_Screen")
                    for (double d = 0.01; d < 1; d += 0.2)
                    {
                        System.Threading.Thread.Sleep(1);
                        Application.DoEvents();
                        Frm.Opacity = d;
                        Frm.Refresh();
                    }
                Frm.Opacity = 1;
                Tem_Bool = true;
            }
            if (Frm.Name == "Frm_ListBox")
                Example_ListShow = Tem_Bool;
            if (Frm.Name == "Frm_Libretto")
                Example_LibrettoShow = Tem_Bool;
            if (Frm.Name == "Frm_Screen")
                Example_ScreenShow = Tem_Bool;
        }
        #endregion

        #region  对列表进行格式化
        /// <summary>
        ///  对列表进行格式化
        /// </summary>
        /// <param LV="ListView">ListView控件</param>
        public void Format_ListV(ListView LV)
        {
            LV.Items.Clear();//清空所有项的集合
            LV.Columns.Clear();//清空所有列的集合
            LV.View = View.Details;//显示列名称

            LV.HeaderStyle= ColumnHeaderStyle.None;//隐藏列标题
            LV.ForeColor = Color.White;
            LV.FullRowSelect = true;//在单击某项时，对其进行选中
            LV.Columns.Add("", 18, HorizontalAlignment.Left);//设置头像
            LV.Columns.Add("歌曲名", LV.Width - 80, HorizontalAlignment.Left);//设置头像
            LV.Columns.Add("时间", 57, HorizontalAlignment.Right);//设置头像
            LV.Columns.Add("", 0, HorizontalAlignment.Right);
        }

        /// <summary>
        ///  对列表格式进行格式化
        /// </summary>
        /// <param LV="ListView">ListView控件</param>
        public void Format_ListN(ListView LV)
        {
            LV.Items.Clear();//清空所有项的集合
            LV.Columns.Clear();//清空所有列的集合
            LV.View = View.Details;//显示列名称

            LV.HeaderStyle = ColumnHeaderStyle.None;//隐藏列标题
            LV.ForeColor = Color.White;
            LV.FullRowSelect = true;//在单击某项时，对其进行选中
            LV.Columns.Add("", LV.Width-2, HorizontalAlignment.Left);//显示名称
            LV.Columns.Add("", 0, HorizontalAlignment.Right);//路径
        }

        /// <summary>
        ///  操制列表各列标题的大小
        /// </summary>
        /// <param LV="ListView">ListView控件</param>
        public void Format_ListSize(ListView LV)
        {
            LV.Columns[0].Width = 18;
            LV.Columns[1].Width = LV.Width - 80;
            LV.Columns[2].Width = 57;
            LV.Columns[3].Width = 0;
        }
        #endregion

        #region  向列表中添加歌曲信息
        /// <summary>
        /// 向列表中添加歌曲信息
        /// </summary>
        /// <param LV="ListView">ListView控件</param>
        /// <param DS="DataSet">返回查找的数据集</param>
        public void Data_List(ListView LV, string Local_Name, string Local_Time, string Local_Path)  //Form或MouseEventArgs添加命名空间using System.Windows.Forms;
        {
            int Tem_Count = 0;
            if (LV.Items.Count == 0)
                Tem_Count = 1;
            else
                Tem_Count = LV.Items.Count + 1;
            ListViewItem item = new ListViewItem(Tem_Count.ToString());
            item.SubItems.Add(Local_Name);
            item.SubItems.Add(Local_Time);
            item.SubItems.Add(Local_Path);
            LV.Items.Add(item);
            LV.Items[LV.Items.Count - 1].BackColor = Color.DarkSeaGreen;
            if (Example_AddFileSign == 1)
            {
                Local_Time = BuildSec(Local_Time);
                m3uWrite(Local_Name, Local_Time, Local_Path, Example_ListNameDir);
                Example_AddFileSign = 0;
            }
        }

        /// <summary>
        /// 向列表中添加列表名称
        /// </summary>
        /// <param LV="ListView">ListView控件</param>
        /// <param DS="DataSet">返回查找的数据集</param>
        public void Data_List(ListView LV, string Local_Name, string Local_Path)  //Form或MouseEventArgs添加命名空间using System.Windows.Forms;
        {
            ListViewItem item = new ListViewItem(Local_Name);
            item.SubItems.Add(Local_Path);
            LV.Items.Add(item);
            LV.Items[LV.Items.Count - 1].BackColor = Color.DarkSeaGreen;
            //LV.Items[0].BackColor = Color.DarkGreen;
        }

        /// <summary>
        /// 将m3u文件的信息添加到列表中
        /// </summary>
        /// <param LV="ListView">ListView控件</param>
        /// <param Local_Name="string[]">返回查找的数据集</param>
        public void ListAddFile(ListView LV, ListView LVFile, ArrayList Array_LName)  //Form或MouseEventArgs添加命名空间using System.Windows.Forms;
        {
            int i=0;
            string Tem_name = "";//文件名称
            string Tem_Time = "";//播放时间
            string Tem_dir = "";//播放路径
            string Tem_info = "";//临时记录
            string[] Array_Name = new string[Array_LName.Count];
            foreach (string str in Array_LName)					//遍历ArrayList集合中的元素并输出
            {
                Array_Name[i] = str;
                i = i + 1;
            }
            i=0;

            while (true)
            {
                if (Array_Name[i] == "#EXTM3U")
                {
                    i = i + 1;
                    continue;
                }
                if (i > Array_Name.Length - 1)
                    break;
                if (Array_Name.Length < 2)
                    break;
                if (Array_Name[i].Substring(0, 7) == "#EXTINF")
                {
                    Tem_info = Array_Name[i];
                    Tem_Time = Tem_info.Substring(Tem_info.IndexOf(':') + 1, Tem_info.LastIndexOf(',') - Tem_info.IndexOf(':') - 1);
                    if (Tem_Time.IndexOf(',') > 0)
                        Tem_Time = Convert.ToString(InterceptFig(Tem_Time));
                    if (Tem_Time.Trim().Length > 0)
                        Tem_Time = GetFileTimeSec(Convert.ToInt32(Tem_Time));
                    Tem_name = Tem_info.Substring(Tem_info.LastIndexOf(',') + 1, Tem_info.Length - Tem_info.LastIndexOf(',') - 1);
                    Tem_dir = Array_Name[i + 1];
                    Data_List(LVFile, Tem_name, Tem_Time, Tem_dir);
                    i = i + 2;
                }
                if (i > Array_Name.Length - 2)
                    break;
            }

        }

        #endregion

        #region  获取播放文件的所有信息
        /// <summary>
        /// 获取播放文件的单个信息
        /// </summary>
        /// <param strF1="string">文件路径</param>
        /// <param iIndex="int">信息索引号</param>
        public string GetFileInfo(string strF1, int iIndex)
        {
            //应用Scripting,在“添加引用”对话框中选中"COM"选项卡，然后选中Microsoft Scripting Runtime，单击“确定”按钮
            Scripting.FileSystemObject fso = new Scripting.FileSystemObject();
            Scripting.File fl;
            string pth = "";
            string flname = "";

            //应用Shell32,在“添加引用”对话框中选中"COM"选项卡，然后选中Microsoft Shell Controls And Automation，单击“确定”按钮
            Shell32.Shell shl = new Shell32.Shell();
            Shell32.Folder shfd;
            string s = "";

            fl = fso.GetFile(strF1);
            pth = fl.ParentFolder.Path;
            flname = fl.Name;

            shfd = shl.NameSpace(pth);

            if (shfd.GetDetailsOf(0, iIndex) != "" || shfd.GetDetailsOf(shfd.Items().Item(flname), iIndex) != "")
                if (shfd.GetDetailsOf(shfd.Items().Item(flname), iIndex) != "")
                    s = shfd.GetDetailsOf(shfd.Items().Item(flname), iIndex);
                    //s = shfd.GetDetailsOf(0, iIndex) + "： " + shfd.GetDetailsOf(shfd.Items().Item(flname), iIndex);
                else
                    s = "";
                return s;
        }

        /// <summary>
        /// 获取播放文件的基本信息
        /// </summary>
        /// <param strF1="string">文件路径</param>
        public ArrayList GetFileDouble(string strF1)
        {
            ArrayList List = new ArrayList();
            int[] tem_ArrInt ={ 0, 10, 16, 17, 33, 22, 21, 1 };
            string[] tem_AStr ={ "", "", "", "", "", "", "", "" };
            string[] tem_ArrStr ={ "", "标题: ", "艺术家: ", "专辑: ", "格式: ", "长度: " };
            string mp = "";
            for (int i = 0; i < tem_ArrInt.Length; i++)
            {
                tem_AStr[i] = GetFileInfo(strF1.Trim(), tem_ArrInt[i]);
            }

            if (tem_AStr[0] != "")
                mp = tem_AStr[0].Substring(tem_AStr[0].Length - 3, 3);
            if (tem_AStr[1] != "" && tem_AStr[2] != "")
                List.Add(tem_AStr[2] + "-" + tem_AStr[1]);
            else
                List.Add(tem_AStr[0]);
            if (tem_AStr[1] != "")
                List.Add(tem_ArrStr[1] + tem_AStr[1]);
            if (tem_AStr[2] != "")
                List.Add(tem_ArrStr[2] + tem_AStr[2]);
            if (tem_AStr[3] != "")
                List.Add(tem_ArrStr[3] + tem_AStr[3]);
            if (tem_AStr[4] != "" || tem_AStr[5] != "")
                List.Add(tem_ArrStr[4] + mp + " " + tem_ArrStr[4] + tem_AStr[5]);
            //List.Add(tem_ArrStr[5] + GetFileTime(LongTime(strF1)));
            if (tem_AStr[7] != "")
            {
                float Tem_Size = InterceptFig(tem_AStr[7]);
                if (Tem_Size != 0)
                {
                    Example_File_Size = FormatMB(Tem_Size);
                }
            }
            return List;
        }
        #endregion

        #region  在字符串中截取数字
        /// <summary>
        /// 在字符串中截取数字
        /// </summary>
        /// <param Istr="string">包含数字的字符串</param>
        public int InterceptFig(string Istr)
        {
            string Tem_Sint = "";
            int Tem_Value=0;
            CharEnumerator Tem_CharEnum = Istr.GetEnumerator();
            while (Tem_CharEnum.MoveNext())
            {
                byte[] Tem_byte = new byte[1];
                Tem_byte = System.Text.Encoding.ASCII.GetBytes(Tem_CharEnum.Current.ToString());
                int Tem_ASCII_Code = (short)(Tem_byte[0]);
                if (Tem_ASCII_Code >= 48 && Tem_ASCII_Code <= 57)
                    Tem_Sint += Tem_CharEnum.Current.ToString();
            }
            if (Tem_Sint != "")
                Tem_Value = Convert.ToInt32(Tem_Sint.Trim());
            return Tem_Value;
        }
        #endregion

        #region  将KB转换成MB
        /// <summary>
        /// 将KB转换成MB
        /// </summary>
        /// <param Istr="string">包含数字的字符串</param>
        public string FormatMB(float Mb)
        {
            string Tem_MB = "";
            Mb = Mb / 1024;
            if (Mb > 1)
            {
                Tem_MB = Mb.ToString();
                Tem_MB = Tem_MB.Substring(0, Tem_MB.IndexOf(",") + 1) + "MB";
            }
            else
                Tem_MB = Mb.ToString() + "KB";

            return Tem_MB;
        }
        #endregion

        #region  获取文件的播放时间，并在列表中进行显示
        /// <summary>
        /// 获取文件的播放时间，并在列表中进行显示
        /// </summary>
        /// <param Millisecond="int">毫秒数</param>
        //添加using System.Runtime.InteropServices;API函数的命名空间
        [DllImport("kernel32.dll", CharSet = CharSet.Auto)]
        public static extern int GetShortPathName(string lpszLongPath, string shortFile, int cchBuffer);

        [DllImport("winmm.dll", EntryPoint = "mciSendString", CharSet = CharSet.Auto)]
        public static extern int mciSendString(string lpstrCommand, string lpstrReturnString, int uReturnLength, int hwndCallback);

        public int LongTime(string Spath)
        {
            string Pname = "";
            string TemStr = "";
            int ilong = 0;
            string tem_str = "";
            int t = 0;
            TemStr = TemStr.PadLeft(128, Convert.ToChar(" "));
            ilong = GetShortPathName(Spath, TemStr, TemStr.Length);
            Pname = "open " + Convert.ToChar(34) + Spath + Convert.ToChar(34) + " alias media";
            t = mciSendString(Pname, TemStr, TemStr.Length, 0);
            t = mciSendString("status " + Spath + " length", TemStr, 128, 0);
            tem_str = TemStr.Substring(0, TemStr.IndexOf("\0"));
            if (tem_str.Trim() == "")
                t = 0;
            else
                t = Convert.ToInt32(tem_str);
            return t;
        }
        #endregion

        #region  获取文件的播放时间，并按指定格式进行显示
        /// <summary>
        /// 获取文件的播放时间，并按指定格式进行显示
        /// </summary>
        /// <param Millisecond="int">毫秒数</param>
        public string GetFileTime(int Millisecond)
        {
            string Tem_Time = "";
            //double Tem_hour = 0;
            double Tem_min = 0;
            double Tem_sec = 0;
            double Tem_millisec = 0;

            Tem_min = Millisecond / 1000;
            Tem_min = Tem_min / 60.0;

            Tem_sec = Tem_min - (int)Tem_min;
            Tem_min = (int)Tem_min;
            Tem_sec = (60 * Tem_sec) / 100.0;
            Tem_sec = (int)(Tem_sec * 100);
            Tem_millisec = (int)((Millisecond - Tem_min * 60 * 1000 - Tem_sec * 1000) / 1000 * 100);
            //string Tem_Digit="";
            if (Tem_min >= 100)
            {
                Tem_Time = Tem_min.ToString("000") + ":" + Tem_sec.ToString("00");
            }
            else
                Tem_Time = Tem_min.ToString("00") + ":" + Tem_sec.ToString("00");
            return Tem_Time;
        }

        /// <summary>
        /// 获取文件的播放时间，并按指定格式进行显示
        /// </summary>
        /// <param Millisecond="int">秒数</param>
        public string GetFileTimeSec(int Millisecond)
        {
            string Tem_Time = "";
            //double Tem_hour = 0;
            double Tem_min = 0;
            double Tem_sec = 0;

            Tem_min = Millisecond / 60.0;

            Tem_sec = Tem_min - (int)Tem_min;
            Tem_min = (int)Tem_min;
            Tem_sec = (60 * Tem_sec) / 100.0;
            Tem_sec = (int)(Tem_sec * 100);
            if (Tem_min >= 100)
            {
                Tem_Time = Tem_min.ToString("000") + ":" + Tem_sec.ToString("00");
            }
            else
                Tem_Time = Tem_min.ToString("00") + ":" + Tem_sec.ToString("00");
            return Tem_Time;
        }
        #endregion

        #region  获取MP3的歌词
        /// <summary>
        /// 获取MP3的歌词
        /// </summary>
        /// <param FileName="string">歌词路径</param>
        public string[]  LRC_Lyric(string FileName)
        {
            ArrayList ArrLyric = new ArrayList();
            FileStream fs = new FileStream(@FileName, FileMode.Open, FileAccess.Read, FileShare.None);
            StreamReader sr = new StreamReader(fs, System.Text.Encoding.Default);
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            string Tem_strLine = sr.ReadLine();
            string Tem_Str = "";
            string sp = "";
            int Tem_p = 0;//记录当前[的位置
            int Tem_q = 0;//记录当前]的位置
            string Tem_Time = "";//时间
            string Tem_Slyrec = "";//歌词
            bool Tem_bool = true;//循环条件

            while (Tem_strLine != null)
            {
                Tem_bool = true;
                Tem_Str = Tem_strLine;
                sp = Tem_strLine;
                if (sp.IndexOf(Convert.ToChar("[")) == -1 || sp.Trim() == "")
                {
                    Tem_strLine = sr.ReadLine();
                    continue;
                }

                sp = sp.Substring(sp.IndexOf(Convert.ToChar("[")) + 1, 1);
                Tem_Slyrec = Tem_Str.Substring(Tem_Str.LastIndexOf(Convert.ToChar("]")) + 1, Tem_Str.Length - (Tem_Str.LastIndexOf(Convert.ToChar("]")) + 1));
                if (EstimateFig(sp))
                {
                    while (Tem_bool)
                    {
                        Tem_p = Tem_Str.IndexOf(Convert.ToChar("["));
                        Tem_q = Tem_Str.IndexOf(Convert.ToChar("]"));
                        Tem_Time = Tem_Str.Substring(Tem_p + 1, Tem_q - Tem_p - 1);
                        ArrLyric.Add(Tem_Time + "|" + Tem_Slyrec);
                        if (Tem_q != Tem_Str.LastIndexOf(Convert.ToChar("]")))
                            Tem_Str = Tem_Str.Substring(Tem_q + 1, Tem_Str.Length - Tem_q - 1);
                        else
                            Tem_bool = false;
                    }
                }
                Tem_strLine = sr.ReadLine();
            }
            sr.Dispose();
            fs.Dispose();

            int Tem_DatetimeUp;//记录前一个时间
            int Tem_DstetimeDown;//记录后一个时间
            string Tem_taxisTime = "";//记当截取后的时间字符串
            string Tem_Transitorily = "";//排序时临时存储的字符串
            string[] ArrayStr = new string[ArrLyric.Count];
            for (int i = 0; i < ArrayStr.Length; i++)
            {
                Tem_Str = ArrLyric[i].ToString();
                Tem_taxisTime = Tem_Str.Substring(0, Tem_Str.LastIndexOf(Convert.ToChar("|")));
                Tem_taxisTime = BuildMillisecond(Tem_taxisTime);
                ArrayStr[i] = Tem_taxisTime + "|" + Tem_Str.Substring(Tem_Str.LastIndexOf(Convert.ToChar("|")) + 1, Tem_Str.Length - Tem_Str.LastIndexOf(Convert.ToChar("|")) - 1);
            }
            string iStr = "";
            string jStr = "";
            for (int i = 0; i < ArrayStr.Length - 2; i++)
            {
                for (int j = 0; j < ArrayStr.Length - 1 - i; j++)
                {
                    iStr = ArrayStr[j];
                    jStr = ArrayStr[j + 1];
                    Tem_taxisTime = iStr.Substring(0, iStr.LastIndexOf(Convert.ToChar("|")));
                    Tem_DatetimeUp = Convert.ToInt32(Tem_taxisTime);
                    Tem_taxisTime = jStr.Substring(0, jStr.LastIndexOf(Convert.ToChar("|")));
                    Tem_DstetimeDown = Convert.ToInt32(Tem_taxisTime);
                    if (Tem_DstetimeDown < Tem_DatetimeUp)
                    {
                        Tem_Transitorily = ArrayStr[j];
                        ArrayStr[j] = ArrayStr[j + 1];
                        ArrayStr[j + 1] = Tem_Transitorily;
                    }
                }
            }
            return ArrayStr;
        }
        #endregion

        #region  在字符串中截取数字
        /// <summary>
        /// 在字符串中截取数字
        /// </summary>
        /// <param Istr="string">包含数字的字符串</param>
        public bool EstimateFig(string Istr)
        {
            string Tem_Sint = "";
            bool Tem_Bool = false;
            CharEnumerator Tem_CharEnum = Istr.GetEnumerator();
            while (Tem_CharEnum.MoveNext())
            {
                byte[] Tem_byte = new byte[1];
                Tem_byte = System.Text.Encoding.ASCII.GetBytes(Tem_CharEnum.Current.ToString());
                int Tem_ASCII_Code = (short)(Tem_byte[0]);
                if (Tem_ASCII_Code >= 48 && Tem_ASCII_Code <= 57)
                    Tem_Sint += Tem_CharEnum.Current.ToString();
            }
            if (Tem_Sint != "")
                Tem_Bool = true;
            return Tem_Bool;
        }
        #endregion

        #region  计算时间的毫秒数
        /// <summary>
        /// 计算时间的毫秒数
        /// </summary>
        /// <param Istr="string">时间</param>
        public string BuildMillisecond(string Istr)
        {
            string Tem_Value = "";
            int Tem_Cent = 0;
            int Tem_Sec = 0;
            int Tem_Mill = 0;
            Tem_Cent = Convert.ToInt32(Istr.Substring(0, Istr.IndexOf(Convert.ToChar(":"))));
            Tem_Sec = Convert.ToInt32(Istr.Substring(Istr.IndexOf(Convert.ToChar(":")) + 1, Istr.IndexOf(Convert.ToChar(".")) - Istr.IndexOf(Convert.ToChar(":")) - 1));
            Tem_Mill = Convert.ToInt32(Istr.Substring(Istr.IndexOf(Convert.ToChar(".")) + 1, Istr.Length - Istr.IndexOf(Convert.ToChar(".")) - 1));
            Tem_Cent = Tem_Cent * 60000 + Tem_Sec * 1000 + Tem_Mill;
            Tem_Value = Tem_Cent.ToString();
            return Tem_Value;
        }
        #endregion

        #region  计算时间的秒数
        /// <summary>
        /// 计算时间的毫秒数
        /// </summary>
        /// <param Istr="string">时间</param>
        public string BuildSec(string Istr)
        {
            string Tem_Value = "";
            if (Istr == "")
                return Tem_Value;
            int Tem_Cent = 0;
            int Tem_Sec = 0;
            Tem_Cent = Convert.ToInt32(Istr.Substring(0, Istr.IndexOf(Convert.ToChar(":"))));
            Tem_Sec = Convert.ToInt32(Istr.Substring(Istr.IndexOf(Convert.ToChar(":")) + 1, Istr.Length - Istr.IndexOf(Convert.ToChar(":")) - 1));
            Tem_Cent = Tem_Cent * 60 + Tem_Sec;
            Tem_Value = Tem_Cent.ToString();
            return Tem_Value;
        }
        #endregion

        #region  清空数组
        /// <summary>
        /// 清空数组
        /// </summary>
        /// <param Arr_List="ArrayList">数组名</param>
        public void ArrayList_Close( ArrayList Arr_List)
        {
            if (Arr_List.Count > 0)
            {
                for (int i = 0; i < Arr_List.Count; i++)
                    Arr_List.RemoveAt(0);
            }
        }
        #endregion

        #region  返回上一级目录
        /// <summary>
        /// 返回上一级目录
        /// </summary>
        /// <param dir="string">目录</param>
        /// <returns>返回String对象</returns>
        public string UpAndDown_Dir(string dir)
        {
            string Change_dir = "";
            if (dir.Length > 4)
                Change_dir = Directory.GetParent(dir).FullName;
            else
                Change_dir = dir;
            return Change_dir;
        }
        #endregion

        #region  获取图片路径
        /// <summary>
        /// 获取图片路径
        /// </summary>
        public void ImageDir()
        {
            string Tem_Imadir = "";
            Tem_Imadir = UpAndDown_Dir(System.AppDomain.CurrentDomain.BaseDirectory);
            Tem_Imadir = UpAndDown_Dir(Tem_Imadir);
            Tem_Imadir = UpAndDown_Dir(Tem_Imadir);
            ImgDir = Tem_Imadir;
        }
        #endregion

        #region  改变按钮的动态图片
        /// <summary>
        /// 改变按钮的动态图片
        /// </summary>
        /// <param PicBox="PictureBox">PictureBox控件</param>
        /// <param n="Int16">切换样式的标识</param>
        /// <param Bn="Boolean">判断切换的图片，True为新图片，False为原始图片</param>
        public void ButtonChange(PictureBox PicBox,Int16 n,Boolean Bn)
        {
            if (n > 0 && n <= 12)
                PicBox.Image = null;
            switch (n)
            {
                case 1://主窗体最小化按钮
                    {
                        if (Bn)
                            PicBox.Image = (Image)Properties.Resources.最小化按钮变色;
                        else
                            PicBox.Image = (Image)Properties.Resources.最小化按钮;
                        break;
                    }
                case 2://主窗体关闭按钮
                    {
                        if (Bn)
                            PicBox.Image = (Image)Properties.Resources.关闭按钮变色;
                        else
                            PicBox.Image = (Image)Properties.Resources.关闭按钮;
                        break;
                    }
                case 3://打开文件按钮
                    {
                        if (Bn)
                            PicBox.Image = (Image)Properties.Resources.打开文件列表变;
                        else
                            PicBox.Image = (Image)Properties.Resources.打开文件列表;
                        break;
                    }
                case 4://显示文件列表窗体按钮
                    {
                        if (Bn)
                            PicBox.Image = (Image)Properties.Resources.PL变;
                        else
                            PicBox.Image = (Image)Properties.Resources.PL;
                        break;
                    }
                case 5://显示歌词窗体按钮
                    {
                        if (Bn)
                            PicBox.Image = (Image)Properties.Resources.LRC变;
                        else
                            PicBox.Image = (Image)Properties.Resources.LRC;
                        break;
                    }
                case 6://显示视频窗体按钮
                    {
                        if (Bn)
                            PicBox.Image = (Image)Properties.Resources.WF变;
                        else
                            PicBox.Image = (Image)Properties.Resources.WF;
                        break;
                    }
                case 7://播放上一个文件按钮
                    {
                        if (Bn)
                            PicBox.Image = (Image)Properties.Resources.前进按钮变;
                        else
                            PicBox.Image = (Image)Properties.Resources.前进按钮;
                        break;
                    }
                case 8://文件播放按钮
                    {
                        if (Bn)
                            PicBox.Image = (Image)Properties.Resources.播放按钮变;
                        else
                            PicBox.Image = (Image)Properties.Resources.播放按钮;
                        break;
                    }
                case 9://文件停止按钮
                    {
                        if (Bn)
                            PicBox.Image = (Image)Properties.Resources.停止按钮变;
                        else
                            PicBox.Image = (Image)Properties.Resources.停止按钮;
                        break;
                    }
                case 10://播放下一个文件按钮
                    {
                        if (Bn)
                            PicBox.Image = (Image)Properties.Resources.后退按钮变;
                        else
                            PicBox.Image = (Image)Properties.Resources.后退按钮;
                        break;
                    }
                case 11:
                    {
                        if (Bn)
                            PicBox.Image = (Image)Properties.Resources.播放列表关闭按钮变;
                        else
                            PicBox.Image = (Image)Properties.Resources.播放列表的关闭按钮原;
                        break;
                    }
                case 12:
                    {
                        if (Bn)
                            PicBox.Image = (Image)Properties.Resources.暂停按钮变;
                        else
                            PicBox.Image = (Image)Properties.Resources.暂停按钮;
                        break;
                    }
            }
        }
        #endregion


        #region  创建m3u文件
        /// <summary>
        /// 创建m3u文件
        /// </summary>
        /// <param FileDir="string">目录</param>
        public void m3uCreate(string FileDir)
        {
            FileStream fs;
            Byte[] info;
            if (File.Exists(FileDir)) //如果文件存在,则退出操作
            {
                MessageBox.Show("文件已存在，请重新设置文件名。");
                return;
            }
            else    //如果文件不存在,则创建File.CreateText对象
            {
                fs = File.Create(FileDir);
            }
            info = new UTF8Encoding(true).GetBytes("#EXTM3U");
            fs.Write(info, 0, info.Length);
            fs.Close();
            fs.Dispose();
        }
        #endregion

        #region  写入m3u文件
        /// <summary>
        /// 写入m3u文件
        /// </summary>
        /// <param FileDir="string">目录</param>
        public void m3uWrite(string FName, string FTime, string FDir, string FileDir)
        {
            if (!File.Exists(FileDir))
            {
                MessageBox.Show("文件不存在。");
                return;
            }
            StreamWriter ASW = new StreamWriter(FileDir,true,Encoding.Default);
            ASW.WriteLine();
            ASW.Write("#EXTINF:" + FTime + "," + FName);
            ASW.WriteLine();
            ASW.Write(FDir, Encoding.Default);
            ASW.Flush();
            ASW.Close();
            ASW.Dispose();
        }
        #endregion

        #region  删除m3u文件
        /// <summary>
        /// 删除m3u文件
        /// </summary>
        /// <param FileDir="string">目录</param>
        public void m3uDelete(string FileDir)
        {
            if (!File.Exists(FileDir))
            {
                MessageBox.Show("文件不存在。");
                return;
            }
            File.Delete(FileDir);

        }
        #endregion

        public static ArrayList AList = new ArrayList();
        #region  读取m3u文件
        /// <summary>
        /// 读取m3u文件
        /// </summary>
        /// <param FileDir="string">目录</param>
        public void m3uRead(string FileDir)
        {
            if (!File.Exists(FileDir))
            {
                MessageBox.Show("文件不存在。");
                return;
            }
            AList.Clear();
            string S;
            StreamReader SR =new StreamReader(FileDir,Encoding.Default);
            S = SR.ReadLine();
            AList.Add(S);
            while (S != null)
            {
                S = SR.ReadLine();
                if (S == null)
                    break;
                AList.Add(S);
            }
            SR.Close();
            SR.Dispose();
        }
        #endregion

        #region  列表的相关操作
        /// <summary>
        /// 列表的相关操作
        /// </summary>
        /// <param LV="ListView">ListView控件</param>
        /// <param n="int">标识</param>
        public void List_ADDName(ListView LV,int n)
        {
            string tem_n="";
            switch (n)
            {
                case 1://新建列表
                    {

                        int tem_i = 0;
                        for (int i = 0; i < LV.Items.Count; i++)
                        {
                            tem_n = LV.Items[i].SubItems[0].Text;
                            if (tem_n.IndexOf("新建") > -1)
                            {
                                if (tem_n.Length == 3)
                                {
                                    if (tem_i <= Convert.ToInt16(tem_n.Substring(2, 1)))
                                        tem_i = Convert.ToInt16(tem_n.Substring(2, 1));
                                }
                            }
                        }
                        tem_i = tem_i + 1;
                        Data_List(LV, "新建" + tem_i.ToString(), UpAndDown_Dir(System.AppDomain.CurrentDomain.BaseDirectory) + "\\新建" + tem_i.ToString() + ".m3u");
                        m3uCreate(UpAndDown_Dir(System.AppDomain.CurrentDomain.BaseDirectory) + "\\新建" + tem_i.ToString() + ".m3u");
                        break;
                    }
                case 2://添加列表
                    {
                        string tem_newName = "";
                        OpenFileDialog FileD = new OpenFileDialog();
                        if (FileD.ShowDialog() == DialogResult.OK)
                        {
                            tem_n = FileD.FileName;
                            tem_newName = Folder_Handle(tem_n, "", "", n);
                            if (tem_newName.IndexOf('\\') >= 0)
                                Data_List(LV, File_Name(tem_newName, false), tem_newName);
                        }
                        break;
                    }
                case 3://打开列表
                    {
                        string tem_newName = "";
                        OpenFileDialog FileD = new OpenFileDialog();
                        FileD.Filter = "M3U文件(*.M3U)|*.m3u";
                        if (FileD.ShowDialog() == DialogResult.OK)
                        {
                            tem_n = FileD.FileName;
                            tem_newName = Folder_Handle(tem_n, "", "", 2);
                            if (tem_newName.IndexOf('\\') >= 0)
                                Data_List(LV, File_Name(tem_newName, false), tem_newName);

                            int tem_n2 = 0;
                            if ((LV.Items.Count - 1) > FrmClass.Example_ListNameNark)
                            {
                                tem_n2 = LV.Items.Count - 1;
                                Format_ListN(((Frm_ListBox)FrmClass.F_List).listView_List);
                                Format_ListV(((Frm_ListBox)FrmClass.F_List).listView_List);

                                LV.Items[Example_ListNameNark].Selected = true;
                                LV.SelectedItems[0].BackColor = Color.DarkSeaGreen;
                                LV.Items[Example_ListNameNark].Selected = false;

                                Example_ListNameNark = tem_n2;
                                LV.Items[Example_ListNameNark].Selected = true;
                                LV.Items[Example_ListNameNark].Focused = true;

                                LV.SelectedItems[0].BackColor = Color.DarkGreen;

                                Example_ListNameDir = LV.Items[Example_ListNameNark].SubItems[1].Text;
                                m3uRead(LV.Items[FrmClass.Example_ListNameNark].SubItems[1].Text);
                                if (FrmClass.AList.Count > 1)
                                {
                                    ListAddFile(LV, ((Frm_ListBox)FrmClass.F_List).listView_List, AList);
                                }
                                Example_ListMark = -1;
                            }

                        }
                        FileD.Dispose();
                        break;
                    }
                case 4://另存为
                    {
                        //Example_ListFClick
                        FolderBrowserDialog FileD = new FolderBrowserDialog();
                        if (FileD.ShowDialog() == DialogResult.OK)
                        {
                            tem_n = FileD.SelectedPath;
                            Folder_Handle(tem_n, LV.Items[Example_ListNameNark].SubItems[1].Text, "", n);
                        }
                        FileD.Dispose();
                        break;
                    }
                case 5://删除
                    {
                        if (Example_ListFClick < 0)
                        {
                            MessageBox.Show("请选择要删除的列表文件。");
                            break;
                        }
                        if (LV.Items[Example_ListFClick].SubItems[0].Text == "默认")
                        {
                            //MessageBox.Show("播放器的默认文件列表不能删除。");
                            break;
                            return;
                        }
                        if (Folder_Handle(LV.Items[Example_ListFClick].SubItems[1].Text, "", "", n) != "")
                        {
                            LV.Items[Example_ListNameNark].Selected = false;
                            LV.Items[Example_ListNameNark].Focused = false;

                            Format_ListN(((Frm_ListBox)FrmClass.F_List).listView_List);
                            Format_ListV(((Frm_ListBox)FrmClass.F_List).listView_List);

                            if (Example_ListFClick <= Example_ListNameNark)
                            {
                                int LVCount = (((Frm_ListBox)FrmClass.F_List).listView_List.Items.Count - 1);
                                LV.Items[Example_ListFClick].Remove();
                                LVCount = LVCount - 1;
                                if (Example_ListFClick < Example_ListNameNark)
                                {
                                    Example_ListNameNark = Example_ListNameNark - 1;
                                }
                                else if (Example_ListFClick == Example_ListNameNark)
                                {

                                    if ((LV.Items.Count-1) <= Example_ListFClick)
                                        Example_ListNameNark = 0;
                                }
                                LV.Items[Example_ListNameNark].Selected = true;
                                LV.Items[Example_ListNameNark].Focused = true;

                                LV.SelectedItems[0].BackColor = Color.DarkGreen;

                                Example_ListNameDir = LV.Items[Example_ListNameNark].SubItems[1].Text;
                                m3uRead(LV.Items[FrmClass.Example_ListNameNark].SubItems[1].Text);
                                if (FrmClass.AList.Count > 1)
                                {
                                    ListAddFile(LV, ((Frm_ListBox)FrmClass.F_List).listView_List, AList);
                                }
                            }
                            else
                            {
                                if (Example_ListFClick > Example_ListNameNark)
                                {
                                    LV.Items[Example_ListFClick].Remove();
                                    LV.Items[Example_ListNameNark].Selected = true;
                                    LV.Items[Example_ListNameNark].Focused = true;
                                }
                            }
                            Example_ListFClick = Example_ListNameNark;
                            
                        }
                        break;
                    }
            }
        }
        #endregion

        #region  文件名
        /// <summary>
        /// 文件名
        /// </summary>
        /// <param dir="string">目录</param>
        /// <param n="bool">判断是否带扩展名</param>
        public string File_Name(string dir, bool n)
        {
            if (dir.IndexOf('\\') < 0)
                return "";
            string Tem_FName = dir;
            Tem_FName = Tem_FName.Substring(Tem_FName.LastIndexOf('\\') + 1, Tem_FName.Length - Tem_FName.LastIndexOf('\\') - 1);
            if (!n)
                Tem_FName = Tem_FName.Substring(0, Tem_FName.LastIndexOf('.'));
            return Tem_FName;

        }
        #endregion

        #region  文件的操作
        /// <summary>
        /// 文件的操作
        /// </summary>
        /// <param dir="string">目的目录</param>
        /// <param Sdir="string">原目录</param>
        /// <param NewName="string">修改的文件名称</param>
        /// <param n="int">标识</param>
        /// <returns>返回string对象</returns>
        public string Folder_Handle(string dir, string Sdir, string NewName, int n)
        {

            string F_Name = "";//定义一个字符串变量，用于记录当前操作的是文件夹，还是文件
            string t = "";//定义一个整型变量
            if (dir.IndexOf('\\') < 0)
                return t;
            if (UpAndDown_Dir(System.AppDomain.CurrentDomain.BaseDirectory) == UpAndDown_Dir(dir) && n < 4)
            {
                MessageBox.Show("不能在同一个目录下进行操作。");
                return t;
            }

            switch (n)
            {
                case 2://添加列表文件
                    {
                        try
                        {
                            FileInfo FInfo = new FileInfo(dir);//根据文件的路径，实例化一个FileInfo类
                            string tem_AddFile = UpAndDown_Dir(System.AppDomain.CurrentDomain.BaseDirectory) + "\\" + File_Name(dir, true);
                            if (File.Exists(tem_AddFile))
                            {
                                string tem_add = File_Name(dir, false);
                                bool tem_have = true;
                                while (tem_have)
                                {
                                    tem_add = tem_add + "(1)";
                                    F_Name = UpAndDown_Dir(System.AppDomain.CurrentDomain.BaseDirectory) + "\\" + tem_add + ".m3u";
                                    if (!File.Exists(F_Name))
                                    {
                                        tem_have=false;
                                    }
                                }
                            }
                            else
                            {
                                F_Name = UpAndDown_Dir(System.AppDomain.CurrentDomain.BaseDirectory) + "\\" + File_Name(dir, true);
                            }
                            FInfo.CopyTo(F_Name, true);
                            t = F_Name;
                        }
                        catch (Exception ex)
                        {
                            t = "";//标识，如是t为空表示操作失败
                            MessageBox.Show("文件添加失败。");
                            break;
                        }
                        break;
                    }
                case 4:
                    {
                        try
                        {
                            FileInfo FInfo = new FileInfo(Sdir);//根据文件的路径，实例化一个FileInfo类
                            string tem_AddFile = dir + "\\" + File_Name(Sdir, true);
                            if (File.Exists(tem_AddFile))
                            {
                                string tem_add = File_Name(tem_AddFile, false);
                                bool tem_have = true;
                                while (tem_have)
                                {
                                    tem_add = tem_add + "(1)";
                                    F_Name = UpAndDown_Dir(tem_AddFile) + "\\" + tem_add + ".m3u";
                                    if (!File.Exists(F_Name))
                                    {
                                        tem_have = false;
                                    }
                                }
                            }
                            else
                            {
                                F_Name = dir + "\\" + File_Name(Sdir, true);
                            }
                            FInfo.CopyTo(F_Name, true);
                            t = F_Name;
                        }
                        catch (Exception ex)
                        {
                            t = "";//标识，如是t为空表示操作失败
                            MessageBox.Show("文件保存失败。");
                            break;
                        }
                        break;
                    }
                case 5:
                    {
                        try
                        {
                            FileInfo FInfo = new FileInfo(dir);//根据文件的路径，实例化一个FileInfo类
                            FInfo.Delete();
                            t = dir;
                            break;
                        }
                        catch (Exception ex)
                        {
                            t = "";//标识，如是t为空表示操作失败
                            MessageBox.Show("文件删除失败。");
                            break;
                        }
                        break;
                    }
                case 6:
                    {
                        try
                        {
                            FileInfo FInfo = new FileInfo(dir);//根据文件的路径，实例化一个FileInfo类
                            F_Name = UpAndDown_Dir(dir) + "//" + NewName + ".m3u";
                            FInfo.MoveTo(F_Name);
                            t = F_Name;
                            break;
                        }
                        catch (Exception ex)
                        {
                            t = "";//标识，如是t为空表示操作失败
                            MessageBox.Show("文件删除失败。");
                            break;
                        }
                        break;
                    }

            }
            return t;
        }
        #endregion








    }
}
