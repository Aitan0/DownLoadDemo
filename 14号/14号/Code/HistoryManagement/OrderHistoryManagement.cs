using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data.SqlClient;
using HotelManagementSystem.Data;
using HotelManagementSystem.Config;

//预订单历史查询
namespace HotelManagementSystem.HistoryManagement
{
	/// <summary>
	/// OrderHistoryManagement 的摘要说明。
	/// </summary>
	public class OrderHistoryManagement : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.DataGrid dataGrid1;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnEnd;
		private System.Windows.Forms.Button btnNext;
		private System.Windows.Forms.Button btnBack;
		private System.Windows.Forms.Button btnFirst;
		private System.Windows.Forms.Button btnAll;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.Button btnFind;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.TextBox textBox1;
		private HotelManagementSystem.Data.HotelDataSet ds;
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;
		private System.Data.SqlClient.SqlConnection conn;
		private System.Data.SqlClient.SqlDataAdapter da;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
		private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
		private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
		BindingManagerBase bmb;

		public OrderHistoryManagement()
		{
			//
			// Windows 窗体设计器支持所必需的
			//
			InitializeComponent();

			//
			// TODO: 在 InitializeComponent 调用后添加任何构造函数代码
			//
		}

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows 窗体设计器生成的代码
		/// <summary>
		/// 设计器支持所需的方法 - 不要使用代码编辑器修改
		/// 此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			this.label24 = new System.Windows.Forms.Label();
			this.label23 = new System.Windows.Forms.Label();
			this.dataGrid1 = new System.Windows.Forms.DataGrid();
			this.ds = new HotelManagementSystem.Data.HotelDataSet();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnEnd = new System.Windows.Forms.Button();
			this.btnNext = new System.Windows.Forms.Button();
			this.btnBack = new System.Windows.Forms.Button();
			this.btnFirst = new System.Windows.Forms.Button();
			this.btnAll = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.btnFind = new System.Windows.Forms.Button();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.conn = new System.Data.SqlClient.SqlConnection();
			this.da = new System.Data.SqlClient.SqlDataAdapter();
			this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// label24
			// 
			this.label24.Location = new System.Drawing.Point(626, 40);
			this.label24.Name = "label24";
			this.label24.TabIndex = 66;
			this.label24.Text = "记录数：";
			this.label24.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// label23
			// 
			this.label23.Location = new System.Drawing.Point(18, 40);
			this.label23.Name = "label23";
			this.label23.TabIndex = 65;
			this.label23.Text = "当前记录：";
			this.label23.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// dataGrid1
			// 
			this.dataGrid1.DataMember = "预订单历史";
			this.dataGrid1.DataSource = this.ds;
			this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGrid1.Location = new System.Drawing.Point(16, 64);
			this.dataGrid1.Name = "dataGrid1";
			this.dataGrid1.ReadOnly = true;
			this.dataGrid1.Size = new System.Drawing.Size(712, 328);
			this.dataGrid1.TabIndex = 64;
			// 
			// ds
			// 
			this.ds.DataSetName = "HotelDataSet";
			this.ds.Locale = new System.Globalization.CultureInfo("en-US");
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(535, 24);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.TabIndex = 63;
			this.btnCancel.Text = "退出";
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnEnd
			// 
			this.btnEnd.Location = new System.Drawing.Point(454, 24);
			this.btnEnd.Name = "btnEnd";
			this.btnEnd.TabIndex = 62;
			this.btnEnd.Text = "最后";
			this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
			// 
			// btnNext
			// 
			this.btnNext.Location = new System.Drawing.Point(373, 24);
			this.btnNext.Name = "btnNext";
			this.btnNext.TabIndex = 61;
			this.btnNext.Text = "下一个";
			this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
			// 
			// btnBack
			// 
			this.btnBack.Location = new System.Drawing.Point(292, 24);
			this.btnBack.Name = "btnBack";
			this.btnBack.TabIndex = 60;
			this.btnBack.Text = "上一个";
			this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
			// 
			// btnFirst
			// 
			this.btnFirst.Location = new System.Drawing.Point(211, 24);
			this.btnFirst.Name = "btnFirst";
			this.btnFirst.TabIndex = 59;
			this.btnFirst.Text = "最前";
			this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
			// 
			// btnAll
			// 
			this.btnAll.Location = new System.Drawing.Point(130, 24);
			this.btnAll.Name = "btnAll";
			this.btnAll.TabIndex = 58;
			this.btnAll.Text = "查询所有";
			this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.radioButton1);
			this.groupBox2.Controls.Add(this.btnFind);
			this.groupBox2.Controls.Add(this.textBox2);
			this.groupBox2.Controls.Add(this.radioButton2);
			this.groupBox2.Controls.Add(this.textBox1);
			this.groupBox2.Location = new System.Drawing.Point(16, 408);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(712, 64);
			this.groupBox2.TabIndex = 67;
			this.groupBox2.TabStop = false;
			// 
			// radioButton1
			// 
			this.radioButton1.Location = new System.Drawing.Point(16, 27);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(80, 24);
			this.radioButton1.TabIndex = 5;
			this.radioButton1.Text = "预订单号";
			this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
			// 
			// btnFind
			// 
			this.btnFind.Location = new System.Drawing.Point(608, 27);
			this.btnFind.Name = "btnFind";
			this.btnFind.TabIndex = 4;
			this.btnFind.Text = "查询";
			this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
			// 
			// textBox2
			// 
			this.textBox2.Enabled = false;
			this.textBox2.Location = new System.Drawing.Point(400, 27);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(176, 21);
			this.textBox2.TabIndex = 3;
			this.textBox2.Text = "";
			// 
			// radioButton2
			// 
			this.radioButton2.Location = new System.Drawing.Point(320, 27);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(72, 24);
			this.radioButton2.TabIndex = 2;
			this.radioButton2.Text = "客房编号";
			this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
			// 
			// textBox1
			// 
			this.textBox1.Enabled = false;
			this.textBox1.Location = new System.Drawing.Point(104, 27);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(176, 21);
			this.textBox1.TabIndex = 1;
			this.textBox1.Text = "";
			// 
			// da
			// 
			this.da.DeleteCommand = this.sqlDeleteCommand1;
			this.da.InsertCommand = this.sqlInsertCommand1;
			this.da.SelectCommand = this.sqlSelectCommand1;
			this.da.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																						 new System.Data.Common.DataTableMapping("Table", "预订单历史", new System.Data.Common.DataColumnMapping[] {
																																																  new System.Data.Common.DataColumnMapping("预订单号", "预订单号"),
																																																  new System.Data.Common.DataColumnMapping("会员编号", "会员编号"),
																																																  new System.Data.Common.DataColumnMapping("客房编号", "客房编号"),
																																																  new System.Data.Common.DataColumnMapping("客房类型", "客房类型"),
																																																  new System.Data.Common.DataColumnMapping("客房位置", "客房位置"),
																																																  new System.Data.Common.DataColumnMapping("抵店时间", "抵店时间"),
																																																  new System.Data.Common.DataColumnMapping("离店时间", "离店时间"),
																																																  new System.Data.Common.DataColumnMapping("单据状态", "单据状态"),
																																																  new System.Data.Common.DataColumnMapping("入住人数", "入住人数"),
																																																  new System.Data.Common.DataColumnMapping("客房价格", "客房价格"),
																																																  new System.Data.Common.DataColumnMapping("入住价格", "入住价格"),
																																																  new System.Data.Common.DataColumnMapping("折扣", "折扣"),
																																																  new System.Data.Common.DataColumnMapping("折扣原因", "折扣原因"),
																																																  new System.Data.Common.DataColumnMapping("是否加床", "是否加床"),
																																																  new System.Data.Common.DataColumnMapping("加床价格", "加床价格"),
																																																  new System.Data.Common.DataColumnMapping("预收款", "预收款"),
																																																  new System.Data.Common.DataColumnMapping("预订人", "预订人"),
																																																  new System.Data.Common.DataColumnMapping("身份证", "身份证"),
																																																  new System.Data.Common.DataColumnMapping("预订公司", "预订公司"),
																																																  new System.Data.Common.DataColumnMapping("联系电话", "联系电话"),
																																																  new System.Data.Common.DataColumnMapping("备注", "备注"),
																																																  new System.Data.Common.DataColumnMapping("操作员", "操作员"),
																																																  new System.Data.Common.DataColumnMapping("业务员", "业务员")})});
			this.da.UpdateCommand = this.sqlUpdateCommand1;
			// 
			// sqlDeleteCommand1
			// 
			this.sqlDeleteCommand1.CommandText = "DELETE FROM 预订单历史 WHERE (预订单号 = @Original_预订单号) AND (业务员 = @Original_业务员 OR @Orig" +
				"inal_业务员 IS NULL AND 业务员 IS NULL) AND (会员编号 = @Original_会员编号 OR @Original_会员编号 I" +
				"S NULL AND 会员编号 IS NULL) AND (入住人数 = @Original_入住人数 OR @Original_入住人数 IS NULL AN" +
				"D 入住人数 IS NULL) AND (入住价格 = @Original_入住价格 OR @Original_入住价格 IS NULL AND 入住价格 IS" +
				" NULL) AND (加床价格 = @Original_加床价格 OR @Original_加床价格 IS NULL AND 加床价格 IS NULL) AN" +
				"D (单据状态 = @Original_单据状态 OR @Original_单据状态 IS NULL AND 单据状态 IS NULL) AND (备注 = @" +
				"Original_备注 OR @Original_备注 IS NULL AND 备注 IS NULL) AND (客房价格 = @Original_客房价格 O" +
				"R @Original_客房价格 IS NULL AND 客房价格 IS NULL) AND (客房位置 = @Original_客房位置 OR @Origin" +
				"al_客房位置 IS NULL AND 客房位置 IS NULL) AND (客房类型 = @Original_客房类型 OR @Original_客房类型 I" +
				"S NULL AND 客房类型 IS NULL) AND (客房编号 = @Original_客房编号) AND (折扣 = @Original_折扣 OR @" +
				"Original_折扣 IS NULL AND 折扣 IS NULL) AND (折扣原因 = @Original_折扣原因 OR @Original_折扣原因" +
				" IS NULL AND 折扣原因 IS NULL) AND (抵店时间 = @Original_抵店时间 OR @Original_抵店时间 IS NULL " +
				"AND 抵店时间 IS NULL) AND (操作员 = @Original_操作员 OR @Original_操作员 IS NULL AND 操作员 IS N" +
				"ULL) AND (是否加床 = @Original_是否加床 OR @Original_是否加床 IS NULL AND 是否加床 IS NULL) AND " +
				"(离店时间 = @Original_离店时间 OR @Original_离店时间 IS NULL AND 离店时间 IS NULL) AND (联系电话 = @" +
				"Original_联系电话 OR @Original_联系电话 IS NULL AND 联系电话 IS NULL) AND (身份证 = @Original_身" +
				"份证 OR @Original_身份证 IS NULL AND 身份证 IS NULL) AND (预收款 = @Original_预收款 OR @Origin" +
				"al_预收款 IS NULL AND 预收款 IS NULL) AND (预订人 = @Original_预订人 OR @Original_预订人 IS NUL" +
				"L AND 预订人 IS NULL) AND (预订公司 = @Original_预订公司 OR @Original_预订公司 IS NULL AND 预订公司" +
				" IS NULL)";
			this.sqlDeleteCommand1.Connection = this.conn;
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_预订单号", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "预订单号", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_业务员", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "业务员", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_会员编号", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "会员编号", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_入住人数", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "入住人数", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_入住价格", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "入住价格", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_加床价格", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "加床价格", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_单据状态", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "单据状态", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_备注", System.Data.SqlDbType.VarChar, 40, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "备注", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_客房价格", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "客房价格", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_客房位置", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "客房位置", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_客房类型", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "客房类型", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_客房编号", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "客房编号", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_折扣", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "折扣", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_折扣原因", System.Data.SqlDbType.VarChar, 40, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "折扣原因", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_抵店时间", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "抵店时间", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_操作员", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "操作员", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_是否加床", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "是否加床", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_离店时间", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "离店时间", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_联系电话", System.Data.SqlDbType.VarChar, 13, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "联系电话", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_身份证", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "身份证", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_预收款", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "预收款", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_预订人", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "预订人", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_预订公司", System.Data.SqlDbType.VarChar, 40, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "预订公司", System.Data.DataRowVersion.Original, null));
			// 
			// sqlInsertCommand1
			// 
			this.sqlInsertCommand1.CommandText = @"INSERT INTO 预订单历史(预订单号, 会员编号, 客房编号, 客房类型, 客房位置, 抵店时间, 离店时间, 单据状态, 入住人数, 客房价格, 入住价格, 折扣, 折扣原因, 是否加床, 加床价格, 预收款, 预订人, 身份证, 预订公司, 联系电话, 备注, 操作员, 业务员) VALUES (@预订单号, @会员编号, @客房编号, @客房类型, @客房位置, @抵店时间, @离店时间, @单据状态, @入住人数, @客房价格, @入住价格, @折扣, @折扣原因, @是否加床, @加床价格, @预收款, @预订人, @身份证, @预订公司, @联系电话, @备注, @操作员, @业务员); SELECT 预订单号, 会员编号, 客房编号, 客房类型, 客房位置, 抵店时间, 离店时间, 单据状态, 入住人数, 客房价格, 入住价格, 折扣, 折扣原因, 是否加床, 加床价格, 预收款, 预订人, 身份证, 预订公司, 联系电话, 备注, 操作员, 业务员 FROM 预订单历史 WHERE (预订单号 = @预订单号)";
			this.sqlInsertCommand1.Connection = this.conn;
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@预订单号", System.Data.SqlDbType.VarChar, 10, "预订单号"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@会员编号", System.Data.SqlDbType.VarChar, 10, "会员编号"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@客房编号", System.Data.SqlDbType.VarChar, 10, "客房编号"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@客房类型", System.Data.SqlDbType.VarChar, 20, "客房类型"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@客房位置", System.Data.SqlDbType.VarChar, 10, "客房位置"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@抵店时间", System.Data.SqlDbType.DateTime, 4, "抵店时间"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@离店时间", System.Data.SqlDbType.DateTime, 4, "离店时间"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@单据状态", System.Data.SqlDbType.VarChar, 10, "单据状态"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@入住人数", System.Data.SqlDbType.Int, 4, "入住人数"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@客房价格", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "客房价格", System.Data.DataRowVersion.Current, null));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@入住价格", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "入住价格", System.Data.DataRowVersion.Current, null));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@折扣", System.Data.SqlDbType.Float, 8, "折扣"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@折扣原因", System.Data.SqlDbType.VarChar, 40, "折扣原因"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@是否加床", System.Data.SqlDbType.Bit, 1, "是否加床"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@加床价格", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "加床价格", System.Data.DataRowVersion.Current, null));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@预收款", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "预收款", System.Data.DataRowVersion.Current, null));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@预订人", System.Data.SqlDbType.VarChar, 10, "预订人"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@身份证", System.Data.SqlDbType.VarChar, 20, "身份证"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@预订公司", System.Data.SqlDbType.VarChar, 40, "预订公司"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@联系电话", System.Data.SqlDbType.VarChar, 13, "联系电话"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@备注", System.Data.SqlDbType.VarChar, 40, "备注"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@操作员", System.Data.SqlDbType.VarChar, 10, "操作员"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@业务员", System.Data.SqlDbType.VarChar, 10, "业务员"));
			// 
			// sqlSelectCommand1
			// 
			this.sqlSelectCommand1.CommandText = "SELECT 预订单号, 会员编号, 客房编号, 客房类型, 客房位置, 抵店时间, 离店时间, 单据状态, 入住人数, 客房价格, 入住价格, 折扣, 折扣原因" +
				", 是否加床, 加床价格, 预收款, 预订人, 身份证, 预订公司, 联系电话, 备注, 操作员, 业务员 FROM 预订单历史";
			this.sqlSelectCommand1.Connection = this.conn;
			// 
			// sqlUpdateCommand1
			// 
			this.sqlUpdateCommand1.CommandText = "UPDATE 预订单历史 SET 预订单号 = @预订单号, 会员编号 = @会员编号, 客房编号 = @客房编号, 客房类型 = @客房类型, 客房位置 = @" +
				"客房位置, 抵店时间 = @抵店时间, 离店时间 = @离店时间, 单据状态 = @单据状态, 入住人数 = @入住人数, 客房价格 = @客房价格, 入住价格" +
				" = @入住价格, 折扣 = @折扣, 折扣原因 = @折扣原因, 是否加床 = @是否加床, 加床价格 = @加床价格, 预收款 = @预收款, 预订人 = " +
				"@预订人, 身份证 = @身份证, 预订公司 = @预订公司, 联系电话 = @联系电话, 备注 = @备注, 操作员 = @操作员, 业务员 = @业务员 W" +
				"HERE (预订单号 = @Original_预订单号) AND (业务员 = @Original_业务员 OR @Original_业务员 IS NULL A" +
				"ND 业务员 IS NULL) AND (会员编号 = @Original_会员编号 OR @Original_会员编号 IS NULL AND 会员编号 IS" +
				" NULL) AND (入住人数 = @Original_入住人数 OR @Original_入住人数 IS NULL AND 入住人数 IS NULL) AN" +
				"D (入住价格 = @Original_入住价格 OR @Original_入住价格 IS NULL AND 入住价格 IS NULL) AND (加床价格 =" +
				" @Original_加床价格 OR @Original_加床价格 IS NULL AND 加床价格 IS NULL) AND (单据状态 = @Origina" +
				"l_单据状态 OR @Original_单据状态 IS NULL AND 单据状态 IS NULL) AND (备注 = @Original_备注 OR @Or" +
				"iginal_备注 IS NULL AND 备注 IS NULL) AND (客房价格 = @Original_客房价格 OR @Original_客房价格 I" +
				"S NULL AND 客房价格 IS NULL) AND (客房位置 = @Original_客房位置 OR @Original_客房位置 IS NULL AN" +
				"D 客房位置 IS NULL) AND (客房类型 = @Original_客房类型 OR @Original_客房类型 IS NULL AND 客房类型 IS" +
				" NULL) AND (客房编号 = @Original_客房编号) AND (折扣 = @Original_折扣 OR @Original_折扣 IS NUL" +
				"L AND 折扣 IS NULL) AND (折扣原因 = @Original_折扣原因 OR @Original_折扣原因 IS NULL AND 折扣原因 " +
				"IS NULL) AND (抵店时间 = @Original_抵店时间 OR @Original_抵店时间 IS NULL AND 抵店时间 IS NULL) " +
				"AND (操作员 = @Original_操作员 OR @Original_操作员 IS NULL AND 操作员 IS NULL) AND (是否加床 = @" +
				"Original_是否加床 OR @Original_是否加床 IS NULL AND 是否加床 IS NULL) AND (离店时间 = @Original_" +
				"离店时间 OR @Original_离店时间 IS NULL AND 离店时间 IS NULL) AND (联系电话 = @Original_联系电话 OR @" +
				"Original_联系电话 IS NULL AND 联系电话 IS NULL) AND (身份证 = @Original_身份证 OR @Original_身份" +
				"证 IS NULL AND 身份证 IS NULL) AND (预收款 = @Original_预收款 OR @Original_预收款 IS NULL AND" +
				" 预收款 IS NULL) AND (预订人 = @Original_预订人 OR @Original_预订人 IS NULL AND 预订人 IS NULL)" +
				" AND (预订公司 = @Original_预订公司 OR @Original_预订公司 IS NULL AND 预订公司 IS NULL); SELECT " +
				"预订单号, 会员编号, 客房编号, 客房类型, 客房位置, 抵店时间, 离店时间, 单据状态, 入住人数, 客房价格, 入住价格, 折扣, 折扣原因, 是否加床" +
				", 加床价格, 预收款, 预订人, 身份证, 预订公司, 联系电话, 备注, 操作员, 业务员 FROM 预订单历史 WHERE (预订单号 = @预订单号)";
			this.sqlUpdateCommand1.Connection = this.conn;
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@预订单号", System.Data.SqlDbType.VarChar, 10, "预订单号"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@会员编号", System.Data.SqlDbType.VarChar, 10, "会员编号"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@客房编号", System.Data.SqlDbType.VarChar, 10, "客房编号"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@客房类型", System.Data.SqlDbType.VarChar, 20, "客房类型"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@客房位置", System.Data.SqlDbType.VarChar, 10, "客房位置"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@抵店时间", System.Data.SqlDbType.DateTime, 4, "抵店时间"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@离店时间", System.Data.SqlDbType.DateTime, 4, "离店时间"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@单据状态", System.Data.SqlDbType.VarChar, 10, "单据状态"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@入住人数", System.Data.SqlDbType.Int, 4, "入住人数"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@客房价格", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "客房价格", System.Data.DataRowVersion.Current, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@入住价格", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "入住价格", System.Data.DataRowVersion.Current, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@折扣", System.Data.SqlDbType.Float, 8, "折扣"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@折扣原因", System.Data.SqlDbType.VarChar, 40, "折扣原因"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@是否加床", System.Data.SqlDbType.Bit, 1, "是否加床"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@加床价格", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "加床价格", System.Data.DataRowVersion.Current, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@预收款", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "预收款", System.Data.DataRowVersion.Current, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@预订人", System.Data.SqlDbType.VarChar, 10, "预订人"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@身份证", System.Data.SqlDbType.VarChar, 20, "身份证"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@预订公司", System.Data.SqlDbType.VarChar, 40, "预订公司"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@联系电话", System.Data.SqlDbType.VarChar, 13, "联系电话"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@备注", System.Data.SqlDbType.VarChar, 40, "备注"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@操作员", System.Data.SqlDbType.VarChar, 10, "操作员"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@业务员", System.Data.SqlDbType.VarChar, 10, "业务员"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_预订单号", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "预订单号", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_业务员", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "业务员", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_会员编号", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "会员编号", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_入住人数", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "入住人数", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_入住价格", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "入住价格", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_加床价格", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "加床价格", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_单据状态", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "单据状态", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_备注", System.Data.SqlDbType.VarChar, 40, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "备注", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_客房价格", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "客房价格", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_客房位置", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "客房位置", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_客房类型", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "客房类型", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_客房编号", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "客房编号", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_折扣", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "折扣", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_折扣原因", System.Data.SqlDbType.VarChar, 40, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "折扣原因", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_抵店时间", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "抵店时间", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_操作员", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "操作员", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_是否加床", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "是否加床", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_离店时间", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "离店时间", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_联系电话", System.Data.SqlDbType.VarChar, 13, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "联系电话", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_身份证", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "身份证", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_预收款", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "预收款", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_预订人", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "预订人", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_预订公司", System.Data.SqlDbType.VarChar, 40, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "预订公司", System.Data.DataRowVersion.Original, null));
			// 
			// OrderHistoryManagement
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(744, 494);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.label24);
			this.Controls.Add(this.label23);
			this.Controls.Add(this.dataGrid1);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnEnd);
			this.Controls.Add(this.btnNext);
			this.Controls.Add(this.btnBack);
			this.Controls.Add(this.btnFirst);
			this.Controls.Add(this.btnAll);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(752, 528);
			this.MinimumSize = new System.Drawing.Size(752, 528);
			this.Name = "OrderHistoryManagement";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "预订单历史查询";
			this.Load += new System.EventHandler(this.OrderHistoryManagement_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void btnAll_Click(object sender, System.EventArgs e)
		{
			this.sqlSelectCommand1.CommandText = "Select * from 预订单历史";
			ds.Clear();
			da.Fill(this.ds,"预订单历史");
			bmb = this.BindingContext[ds,"预订单历史"];
			this.label23.Text = "当前记录："+(this.dataGrid1.CurrentRowIndex+1);
			this.label24.Text = "记录数："+this.bmb.Count;
		}

		private void btnFirst_Click(object sender, System.EventArgs e)
		{
			try
			{
				bmb.Position =0;
				this.label23.Text = "当前记录："+(this.dataGrid1.CurrentRowIndex+1);
			}
			catch
			{
			}
		}

		private void btnBack_Click(object sender, System.EventArgs e)
		{
			try
			{
				if(bmb.Position!=0)
					bmb.Position-=1;
				this.label23.Text = "当前记录："+(this.dataGrid1.CurrentRowIndex+1);
			}
			catch
			{
			}
		}

		private void btnNext_Click(object sender, System.EventArgs e)
		{
			try
			{
				if(bmb.Position!=bmb.Count)
					bmb.Position+=1;
				this.label23.Text = "当前记录："+(this.dataGrid1.CurrentRowIndex+1);
			}
			catch
			{
			}
		}

		private void btnEnd_Click(object sender, System.EventArgs e)
		{
			try
			{
				bmb.Position = bmb.Count;
				this.label23.Text = "当前记录："+(this.dataGrid1.CurrentRowIndex+1);
			}
			catch
			{
			}
		}

		private void btnCancel_Click(object sender, System.EventArgs e)
		{
		    this.Close();
		}

		private void radioButton1_CheckedChanged(object sender, System.EventArgs e)
		{
			this.textBox1.Enabled = true;
			this.textBox2.Enabled = false;
			this.textBox2.Text = "";
		}

		private void radioButton2_CheckedChanged(object sender, System.EventArgs e)
		{
			this.textBox1.Enabled = false;
			this.textBox2.Enabled = true;
			this.textBox1.Text = "";
		}

		private void btnFind_Click(object sender, System.EventArgs e)
		{
			string str = "";
			try
			{
				if(this.textBox1.Enabled == true && this.textBox1.Text.Trim() != "")
				{
					str = "Select * from 预订单历史 where 预订单号 like '%"+this.textBox1.Text.Trim()+"%'";
					this.sqlSelectCommand1.CommandText = str;
					this.ds.Clear();
					da.Fill(this.ds,"预订单历史");
					bmb=this.BindingContext[ds,"预订单历史"];
					this.label23.Text = "当前记录："+(this.dataGrid1.CurrentRowIndex+1);
					this.label24.Text = "记录数："+this.bmb.Count;
		
				}
				if(this.textBox2.Enabled == true && this.textBox2.Text.Trim() != "")
				{
					str = "Select * from 预订单历史 where 客房编号 like '%"+this.textBox2.Text.Trim()+"%'";
					this.sqlSelectCommand1.CommandText = str;
					this.ds.Clear();
					da.Fill(this.ds,"预订单历史");
					bmb=this.BindingContext[ds,"预订单历史"];
					this.label23.Text = "当前记录："+(this.dataGrid1.CurrentRowIndex+1);
					this.label24.Text = "记录数："+this.bmb.Count;
				}
				if(str == "")
				{
					MessageBox.Show("请输入查找条件");;
				}
			}
			catch
			{
				MessageBox.Show("输入有误");
			}
		}

		private void OrderHistoryManagement_Load(object sender, System.EventArgs e)
		{
			this.conn.ConnectionString = Config.Settings.ConnStr;
		}
	}
}
