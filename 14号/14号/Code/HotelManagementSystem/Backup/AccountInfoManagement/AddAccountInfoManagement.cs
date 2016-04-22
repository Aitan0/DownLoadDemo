using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data.SqlClient;
using HotelManagementSystem.Data;
using HotelManagementSystem.Config;
//计算信息添加
namespace HotelManagementSystem.AccountInfoManagement
{
	/// <summary>
	/// AddAccountInfoManagement 的摘要说明。
	/// </summary>
	public class AddAccountInfoManagement : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txtRemarks;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.TextBox txtDiscount;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.TextBox txtMoney;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox txtContents;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox txtIDCard;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtPrice;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtPosition;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtType;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtRoomID;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtInID;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtBillID;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.DateTimePicker dtArrTime;
		private System.Windows.Forms.DateTimePicker dtAccountTime;
		private HotelManagementSystem.Data.HotelDataSet ds;
		private System.Data.SqlClient.SqlConnection conn;
		private System.Data.SqlClient.SqlDataAdapter da;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
		private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
		private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
		private System.Data.SqlClient.SqlCommand sqlCommand1;
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;

		

		public AddAccountInfoManagement()
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.dtAccountTime = new System.Windows.Forms.DateTimePicker();
			this.dtArrTime = new System.Windows.Forms.DateTimePicker();
			this.txtRemarks = new System.Windows.Forms.TextBox();
			this.label16 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.txtDiscount = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.txtMoney = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.txtContents = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.txtIDCard = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txtPrice = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtPosition = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtType = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtRoomID = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtInID = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtBillID = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.ds = new HotelManagementSystem.Data.HotelDataSet();
			this.conn = new System.Data.SqlClient.SqlConnection();
			this.da = new System.Data.SqlClient.SqlDataAdapter();
			this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlCommand1 = new System.Data.SqlClient.SqlCommand();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.dtAccountTime);
			this.groupBox1.Controls.Add(this.dtArrTime);
			this.groupBox1.Controls.Add(this.txtRemarks);
			this.groupBox1.Controls.Add(this.label16);
			this.groupBox1.Controls.Add(this.label15);
			this.groupBox1.Controls.Add(this.txtDiscount);
			this.groupBox1.Controls.Add(this.label14);
			this.groupBox1.Controls.Add(this.label13);
			this.groupBox1.Controls.Add(this.txtMoney);
			this.groupBox1.Controls.Add(this.label12);
			this.groupBox1.Controls.Add(this.txtContents);
			this.groupBox1.Controls.Add(this.label11);
			this.groupBox1.Controls.Add(this.txtIDCard);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.txtName);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.txtPrice);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.txtPosition);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.txtType);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.txtRoomID);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.txtInID);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.txtBillID);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(40, 32);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(576, 296);
			this.groupBox1.TabIndex = 41;
			this.groupBox1.TabStop = false;
			// 
			// dtAccountTime
			// 
			this.dtAccountTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtAccountTime.Location = new System.Drawing.Point(376, 216);
			this.dtAccountTime.Name = "dtAccountTime";
			this.dtAccountTime.Size = new System.Drawing.Size(176, 21);
			this.dtAccountTime.TabIndex = 29;
			// 
			// dtArrTime
			// 
			this.dtArrTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtArrTime.Location = new System.Drawing.Point(376, 144);
			this.dtArrTime.Name = "dtArrTime";
			this.dtArrTime.Size = new System.Drawing.Size(176, 21);
			this.dtArrTime.TabIndex = 28;
			// 
			// txtRemarks
			// 
			this.txtRemarks.Location = new System.Drawing.Point(376, 254);
			this.txtRemarks.Name = "txtRemarks";
			this.txtRemarks.Size = new System.Drawing.Size(176, 21);
			this.txtRemarks.TabIndex = 27;
			this.txtRemarks.Text = "";
			// 
			// label16
			// 
			this.label16.Location = new System.Drawing.Point(296, 254);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(72, 23);
			this.label16.TabIndex = 26;
			this.label16.Text = "备注";
			this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label15
			// 
			this.label15.Location = new System.Drawing.Point(296, 217);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(72, 23);
			this.label15.TabIndex = 24;
			this.label15.Text = "结算日期";
			this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtDiscount
			// 
			this.txtDiscount.Location = new System.Drawing.Point(376, 180);
			this.txtDiscount.Name = "txtDiscount";
			this.txtDiscount.Size = new System.Drawing.Size(176, 21);
			this.txtDiscount.TabIndex = 23;
			this.txtDiscount.Text = "";
			// 
			// label14
			// 
			this.label14.Location = new System.Drawing.Point(296, 180);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(72, 23);
			this.label14.TabIndex = 22;
			this.label14.Text = "折扣";
			this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label13
			// 
			this.label13.Location = new System.Drawing.Point(296, 143);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(72, 23);
			this.label13.TabIndex = 20;
			this.label13.Text = "入住时间";
			this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtMoney
			// 
			this.txtMoney.Location = new System.Drawing.Point(376, 106);
			this.txtMoney.Name = "txtMoney";
			this.txtMoney.Size = new System.Drawing.Size(176, 21);
			this.txtMoney.TabIndex = 19;
			this.txtMoney.Text = "";
			// 
			// label12
			// 
			this.label12.Location = new System.Drawing.Point(296, 106);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(72, 23);
			this.label12.TabIndex = 18;
			this.label12.Text = "消费金额";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtContents
			// 
			this.txtContents.Location = new System.Drawing.Point(376, 69);
			this.txtContents.Name = "txtContents";
			this.txtContents.Size = new System.Drawing.Size(176, 21);
			this.txtContents.TabIndex = 17;
			this.txtContents.Text = "";
			// 
			// label11
			// 
			this.label11.Location = new System.Drawing.Point(296, 69);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(72, 23);
			this.label11.TabIndex = 16;
			this.label11.Text = "消费内容";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtIDCard
			// 
			this.txtIDCard.Location = new System.Drawing.Point(376, 32);
			this.txtIDCard.Name = "txtIDCard";
			this.txtIDCard.Size = new System.Drawing.Size(176, 21);
			this.txtIDCard.TabIndex = 15;
			this.txtIDCard.Text = "";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(296, 32);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(72, 23);
			this.label8.TabIndex = 14;
			this.label8.Text = "身份证";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(96, 254);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(176, 21);
			this.txtName.TabIndex = 13;
			this.txtName.Text = "";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(16, 260);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(72, 23);
			this.label7.TabIndex = 12;
			this.label7.Text = "顾客姓名";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtPrice
			// 
			this.txtPrice.Location = new System.Drawing.Point(96, 217);
			this.txtPrice.Name = "txtPrice";
			this.txtPrice.Size = new System.Drawing.Size(176, 21);
			this.txtPrice.TabIndex = 11;
			this.txtPrice.Text = "";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(16, 222);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(72, 23);
			this.label6.TabIndex = 10;
			this.label6.Text = "客房价格";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtPosition
			// 
			this.txtPosition.Location = new System.Drawing.Point(96, 180);
			this.txtPosition.Name = "txtPosition";
			this.txtPosition.Size = new System.Drawing.Size(176, 21);
			this.txtPosition.TabIndex = 9;
			this.txtPosition.Text = "";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(16, 184);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(72, 23);
			this.label5.TabIndex = 8;
			this.label5.Text = "客房位置";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtType
			// 
			this.txtType.Location = new System.Drawing.Point(96, 143);
			this.txtType.Name = "txtType";
			this.txtType.Size = new System.Drawing.Size(176, 21);
			this.txtType.TabIndex = 7;
			this.txtType.Text = "";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(16, 146);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(72, 23);
			this.label4.TabIndex = 6;
			this.label4.Text = "客房类型";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtRoomID
			// 
			this.txtRoomID.Location = new System.Drawing.Point(96, 106);
			this.txtRoomID.Name = "txtRoomID";
			this.txtRoomID.Size = new System.Drawing.Size(176, 21);
			this.txtRoomID.TabIndex = 5;
			this.txtRoomID.Text = "";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(16, 108);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(72, 23);
			this.label3.TabIndex = 4;
			this.label3.Text = "客房编号";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtInID
			// 
			this.txtInID.Location = new System.Drawing.Point(96, 69);
			this.txtInID.Name = "txtInID";
			this.txtInID.Size = new System.Drawing.Size(176, 21);
			this.txtInID.TabIndex = 3;
			this.txtInID.Text = "";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(16, 70);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(72, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "入住单号";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtBillID
			// 
			this.txtBillID.Location = new System.Drawing.Point(96, 32);
			this.txtBillID.Name = "txtBillID";
			this.txtBillID.Size = new System.Drawing.Size(176, 21);
			this.txtBillID.TabIndex = 1;
			this.txtBillID.Text = "";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(16, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(72, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "帐单编号";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(424, 360);
			this.btnSave.Name = "btnSave";
			this.btnSave.TabIndex = 42;
			this.btnSave.Text = "保存";
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(528, 360);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.TabIndex = 43;
			this.btnCancel.Text = "取消";
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
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
																						 new System.Data.Common.DataTableMapping("Table", "帐单明细", new System.Data.Common.DataColumnMapping[] {
																																																 new System.Data.Common.DataColumnMapping("帐单编号", "帐单编号"),
																																																 new System.Data.Common.DataColumnMapping("入住单号", "入住单号"),
																																																 new System.Data.Common.DataColumnMapping("客房编号", "客房编号"),
																																																 new System.Data.Common.DataColumnMapping("客房类型", "客房类型"),
																																																 new System.Data.Common.DataColumnMapping("客房位置", "客房位置"),
																																																 new System.Data.Common.DataColumnMapping("客房价格", "客房价格"),
																																																 new System.Data.Common.DataColumnMapping("顾客姓名", "顾客姓名"),
																																																 new System.Data.Common.DataColumnMapping("身份证", "身份证"),
																																																 new System.Data.Common.DataColumnMapping("消费内容", "消费内容"),
																																																 new System.Data.Common.DataColumnMapping("消费金额", "消费金额"),
																																																 new System.Data.Common.DataColumnMapping("入住时间", "入住时间"),
																																																 new System.Data.Common.DataColumnMapping("折扣", "折扣"),
																																																 new System.Data.Common.DataColumnMapping("结算日期", "结算日期"),
																																																 new System.Data.Common.DataColumnMapping("备注", "备注")})});
			this.da.UpdateCommand = this.sqlUpdateCommand1;
			// 
			// sqlDeleteCommand1
			// 
			this.sqlDeleteCommand1.CommandText = @"DELETE FROM 帐单明细 WHERE (帐单编号 = @Original_帐单编号) AND (入住单号 = @Original_入住单号) AND (入住时间 = @Original_入住时间 OR @Original_入住时间 IS NULL AND 入住时间 IS NULL) AND (备注 = @Original_备注 OR @Original_备注 IS NULL AND 备注 IS NULL) AND (客房价格 = @Original_客房价格 OR @Original_客房价格 IS NULL AND 客房价格 IS NULL) AND (客房位置 = @Original_客房位置 OR @Original_客房位置 IS NULL AND 客房位置 IS NULL) AND (客房类型 = @Original_客房类型 OR @Original_客房类型 IS NULL AND 客房类型 IS NULL) AND (客房编号 = @Original_客房编号) AND (折扣 = @Original_折扣 OR @Original_折扣 IS NULL AND 折扣 IS NULL) AND (消费内容 = @Original_消费内容 OR @Original_消费内容 IS NULL AND 消费内容 IS NULL) AND (消费金额 = @Original_消费金额 OR @Original_消费金额 IS NULL AND 消费金额 IS NULL) AND (结算日期 = @Original_结算日期 OR @Original_结算日期 IS NULL AND 结算日期 IS NULL) AND (身份证 = @Original_身份证 OR @Original_身份证 IS NULL AND 身份证 IS NULL) AND (顾客姓名 = @Original_顾客姓名 OR @Original_顾客姓名 IS NULL AND 顾客姓名 IS NULL)";
			this.sqlDeleteCommand1.Connection = this.conn;
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_帐单编号", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "帐单编号", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_入住单号", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "入住单号", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_入住时间", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "入住时间", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_备注", System.Data.SqlDbType.VarChar, 40, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "备注", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_客房价格", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "客房价格", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_客房位置", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "客房位置", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_客房类型", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "客房类型", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_客房编号", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "客房编号", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_折扣", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "折扣", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_消费内容", System.Data.SqlDbType.VarChar, 40, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "消费内容", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_消费金额", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "消费金额", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_结算日期", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "结算日期", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_身份证", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "身份证", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_顾客姓名", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "顾客姓名", System.Data.DataRowVersion.Original, null));
			// 
			// sqlInsertCommand1
			// 
			this.sqlInsertCommand1.CommandText = @"INSERT INTO 帐单明细(帐单编号, 入住单号, 客房编号, 客房类型, 客房位置, 客房价格, 顾客姓名, 身份证, 消费内容, 消费金额, 入住时间, 折扣, 结算日期, 备注) VALUES (@帐单编号, @入住单号, @客房编号, @客房类型, @客房位置, @客房价格, @顾客姓名, @身份证, @消费内容, @消费金额, @入住时间, @折扣, @结算日期, @备注); SELECT 帐单编号, 入住单号, 客房编号, 客房类型, 客房位置, 客房价格, 顾客姓名, 身份证, 消费内容, 消费金额, 入住时间, 折扣, 结算日期, 备注 FROM 帐单明细 WHERE (帐单编号 = @帐单编号)";
			this.sqlInsertCommand1.Connection = this.conn;
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@帐单编号", System.Data.SqlDbType.VarChar, 10, "帐单编号"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@入住单号", System.Data.SqlDbType.VarChar, 10, "入住单号"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@客房编号", System.Data.SqlDbType.VarChar, 10, "客房编号"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@客房类型", System.Data.SqlDbType.VarChar, 20, "客房类型"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@客房位置", System.Data.SqlDbType.VarChar, 10, "客房位置"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@客房价格", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "客房价格", System.Data.DataRowVersion.Current, null));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@顾客姓名", System.Data.SqlDbType.VarChar, 10, "顾客姓名"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@身份证", System.Data.SqlDbType.VarChar, 20, "身份证"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@消费内容", System.Data.SqlDbType.VarChar, 40, "消费内容"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@消费金额", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "消费金额", System.Data.DataRowVersion.Current, null));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@入住时间", System.Data.SqlDbType.DateTime, 8, "入住时间"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@折扣", System.Data.SqlDbType.Float, 8, "折扣"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@结算日期", System.Data.SqlDbType.DateTime, 8, "结算日期"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@备注", System.Data.SqlDbType.VarChar, 40, "备注"));
			// 
			// sqlSelectCommand1
			// 
			this.sqlSelectCommand1.CommandText = "SELECT 帐单编号, 入住单号, 客房编号, 客房类型, 客房位置, 客房价格, 顾客姓名, 身份证, 消费内容, 消费金额, 入住时间, 折扣, 结算日期," +
				" 备注 FROM 帐单明细";
			this.sqlSelectCommand1.Connection = this.conn;
			// 
			// sqlUpdateCommand1
			// 
			this.sqlUpdateCommand1.CommandText = @"UPDATE 帐单明细 SET 帐单编号 = @帐单编号, 入住单号 = @入住单号, 客房编号 = @客房编号, 客房类型 = @客房类型, 客房位置 = @客房位置, 客房价格 = @客房价格, 顾客姓名 = @顾客姓名, 身份证 = @身份证, 消费内容 = @消费内容, 消费金额 = @消费金额, 入住时间 = @入住时间, 折扣 = @折扣, 结算日期 = @结算日期, 备注 = @备注 WHERE (帐单编号 = @Original_帐单编号) AND (入住单号 = @Original_入住单号) AND (入住时间 = @Original_入住时间 OR @Original_入住时间 IS NULL AND 入住时间 IS NULL) AND (备注 = @Original_备注 OR @Original_备注 IS NULL AND 备注 IS NULL) AND (客房价格 = @Original_客房价格 OR @Original_客房价格 IS NULL AND 客房价格 IS NULL) AND (客房位置 = @Original_客房位置 OR @Original_客房位置 IS NULL AND 客房位置 IS NULL) AND (客房类型 = @Original_客房类型 OR @Original_客房类型 IS NULL AND 客房类型 IS NULL) AND (客房编号 = @Original_客房编号) AND (折扣 = @Original_折扣 OR @Original_折扣 IS NULL AND 折扣 IS NULL) AND (消费内容 = @Original_消费内容 OR @Original_消费内容 IS NULL AND 消费内容 IS NULL) AND (消费金额 = @Original_消费金额 OR @Original_消费金额 IS NULL AND 消费金额 IS NULL) AND (结算日期 = @Original_结算日期 OR @Original_结算日期 IS NULL AND 结算日期 IS NULL) AND (身份证 = @Original_身份证 OR @Original_身份证 IS NULL AND 身份证 IS NULL) AND (顾客姓名 = @Original_顾客姓名 OR @Original_顾客姓名 IS NULL AND 顾客姓名 IS NULL); SELECT 帐单编号, 入住单号, 客房编号, 客房类型, 客房位置, 客房价格, 顾客姓名, 身份证, 消费内容, 消费金额, 入住时间, 折扣, 结算日期, 备注 FROM 帐单明细 WHERE (帐单编号 = @帐单编号)";
			this.sqlUpdateCommand1.Connection = this.conn;
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@帐单编号", System.Data.SqlDbType.VarChar, 10, "帐单编号"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@入住单号", System.Data.SqlDbType.VarChar, 10, "入住单号"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@客房编号", System.Data.SqlDbType.VarChar, 10, "客房编号"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@客房类型", System.Data.SqlDbType.VarChar, 20, "客房类型"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@客房位置", System.Data.SqlDbType.VarChar, 10, "客房位置"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@客房价格", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "客房价格", System.Data.DataRowVersion.Current, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@顾客姓名", System.Data.SqlDbType.VarChar, 10, "顾客姓名"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@身份证", System.Data.SqlDbType.VarChar, 20, "身份证"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@消费内容", System.Data.SqlDbType.VarChar, 40, "消费内容"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@消费金额", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "消费金额", System.Data.DataRowVersion.Current, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@入住时间", System.Data.SqlDbType.DateTime, 8, "入住时间"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@折扣", System.Data.SqlDbType.Float, 8, "折扣"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@结算日期", System.Data.SqlDbType.DateTime, 8, "结算日期"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@备注", System.Data.SqlDbType.VarChar, 40, "备注"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_帐单编号", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "帐单编号", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_入住单号", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "入住单号", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_入住时间", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "入住时间", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_备注", System.Data.SqlDbType.VarChar, 40, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "备注", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_客房价格", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "客房价格", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_客房位置", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "客房位置", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_客房类型", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "客房类型", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_客房编号", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "客房编号", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_折扣", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "折扣", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_消费内容", System.Data.SqlDbType.VarChar, 40, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "消费内容", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_消费金额", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "消费金额", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_结算日期", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "结算日期", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_身份证", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "身份证", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_顾客姓名", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "顾客姓名", System.Data.DataRowVersion.Original, null));
			// 
			// sqlCommand1
			// 
			this.sqlCommand1.CommandText = "dbo.[PROC_帐单明细历史]";
			this.sqlCommand1.CommandType = System.Data.CommandType.StoredProcedure;
			this.sqlCommand1.Connection = this.conn;
			this.sqlCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((System.Byte)(0)), ((System.Byte)(0)), "", System.Data.DataRowVersion.Current, null));
			this.sqlCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@帐单编号", System.Data.SqlDbType.VarChar, 10));
			// 
			// AddAccountInfoManagement
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(656, 414);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.groupBox1);
			this.MaximizeBox = false;
			this.Name = "AddAccountInfoManagement";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "结算信息添加";
			this.Load += new System.EventHandler(this.AddAccountInfoManagement_Load);
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

	
		private void btnSave_Click(object sender, System.EventArgs e)
		{
			if(this.txtBillID.Text.Trim() == "" || this.txtInID.Text.Trim() == "" || this.txtRoomID.Text.Trim() == "" || 
				this.txtPrice.Text.Trim() == "" || this.txtMoney.Text.Trim() == "" || this.txtDiscount.Text.Trim() == "")
			{
				MessageBox.Show("帐单编号、入住单号、客房编号、客房价格、消费金额、折扣不能为空");
			}
			else
			{
				try
				{
					HotelDataSet.帐单明细Row dr = ds.帐单明细.New帐单明细Row();
					dr.帐单编号 = this.txtBillID.Text.Trim();
					dr.入住单号 = this.txtInID.Text.Trim();
					dr.客房编号 = this.txtRoomID.Text.Trim();
					dr.客房类型 = this.txtType.Text.Trim();
					dr.客房位置 = this.txtPosition.Text.Trim();
					dr.客房价格 = decimal.Parse(this.txtPrice.Text.Trim());
					dr.顾客姓名 = this.txtName.Text.Trim();
					dr.身份证 = this.txtIDCard.Text.Trim();
					dr.消费内容 = this.txtContents.Text.Trim();
					dr.消费金额 = decimal.Parse(this.txtMoney.Text.Trim());
					dr.入住时间 = this.dtArrTime.Value;
					dr.折扣 = float.Parse(this.txtDiscount.Text.Trim());
					dr.结算日期 = this.dtAccountTime.Value;
					dr.备注 = this.txtRemarks.Text.Trim();
					this.ds.帐单明细.Add帐单明细Row(dr);
					da.Update(ds,"帐单明细");
					conn.Open();
					this.sqlCommand1.Parameters["@帐单编号"].Value = this.txtBillID.Text.Trim();
					this.sqlCommand1.ExecuteNonQuery();
					conn.Close();
					MessageBox.Show("数据保存成功");
				}
				catch
				{
					MessageBox.Show("输入有误");
				}
			}
		}

		private void btnCancel_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void AddAccountInfoManagement_Load(object sender, System.EventArgs e)
		{
			this.conn.ConnectionString = Config.Settings.ConnStr;
		}
	}
}
