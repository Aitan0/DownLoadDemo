namespace Express
{
    partial class AppForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppForm));
            this.menuItemBaseSet = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemSetBill = new System.Windows.Forms.ToolStripMenuItem();
            this.操作员设置ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemSetOperator = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemAmendPass = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemExpress = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemBillPrint = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemBillQuery = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.menuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMain = new System.Windows.Forms.ToolStrip();
            this.toolBillPrint = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolBillQuery = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolSetBill = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolSetOperator = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolAmendPass = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolExit = new System.Windows.Forms.ToolStripButton();
            this.menuStripMain.SuspendLayout();
            this.toolStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuItemBaseSet
            // 
            this.menuItemBaseSet.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemSetBill,
            this.操作员设置ToolStripMenuItem1});
            this.menuItemBaseSet.Image = ((System.Drawing.Image)(resources.GetObject("menuItemBaseSet.Image")));
            this.menuItemBaseSet.Name = "menuItemBaseSet";
            this.menuItemBaseSet.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Y)));
            this.menuItemBaseSet.Size = new System.Drawing.Size(99, 20);
            this.menuItemBaseSet.Text = "基础设置(&Y)";
            // 
            // menuItemSetBill
            // 
            this.menuItemSetBill.Image = ((System.Drawing.Image)(resources.GetObject("menuItemSetBill.Image")));
            this.menuItemSetBill.Name = "menuItemSetBill";
            this.menuItemSetBill.Size = new System.Drawing.Size(130, 22);
            this.menuItemSetBill.Text = "快递单设置";
            this.menuItemSetBill.Click += new System.EventHandler(this.menuItemSetBill_Click);
            // 
            // 操作员设置ToolStripMenuItem1
            // 
            this.操作员设置ToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemSetOperator,
            this.menuItemAmendPass});
            this.操作员设置ToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("操作员设置ToolStripMenuItem1.Image")));
            this.操作员设置ToolStripMenuItem1.Name = "操作员设置ToolStripMenuItem1";
            this.操作员设置ToolStripMenuItem1.Size = new System.Drawing.Size(130, 22);
            this.操作员设置ToolStripMenuItem1.Text = "操作员设置";
            // 
            // menuItemSetOperator
            // 
            this.menuItemSetOperator.Image = ((System.Drawing.Image)(resources.GetObject("menuItemSetOperator.Image")));
            this.menuItemSetOperator.Name = "menuItemSetOperator";
            this.menuItemSetOperator.Size = new System.Drawing.Size(130, 22);
            this.menuItemSetOperator.Text = "操作员维护";
            this.menuItemSetOperator.Click += new System.EventHandler(this.menuItemSetOperator_Click);
            // 
            // menuItemAmendPass
            // 
            this.menuItemAmendPass.Image = ((System.Drawing.Image)(resources.GetObject("menuItemAmendPass.Image")));
            this.menuItemAmendPass.Name = "menuItemAmendPass";
            this.menuItemAmendPass.Size = new System.Drawing.Size(130, 22);
            this.menuItemAmendPass.Text = "修改密码";
            this.menuItemAmendPass.Click += new System.EventHandler(this.menuItemAmendPass_Click);
            // 
            // menuItemExpress
            // 
            this.menuItemExpress.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemBillPrint,
            this.menuItemBillQuery});
            this.menuItemExpress.Image = ((System.Drawing.Image)(resources.GetObject("menuItemExpress.Image")));
            this.menuItemExpress.Name = "menuItemExpress";
            this.menuItemExpress.Size = new System.Drawing.Size(81, 20);
            this.menuItemExpress.Text = "单据管理";
            // 
            // menuItemBillPrint
            // 
            this.menuItemBillPrint.Image = ((System.Drawing.Image)(resources.GetObject("menuItemBillPrint.Image")));
            this.menuItemBillPrint.Name = "menuItemBillPrint";
            this.menuItemBillPrint.Size = new System.Drawing.Size(130, 22);
            this.menuItemBillPrint.Tag = "220";
            this.menuItemBillPrint.Text = "快递单打印";
            this.menuItemBillPrint.Click += new System.EventHandler(this.menuItemBillPrint_Click);
            // 
            // menuItemBillQuery
            // 
            this.menuItemBillQuery.Image = ((System.Drawing.Image)(resources.GetObject("menuItemBillQuery.Image")));
            this.menuItemBillQuery.Name = "menuItemBillQuery";
            this.menuItemBillQuery.Size = new System.Drawing.Size(130, 22);
            this.menuItemBillQuery.Text = "快递单查询";
            this.menuItemBillQuery.Click += new System.EventHandler(this.menuItemBillQuery_Click);
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemBaseSet,
            this.menuItemExpress,
            this.menuItemExit});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(1142, 24);
            this.menuStripMain.TabIndex = 4;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // menuItemExit
            // 
            this.menuItemExit.Image = ((System.Drawing.Image)(resources.GetObject("menuItemExit.Image")));
            this.menuItemExit.Name = "menuItemExit";
            this.menuItemExit.Size = new System.Drawing.Size(57, 20);
            this.menuItemExit.Text = "退出";
            this.menuItemExit.Click += new System.EventHandler(this.menuItemExit_Click);
            // 
            // toolStripMain
            // 
            this.toolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBillPrint,
            this.toolStripSeparator3,
            this.toolBillQuery,
            this.toolStripSeparator1,
            this.toolSetBill,
            this.toolStripSeparator2,
            this.toolSetOperator,
            this.toolStripSeparator4,
            this.toolAmendPass,
            this.toolStripSeparator5,
            this.toolExit});
            this.toolStripMain.Location = new System.Drawing.Point(0, 24);
            this.toolStripMain.Name = "toolStripMain";
            this.toolStripMain.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStripMain.Size = new System.Drawing.Size(1142, 25);
            this.toolStripMain.TabIndex = 9;
            this.toolStripMain.Text = "toolStrip1";
            // 
            // toolBillPrint
            // 
            this.toolBillPrint.Image = ((System.Drawing.Image)(resources.GetObject("toolBillPrint.Image")));
            this.toolBillPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBillPrint.Name = "toolBillPrint";
            this.toolBillPrint.Size = new System.Drawing.Size(85, 22);
            this.toolBillPrint.Text = "快递单打印";
            this.toolBillPrint.Click += new System.EventHandler(this.menuItemBillPrint_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolBillQuery
            // 
            this.toolBillQuery.Image = ((System.Drawing.Image)(resources.GetObject("toolBillQuery.Image")));
            this.toolBillQuery.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBillQuery.Name = "toolBillQuery";
            this.toolBillQuery.Size = new System.Drawing.Size(85, 22);
            this.toolBillQuery.Text = "快递单查询";
            this.toolBillQuery.Click += new System.EventHandler(this.menuItemBillQuery_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolSetBill
            // 
            this.toolSetBill.Image = ((System.Drawing.Image)(resources.GetObject("toolSetBill.Image")));
            this.toolSetBill.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolSetBill.Name = "toolSetBill";
            this.toolSetBill.Size = new System.Drawing.Size(85, 22);
            this.toolSetBill.Text = "快递单设置";
            this.toolSetBill.Click += new System.EventHandler(this.menuItemSetBill_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolSetOperator
            // 
            this.toolSetOperator.Image = ((System.Drawing.Image)(resources.GetObject("toolSetOperator.Image")));
            this.toolSetOperator.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolSetOperator.Name = "toolSetOperator";
            this.toolSetOperator.Size = new System.Drawing.Size(85, 22);
            this.toolSetOperator.Text = "操作员维护";
            this.toolSetOperator.Click += new System.EventHandler(this.menuItemSetOperator_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolAmendPass
            // 
            this.toolAmendPass.Image = ((System.Drawing.Image)(resources.GetObject("toolAmendPass.Image")));
            this.toolAmendPass.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolAmendPass.Name = "toolAmendPass";
            this.toolAmendPass.Size = new System.Drawing.Size(73, 22);
            this.toolAmendPass.Text = "修改密码";
            this.toolAmendPass.Click += new System.EventHandler(this.menuItemAmendPass_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // toolExit
            // 
            this.toolExit.Image = ((System.Drawing.Image)(resources.GetObject("toolExit.Image")));
            this.toolExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolExit.Name = "toolExit";
            this.toolExit.Size = new System.Drawing.Size(49, 22);
            this.toolExit.Text = "退出";
            this.toolExit.Click += new System.EventHandler(this.menuItemExit_Click);
            // 
            // AppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1142, 760);
            this.Controls.Add(this.toolStripMain);
            this.Controls.Add(this.menuStripMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "AppForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "快递单打印通";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AppForm_FormClosed);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.toolStripMain.ResumeLayout(false);
            this.toolStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem menuItemBaseSet;
        private System.Windows.Forms.ToolStripMenuItem menuItemSetBill;
        private System.Windows.Forms.ToolStripMenuItem menuItemExpress;
        private System.Windows.Forms.ToolStripMenuItem menuItemBillPrint;
        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem menuItemBillQuery;
        private System.Windows.Forms.ToolStripMenuItem 操作员设置ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem menuItemSetOperator;
        private System.Windows.Forms.ToolStripMenuItem menuItemAmendPass;
        private System.Windows.Forms.ToolStrip toolStripMain;
        private System.Windows.Forms.ToolStripButton toolBillPrint;
        private System.Windows.Forms.ToolStripButton toolBillQuery;
        private System.Windows.Forms.ToolStripButton toolAmendPass;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolSetBill;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolSetOperator;
        private System.Windows.Forms.ToolStripMenuItem menuItemExit;
        private System.Windows.Forms.ToolStripButton toolExit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;

    }
}

