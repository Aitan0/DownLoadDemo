using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data.SqlClient;
using HotelManagementSystem.Data;
using HotelManagementSystem.Config;
//�û�����
namespace HotelManagementSystem.SystemManagement
{
	/// <summary>
	/// SelectUserManagement ��ժҪ˵����
	/// </summary>
	public class SelectUserManagement : System.Windows.Forms.Form
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
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtPwd;
		private System.Windows.Forms.TextBox txtPost;
		private System.Windows.Forms.TextBox txtSection;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.TextBox txtID;
		private System.Windows.Forms.TextBox txtGrade;
		private System.Windows.Forms.Label label8;
		private HotelManagementSystem.Data.HotelDataSet ds;
		private System.Data.SqlClient.SqlConnection conn;
		/// <summary>
		/// ����������������
		/// </summary>
		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.TextBox txtPower;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label9;
		private System.Data.SqlClient.SqlDataAdapter da;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
		private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
		private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
		BindingManagerBase bmb;


		public SelectUserManagement()
		{
			//
			// Windows ���������֧���������
			//
			InitializeComponent();

			//
			// TODO: �� InitializeComponent ���ú�����κι��캯������
			//
		}

		/// <summary>
		/// ������������ʹ�õ���Դ��
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

		#region Windows ������������ɵĴ���
		/// <summary>
		/// �����֧������ķ��� - ��Ҫʹ�ô���༭���޸�
		/// �˷��������ݡ�
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
			this.label7.Location = new System.Drawing.Point(577, 45);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(80, 23);
			this.label7.TabIndex = 58;
			this.label7.Text = "��¼����";
			this.label7.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(1, 45);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(96, 23);
			this.label6.TabIndex = 57;
			this.label6.Text = "��ǰ��¼��";
			this.label6.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(497, 37);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.TabIndex = 56;
			this.btnCancel.Text = "�˳�";
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnEnd
			// 
			this.btnEnd.Location = new System.Drawing.Point(417, 37);
			this.btnEnd.Name = "btnEnd";
			this.btnEnd.TabIndex = 55;
			this.btnEnd.Text = "���";
			this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
			// 
			// btnNext
			// 
			this.btnNext.Location = new System.Drawing.Point(337, 37);
			this.btnNext.Name = "btnNext";
			this.btnNext.TabIndex = 54;
			this.btnNext.Text = "��һ��";
			this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
			// 
			// btnBack
			// 
			this.btnBack.Location = new System.Drawing.Point(257, 37);
			this.btnBack.Name = "btnBack";
			this.btnBack.TabIndex = 53;
			this.btnBack.Text = "��һ��";
			this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
			// 
			// btnFirst
			// 
			this.btnFirst.Location = new System.Drawing.Point(177, 37);
			this.btnFirst.Name = "btnFirst";
			this.btnFirst.TabIndex = 52;
			this.btnFirst.Text = "��ǰ";
			this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
			// 
			// btnAll
			// 
			this.btnAll.Location = new System.Drawing.Point(97, 37);
			this.btnAll.Name = "btnAll";
			this.btnAll.TabIndex = 51;
			this.btnAll.Text = "��ѯ����";
			this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.textBox2);
			this.groupBox2.Controls.Add(this.radioButton2);
			this.groupBox2.Controls.Add(this.radioButton1);
			this.groupBox2.Controls.Add(this.textBox1);
			this.groupBox2.Controls.Add(this.btnFind);
			this.groupBox2.Location = new System.Drawing.Point(49, 432);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(564, 64);
			this.groupBox2.TabIndex = 50;
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
			this.radioButton2.Text = "����";
			this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
			// 
			// radioButton1
			// 
			this.radioButton1.Location = new System.Drawing.Point(24, 24);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(64, 24);
			this.radioButton1.TabIndex = 9;
			this.radioButton1.Text = "���";
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
			this.btnFind.Text = "��ѯ";
			this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
			// 
			// dataGrid1
			// 
			this.dataGrid1.DataMember = "����Ա";
			this.dataGrid1.DataSource = this.ds;
			this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGrid1.Location = new System.Drawing.Point(49, 72);
			this.dataGrid1.Name = "dataGrid1";
			this.dataGrid1.ReadOnly = true;
			this.dataGrid1.Size = new System.Drawing.Size(564, 169);
			this.dataGrid1.TabIndex = 49;
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
			this.groupBox1.Location = new System.Drawing.Point(49, 248);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(564, 177);
			this.groupBox1.TabIndex = 48;
			this.groupBox1.TabStop = false;
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(24, 143);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(72, 23);
			this.label9.TabIndex = 14;
			this.label9.Text = "Ȩ��";
			// 
			// txtPower
			// 
			this.txtPower.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ds, "����Ա.Ȩ��"));
			this.txtPower.Location = new System.Drawing.Point(96, 140);
			this.txtPower.Name = "txtPower";
			this.txtPower.ReadOnly = true;
			this.txtPower.Size = new System.Drawing.Size(272, 21);
			this.txtPower.TabIndex = 13;
			this.txtPower.Text = "";
			// 
			// txtGrade
			// 
			this.txtGrade.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ds, "����Ա.�ȼ�"));
			this.txtGrade.Location = new System.Drawing.Point(368, 105);
			this.txtGrade.Name = "txtGrade";
			this.txtGrade.ReadOnly = true;
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
			this.label8.Text = "�ȼ�";
			// 
			// txtPwd
			// 
			this.txtPwd.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ds, "����Ա.����"));
			this.txtPwd.Location = new System.Drawing.Point(96, 102);
			this.txtPwd.Name = "txtPwd";
			this.txtPwd.ReadOnly = true;
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
			this.label5.Text = "����";
			// 
			// txtPost
			// 
			this.txtPost.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ds, "����Ա.ְλ"));
			this.txtPost.Location = new System.Drawing.Point(368, 64);
			this.txtPost.Name = "txtPost";
			this.txtPost.ReadOnly = true;
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
			this.label4.Text = "ְλ";
			// 
			// txtSection
			// 
			this.txtSection.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ds, "����Ա.����"));
			this.txtSection.Location = new System.Drawing.Point(368, 25);
			this.txtSection.Name = "txtSection";
			this.txtSection.ReadOnly = true;
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
			this.label3.Text = "����";
			// 
			// txtName
			// 
			this.txtName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ds, "����Ա.����"));
			this.txtName.Location = new System.Drawing.Point(96, 63);
			this.txtName.Name = "txtName";
			this.txtName.ReadOnly = true;
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
			this.label2.Text = "����";
			// 
			// txtID
			// 
			this.txtID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ds, "����Ա.���"));
			this.txtID.Location = new System.Drawing.Point(96, 24);
			this.txtID.Name = "txtID";
			this.txtID.ReadOnly = true;
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
			this.label1.Text = "���";
			// 
			// da
			// 
			this.da.DeleteCommand = this.sqlDeleteCommand1;
			this.da.InsertCommand = this.sqlInsertCommand1;
			this.da.SelectCommand = this.sqlSelectCommand1;
			this.da.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																						 new System.Data.Common.DataTableMapping("Table", "����Ա", new System.Data.Common.DataColumnMapping[] {
																																																new System.Data.Common.DataColumnMapping("���", "���"),
																																																new System.Data.Common.DataColumnMapping("����", "����"),
																																																new System.Data.Common.DataColumnMapping("����", "����"),
																																																new System.Data.Common.DataColumnMapping("����", "����"),
																																																new System.Data.Common.DataColumnMapping("ְλ", "ְλ"),
																																																new System.Data.Common.DataColumnMapping("�ȼ�", "�ȼ�"),
																																																new System.Data.Common.DataColumnMapping("Ȩ��", "Ȩ��")})});
			this.da.UpdateCommand = this.sqlUpdateCommand1;
			// 
			// sqlDeleteCommand1
			// 
			this.sqlDeleteCommand1.CommandText = "DELETE FROM ����Ա WHERE (��� = @Original_���) AND (���� = @Original_����) AND (���� = @Orig" +
				"inal_����) AND (Ȩ�� = @Original_Ȩ��) AND (�ȼ� = @Original_�ȼ�) AND (ְλ = @Original_ְλ)" +
				" AND (���� = @Original_����)";
			this.sqlDeleteCommand1.Connection = this.conn;
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_���", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "���", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_����", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "����", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_����", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "����", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Ȩ��", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Ȩ��", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_�ȼ�", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "�ȼ�", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_ְλ", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ְλ", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_����", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "����", System.Data.DataRowVersion.Original, null));
			// 
			// sqlInsertCommand1
			// 
			this.sqlInsertCommand1.CommandText = "INSERT INTO ����Ա(���, ����, ����, ����, ְλ, �ȼ�, Ȩ��) VALUES (@���, @����, @����, @����, @ְλ, @�ȼ�," +
				" @Ȩ��); SELECT ���, ����, ����, ����, ְλ, �ȼ�, Ȩ�� FROM ����Ա WHERE (��� = @���)";
			this.sqlInsertCommand1.Connection = this.conn;
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@���", System.Data.SqlDbType.VarChar, 20, "���"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@����", System.Data.SqlDbType.VarChar, 20, "����"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@����", System.Data.SqlDbType.VarChar, 20, "����"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@����", System.Data.SqlDbType.VarChar, 20, "����"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ְλ", System.Data.SqlDbType.VarChar, 20, "ְλ"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@�ȼ�", System.Data.SqlDbType.VarChar, 20, "�ȼ�"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Ȩ��", System.Data.SqlDbType.VarChar, 20, "Ȩ��"));
			// 
			// sqlSelectCommand1
			// 
			this.sqlSelectCommand1.CommandText = "SELECT ���, ����, ����, ����, ְλ, �ȼ�, Ȩ�� FROM ����Ա";
			this.sqlSelectCommand1.Connection = this.conn;
			// 
			// sqlUpdateCommand1
			// 
			this.sqlUpdateCommand1.CommandText = @"UPDATE ����Ա SET ��� = @���, ���� = @����, ���� = @����, ���� = @����, ְλ = @ְλ, �ȼ� = @�ȼ�, Ȩ�� = @Ȩ�� WHERE (��� = @Original_���) AND (���� = @Original_����) AND (���� = @Original_����) AND (Ȩ�� = @Original_Ȩ��) AND (�ȼ� = @Original_�ȼ�) AND (ְλ = @Original_ְλ) AND (���� = @Original_����); SELECT ���, ����, ����, ����, ְλ, �ȼ�, Ȩ�� FROM ����Ա WHERE (��� = @���)";
			this.sqlUpdateCommand1.Connection = this.conn;
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@���", System.Data.SqlDbType.VarChar, 20, "���"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@����", System.Data.SqlDbType.VarChar, 20, "����"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@����", System.Data.SqlDbType.VarChar, 20, "����"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@����", System.Data.SqlDbType.VarChar, 20, "����"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ְλ", System.Data.SqlDbType.VarChar, 20, "ְλ"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@�ȼ�", System.Data.SqlDbType.VarChar, 20, "�ȼ�"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Ȩ��", System.Data.SqlDbType.VarChar, 20, "Ȩ��"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_���", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "���", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_����", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "����", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_����", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "����", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Ȩ��", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Ȩ��", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_�ȼ�", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "�ȼ�", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_ְλ", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ְλ", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_����", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "����", System.Data.DataRowVersion.Original, null));
			// 
			// SelectUserManagement
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(664, 518);
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
			this.MaximumSize = new System.Drawing.Size(672, 552);
			this.MinimumSize = new System.Drawing.Size(672, 552);
			this.Name = "SelectUserManagement";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "�û���ѯ";
			this.Load += new System.EventHandler(this.SelectUserManagement_Load);
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void btnAll_Click(object sender, System.EventArgs e)
		{
			this.sqlSelectCommand1.CommandText = "Select * from ����Ա";
			this.ds.Clear();	
			da.Fill(ds,"����Ա");
			bmb = this.BindingContext[ds,"����Ա"];
			this.label6.Text = "��ǰ��¼��"+(this.dataGrid1.CurrentRowIndex+1);
			this.label7.Text = "��¼����"+this.bmb.Count;
		}

		private void btnFirst_Click(object sender, System.EventArgs e)
		{
			try
			{
				bmb.Position = 0;
				this.label6.Text = "��ǰ��¼��"+(this.dataGrid1.CurrentRowIndex+1);
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
				this.label6.Text = "��ǰ��¼��"+(this.dataGrid1.CurrentRowIndex+1);
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
				this.label6.Text = "��ǰ��¼��"+(this.dataGrid1.CurrentRowIndex+1);
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
				this.label6.Text = "��ǰ��¼��"+(this.dataGrid1.CurrentRowIndex+1);
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
					str = "Select * from ����Ա where ���  like '%"+this.textBox1.Text.Trim()+"%'";
					this.sqlSelectCommand1.CommandText = str;
					this.ds.Clear();
					da.Fill(this.ds,"����Ա");
					bmb=this.BindingContext[ds,"����Ա"];
					this.label6.Text = "��ǰ��¼��"+(this.dataGrid1.CurrentRowIndex+1);
					this.label7.Text = "��¼����"+this.bmb.Count;
				}
				if(this.textBox2.Enabled == true && this.textBox2.Text.Trim() != "")
				{
					str = "Select * from ����Ա where ���� like '%"+this.textBox2.Text.Trim()+"%'";
					this.sqlSelectCommand1.CommandText =str;
					this.ds.Clear();
					da.Fill(this.ds,"����Ա");
					bmb=this.BindingContext[ds,"����Ա"];
					this.label6.Text = "��ǰ��¼��"+(this.dataGrid1.CurrentRowIndex+1);
					this.label7.Text = "��¼����"+this.bmb.Count;
				}
				if(str == "")
				{
					MessageBox.Show("�������������");;
				}
			}
			catch
			{
				MessageBox.Show("��������");
			}
		}

		private void SelectUserManagement_Load(object sender, System.EventArgs e)
		{
			this.conn.ConnectionString = Config.Settings.ConnStr;
		}
	}
}
