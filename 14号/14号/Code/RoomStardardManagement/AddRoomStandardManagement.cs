using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data.SqlClient;
using HotelManagementSystem.Data;
using HotelManagementSystem.Config;
//客房标准添加
namespace HotelManagementSystem.RoomStandardManagement
{
	/// <summary>
	/// AddRoomStandardManagement 的摘要说明。
	/// </summary>
	public class AddRoomStandardManagement : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.CheckBox checkBox4;
		private System.Windows.Forms.CheckBox checkBox3;
		private System.Windows.Forms.CheckBox checkBox2;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.GroupBox groupBox1;
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
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnSave;
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
		

		public AddRoomStandardManagement()
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
			this.checkBox4 = new System.Windows.Forms.CheckBox();
			this.checkBox3 = new System.Windows.Forms.CheckBox();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
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
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.ds = new HotelManagementSystem.Data.HotelDataSet();
			this.conn = new System.Data.SqlClient.SqlConnection();
			this.da = new System.Data.SqlClient.SqlDataAdapter();
			this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.checkBox4);
			this.groupBox2.Controls.Add(this.checkBox3);
			this.groupBox2.Controls.Add(this.checkBox2);
			this.groupBox2.Controls.Add(this.checkBox1);
			this.groupBox2.Location = new System.Drawing.Point(56, 264);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(332, 96);
			this.groupBox2.TabIndex = 21;
			this.groupBox2.TabStop = false;
			// 
			// checkBox4
			// 
			this.checkBox4.Location = new System.Drawing.Point(216, 64);
			this.checkBox4.Name = "checkBox4";
			this.checkBox4.TabIndex = 19;
			this.checkBox4.Text = "单独卫生间";
			// 
			// checkBox3
			// 
			this.checkBox3.Location = new System.Drawing.Point(40, 64);
			this.checkBox3.Name = "checkBox3";
			this.checkBox3.TabIndex = 18;
			this.checkBox3.Text = "电话";
			// 
			// checkBox2
			// 
			this.checkBox2.Location = new System.Drawing.Point(216, 15);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.TabIndex = 17;
			this.checkBox2.Text = "电视机";
			// 
			// checkBox1
			// 
			this.checkBox1.Location = new System.Drawing.Point(40, 15);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.TabIndex = 16;
			this.checkBox1.Text = "空调";
			// 
			// groupBox1
			// 
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
			this.groupBox1.Location = new System.Drawing.Point(56, 16);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(332, 240);
			this.groupBox1.TabIndex = 20;
			this.groupBox1.TabStop = false;
			// 
			// txtPrice
			// 
			this.txtPrice.Location = new System.Drawing.Point(136, 199);
			this.txtPrice.Name = "txtPrice";
			this.txtPrice.Size = new System.Drawing.Size(168, 21);
			this.txtPrice.TabIndex = 21;
			this.txtPrice.Text = "";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(24, 201);
			this.label5.Name = "label5";
			this.label5.TabIndex = 20;
			this.label5.Text = "客房价格";
			// 
			// txtNum
			// 
			this.txtNum.Location = new System.Drawing.Point(136, 153);
			this.txtNum.Name = "txtNum";
			this.txtNum.Size = new System.Drawing.Size(168, 21);
			this.txtNum.TabIndex = 19;
			this.txtNum.Text = "";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(24, 157);
			this.label4.Name = "label4";
			this.label4.TabIndex = 18;
			this.label4.Text = "床位数量";
			// 
			// txtArea
			// 
			this.txtArea.Location = new System.Drawing.Point(136, 113);
			this.txtArea.Name = "txtArea";
			this.txtArea.Size = new System.Drawing.Size(168, 21);
			this.txtArea.TabIndex = 17;
			this.txtArea.Text = "";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(24, 113);
			this.label3.Name = "label3";
			this.label3.TabIndex = 16;
			this.label3.Text = "房间面积";
			// 
			// txtname
			// 
			this.txtname.Location = new System.Drawing.Point(136, 73);
			this.txtname.Name = "txtname";
			this.txtname.Size = new System.Drawing.Size(168, 21);
			this.txtname.TabIndex = 15;
			this.txtname.Text = "";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(24, 69);
			this.label2.Name = "label2";
			this.label2.TabIndex = 14;
			this.label2.Text = "客房类型";
			// 
			// txtID
			// 
			this.txtID.Location = new System.Drawing.Point(136, 25);
			this.txtID.Name = "txtID";
			this.txtID.Size = new System.Drawing.Size(168, 21);
			this.txtID.TabIndex = 13;
			this.txtID.Text = "";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(24, 25);
			this.label1.Name = "label1";
			this.label1.TabIndex = 12;
			this.label1.Text = "类型编号";
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(296, 384);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.TabIndex = 19;
			this.btnCancel.Text = "取消";
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(72, 384);
			this.btnSave.Name = "btnSave";
			this.btnSave.TabIndex = 18;
			this.btnSave.Text = "保存";
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// ds
			// 
			this.ds.DataSetName = "HotelDataSet";
			this.ds.Locale = new System.Globalization.CultureInfo("en-US");
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
			// AddRoomStandardManagement
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(442, 440);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnSave);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(450, 472);
			this.MinimumSize = new System.Drawing.Size(450, 472);
			this.Name = "AddRoomStandardManagement";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "客房标准添加";
			this.Load += new System.EventHandler(this.AddRoomStandardManagement_Load);
			this.groupBox2.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void btnSave_Click(object sender, System.EventArgs e)
		{
			if(this.txtID.Text.Trim() == "" || this.txtArea.Text.Trim() == "" || this.txtNum.Text.Trim() == "" ||
				this.txtPrice.Text.Trim() == "")
			{
				MessageBox.Show("类型编号、房间面积、床位数量、客房价格不能空");
			}
			else
			{
				try
				{
					HotelDataSet.客房标准信息Row dr = ds.客房标准信息.New客房标准信息Row();
					dr.类型编号 = this.txtID.Text.Trim();
					dr.客房类型 = this.txtname.Text.Trim();
					dr.房间面积 = decimal.Parse(this.txtArea.Text.Trim());
					dr.床位数量 = Int32.Parse(this.txtNum.Text.Trim());
					dr.客房价格 = decimal.Parse(this.txtPrice.Text.Trim());
					dr.空调 = this.checkBox1.Checked;
					dr.电视机 = this.checkBox2.Checked;
					dr.电话 = this.checkBox3.Checked;
					dr.单独卫生间 = this.checkBox4.Checked;
					this.ds.客房标准信息.Add客房标准信息Row(dr);
					da.Update(ds , "客房标准信息");
					MessageBox.Show("数据保存成功");
				}
				catch(Exception ex)
				{
					MessageBox.Show(ex.Message.ToString());
				}
			}
		
		}

		private void btnCancel_Click(object sender, System.EventArgs e)
		{
		    this.Close();
		}

		private void AddRoomStandardManagement_Load(object sender, System.EventArgs e)
		{
			this.conn.ConnectionString = Config.Settings.ConnStr;
		}
	}
}
