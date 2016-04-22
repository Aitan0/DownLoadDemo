using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data.SqlClient;
using HotelManagementSystem.Data;
using HotelManagementSystem.Config;
//�ͷ���׼���
namespace HotelManagementSystem.RoomStandardManagement
{
	/// <summary>
	/// AddRoomStandardManagement ��ժҪ˵����
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
		/// ����������������
		/// </summary>
		private System.ComponentModel.Container components = null;
		

		public AddRoomStandardManagement()
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
			this.checkBox4.Text = "����������";
			// 
			// checkBox3
			// 
			this.checkBox3.Location = new System.Drawing.Point(40, 64);
			this.checkBox3.Name = "checkBox3";
			this.checkBox3.TabIndex = 18;
			this.checkBox3.Text = "�绰";
			// 
			// checkBox2
			// 
			this.checkBox2.Location = new System.Drawing.Point(216, 15);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.TabIndex = 17;
			this.checkBox2.Text = "���ӻ�";
			// 
			// checkBox1
			// 
			this.checkBox1.Location = new System.Drawing.Point(40, 15);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.TabIndex = 16;
			this.checkBox1.Text = "�յ�";
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
			this.label5.Text = "�ͷ��۸�";
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
			this.label4.Text = "��λ����";
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
			this.label3.Text = "�������";
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
			this.label2.Text = "�ͷ�����";
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
			this.label1.Text = "���ͱ��";
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(296, 384);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.TabIndex = 19;
			this.btnCancel.Text = "ȡ��";
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(72, 384);
			this.btnSave.Name = "btnSave";
			this.btnSave.TabIndex = 18;
			this.btnSave.Text = "����";
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
																						 new System.Data.Common.DataTableMapping("Table", "�ͷ���׼��Ϣ", new System.Data.Common.DataColumnMapping[] {
																																																   new System.Data.Common.DataColumnMapping("���ͱ��", "���ͱ��"),
																																																   new System.Data.Common.DataColumnMapping("�ͷ�����", "�ͷ�����"),
																																																   new System.Data.Common.DataColumnMapping("�������", "�������"),
																																																   new System.Data.Common.DataColumnMapping("��λ����", "��λ����"),
																																																   new System.Data.Common.DataColumnMapping("�ͷ��۸�", "�ͷ��۸�"),
																																																   new System.Data.Common.DataColumnMapping("�յ�", "�յ�"),
																																																   new System.Data.Common.DataColumnMapping("���ӻ�", "���ӻ�"),
																																																   new System.Data.Common.DataColumnMapping("�绰", "�绰"),
																																																   new System.Data.Common.DataColumnMapping("����������", "����������")})});
			this.da.UpdateCommand = this.sqlUpdateCommand1;
			// 
			// sqlDeleteCommand1
			// 
			this.sqlDeleteCommand1.CommandText = @"DELETE FROM �ͷ���׼��Ϣ WHERE (���ͱ�� = @Original_���ͱ��) AND (���������� = @Original_���������� OR @Original_���������� IS NULL AND ���������� IS NULL) AND (�ͷ��۸� = @Original_�ͷ��۸� OR @Original_�ͷ��۸� IS NULL AND �ͷ��۸� IS NULL) AND (�ͷ����� = @Original_�ͷ����� OR @Original_�ͷ����� IS NULL AND �ͷ����� IS NULL) AND (��λ���� = @Original_��λ���� OR @Original_��λ���� IS NULL AND ��λ���� IS NULL) AND (������� = @Original_������� OR @Original_������� IS NULL AND ������� IS NULL) AND (���ӻ� = @Original_���ӻ� OR @Original_���ӻ� IS NULL AND ���ӻ� IS NULL) AND (�绰 = @Original_�绰 OR @Original_�绰 IS NULL AND �绰 IS NULL) AND (�յ� = @Original_�յ� OR @Original_�յ� IS NULL AND �յ� IS NULL)";
			this.sqlDeleteCommand1.Connection = this.conn;
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_���ͱ��", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "���ͱ��", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_����������", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "����������", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_�ͷ��۸�", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "�ͷ��۸�", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_�ͷ�����", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "�ͷ�����", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_��λ����", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "��λ����", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_�������", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "�������", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_���ӻ�", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "���ӻ�", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_�绰", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "�绰", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_�յ�", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "�յ�", System.Data.DataRowVersion.Original, null));
			// 
			// sqlInsertCommand1
			// 
			this.sqlInsertCommand1.CommandText = "INSERT INTO �ͷ���׼��Ϣ(���ͱ��, �ͷ�����, �������, ��λ����, �ͷ��۸�, �յ�, ���ӻ�, �绰, ����������) VALUES (@���ͱ�" +
				"��, @�ͷ�����, @�������, @��λ����, @�ͷ��۸�, @�յ�, @���ӻ�, @�绰, @����������); SELECT ���ͱ��, �ͷ�����, �������," +
				" ��λ����, �ͷ��۸�, �յ�, ���ӻ�, �绰, ���������� FROM �ͷ���׼��Ϣ WHERE (���ͱ�� = @���ͱ��)";
			this.sqlInsertCommand1.Connection = this.conn;
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@���ͱ��", System.Data.SqlDbType.VarChar, 10, "���ͱ��"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@�ͷ�����", System.Data.SqlDbType.VarChar, 10, "�ͷ�����"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@�������", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "�������", System.Data.DataRowVersion.Current, null));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@��λ����", System.Data.SqlDbType.Int, 4, "��λ����"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@�ͷ��۸�", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "�ͷ��۸�", System.Data.DataRowVersion.Current, null));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@�յ�", System.Data.SqlDbType.Bit, 1, "�յ�"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@���ӻ�", System.Data.SqlDbType.Bit, 1, "���ӻ�"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@�绰", System.Data.SqlDbType.Bit, 1, "�绰"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@����������", System.Data.SqlDbType.Bit, 1, "����������"));
			// 
			// sqlSelectCommand1
			// 
			this.sqlSelectCommand1.CommandText = "SELECT ���ͱ��, �ͷ�����, �������, ��λ����, �ͷ��۸�, �յ�, ���ӻ�, �绰, ���������� FROM �ͷ���׼��Ϣ";
			this.sqlSelectCommand1.Connection = this.conn;
			// 
			// sqlUpdateCommand1
			// 
			this.sqlUpdateCommand1.CommandText = @"UPDATE �ͷ���׼��Ϣ SET ���ͱ�� = @���ͱ��, �ͷ����� = @�ͷ�����, ������� = @�������, ��λ���� = @��λ����, �ͷ��۸� = @�ͷ��۸�, �յ� = @�յ�, ���ӻ� = @���ӻ�, �绰 = @�绰, ���������� = @���������� WHERE (���ͱ�� = @Original_���ͱ��) AND (���������� = @Original_���������� OR @Original_���������� IS NULL AND ���������� IS NULL) AND (�ͷ��۸� = @Original_�ͷ��۸� OR @Original_�ͷ��۸� IS NULL AND �ͷ��۸� IS NULL) AND (�ͷ����� = @Original_�ͷ����� OR @Original_�ͷ����� IS NULL AND �ͷ����� IS NULL) AND (��λ���� = @Original_��λ���� OR @Original_��λ���� IS NULL AND ��λ���� IS NULL) AND (������� = @Original_������� OR @Original_������� IS NULL AND ������� IS NULL) AND (���ӻ� = @Original_���ӻ� OR @Original_���ӻ� IS NULL AND ���ӻ� IS NULL) AND (�绰 = @Original_�绰 OR @Original_�绰 IS NULL AND �绰 IS NULL) AND (�յ� = @Original_�յ� OR @Original_�յ� IS NULL AND �յ� IS NULL); SELECT ���ͱ��, �ͷ�����, �������, ��λ����, �ͷ��۸�, �յ�, ���ӻ�, �绰, ���������� FROM �ͷ���׼��Ϣ WHERE (���ͱ�� = @���ͱ��)";
			this.sqlUpdateCommand1.Connection = this.conn;
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@���ͱ��", System.Data.SqlDbType.VarChar, 10, "���ͱ��"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@�ͷ�����", System.Data.SqlDbType.VarChar, 10, "�ͷ�����"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@�������", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "�������", System.Data.DataRowVersion.Current, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@��λ����", System.Data.SqlDbType.Int, 4, "��λ����"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@�ͷ��۸�", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "�ͷ��۸�", System.Data.DataRowVersion.Current, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@�յ�", System.Data.SqlDbType.Bit, 1, "�յ�"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@���ӻ�", System.Data.SqlDbType.Bit, 1, "���ӻ�"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@�绰", System.Data.SqlDbType.Bit, 1, "�绰"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@����������", System.Data.SqlDbType.Bit, 1, "����������"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_���ͱ��", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "���ͱ��", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_����������", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "����������", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_�ͷ��۸�", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "�ͷ��۸�", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_�ͷ�����", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "�ͷ�����", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_��λ����", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "��λ����", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_�������", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "�������", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_���ӻ�", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "���ӻ�", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_�绰", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "�绰", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_�յ�", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "�յ�", System.Data.DataRowVersion.Original, null));
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
			this.Text = "�ͷ���׼���";
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
				MessageBox.Show("���ͱ�š������������λ�������ͷ��۸��ܿ�");
			}
			else
			{
				try
				{
					HotelDataSet.�ͷ���׼��ϢRow dr = ds.�ͷ���׼��Ϣ.New�ͷ���׼��ϢRow();
					dr.���ͱ�� = this.txtID.Text.Trim();
					dr.�ͷ����� = this.txtname.Text.Trim();
					dr.������� = decimal.Parse(this.txtArea.Text.Trim());
					dr.��λ���� = Int32.Parse(this.txtNum.Text.Trim());
					dr.�ͷ��۸� = decimal.Parse(this.txtPrice.Text.Trim());
					dr.�յ� = this.checkBox1.Checked;
					dr.���ӻ� = this.checkBox2.Checked;
					dr.�绰 = this.checkBox3.Checked;
					dr.���������� = this.checkBox4.Checked;
					this.ds.�ͷ���׼��Ϣ.Add�ͷ���׼��ϢRow(dr);
					da.Update(ds , "�ͷ���׼��Ϣ");
					MessageBox.Show("���ݱ���ɹ�");
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
