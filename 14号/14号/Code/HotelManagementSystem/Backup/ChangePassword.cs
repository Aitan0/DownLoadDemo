using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

//修改密码

namespace HotelManagementSystem
{
	/// <summary>
	/// ChangePassword 的摘要说明。
	/// </summary>
	public class ChangePassword : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtNewPwd;
		private System.Windows.Forms.Button btnOk;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.TextBox txtConfirmNewPwd;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox groupBox1;
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;

		public ChangePassword()
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
			this.txtNewPwd = new System.Windows.Forms.TextBox();
			this.btnOk = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.txtConfirmNewPwd = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(24, 33);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(80, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "新密码";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtNewPwd
			// 
			this.txtNewPwd.Location = new System.Drawing.Point(112, 32);
			this.txtNewPwd.Name = "txtNewPwd";
			this.txtNewPwd.PasswordChar = '*';
			this.txtNewPwd.Size = new System.Drawing.Size(192, 21);
			this.txtNewPwd.TabIndex = 1;
			this.txtNewPwd.Text = "";
			// 
			// btnOk
			// 
			this.btnOk.Location = new System.Drawing.Point(64, 168);
			this.btnOk.Name = "btnOk";
			this.btnOk.TabIndex = 2;
			this.btnOk.Text = "确定";
			this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(248, 168);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.TabIndex = 5;
			this.btnCancel.Text = "取消";
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// txtConfirmNewPwd
			// 
			this.txtConfirmNewPwd.Location = new System.Drawing.Point(112, 80);
			this.txtConfirmNewPwd.Name = "txtConfirmNewPwd";
			this.txtConfirmNewPwd.PasswordChar = '*';
			this.txtConfirmNewPwd.Size = new System.Drawing.Size(192, 21);
			this.txtConfirmNewPwd.TabIndex = 4;
			this.txtConfirmNewPwd.Text = "";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(24, 81);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(80, 23);
			this.label2.TabIndex = 3;
			this.label2.Text = "确认新密码";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.txtConfirmNewPwd);
			this.groupBox1.Controls.Add(this.txtNewPwd);
			this.groupBox1.Location = new System.Drawing.Point(32, 16);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(328, 128);
			this.groupBox1.TabIndex = 6;
			this.groupBox1.TabStop = false;
			// 
			// ChangePassword
			// 
			this.AcceptButton = this.btnOk;
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(392, 214);
			this.ControlBox = false;
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOk);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(400, 248);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(400, 248);
			this.Name = "ChangePassword";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "修改密码";
			this.Load += new System.EventHandler(this.ChangePassword_Load);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void btnOk_Click(object sender, System.EventArgs e)
		{
			//判断新密码是否空
			if(this.txtNewPwd.Text.Trim() == "")
			{
				this.txtNewPwd.Text = "";
				this.txtConfirmNewPwd.Text = "";
				txtNewPwd.Focus();
				MessageBox.Show("新密码不能空");
				return;
			}
			//判断新密码是否一致
			if(this.txtNewPwd.Text.Trim() != this.txtConfirmNewPwd.Text.Trim())
			{
				this.txtNewPwd.Text = "";
				this.txtConfirmNewPwd.Text = "";
				this.txtNewPwd.Focus();
				MessageBox.Show("新密码不一致");
				return;
			}
			//判断新旧密码是否相同
			if(this.txtNewPwd.Text.Trim() == Login.UserPassword)
			{
				this.txtNewPwd.Text = "";
				this.txtConfirmNewPwd.Text = "";
				this.txtNewPwd.Focus();
				MessageBox.Show("新旧密码相同");
				return;
			}
			
			
			try
			{
				SqlConnection conn=new SqlConnection();
				conn.ConnectionString = Config.Settings.ConnStr;
				SqlCommand cmd = conn.CreateCommand();
				cmd.CommandType = CommandType.Text;
				SqlCommand Updcmd = conn.CreateCommand();

				conn.Open();
				cmd.CommandText = "select * from 管理员 where 编号 = '"+Login.UserID+"'"+" and 姓名 = '" +Login.UserName + "'"+" and  密码='"+Login.UserPassword+"'";
				SqlDataReader myReader = cmd.ExecuteReader();
	
				while(myReader.Read())
				{
					if (Login.UserPassword == myReader["密码"].ToString().Trim() && Login.UserID == myReader["编号"].ToString().Trim()
						&& Login.UserName == myReader["姓名"].ToString().Trim())
					{
						Updcmd.CommandText = "Update 管理员 Set 密码 = '"+this.txtNewPwd.Text.Trim()+"'"+
							" where 编号 = '"+Login.UserID+"'"+" and 姓名 = '"+Login.UserName+"'";
					}

				} 
				myReader.Close();				
				Updcmd.ExecuteNonQuery();
				conn.Close();	
				this.Close();				
				MessageBox.Show("密码修改成功，请记住新密码");					
			}
			catch
			{
				MessageBox.Show("密码修改失败");
			}
		}

		private void btnCancel_Click(object sender, System.EventArgs e)
		{
		     this.Close();
		}

		private void ChangePassword_Load(object sender, System.EventArgs e)
		{
		
		}
	}
}
