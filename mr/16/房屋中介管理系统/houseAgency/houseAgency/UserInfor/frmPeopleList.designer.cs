namespace houseAgency
{
    partial class frmPeopleList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPeopleList));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tb_Select = new System.Windows.Forms.ToolStripButton();
            this.tb_update = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tb_delete = new System.Windows.Forms.ToolStripButton();
            this.sp_operater = new System.Windows.Forms.ToolStripSplitButton();
            this.tp_OK = new System.Windows.Forms.ToolStripMenuItem();
            this.tp_cancel = new System.Windows.Forms.ToolStripMenuItem();
            this.listView1 = new System.Windows.Forms.ListView();
            this.clID = new System.Windows.Forms.ColumnHeader();
            this.clName = new System.Windows.Forms.ColumnHeader();
            this.clHomePhone = new System.Windows.Forms.ColumnHeader();
            this.clIDcard = new System.Windows.Forms.ColumnHeader();
            this.clPhone = new System.Windows.Forms.ColumnHeader();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tb_Select,
            this.tb_update,
            this.toolStripSeparator2,
            this.tb_delete,
            this.sp_operater});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(546, 35);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "增加";
            // 
            // tb_Select
            // 
            this.tb_Select.Image = global::houseAgency.Properties.Resources.查询;
            this.tb_Select.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tb_Select.Name = "tb_Select";
            this.tb_Select.Size = new System.Drawing.Size(57, 32);
            this.tb_Select.Text = "查找信息";
            this.tb_Select.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tb_Select.Click += new System.EventHandler(this.tb_Select_Click);
            // 
            // tb_update
            // 
            this.tb_update.Enabled = false;
            this.tb_update.Image = global::houseAgency.Properties.Resources.修改;
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
            this.tb_delete.Image = global::houseAgency.Properties.Resources.删除;
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
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clID,
            this.clName,
            this.clHomePhone,
            this.clIDcard,
            this.clPhone});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(18, 169);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(516, 182);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.Click += new System.EventHandler(this.listView1_Click);
            // 
            // clID
            // 
            this.clID.Text = "编号";
            this.clID.Width = 80;
            // 
            // clName
            // 
            this.clName.Text = "姓名";
            this.clName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clName.Width = 80;
            // 
            // clHomePhone
            // 
            this.clHomePhone.Text = "家用电话";
            this.clHomePhone.Width = 100;
            // 
            // clIDcard
            // 
            this.clIDcard.Text = "身份证";
            this.clIDcard.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clIDcard.Width = 140;
            // 
            // clPhone
            // 
            this.clPhone.Text = "手机";
            this.clPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clPhone.Width = 120;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 38);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(531, 125);
            this.tabControl1.TabIndex = 7;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tabPage1.Controls.Add(this.textBox5);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.textBox4);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.textBox3);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 21);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(523, 100);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "出租人";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(320, 58);
            this.textBox5.MaxLength = 20;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(178, 21);
            this.textBox5.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(273, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 25;
            this.label5.Text = "手机号";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(68, 59);
            this.textBox4.MaxLength = 18;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(199, 21);
            this.textBox4.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(14, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 23;
            this.label4.Text = "身份证号";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(398, 26);
            this.textBox3.MaxLength = 20;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 21);
            this.textBox3.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(339, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 21;
            this.label3.Text = "家用电话";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(233, 26);
            this.textBox2.MaxLength = 20;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 21);
            this.textBox2.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(174, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 19;
            this.label2.Text = "用户姓名";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(68, 26);
            this.textBox1.MaxLength = 20;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(14, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 17;
            this.label1.Text = "用户编号";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tabPage2.Controls.Add(this.textBox6);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.textBox7);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.textBox8);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.textBox9);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.textBox10);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Location = new System.Drawing.Point(4, 21);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(523, 100);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "求租人";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(321, 57);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(178, 21);
            this.textBox6.TabIndex = 36;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(274, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 35;
            this.label6.Text = "手机号";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(69, 58);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(199, 21);
            this.textBox7.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(15, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 33;
            this.label7.Text = "身份证号";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(399, 25);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 21);
            this.textBox8.TabIndex = 32;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(340, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 31;
            this.label8.Text = "家用电话";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(234, 25);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(100, 21);
            this.textBox9.TabIndex = 30;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(175, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 29;
            this.label9.Text = "用户姓名";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(69, 25);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(100, 21);
            this.textBox10.TabIndex = 28;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(15, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 27;
            this.label10.Text = "用户编号";
            // 
            // frmPeopleList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 357);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPeopleList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "用户信息管理";
            this.Load += new System.EventHandler(this.frmPeopleList_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tb_update;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tb_delete;
        private System.Windows.Forms.ToolStripSplitButton sp_operater;
        private System.Windows.Forms.ToolStripMenuItem tp_OK;
        private System.Windows.Forms.ToolStripMenuItem tp_cancel;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader clID;
        private System.Windows.Forms.ColumnHeader clName;
        private System.Windows.Forms.ColumnHeader clPhone;
        private System.Windows.Forms.ColumnHeader clIDcard;
        private System.Windows.Forms.ColumnHeader clHomePhone;
        protected System.Windows.Forms.ToolStripButton tb_Select;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label10;
    }
}