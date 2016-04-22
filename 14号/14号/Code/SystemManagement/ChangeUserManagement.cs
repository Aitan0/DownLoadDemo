using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data.SqlClient;
using HotelManagementSystem.Data;
using HotelManagementSystem.Config;
//用户修改
namespace HotelManagementSystem.SystemManagement
{
	/// <summary>
	/// ChangeUserManagement 的摘要说明。
	/// </summary>
	public class ChangeUserManagement : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnEnd;
		private System.Windows.Forms.Button btnNext;
		private System.Windows.Forms.Button btnBack;
		private System.Windows.Forms.Button btnFirst;
		private System.Windows.Forms.Button btnAll;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button btnFind;
		private System.Windows.Forms.DataGrid dataGrid1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txtPower;
		private System.Windows.Forms.TextBox txtGrade;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtPwd;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtPost;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtSection;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtID;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnDelete;
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
		BindingManagerBase bmb;

		public ChangeUserManagement()
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
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnEnd = new System.Windows.Forms.Button();
			this.btnNext = new System.Windows.Forms.Button();
			this.btnBack = new System.Windows.Forms.Button();
			this.btnFirst = new System.Windows.Forms.Button();
			this.btnAll = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.btnFind = new System.Windows.Forms.Button();
			this.dataGrid1 = new System.Windows.Forms.DataGrid();
			this.ds = new HotelManagementSystem.Data.HotelDataSet();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label9 = new System.Windows.Forms.Label();
			this.txtPower = new System.Windows.Forms.TextBox();
			this.txtGrade = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.txtPwd = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtPost = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtSection = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtID = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
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
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(578, 35);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(80, 23);
			this.label7.TabIndex = 69;
			this.label7.Text = "记录数：";
			this.label7.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(2, 35);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(96, 23);
			this.label6.TabIndex = 68;
			this.label6.Text = "当前记录：";
			this.label6.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(498, 27);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.TabIndex = 67;
			this.btnCancel.Text = "退出";
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnEnd
			// 
			this.btnEnd.Location = new System.Drawing.Point(418, 27);
			this.btnEnd.Name = "btnEnd";
			this.btnEnd.TabIndex = 66;
			this.btnEnd.Text = "最后";
			this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
			// 
			// btnNext
			// 
			this.btnNext.Location = new System.Drawing.Point(338, 27);
			this.btnNext.Name = "btnNext";
			this.btnNext.TabIndex = 65;
			this.btnNext.Text = "下一个";
			this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
			// 
			// btnBack
			// 
			this.btnBack.Location = new System.Drawing.Point(258, 27);
			this.btnBack.Name = "btnBack";
			this.btnBack.TabIndex = 64;
			this.btnBack.Text = "上一个";
			this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
			// 
			// btnFirst
			// 
			this.btnFirst.Location = new System.Drawing.Point(178, 27);
			this.btnFirst.Name = "btnFirst";
			this.btnFirst.TabIndex = 63;
			this.btnFirst.Text = "最前";
			this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
			// 
			// btnAll
			// 
			this.btnAll.Location = new System.Drawing.Point(98, 27);
			this.btnAll.Name = "btnAll";
			this.btnAll.TabIndex = 62;
			this.btnAll.Text = "查询所有";
			this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.textBox2);
			this.groupBox2.Controls.Add(this.radioButton2);
			this.groupBox2.Controls.Add(this.radioButton1);
			this.groupBox2.Controls.Add(this.textBox1);
			this.groupBox2.Controls.Add(this.btnFind);
			this.groupBox2.Location = new System.Drawing.Point(50, 425);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(564, 64);
			this.groupBox2.TabIndex = 61;
			this.groupBox2.TabStop = false;
			// 
			// textBox2
			// 
			this.textBox2.Enabled = false;
			this.textBox2.Location = new System.Drawing.Point(320, 24);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(120, 21);
			this.textBox2.TabIndex = 11;
			this.textBox2.Text = "";
			// 
			// radioButton2
			// 
			this.radioButton2.Location = new System.Drawing.Point(248, 24);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(65, 24);
			this.radioButton2.TabIndex = 10;
			this.radioButton2.Text = "姓名";
			this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
			// 
			// radioButton1
			// 
			this.radioButton1.Location = new System.Drawing.Point(24, 24);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(64, 24);
			this.radioButton1.TabIndex = 9;
			this.radioButton1.Text = "编号";
			this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
			// 
			// textBox1
			// 
			this.textBox1.Enabled = false;
			this.textBox1.Location = new System.Drawing.Point(96, 24);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(120, 21);
			this.textBox1.TabIndex = 8;
			this.textBox1.Text = "";
			// 
			// btnFind
			// 
			this.btnFind.Location = new System.Drawing.Point(464, 24);
			this.btnFind.Name = "btnFind";
			this.btnFind.TabIndex = 7;
			this.btnFind.Text = "查询";
			this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
			// 
			// dataGrid1
			// 
			this.dataGrid1.DataMember = "管理员";
			this.dataGrid1.DataSource = this.ds;
			this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGrid1.Location = new System.Drawing.Point(50, 62);
			this.dataGrid1.Name = "dataGrid1";
			this.dataGrid1.ReadOnly = true;
			this.dataGrid1.Size = new System.Drawing.Size(564, 151);
			this.dataGrid1.TabIndex = 60;
			// 
			// ds
			// 
			this.ds.DataSetName = "HotelDataSet";
			this.ds.Locale = new System.Globalization.CultureInfo("en-US");
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.txtPower);
			this.groupBox1.Controls.Add(this.txtGrade);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.txtPwd);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.txtPost);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.txtSection);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.txtName);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.txtID);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Enabled = false;
			this.groupBox1.Location = new System.Drawing.Point(50, 244);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(564, 177);
			this.groupBox1.TabIndex = 59;
			this.groupBox1.TabStop = false;
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(24, 143);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(72, 23);
			this.label9.TabIndex = 14;
			this.label9.Text = "权限";
			// 
			// txtPower
			// 
			this.txtPower.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ds, "管理员.权限"));
			this.txtPower.Location = new System.Drawing.Point(96, 140);
			this.txtPower.Name = "txtPower";
			this.txtPower.Size = new System.Drawing.Size(272, 21);
			this.txtPower.TabIndex = 13;
			this.txtPower.Text = "";
			// 
			// txtGrade
			// 
			this.txtGrade.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ds, "管理员.等级"));
			this.txtGrade.Location = new System.Drawing.Point(368, 105);
			this.txtGrade.Name = "txtGrade";
			this.txtGrade.Size = new System.Drawing.Size(176, 21);
			this.txtGrade.TabIndex = 11;
			this.txtGrade.Text = "";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(288, 107);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(80, 23);
			this.label8.TabIndex = 10;
			this.label8.Text = "等级";
			// 
			// txtPwd
			// 
			this.txtPwd.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ds, "管理员.密码"));
			this.txtPwd.Location = new System.Drawing.Point(96, 102);
			this.txtPwd.Name = "txtPwd";
			this.txtPwd.Size = new System.Drawing.Size(168, 21);
			this.txtPwd.TabIndex = 9;
			this.txtPwd.Text = "";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(24, 106);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(72, 23);
			this.label5.TabIndex = 8;
			this.label5.Text = "密码";
			// 
			// txtPost
			// 
			this.txtPost.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ds, "管理员.职位"));
			this.txtPost.Location = new System.Drawing.Point(368, 64);
			this.txtPost.Name = "txtPost";
			this.txtPost.Size = new System.Drawing.Size(176, 21);
			this.txtPost.TabIndex = 7;
			this.txtPost.Text = "";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(288, 67);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(80, 23);
			this.label4.TabIndex = 6;
			this.label4.Text = "职位";
			// 
			// txtSection
			// 
			this.txtSection.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ds, "管理员.部门"));
			this.txtSection.Location = new System.Drawing.Point(368, 25);
			this.txtSection.Name = "txtSection";
			this.txtSection.Size = new System.Drawing.Size(176, 21);
			this.txtSection.TabIndex = 5;
			this.txtSection.Text = "";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(288, 32);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(80, 23);
			this.label3.TabIndex = 4;
			this.label3.Text = "部门";
			// 
			// txtName
			// 
			this.txtName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ds, "管理员.姓名"));
			this.txtName.Location = new System.Drawing.Point(96, 63);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(168, 21);
			this.txtName.TabIndex = 3;
			this.txtName.Text = "";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(24, 67);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(72, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "姓名";
			// 
			// txtID
			// 
			this.txtID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ds, "管理员.编号"));
			this.txtID.Location = new System.Drawing.Point(96, 24);
			this.txtID.Name = "txtID";
			this.txtID.Size = new System.Drawing.Size(168, 21);
			this.txtID.TabIndex = 1;
			this.txtID.Text = "";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(24, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(72, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "编号";
			// 
			// checkBox1
			// 
			this.checkBox1.Location = new System.Drawing.Point(50, 220);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(52, 24);
			this.checkBox1.TabIndex = 70;
			this.checkBox1.Text = "修改";
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(114, 220);
			this.btnSave.Name = "btnSave";
			this.btnSave.TabIndex = 71;
			this.btnSave.Text = "保存";
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(522, 220);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.TabIndex = 72;
			this.btnDelete.Text = "删除";
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// da
			// 
			this.da.DeleteCommand = this.sqlDeleteCommand1;
			this.da.InsertCommand = this.sqlInsertCommand1;
			this.da.SelectCommand = this.sqlSelectCommand1;
			this.da.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																						 new System.Data.Common.DataTableMapping("Table", "管理员", new System.Data.Common.DataColumnMapping[] {
																																																new System.Data.Common.DataColumnMapping("编号", "编号"),
																																																new System.Data.Common.DataColumnMapping("姓名", "姓名"),
																																																new System.Data.Common.DataColumnMapping("密码", "密码"),
																																																new System.Data.Common.DataColumnMapping("部门", "部门"),
																																																new System.Data.Common.DataColumnMapping("职位", "职位"),
																																																new System.Data.Common.DataColumnMapping("等级", "等级"),
																																																new System.Data.Common.DataColumnMapping("权限", "权限")})});
			this.da.UpdateCommand = this.sqlUpdateCommand1;
			// 
			// sqlDeleteCommand1
			// 
			this.sqlDeleteCommand1.CommandText = "DELETE FROM 管理员 WHERE (编号 = @Original_编号) AND (姓名 = @Original_姓名) AND (密码 = @Orig" +
				"inal_密码) AND (权限 = @Original_权限) AND (等级 = @Original_等级) AND (职位 = @Original_职位)" +
				" AND (部门 = @Original_部门)";
			this.sqlDeleteCommand1.Connection = this.conn;
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_编号", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "编号", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_姓名", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "姓名", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_密码", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "密码", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_权限", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "权限", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_等级", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "等级", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_职位", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "职位", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_部门", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "部门", System.Data.DataRowVersion.Original, null));
			// 
			// sqlInsertCommand1
			// 
			this.sqlInsertCommand1.CommandText = "INSERT INTO 管理员(编号, 姓名, 密码, 部门, 职位, 等级, 权限) VALUES (@编号, @姓名, @密码, @部门, @职位, @等级," +
				" @权限); SELECT 编号, 姓名, 密码, 部门, 职位, 等级, 权限 FROM 管理员 WHERE (编号 = @编号)";
			this.sqlInsertCommand1.Connection = this.conn;
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@编号", System.Data.SqlDbType.VarChar, 20, "编号"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@姓名", System.Data.SqlDbType.VarChar, 20, "姓名"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@密码", System.Data.SqlDbType.VarChar, 20, "密码"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@部门", System.Data.SqlDbType.VarChar, 20, "部门"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@职位", System.Data.SqlDbType.VarChar, 20, "职位"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@等级", System.Data.SqlDbType.VarChar, 20, "等级"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@权限", System.Data.SqlDbType.VarChar, 20, "权限"));
			// 
			// sqlSelectCommand1
			// 
			this.sqlSelectCommand1.CommandText = "SELECT 编号, 姓名, 密码, 部门, 职位, 等级, 权限 FROM 管理员";
			this.sqlSelectCommand1.Connection = this.conn;
			// 
			// sqlUpdateCommand1
			// 
			this.sqlUpdateCommand1.CommandText = @"UPDATE 管理员 SET 编号 = @编号, 姓名 = @姓名, 密码 = @密码, 部门 = @部门, 职位 = @职位, 等级 = @等级, 权限 = @权限 WHERE (编号 = @Original_编号) AND (姓名 = @Original_姓名) AND (密码 = @Original_密码) AND (权限 = @Original_权限) AND (等级 = @Original_等级) AND (职位 = @Original_职位) AND (部门 = @Original_部门); SELECT 编号, 姓名, 密码, 部门, 职位, 等级, 权限 FROM 管理员 WHERE (编号 = @编号)";
			this.sqlUpdateCommand1.Connection = this.conn;
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@编号", System.Data.SqlDbType.VarChar, 20, "编号"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@姓名", System.Data.SqlDbType.VarChar, 20, "姓名"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@密码", System.Data.SqlDbType.VarChar, 20, "密码"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@部门", System.Data.SqlDbType.VarChar, 20, "部门"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@职位", System.Data.SqlDbType.VarChar, 20, "职位"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@等级", System.Data.SqlDbType.VarChar, 20, "等级"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@权限", System.Data.SqlDbType.VarChar, 20, "权限"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_编号", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "编号", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_姓名", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "姓名", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_密码", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "密码", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_权限", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "权限", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_等级", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "等级", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_职位", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "职位", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_部门", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "部门", System.Data.DataRowVersion.Original, null));
			// 
			// ChangeUserManagement
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(663, 510);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.checkBox1);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnEnd);
			this.Controls.Add(this.btnNext);
			this.Controls.Add(this.btnBack);
			this.Controls.Add(this.btnFirst);
			this.Controls.Add(this.btnAll);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.dataGrid1);
			this.Controls.Add(this.groupBox1);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(671, 544);
			this.MinimumSize = new System.Drawing.Size(671, 544);
			this.Name = "ChangeUserManagement";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "用户修改";
			this.Load += new System.EventHandler(this.ChangeUserManagement_Load);
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void btnAll_Click(object sender, System.EventArgs e)
		{
			this.sqlSelectCommand1.CommandText = "Select * from 管理员";
			this.ds.Clear();	
			da.Fill(ds,"管理员");
			bmb = this.BindingContext[ds,"管理员"];
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
				if(bmb.Position!=0)
					bmb.Position-=1;
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
				if(bmb.Position!=bmb.Count)
					bmb.Position+=1;
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

		private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
		{
			if(this.checkBox1.Checked ==true)
			{
				this.groupBox1.Enabled = true;
				this.btnSave.Enabled = true;
			}
			else
			{
				this.groupBox1.Enabled = false;
				this.btnSave.Enabled = false;
			}
		}

		private void btnSave_Click(object sender, System.EventArgs e)
		{
			try
			{
				bmb.EndCurrentEdit();
				da.Update(ds,"管理员");
				this.ds.Clear();
				da.Fill(this.ds,"管理员");
				bmb=this.BindingContext[ds,"管理员"];
				this.label6.Text = "当前记录："+(this.dataGrid1.CurrentRowIndex+1);
				this.label7.Text = "记录数："+this.bmb.Count;
				MessageBox.Show("数据修改成功");
			}
			catch(Exception ex)
			{
				MessageBox.Show("修改失败："+ex.Message.ToString());
			}

		}

		private void btnDelete_Click(object sender, System.EventArgs e)
		{
			try
			{
				if(DialogResult.OK == MessageBox.Show("确定删除记录?","确定",MessageBoxButtons.OKCancel,MessageBoxIcon.Question))
				{
					this.ds.管理员.Rows[this.bmb.Position].Delete();
					da.Update(ds,"管理员");
					ds.Clear();
					da.Fill(ds,"管理员");
					bmb = this.BindingContext[ds,"管理员"];
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
				MessageBox.Show("删除无效："+ex.Message.ToString());
			}
		}

		private void btnFind_Click(object sender, System.EventArgs e)
		{
			string str = "";
			try
			{
				if(this.textBox1.Enabled == true && this.textBox1.Text.Trim() != "")
				{
					str = "Select * from 管理员 where 编号  like '%"+this.textBox1.Text.Trim()+"%'";
					this.sqlSelectCommand1.CommandText = str;
					this.ds.Clear();
					da.Fill(this.ds,"管理员");
					bmb=this.BindingContext[ds,"管理员"];
					this.label6.Text = "当前记录："+(this.dataGrid1.CurrentRowIndex+1);
					this.label7.Text = "记录数："+this.bmb.Count;
				}
				if(this.textBox2.Enabled == true && this.textBox2.Text.Trim() != "")
				{
					str = "Select * from 管理员 where 姓名 like '%"+this.textBox2.Text.Trim()+"%'";
					this.sqlSelectCommand1.CommandText =str;
					this.ds.Clear();
					da.Fill(this.ds,"管理员");
					bmb=this.BindingContext[ds,"管理员"];
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

		private void ChangeUserManagement_Load(object sender, System.EventArgs e)
		{
			this.conn.ConnectionString = Config.Settings.ConnStr;
		}
	}
}
