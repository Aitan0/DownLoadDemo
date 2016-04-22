namespace houseAgency
{
    partial class frmIntendInfo
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
            this.cobUser = new System.Windows.Forms.ComboBox();
            this.cboFavoe = new System.Windows.Forms.ComboBox();
            this.cobFlood = new System.Windows.Forms.ComboBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblHouseID = new System.Windows.Forms.Label();
            this.cobZhuang = new System.Windows.Forms.ComboBox();
            this.cobDong = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cboXing = new System.Windows.Forms.ComboBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cobUser
            // 
            this.cobUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cobUser.FormattingEnabled = true;
            this.cobUser.Location = new System.Drawing.Point(281, 78);
            this.cobUser.Name = "cobUser";
            this.cobUser.Size = new System.Drawing.Size(145, 20);
            this.cobUser.TabIndex = 40;
            // 
            // cboFavoe
            // 
            this.cboFavoe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFavoe.FormattingEnabled = true;
            this.cboFavoe.Location = new System.Drawing.Point(67, 107);
            this.cboFavoe.Name = "cboFavoe";
            this.cboFavoe.Size = new System.Drawing.Size(132, 20);
            this.cboFavoe.TabIndex = 39;
            // 
            // cobFlood
            // 
            this.cobFlood.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cobFlood.FormattingEnabled = true;
            this.cobFlood.Location = new System.Drawing.Point(67, 78);
            this.cobFlood.Name = "cobFlood";
            this.cobFlood.Size = new System.Drawing.Size(132, 20);
            this.cobFlood.TabIndex = 38;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(282, 20);
            this.txtPrice.MaxLength = 10;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(143, 21);
            this.txtPrice.TabIndex = 49;
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(224, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 48;
            this.label1.Text = "每月单价";
            // 
            // lblHouseID
            // 
            this.lblHouseID.AutoSize = true;
            this.lblHouseID.Font = new System.Drawing.Font("隶书", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblHouseID.Location = new System.Drawing.Point(131, -33);
            this.lblHouseID.Name = "lblHouseID";
            this.lblHouseID.Size = new System.Drawing.Size(128, 16);
            this.lblHouseID.TabIndex = 26;
            this.lblHouseID.Text = "show House Info";
            // 
            // cobZhuang
            // 
            this.cobZhuang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cobZhuang.FormattingEnabled = true;
            this.cobZhuang.Location = new System.Drawing.Point(280, 107);
            this.cobZhuang.Name = "cobZhuang";
            this.cobZhuang.Size = new System.Drawing.Size(146, 20);
            this.cobZhuang.TabIndex = 37;
            // 
            // cobDong
            // 
            this.cobDong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cobDong.FormattingEnabled = true;
            this.cobDong.Location = new System.Drawing.Point(281, 50);
            this.cobDong.Name = "cobDong";
            this.cobDong.Size = new System.Drawing.Size(145, 20);
            this.cobDong.TabIndex = 36;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txtPrice);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cobUser);
            this.groupBox1.Controls.Add(this.cboFavoe);
            this.groupBox1.Controls.Add(this.cobFlood);
            this.groupBox1.Controls.Add(this.cobZhuang);
            this.groupBox1.Controls.Add(this.cobDong);
            this.groupBox1.Controls.Add(this.cboXing);
            this.groupBox1.Controls.Add(this.txtArea);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(451, 145);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "房源信息：";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(133, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(257, 145);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "找到相符信息";
            this.groupBox2.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(245, 119);
            this.dataGridView1.TabIndex = 0;
            // 
            // cboXing
            // 
            this.cboXing.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboXing.FormattingEnabled = true;
            this.cboXing.Location = new System.Drawing.Point(67, 50);
            this.cboXing.Name = "cboXing";
            this.cboXing.Size = new System.Drawing.Size(132, 20);
            this.cboXing.TabIndex = 35;
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(67, 20);
            this.txtArea.MaxLength = 10;
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(132, 21);
            this.txtArea.TabIndex = 34;
            this.txtArea.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtArea_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 30;
            this.label10.Text = "建筑面积";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 28;
            this.label8.Text = "楼层";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(246, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 27;
            this.label7.Text = "用途";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 26;
            this.label6.Text = "朝向";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(248, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 25;
            this.label5.Text = "装修";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(240, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 24;
            this.label4.Text = "幢/座";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 23;
            this.label3.Text = "房形";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(268, 163);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 27;
            this.button1.Text = "确定(&O)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(374, 163);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 28;
            this.button2.Text = "取消(&C)";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmIntendInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 196);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblHouseID);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmIntendInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "房源信息意向";
            this.Load += new System.EventHandler(this.frmIntendInfo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cobUser;
        private System.Windows.Forms.ComboBox cboFavoe;
        private System.Windows.Forms.ComboBox cobFlood;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblHouseID;
        private System.Windows.Forms.ComboBox cobZhuang;
        private System.Windows.Forms.ComboBox cobDong;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboXing;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}