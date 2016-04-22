namespace ServerGobang
{
    partial class Frm_Server
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
            this.ToolSMI_Server = new System.Windows.Forms.ToolStripMenuItem();
            this.Tool_Open = new System.Windows.Forms.ToolStripMenuItem();
            this.Tool_Arrange = new System.Windows.Forms.ToolStripMenuItem();
            this.Tool_BS = new System.Windows.Forms.ToolStripMenuItem();
            this.Tool_SB = new System.Windows.Forms.ToolStripMenuItem();
            this.Tool_Refurbish = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolSMI_Windows = new System.Windows.Forms.ToolStripMenuItem();
            this.Tool_Close = new System.Windows.Forms.ToolStripMenuItem();
            this.LV_SysUser = new System.Windows.Forms.ListView();
            this.ColumnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.ColumnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.ColumnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.udpSocket1 = new GobangClass.UDPSocket(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolSMI_Server,
            this.ToolSMI_Windows});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(596, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ToolSMI_Server
            // 
            this.ToolSMI_Server.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tool_Open,
            this.Tool_Arrange,
            this.Tool_Refurbish});
            this.ToolSMI_Server.Name = "ToolSMI_Server";
            this.ToolSMI_Server.Size = new System.Drawing.Size(53, 20);
            this.ToolSMI_Server.Text = "控制台";
            // 
            // Tool_Open
            // 
            this.Tool_Open.Name = "Tool_Open";
            this.Tool_Open.Size = new System.Drawing.Size(118, 22);
            this.Tool_Open.Text = "开始服务";
            this.Tool_Open.Click += new System.EventHandler(this.Tool_Open_Click);
            // 
            // Tool_Arrange
            // 
            this.Tool_Arrange.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tool_BS,
            this.Tool_SB});
            this.Tool_Arrange.Name = "Tool_Arrange";
            this.Tool_Arrange.Size = new System.Drawing.Size(118, 22);
            this.Tool_Arrange.Text = "分数排名";
            // 
            // Tool_BS
            // 
            this.Tool_BS.Name = "Tool_BS";
            this.Tool_BS.Size = new System.Drawing.Size(118, 22);
            this.Tool_BS.Text = "从大到小";
            this.Tool_BS.Click += new System.EventHandler(this.Tool_BS_Click);
            // 
            // Tool_SB
            // 
            this.Tool_SB.Name = "Tool_SB";
            this.Tool_SB.Size = new System.Drawing.Size(118, 22);
            this.Tool_SB.Text = "从小到大";
            this.Tool_SB.Click += new System.EventHandler(this.Tool_SB_Click);
            // 
            // Tool_Refurbish
            // 
            this.Tool_Refurbish.Name = "Tool_Refurbish";
            this.Tool_Refurbish.Size = new System.Drawing.Size(118, 22);
            this.Tool_Refurbish.Text = "刷新";
            this.Tool_Refurbish.Click += new System.EventHandler(this.Tool_Refurbish_Click);
            // 
            // ToolSMI_Windows
            // 
            this.ToolSMI_Windows.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tool_Close});
            this.ToolSMI_Windows.Name = "ToolSMI_Windows";
            this.ToolSMI_Windows.Size = new System.Drawing.Size(41, 20);
            this.ToolSMI_Windows.Text = "系统";
            // 
            // Tool_Close
            // 
            this.Tool_Close.Name = "Tool_Close";
            this.Tool_Close.Size = new System.Drawing.Size(94, 22);
            this.Tool_Close.Text = "退出";
            this.Tool_Close.Click += new System.EventHandler(this.Tool_Close_Click);
            // 
            // LV_SysUser
            // 
            this.LV_SysUser.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader1,
            this.ColumnHeader2,
            this.ColumnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.LV_SysUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LV_SysUser.FullRowSelect = true;
            this.LV_SysUser.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.LV_SysUser.Location = new System.Drawing.Point(0, 24);
            this.LV_SysUser.Name = "LV_SysUser";
            this.LV_SysUser.Size = new System.Drawing.Size(596, 333);
            this.LV_SysUser.TabIndex = 16;
            this.LV_SysUser.UseCompatibleStateImageBehavior = false;
            this.LV_SysUser.View = System.Windows.Forms.View.Details;
            // 
            // ColumnHeader1
            // 
            this.ColumnHeader1.Text = "ID";
            this.ColumnHeader1.Width = 72;
            // 
            // ColumnHeader2
            // 
            this.ColumnHeader2.Text = "IP地址";
            this.ColumnHeader2.Width = 158;
            // 
            // ColumnHeader3
            // 
            this.ColumnHeader3.Text = "端口";
            this.ColumnHeader3.Width = 94;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "用户名";
            this.columnHeader4.Width = 127;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "用户分数";
            this.columnHeader5.Width = 80;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "状态";
            // 
            // udpSocket1
            // 
            this.udpSocket1.Active = false;
            this.udpSocket1.LocalHost = "127.0.0.1";
            this.udpSocket1.LocalPort = 11000;
            this.udpSocket1.DataArrival += new GobangClass.UDPSocket.DataArrivalEventHandler(this.udpSocket1_DataArrival);
            // 
            // Frm_Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 357);
            this.Controls.Add(this.LV_SysUser);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Frm_Server";
            this.Text = "网络五子棋服务器";
            this.Shown += new System.EventHandler(this.Frm_Server_Shown);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_Server_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GobangClass.UDPSocket udpSocket1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolSMI_Server;
        private System.Windows.Forms.ToolStripMenuItem Tool_Open;
        private System.Windows.Forms.ToolStripMenuItem ToolSMI_Windows;
        private System.Windows.Forms.ToolStripMenuItem Tool_Close;
        internal System.Windows.Forms.ListView LV_SysUser;
        internal System.Windows.Forms.ColumnHeader ColumnHeader1;
        internal System.Windows.Forms.ColumnHeader ColumnHeader2;
        internal System.Windows.Forms.ColumnHeader ColumnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ToolStripMenuItem Tool_Arrange;
        private System.Windows.Forms.ToolStripMenuItem Tool_BS;
        private System.Windows.Forms.ToolStripMenuItem Tool_SB;
        private System.Windows.Forms.ToolStripMenuItem Tool_Refurbish;
    }
}

