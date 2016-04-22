using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data.SqlClient;
using HotelManagementSystem.Config;
using HotelManagementSystem.Data;

//客房信息查询
namespace HotelManagementSystem.RoomInfoManagement
{
	/// <summary>
	/// SelectRoomInfoManagement 的摘要说明。
	/// </summary>
	public class SelectRoomInfoManagement : System.Windows.Forms.Form
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
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.TextBox txtState;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtSay;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtBedNum;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtNum;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtPlace;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtRoomType;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtTypeID;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtRoomID;
		private System.Windows.Forms.Label label1;
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;

		private HotelManagementSystem.Data.HotelDataSet ds;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Data.SqlClient.SqlConnection conn;
		private System.Data.SqlClient.SqlDataAdapter da;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
		private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
		private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
		protected BindingManagerBase bmb;

		public SelectRoomInfoManagement()
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
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.txtState = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.txtSay = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txtBedNum = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtNum = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtPlace = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtRoomType = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtTypeID = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtRoomID = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.conn = new System.Data.SqlClient.SqlConnection();
			this.da = new System.Data.SqlClient.SqlDataAdapter();
			this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
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
			this.groupBox2.Location = new System.Drawing.Point(56, 399);
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
			this.radioButton1.Text = "客房编号";
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
			this.btnCancel.Location = new System.Drawing.Point(504, 31);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.TabIndex = 36;
			this.btnCancel.Text = "退出";
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnEnd
			// 
			this.btnEnd.Location = new System.Drawing.Point(416, 31);
			this.btnEnd.Name = "btnEnd";
			this.btnEnd.TabIndex = 35;
			this.btnEnd.Text = "最后";
			this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
			// 
			// btnNext
			// 
			this.btnNext.Location = new System.Drawing.Point(336, 31);
			this.btnNext.Name = "btnNext";
			this.btnNext.TabIndex = 34;
			this.btnNext.Text = "下一个";
			this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
			// 
			// btnBack
			// 
			this.btnBack.Location = new System.Drawing.Point(256, 31);
			this.btnBack.Name = "btnBack";
			this.btnBack.TabIndex = 33;
			this.btnBack.Text = "上一个";
			this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
			// 
			// btnFirst
			// 
			this.btnFirst.Location = new System.Drawing.Point(176, 31);
			this.btnFirst.Name = "btnFirst";
			this.btnFirst.TabIndex = 32;
			this.btnFirst.Text = "最前";
			this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
			// 
			// btnAll
			// 
			this.btnAll.Location = new System.Drawing.Point(96, 31);
			this.btnAll.Name = "btnAll";
			this.btnAll.TabIndex = 31;
			this.btnAll.Text = "查询所有";
			this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
			// 
			// dataGrid1
			// 
			this.dataGrid1.DataMember = "客房信息";
			this.dataGrid1.DataSource = this.ds;
			this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGrid1.Location = new System.Drawing.Point(56, 71);
			this.dataGrid1.Name = "dataGrid1";
			this.dataGrid1.ReadOnly = true;
			this.dataGrid1.Size = new System.Drawing.Size(576, 151);
			this.dataGrid1.TabIndex = 30;
			// 
			// ds
			// 
			this.ds.DataSetName = "HotelDataSet";
			this.ds.Locale = new System.Globalization.CultureInfo("en-US");
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.checkBox1);
			this.groupBox1.Controls.Add(this.txtState);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.txtSay);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.txtBedNum);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.txtNum);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.txtPlace);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.txtRoomType);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.txtTypeID);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.txtRoomID);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(56, 229);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(576, 168);
			this.groupBox1.TabIndex = 29;
			this.groupBox1.TabStop = false;
			// 
			// checkBox1
			// 
			this.checkBox1.AutoCheck = false;
			this.checkBox1.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.ds, "客房信息.是否可拼房"));
			this.checkBox1.Location = new System.Drawing.Point(384, 120);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.TabIndex = 33;
			this.checkBox1.Text = "是否可拼房";
			// 
			// txtState
			// 
			this.txtState.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ds, "客房信息.状态"));
			this.txtState.Location = new System.Drawing.Point(384, 80);
			this.txtState.Name = "txtState";
			this.txtState.ReadOnly = true;
			this.txtState.Size = new System.Drawing.Size(168, 21);
			this.txtState.TabIndex = 32;
			this.txtState.Text = "";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(296, 80);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(72, 23);
			this.label8.TabIndex = 31;
			this.label8.Text = "状态";
			// 
			// txtSay
			// 
			this.txtSay.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ds, "客房信息.客房描述"));
			this.txtSay.Location = new System.Drawing.Point(384, 48);
			this.txtSay.Name = "txtSay";
			this.txtSay.ReadOnly = true;
			this.txtSay.Size = new System.Drawing.Size(168, 21);
			this.txtSay.TabIndex = 30;
			this.txtSay.Text = "";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(296, 48);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(72, 23);
			this.label7.TabIndex = 29;
			this.label7.Text = "客房描述";
			// 
			// txtBedNum
			// 
			this.txtBedNum.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ds, "客房信息.床数"));
			this.txtBedNum.Location = new System.Drawing.Point(384, 16);
			this.txtBedNum.Name = "txtBedNum";
			this.txtBedNum.ReadOnly = true;
			this.txtBedNum.Size = new System.Drawing.Size(168, 21);
			this.txtBedNum.TabIndex = 28;
			this.txtBedNum.Text = "";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(296, 16);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(72, 23);
			this.label6.TabIndex = 27;
			this.label6.Text = "床数";
			// 
			// txtNum
			// 
			this.txtNum.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ds, "客房信息.额定人数"));
			this.txtNum.Location = new System.Drawing.Point(104, 136);
			this.txtNum.Name = "txtNum";
			this.txtNum.ReadOnly = true;
			this.txtNum.Size = new System.Drawing.Size(168, 21);
			this.txtNum.TabIndex = 26;
			this.txtNum.Text = "";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(16, 136);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(72, 23);
			this.label5.TabIndex = 25;
			this.label5.Text = "额定人数";
			// 
			// txtPlace
			// 
			this.txtPlace.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ds, "客房信息.客房位置"));
			this.txtPlace.Location = new System.Drawing.Point(104, 109);
			this.txtPlace.Name = "txtPlace";
			this.txtPlace.ReadOnly = true;
			this.txtPlace.Size = new System.Drawing.Size(168, 21);
			this.txtPlace.TabIndex = 24;
			this.txtPlace.Text = "";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(16, 112);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(72, 24);
			this.label4.TabIndex = 23;
			this.label4.Text = "客房位置";
			// 
			// txtRoomType
			// 
			this.txtRoomType.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ds, "客房信息.客房类型"));
			this.txtRoomType.Location = new System.Drawing.Point(104, 77);
			this.txtRoomType.Name = "txtRoomType";
			this.txtRoomType.ReadOnly = true;
			this.txtRoomType.Size = new System.Drawing.Size(168, 21);
			this.txtRoomType.TabIndex = 22;
			this.txtRoomType.Text = "";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(16, 80);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(72, 24);
			this.label3.TabIndex = 21;
			this.label3.Text = "客房类型";
			// 
			// txtTypeID
			// 
			this.txtTypeID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ds, "客房信息.类型编号"));
			this.txtTypeID.Location = new System.Drawing.Point(104, 47);
			this.txtTypeID.Name = "txtTypeID";
			this.txtTypeID.ReadOnly = true;
			this.txtTypeID.Size = new System.Drawing.Size(168, 21);
			this.txtTypeID.TabIndex = 20;
			this.txtTypeID.Text = "";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(16, 48);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(72, 24);
			this.label2.TabIndex = 19;
			this.label2.Text = "类型编号";
			// 
			// txtRoomID
			// 
			this.txtRoomID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ds, "客房信息.客房编号"));
			this.txtRoomID.Location = new System.Drawing.Point(104, 16);
			this.txtRoomID.Name = "txtRoomID";
			this.txtRoomID.ReadOnly = true;
			this.txtRoomID.Size = new System.Drawing.Size(168, 21);
			this.txtRoomID.TabIndex = 18;
			this.txtRoomID.Text = "";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(16, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(72, 24);
			this.label1.TabIndex = 17;
			this.label1.Text = "客房编号";
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(8, 48);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(88, 23);
			this.label9.TabIndex = 38;
			this.label9.Text = "当前记录：";
			this.label9.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(584, 48);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(88, 23);
			this.label10.TabIndex = 39;
			this.label10.Text = "记录数：";
			this.label10.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// da
			// 
			this.da.DeleteCommand = this.sqlDeleteCommand1;
			this.da.InsertCommand = this.sqlInsertCommand1;
			this.da.SelectCommand = this.sqlSelectCommand1;
			this.da.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																						 new System.Data.Common.DataTableMapping("Table", "客房信息", new System.Data.Common.DataColumnMapping[] {
																																																 new System.Data.Common.DataColumnMapping("客房编号", "客房编号"),
																																																 new System.Data.Common.DataColumnMapping("类型编号", "类型编号"),
																																																 new System.Data.Common.DataColumnMapping("客房类型", "客房类型"),
																																																 new System.Data.Common.DataColumnMapping("客房位置", "客房位置"),
																																																 new System.Data.Common.DataColumnMapping("额定人数", "额定人数"),
																																																 new System.Data.Common.DataColumnMapping("床数", "床数"),
																																																 new System.Data.Common.DataColumnMapping("客房描述", "客房描述"),
																																																 new System.Data.Common.DataColumnMapping("状态", "状态"),
																																																 new System.Data.Common.DataColumnMapping("是否可拼房", "是否可拼房")})});
			this.da.UpdateCommand = this.sqlUpdateCommand1;
			// 
			// sqlDeleteCommand1
			// 
			this.sqlDeleteCommand1.CommandText = @"DELETE FROM 客房信息 WHERE (客房编号 = @Original_客房编号) AND (客房位置 = @Original_客房位置 OR @Original_客房位置 IS NULL AND 客房位置 IS NULL) AND (客房描述 = @Original_客房描述 OR @Original_客房描述 IS NULL AND 客房描述 IS NULL) AND (客房类型 = @Original_客房类型 OR @Original_客房类型 IS NULL AND 客房类型 IS NULL) AND (床数 = @Original_床数 OR @Original_床数 IS NULL AND 床数 IS NULL) AND (是否可拼房 = @Original_是否可拼房 OR @Original_是否可拼房 IS NULL AND 是否可拼房 IS NULL) AND (状态 = @Original_状态 OR @Original_状态 IS NULL AND 状态 IS NULL) AND (类型编号 = @Original_类型编号) AND (额定人数 = @Original_额定人数 OR @Original_额定人数 IS NULL AND 额定人数 IS NULL)";
			this.sqlDeleteCommand1.Connection = this.conn;
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_客房编号", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "客房编号", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_客房位置", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "客房位置", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_客房描述", System.Data.SqlDbType.VarChar, 40, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "客房描述", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_客房类型", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "客房类型", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_床数", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "床数", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_是否可拼房", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "是否可拼房", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_状态", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "状态", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_类型编号", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "类型编号", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_额定人数", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "额定人数", System.Data.DataRowVersion.Original, null));
			// 
			// sqlInsertCommand1
			// 
			this.sqlInsertCommand1.CommandText = "INSERT INTO 客房信息(客房编号, 类型编号, 客房类型, 客房位置, 额定人数, 床数, 客房描述, 状态, 是否可拼房) VALUES (@客房编号" +
				", @类型编号, @客房类型, @客房位置, @额定人数, @床数, @客房描述, @状态, @是否可拼房); SELECT 客房编号, 类型编号, 客房类型," +
				" 客房位置, 额定人数, 床数, 客房描述, 状态, 是否可拼房 FROM 客房信息 WHERE (客房编号 = @客房编号)";
			this.sqlInsertCommand1.Connection = this.conn;
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@客房编号", System.Data.SqlDbType.VarChar, 10, "客房编号"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@类型编号", System.Data.SqlDbType.VarChar, 10, "类型编号"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@客房类型", System.Data.SqlDbType.VarChar, 20, "客房类型"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@客房位置", System.Data.SqlDbType.VarChar, 10, "客房位置"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@额定人数", System.Data.SqlDbType.Int, 4, "额定人数"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@床数", System.Data.SqlDbType.Int, 4, "床数"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@客房描述", System.Data.SqlDbType.VarChar, 40, "客房描述"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@状态", System.Data.SqlDbType.VarChar, 10, "状态"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@是否可拼房", System.Data.SqlDbType.Bit, 1, "是否可拼房"));
			// 
			// sqlSelectCommand1
			// 
			this.sqlSelectCommand1.CommandText = "SELECT 客房编号, 类型编号, 客房类型, 客房位置, 额定人数, 床数, 客房描述, 状态, 是否可拼房 FROM 客房信息";
			this.sqlSelectCommand1.Connection = this.conn;
			// 
			// sqlUpdateCommand1
			// 
			this.sqlUpdateCommand1.CommandText = @"UPDATE 客房信息 SET 客房编号 = @客房编号, 类型编号 = @类型编号, 客房类型 = @客房类型, 客房位置 = @客房位置, 额定人数 = @额定人数, 床数 = @床数, 客房描述 = @客房描述, 状态 = @状态, 是否可拼房 = @是否可拼房 WHERE (客房编号 = @Original_客房编号) AND (客房位置 = @Original_客房位置 OR @Original_客房位置 IS NULL AND 客房位置 IS NULL) AND (客房描述 = @Original_客房描述 OR @Original_客房描述 IS NULL AND 客房描述 IS NULL) AND (客房类型 = @Original_客房类型 OR @Original_客房类型 IS NULL AND 客房类型 IS NULL) AND (床数 = @Original_床数 OR @Original_床数 IS NULL AND 床数 IS NULL) AND (是否可拼房 = @Original_是否可拼房 OR @Original_是否可拼房 IS NULL AND 是否可拼房 IS NULL) AND (状态 = @Original_状态 OR @Original_状态 IS NULL AND 状态 IS NULL) AND (类型编号 = @Original_类型编号) AND (额定人数 = @Original_额定人数 OR @Original_额定人数 IS NULL AND 额定人数 IS NULL); SELECT 客房编号, 类型编号, 客房类型, 客房位置, 额定人数, 床数, 客房描述, 状态, 是否可拼房 FROM 客房信息 WHERE (客房编号 = @客房编号)";
			this.sqlUpdateCommand1.Connection = this.conn;
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@客房编号", System.Data.SqlDbType.VarChar, 10, "客房编号"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@类型编号", System.Data.SqlDbType.VarChar, 10, "类型编号"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@客房类型", System.Data.SqlDbType.VarChar, 20, "客房类型"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@客房位置", System.Data.SqlDbType.VarChar, 10, "客房位置"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@额定人数", System.Data.SqlDbType.Int, 4, "额定人数"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@床数", System.Data.SqlDbType.Int, 4, "床数"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@客房描述", System.Data.SqlDbType.VarChar, 40, "客房描述"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@状态", System.Data.SqlDbType.VarChar, 10, "状态"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@是否可拼房", System.Data.SqlDbType.Bit, 1, "是否可拼房"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_客房编号", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "客房编号", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_客房位置", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "客房位置", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_客房描述", System.Data.SqlDbType.VarChar, 40, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "客房描述", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_客房类型", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "客房类型", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_床数", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "床数", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_是否可拼房", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "是否可拼房", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_状态", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "状态", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_类型编号", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "类型编号", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_额定人数", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "额定人数", System.Data.DataRowVersion.Original, null));
			// 
			// SelectRoomInfoManagement
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(688, 494);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label9);
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
			this.MaximumSize = new System.Drawing.Size(696, 528);
			this.MinimumSize = new System.Drawing.Size(696, 528);
			this.Name = "SelectRoomInfoManagement";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "客房信息查询";
			this.Load += new System.EventHandler(this.SelectRoomInfoManagement_Load);
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		//查询所有记录
		private void btnAll_Click(object sender, System.EventArgs e)
		{
			this.sqlSelectCommand1.CommandText = "Select * from 客房信息";
			this.ds.Clear();
			da.Fill(this.ds,"客房信息");
			bmb = this.BindingContext[ds,"客房信息"];
			this.label9.Text = "当前记录："+(this.dataGrid1.CurrentRowIndex+1);
			this.label10.Text = "记录数："+bmb.Count;
		}

		private void btnFirst_Click(object sender, System.EventArgs e)
		{
			try
			{
				bmb.Position = 0;
				this.label9.Text = "当前记录："+(this.dataGrid1.CurrentRowIndex+1);
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
				this.label9.Text = "当前记录："+(this.dataGrid1.CurrentRowIndex+1);
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
				this.label9.Text = "当前记录："+(this.dataGrid1.CurrentRowIndex+1);
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
				this.label9.Text = "当前记录："+(this.dataGrid1.CurrentRowIndex+1);
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

		//按条件查找记录
		private void btnFind_Click(object sender, System.EventArgs e)
		{
			string str = "";
			try
			{
				if(this.textBox1.Enabled == true && this.textBox1.Text.Trim() != "")
				{
					str = "Select * from 客房信息 where 客房编号 like '%"+this.textBox1.Text.Trim()+"%'";
					this.sqlSelectCommand1.CommandText = str;
					this.ds.Clear();
					da.Fill(this.ds,"客房信息");
					bmb=this.BindingContext[ds,"客房信息"];
					this.label9.Text = "当前记录："+(this.dataGrid1.CurrentRowIndex+1);
					this.label10.Text = "记录数："+bmb.Count;
		
				}
				if(this.textBox2.Enabled == true && this.textBox2.Text.Trim() != "")
				{
					str = "Select * from 客房信息 where 客房类型 like '%"+this.textBox2.Text.Trim()+"%'";
					this.sqlSelectCommand1.CommandText = str;
					this.ds.Clear();
					da.Fill(this.ds,"客房信息");
					bmb=this.BindingContext[ds,"客房信息"];
					this.label9.Text = "当前记录："+(this.dataGrid1.CurrentRowIndex+1);
					this.label10.Text = "记录数："+bmb.Count;
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

		private void SelectRoomInfoManagement_Load(object sender, System.EventArgs e)
		{
			this.conn.ConnectionString = Config.Settings.ConnStr;
		}
	}
}
