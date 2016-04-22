namespace houseAgency
{
    partial class frmFavor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFavor));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tb_add = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tb_update = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tb_delete = new System.Windows.Forms.ToolStripButton();
            this.sp_operater = new System.Windows.Forms.ToolStripSplitButton();
            this.tp_OK = new System.Windows.Forms.ToolStripMenuItem();
            this.tp_cancel = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tb_add,
            this.toolStripSeparator1,
            this.tb_update,
            this.toolStripSeparator2,
            this.tb_delete,
            this.sp_operater});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(387, 35);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "增加";
            // 
            // tb_add
            // 
            this.tb_add.Image = ((System.Drawing.Image)(resources.GetObject("tb_add.Image")));
            this.tb_add.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tb_add.Name = "tb_add";
            this.tb_add.Size = new System.Drawing.Size(51, 32);
            this.tb_add.Text = "增加(A)";
            this.tb_add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tb_add.Click += new System.EventHandler(this.tb_add_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 35);
            // 
            // tb_update
            // 
            this.tb_update.Image = ((System.Drawing.Image)(resources.GetObject("tb_update.Image")));
            this.tb_update.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tb_update.Name = "tb_update";
            this.tb_update.Size = new System.Drawing.Size(51, 32);
            this.tb_update.Text = "修改(U)";
            this.tb_update.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tb_update.Click += new System.EventHandler(this.tb_update_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 35);
            // 
            // tb_delete
            // 
            this.tb_delete.Image = ((System.Drawing.Image)(resources.GetObject("tb_delete.Image")));
            this.tb_delete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tb_delete.Name = "tb_delete";
            this.tb_delete.Size = new System.Drawing.Size(51, 32);
            this.tb_delete.Text = "删除(&D)";
            this.tb_delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tb_delete.Click += new System.EventHandler(this.tb_delete_Click);
            // 
            // sp_operater
            // 
            this.sp_operater.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tp_OK,
            this.tp_cancel});
            this.sp_operater.Image = ((System.Drawing.Image)(resources.GetObject("sp_operater.Image")));
            this.sp_operater.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.sp_operater.Name = "sp_operater";
            this.sp_operater.Size = new System.Drawing.Size(45, 32);
            this.sp_operater.Text = "操作";
            this.sp_operater.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tp_OK
            // 
            this.tp_OK.BackColor = System.Drawing.SystemColors.MenuBar;
            this.tp_OK.Image = ((System.Drawing.Image)(resources.GetObject("tp_OK.Image")));
            this.tp_OK.Name = "tp_OK";
            this.tp_OK.Size = new System.Drawing.Size(112, 22);
            this.tp_OK.Text = "确定(&O)";
            this.tp_OK.Click += new System.EventHandler(this.tp_OK_Click);
            // 
            // tp_cancel
            // 
            this.tp_cancel.BackColor = System.Drawing.SystemColors.MenuBar;
            this.tp_cancel.Image = ((System.Drawing.Image)(resources.GetObject("tp_cancel.Image")));
            this.tp_cancel.Name = "tp_cancel";
            this.tp_cancel.Size = new System.Drawing.Size(112, 22);
            this.tp_cancel.Text = "取消(&C)";
            this.tp_cancel.Click += new System.EventHandler(this.tp_cancel_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 35);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.button2);
            this.splitContainer1.Panel2.Controls.Add(this.button1);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(387, 213);
            this.splitContainer1.SplitterDistance = 143;
            this.splitContainer1.TabIndex = 1;
            // 
            // treeView1
            // 
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.Location = new System.Drawing.Point(1, 7);
            this.treeView1.Name = "treeView1";
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size(139, 203);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "查询.bmp");
            this.imageList1.Images.SetKeyName(1, "操作.bmp");
            this.imageList1.Images.SetKeyName(2, "删除.bmp");
            this.imageList1.Images.SetKeyName(3, "修改.bmp");
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button2.Location = new System.Drawing.Point(57, 179);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "确定(&O)";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(138, 179);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "取消(&C)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(215, 149);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "朝向信息";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Enabled = false;
            this.richTextBox1.Location = new System.Drawing.Point(60, 78);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(140, 53);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "备注：";
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(59, 50);
            this.textBox2.MaxLength = 20;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(141, 21);
            this.textBox2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "朝向：";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(59, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(141, 21);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "编号：";
            // 
            // frmFavor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 248);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFavor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "朝向设置";
            this.Load += new System.EventHandler(this.frmFavor_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tb_add;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tb_update;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tb_delete;
        private System.Windows.Forms.ToolStripSplitButton sp_operater;
        private System.Windows.Forms.ToolStripMenuItem tp_OK;
        private System.Windows.Forms.ToolStripMenuItem tp_cancel;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList imageList1;
    }
}