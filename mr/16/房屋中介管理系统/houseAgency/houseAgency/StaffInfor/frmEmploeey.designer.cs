namespace houseAgency
{
    partial class frmEmploeey
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
            this.txtIDCard = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cbSex = new System.Windows.Forms.ComboBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBasePay = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cobStudy = new System.Windows.Forms.ComboBox();
            this.cobGov = new System.Windows.Forms.ComboBox();
            this.btnSutdy = new System.Windows.Forms.Button();
            this.btnGov = new System.Windows.Forms.Button();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtBirthday = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtIDCard
            // 
            this.txtIDCard.Location = new System.Drawing.Point(77, 110);
            this.txtIDCard.MaxLength = 18;
            this.txtIDCard.Name = "txtIDCard";
            this.txtIDCard.Size = new System.Drawing.Size(366, 21);
            this.txtIDCard.TabIndex = 15;
            this.txtIDCard.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIDCard_KeyPress);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(368, 170);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "取消(&C)";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(276, 170);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "确定(&O)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 14;
            this.label7.Text = "身份证号：";
            // 
            // cbSex
            // 
            this.cbSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSex.FormattingEnabled = true;
            this.cbSex.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.cbSex.Location = new System.Drawing.Point(78, 57);
            this.cbSex.Name = "cbSex";
            this.cbSex.Size = new System.Drawing.Size(121, 20);
            this.cbSex.TabIndex = 13;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(286, 29);
            this.txtPhone.MaxLength = 11;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(157, 21);
            this.txtPhone.TabIndex = 8;
            this.txtPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhone_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.txtBasePay);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cobStudy);
            this.groupBox1.Controls.Add(this.cobGov);
            this.groupBox1.Controls.Add(this.btnSutdy);
            this.groupBox1.Controls.Add(this.btnGov);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtIDCard);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cbSex);
            this.groupBox1.Controls.Add(this.txtPhone);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtBirthday);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(455, 203);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "基本信息维护";
            // 
            // txtBasePay
            // 
            this.txtBasePay.Location = new System.Drawing.Point(77, 165);
            this.txtBasePay.MaxLength = 8;
            this.txtBasePay.Name = "txtBasePay";
            this.txtBasePay.Size = new System.Drawing.Size(137, 21);
            this.txtBasePay.TabIndex = 25;
            this.txtBasePay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBasePay_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 170);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 24;
            this.label9.Text = "基本工资：";
            // 
            // cobStudy
            // 
            this.cobStudy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cobStudy.FormattingEnabled = true;
            this.cobStudy.Location = new System.Drawing.Point(287, 84);
            this.cobStudy.Name = "cobStudy";
            this.cobStudy.Size = new System.Drawing.Size(121, 20);
            this.cobStudy.TabIndex = 23;
            // 
            // cobGov
            // 
            this.cobGov.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cobGov.FormattingEnabled = true;
            this.cobGov.Location = new System.Drawing.Point(286, 57);
            this.cobGov.Name = "cobGov";
            this.cobGov.Size = new System.Drawing.Size(121, 20);
            this.cobGov.TabIndex = 22;
            // 
            // btnSutdy
            // 
            this.btnSutdy.Location = new System.Drawing.Point(416, 84);
            this.btnSutdy.Name = "btnSutdy";
            this.btnSutdy.Size = new System.Drawing.Size(27, 20);
            this.btnSutdy.TabIndex = 21;
            this.btnSutdy.Text = "...";
            this.btnSutdy.UseVisualStyleBackColor = true;
            this.btnSutdy.Click += new System.EventHandler(this.btnSutdy_Click);
            // 
            // btnGov
            // 
            this.btnGov.Location = new System.Drawing.Point(416, 55);
            this.btnGov.Name = "btnGov";
            this.btnGov.Size = new System.Drawing.Size(27, 20);
            this.btnGov.TabIndex = 20;
            this.btnGov.Text = "...";
            this.btnGov.UseVisualStyleBackColor = true;
            this.btnGov.Click += new System.EventHandler(this.btnGov_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(77, 138);
            this.txtAddress.MaxLength = 50;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(366, 21);
            this.txtAddress.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 142);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 18;
            this.label8.Text = "地    址：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(215, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 17;
            this.label6.Text = "学    历：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(215, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 16;
            this.label5.Text = "民    族：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(215, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "手    机：";
            // 
            // dtBirthday
            // 
            this.dtBirthday.Location = new System.Drawing.Point(77, 83);
            this.dtBirthday.Name = "dtBirthday";
            this.dtBirthday.Size = new System.Drawing.Size(123, 21);
            this.dtBirthday.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "出生日期：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "性    别：";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(77, 28);
            this.txtName.MaxLength = 20;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(123, 21);
            this.txtName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "姓    名：";
            // 
            // frmEmploeey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 226);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEmploeey";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "员工信息";
            this.Load += new System.EventHandler(this.frmEmploeey_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtIDCard;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbSex;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtBirthday;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSutdy;
        private System.Windows.Forms.Button btnGov;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.ComboBox cobStudy;
        private System.Windows.Forms.ComboBox cobGov;
        private System.Windows.Forms.TextBox txtBasePay;
        private System.Windows.Forms.Label label9;
    }
}