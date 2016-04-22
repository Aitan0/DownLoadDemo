using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data.SqlClient;
using HotelManagementSystem.Data;
using HotelManagementSystem.Config;
//客房标准修改
namespace HotelManagementSystem.RoomStandardManagement
{
	/// <summary>
	/// ChangeRoomStandardManagement 的摘要说明。
	/// </summary>
	public class ChangeRoomStandardManagement : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button btnFind;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnEnd;
		private System.Windows.Forms.Button btnNext;
		private System.Windows.Forms.Button btnBack;
		private System.Windows.Forms.Button btnFirst;
		private System.Windows.Forms.Button btnAll;
		private System.Windows.Forms.DataGrid dataGrid1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.CheckBox checkBox4;
		private System.Windows.Forms.CheckBox checkBox3;
		private System.Windows.Forms.CheckBox checkBox2;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.TextBox txtPrice;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtNum;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtArea;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtname;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtID;
		private System.Windows.Forms.Label label1;
		private HotelManagementSystem.Data.HotelDataSet ds;
		private System.Data.SqlClient.SqlConnection conn;
		private System.Data.SqlClient.SqlDataAdapter da;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
		private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
		private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.CheckBox checkBox5;
		protected BindingManagerBase bmb;

		public ChangeRoomStandardManagement()
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
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.btnFind = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnEnd = new System.Windows.Forms.Button();
			this.btnNext = new System.Windows.Forms.Button();
			this.btnBack = new System.Windows.Forms.Button();
			this.btnFirst = new System.Windows.Forms.Button();
			this.btnAll = new System.Windows.Forms.Button();
			this.dataGrid1 = new System.Windows.Forms.DataGrid();
			this.ds = new HotelManagementSystem.Data.HotelDataSet();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.checkBox4 = new System.Windows.Forms.CheckBox();
			this.checkBox3 = new System.Windows.Forms.CheckBox();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.txtPrice = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtNum = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtArea = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtname = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtID = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.conn = new System.Data.SqlClient.SqlConnection();
			this.da = new System.Data.SqlClient.SqlDataAdapter();
			this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.checkBox5 = new System.Windows.Forms.CheckBox();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.textBox2);
			this.groupBox2.Controls.Add(this.radioButton2);
			this.groupBox2.Controls.Add(this.radioButton1);
			this.groupBox2.Controls.Add(this.textBox1);
			this.groupBox2.Controls.Add(this.btnFind);
			this.groupBox2.Location = new System.Drawing.Point(57, 400);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(576, 64);
			this.groupBox2.TabIndex = 37;
			this.groupBox2.TabStop = false;
			// 
			// textBox2
			// 
			this.textBox2.Enabled = false;
			this.textBox2.Location = new System.Drawing.Point(328, 24);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(120, 21);
			this.textBox2.TabIndex = 11;
			this.textBox2.Text = "";
			// 
			// radioButton2
			// 
			this.radioButton2.Location = new System.Drawing.Point(255, 24);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(73, 24);
			this.radioButton2.TabIndex = 10;
			this.radioButton2.Text = "客房类型";
			this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
			// 
			// radioButton1
			// 
			this.radioButton1.Location = new System.Drawing.Point(24, 24);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(73, 24);
			this.radioButton1.TabIndex = 9;
			this.radioButton1.Text = "类型编号";
			this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
			// 
			// textBox1
			// 
			this.textBox1.Enabled = false;
			this.textBox1.Location = new System.Drawing.Point(112, 24);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(120, 21);
			this.textBox1.TabIndex = 8;
			this.textBox1.Text = "";
			// 
			// btnFind
			// 
			this.btnFind.Location = new System.Drawing.Point(480, 24);
			this.btnFind.Name = "btnFind";
			this.btnFind.TabIndex = 7;
			this.btnFind.Text = "查询";
			this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(490, 32);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.TabIndex = 36;
			this.btnCancel.Text = "退出";
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnEnd
			// 
			this.btnEnd.Location = new System.Drawing.Point(415, 32);
			this.btnEnd.Name = "btnEnd";
			this.btnEnd.TabIndex = 35;
			this.btnEnd.Text = "最后";
			this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
			// 
			// btnNext
			// 
			this.btnNext.Location = new System.Drawing.Point(340, 32);
			this.btnNext.Name = "btnNext";
			this.btnNext.TabIndex = 34;
			this.btnNext.Text = "下一个";
			this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
			// 
			// btnBack
			// 
			this.btnBack.Location = new System.Drawing.Point(265, 32);
			this.btnBack.Name = "btnBack";
			this.btnBack.TabIndex = 33;
			this.btnBack.Text = "上一个";
			this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
			// 
			// btnFirst
			// 
			this.btnFirst.Location = new System.Drawing.Point(190, 32);
			this.btnFirst.Name = "btnFirst";
			this.btnFirst.TabIndex = 32;
			this.btnFirst.Text = "最前";
			this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
			// 
			// btnAll
			// 
			this.btnAll.Location = new System.Drawing.Point(115, 32);
			this.btnAll.Name = "btnAll";
			this.btnAll.TabIndex = 31;
			this.btnAll.Text = "查询所有";
			this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
			// 
			// dataGrid1
			// 
			this.dataGrid1.DataMember = "客房标准信息";
			this.dataGrid1.DataSource = this.ds;
			this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGrid1.Location = new System.Drawing.Point(57, 72);
			this.dataGrid1.Name = "dataGrid1";
			this.dataGrid1.ReadOnly = true;
			this.dataGrid1.Size = new System.Drawing.Size(576, 150);
			this.dataGrid1.TabIndex = 30;
			// 
			// ds
			// 
			this.ds.DataSetName = "HotelDataSet";
			this.ds.Locale = new System.Globalization.CultureInfo("en-US");
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.checkBox4);
			this.groupBox1.Controls.Add(this.checkBox3);
			this.groupBox1.Controls.Add(this.checkBox2);
			this.groupBox1.Controls.Add(this.checkBox1);
			this.groupBox1.Controls.Add(this.txtPrice);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.txtNum);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.txtArea);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.txtname);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.txtID);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Enabled = false;
			this.groupBox1.Location = new System.Drawing.Point(57, 256);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(576, 144);
			this.groupBox1.TabIndex = 29;
			this.groupBox1.TabStop = false;
			// 
			// checkBox4
			// 
			this.checkBox4.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.ds, "客房标准信息.单独卫生间"));
			this.checkBox4.Location = new System.Drawing.Point(456, 112);
			this.checkBox4.Name = "checkBox4";
			this.checkBox4.TabIndex = 35;
			this.checkBox4.Text = "单独卫生间";
			// 
			// checkBox3
			// 
			this.checkBox3.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.ds, "客房标准信息.电话"));
			this.checkBox3.Location = new System.Drawing.Point(304, 112);
			this.checkBox3.Name = "checkBox3";
			this.checkBox3.TabIndex = 34;
			this.checkBox3.Text = "电话";
			// 
			// checkBox2
			// 
			this.checkBox2.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.ds, "客房标准信息.电视机"));
			this.checkBox2.Location = new System.Drawing.Point(456, 88);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.TabIndex = 33;
			this.checkBox2.Text = "电视机";
			// 
			// checkBox1
			// 
			this.checkBox1.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.ds, "客房标准信息.空调"));
			this.checkBox1.Location = new System.Drawing.Point(304, 88);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.TabIndex = 32;
			this.checkBox1.Text = "空调";
			// 
			// txtPrice
			// 
			this.txtPrice.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ds, "客房标准信息.客房价格"));
			this.txtPrice.Location = new System.Drawing.Point(400, 62);
			this.txtPrice.Name = "txtPrice";
			this.txtPrice.Size = new System.Drawing.Size(152, 21);
			this.txtPrice.TabIndex = 31;
			this.txtPrice.Text = "";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(288, 62);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(104, 23);
			this.label5.TabIndex = 30;
			this.label5.Text = "客房价格";
			// 
			// txtNum
			// 
			this.txtNum.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ds, "客房标准信息.床位数量"));
			this.txtNum.Location = new System.Drawing.Point(400, 23);
			this.txtNum.Name = "txtNum";
			this.txtNum.Size = new System.Drawing.Size(152, 21);
			this.txtNum.TabIndex = 29;
			this.txtNum.Text = "";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(288, 25);
			this.label4.Name = "label4";
			this.label4.TabIndex = 28;
			this.label4.Text = "床位数量";
			// 
			// txtArea
			// 
			this.txtArea.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ds, "客房标准信息.客房类型"));
			this.txtArea.Location = new System.Drawing.Point(120, 64);
			this.txtArea.Name = "txtArea";
			this.txtArea.Size = new System.Drawing.Size(152, 21);
			this.txtArea.TabIndex = 27;
			this.txtArea.Text = "";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(8, 106);
			this.label3.Name = "label3";
			this.label3.TabIndex = 26;
			this.label3.Text = "房间面积";
			// 
			// txtname
			// 
			this.txtname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ds, "客房标准信息.房间面积"));
			this.txtname.Location = new System.Drawing.Point(120, 104);
			this.txtname.Name = "txtname";
			this.txtname.Size = new System.Drawing.Size(152, 21);
			this.txtname.TabIndex = 25;
			this.txtname.Text = "";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(8, 66);
			this.label2.Name = "label2";
			this.label2.TabIndex = 24;
			this.label2.Text = "客房类型";
			// 
			// txtID
			// 
			this.txtID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ds, "客房标准信息.类型编号"));
			this.txtID.Location = new System.Drawing.Point(120, 24);
			this.txtID.Name = "txtID";
			this.txtID.Size = new System.Drawing.Size(152, 21);
			this.txtID.TabIndex = 23;
			this.txtID.Text = "";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 24);
			this.label1.TabIndex = 22;
			this.label1.Text = "类型编号";
			// 
			// conn
			// 
			this.conn.ConnectionString = Config.Settings.ConnStr;
			// 
			// da
			// 
			this.da.DeleteCommand = this.sqlDeleteCommand1;
			this.da.InsertCommand = this.sqlInsertCommand1;
			this.da.SelectCommand = this.sqlSelectCommand1;
			this.da.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																						 new System.Data.Common.DataTableMapping("Table", "客房标准信息", new System.Data.Common.DataColumnMapping[] {
																																																   new System.Data.Common.DataColumnMapping("类型编号", "类型编号"),
																																																   new System.Data.Common.DataColumnMapping("客房类型", "客房类型"),
																																																   new System.Data.Common.DataColumnMapping("房间面积", "房间面积"),
																																																   new System.Data.Common.DataColumnMapping("床位数量", "床位数量"),
																																																   new System.Data.Common.DataColumnMapping("客房价格", "客房价格"),
																																																   new System.Data.Common.DataColumnMapping("空调", "空调"),
																																																   new System.Data.Common.DataColumnMapping("电视机", "电视机"),
																																																   new System.Data.Common.DataColumnMapping("电话", "电话"),
																																																   new System.Data.Common.DataColumnMapping("单独卫生间", "单独卫生间")})});
			this.da.UpdateCommand = this.sqlUpdateCommand1;
			// 
			// sqlDeleteCommand1
			// 
			this.sqlDeleteCommand1.CommandText = @"DELETE FROM 客房标准信息 WHERE (类型编号 = @Original_类型编号) AND (单独卫生间 = @Original_单独卫生间 OR @Original_单独卫生间 IS NULL AND 单独卫生间 IS NULL) AND (客房价格 = @Original_客房价格 OR @Original_客房价格 IS NULL AND 客房价格 IS NULL) AND (客房类型 = @Original_客房类型 OR @Original_客房类型 IS NULL AND 客房类型 IS NULL) AND (床位数量 = @Original_床位数量 OR @Original_床位数量 IS NULL AND 床位数量 IS NULL) AND (房间面积 = @Original_房间面积 OR @Original_房间面积 IS NULL AND 房间面积 IS NULL) AND (电视机 = @Original_电视机 OR @Original_电视机 IS NULL AND 电视机 IS NULL) AND (电话 = @Original_电话 OR @Original_电话 IS NULL AND 电话 IS NULL) AND (空调 = @Original_空调 OR @Original_空调 IS NULL AND 空调 IS NULL)";
			this.sqlDeleteCommand1.Connection = this.conn;
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_类型编号", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "类型编号", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_单独卫生间", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "单独卫生间", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_客房价格", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "客房价格", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_客房类型", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "客房类型", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_床位数量", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "床位数量", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_房间面积", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "房间面积", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_电视机", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "电视机", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_电话", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "电话", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_空调", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "空调", System.Data.DataRowVersion.Original, null));
			// 
			// sqlInsertCommand1
			// 
			this.sqlInsertCommand1.CommandText = "INSERT INTO 客房标准信息(类型编号, 客房类型, 房间面积, 床位数量, 客房价格, 空调, 电视机, 电话, 单独卫生间) VALUES (@类型编" +
				"号, @客房类型, @房间面积, @床位数量, @客房价格, @空调, @电视机, @电话, @单独卫生间); SELECT 类型编号, 客房类型, 房间面积," +
				" 床位数量, 客房价格, 空调, 电视机, 电话, 单独卫生间 FROM 客房标准信息 WHERE (类型编号 = @类型编号)";
			this.sqlInsertCommand1.Connection = this.conn;
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@类型编号", System.Data.SqlDbType.VarChar, 10, "类型编号"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@客房类型", System.Data.SqlDbType.VarChar, 10, "客房类型"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@房间面积", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "房间面积", System.Data.DataRowVersion.Current, null));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@床位数量", System.Data.SqlDbType.Int, 4, "床位数量"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@客房价格", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "客房价格", System.Data.DataRowVersion.Current, null));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@空调", System.Data.SqlDbType.Bit, 1, "空调"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@电视机", System.Data.SqlDbType.Bit, 1, "电视机"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@电话", System.Data.SqlDbType.Bit, 1, "电话"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@单独卫生间", System.Data.SqlDbType.Bit, 1, "单独卫生间"));
			// 
			// sqlSelectCommand1
			// 
			this.sqlSelectCommand1.CommandText = "SELECT 类型编号, 客房类型, 房间面积, 床位数量, 客房价格, 空调, 电视机, 电话, 单独卫生间 FROM 客房标准信息";
			this.sqlSelectCommand1.Connection = this.conn;
			// 
			// sqlUpdateCommand1
			// 
			this.sqlUpdateCommand1.CommandText = @"UPDATE 客房标准信息 SET 类型编号 = @类型编号, 客房类型 = @客房类型, 房间面积 = @房间面积, 床位数量 = @床位数量, 客房价格 = @客房价格, 空调 = @空调, 电视机 = @电视机, 电话 = @电话, 单独卫生间 = @单独卫生间 WHERE (类型编号 = @Original_类型编号) AND (单独卫生间 = @Original_单独卫生间 OR @Original_单独卫生间 IS NULL AND 单独卫生间 IS NULL) AND (客房价格 = @Original_客房价格 OR @Original_客房价格 IS NULL AND 客房价格 IS NULL) AND (客房类型 = @Original_客房类型 OR @Original_客房类型 IS NULL AND 客房类型 IS NULL) AND (床位数量 = @Original_床位数量 OR @Original_床位数量 IS NULL AND 床位数量 IS NULL) AND (房间面积 = @Original_房间面积 OR @Original_房间面积 IS NULL AND 房间面积 IS NULL) AND (电视机 = @Original_电视机 OR @Original_电视机 IS NULL AND 电视机 IS NULL) AND (电话 = @Original_电话 OR @Original_电话 IS NULL AND 电话 IS NULL) AND (空调 = @Original_空调 OR @Original_空调 IS NULL AND 空调 IS NULL); SELECT 类型编号, 客房类型, 房间面积, 床位数量, 客房价格, 空调, 电视机, 电话, 单独卫生间 FROM 客房标准信息 WHERE (类型编号 = @类型编号)";
			this.sqlUpdateCommand1.Connection = this.conn;
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@类型编号", System.Data.SqlDbType.VarChar, 10, "类型编号"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@客房类型", System.Data.SqlDbType.VarChar, 10, "客房类型"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@房间面积", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "房间面积", System.Data.DataRowVersion.Current, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@床位数量", System.Data.SqlDbType.Int, 4, "床位数量"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@客房价格", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "客房价格", System.Data.DataRowVersion.Current, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@空调", System.Data.SqlDbType.Bit, 1, "空调"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@电视机", System.Data.SqlDbType.Bit, 1, "电视机"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@电话", System.Data.SqlDbType.Bit, 1, "电话"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@单独卫生间", System.Data.SqlDbType.Bit, 1, "单独卫生间"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_类型编号", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "类型编号", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_单独卫生间", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "单独卫生间", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_客房价格", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "客房价格", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_客房类型", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "客房类型", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_床位数量", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "床位数量", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_房间面积", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "房间面积", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_电视机", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "电视机", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_电话", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "电话", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_空调", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "空调", System.Data.DataRowVersion.Original, null));
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(544, 232);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.TabIndex = 38;
			this.btnDelete.Text = "删除";
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnSave
			// 
			this.btnSave.Enabled = false;
			this.btnSave.Location = new System.Drawing.Point(120, 232);
			this.btnSave.Name = "btnSave";
			this.btnSave.TabIndex = 39;
			this.btnSave.Text = "保存";
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(8, 48);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(104, 23);
			this.label6.TabIndex = 42;
			this.label6.Text = "当前记录：";
			this.label6.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(568, 47);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(104, 23);
			this.label7.TabIndex = 43;
			this.label7.Text = "记录数：";
			this.label7.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// checkBox5
			// 
			this.checkBox5.Location = new System.Drawing.Point(56, 232);
			this.checkBox5.Name = "checkBox5";
			this.checkBox5.Size = new System.Drawing.Size(56, 24);
			this.checkBox5.TabIndex = 44;
			this.checkBox5.Text = "修改";
			this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
			// 
			// ChangeRoomStandardManagement
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(692, 486);
			this.Controls.Add(this.checkBox5);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnEnd);
			this.Controls.Add(this.btnNext);
			this.Controls.Add(this.btnBack);
			this.Controls.Add(this.btnFirst);
			this.Controls.Add(this.btnAll);
			this.Controls.Add(this.dataGrid1);
			this.Controls.Add(this.groupBox1);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(700, 520);
			this.MinimumSize = new System.Drawing.Size(700, 520);
			this.Name = "ChangeRoomStandardManagement";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "客房标准修改";
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void btnAll_Click(object sender, System.EventArgs e)
		{
			this.sqlSelectCommand1.CommandText = "Select * from 客房标准信息";
			this.ds.Clear();
		    da.Fill(ds,"客房标准信息");
			bmb = this.BindingContext[ds,"客房标准信息"];
			this.label6.Text = "当前记录："+(this.dataGrid1.CurrentRowIndex+1);
			this.label7.Text = "记录数："+this.bmb.Count;
		}

		private void btnFirst_Click(object sender, System.EventArgs e)
		{
			try
			{
				bmb.Position = 0;
				this.label6.Text = "当前记录："+(this.dataGrid1.CurrentRowIndex+1);
			}
			catch
			{
			}
		}

		private void btnBack_Click(object sender, System.EventArgs e)
		{
			try
			{
				if(bmb.Position != 0)
					bmb.Position -= 1;
				this.label6.Text = "当前记录："+(this.dataGrid1.CurrentRowIndex+1);
			}
			catch
			{
			}

		}

		private void btnNext_Click(object sender, System.EventArgs e)
		{
			try
			{
				if(bmb.Position != bmb.Count)
					bmb.Position +=1 ;
				this.label6.Text = "当前记录："+(this.dataGrid1.CurrentRowIndex+1);
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
				this.label6.Text = "当前记录："+(this.dataGrid1.CurrentRowIndex+1);
			}
			catch
			{
			}
		}

		private void btnCancel_Click(object sender, System.EventArgs e)
		{
		    this.Close();
		}

		private void btnSave_Click(object sender, System.EventArgs e)
		{
			try
			{
				bmb.EndCurrentEdit();
				da.Update(ds,"客房标准信息");
				ds.Clear();
				da.Fill(ds,"客房标准信息");
				bmb = this.BindingContext[ds,"客房标准信息"];
				this.label6.Text = "当前记录："+(this.dataGrid1.CurrentRowIndex+1);
				this.label7.Text = "记录数："+this.bmb.Count;
				MessageBox.Show("记录修改成功");
			}
			catch(Exception ex)
			{
				MessageBox.Show("修改失败:"+ex.Message.ToString());
			}

		}

		private void btnDelete_Click(object sender, System.EventArgs e)
		{
			try
			{
				if(DialogResult.OK == MessageBox.Show("确定删除记录?","确定",MessageBoxButtons.OKCancel,MessageBoxIcon.Question))
				{
					this.ds.客房标准信息.Rows[this.bmb.Position].Delete();
					da.Update(ds,"客房标准信息");
					ds.Clear();
					da.Fill(ds,"客房标准信息");
					bmb = this.BindingContext[ds,"客房标准信息"];
					this.label6.Text = "当前记录："+(this.dataGrid1.CurrentRowIndex+1);
					this.label7.Text = "记录数："+this.bmb.Count;
					MessageBox.Show("记录删除成功");
				}
				else
				{

				}
			}
			catch(Exception ex)
			{
				MessageBox.Show("删除无效:"+ex.Message.ToString());
			}
		}

		private void checkBox5_CheckedChanged(object sender, System.EventArgs e)
		{
			if(this.checkBox5.Checked ==true)
			{
				this.groupBox1.Enabled = true;
				this.btnSave.Enabled = true;
			}
			else
			{
				this.groupBox1.Enabled = false;
				this.btnSave.Enabled = false;
				this.ds.RejectChanges();
			}
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
					str = "Select * from 客房标准信息 where 类型编号  like '%"+this.textBox1.Text.Trim()+"%'";
					this.sqlSelectCommand1.CommandText = str;
					this.ds.Clear();
					da.Fill(this.ds,"客房标准信息");
					bmb=this.BindingContext[ds,"客房标准信息"];
					this.label6.Text = "当前记录："+(this.dataGrid1.CurrentRowIndex+1);
					this.label7.Text = "记录数："+this.bmb.Count;
				}
				if(this.textBox2.Enabled == true && this.textBox2.Text.Trim() != "")
				{
					str = "Select * from 客房标准信息 where 客房类型 like '%"+this.textBox2.Text.Trim()+"%'";
					this.sqlSelectCommand1.CommandText = str;
					this.ds.Clear();
					da.Fill(this.ds,"客房标准信息");
					bmb=this.BindingContext[ds,"客房标准信息"];
					this.label6.Text = "当前记录："+(this.dataGrid1.CurrentRowIndex+1);
					this.label7.Text = "记录数："+this.bmb.Count;
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
	}
}
