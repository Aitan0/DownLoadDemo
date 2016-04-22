using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data.SqlClient;
using HotelManagementSystem.Data;
using HotelManagementSystem.Config;
//用户添加
namespace HotelManagementSystem.SystemManagement
{
	/// <summary>
	/// AddUserManagement 的摘要说明。
	/// </summary>
	public class AddUserManagement : System.Windows.Forms.Form
	{
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
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnCancel;
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

		public AddUserManagement()
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
			this.btnSave = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
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
			this.groupBox1.Location = new System.Drawing.Point(40, 24);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(328, 304);
			this.groupBox1.TabIndex = 49;
			this.groupBox1.TabStop = false;
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(24, 260);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(72, 23);
			this.label9.TabIndex = 14;
			this.label9.Text = "权限";
			// 
			// txtPower
			// 
			this.txtPower.Location = new System.Drawing.Point(96, 254);
			this.txtPower.Name = "txtPower";
			this.txtPower.Size = new System.Drawing.Size(200, 21);
			this.txtPower.TabIndex = 13;
			this.txtPower.Text = "";
			// 
			// txtGrade
			// 
			this.txtGrade.Location = new System.Drawing.Point(96, 217);
			this.txtGrade.Name = "txtGrade";
			this.txtGrade.Size = new System.Drawing.Size(200, 21);
			this.txtGrade.TabIndex = 11;
			this.txtGrade.Text = "";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(24, 222);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(72, 23);
			this.label8.TabIndex = 10;
			this.label8.Text = "等级";
			// 
			// txtPwd
			// 
			this.txtPwd.Location = new System.Drawing.Point(96, 106);
			this.txtPwd.Name = "txtPwd";
			this.txtPwd.Size = new System.Drawing.Size(200, 21);
			this.txtPwd.TabIndex = 9;
			this.txtPwd.Text = "";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(24, 108);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(72, 23);
			this.label5.TabIndex = 8;
			this.label5.Text = "密码";
			// 
			// txtPost
			// 
			this.txtPost.Location = new System.Drawing.Point(96, 180);
			this.txtPost.Name = "txtPost";
			this.txtPost.Size = new System.Drawing.Size(200, 21);
			this.txtPost.TabIndex = 7;
			this.txtPost.Text = "";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(24, 184);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(72, 23);
			this.label4.TabIndex = 6;
			this.label4.Text = "职位";
			// 
			// txtSection
			// 
			this.txtSection.Location = new System.Drawing.Point(96, 143);
			this.txtSection.Name = "txtSection";
			this.txtSection.Size = new System.Drawing.Size(200, 21);
			this.txtSection.TabIndex = 5;
			this.txtSection.Text = "";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(24, 146);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(72, 23);
			this.label3.TabIndex = 4;
			this.label3.Text = "部门";
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(96, 69);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(200, 21);
			this.txtName.TabIndex = 3;
			this.txtName.Text = "";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(24, 70);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(72, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "姓名";
			// 
			// txtID
			// 
			this.txtID.Location = new System.Drawing.Point(96, 32);
			this.txtID.Name = "txtID";
			this.txtID.Size = new System.Drawing.Size(200, 21);
			this.txtID.TabIndex = 1;
			this.txtID.Text = "";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(24, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(72, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "编号";
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(80, 360);
			this.btnSave.Name = "btnSave";
			this.btnSave.TabIndex = 50;
			this.btnSave.Text = "保存";
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(248, 360);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.TabIndex = 51;
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
			// AddUserManagement
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(408, 418);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.groupBox1);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(416, 450);
			this.MinimumSize = new System.Drawing.Size(416, 450);
			this.Name = "AddUserManagement";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "用户添加";
			this.Load += new System.EventHandler(this.AddUserManagement_Load);
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void btnSave_Click(object sender, System.EventArgs e)
		{
			if(this.txtID.Text.Trim() == "" || this.txtName.Text.Trim() == "" || this.txtPwd.Text.Trim() == "" || this.txtSection.Text.Trim() == "" ||
				this.txtPost.Text.Trim() == "" ||this.txtGrade.Text.Trim() == "" || this.txtPower.Text.Trim() == "")
			{
				MessageBox.Show("用户所有信息都不能空");
			}
			else
			{
				HotelDataSet.管理员Row dr = this.ds.管理员.New管理员Row();
				dr.编号 = this.txtID.Text.Trim();
				dr.姓名 = this.txtName.Text.Trim();
				dr.密码 = this.txtPwd.Text.Trim();
				dr.部门 = this.txtSection.Text.Trim();
				dr.职位 = this.txtPost.Text.Trim();
				dr.等级 = this.txtGrade.Text.Trim();
				dr.权限 = this.txtPower.Text.Trim();
				ds.管理员.Add管理员Row(dr);
				da.Update(ds,"管理员");
				MessageBox.Show("数据保存成功");
			}
		}

		private void btnCancel_Click(object sender, System.EventArgs e)
		{
		    this.Close();
		}

		private void AddUserManagement_Load(object sender, System.EventArgs e)
		{
			this.conn.ConnectionString = Config.Settings.ConnStr;
		}
	}
}
