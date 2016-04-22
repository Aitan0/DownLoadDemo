namespace Rendering
{
    partial class Frm_Appear
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Appear));
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox_Stat = new System.Windows.Forms.ComboBox();
            this.comboBox_Arrange = new System.Windows.Forms.ComboBox();
            this.comboBox_Data = new System.Windows.Forms.ComboBox();
            this.comboBox_Row = new System.Windows.Forms.ComboBox();
            this.comboBox_Page = new System.Windows.Forms.ComboBox();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.button_OK = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.comboBox_Stat);
            this.panel1.Controls.Add(this.comboBox_Arrange);
            this.panel1.Controls.Add(this.comboBox_Data);
            this.panel1.Controls.Add(this.comboBox_Row);
            this.panel1.Controls.Add(this.comboBox_Page);
            this.panel1.Controls.Add(this.button_Cancel);
            this.panel1.Controls.Add(this.button_OK);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(468, 267);
            this.panel1.TabIndex = 0;
            // 
            // comboBox_Stat
            // 
            this.comboBox_Stat.FormattingEnabled = true;
            this.comboBox_Stat.Items.AddRange(new object[] {
            "汇总",
            "平均值",
            "个数"});
            this.comboBox_Stat.Location = new System.Drawing.Point(343, 166);
            this.comboBox_Stat.Name = "comboBox_Stat";
            this.comboBox_Stat.Size = new System.Drawing.Size(95, 20);
            this.comboBox_Stat.TabIndex = 6;
            this.comboBox_Stat.TextChanged += new System.EventHandler(this.comboBox_Stat_TextChanged);
            // 
            // comboBox_Arrange
            // 
            this.comboBox_Arrange.FormattingEnabled = true;
            this.comboBox_Arrange.Location = new System.Drawing.Point(287, 13);
            this.comboBox_Arrange.Name = "comboBox_Arrange";
            this.comboBox_Arrange.Size = new System.Drawing.Size(101, 20);
            this.comboBox_Arrange.TabIndex = 5;
            this.comboBox_Arrange.TextChanged += new System.EventHandler(this.comboBox_Arrange_TextChanged);
            // 
            // comboBox_Data
            // 
            this.comboBox_Data.FormattingEnabled = true;
            this.comboBox_Data.Location = new System.Drawing.Point(287, 72);
            this.comboBox_Data.Name = "comboBox_Data";
            this.comboBox_Data.Size = new System.Drawing.Size(101, 20);
            this.comboBox_Data.TabIndex = 4;
            // 
            // comboBox_Row
            // 
            this.comboBox_Row.FormattingEnabled = true;
            this.comboBox_Row.Location = new System.Drawing.Point(149, 92);
            this.comboBox_Row.Name = "comboBox_Row";
            this.comboBox_Row.Size = new System.Drawing.Size(77, 20);
            this.comboBox_Row.TabIndex = 3;
            this.comboBox_Row.TextChanged += new System.EventHandler(this.comboBox_Row_TextChanged);
            // 
            // comboBox_Page
            // 
            this.comboBox_Page.FormattingEnabled = true;
            this.comboBox_Page.Location = new System.Drawing.Point(6, 44);
            this.comboBox_Page.Name = "comboBox_Page";
            this.comboBox_Page.Size = new System.Drawing.Size(87, 20);
            this.comboBox_Page.TabIndex = 2;
            this.comboBox_Page.TextChanged += new System.EventHandler(this.comboBox_Page_TextChanged);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(364, 224);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(75, 23);
            this.button_Cancel.TabIndex = 1;
            this.button_Cancel.Text = "取消";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // button_OK
            // 
            this.button_OK.Location = new System.Drawing.Point(271, 224);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(75, 23);
            this.button_OK.TabIndex = 0;
            this.button_OK.Text = "生成";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // Frm_Appear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 264);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Frm_Appear";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "生成透视表";
            this.Shown += new System.EventHandler(this.Frm_Appear_Shown);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.ComboBox comboBox_Page;
        private System.Windows.Forms.ComboBox comboBox_Stat;
        private System.Windows.Forms.ComboBox comboBox_Arrange;
        private System.Windows.Forms.ComboBox comboBox_Data;
        private System.Windows.Forms.ComboBox comboBox_Row;
    }
}