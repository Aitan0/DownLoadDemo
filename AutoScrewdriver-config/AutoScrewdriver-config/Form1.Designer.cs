namespace fileRW
{
    partial class AutoScrew
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
            this.Baud = new System.Windows.Forms.ComboBox();
            this.Data = new System.Windows.Forms.ComboBox();
            this.Parit = new System.Windows.Forms.ComboBox();
            this.stop = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Comnum = new System.Windows.Forms.ComboBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.Test = new System.Windows.Forms.Button();
            this.Mod1 = new System.Windows.Forms.NumericUpDown();
            this.Mod2 = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.OK = new System.Windows.Forms.Button();
            this.amount = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.Mod1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mod2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Baud
            // 
            this.Baud.FormattingEnabled = true;
            this.Baud.Location = new System.Drawing.Point(103, 93);
            this.Baud.Name = "Baud";
            this.Baud.Size = new System.Drawing.Size(92, 21);
            this.Baud.TabIndex = 1;
            // 
            // Data
            // 
            this.Data.FormattingEnabled = true;
            this.Data.Location = new System.Drawing.Point(103, 140);
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(92, 21);
            this.Data.TabIndex = 1;
            // 
            // Parit
            // 
            this.Parit.FormattingEnabled = true;
            this.Parit.Location = new System.Drawing.Point(103, 187);
            this.Parit.Name = "Parit";
            this.Parit.Size = new System.Drawing.Size(92, 21);
            this.Parit.TabIndex = 1;
            // 
            // stop
            // 
            this.stop.FormattingEnabled = true;
            this.stop.Location = new System.Drawing.Point(103, 234);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(92, 21);
            this.stop.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ComNum";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "BaudRate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "DataBits";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Parity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "StopBits";
            // 
            // Comnum
            // 
            this.Comnum.FormattingEnabled = true;
            this.Comnum.Location = new System.Drawing.Point(103, 46);
            this.Comnum.Name = "Comnum";
            this.Comnum.Size = new System.Drawing.Size(92, 21);
            this.Comnum.TabIndex = 3;
            // 
            // Test
            // 
            this.Test.Location = new System.Drawing.Point(103, 369);
            this.Test.Name = "Test";
            this.Test.Size = new System.Drawing.Size(75, 23);
            this.Test.TabIndex = 4;
            this.Test.Text = "Test";
            this.Test.UseVisualStyleBackColor = true;
            this.Test.Click += new System.EventHandler(this.Test_Click);
            // 
            // Mod1
            // 
            this.Mod1.Location = new System.Drawing.Point(103, 281);
            this.Mod1.Name = "Mod1";
            this.Mod1.Size = new System.Drawing.Size(92, 20);
            this.Mod1.TabIndex = 5;
            // 
            // Mod2
            // 
            this.Mod2.Location = new System.Drawing.Point(103, 327);
            this.Mod2.Name = "Mod2";
            this.Mod2.Size = new System.Drawing.Size(92, 20);
            this.Mod2.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 281);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Mod1Addr";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(47, 328);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Mod2Addr";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(50, 398);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(145, 56);
            this.listBox1.TabIndex = 6;
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(324, 409);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
            this.OK.TabIndex = 7;
            this.OK.TabStop = false;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // amount
            // 
            this.amount.Location = new System.Drawing.Point(324, 46);
            this.amount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(92, 20);
            this.amount.TabIndex = 8;
            this.amount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.amount.ValueChanged += new System.EventHandler(this.amount_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(276, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "amount";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView1.Location = new System.Drawing.Point(432, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(343, 395);
            this.dataGridView1.TabIndex = 10;
            // 
            // AutoScrew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 464);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Mod2);
            this.Controls.Add(this.Mod1);
            this.Controls.Add(this.Test);
            this.Controls.Add(this.Comnum);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.Parit);
            this.Controls.Add(this.Data);
            this.Controls.Add(this.Baud);
            this.Name = "AutoScrew";
            this.Text = "AutoScrewdriver-config";
            this.Load += new System.EventHandler(this.AutoScrew_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Mod1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mod2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Baud;
        private System.Windows.Forms.ComboBox Data;
        private System.Windows.Forms.ComboBox Parit;
        private System.Windows.Forms.ComboBox stop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox Comnum;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button Test;
        private System.Windows.Forms.NumericUpDown Mod1;
        private System.Windows.Forms.NumericUpDown Mod2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.NumericUpDown amount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

