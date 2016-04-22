namespace ClientGobang
{
    partial class F_SerSetup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_SerSetup));
            this.button_OK = new System.Windows.Forms.Button();
            this.button_Close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.text_PassWord = new System.Windows.Forms.TextBox();
            this.text_Name = new System.Windows.Forms.TextBox();
            this.text_IP5 = new System.Windows.Forms.TextBox();
            this.text_IP = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox_Sex = new System.Windows.Forms.ComboBox();
            this.label_CPhoto = new System.Windows.Forms.Label();
            this.comboBox_CPhoto = new System.Windows.Forms.ComboBox();
            this.text_PassWord2 = new System.Windows.Forms.TextBox();
            this.udpSocket1 = new GobangClass.UDPSocket(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_OK
            // 
            this.button_OK.Location = new System.Drawing.Point(34, 253);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(75, 23);
            this.button_OK.TabIndex = 1;
            this.button_OK.Text = "确定";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // button_Close
            // 
            this.button_Close.Location = new System.Drawing.Point(175, 253);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(75, 23);
            this.button_Close.TabIndex = 2;
            this.button_Close.Text = "取消";
            this.button_Close.UseVisualStyleBackColor = true;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "服务器IP：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "端 口 号：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "用 户 名：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "密    码：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 14;
            this.label5.Text = "确认密码：";
            // 
            // text_PassWord
            // 
            this.text_PassWord.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text_PassWord.Location = new System.Drawing.Point(98, 116);
            this.text_PassWord.Name = "text_PassWord";
            this.text_PassWord.PasswordChar = '*';
            this.text_PassWord.Size = new System.Drawing.Size(156, 21);
            this.text_PassWord.TabIndex = 15;
            // 
            // text_Name
            // 
            this.text_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text_Name.Location = new System.Drawing.Point(98, 85);
            this.text_Name.Name = "text_Name";
            this.text_Name.Size = new System.Drawing.Size(156, 21);
            this.text_Name.TabIndex = 16;
            // 
            // text_IP5
            // 
            this.text_IP5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text_IP5.Location = new System.Drawing.Point(98, 54);
            this.text_IP5.Name = "text_IP5";
            this.text_IP5.Size = new System.Drawing.Size(156, 21);
            this.text_IP5.TabIndex = 17;
            // 
            // text_IP
            // 
            this.text_IP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text_IP.Location = new System.Drawing.Point(98, 23);
            this.text_IP.Name = "text_IP";
            this.text_IP.Size = new System.Drawing.Size(156, 21);
            this.text_IP.TabIndex = 18;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.comboBox_Sex);
            this.groupBox1.Controls.Add(this.label_CPhoto);
            this.groupBox1.Controls.Add(this.comboBox_CPhoto);
            this.groupBox1.Controls.Add(this.text_PassWord2);
            this.groupBox1.Controls.Add(this.text_IP);
            this.groupBox1.Controls.Add(this.text_IP5);
            this.groupBox1.Controls.Add(this.text_Name);
            this.groupBox1.Controls.Add(this.text_PassWord);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(8, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 240);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "设置信息";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 23;
            this.label6.Text = "性    别：";
            // 
            // comboBox_Sex
            // 
            this.comboBox_Sex.FormattingEnabled = true;
            this.comboBox_Sex.Items.AddRange(new object[] {
            "男",
            "女"});
            this.comboBox_Sex.Location = new System.Drawing.Point(98, 207);
            this.comboBox_Sex.Name = "comboBox_Sex";
            this.comboBox_Sex.Size = new System.Drawing.Size(156, 20);
            this.comboBox_Sex.TabIndex = 22;
            // 
            // label_CPhoto
            // 
            this.label_CPhoto.AutoSize = true;
            this.label_CPhoto.Location = new System.Drawing.Point(24, 181);
            this.label_CPhoto.Name = "label_CPhoto";
            this.label_CPhoto.Size = new System.Drawing.Size(65, 12);
            this.label_CPhoto.TabIndex = 21;
            this.label_CPhoto.Text = "头    像：";
            // 
            // comboBox_CPhoto
            // 
            this.comboBox_CPhoto.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboBox_CPhoto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_CPhoto.FormattingEnabled = true;
            this.comboBox_CPhoto.Location = new System.Drawing.Point(98, 177);
            this.comboBox_CPhoto.Name = "comboBox_CPhoto";
            this.comboBox_CPhoto.Size = new System.Drawing.Size(156, 22);
            this.comboBox_CPhoto.TabIndex = 20;
            this.comboBox_CPhoto.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.comboBox_CPhoto_DrawItem);
            // 
            // text_PassWord2
            // 
            this.text_PassWord2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text_PassWord2.Location = new System.Drawing.Point(98, 147);
            this.text_PassWord2.Name = "text_PassWord2";
            this.text_PassWord2.PasswordChar = '*';
            this.text_PassWord2.Size = new System.Drawing.Size(156, 21);
            this.text_PassWord2.TabIndex = 19;
            // 
            // udpSocket1
            // 
            this.udpSocket1.Active = false;
            this.udpSocket1.LocalHost = "127.0.0.1";
            this.udpSocket1.LocalPort = 11001;
            this.udpSocket1.DataArrival += new GobangClass.UDPSocket.DataArrivalEventHandler(this.sockUDP1_DataArrival);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "头像1.png");
            this.imageList1.Images.SetKeyName(1, "头像2.png");
            this.imageList1.Images.SetKeyName(2, "头像3.png");
            this.imageList1.Images.SetKeyName(3, "头像4.png");
            this.imageList1.Images.SetKeyName(4, "头像5.png");
            this.imageList1.Images.SetKeyName(5, "头像6.png");
            // 
            // F_SerSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 300);
            this.Controls.Add(this.button_Close);
            this.Controls.Add(this.button_OK);
            this.Controls.Add(this.groupBox1);
            this.Name = "F_SerSetup";
            this.Text = "用户注册";
            this.Shown += new System.EventHandler(this.F_SerSetup_Shown);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.F_SerSetup_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.Button button_Close;
        private GobangClass.UDPSocket udpSocket1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox text_PassWord;
        private System.Windows.Forms.TextBox text_Name;
        private System.Windows.Forms.TextBox text_IP5;
        private System.Windows.Forms.TextBox text_IP;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox text_PassWord2;
        private System.Windows.Forms.Label label_CPhoto;
        private System.Windows.Forms.ComboBox comboBox_CPhoto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox_Sex;
        private System.Windows.Forms.ImageList imageList1;
    }
}