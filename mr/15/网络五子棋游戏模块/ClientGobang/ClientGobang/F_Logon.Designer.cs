﻿namespace ClientGobang
{
    partial class F_Logon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Logon));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_QQLogon = new System.Windows.Forms.Button();
            this.button_QQClose = new System.Windows.Forms.Button();
            this.text_Name = new System.Windows.Forms.TextBox();
            this.text_PassWord = new System.Windows.Forms.TextBox();
            this.udpSocket1 = new GobangClass.UDPSocket(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(306, 163);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button_QQLogon
            // 
            this.button_QQLogon.Location = new System.Drawing.Point(123, 144);
            this.button_QQLogon.Name = "button_QQLogon";
            this.button_QQLogon.Size = new System.Drawing.Size(43, 23);
            this.button_QQLogon.TabIndex = 1;
            this.button_QQLogon.Text = "登录";
            this.button_QQLogon.UseVisualStyleBackColor = true;
            this.button_QQLogon.Click += new System.EventHandler(this.button_QQLogon_Click);
            // 
            // button_QQClose
            // 
            this.button_QQClose.Location = new System.Drawing.Point(203, 144);
            this.button_QQClose.Name = "button_QQClose";
            this.button_QQClose.Size = new System.Drawing.Size(43, 23);
            this.button_QQClose.TabIndex = 2;
            this.button_QQClose.Text = "退出";
            this.button_QQClose.UseVisualStyleBackColor = true;
            this.button_QQClose.Click += new System.EventHandler(this.button_QQClose_Click);
            // 
            // text_Name
            // 
            this.text_Name.Location = new System.Drawing.Point(146, 68);
            this.text_Name.Name = "text_Name";
            this.text_Name.Size = new System.Drawing.Size(100, 21);
            this.text_Name.TabIndex = 5;
            // 
            // text_PassWord
            // 
            this.text_PassWord.Location = new System.Drawing.Point(146, 107);
            this.text_PassWord.Name = "text_PassWord";
            this.text_PassWord.PasswordChar = '*';
            this.text_PassWord.Size = new System.Drawing.Size(100, 21);
            this.text_PassWord.TabIndex = 6;
            // 
            // udpSocket1
            // 
            this.udpSocket1.Active = false;
            this.udpSocket1.LocalHost = "127.0.0.1";
            this.udpSocket1.LocalPort = 11001;
            this.udpSocket1.DataArrival += new GobangClass.UDPSocket.DataArrivalEventHandler(this.udpSocket1_DataArrival);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(306, 37);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseMove);
            this.pictureBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(72, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "用户名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(72, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "密  码：";
            // 
            // F_Logon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(306, 200);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.text_PassWord);
            this.Controls.Add(this.text_Name);
            this.Controls.Add(this.button_QQClose);
            this.Controls.Add(this.button_QQLogon);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "F_Logon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_Logon";
            this.Load += new System.EventHandler(this.F_Logon_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.F_Logon_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_QQLogon;
        private System.Windows.Forms.Button button_QQClose;
        private System.Windows.Forms.TextBox text_Name;
        private System.Windows.Forms.TextBox text_PassWord;
        private GobangClass.UDPSocket udpSocket1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}