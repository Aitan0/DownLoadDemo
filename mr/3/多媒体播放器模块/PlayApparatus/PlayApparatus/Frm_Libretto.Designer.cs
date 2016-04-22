namespace PlayApparatus
{
    partial class Frm_Libretto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Libretto));
            this.pane_Title = new System.Windows.Forms.Panel();
            this.panel_zhong = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_TitleR = new System.Windows.Forms.Panel();
            this.panel_TitleL = new System.Windows.Forms.Panel();
            this.panel_All = new System.Windows.Forms.Panel();
            this.listBox_Lyric = new System.Windows.Forms.ListBox();
            this.panel_Right = new System.Windows.Forms.Panel();
            this.panel_Left = new System.Windows.Forms.Panel();
            this.panel_Bottom = new System.Windows.Forms.Panel();
            this.panel_BZ = new System.Windows.Forms.Panel();
            this.panel_BR = new System.Windows.Forms.Panel();
            this.panel_BL = new System.Windows.Forms.Panel();
            this.panel_Top = new System.Windows.Forms.Panel();
            this.pane_Title.SuspendLayout();
            this.panel_zhong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_All.SuspendLayout();
            this.panel_Bottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // pane_Title
            // 
            this.pane_Title.BackColor = System.Drawing.Color.Transparent;
            this.pane_Title.Controls.Add(this.panel_zhong);
            this.pane_Title.Controls.Add(this.panel_TitleR);
            this.pane_Title.Controls.Add(this.panel_TitleL);
            this.pane_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.pane_Title.Location = new System.Drawing.Point(0, 0);
            this.pane_Title.Name = "pane_Title";
            this.pane_Title.Size = new System.Drawing.Size(290, 21);
            this.pane_Title.TabIndex = 1;
            this.pane_Title.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pane_Title_MouseMove);
            this.pane_Title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pane_Title_MouseDown);
            this.pane_Title.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pane_Title_MouseUp);
            // 
            // panel_zhong
            // 
            this.panel_zhong.BackColor = System.Drawing.Color.Transparent;
            this.panel_zhong.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_zhong.BackgroundImage")));
            this.panel_zhong.Controls.Add(this.pictureBox1);
            this.panel_zhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_zhong.Location = new System.Drawing.Point(12, 0);
            this.panel_zhong.Name = "panel_zhong";
            this.panel_zhong.Size = new System.Drawing.Size(270, 21);
            this.panel_zhong.TabIndex = 2;
            this.panel_zhong.Tag = "2";
            this.panel_zhong.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pane_Title_MouseMove);
            this.panel_zhong.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pane_Title_MouseDown);
            this.panel_zhong.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pane_Title_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(254, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(11, 11);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "11";
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            // 
            // panel_TitleR
            // 
            this.panel_TitleR.BackColor = System.Drawing.Color.Transparent;
            this.panel_TitleR.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_TitleR.BackgroundImage")));
            this.panel_TitleR.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_TitleR.Location = new System.Drawing.Point(282, 0);
            this.panel_TitleR.Name = "panel_TitleR";
            this.panel_TitleR.Size = new System.Drawing.Size(8, 21);
            this.panel_TitleR.TabIndex = 1;
            this.panel_TitleR.Tag = "3";
            this.panel_TitleR.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pane_Title_MouseMove);
            this.panel_TitleR.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pane_Title_MouseDown);
            this.panel_TitleR.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pane_Title_MouseUp);
            // 
            // panel_TitleL
            // 
            this.panel_TitleL.BackColor = System.Drawing.Color.Transparent;
            this.panel_TitleL.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_TitleL.BackgroundImage")));
            this.panel_TitleL.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_TitleL.Location = new System.Drawing.Point(0, 0);
            this.panel_TitleL.Name = "panel_TitleL";
            this.panel_TitleL.Size = new System.Drawing.Size(12, 21);
            this.panel_TitleL.TabIndex = 0;
            this.panel_TitleL.Tag = "1";
            this.panel_TitleL.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pane_Title_MouseMove);
            this.panel_TitleL.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pane_Title_MouseDown);
            this.panel_TitleL.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pane_Title_MouseUp);
            // 
            // panel_All
            // 
            this.panel_All.BackColor = System.Drawing.Color.Honeydew;
            this.panel_All.Controls.Add(this.listBox_Lyric);
            this.panel_All.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_All.Location = new System.Drawing.Point(6, 21);
            this.panel_All.Name = "panel_All";
            this.panel_All.Size = new System.Drawing.Size(278, 258);
            this.panel_All.TabIndex = 11;
            this.panel_All.Resize += new System.EventHandler(this.panel_All_Resize);
            // 
            // listBox_Lyric
            // 
            this.listBox_Lyric.BackColor = System.Drawing.Color.Honeydew;
            this.listBox_Lyric.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox_Lyric.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listBox_Lyric.ForeColor = System.Drawing.Color.DarkGreen;
            this.listBox_Lyric.FormattingEnabled = true;
            this.listBox_Lyric.ItemHeight = 12;
            this.listBox_Lyric.Location = new System.Drawing.Point(0, 0);
            this.listBox_Lyric.Name = "listBox_Lyric";
            this.listBox_Lyric.Size = new System.Drawing.Size(310, 252);
            this.listBox_Lyric.TabIndex = 0;
            this.listBox_Lyric.MouseUp += new System.Windows.Forms.MouseEventHandler(this.listBox_Lyric_MouseUp);
            this.listBox_Lyric.MouseMove += new System.Windows.Forms.MouseEventHandler(this.listBox_Lyric_MouseMove);
            this.listBox_Lyric.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBox_Lyric_MouseDown);
            // 
            // panel_Right
            // 
            this.panel_Right.BackColor = System.Drawing.Color.Transparent;
            this.panel_Right.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_Right.BackgroundImage")));
            this.panel_Right.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.panel_Right.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_Right.Location = new System.Drawing.Point(284, 21);
            this.panel_Right.Name = "panel_Right";
            this.panel_Right.Size = new System.Drawing.Size(6, 258);
            this.panel_Right.TabIndex = 10;
            this.panel_Right.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_Right_MouseMove);
            this.panel_Right.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_Right_MouseDown);
            this.panel_Right.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_Right_MouseUp);
            // 
            // panel_Left
            // 
            this.panel_Left.BackColor = System.Drawing.Color.Transparent;
            this.panel_Left.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_Left.BackgroundImage")));
            this.panel_Left.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Left.Location = new System.Drawing.Point(0, 21);
            this.panel_Left.Name = "panel_Left";
            this.panel_Left.Size = new System.Drawing.Size(6, 258);
            this.panel_Left.TabIndex = 9;
            // 
            // panel_Bottom
            // 
            this.panel_Bottom.BackColor = System.Drawing.Color.Transparent;
            this.panel_Bottom.Controls.Add(this.panel_BZ);
            this.panel_Bottom.Controls.Add(this.panel_BR);
            this.panel_Bottom.Controls.Add(this.panel_BL);
            this.panel_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_Bottom.Location = new System.Drawing.Point(0, 279);
            this.panel_Bottom.Name = "panel_Bottom";
            this.panel_Bottom.Size = new System.Drawing.Size(290, 11);
            this.panel_Bottom.TabIndex = 8;
            this.panel_Bottom.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_Right_MouseMove);
            this.panel_Bottom.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_Right_MouseDown);
            this.panel_Bottom.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_Right_MouseUp);
            // 
            // panel_BZ
            // 
            this.panel_BZ.BackColor = System.Drawing.Color.Transparent;
            this.panel_BZ.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_BZ.BackgroundImage")));
            this.panel_BZ.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.panel_BZ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_BZ.Location = new System.Drawing.Point(8, 0);
            this.panel_BZ.Name = "panel_BZ";
            this.panel_BZ.Size = new System.Drawing.Size(274, 11);
            this.panel_BZ.TabIndex = 2;
            this.panel_BZ.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_Right_MouseMove);
            this.panel_BZ.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_Right_MouseDown);
            this.panel_BZ.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_Right_MouseUp);
            // 
            // panel_BR
            // 
            this.panel_BR.BackColor = System.Drawing.Color.Transparent;
            this.panel_BR.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_BR.BackgroundImage")));
            this.panel_BR.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.panel_BR.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_BR.Location = new System.Drawing.Point(282, 0);
            this.panel_BR.Name = "panel_BR";
            this.panel_BR.Size = new System.Drawing.Size(8, 11);
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
            this.panel_BL.Size = new System.Drawing.Size(8, 11);
            this.panel_BL.TabIndex = 0;
            this.panel_BL.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_Right_MouseMove);
            this.panel_BL.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_Right_MouseDown);
            this.panel_BL.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_Right_MouseUp);
            // 
            // panel_Top
            // 
            this.panel_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Top.Location = new System.Drawing.Point(0, 21);
            this.panel_Top.Name = "panel_Top";
            this.panel_Top.Size = new System.Drawing.Size(290, 0);
            this.panel_Top.TabIndex = 7;
            // 
            // Frm_Libretto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(290, 290);
            this.Controls.Add(this.panel_All);
            this.Controls.Add(this.panel_Right);
            this.Controls.Add(this.panel_Left);
            this.Controls.Add(this.panel_Bottom);
            this.Controls.Add(this.panel_Top);
            this.Controls.Add(this.pane_Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Libretto";
            this.Text = "Frm_Libretto";
            this.TransparencyKey = System.Drawing.Color.Maroon;
            this.Load += new System.EventHandler(this.Frm_Libretto_Load);
            this.pane_Title.ResumeLayout(false);
            this.panel_zhong.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_All.ResumeLayout(false);
            this.panel_Bottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pane_Title;
        private System.Windows.Forms.Panel panel_All;
        private System.Windows.Forms.Panel panel_Right;
        private System.Windows.Forms.Panel panel_Left;
        private System.Windows.Forms.Panel panel_Bottom;
        private System.Windows.Forms.Panel panel_Top;
        private System.Windows.Forms.ListBox listBox_Lyric;
        private System.Windows.Forms.Panel panel_TitleR;
        private System.Windows.Forms.Panel panel_TitleL;
        private System.Windows.Forms.Panel panel_zhong;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel_BR;
        private System.Windows.Forms.Panel panel_BL;
        private System.Windows.Forms.Panel panel_BZ;
    }
}