namespace Express.UI.BaseSet
{
    partial class FormSetTemplate
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSetTemplate));
            this.contextMenuSetting = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolAddCTextBox = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolSave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolExit = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuSetting.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuSetting
            // 
            this.contextMenuSetting.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolAddCTextBox,
            this.toolStripMenuItem1,
            this.toolSave,
            this.toolStripMenuItem2,
            this.toolExit});
            this.contextMenuSetting.Name = "contextMenuStrip1";
            this.contextMenuSetting.Size = new System.Drawing.Size(153, 104);
            this.contextMenuSetting.Text = "添加输入文本框";
            // 
            // toolAddCTextBox
            // 
            this.toolAddCTextBox.Name = "toolAddCTextBox";
            this.toolAddCTextBox.Size = new System.Drawing.Size(152, 22);
            this.toolAddCTextBox.Text = "添加输入框";
            this.toolAddCTextBox.Click += new System.EventHandler(this.toolAddCTextBox_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 6);
            // 
            // toolSave
            // 
            this.toolSave.Name = "toolSave";
            this.toolSave.Size = new System.Drawing.Size(152, 22);
            this.toolSave.Text = "保存模板";
            this.toolSave.Click += new System.EventHandler(this.toolSave_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(149, 6);
            // 
            // toolExit
            // 
            this.toolExit.Name = "toolExit";
            this.toolExit.Size = new System.Drawing.Size(152, 22);
            this.toolExit.Text = "退出窗口";
            this.toolExit.Click += new System.EventHandler(this.toolExit_Click);
            // 
            // FormSetTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(908, 516);
            this.ContextMenuStrip = this.contextMenuSetting;
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSetTemplate";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "设计模板";
            this.Load += new System.EventHandler(this.FormSetTemplate_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormSetTemplate_Paint);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormSetTemplate_FormClosed);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormSetTemplate_FormClosing);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormSetTemplate_MouseMove);
            this.contextMenuSetting.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuSetting;
        private System.Windows.Forms.ToolStripMenuItem toolAddCTextBox;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolSave;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolExit;
    }
}