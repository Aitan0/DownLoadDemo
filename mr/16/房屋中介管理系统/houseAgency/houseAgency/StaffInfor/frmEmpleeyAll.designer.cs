namespace houseAgency
{
    partial class frmEmpleeyAll
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmpleeyAll));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tb_update = new System.Windows.Forms.ToolStripButton();
            this.sp_operater = new System.Windows.Forms.ToolStripSplitButton();
            this.tp_OK = new System.Windows.Forms.ToolStripMenuItem();
            this.tp_cancel = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tb_delete = new System.Windows.Forms.ToolStripButton();
            this.tsAll = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.cobPower = new System.Windows.Forms.ComboBox();
            this.txtBasePay = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(1, 102);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(547, 219);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "员工信息";
            // 
            // dataGridView1
            // 
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.PowderBlue;
            this.dataGridView1.Location = new System.Drawing.Point(9, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.MenuBar;
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(529, 191);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tb_update,
            this.sp_operater,
            this.toolStripSeparator2,
            this.tb_delete,
            this.tsAll});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(553, 35);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "增加";
            // 
            // tb_update
            // 
            this.tb_update.Image = global::houseAgency.Properties.Resources.修改;
            this.tb_update.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tb_update.Name = "tb_update";
            this.tb_update.Size = new System.Drawing.Size(51, 32);
            this.tb_update.Text = "修改(U)";
            this.tb_update.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tb_update.Click += new System.EventHandler(this.tb_update_Click);
            // 
            // sp_operater
            // 
            this.sp_operater.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tp_OK,
            this.tp_cancel});
            this.sp_operater.Image = global::houseAgency.Properties.Resources.操作;
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
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 35);
            // 
            // tb_delete
            // 
            this.tb_delete.Image = global::houseAgency.Properties.Resources.删除;
            this.tb_delete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tb_delete.Name = "tb_delete";
            this.tb_delete.Size = new System.Drawing.Size(51, 32);
            this.tb_delete.Text = "删除(&D)";
            this.tb_delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tb_delete.Click += new System.EventHandler(this.tb_delete_Click);
            // 
            // tsAll
            // 
            this.tsAll.Image = global::houseAgency.Properties.Resources.查询;
            this.tsAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsAll.MergeIndex = 3;
            this.tsAll.Name = "tsAll";
            this.tsAll.Size = new System.Drawing.Size(73, 32);
            this.tsAll.Text = "所有员工";
            this.tsAll.Click += new System.EventHandler(this.tsAll_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "员工姓名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "权    限：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(262, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "手    机：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(265, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "基本工资：";
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(94, 48);
            this.txtName.MaxLength = 20;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(144, 21);
            this.txtName.TabIndex = 7;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(333, 45);
            this.txtPhone.MaxLength = 11;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(144, 21);
            this.txtPhone.TabIndex = 8;
            this.txtPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhone_KeyPress);
            // 
            // cobPower
            // 
            this.cobPower.FormattingEnabled = true;
            this.cobPower.Location = new System.Drawing.Point(94, 75);
            this.cobPower.Name = "cobPower";
            this.cobPower.Size = new System.Drawing.Size(144, 20);
            this.cobPower.TabIndex = 9;
            // 
            // txtBasePay
            // 
            this.txtBasePay.Location = new System.Drawing.Point(334, 76);
            this.txtBasePay.MaxLength = 8;
            this.txtBasePay.Name = "txtBasePay";
            this.txtBasePay.Size = new System.Drawing.Size(144, 21);
            this.txtBasePay.TabIndex = 10;
            this.txtBasePay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBasePay_KeyPress);
            // 
            // frmEmpleeyAll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 327);
            this.Controls.Add(this.txtBasePay);
            this.Controls.Add(this.cobPower);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEmpleeyAll";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "员工信息设置";
            this.Load += new System.EventHandler(this.frmEmpleeyAll_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tb_update;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tb_delete;
        private System.Windows.Forms.ToolStripSplitButton sp_operater;
        private System.Windows.Forms.ToolStripMenuItem tp_OK;
        private System.Windows.Forms.ToolStripMenuItem tp_cancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.ComboBox cobPower;
        private System.Windows.Forms.TextBox txtBasePay;
        private System.Windows.Forms.ToolStripButton tsAll;
    }
}