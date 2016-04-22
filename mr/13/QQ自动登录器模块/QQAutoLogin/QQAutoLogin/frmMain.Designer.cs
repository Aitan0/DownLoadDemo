namespace QQAutoLogin
{
    partial class frmMain
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
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnExt = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnSet = new System.Windows.Forms.Button();
            this.imgQQ = new System.Windows.Forms.ImageList(this.components);
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnStartQQ = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.ToolStripMenuShowItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lvInfo = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.contextQQMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripMenuChgItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuDelItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextQQMenu.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExt
            // 
            this.btnExt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExt.BackgroundImage")));
            this.btnExt.FlatAppearance.BorderSize = 0;
            this.btnExt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExt.Location = new System.Drawing.Point(259, 248);
            this.btnExt.Name = "btnExt";
            this.btnExt.Size = new System.Drawing.Size(76, 24);
            this.btnExt.TabIndex = 1;
            this.btnExt.UseVisualStyleBackColor = true;
            this.btnExt.Click += new System.EventHandler(this.btnExt_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAbout.BackgroundImage")));
            this.btnAbout.FlatAppearance.BorderSize = 0;
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.Location = new System.Drawing.Point(259, 212);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(76, 24);
            this.btnAbout.TabIndex = 1;
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnSet
            // 
            this.btnSet.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSet.BackgroundImage")));
            this.btnSet.FlatAppearance.BorderSize = 0;
            this.btnSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSet.Location = new System.Drawing.Point(259, 174);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(76, 24);
            this.btnSet.TabIndex = 1;
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // imgQQ
            // 
            this.imgQQ.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgQQ.ImageStream")));
            this.imgQQ.TransparentColor = System.Drawing.Color.Transparent;
            this.imgQQ.Images.SetKeyName(0, "qq1.gif");
            this.imgQQ.Images.SetKeyName(1, "qq2.gif");
            // 
            // btnAdd
            // 
            this.btnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.BackgroundImage")));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(259, 136);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(76, 24);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnStartQQ
            // 
            this.btnStartQQ.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnStartQQ.BackgroundImage")));
            this.btnStartQQ.FlatAppearance.BorderSize = 0;
            this.btnStartQQ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartQQ.Location = new System.Drawing.Point(259, 98);
            this.btnStartQQ.Name = "btnStartQQ";
            this.btnStartQQ.Size = new System.Drawing.Size(76, 24);
            this.btnStartQQ.TabIndex = 1;
            this.btnStartQQ.UseVisualStyleBackColor = true;
            this.btnStartQQ.Click += new System.EventHandler(this.btnStartQQ_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnStart.BackgroundImage")));
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Location = new System.Drawing.Point(259, 60);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(76, 24);
            this.btnStart.TabIndex = 1;
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // ToolStripMenuShowItem
            // 
            this.ToolStripMenuShowItem.Name = "ToolStripMenuShowItem";
            this.ToolStripMenuShowItem.Size = new System.Drawing.Size(100, 22);
            this.ToolStripMenuShowItem.Text = "隐身";
            this.ToolStripMenuShowItem.Click += new System.EventHandler(this.ToolStripMenuShowItem_Click);
            // 
            // lvInfo
            // 
            this.lvInfo.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lvInfo.CheckBoxes = true;
            this.lvInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvInfo.ContextMenuStrip = this.contextQQMenu;
            this.lvInfo.ForeColor = System.Drawing.Color.Purple;
            this.lvInfo.FullRowSelect = true;
            this.lvInfo.GridLines = true;
            this.lvInfo.HideSelection = false;
            this.lvInfo.Location = new System.Drawing.Point(10, 20);
            this.lvInfo.MultiSelect = false;
            this.lvInfo.Name = "lvInfo";
            this.lvInfo.Scrollable = false;
            this.lvInfo.Size = new System.Drawing.Size(237, 251);
            this.lvInfo.SmallImageList = this.imgQQ;
            this.lvInfo.TabIndex = 2;
            this.lvInfo.UseCompatibleStateImageBehavior = false;
            this.lvInfo.View = System.Windows.Forms.View.Details;
            this.lvInfo.DoubleClick += new System.EventHandler(this.lvInfo_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "QQ号码";
            this.columnHeader1.Width = 114;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "上次登录时间";
            this.columnHeader2.Width = 120;
            // 
            // contextQQMenu
            // 
            this.contextQQMenu.BackColor = System.Drawing.SystemColors.HotTrack;
            this.contextQQMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuChgItem,
            this.ToolStripMenuDelItem,
            this.ToolStripMenuShowItem});
            this.contextQQMenu.Name = "contextQQMenu";
            this.contextQQMenu.Size = new System.Drawing.Size(101, 70);
            // 
            // ToolStripMenuChgItem
            // 
            this.ToolStripMenuChgItem.Name = "ToolStripMenuChgItem";
            this.ToolStripMenuChgItem.Size = new System.Drawing.Size(100, 22);
            this.ToolStripMenuChgItem.Text = "修改";
            this.ToolStripMenuChgItem.Click += new System.EventHandler(this.ToolStripMenuChgItem_Click);
            // 
            // ToolStripMenuDelItem
            // 
            this.ToolStripMenuDelItem.Name = "ToolStripMenuDelItem";
            this.ToolStripMenuDelItem.Size = new System.Drawing.Size(100, 22);
            this.ToolStripMenuDelItem.Text = "删除";
            this.ToolStripMenuDelItem.Click += new System.EventHandler(this.ToolStripMenuDelItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lvInfo);
            this.groupBox1.Controls.Add(this.btnExt);
            this.groupBox1.Controls.Add(this.btnAbout);
            this.groupBox1.Controls.Add(this.btnSet);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.btnStartQQ);
            this.groupBox1.Controls.Add(this.btnStart);
            this.groupBox1.Location = new System.Drawing.Point(-1, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 283);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "选择启动的QQ账号";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(340, 336);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 336);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QQ自动登录器";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.contextQQMenu.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExt;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.ImageList imgQQ;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnStartQQ;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuShowItem;
        private System.Windows.Forms.ListView lvInfo;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ContextMenuStrip contextQQMenu;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuChgItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuDelItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

