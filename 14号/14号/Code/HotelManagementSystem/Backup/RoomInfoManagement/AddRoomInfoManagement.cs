using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data.SqlClient;
using HotelManagementSystem.Data;
using HotelManagementSystem.Config;

//客房信息添加
namespace HotelManagementSystem.RoomInfoManagement
{
	/// <summary>
	/// AddRoomInfoManagement 的摘要说明。
	/// </summary>
	public class AddRoomInfoManagement : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtRoomID;
		private System.Windows.Forms.TextBox txtTypeID;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtRoomType;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtPlace;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtNum;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtBedNum;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtSay;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtState;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.Button btnCancel;
		private HotelManagementSystem.Data.HotelDataSet ds;
		private System.Data.SqlClient.SqlConnection conn;
		private System.Data.SqlClient.SqlDataAdapter da;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
		private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
		private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
		private System.Windows.Forms.Button btnSave;
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;

		public AddRoomInfoManagement()
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
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.ds = new HotelManagementSystem.Data.HotelDataSet();
			this.conn = new System.Data.SqlClient.SqlConnection();
			this.da = new System.Data.SqlClient.SqlDataAdapter();
			this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
			this.SuspendLayout();
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
			this.groupBox1.Location = new System.Drawing.Point(56, 32);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(332, 344);
			this.groupBox1.TabIndex = 24;
			this.groupBox1.TabStop = false;
			// 
			// checkBox1
			// 
			this.checkBox1.Location = new System.Drawing.Point(184, 304);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.TabIndex = 16;
			this.checkBox1.Text = "是否可拼房";
			// 
			// txtState
			// 
			this.txtState.Location = new System.Drawing.Point(136, 262);
			this.txtState.Name = "txtState";
			this.txtState.Size = new System.Drawing.Size(176, 21);
			this.txtState.TabIndex = 15;
			this.txtState.Text = "";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(24, 264);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(80, 23);
			this.label8.TabIndex = 14;
			this.label8.Text = "状态";
			// 
			// txtSay
			// 
			this.txtSay.Location = new System.Drawing.Point(136, 228);
			this.txtSay.Name = "txtSay";
			this.txtSay.Size = new System.Drawing.Size(176, 21);
			this.txtSay.TabIndex = 13;
			this.txtSay.Text = "";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(24, 232);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(80, 23);
			this.label7.TabIndex = 12;
			this.label7.Text = "客房描述";
			// 
			// txtBedNum
			// 
			this.txtBedNum.Location = new System.Drawing.Point(136, 194);
			this.txtBedNum.Name = "txtBedNum";
			this.txtBedNum.Size = new System.Drawing.Size(176, 21);
			this.txtBedNum.TabIndex = 11;
			this.txtBedNum.Text = "";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(24, 200);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(80, 23);
			this.label6.TabIndex = 10;
			this.label6.Text = "床数";
			// 
			// txtNum
			// 
			this.txtNum.Location = new System.Drawing.Point(136, 160);
			this.txtNum.Name = "txtNum";
			this.txtNum.Size = new System.Drawing.Size(176, 21);
			this.txtNum.TabIndex = 9;
			this.txtNum.Text = "";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(24, 166);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(80, 23);
			this.label5.TabIndex = 8;
			this.label5.Text = "额定人数";
			// 
			// txtPlace
			// 
			this.txtPlace.Location = new System.Drawing.Point(136, 126);
			this.txtPlace.Name = "txtPlace";
			this.txtPlace.Size = new System.Drawing.Size(176, 21);
			this.txtPlace.TabIndex = 7;
			this.txtPlace.Text = "";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(24, 131);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(80, 23);
			this.label4.TabIndex = 6;
			this.label4.Text = "客房位置";
			// 
			// txtRoomType
			// 
			this.txtRoomType.Location = new System.Drawing.Point(136, 92);
			this.txtRoomType.Name = "txtRoomType";
			this.txtRoomType.Size = new System.Drawing.Size(176, 21);
			this.txtRoomType.TabIndex = 5;
			this.txtRoomType.Text = "";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(25, 98);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(80, 23);
			this.label3.TabIndex = 4;
			this.label3.Text = "客房类型";
			// 
			// txtTypeID
			// 
			this.txtTypeID.Location = new System.Drawing.Point(136, 58);
			this.txtTypeID.Name = "txtTypeID";
			this.txtTypeID.Size = new System.Drawing.Size(176, 21);
			this.txtTypeID.TabIndex = 3;
			this.txtTypeID.Text = "";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(24, 64);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(80, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "类型编号";
			// 
			// txtRoomID
			// 
			this.txtRoomID.Location = new System.Drawing.Point(136, 24);
			this.txtRoomID.Name = "txtRoomID";
			this.txtRoomID.Size = new System.Drawing.Size(176, 21);
			this.txtRoomID.TabIndex = 1;
			this.txtRoomID.Text = "";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(24, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(80, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "客房编号";
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(280, 408);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.TabIndex = 23;
			this.btnCancel.Text = "取消";
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(72, 408);
			this.btnSave.Name = "btnSave";
			this.btnSave.TabIndex = 22;
			this.btnSave.Text = "保存";
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// ds
			// 
			this.ds.DataSetName = "HotelDataSet";
			this.ds.Locale = new System.Globalization.CultureInfo("en-US");
			// 
			// conn
			// 
			this.conn.ConnectionString = "workstation id=(local);packet size=4096;integrated security=SSPI;data source=(loc" +
				"al);persist security info=False;initial catalog=酒店管理系统";
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
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_客房类型", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "客房类型", System.Data.DataRowVersion.Original, null));
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
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@客房类型", System.Data.SqlDbType.VarChar, 10, "客房类型"));
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
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@客房类型", System.Data.SqlDbType.VarChar, 10, "客房类型"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@客房位置", System.Data.SqlDbType.VarChar, 10, "客房位置"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@额定人数", System.Data.SqlDbType.Int, 4, "额定人数"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@床数", System.Data.SqlDbType.Int, 4, "床数"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@客房描述", System.Data.SqlDbType.VarChar, 40, "客房描述"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@状态", System.Data.SqlDbType.VarChar, 10, "状态"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@是否可拼房", System.Data.SqlDbType.Bit, 1, "是否可拼房"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_客房编号", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "客房编号", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_客房位置", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "客房位置", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_客房描述", System.Data.SqlDbType.VarChar, 40, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "客房描述", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_客房类型", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "客房类型", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_床数", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "床数", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_是否可拼房", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "是否可拼房", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_状态", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "状态", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_类型编号", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "类型编号", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_额定人数", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "额定人数", System.Data.DataRowVersion.Original, null));
			// 
			// AddRoomInfoManagement
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(442, 464);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnSave);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(450, 496);
			this.MinimumSize = new System.Drawing.Size(450, 496);
			this.Name = "AddRoomInfoManagement";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "客房信息添加";
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		
		private void btnSave_Click(object sender, System.EventArgs e)
		{
			if(this.txtRoomID.Text.Trim() == "" || this.txtTypeID.Text.Trim() == "" || 
				this.txtNum.Text.Trim() == "" || this.txtBedNum.Text.Trim() == "")
			{
				MessageBox.Show("客房编号、类型编号、额定人数、床数不能空");
			}
			else
			{
				try
				{
					HotelDataSet.客房信息Row dr = ds.客房信息.New客房信息Row();
					dr.客房编号 = this.txtRoomID.Text.Trim();
					dr.类型编号 = this.txtTypeID.Text.Trim();
					dr.客房类型 = this.txtRoomType.Text.Trim();
					dr.客房位置 = this.txtPlace.Text.Trim();
					dr.额定人数 = Int32.Parse(this.txtNum.Text.Trim());
					dr.床数 = Int32.Parse(this.txtBedNum.Text.Trim());
					dr.客房描述 = this.txtSay.Text.Trim();
					dr.状态 = this.txtState.Text.Trim();
					dr.是否可拼房 = this.checkBox1.Checked;
					this.ds.客房信息.Add客房信息Row(dr);
					da.Update(ds,"客房信息");
					MessageBox.Show("数据保存成功");
				}
				catch(Exception ex)
				{
					MessageBox.Show("输入有误"+ex.Message.ToString());
				}
			}
		}
		private void btnCancel_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		
	}
}
