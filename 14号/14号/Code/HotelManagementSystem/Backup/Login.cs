using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using HotelManagementSystem.Config;
//登录验证
namespace HotelManagementSystem
{
	/// <summary>
	/// Login 的摘要说明。
	/// </summary>
	public class Login : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnOk;
		private System.Windows.Forms.TextBox txtID;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtPwd;
		private System.Windows.Forms.Button btnCancel;
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox combGrade;

		public bool Loginvalue ;
		public static bool LoginGrade;
		public static string UserID;
		public static string UserName;
		public static string UserPassword;
		public Login()
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
			this.label1 = new System.Windows.Forms.Label();
			this.btnOk = new System.Windows.Forms.Button();
			this.txtID = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.combGrade = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtPwd = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.btnCancel = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(32, 29);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(80, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "编号";
			// 
			// btnOk
			// 
			this.btnOk.Location = new System.Drawing.Point(80, 264);
			this.btnOk.Name = "btnOk";
			this.btnOk.TabIndex = 8;
			this.btnOk.Text = "登录";
			this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
			// 
			// txtID
			// 
			this.txtID.Location = new System.Drawing.Point(136, 24);
			this.txtID.Name = "txtID";
			this.txtID.Size = new System.Drawing.Size(208, 21);
			this.txtID.TabIndex = 2;
			this.txtID.Text = "";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.combGrade);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.txtPwd);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.txtName);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.txtID);
			this.groupBox1.Location = new System.Drawing.Point(43, 32);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(376, 200);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			// 
			// combGrade
			// 
			this.combGrade.Items.AddRange(new object[] {
														   "高级",
														   "普通"});
			this.combGrade.Location = new System.Drawing.Point(136, 156);
			this.combGrade.Name = "combGrade";
			this.combGrade.Size = new System.Drawing.Size(208, 20);
			this.combGrade.TabIndex = 8;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(32, 158);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(80, 23);
			this.label4.TabIndex = 7;
			this.label4.Text = "等级";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(32, 115);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(80, 23);
			this.label3.TabIndex = 5;
			this.label3.Text = "密码";
			// 
			// txtPwd
			// 
			this.txtPwd.Location = new System.Drawing.Point(136, 112);
			this.txtPwd.Name = "txtPwd";
			this.txtPwd.PasswordChar = '*';
			this.txtPwd.Size = new System.Drawing.Size(208, 21);
			this.txtPwd.TabIndex = 6;
			this.txtPwd.Text = "";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(32, 73);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(80, 23);
			this.label2.TabIndex = 3;
			this.label2.Text = "姓名";
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(136, 68);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(208, 21);
			this.txtName.TabIndex = 4;
			this.txtName.Text = "";
			// 
			// btnCancel
			// 
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(304, 264);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.TabIndex = 10;
			this.btnCancel.Text = "取消";
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// Login
			// 
			this.AcceptButton = this.btnOk;
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(464, 316);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnOk);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(472, 350);
			this.MinimumSize = new System.Drawing.Size(472, 350);
			this.Name = "Login";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "登录";
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void btnOk_Click(object sender, System.EventArgs e)
		{
			try
			{
				bool boolvalue = true;
				SqlConnection conn=new SqlConnection();
				conn.ConnectionString = Config.Settings.ConnStr;
				SqlCommand cmd = conn.CreateCommand();
				cmd.CommandType = CommandType.Text;

				conn.Open();
				cmd.CommandText = "select * from 管理员 where 编号 = '"+this.txtID.Text.Trim() + "'" + " and 密码 = '" +this.txtPwd.Text.Trim() + "'"+" and 姓名 ='"+this.txtName.Text.Trim()+"'";
				SqlDataReader myReader = cmd.ExecuteReader();
		
				while(myReader.Read())
				{
					if (this.txtPwd.Text.Trim() == myReader["密码"].ToString().Trim() && this.txtID.Text.Trim() == myReader["编号"].ToString().Trim()
						&& this.combGrade.Text.Trim() == myReader["等级"].ToString().Trim() && this.txtName.Text.Length != 0)
					{
						if(myReader["等级"].ToString().Trim() == "高级")
						{
                            LoginGrade = true;
						}
						UserID = this.txtID.Text.Trim();
						UserName = this.txtName.Text.Trim();
						UserPassword = this.txtPwd.Text.Trim();
						boolvalue = false;
						Loginvalue = true;
						this.Close();
					}

				} 
				myReader.Close();
				conn.Close();
				if(boolvalue)
				{
					MessageBox.Show("登录失败");		
					this.txtID.Focus();
				}	
			}
			catch
			{
				MessageBox.Show("输入有误");
			}
		}

		private void btnCancel_Click(object sender, System.EventArgs e)
		{
			this.Close();
			Application.Exit();
		}
	}
}
