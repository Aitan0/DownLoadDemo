namespace PlayApparatus
{
    partial class Frm_ListBox
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        public void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ListBox));
            this.panel_Title = new System.Windows.Forms.Panel();
            this.panel_TitZ = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_TitR = new System.Windows.Forms.Panel();
            this.panel_TitL = new System.Windows.Forms.Panel();
            this.panel_Bottom = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_BR = new System.Windows.Forms.Panel();
            this.panel_BL = new System.Windows.Forms.Panel();
            this.panel_Left = new System.Windows.Forms.Panel();
            this.panel_Right = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Tool_AddFile = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolS_File = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolS_Dir = new System.Windows.Forms.ToolStripMenuItem();
            this.Tool_DeleteFile = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolS_SelectFile = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolSt_RepeatFile = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolS_ALLFile = new System.Windows.Forms.ToolStripMenuItem();
            this.Tool_List = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolS_NewList = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolS_ADDList = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolS_OpenList = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolS_SaveList = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolS_DeleteList = new System.Windows.Forms.ToolStripMenuItem();
            this.Tool_Mode = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolS_Mode01 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolS_Mode02 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolS_Mode03 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolS_Mode04 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolS_Mode05 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_Top = new System.Windows.Forms.Panel();
            this.panel_All = new System.Windows.Forms.Panel();
            this.listView_List = new System.Windows.Forms.ListView();
            this.panel_Hide = new System.Windows.Forms.Panel();
            this.panel_Move = new System.Windows.Forms.Panel();
            this.listView_Fname = new System.Windows.Forms.ListView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.panel_Title.SuspendLayout();
            this.panel_TitZ.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_Bottom.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel_All.SuspendLayout();
            this.panel_Move.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Title
            // 
            this.panel_Title.BackColor = System.Drawing.Color.Transparent;
            this.panel_Title.Controls.Add(this.panel_TitZ);
            this.panel_Title.Controls.Add(this.panel_TitR);
            this.panel_Title.Controls.Add(this.panel_TitL);
            this.panel_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Title.Location = new System.Drawing.Point(0, 0);
            this.panel_Title.Name = "panel_Title";
            this.panel_Title.Size = new System.Drawing.Size(290, 19);
            this.panel_Title.TabIndex = 0;
            this.panel_Title.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_Title_MouseMove);
            this.panel_Title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_Title_MouseDown);
            this.panel_Title.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_Title_MouseUp);
            // 
            // panel_TitZ
            // 
            this.panel_TitZ.BackColor = System.Drawing.Color.Transparent;
            this.panel_TitZ.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_TitZ.BackgroundImage")));
            this.panel_TitZ.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_TitZ.Controls.Add(this.pictureBox1);
            this.panel_TitZ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_TitZ.Location = new System.Drawing.Point(12, 0);
            this.panel_TitZ.Name = "panel_TitZ";
            this.panel_TitZ.Size = new System.Drawing.Size(270, 19);
            this.panel_TitZ.TabIndex = 2;
            this.panel_TitZ.Tag = "2";
            this.panel_TitZ.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_Title_MouseMove);
            this.panel_TitZ.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_Title_MouseDown);
            this.panel_TitZ.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_Title_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(253, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(11, 11);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "11";
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            // 
            // panel_TitR
            // 
            this.panel_TitR.BackColor = System.Drawing.Color.Transparent;
            this.panel_TitR.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_TitR.BackgroundImage")));
            this.panel_TitR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_TitR.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_TitR.Location = new System.Drawing.Point(282, 0);
            this.panel_TitR.Name = "panel_TitR";
            this.panel_TitR.Size = new System.Drawing.Size(8, 19);
            this.panel_TitR.TabIndex = 1;
            this.panel_TitR.Tag = "3";
            this.panel_TitR.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_Title_MouseMove);
            this.panel_TitR.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_Title_MouseDown);
            this.panel_TitR.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_Title_MouseUp);
            // 
            // panel_TitL
            // 
            this.panel_TitL.BackColor = System.Drawing.Color.Transparent;
            this.panel_TitL.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_TitL.BackgroundImage")));
            this.panel_TitL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_TitL.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_TitL.Location = new System.Drawing.Point(0, 0);
            this.panel_TitL.Name = "panel_TitL";
            this.panel_TitL.Size = new System.Drawing.Size(12, 19);
            this.panel_TitL.TabIndex = 0;
            this.panel_TitL.Tag = "1";
            this.panel_TitL.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_Title_MouseMove);
            this.panel_TitL.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_Title_MouseDown);
            this.panel_TitL.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_Title_MouseUp);
            // 
            // panel_Bottom
            // 
            this.panel_Bottom.BackColor = System.Drawing.Color.Transparent;
            this.panel_Bottom.Controls.Add(this.panel1);
            this.panel_Bottom.Controls.Add(this.panel_BR);
            this.panel_Bottom.Controls.Add(this.panel_BL);
            this.panel_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_Bottom.Location = new System.Drawing.Point(0, 135);
            this.panel_Bottom.Name = "panel_Bottom";
            this.panel_Bottom.Size = new System.Drawing.Size(290, 10);
            this.panel_Bottom.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(8, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(274, 10);
            this.panel1.TabIndex = 2;
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_Right_MouseMove);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_Right_MouseDown);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_Right_MouseUp);
            // 
            // panel_BR
            // 
            this.panel_BR.BackColor = System.Drawing.Color.Transparent;
            this.panel_BR.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_BR.BackgroundImage")));
            this.panel_BR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_BR.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.panel_BR.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_BR.Location = new System.Drawing.Point(282, 0);
            this.panel_BR.Name = "panel_BR";
            this.panel_BR.Size = new System.Drawing.Size(8, 10);
            this.panel_BR.TabIndex = 1;
            this.panel_BR.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_Right_MouseMove);
            this.panel_BR.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_Right_MouseDown);
            this.panel_BR.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_Right_MouseUp);
            // 
            // panel_BL
            // 
            this.panel_BL.BackColor = System.Drawing.Color.Transparent;
            this.panel_BL.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_BL.BackgroundImage")));
            this.panel_BL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_BL.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.panel_BL.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_BL.Location = new System.Drawing.Point(0, 0);
            this.panel_BL.Name = "panel_BL";
            this.panel_BL.Size = new System.Drawing.Size(8, 10);
            this.panel_BL.TabIndex = 0;
            this.panel_BL.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_Right_MouseMove);
            this.panel_BL.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_Right_MouseDown);
            this.panel_BL.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_Right_MouseUp);
            // 
            // panel_Left
            // 
            this.panel_Left.BackColor = System.Drawing.Color.Transparent;
            this.panel_Left.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_Left.BackgroundImage")));
            this.panel_Left.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Left.Location = new System.Drawing.Point(0, 19);
            this.panel_Left.Name = "panel_Left";
            this.panel_Left.Size = new System.Drawing.Size(6, 116);
            this.panel_Left.TabIndex = 2;
            // 
            // panel_Right
            // 
            this.panel_Right.BackColor = System.Drawing.Color.Transparent;
            this.panel_Right.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_Right.BackgroundImage")));
            this.panel_Right.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.panel_Right.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_Right.Location = new System.Drawing.Point(284, 19);
            this.panel_Right.Name = "panel_Right";
            this.panel_Right.Size = new System.Drawing.Size(6, 116);
            this.panel_Right.TabIndex = 3;
            this.panel_Right.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_Right_MouseMove);
            this.panel_Right.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_Right_MouseDown);
            this.panel_Right.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_Right_MouseUp);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Gainsboro;
            this.menuStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menuStrip1.BackgroundImage")));
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tool_AddFile,
            this.Tool_DeleteFile,
            this.Tool_List,
            this.Tool_Mode});
            this.menuStrip1.Location = new System.Drawing.Point(6, 19);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(278, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Tool_AddFile
            // 
            this.Tool_AddFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolS_File,
            this.ToolS_Dir});
            this.Tool_AddFile.Name = "Tool_AddFile";
            this.Tool_AddFile.Size = new System.Drawing.Size(41, 20);
            this.Tool_AddFile.Text = "添加";
            // 
            // ToolS_File
            // 
            this.ToolS_File.Name = "ToolS_File";
            this.ToolS_File.Size = new System.Drawing.Size(106, 22);
            this.ToolS_File.Text = "文件";
            this.ToolS_File.Click += new System.EventHandler(this.ToolS_File_Click);
            // 
            // ToolS_Dir
            // 
            this.ToolS_Dir.Name = "ToolS_Dir";
            this.ToolS_Dir.Size = new System.Drawing.Size(106, 22);
            this.ToolS_Dir.Text = "文件夹";
            this.ToolS_Dir.Click += new System.EventHandler(this.ToolS_Dir_Click);
            // 
            // Tool_DeleteFile
            // 
            this.Tool_DeleteFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolS_SelectFile,
            this.ToolSt_RepeatFile,
            this.ToolS_ALLFile});
            this.Tool_DeleteFile.Name = "Tool_DeleteFile";
            this.Tool_DeleteFile.Size = new System.Drawing.Size(41, 20);
            this.Tool_DeleteFile.Text = "删除";
            // 
            // ToolS_SelectFile
            // 
            this.ToolS_SelectFile.Name = "ToolS_SelectFile";
            this.ToolS_SelectFile.Size = new System.Drawing.Size(130, 22);
            this.ToolS_SelectFile.Tag = "0";
            this.ToolS_SelectFile.Text = "选中的文件";
            this.ToolS_SelectFile.Click += new System.EventHandler(this.ToolS_SelectFile_Click);
            // 
            // ToolSt_RepeatFile
            // 
            this.ToolSt_RepeatFile.Name = "ToolSt_RepeatFile";
            this.ToolSt_RepeatFile.Size = new System.Drawing.Size(130, 22);
            this.ToolSt_RepeatFile.Tag = "1";
            this.ToolSt_RepeatFile.Text = "重复的文件";
            this.ToolSt_RepeatFile.Click += new System.EventHandler(this.ToolS_SelectFile_Click);
            // 
            // ToolS_ALLFile
            // 
            this.ToolS_ALLFile.Name = "ToolS_ALLFile";
            this.ToolS_ALLFile.Size = new System.Drawing.Size(130, 22);
            this.ToolS_ALLFile.Tag = "2";
            this.ToolS_ALLFile.Text = "全部删除";
            this.ToolS_ALLFile.Click += new System.EventHandler(this.ToolS_SelectFile_Click);
            // 
            // Tool_List
            // 
            this.Tool_List.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolS_NewList,
            this.ToolS_ADDList,
            this.ToolS_OpenList,
            this.ToolS_SaveList,
            this.ToolS_DeleteList});
            this.Tool_List.Name = "Tool_List";
            this.Tool_List.Size = new System.Drawing.Size(41, 20);
            this.Tool_List.Text = "列表";
            // 
            // ToolS_NewList
            // 
            this.ToolS_NewList.Name = "ToolS_NewList";
            this.ToolS_NewList.Size = new System.Drawing.Size(152, 22);
            this.ToolS_NewList.Tag = "1";
            this.ToolS_NewList.Text = "新建列表";
            this.ToolS_NewList.Click += new System.EventHandler(this.ToolS_NewList_Click);
            // 
            // ToolS_ADDList
            // 
            this.ToolS_ADDList.Name = "ToolS_ADDList";
            this.ToolS_ADDList.Size = new System.Drawing.Size(152, 22);
            this.ToolS_ADDList.Tag = "2";
            this.ToolS_ADDList.Text = "添加列表";
            this.ToolS_ADDList.Click += new System.EventHandler(this.ToolS_NewList_Click);
            // 
            // ToolS_OpenList
            // 
            this.ToolS_OpenList.Name = "ToolS_OpenList";
            this.ToolS_OpenList.Size = new System.Drawing.Size(152, 22);
            this.ToolS_OpenList.Tag = "3";
            this.ToolS_OpenList.Text = "打开列表";
            this.ToolS_OpenList.Click += new System.EventHandler(this.ToolS_NewList_Click);
            // 
            // ToolS_SaveList
            // 
            this.ToolS_SaveList.Name = "ToolS_SaveList";
            this.ToolS_SaveList.Size = new System.Drawing.Size(152, 22);
            this.ToolS_SaveList.Tag = "4";
            this.ToolS_SaveList.Text = "保存列表";
            this.ToolS_SaveList.Click += new System.EventHandler(this.ToolS_NewList_Click);
            // 
            // ToolS_DeleteList
            // 
            this.ToolS_DeleteList.Name = "ToolS_DeleteList";
            this.ToolS_DeleteList.Size = new System.Drawing.Size(152, 22);
            this.ToolS_DeleteList.Tag = "5";
            this.ToolS_DeleteList.Text = "删除列表";
            this.ToolS_DeleteList.Click += new System.EventHandler(this.ToolS_NewList_Click);
            // 
            // Tool_Mode
            // 
            this.Tool_Mode.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolS_Mode01,
            this.ToolS_Mode02,
            this.ToolS_Mode03,
            this.ToolS_Mode04,
            this.ToolS_Mode05});
            this.Tool_Mode.Name = "Tool_Mode";
            this.Tool_Mode.Size = new System.Drawing.Size(41, 20);
            this.Tool_Mode.Text = "模式";
            // 
            // ToolS_Mode01
            // 
            this.ToolS_Mode01.Name = "ToolS_Mode01";
            this.ToolS_Mode01.Size = new System.Drawing.Size(118, 22);
            this.ToolS_Mode01.Tag = "1";
            this.ToolS_Mode01.Text = "单曲播放";
            this.ToolS_Mode01.Click += new System.EventHandler(this.ToolS_Mode01_Click);
            // 
            // ToolS_Mode02
            // 
            this.ToolS_Mode02.Name = "ToolS_Mode02";
            this.ToolS_Mode02.Size = new System.Drawing.Size(118, 22);
            this.ToolS_Mode02.Tag = "2";
            this.ToolS_Mode02.Text = "单曲循环";
            this.ToolS_Mode02.Click += new System.EventHandler(this.ToolS_Mode01_Click);
            // 
            // ToolS_Mode03
            // 
            this.ToolS_Mode03.Name = "ToolS_Mode03";
            this.ToolS_Mode03.Size = new System.Drawing.Size(118, 22);
            this.ToolS_Mode03.Tag = "3";
            this.ToolS_Mode03.Text = "顺序播放";
            this.ToolS_Mode03.Click += new System.EventHandler(this.ToolS_Mode01_Click);
            // 
            // ToolS_Mode04
            // 
            this.ToolS_Mode04.Name = "ToolS_Mode04";
            this.ToolS_Mode04.Size = new System.Drawing.Size(118, 22);
            this.ToolS_Mode04.Tag = "4";
            this.ToolS_Mode04.Text = "循环播放";
            this.ToolS_Mode04.Click += new System.EventHandler(this.ToolS_Mode01_Click);
            // 
            // ToolS_Mode05
            // 
            this.ToolS_Mode05.Name = "ToolS_Mode05";
            this.ToolS_Mode05.Size = new System.Drawing.Size(118, 22);
            this.ToolS_Mode05.Tag = "5";
            this.ToolS_Mode05.Text = "随机播放";
            this.ToolS_Mode05.Click += new System.EventHandler(this.ToolS_Mode01_Click);
            // 
            // panel_Top
            // 
            this.panel_Top.BackColor = System.Drawing.Color.Transparent;
            this.panel_Top.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_Top.BackgroundImage")));
            this.panel_Top.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Top.Location = new System.Drawing.Point(6, 43);
            this.panel_Top.Name = "panel_Top";
            this.panel_Top.Size = new System.Drawing.Size(278, 6);
            this.panel_Top.TabIndex = 5;
            // 
            // panel_All
            // 
            this.panel_All.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel_All.Controls.Add(this.listView_List);
            this.panel_All.Controls.Add(this.panel_Hide);
            this.panel_All.Controls.Add(this.panel_Move);
            this.panel_All.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_All.Location = new System.Drawing.Point(6, 49);
            this.panel_All.Name = "panel_All";
            this.panel_All.Size = new System.Drawing.Size(278, 86);
            this.panel_All.TabIndex = 6;
            // 
            // listView_List
            // 
            this.listView_List.BackColor = System.Drawing.Color.Honeydew;
            this.listView_List.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView_List.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView_List.Location = new System.Drawing.Point(61, 0);
            this.listView_List.Name = "listView_List";
            this.listView_List.Size = new System.Drawing.Size(217, 86);
            this.listView_List.TabIndex = 2;
            this.listView_List.UseCompatibleStateImageBehavior = false;
            this.listView_List.DoubleClick += new System.EventHandler(this.listView_List_DoubleClick);
            // 
            // panel_Hide
            // 
            this.panel_Hide.BackColor = System.Drawing.Color.YellowGreen;
            this.panel_Hide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel_Hide.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Hide.Location = new System.Drawing.Point(56, 0);
            this.panel_Hide.Name = "panel_Hide";
            this.panel_Hide.Size = new System.Drawing.Size(5, 86);
            this.panel_Hide.TabIndex = 1;
            this.panel_Hide.Click += new System.EventHandler(this.panel_Hide_Click);
            // 
            // panel_Move
            // 
            this.panel_Move.BackColor = System.Drawing.Color.Honeydew;
            this.panel_Move.Controls.Add(this.listView_Fname);
            this.panel_Move.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Move.Location = new System.Drawing.Point(0, 0);
            this.panel_Move.Name = "panel_Move";
            this.panel_Move.Size = new System.Drawing.Size(56, 86);
            this.panel_Move.TabIndex = 0;
            // 
            // listView_Fname
            // 
            this.listView_Fname.BackColor = System.Drawing.Color.Honeydew;
            this.listView_Fname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView_Fname.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView_Fname.LabelEdit = true;
            this.listView_Fname.Location = new System.Drawing.Point(0, 0);
            this.listView_Fname.Name = "listView_Fname";
            this.listView_Fname.Size = new System.Drawing.Size(56, 86);
            this.listView_Fname.TabIndex = 0;
            this.listView_Fname.UseCompatibleStateImageBehavior = false;
            this.listView_Fname.AfterLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.listView_Fname_AfterLabelEdit);
            this.listView_Fname.DoubleClick += new System.EventHandler(this.listView_Fname_DoubleClick);
            this.listView_Fname.Click += new System.EventHandler(this.listView_Fname_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Frm_ListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(290, 145);
            this.Controls.Add(this.panel_All);
            this.Controls.Add(this.panel_Top);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel_Right);
            this.Controls.Add(this.panel_Left);
            this.Controls.Add(this.panel_Bottom);
            this.Controls.Add(this.panel_Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_ListBox";
            this.Text = "Frm_ListBox";
            this.TransparencyKey = System.Drawing.Color.Maroon;
            this.Load += new System.EventHandler(this.Frm_ListBox_Load);
            this.panel_Title.ResumeLayout(false);
            this.panel_TitZ.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_Bottom.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel_All.ResumeLayout(false);
            this.panel_Move.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_Title;
        private System.Windows.Forms.Panel panel_Bottom;
        private System.Windows.Forms.Panel panel_Left;
        private System.Windows.Forms.Panel panel_Right;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Tool_AddFile;
        private System.Windows.Forms.ToolStripMenuItem ToolS_File;
        private System.Windows.Forms.ToolStripMenuItem ToolS_Dir;
        private System.Windows.Forms.ToolStripMenuItem Tool_DeleteFile;
        private System.Windows.Forms.ToolStripMenuItem ToolS_SelectFile;
        private System.Windows.Forms.ToolStripMenuItem ToolSt_RepeatFile;
        private System.Windows.Forms.ToolStripMenuItem ToolS_ALLFile;
        private System.Windows.Forms.ToolStripMenuItem Tool_List;
        private System.Windows.Forms.ToolStripMenuItem ToolS_NewList;
        private System.Windows.Forms.ToolStripMenuItem ToolS_ADDList;
        private System.Windows.Forms.ToolStripMenuItem ToolS_OpenList;
        private System.Windows.Forms.ToolStripMenuItem ToolS_SaveList;
        private System.Windows.Forms.ToolStripMenuItem ToolS_DeleteList;
        private System.Windows.Forms.ToolStripMenuItem Tool_Mode;
        private System.Windows.Forms.ToolStripMenuItem ToolS_Mode01;
        private System.Windows.Forms.ToolStripMenuItem ToolS_Mode02;
        private System.Windows.Forms.ToolStripMenuItem ToolS_Mode03;
        private System.Windows.Forms.ToolStripMenuItem ToolS_Mode04;
        private System.Windows.Forms.ToolStripMenuItem ToolS_Mode05;
        private System.Windows.Forms.Panel panel_Top;
        private System.Windows.Forms.Panel panel_All;
        public System.Windows.Forms.ListView listView_List;
        private System.Windows.Forms.Panel panel_Hide;
        private System.Windows.Forms.Panel panel_Move;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Panel panel_TitL;
        private System.Windows.Forms.Panel panel_TitZ;
        private System.Windows.Forms.Panel panel_TitR;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_BR;
        private System.Windows.Forms.Panel panel_BL;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.ListView listView_Fname;


    }
}