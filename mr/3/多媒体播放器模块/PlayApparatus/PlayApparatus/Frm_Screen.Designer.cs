namespace PlayApparatus
{
    partial class Frm_Screen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Screen));
            this.panel_Title = new System.Windows.Forms.Panel();
            this.panel_TZ = new System.Windows.Forms.Panel();
            this.pictureBox_Close = new System.Windows.Forms.PictureBox();
            this.pictureBox_Min = new System.Windows.Forms.PictureBox();
            this.panel_TR = new System.Windows.Forms.Panel();
            this.panel_TL = new System.Windows.Forms.Panel();
            this.panel_Bottom = new System.Windows.Forms.Panel();
            this.panel_BZ = new System.Windows.Forms.Panel();
            this.panel_BR = new System.Windows.Forms.Panel();
            this.panel_BL = new System.Windows.Forms.Panel();
            this.panel_Left = new System.Windows.Forms.Panel();
            this.panel_Right = new System.Windows.Forms.Panel();
            this.panel_Play = new System.Windows.Forms.Panel();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel_Title.SuspendLayout();
            this.panel_TZ.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Min)).BeginInit();
            this.panel_Bottom.SuspendLayout();
            this.panel_Play.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Title
            // 
            this.panel_Title.Controls.Add(this.panel_TZ);
            this.panel_Title.Controls.Add(this.panel_TR);
            this.panel_Title.Controls.Add(this.panel_TL);
            this.panel_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Title.Location = new System.Drawing.Point(0, 0);
            this.panel_Title.Name = "panel_Title";
            this.panel_Title.Size = new System.Drawing.Size(300, 19);
            this.panel_Title.TabIndex = 0;
            this.panel_Title.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_Top_MouseMove);
            this.panel_Title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_Top_MouseDown);
            this.panel_Title.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_Top_MouseUp);
            // 
            // panel_TZ
            // 
            this.panel_TZ.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_TZ.BackgroundImage")));
            this.panel_TZ.Controls.Add(this.pictureBox_Close);
            this.panel_TZ.Controls.Add(this.pictureBox_Min);
            this.panel_TZ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_TZ.Location = new System.Drawing.Point(12, 0);
            this.panel_TZ.Name = "panel_TZ";
            this.panel_TZ.Size = new System.Drawing.Size(280, 19);
            this.panel_TZ.TabIndex = 2;
            this.panel_TZ.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_Top_MouseMove);
            this.panel_TZ.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_Top_MouseDown);
            this.panel_TZ.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_Top_MouseUp);
            // 
            // pictureBox_Close
            // 
            this.pictureBox_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_Close.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Close.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Close.Image")));
            this.pictureBox_Close.Location = new System.Drawing.Point(267, 4);
            this.pictureBox_Close.Name = "pictureBox_Close";
            this.pictureBox_Close.Size = new System.Drawing.Size(11, 11);
            this.pictureBox_Close.TabIndex = 1;
            this.pictureBox_Close.TabStop = false;
            this.pictureBox_Close.Tag = "2";
            this.pictureBox_Close.MouseLeave += new System.EventHandler(this.pictureBox_Min_MouseLeave);
            this.pictureBox_Close.Click += new System.EventHandler(this.pictureBox_Close_Click);
            this.pictureBox_Close.MouseEnter += new System.EventHandler(this.pictureBox_Min_MouseEnter);
            // 
            // pictureBox_Min
            // 
            this.pictureBox_Min.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_Min.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Min.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Min.Image")));
            this.pictureBox_Min.Location = new System.Drawing.Point(249, 4);
            this.pictureBox_Min.Name = "pictureBox_Min";
            this.pictureBox_Min.Size = new System.Drawing.Size(11, 11);
            this.pictureBox_Min.TabIndex = 0;
            this.pictureBox_Min.TabStop = false;
            this.pictureBox_Min.Tag = "1";
            this.pictureBox_Min.MouseLeave += new System.EventHandler(this.pictureBox_Min_MouseLeave);
            this.pictureBox_Min.Click += new System.EventHandler(this.pictureBox_Min_Click);
            this.pictureBox_Min.MouseEnter += new System.EventHandler(this.pictureBox_Min_MouseEnter);
            // 
            // panel_TR
            // 
            this.panel_TR.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_TR.BackgroundImage")));
            this.panel_TR.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_TR.Location = new System.Drawing.Point(292, 0);
            this.panel_TR.Name = "panel_TR";
            this.panel_TR.Size = new System.Drawing.Size(8, 19);
            this.panel_TR.TabIndex = 1;
            this.panel_TR.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_Top_MouseMove);
            this.panel_TR.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_Top_MouseDown);
            this.panel_TR.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_Top_MouseUp);
            // 
            // panel_TL
            // 
            this.panel_TL.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_TL.BackgroundImage")));
            this.panel_TL.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_TL.Location = new System.Drawing.Point(0, 0);
            this.panel_TL.Name = "panel_TL";
            this.panel_TL.Size = new System.Drawing.Size(12, 19);
            this.panel_TL.TabIndex = 0;
            this.panel_TL.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_Top_MouseMove);
            this.panel_TL.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_Top_MouseDown);
            this.panel_TL.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_Top_MouseUp);
            // 
            // panel_Bottom
            // 
            this.panel_Bottom.Controls.Add(this.panel_BZ);
            this.panel_Bottom.Controls.Add(this.panel_BR);
            this.panel_Bottom.Controls.Add(this.panel_BL);
            this.panel_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_Bottom.Location = new System.Drawing.Point(0, 190);
            this.panel_Bottom.Name = "panel_Bottom";
            this.panel_Bottom.Size = new System.Drawing.Size(300, 10);
            this.panel_Bottom.TabIndex = 1;
            this.panel_Bottom.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_Right_MouseMove);
            this.panel_Bottom.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_Right_MouseDown);
            this.panel_Bottom.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_Right_MouseUp);
            // 
            // panel_BZ
            // 
            this.panel_BZ.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_BZ.BackgroundImage")));
            this.panel_BZ.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.panel_BZ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_BZ.Location = new System.Drawing.Point(8, 0);
            this.panel_BZ.Name = "panel_BZ";
            this.panel_BZ.Size = new System.Drawing.Size(284, 10);
            this.panel_BZ.TabIndex = 2;
            this.panel_BZ.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_Right_MouseMove);
            this.panel_BZ.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_Right_MouseDown);
            this.panel_BZ.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_Right_MouseUp);
            // 
            // panel_BR
            // 
            this.panel_BR.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_BR.BackgroundImage")));
            this.panel_BR.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.panel_BR.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_BR.Location = new System.Drawing.Point(292, 0);
            this.panel_BR.Name = "panel_BR";
            this.panel_BR.Size = new System.Drawing.Size(8, 10);
            this.panel_BR.TabIndex = 1;
            this.panel_BR.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_Right_MouseMove);
            this.panel_BR.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_Right_MouseDown);
            this.panel_BR.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_Right_MouseUp);
            // 
            // panel_BL
            // 
            this.panel_BL.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_BL.BackgroundImage")));
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
            this.panel_Left.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_Left.BackgroundImage")));
            this.panel_Left.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Left.Location = new System.Drawing.Point(0, 19);
            this.panel_Left.Name = "panel_Left";
            this.panel_Left.Size = new System.Drawing.Size(6, 171);
            this.panel_Left.TabIndex = 2;
            // 
            // panel_Right
            // 
            this.panel_Right.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_Right.BackgroundImage")));
            this.panel_Right.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.panel_Right.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_Right.Location = new System.Drawing.Point(294, 19);
            this.panel_Right.Name = "panel_Right";
            this.panel_Right.Size = new System.Drawing.Size(6, 171);
            this.panel_Right.TabIndex = 3;
            this.panel_Right.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_Right_MouseMove);
            this.panel_Right.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_Right_MouseDown);
            this.panel_Right.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_Right_MouseUp);
            // 
            // panel_Play
            // 
            this.panel_Play.BackColor = System.Drawing.Color.Black;
            this.panel_Play.Controls.Add(this.axWindowsMediaPlayer1);
            this.panel_Play.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Play.Location = new System.Drawing.Point(6, 19);
            this.panel_Play.Name = "panel_Play";
            this.panel_Play.Size = new System.Drawing.Size(288, 171);
            this.panel_Play.TabIndex = 4;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(0, 0);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(288, 171);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Frm_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(300, 200);
            this.Controls.Add(this.panel_Play);
            this.Controls.Add(this.panel_Right);
            this.Controls.Add(this.panel_Left);
            this.Controls.Add(this.panel_Bottom);
            this.Controls.Add(this.panel_Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Screen";
            this.Text = "夜月视频";
            this.TransparencyKey = System.Drawing.Color.Maroon;
            this.Load += new System.EventHandler(this.Frm_Screen_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_Screen_FormClosed);
            this.panel_Title.ResumeLayout(false);
            this.panel_TZ.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Min)).EndInit();
            this.panel_Bottom.ResumeLayout(false);
            this.panel_Play.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Title;
        private System.Windows.Forms.Panel panel_Bottom;
        private System.Windows.Forms.Panel panel_Left;
        private System.Windows.Forms.Panel panel_Right;
        private System.Windows.Forms.Panel panel_Play;
        public AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel_TL;
        private System.Windows.Forms.Panel panel_TR;
        private System.Windows.Forms.Panel panel_TZ;
        private System.Windows.Forms.Panel panel_BL;
        private System.Windows.Forms.Panel panel_BR;
        private System.Windows.Forms.Panel panel_BZ;
        private System.Windows.Forms.PictureBox pictureBox_Close;
        private System.Windows.Forms.PictureBox pictureBox_Min;


    }
}