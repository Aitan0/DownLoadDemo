namespace Express.UI.BaseSet
{
    partial class FormBillTypeInput
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBillTypeInput));
            this.label5 = new System.Windows.Forms.Label();
            this.txtBillHeight = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.txtBillWidth = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBillTypeName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBillTypeCode = new System.Windows.Forms.TextBox();
            this.lb1 = new System.Windows.Forms.Label();
            this.btnChoice = new System.Windows.Forms.Button();
            this.pbxBillPicture = new System.Windows.Forms.PictureBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dlgPicture = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBillCodeLength = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.rbIsEnabled1 = new System.Windows.Forms.RadioButton();
            this.rbIsEnabled0 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBillPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoEllipsis = true;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 89;
            this.label5.Text = "备    注";
            // 
            // txtBillHeight
            // 
            this.txtBillHeight.Location = new System.Drawing.Point(75, 113);
            this.txtBillHeight.MaxLength = 3;
            this.txtBillHeight.Name = "txtBillHeight";
            this.txtBillHeight.Size = new System.Drawing.Size(174, 21);
            this.txtBillHeight.TabIndex = 81;
            this.txtBillHeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBillHeight_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 117);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 82;
            this.label10.Text = "单据高度";
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(75, 181);
            this.txtRemark.MaxLength = 200;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(174, 21);
            this.txtRemark.TabIndex = 78;
            // 
            // txtBillWidth
            // 
            this.txtBillWidth.Location = new System.Drawing.Point(75, 79);
            this.txtBillWidth.MaxLength = 3;
            this.txtBillWidth.Name = "txtBillWidth";
            this.txtBillWidth.Size = new System.Drawing.Size(174, 21);
            this.txtBillWidth.TabIndex = 75;
            this.txtBillWidth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBillWidth_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 76;
            this.label4.Text = "单据宽度";
            // 
            // txtBillTypeName
            // 
            this.txtBillTypeName.Location = new System.Drawing.Point(75, 45);
            this.txtBillTypeName.MaxLength = 20;
            this.txtBillTypeName.Name = "txtBillTypeName";
            this.txtBillTypeName.Size = new System.Drawing.Size(174, 21);
            this.txtBillTypeName.TabIndex = 70;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 71;
            this.label2.Text = "单据名称";
            // 
            // txtBillTypeCode
            // 
            this.txtBillTypeCode.AcceptsReturn = true;
            this.txtBillTypeCode.Enabled = false;
            this.txtBillTypeCode.Location = new System.Drawing.Point(75, 11);
            this.txtBillTypeCode.MaxLength = 50;
            this.txtBillTypeCode.Name = "txtBillTypeCode";
            this.txtBillTypeCode.Size = new System.Drawing.Size(174, 21);
            this.txtBillTypeCode.TabIndex = 66;
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(18, 15);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(53, 12);
            this.lb1.TabIndex = 68;
            this.lb1.Text = "单据代码";
            // 
            // btnChoice
            // 
            this.btnChoice.Location = new System.Drawing.Point(321, 10);
            this.btnChoice.Name = "btnChoice";
            this.btnChoice.Size = new System.Drawing.Size(108, 23);
            this.btnChoice.TabIndex = 90;
            this.btnChoice.Text = "选择单据图片...";
            this.btnChoice.UseVisualStyleBackColor = true;
            this.btnChoice.Click += new System.EventHandler(this.btnChoice_Click);
            // 
            // pbxBillPicture
            // 
            this.pbxBillPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxBillPicture.Location = new System.Drawing.Point(286, 43);
            this.pbxBillPicture.Name = "pbxBillPicture";
            this.pbxBillPicture.Size = new System.Drawing.Size(174, 189);
            this.pbxBillPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxBillPicture.TabIndex = 91;
            this.pbxBillPicture.TabStop = false;
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(385, 247);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 23);
            this.btnReturn.TabIndex = 94;
            this.btnReturn.Text = "返回";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(282, 247);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 93;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dlgPicture
            // 
            this.dlgPicture.AddExtension = false;
            this.dlgPicture.Filter = "图片文件(*.bmp;*.jpg;*.jpeg)|*.bmp;*.jpg;*.jpeg";
            this.dlgPicture.Title = "打开快递单图片";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(252, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 95;
            this.label1.Text = "mm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(252, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 96;
            this.label3.Text = "mm";
            // 
            // txtBillCodeLength
            // 
            this.txtBillCodeLength.Location = new System.Drawing.Point(75, 147);
            this.txtBillCodeLength.MaxLength = 2;
            this.txtBillCodeLength.Name = "txtBillCodeLength";
            this.txtBillCodeLength.Size = new System.Drawing.Size(174, 21);
            this.txtBillCodeLength.TabIndex = 97;
            this.txtBillCodeLength.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBillCodeLength_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoEllipsis = true;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 98;
            this.label6.Text = "单号位数";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 99;
            this.label7.Text = "状    态";
            // 
            // rbIsEnabled1
            // 
            this.rbIsEnabled1.AutoSize = true;
            this.rbIsEnabled1.Checked = true;
            this.rbIsEnabled1.Location = new System.Drawing.Point(102, 216);
            this.rbIsEnabled1.Name = "rbIsEnabled1";
            this.rbIsEnabled1.Size = new System.Drawing.Size(47, 16);
            this.rbIsEnabled1.TabIndex = 100;
            this.rbIsEnabled1.TabStop = true;
            this.rbIsEnabled1.Text = "启用";
            this.rbIsEnabled1.UseVisualStyleBackColor = true;
            // 
            // rbIsEnabled0
            // 
            this.rbIsEnabled0.AutoSize = true;
            this.rbIsEnabled0.Location = new System.Drawing.Point(190, 216);
            this.rbIsEnabled0.Name = "rbIsEnabled0";
            this.rbIsEnabled0.Size = new System.Drawing.Size(47, 16);
            this.rbIsEnabled0.TabIndex = 101;
            this.rbIsEnabled0.TabStop = true;
            this.rbIsEnabled0.Text = "禁用";
            this.rbIsEnabled0.UseVisualStyleBackColor = true;
            // 
            // FormBillTypeInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(484, 282);
            this.Controls.Add(this.rbIsEnabled0);
            this.Controls.Add(this.rbIsEnabled1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBillCodeLength);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.pbxBillPicture);
            this.Controls.Add(this.btnChoice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBillHeight);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtRemark);
            this.Controls.Add(this.txtBillWidth);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBillTypeName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBillTypeCode);
            this.Controls.Add(this.lb1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormBillTypeInput";
            this.ShowInTaskbar = false;
            this.Text = "快递单基本信息";
            this.Load += new System.EventHandler(this.FormBillTypeInput_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxBillPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBillHeight;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.TextBox txtBillWidth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBillTypeName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBillTypeCode;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Button btnChoice;
        private System.Windows.Forms.PictureBox pbxBillPicture;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.OpenFileDialog dlgPicture;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBillCodeLength;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rbIsEnabled1;
        private System.Windows.Forms.RadioButton rbIsEnabled0;
    }
}