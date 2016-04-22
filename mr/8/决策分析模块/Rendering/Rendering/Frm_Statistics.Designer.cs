namespace Rendering
{
    partial class Frm_Statistics
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
            this.groupBox_Stat = new System.Windows.Forms.GroupBox();
            this.label_Data = new System.Windows.Forms.Label();
            this.label_Stat = new System.Windows.Forms.Label();
            this.comboBox_Data = new System.Windows.Forms.ComboBox();
            this.comboBox_Stat = new System.Windows.Forms.ComboBox();
            this.groupBox_Data = new System.Windows.Forms.GroupBox();
            this.label_Month = new System.Windows.Forms.Label();
            this.label_Year = new System.Windows.Forms.Label();
            this.radioButton_Month = new System.Windows.Forms.RadioButton();
            this.radioButton_Year = new System.Windows.Forms.RadioButton();
            this.comboBox_Month = new System.Windows.Forms.ComboBox();
            this.comboBox_Year = new System.Windows.Forms.ComboBox();
            this.button_OK = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.groupBox_Stat.SuspendLayout();
            this.groupBox_Data.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_Stat
            // 
            this.groupBox_Stat.Controls.Add(this.label_Data);
            this.groupBox_Stat.Controls.Add(this.label_Stat);
            this.groupBox_Stat.Controls.Add(this.comboBox_Data);
            this.groupBox_Stat.Controls.Add(this.comboBox_Stat);
            this.groupBox_Stat.Location = new System.Drawing.Point(14, 12);
            this.groupBox_Stat.Name = "groupBox_Stat";
            this.groupBox_Stat.Size = new System.Drawing.Size(253, 86);
            this.groupBox_Stat.TabIndex = 4;
            this.groupBox_Stat.TabStop = false;
            this.groupBox_Stat.Text = "统计字段的设置";
            // 
            // label_Data
            // 
            this.label_Data.AutoSize = true;
            this.label_Data.Location = new System.Drawing.Point(135, 32);
            this.label_Data.Name = "label_Data";
            this.label_Data.Size = new System.Drawing.Size(65, 12);
            this.label_Data.TabIndex = 7;
            this.label_Data.Text = "数据字段：";
            // 
            // label_Stat
            // 
            this.label_Stat.AutoSize = true;
            this.label_Stat.Location = new System.Drawing.Point(21, 32);
            this.label_Stat.Name = "label_Stat";
            this.label_Stat.Size = new System.Drawing.Size(65, 12);
            this.label_Stat.TabIndex = 6;
            this.label_Stat.Text = "统计字段：";
            // 
            // comboBox_Data
            // 
            this.comboBox_Data.FormattingEnabled = true;
            this.comboBox_Data.Location = new System.Drawing.Point(137, 49);
            this.comboBox_Data.Name = "comboBox_Data";
            this.comboBox_Data.Size = new System.Drawing.Size(94, 20);
            this.comboBox_Data.TabIndex = 5;
            // 
            // comboBox_Stat
            // 
            this.comboBox_Stat.FormattingEnabled = true;
            this.comboBox_Stat.Location = new System.Drawing.Point(23, 49);
            this.comboBox_Stat.Name = "comboBox_Stat";
            this.comboBox_Stat.Size = new System.Drawing.Size(94, 20);
            this.comboBox_Stat.TabIndex = 4;
            this.comboBox_Stat.TextChanged += new System.EventHandler(this.comboBox_Stat_TextChanged);
            // 
            // groupBox_Data
            // 
            this.groupBox_Data.Controls.Add(this.label_Month);
            this.groupBox_Data.Controls.Add(this.label_Year);
            this.groupBox_Data.Controls.Add(this.radioButton_Month);
            this.groupBox_Data.Controls.Add(this.radioButton_Year);
            this.groupBox_Data.Controls.Add(this.comboBox_Month);
            this.groupBox_Data.Controls.Add(this.comboBox_Year);
            this.groupBox_Data.Location = new System.Drawing.Point(14, 104);
            this.groupBox_Data.Name = "groupBox_Data";
            this.groupBox_Data.Size = new System.Drawing.Size(253, 100);
            this.groupBox_Data.TabIndex = 10;
            this.groupBox_Data.TabStop = false;
            this.groupBox_Data.Text = "统计日期";
            this.groupBox_Data.Visible = false;
            // 
            // label_Month
            // 
            this.label_Month.AutoSize = true;
            this.label_Month.Location = new System.Drawing.Point(112, 64);
            this.label_Month.Name = "label_Month";
            this.label_Month.Size = new System.Drawing.Size(41, 12);
            this.label_Month.TabIndex = 15;
            this.label_Month.Text = "月份：";
            // 
            // label_Year
            // 
            this.label_Year.AutoSize = true;
            this.label_Year.Location = new System.Drawing.Point(112, 27);
            this.label_Year.Name = "label_Year";
            this.label_Year.Size = new System.Drawing.Size(41, 12);
            this.label_Year.TabIndex = 14;
            this.label_Year.Text = "年份：";
            // 
            // radioButton_Month
            // 
            this.radioButton_Month.AutoSize = true;
            this.radioButton_Month.Location = new System.Drawing.Point(23, 62);
            this.radioButton_Month.Name = "radioButton_Month";
            this.radioButton_Month.Size = new System.Drawing.Size(71, 16);
            this.radioButton_Month.TabIndex = 13;
            this.radioButton_Month.TabStop = true;
            this.radioButton_Month.Text = "月份统计";
            this.radioButton_Month.UseVisualStyleBackColor = true;
            this.radioButton_Month.MouseUp += new System.Windows.Forms.MouseEventHandler(this.radioButton_Month_MouseUp);
            // 
            // radioButton_Year
            // 
            this.radioButton_Year.AutoSize = true;
            this.radioButton_Year.Location = new System.Drawing.Point(23, 25);
            this.radioButton_Year.Name = "radioButton_Year";
            this.radioButton_Year.Size = new System.Drawing.Size(71, 16);
            this.radioButton_Year.TabIndex = 12;
            this.radioButton_Year.TabStop = true;
            this.radioButton_Year.Text = "年份统计";
            this.radioButton_Year.UseVisualStyleBackColor = true;
            this.radioButton_Year.MouseUp += new System.Windows.Forms.MouseEventHandler(this.radioButton_Year_MouseUp);
            // 
            // comboBox_Month
            // 
            this.comboBox_Month.Enabled = false;
            this.comboBox_Month.FormattingEnabled = true;
            this.comboBox_Month.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.comboBox_Month.Location = new System.Drawing.Point(160, 60);
            this.comboBox_Month.Name = "comboBox_Month";
            this.comboBox_Month.Size = new System.Drawing.Size(71, 20);
            this.comboBox_Month.TabIndex = 11;
            // 
            // comboBox_Year
            // 
            this.comboBox_Year.Enabled = false;
            this.comboBox_Year.FormattingEnabled = true;
            this.comboBox_Year.Location = new System.Drawing.Point(160, 23);
            this.comboBox_Year.Name = "comboBox_Year";
            this.comboBox_Year.Size = new System.Drawing.Size(71, 20);
            this.comboBox_Year.TabIndex = 10;
            this.comboBox_Year.TextChanged += new System.EventHandler(this.comboBox_Year_TextChanged);
            // 
            // button_OK
            // 
            this.button_OK.Location = new System.Drawing.Point(37, 210);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(75, 23);
            this.button_OK.TabIndex = 11;
            this.button_OK.Text = "生成";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(174, 210);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(75, 23);
            this.button_Cancel.TabIndex = 12;
            this.button_Cancel.Text = "关闭";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // Frm_Statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 243);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_OK);
            this.Controls.Add(this.groupBox_Data);
            this.Controls.Add(this.groupBox_Stat);
            this.Name = "Frm_Statistics";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "生成统计表";
            this.Shown += new System.EventHandler(this.Frm_Statistics_Shown);
            this.groupBox_Stat.ResumeLayout(false);
            this.groupBox_Stat.PerformLayout();
            this.groupBox_Data.ResumeLayout(false);
            this.groupBox_Data.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_Stat;
        private System.Windows.Forms.Label label_Data;
        private System.Windows.Forms.Label label_Stat;
        private System.Windows.Forms.ComboBox comboBox_Data;
        private System.Windows.Forms.ComboBox comboBox_Stat;
        private System.Windows.Forms.GroupBox groupBox_Data;
        private System.Windows.Forms.Label label_Month;
        private System.Windows.Forms.Label label_Year;
        private System.Windows.Forms.RadioButton radioButton_Month;
        private System.Windows.Forms.RadioButton radioButton_Year;
        private System.Windows.Forms.ComboBox comboBox_Month;
        private System.Windows.Forms.ComboBox comboBox_Year;
        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.Button button_Cancel;
    }
}