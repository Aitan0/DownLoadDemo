namespace SQL_Test
{
    partial class SQLTestMain
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labviewDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labviewDataSet = new SQL_Test.LabviewDataSet();
            this.labviewDataSet1 = new SQL_Test.LabviewDataSet();
            this.labviewDataSet2 = new SQL_Test.LabviewDataSet();
            this.sX5FVTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sX5_FVTTableAdapter = new SQL_Test.LabviewDataSetTableAdapters.SX5_FVTTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fGSNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pCBADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wIFIMACDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bTMACDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tIMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTATEDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.sTATUSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labviewDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labviewDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labviewDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labviewDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sX5FVTBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(105, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(105, 123);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(213, 197);
            this.textBox1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.fGSNDataGridViewTextBoxColumn,
            this.pCBADataGridViewTextBoxColumn,
            this.wIFIMACDataGridViewTextBoxColumn,
            this.bTMACDataGridViewTextBoxColumn,
            this.dATEDataGridViewTextBoxColumn,
            this.tIMEDataGridViewTextBoxColumn,
            this.sTATEDataGridViewCheckBoxColumn,
            this.sTATUSDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sX5FVTBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(324, 79);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(943, 150);
            this.dataGridView1.TabIndex = 2;
            // 
            // labviewDataSetBindingSource
            // 
            this.labviewDataSetBindingSource.DataSource = this.labviewDataSet;
            this.labviewDataSetBindingSource.Position = 0;
            // 
            // labviewDataSet
            // 
            this.labviewDataSet.DataSetName = "LabviewDataSet";
            this.labviewDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labviewDataSet1
            // 
            this.labviewDataSet1.DataSetName = "LabviewDataSet";
            this.labviewDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labviewDataSet2
            // 
            this.labviewDataSet2.DataSetName = "LabviewDataSet";
            this.labviewDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sX5FVTBindingSource
            // 
            this.sX5FVTBindingSource.DataMember = "SX5_FVT";
            this.sX5FVTBindingSource.DataSource = this.labviewDataSet2;
            // 
            // sX5_FVTTableAdapter
            // 
            this.sX5_FVTTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // fGSNDataGridViewTextBoxColumn
            // 
            this.fGSNDataGridViewTextBoxColumn.DataPropertyName = "FGSN";
            this.fGSNDataGridViewTextBoxColumn.HeaderText = "FGSN";
            this.fGSNDataGridViewTextBoxColumn.Name = "fGSNDataGridViewTextBoxColumn";
            // 
            // pCBADataGridViewTextBoxColumn
            // 
            this.pCBADataGridViewTextBoxColumn.DataPropertyName = "PCBA";
            this.pCBADataGridViewTextBoxColumn.HeaderText = "PCBA";
            this.pCBADataGridViewTextBoxColumn.Name = "pCBADataGridViewTextBoxColumn";
            // 
            // wIFIMACDataGridViewTextBoxColumn
            // 
            this.wIFIMACDataGridViewTextBoxColumn.DataPropertyName = "WIFI MAC";
            this.wIFIMACDataGridViewTextBoxColumn.HeaderText = "WIFI MAC";
            this.wIFIMACDataGridViewTextBoxColumn.Name = "wIFIMACDataGridViewTextBoxColumn";
            // 
            // bTMACDataGridViewTextBoxColumn
            // 
            this.bTMACDataGridViewTextBoxColumn.DataPropertyName = "BT MAC";
            this.bTMACDataGridViewTextBoxColumn.HeaderText = "BT MAC";
            this.bTMACDataGridViewTextBoxColumn.Name = "bTMACDataGridViewTextBoxColumn";
            // 
            // dATEDataGridViewTextBoxColumn
            // 
            this.dATEDataGridViewTextBoxColumn.DataPropertyName = "DATE";
            this.dATEDataGridViewTextBoxColumn.HeaderText = "DATE";
            this.dATEDataGridViewTextBoxColumn.Name = "dATEDataGridViewTextBoxColumn";
            // 
            // tIMEDataGridViewTextBoxColumn
            // 
            this.tIMEDataGridViewTextBoxColumn.DataPropertyName = "TIME";
            this.tIMEDataGridViewTextBoxColumn.HeaderText = "TIME";
            this.tIMEDataGridViewTextBoxColumn.Name = "tIMEDataGridViewTextBoxColumn";
            // 
            // sTATEDataGridViewCheckBoxColumn
            // 
            this.sTATEDataGridViewCheckBoxColumn.DataPropertyName = "STATE";
            this.sTATEDataGridViewCheckBoxColumn.HeaderText = "STATE";
            this.sTATEDataGridViewCheckBoxColumn.Name = "sTATEDataGridViewCheckBoxColumn";
            // 
            // sTATUSDataGridViewTextBoxColumn
            // 
            this.sTATUSDataGridViewTextBoxColumn.DataPropertyName = "STATUS";
            this.sTATUSDataGridViewTextBoxColumn.HeaderText = "STATUS";
            this.sTATUSDataGridViewTextBoxColumn.Name = "sTATUSDataGridViewTextBoxColumn";
            // 
            // SQLTestMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1290, 503);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "SQLTestMain";
            this.Text = "SQLTest";
            this.Load += new System.EventHandler(this.SQLTestMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labviewDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labviewDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labviewDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labviewDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sX5FVTBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource labviewDataSetBindingSource;
        private LabviewDataSet labviewDataSet;
        private LabviewDataSet labviewDataSet1;
        private LabviewDataSet labviewDataSet2;
        private System.Windows.Forms.BindingSource sX5FVTBindingSource;
        private LabviewDataSetTableAdapters.SX5_FVTTableAdapter sX5_FVTTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fGSNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pCBADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wIFIMACDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bTMACDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tIMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn sTATEDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTATUSDataGridViewTextBoxColumn;
    }
}

