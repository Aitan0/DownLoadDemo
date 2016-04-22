namespace Express
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.errInfo = new System.Windows.Forms.ErrorProvider(this.components);
            this.picQuit = new System.Windows.Forms.PictureBox();
            this.picReset = new System.Windows.Forms.PictureBox();
            this.picLogin = new System.Windows.Forms.PictureBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtPwd = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picQuit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picReset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // errInfo
            // 
            this.errInfo.ContainerControl = this;
            // 
            // picQuit
            // 
            this.picQuit.BackColor = System.Drawing.Color.Transparent;
            this.picQuit.Image = ((System.Drawing.Image)(resources.GetObject("picQuit.Image")));
            this.picQuit.Location = new System.Drawing.Point(315, 211);
            this.picQuit.Name = "picQuit";
            this.picQuit.Size = new System.Drawing.Size(54, 23);
            this.picQuit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picQuit.TabIndex = 18;
            this.picQuit.TabStop = false;
            this.picQuit.Click += new System.EventHandler(this.picQuit_Click);
            // 
            // picReset
            // 
            this.picReset.BackColor = System.Drawing.Color.Transparent;
            this.picReset.Image = ((System.Drawing.Image)(resources.GetObject("picReset.Image")));
            this.picReset.Location = new System.Drawing.Point(250, 211);
            this.picReset.Name = "picReset";
            this.picReset.Size = new System.Drawing.Size(54, 23);
            this.picReset.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picReset.TabIndex = 17;
            this.picReset.TabStop = false;
            this.picReset.Click += new System.EventHandler(this.picReset_Click);
            // 
            // picLogin
            // 
            this.picLogin.BackColor = System.Drawing.Color.Transparent;
            this.picLogin.Image = ((System.Drawing.Image)(resources.GetObject("picLogin.Image")));
            this.picLogin.Location = new System.Drawing.Point(185, 211);
            this.picLogin.Name = "picLogin";
            this.picLogin.Size = new System.Drawing.Size(54, 23);
            this.picLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picLogin.TabIndex = 16;
            this.picLogin.TabStop = false;
            this.picLogin.Click += new System.EventHandler(this.picLogin_Click);
            // 
            // txtCode
            // 
            this.txtCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCode.Location = new System.Drawing.Point(254, 146);
            this.txtCode.MaxLength = 10;
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(116, 21);
            this.txtCode.TabIndex = 14;
            this.txtCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCode_KeyDown);
            // 
            // txtPwd
            // 
            this.txtPwd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPwd.Location = new System.Drawing.Point(254, 173);
            this.txtPwd.MaxLength = 20;
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(116, 21);
            this.txtPwd.TabIndex = 15;
            this.txtPwd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPwd_KeyDown);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(420, 258);
            this.Controls.Add(this.picQuit);
            this.Controls.Add(this.picReset);
            this.Controls.Add(this.picLogin);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.txtPwd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "系统登录";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCode_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.errInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picQuit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picReset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errInfo;
        private System.Windows.Forms.PictureBox picQuit;
        private System.Windows.Forms.PictureBox picReset;
        private System.Windows.Forms.PictureBox picLogin;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TextBox txtPwd;
    }
}