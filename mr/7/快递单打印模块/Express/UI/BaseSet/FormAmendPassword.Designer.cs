namespace Express.UI.BaseSet
{
    partial class FormAmendPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAmendPassword));
            this.errPassword = new System.Windows.Forms.ErrorProvider(this.components);
            this.errOldPassword = new System.Windows.Forms.ErrorProvider(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.errAffirmPassword = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtOldPassword = new System.Windows.Forms.TextBox();
            this.btnQuit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAffirmPassWord = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errOldPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errAffirmPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // errPassword
            // 
            this.errPassword.ContainerControl = this;
            // 
            // errOldPassword
            // 
            this.errOldPassword.ContainerControl = this;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 29;
            this.label3.Text = "原 密 码";
            // 
            // errAffirmPassword
            // 
            this.errAffirmPassword.ContainerControl = this;
            // 
            // txtOldPassword
            // 
            this.txtOldPassword.AcceptsReturn = true;
            this.txtOldPassword.Location = new System.Drawing.Point(127, 19);
            this.txtOldPassword.MaxLength = 20;
            this.txtOldPassword.Name = "txtOldPassword";
            this.txtOldPassword.Size = new System.Drawing.Size(145, 21);
            this.txtOldPassword.TabIndex = 22;
            this.txtOldPassword.UseSystemPasswordChar = true;
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(197, 143);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 23);
            this.btnQuit.TabIndex = 27;
            this.btnQuit.Text = "退出";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 26;
            this.label2.Text = "确认密码";
            // 
            // txtAffirmPassWord
            // 
            this.txtAffirmPassWord.AcceptsReturn = true;
            this.txtAffirmPassWord.Location = new System.Drawing.Point(127, 105);
            this.txtAffirmPassWord.MaxLength = 20;
            this.txtAffirmPassWord.Name = "txtAffirmPassWord";
            this.txtAffirmPassWord.Size = new System.Drawing.Size(145, 21);
            this.txtAffirmPassWord.TabIndex = 25;
            this.txtAffirmPassWord.UseSystemPasswordChar = true;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(65, 143);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 24;
            this.btnOk.Text = "保存";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 23;
            this.label1.Text = "新 密 码";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(127, 61);
            this.txtPassword.MaxLength = 20;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(145, 21);
            this.txtPassword.TabIndex = 28;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // FormAmendPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 185);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtOldPassword);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAffirmPassWord);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPassword);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAmendPassword";
            this.ShowInTaskbar = false;
            this.Text = "修改密码";
            ((System.ComponentModel.ISupportInitialize)(this.errPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errOldPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errAffirmPassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOldPassword;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAffirmPassWord;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.ErrorProvider errOldPassword;
        private System.Windows.Forms.ErrorProvider errAffirmPassword;
    }
}