namespace Express.UI.Express
{
    partial class FormBillPrint
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBillPrint));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolPrint = new System.Windows.Forms.ToolStripButton();
            this.toolExit = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pbxBillPicture = new System.Windows.Forms.PictureBox();
            this.lbxBillTypeCode = new System.Windows.Forms.ListBox();
            this.pd = new System.Drawing.Printing.PrintDocument();
            this.toolStrip1.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBillPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolPrint,
            this.toolExit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(1027, 25);
            this.toolStrip1.TabIndex = 9;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolPrint
            // 
            this.toolPrint.Image = ((System.Drawing.Image)(resources.GetObject("toolPrint.Image")));
            this.toolPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolPrint.Name = "toolPrint";
            this.toolPrint.Size = new System.Drawing.Size(76, 22);
            this.toolPrint.Text = "打印单据";
            this.toolPrint.Click += new System.EventHandler(this.toolPrint_Click);
            // 
            // toolExit
            // 
            this.toolExit.Image = ((System.Drawing.Image)(resources.GetObject("toolExit.Image")));
            this.toolExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolExit.Name = "toolExit";
            this.toolExit.Size = new System.Drawing.Size(52, 22);
            this.toolExit.Text = "退出";
            this.toolExit.Click += new System.EventHandler(this.toolExit_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pbxBillPicture);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lbxBillTypeCode);
            this.splitContainer1.Size = new System.Drawing.Size(1027, 501);
            this.splitContainer1.SplitterDistance = 888;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 10;
            // 
            // pbxBillPicture
            // 
            this.pbxBillPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbxBillPicture.Location = new System.Drawing.Point(0, 0);
            this.pbxBillPicture.Name = "pbxBillPicture";
            this.pbxBillPicture.Size = new System.Drawing.Size(888, 501);
            this.pbxBillPicture.TabIndex = 0;
            this.pbxBillPicture.TabStop = false;
            this.pbxBillPicture.Paint += new System.Windows.Forms.PaintEventHandler(this.pbxBillPicture_Paint);
            // 
            // lbxBillTypeCode
            // 
            this.lbxBillTypeCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbxBillTypeCode.FormattingEnabled = true;
            this.lbxBillTypeCode.ItemHeight = 12;
            this.lbxBillTypeCode.Location = new System.Drawing.Point(0, 0);
            this.lbxBillTypeCode.Name = "lbxBillTypeCode";
            this.lbxBillTypeCode.Size = new System.Drawing.Size(136, 496);
            this.lbxBillTypeCode.TabIndex = 0;
            this.lbxBillTypeCode.DoubleClick += new System.EventHandler(this.lbxBillTypeCode_DoubleClick);
            // 
            // pd
            // 
            this.pd.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.pd_PrintPage);
            this.pd.QueryPageSettings += new System.Drawing.Printing.QueryPageSettingsEventHandler(this.pd_QueryPageSettings);
            // 
            // FormBillPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 526);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormBillPrint";
            this.Text = "快递单打印";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormBillPrint_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxBillPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolPrint;
        private System.Windows.Forms.ToolStripButton toolExit;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox pbxBillPicture;
        private System.Windows.Forms.ListBox lbxBillTypeCode;
        private System.Drawing.Printing.PrintDocument pd;

    }
}