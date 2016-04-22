namespace PlayApparatus
{
    partial class Frm_Play
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Play));
            this.panel_Title = new System.Windows.Forms.Panel();
            this.pictureBox_Min = new System.Windows.Forms.PictureBox();
            this.pictureBox_Close = new System.Windows.Forms.PictureBox();
            this.panel_Cortrol = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox_Down = new System.Windows.Forms.PictureBox();
            this.pictureBox_Rest = new System.Windows.Forms.PictureBox();
            this.panel_Sound = new System.Windows.Forms.Panel();
            this.pictureBox_SoundHold = new System.Windows.Forms.PictureBox();
            this.pictureBox_SoundBar = new System.Windows.Forms.PictureBox();
            this.pictureBox_Stop = new System.Windows.Forms.PictureBox();
            this.pictureBox_Play = new System.Windows.Forms.PictureBox();
            this.panel_Show = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox_WF = new System.Windows.Forms.PictureBox();
            this.label_State = new System.Windows.Forms.Label();
            this.panel_Info = new System.Windows.Forms.Panel();
            this.listBox_BendInfo = new System.Windows.Forms.ListBox();
            this.label_Time = new System.Windows.Forms.Label();
            this.panel_Trough = new System.Windows.Forms.Panel();
            this.pictureBox_Hold = new System.Windows.Forms.PictureBox();
            this.pictureBox_Bar = new System.Windows.Forms.PictureBox();
            this.pictureBox_File = new System.Windows.Forms.PictureBox();
            this.pictureBox_Libretto = new System.Windows.Forms.PictureBox();
            this.pictureBox_List = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.timer_ShowTime = new System.Windows.Forms.Timer(this.components);
            this.timer_Bend = new System.Windows.Forms.Timer(this.components);
            this.panel_Title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Close)).BeginInit();
            this.panel_Cortrol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Down)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Rest)).BeginInit();
            this.panel_Sound.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_SoundHold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_SoundBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Stop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Play)).BeginInit();
            this.panel_Show.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_WF)).BeginInit();
            this.panel_Info.SuspendLayout();
            this.panel_Trough.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Hold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Bar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_File)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Libretto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_List)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Title
            // 
            this.panel_Title.BackColor = System.Drawing.Color.Transparent;
            this.panel_Title.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_Title.BackgroundImage")));
            this.panel_Title.Controls.Add(this.pictureBox_Min);
            this.panel_Title.Controls.Add(this.pictureBox_Close);
            this.panel_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Title.Location = new System.Drawing.Point(0, 0);
            this.panel_Title.Name = "panel_Title";
            this.panel_Title.Size = new System.Drawing.Size(290, 19);
            this.panel_Title.TabIndex = 2;
            this.panel_Title.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_Title_MouseMove);
            this.panel_Title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_Title_MouseDown);
            this.panel_Title.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_Title_MouseUp);
            // 
            // pictureBox_Min
            // 
            this.pictureBox_Min.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Min.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_Min.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Min.Image")));
            this.pictureBox_Min.Location = new System.Drawing.Point(249, 4);
            this.pictureBox_Min.Name = "pictureBox_Min";
            this.pictureBox_Min.Size = new System.Drawing.Size(11, 11);
            this.pictureBox_Min.TabIndex = 1;
            this.pictureBox_Min.TabStop = false;
            this.pictureBox_Min.Tag = "1";
            this.pictureBox_Min.MouseLeave += new System.EventHandler(this.pictureBox_Min_MouseLeave);
            this.pictureBox_Min.Click += new System.EventHandler(this.pictureBox_Min_Click);
            this.pictureBox_Min.MouseEnter += new System.EventHandler(this.pictureBox_Min_MouseEnter);
            // 
            // pictureBox_Close
            // 
            this.pictureBox_Close.BackColor = System.Drawing.Color.Gold;
            this.pictureBox_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_Close.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Close.Image")));
            this.pictureBox_Close.Location = new System.Drawing.Point(268, 4);
            this.pictureBox_Close.Name = "pictureBox_Close";
            this.pictureBox_Close.Size = new System.Drawing.Size(11, 11);
            this.pictureBox_Close.TabIndex = 0;
            this.pictureBox_Close.TabStop = false;
            this.pictureBox_Close.Tag = "2";
            this.pictureBox_Close.MouseLeave += new System.EventHandler(this.pictureBox_Min_MouseLeave);
            this.pictureBox_Close.Click += new System.EventHandler(this.pictureBox_Close_Click);
            this.pictureBox_Close.MouseEnter += new System.EventHandler(this.pictureBox_Min_MouseEnter);
            // 
            // panel_Cortrol
            // 
            this.panel_Cortrol.BackColor = System.Drawing.Color.Transparent;
            this.panel_Cortrol.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_Cortrol.BackgroundImage")));
            this.panel_Cortrol.Controls.Add(this.pictureBox2);
            this.panel_Cortrol.Controls.Add(this.pictureBox_Down);
            this.panel_Cortrol.Controls.Add(this.pictureBox_Rest);
            this.panel_Cortrol.Controls.Add(this.panel_Sound);
            this.panel_Cortrol.Controls.Add(this.pictureBox_Stop);
            this.panel_Cortrol.Controls.Add(this.pictureBox_Play);
            this.panel_Cortrol.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_Cortrol.Location = new System.Drawing.Point(0, 110);
            this.panel_Cortrol.Name = "panel_Cortrol";
            this.panel_Cortrol.Size = new System.Drawing.Size(290, 33);
            this.panel_Cortrol.TabIndex = 3;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(21, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(28, 28);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "7";
            this.pictureBox2.MouseLeave += new System.EventHandler(this.pictureBox_Min_MouseLeave);
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            this.pictureBox2.MouseEnter += new System.EventHandler(this.pictureBox_Min_MouseEnter);
            // 
            // pictureBox_Down
            // 
            this.pictureBox_Down.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Down.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_Down.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Down.Image")));
            this.pictureBox_Down.Location = new System.Drawing.Point(126, 1);
            this.pictureBox_Down.Name = "pictureBox_Down";
            this.pictureBox_Down.Size = new System.Drawing.Size(28, 28);
            this.pictureBox_Down.TabIndex = 8;
            this.pictureBox_Down.TabStop = false;
            this.pictureBox_Down.Tag = "10";
            this.pictureBox_Down.MouseLeave += new System.EventHandler(this.pictureBox_Min_MouseLeave);
            this.pictureBox_Down.Click += new System.EventHandler(this.pictureBox2_Click);
            this.pictureBox_Down.MouseEnter += new System.EventHandler(this.pictureBox_Min_MouseEnter);
            // 
            // pictureBox_Rest
            // 
            this.pictureBox_Rest.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Rest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_Rest.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Rest.Image")));
            this.pictureBox_Rest.Location = new System.Drawing.Point(172, 3);
            this.pictureBox_Rest.Name = "pictureBox_Rest";
            this.pictureBox_Rest.Size = new System.Drawing.Size(19, 19);
            this.pictureBox_Rest.TabIndex = 3;
            this.pictureBox_Rest.TabStop = false;
            this.pictureBox_Rest.Tag = "";
            this.pictureBox_Rest.Click += new System.EventHandler(this.pictureBox_Rest_Click);
            // 
            // panel_Sound
            // 
            this.panel_Sound.BackColor = System.Drawing.Color.Transparent;
            this.panel_Sound.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_Sound.BackgroundImage")));
            this.panel_Sound.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_Sound.Controls.Add(this.pictureBox_SoundHold);
            this.panel_Sound.Controls.Add(this.pictureBox_SoundBar);
            this.panel_Sound.Location = new System.Drawing.Point(195, 9);
            this.panel_Sound.Name = "panel_Sound";
            this.panel_Sound.Size = new System.Drawing.Size(83, 9);
            this.panel_Sound.TabIndex = 2;
            // 
            // pictureBox_SoundHold
            // 
            this.pictureBox_SoundHold.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_SoundHold.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_SoundHold.Image")));
            this.pictureBox_SoundHold.Location = new System.Drawing.Point(66, 0);
            this.pictureBox_SoundHold.Name = "pictureBox_SoundHold";
            this.pictureBox_SoundHold.Size = new System.Drawing.Size(17, 9);
            this.pictureBox_SoundHold.TabIndex = 1;
            this.pictureBox_SoundHold.TabStop = false;
            this.pictureBox_SoundHold.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_SoundHold_MouseMove);
            this.pictureBox_SoundHold.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_SoundHold_MouseDown);
            this.pictureBox_SoundHold.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_SoundHold_MouseUp);
            // 
            // pictureBox_SoundBar
            // 
            this.pictureBox_SoundBar.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_SoundBar.Image")));
            this.pictureBox_SoundBar.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_SoundBar.Name = "pictureBox_SoundBar";
            this.pictureBox_SoundBar.Size = new System.Drawing.Size(67, 9);
            this.pictureBox_SoundBar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_SoundBar.TabIndex = 0;
            this.pictureBox_SoundBar.TabStop = false;
            // 
            // pictureBox_Stop
            // 
            this.pictureBox_Stop.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Stop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_Stop.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Stop.Image")));
            this.pictureBox_Stop.Location = new System.Drawing.Point(91, 1);
            this.pictureBox_Stop.Name = "pictureBox_Stop";
            this.pictureBox_Stop.Size = new System.Drawing.Size(28, 28);
            this.pictureBox_Stop.TabIndex = 1;
            this.pictureBox_Stop.TabStop = false;
            this.pictureBox_Stop.Tag = "9";
            this.pictureBox_Stop.MouseLeave += new System.EventHandler(this.pictureBox_Min_MouseLeave);
            this.pictureBox_Stop.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox_Stop.MouseEnter += new System.EventHandler(this.pictureBox_Min_MouseEnter);
            // 
            // pictureBox_Play
            // 
            this.pictureBox_Play.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Play.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_Play.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Play.Image")));
            this.pictureBox_Play.Location = new System.Drawing.Point(56, 1);
            this.pictureBox_Play.Name = "pictureBox_Play";
            this.pictureBox_Play.Size = new System.Drawing.Size(28, 28);
            this.pictureBox_Play.TabIndex = 0;
            this.pictureBox_Play.TabStop = false;
            this.pictureBox_Play.Tag = "8";
            this.pictureBox_Play.MouseLeave += new System.EventHandler(this.pictureBox_Min_MouseLeave);
            this.pictureBox_Play.Click += new System.EventHandler(this.pictureBox_Play_Click);
            this.pictureBox_Play.MouseEnter += new System.EventHandler(this.pictureBox_Min_MouseEnter);
            // 
            // panel_Show
            // 
            this.panel_Show.BackColor = System.Drawing.Color.Transparent;
            this.panel_Show.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_Show.BackgroundImage")));
            this.panel_Show.Controls.Add(this.label1);
            this.panel_Show.Controls.Add(this.pictureBox_WF);
            this.panel_Show.Controls.Add(this.label_State);
            this.panel_Show.Controls.Add(this.panel_Info);
            this.panel_Show.Controls.Add(this.label_Time);
            this.panel_Show.Controls.Add(this.panel_Trough);
            this.panel_Show.Controls.Add(this.pictureBox_File);
            this.panel_Show.Controls.Add(this.pictureBox_Libretto);
            this.panel_Show.Controls.Add(this.pictureBox_List);
            this.panel_Show.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Show.Location = new System.Drawing.Point(0, 19);
            this.panel_Show.Name = "panel_Show";
            this.panel_Show.Size = new System.Drawing.Size(290, 91);
            this.panel_Show.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(137, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "状态：";
            // 
            // pictureBox_WF
            // 
            this.pictureBox_WF.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_WF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_WF.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_WF.Image")));
            this.pictureBox_WF.Location = new System.Drawing.Point(256, 73);
            this.pictureBox_WF.Name = "pictureBox_WF";
            this.pictureBox_WF.Size = new System.Drawing.Size(23, 15);
            this.pictureBox_WF.TabIndex = 7;
            this.pictureBox_WF.TabStop = false;
            this.pictureBox_WF.Tag = "6";
            this.pictureBox_WF.MouseLeave += new System.EventHandler(this.pictureBox_Min_MouseLeave);
            this.pictureBox_WF.Click += new System.EventHandler(this.pictureBox_WF_Click);
            this.pictureBox_WF.MouseEnter += new System.EventHandler(this.pictureBox_Min_MouseEnter);
            // 
            // label_State
            // 
            this.label_State.AutoSize = true;
            this.label_State.BackColor = System.Drawing.Color.Transparent;
            this.label_State.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_State.ForeColor = System.Drawing.SystemColors.Window;
            this.label_State.Location = new System.Drawing.Point(184, 31);
            this.label_State.Name = "label_State";
            this.label_State.Size = new System.Drawing.Size(29, 12);
            this.label_State.TabIndex = 6;
            this.label_State.Text = "停止";
            // 
            // panel_Info
            // 
            this.panel_Info.BackColor = System.Drawing.Color.Transparent;
            this.panel_Info.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_Info.BackgroundImage")));
            this.panel_Info.Controls.Add(this.listBox_BendInfo);
            this.panel_Info.Location = new System.Drawing.Point(12, 53);
            this.panel_Info.Name = "panel_Info";
            this.panel_Info.Size = new System.Drawing.Size(239, 19);
            this.panel_Info.TabIndex = 5;
            // 
            // listBox_BendInfo
            // 
            this.listBox_BendInfo.BackColor = System.Drawing.Color.ForestGreen;
            this.listBox_BendInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox_BendInfo.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listBox_BendInfo.ForeColor = System.Drawing.SystemColors.Window;
            this.listBox_BendInfo.FormattingEnabled = true;
            this.listBox_BendInfo.ItemHeight = 14;
            this.listBox_BendInfo.Location = new System.Drawing.Point(5, 0);
            this.listBox_BendInfo.Name = "listBox_BendInfo";
            this.listBox_BendInfo.Size = new System.Drawing.Size(256, 14);
            this.listBox_BendInfo.TabIndex = 0;
            // 
            // label_Time
            // 
            this.label_Time.BackColor = System.Drawing.Color.Transparent;
            this.label_Time.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Time.ForeColor = System.Drawing.SystemColors.Window;
            this.label_Time.Location = new System.Drawing.Point(24, 20);
            this.label_Time.Name = "label_Time";
            this.label_Time.Size = new System.Drawing.Size(69, 23);
            this.label_Time.TabIndex = 4;
            this.label_Time.Text = "00:00";
            // 
            // panel_Trough
            // 
            this.panel_Trough.BackColor = System.Drawing.Color.Transparent;
            this.panel_Trough.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_Trough.BackgroundImage")));
            this.panel_Trough.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_Trough.Controls.Add(this.pictureBox_Hold);
            this.panel_Trough.Controls.Add(this.pictureBox_Bar);
            this.panel_Trough.Location = new System.Drawing.Point(8, 77);
            this.panel_Trough.Name = "panel_Trough";
            this.panel_Trough.Size = new System.Drawing.Size(188, 9);
            this.panel_Trough.TabIndex = 3;
            // 
            // pictureBox_Hold
            // 
            this.pictureBox_Hold.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_Hold.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Hold.Image")));
            this.pictureBox_Hold.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_Hold.Name = "pictureBox_Hold";
            this.pictureBox_Hold.Size = new System.Drawing.Size(30, 9);
            this.pictureBox_Hold.TabIndex = 1;
            this.pictureBox_Hold.TabStop = false;
            this.pictureBox_Hold.LocationChanged += new System.EventHandler(this.pictureBox_Hold_LocationChanged);
            this.pictureBox_Hold.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_Hold_MouseMove);
            this.pictureBox_Hold.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_Hold_MouseDown);
            this.pictureBox_Hold.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_Hold_MouseUp);
            // 
            // pictureBox_Bar
            // 
            this.pictureBox_Bar.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Bar.Image")));
            this.pictureBox_Bar.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_Bar.Name = "pictureBox_Bar";
            this.pictureBox_Bar.Size = new System.Drawing.Size(0, 9);
            this.pictureBox_Bar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Bar.TabIndex = 0;
            this.pictureBox_Bar.TabStop = false;
            // 
            // pictureBox_File
            // 
            this.pictureBox_File.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_File.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_File.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_File.Image")));
            this.pictureBox_File.Location = new System.Drawing.Point(255, 49);
            this.pictureBox_File.Name = "pictureBox_File";
            this.pictureBox_File.Size = new System.Drawing.Size(24, 19);
            this.pictureBox_File.TabIndex = 2;
            this.pictureBox_File.TabStop = false;
            this.pictureBox_File.Tag = "3";
            this.pictureBox_File.MouseLeave += new System.EventHandler(this.pictureBox_Min_MouseLeave);
            this.pictureBox_File.Click += new System.EventHandler(this.pictureBox_File_Click);
            this.pictureBox_File.MouseEnter += new System.EventHandler(this.pictureBox_Min_MouseEnter);
            // 
            // pictureBox_Libretto
            // 
            this.pictureBox_Libretto.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Libretto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_Libretto.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Libretto.Image")));
            this.pictureBox_Libretto.Location = new System.Drawing.Point(228, 73);
            this.pictureBox_Libretto.Name = "pictureBox_Libretto";
            this.pictureBox_Libretto.Size = new System.Drawing.Size(23, 15);
            this.pictureBox_Libretto.TabIndex = 1;
            this.pictureBox_Libretto.TabStop = false;
            this.pictureBox_Libretto.Tag = "5";
            this.pictureBox_Libretto.MouseLeave += new System.EventHandler(this.pictureBox_Min_MouseLeave);
            this.pictureBox_Libretto.Click += new System.EventHandler(this.pictureBox_Libretto_Click);
            this.pictureBox_Libretto.MouseEnter += new System.EventHandler(this.pictureBox_Min_MouseEnter);
            // 
            // pictureBox_List
            // 
            this.pictureBox_List.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_List.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_List.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_List.Image")));
            this.pictureBox_List.Location = new System.Drawing.Point(202, 73);
            this.pictureBox_List.Name = "pictureBox_List";
            this.pictureBox_List.Size = new System.Drawing.Size(23, 15);
            this.pictureBox_List.TabIndex = 0;
            this.pictureBox_List.TabStop = false;
            this.pictureBox_List.Tag = "4";
            this.pictureBox_List.MouseLeave += new System.EventHandler(this.pictureBox_Min_MouseLeave);
            this.pictureBox_List.Click += new System.EventHandler(this.pictureBox_List_Click);
            this.pictureBox_List.MouseEnter += new System.EventHandler(this.pictureBox_Min_MouseEnter);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // timer_ShowTime
            // 
            this.timer_ShowTime.Tick += new System.EventHandler(this.timer_ShowTime_Tick);
            // 
            // timer_Bend
            // 
            this.timer_Bend.Interval = 1000;
            this.timer_Bend.Tick += new System.EventHandler(this.timer_Bend_Tick);
            // 
            // Frm_Play
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(290, 143);
            this.Controls.Add(this.panel_Show);
            this.Controls.Add(this.panel_Cortrol);
            this.Controls.Add(this.panel_Title);
            this.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Play";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "夜月播放器";
            this.TransparencyKey = System.Drawing.Color.Maroon;
            this.Load += new System.EventHandler(this.Frm_Play_Load);
            this.Shown += new System.EventHandler(this.Frm_Play_Shown);
            this.Activated += new System.EventHandler(this.Frm_Play_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_Play_FormClosing);
            this.panel_Title.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Close)).EndInit();
            this.panel_Cortrol.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Down)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Rest)).EndInit();
            this.panel_Sound.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_SoundHold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_SoundBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Stop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Play)).EndInit();
            this.panel_Show.ResumeLayout(false);
            this.panel_Show.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_WF)).EndInit();
            this.panel_Info.ResumeLayout(false);
            this.panel_Trough.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Hold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Bar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_File)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Libretto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_List)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Title;
        private System.Windows.Forms.Panel panel_Cortrol;
        private System.Windows.Forms.Panel panel_Show;
        private System.Windows.Forms.PictureBox pictureBox_Close;
        private System.Windows.Forms.PictureBox pictureBox_List;
        private System.Windows.Forms.PictureBox pictureBox_Libretto;
        private System.Windows.Forms.PictureBox pictureBox_File;
        public System.Windows.Forms.PictureBox pictureBox_Play;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox_Stop;
        private System.Windows.Forms.Panel panel_Trough;
        private System.Windows.Forms.PictureBox pictureBox_Bar;
        public System.Windows.Forms.PictureBox pictureBox_Hold;
        public System.Windows.Forms.Timer timer_ShowTime;
        private System.Windows.Forms.Label label_Time;
        private System.Windows.Forms.Panel panel_Info;
        private System.Windows.Forms.ListBox listBox_BendInfo;
        private System.Windows.Forms.Timer timer_Bend;
        private System.Windows.Forms.Label label_State;
        private System.Windows.Forms.Panel panel_Sound;
        private System.Windows.Forms.PictureBox pictureBox_SoundBar;
        private System.Windows.Forms.PictureBox pictureBox_SoundHold;
        private System.Windows.Forms.PictureBox pictureBox_Rest;
        private System.Windows.Forms.PictureBox pictureBox_WF;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox_Down;
        private System.Windows.Forms.PictureBox pictureBox_Min;
        private System.Windows.Forms.Label label1;

    }
}

