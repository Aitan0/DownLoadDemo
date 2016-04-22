namespace Auto_Screw_Control_Csharp
{
    partial class ConfigForm
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
            this.Save = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.CountNum = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.Com1Combo = new System.Windows.Forms.ComboBox();
            this.Com2Combo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.IcpdasComCombo = new System.Windows.Forms.ComboBox();
            this.Address = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.General = new System.Windows.Forms.GroupBox();
            this.IndexNum = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.ScopeNum = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.Pos1 = new System.Windows.Forms.NumericUpDown();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.Pos2 = new System.Windows.Forms.NumericUpDown();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.PosScope = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.CountNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Address)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IndexNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScopeNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pos1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pos2)).BeginInit();
            this.PosScope.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(67, 354);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 0;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(438, 354);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 1;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // CountNum
            // 
            this.CountNum.Location = new System.Drawing.Point(81, 33);
            this.CountNum.Name = "CountNum";
            this.CountNum.Size = new System.Drawing.Size(75, 20);
            this.CountNum.TabIndex = 2;
            this.CountNum.ValueChanged += new System.EventHandler(this.CountNum_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Count";
            // 
            // Com1Combo
            // 
            this.Com1Combo.FormattingEnabled = true;
            this.Com1Combo.Location = new System.Drawing.Point(81, 76);
            this.Com1Combo.Name = "Com1Combo";
            this.Com1Combo.Size = new System.Drawing.Size(75, 21);
            this.Com1Combo.TabIndex = 4;
            // 
            // Com2Combo
            // 
            this.Com2Combo.FormattingEnabled = true;
            this.Com2Combo.Location = new System.Drawing.Point(81, 120);
            this.Com2Combo.Name = "Com2Combo";
            this.Com2Combo.Size = new System.Drawing.Size(75, 21);
            this.Com2Combo.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Com1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Com2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "IcpdasCom";
            // 
            // IcpdasComCombo
            // 
            this.IcpdasComCombo.FormattingEnabled = true;
            this.IcpdasComCombo.Location = new System.Drawing.Point(81, 164);
            this.IcpdasComCombo.Name = "IcpdasComCombo";
            this.IcpdasComCombo.Size = new System.Drawing.Size(75, 21);
            this.IcpdasComCombo.TabIndex = 4;
            // 
            // Address
            // 
            this.Address.Location = new System.Drawing.Point(81, 210);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(75, 20);
            this.Address.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Address";
            // 
            // General
            // 
            this.General.Location = new System.Drawing.Point(12, 13);
            this.General.Name = "General";
            this.General.Size = new System.Drawing.Size(179, 327);
            this.General.TabIndex = 5;
            this.General.TabStop = false;
            this.General.Text = "General";
            // 
            // IndexNum
            // 
            this.IndexNum.Location = new System.Drawing.Point(81, 251);
            this.IndexNum.Name = "IndexNum";
            this.IndexNum.Size = new System.Drawing.Size(75, 20);
            this.IndexNum.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Index";
            // 
            // ScopeNum
            // 
            this.ScopeNum.Location = new System.Drawing.Point(81, 295);
            this.ScopeNum.Name = "ScopeNum";
            this.ScopeNum.Size = new System.Drawing.Size(75, 20);
            this.ScopeNum.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 297);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Scope";
            // 
            // Pos1
            // 
            this.Pos1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pos1.Location = new System.Drawing.Point(290, 294);
            this.Pos1.Name = "Pos1";
            this.Pos1.Size = new System.Drawing.Size(118, 31);
            this.Pos1.TabIndex = 7;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(220, 297);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(64, 24);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Pos1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Pos2
            // 
            this.Pos2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pos2.Location = new System.Drawing.Point(510, 294);
            this.Pos2.Name = "Pos2";
            this.Pos2.Size = new System.Drawing.Size(118, 31);
            this.Pos2.TabIndex = 7;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Location = new System.Drawing.Point(440, 297);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(64, 24);
            this.checkBox2.TabIndex = 8;
            this.checkBox2.Text = "Pos2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // PosScope
            // 
            this.PosScope.Controls.Add(this.dataGridView2);
            this.PosScope.Controls.Add(this.dataGridView1);
            this.PosScope.Location = new System.Drawing.Point(197, 13);
            this.PosScope.Name = "PosScope";
            this.PosScope.Size = new System.Drawing.Size(443, 327);
            this.PosScope.TabIndex = 9;
            this.PosScope.TabStop = false;
            this.PosScope.Text = "PosScope";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(227, 22);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(204, 236);
            this.dataGridView2.TabIndex = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(204, 236);
            this.dataGridView1.TabIndex = 10;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // ConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 389);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.Pos2);
            this.Controls.Add(this.Pos1);
            this.Controls.Add(this.IcpdasComCombo);
            this.Controls.Add(this.Com2Combo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Com1Combo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ScopeNum);
            this.Controls.Add(this.IndexNum);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.CountNum);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.General);
            this.Controls.Add(this.PosScope);
            this.Name = "ConfigForm";
            this.Text = "ConfigForm";
            this.Load += new System.EventHandler(this.ConfigForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CountNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Address)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IndexNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScopeNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pos1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pos2)).EndInit();
            this.PosScope.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.NumericUpDown CountNum;
        private System.Windows.Forms.Label label1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ComboBox Com1Combo;
        private System.Windows.Forms.ComboBox Com2Combo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox IcpdasComCombo;
        private System.Windows.Forms.NumericUpDown Address;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox General;
        private System.Windows.Forms.NumericUpDown IndexNum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown ScopeNum;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown Pos1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.NumericUpDown Pos2;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.GroupBox PosScope;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}