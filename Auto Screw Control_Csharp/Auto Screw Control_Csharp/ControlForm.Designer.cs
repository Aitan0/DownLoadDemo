namespace Auto_Screw_Control_Csharp
{
    partial class ControlForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readConfigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openConfigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CountData = new System.Windows.Forms.TextBox();
            this.Count = new System.Windows.Forms.Label();
            this.PosDataView1 = new System.Windows.Forms.ListView();
            this.PosDataView2 = new System.Windows.Forms.ListView();
            this.Pos1 = new System.Windows.Forms.Label();
            this.Pos2 = new System.Windows.Forms.Label();
            this.Message = new System.Windows.Forms.TextBox();
            this.Position1Data = new System.Windows.Forms.TextBox();
            this.Position1 = new System.Windows.Forms.Label();
            this.Position2Data = new System.Windows.Forms.TextBox();
            this.Position2 = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.configToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(752, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pathToolStripMenuItem,
            this.readConfigToolStripMenuItem,
            this.toolStripMenuItem2,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // pathToolStripMenuItem
            // 
            this.pathToolStripMenuItem.Name = "pathToolStripMenuItem";
            this.pathToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.pathToolStripMenuItem.Text = "Path";
            // 
            // readConfigToolStripMenuItem
            // 
            this.readConfigToolStripMenuItem.Name = "readConfigToolStripMenuItem";
            this.readConfigToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.readConfigToolStripMenuItem.Text = "ReadConfig";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(169, 22);
            this.toolStripMenuItem2.Text = "-------------------";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.closeToolStripMenuItem.Text = "Close";
            // 
            // configToolStripMenuItem
            // 
            this.configToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openConfigToolStripMenuItem});
            this.configToolStripMenuItem.Name = "configToolStripMenuItem";
            this.configToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.configToolStripMenuItem.Text = "Config";
            // 
            // openConfigToolStripMenuItem
            // 
            this.openConfigToolStripMenuItem.Name = "openConfigToolStripMenuItem";
            this.openConfigToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openConfigToolStripMenuItem.Text = "OpenConfig";
            this.openConfigToolStripMenuItem.Click += new System.EventHandler(this.openConfigToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // CountData
            // 
            this.CountData.Location = new System.Drawing.Point(68, 123);
            this.CountData.Name = "CountData";
            this.CountData.Size = new System.Drawing.Size(100, 20);
            this.CountData.TabIndex = 1;
            // 
            // Count
            // 
            this.Count.AutoSize = true;
            this.Count.Location = new System.Drawing.Point(12, 123);
            this.Count.Name = "Count";
            this.Count.Size = new System.Drawing.Size(35, 13);
            this.Count.TabIndex = 2;
            this.Count.Text = "Count";
            // 
            // PosDataView1
            // 
            this.PosDataView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PosDataView1.FullRowSelect = true;
            this.PosDataView1.GridLines = true;
            this.PosDataView1.Location = new System.Drawing.Point(251, 56);
            this.PosDataView1.Name = "PosDataView1";
            this.PosDataView1.Size = new System.Drawing.Size(207, 239);
            this.PosDataView1.TabIndex = 3;
            this.PosDataView1.UseCompatibleStateImageBehavior = false;
            // 
            // PosDataView2
            // 
            this.PosDataView2.Location = new System.Drawing.Point(510, 56);
            this.PosDataView2.Name = "PosDataView2";
            this.PosDataView2.Size = new System.Drawing.Size(208, 239);
            this.PosDataView2.TabIndex = 4;
            this.PosDataView2.UseCompatibleStateImageBehavior = false;
            // 
            // Pos1
            // 
            this.Pos1.AutoSize = true;
            this.Pos1.Location = new System.Drawing.Point(335, 37);
            this.Pos1.Name = "Pos1";
            this.Pos1.Size = new System.Drawing.Size(31, 13);
            this.Pos1.TabIndex = 5;
            this.Pos1.Text = "Pos1";
            // 
            // Pos2
            // 
            this.Pos2.AutoSize = true;
            this.Pos2.Location = new System.Drawing.Point(587, 37);
            this.Pos2.Name = "Pos2";
            this.Pos2.Size = new System.Drawing.Size(31, 13);
            this.Pos2.TabIndex = 5;
            this.Pos2.Text = "Pos2";
            // 
            // Message
            // 
            this.Message.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Message.Location = new System.Drawing.Point(251, 328);
            this.Message.Name = "Message";
            this.Message.Size = new System.Drawing.Size(467, 80);
            this.Message.TabIndex = 6;
            // 
            // Position1Data
            // 
            this.Position1Data.Location = new System.Drawing.Point(68, 222);
            this.Position1Data.Name = "Position1Data";
            this.Position1Data.Size = new System.Drawing.Size(100, 20);
            this.Position1Data.TabIndex = 1;
            // 
            // Position1
            // 
            this.Position1.AutoSize = true;
            this.Position1.Location = new System.Drawing.Point(12, 222);
            this.Position1.Name = "Position1";
            this.Position1.Size = new System.Drawing.Size(50, 13);
            this.Position1.TabIndex = 2;
            this.Position1.Text = "Position1";
            // 
            // Position2Data
            // 
            this.Position2Data.Location = new System.Drawing.Point(68, 302);
            this.Position2Data.Name = "Position2Data";
            this.Position2Data.Size = new System.Drawing.Size(100, 20);
            this.Position2Data.TabIndex = 1;
            // 
            // Position2
            // 
            this.Position2.AutoSize = true;
            this.Position2.Location = new System.Drawing.Point(12, 302);
            this.Position2.Name = "Position2";
            this.Position2.Size = new System.Drawing.Size(50, 13);
            this.Position2.TabIndex = 2;
            this.Position2.Text = "Position2";
            // 
            // Timer
            // 
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // ControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 426);
            this.Controls.Add(this.Message);
            this.Controls.Add(this.Pos2);
            this.Controls.Add(this.Pos1);
            this.Controls.Add(this.PosDataView2);
            this.Controls.Add(this.PosDataView1);
            this.Controls.Add(this.Position2);
            this.Controls.Add(this.Position1);
            this.Controls.Add(this.Count);
            this.Controls.Add(this.Position2Data);
            this.Controls.Add(this.Position1Data);
            this.Controls.Add(this.CountData);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ControlForm";
            this.Text = "Auto Screw Control_Csharp";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pathToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem readConfigToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openConfigToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TextBox CountData;
        private System.Windows.Forms.Label Count;
        private System.Windows.Forms.ListView PosDataView1;
        private System.Windows.Forms.ListView PosDataView2;
        private System.Windows.Forms.Label Pos1;
        private System.Windows.Forms.Label Pos2;
        private System.Windows.Forms.TextBox Message;
        private System.Windows.Forms.TextBox Position1Data;
        private System.Windows.Forms.Label Position1;
        private System.Windows.Forms.TextBox Position2Data;
        private System.Windows.Forms.Label Position2;
        private System.Windows.Forms.Timer Timer;
    }
}

