using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data.SqlClient;
using HotelManagementSystem.Data;
using HotelManagementSystem.Config;

//�ʵ���ϸ��ʷ��ѯ

namespace HotelManagementSystem.HistoryManagement
{
	/// <summary>
	/// BillHistoryManagement ��ժҪ˵����
	/// </summary>
	public class BillHistoryManagement : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.Button btnFind;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.DataGrid dataGrid1;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnEnd;
		private System.Windows.Forms.Button btnNext;
		private System.Windows.Forms.Button btnBack;
		private System.Windows.Forms.Button btnFirst;
		private System.Windows.Forms.Button btnAll;
		/// <summary>
		/// ����������������
		/// </summary>
		private System.ComponentModel.Container components = null;
		private HotelManagementSystem.Data.HotelDataSet ds;
		private System.Data.SqlClient.SqlConnection conn;
		private System.Data.SqlClient.SqlDataAdapter da;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
		private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
		private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
		BindingManagerBase bmb;

		public BillHistoryManagement()
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
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.btnFind = new System.Windows.Forms.Button();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label24 = new System.Windows.Forms.Label();
			this.label23 = new System.Windows.Forms.Label();
			this.dataGrid1 = new System.Windows.Forms.DataGrid();
			this.ds = new HotelManagementSystem.Data.HotelDataSet();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnEnd = new System.Windows.Forms.Button();
			this.btnNext = new System.Windows.Forms.Button();
			this.btnBack = new System.Windows.Forms.Button();
			this.btnFirst = new System.Windows.Forms.Button();
			this.btnAll = new System.Windows.Forms.Button();
			this.conn = new System.Data.SqlClient.SqlConnection();
			this.da = new System.Data.SqlClient.SqlDataAdapter();
			this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.radioButton1);
			this.groupBox2.Controls.Add(this.btnFind);
			this.groupBox2.Controls.Add(this.textBox2);
			this.groupBox2.Controls.Add(this.radioButton2);
			this.groupBox2.Controls.Add(this.textBox1);
			this.groupBox2.Location = new System.Drawing.Point(16, 416);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(712, 64);
			this.groupBox2.TabIndex = 87;
			this.groupBox2.TabStop = false;
			// 
			// radioButton1
			// 
			this.radioButton1.Location = new System.Drawing.Point(16, 27);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(80, 24);
			this.radioButton1.TabIndex = 5;
			this.radioButton1.Text = "�ʵ����";
			this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
			// 
			// btnFind
			// 
			this.btnFind.Location = new System.Drawing.Point(608, 27);
			this.btnFind.Name = "btnFind";
			this.btnFind.TabIndex = 4;
			this.btnFind.Text = "��ѯ";
			this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
			// 
			// textBox2
			// 
			this.textBox2.Enabled = false;
			this.textBox2.Location = new System.Drawing.Point(400, 27);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(176, 21);
			this.textBox2.TabIndex = 3;
			this.textBox2.Text = "";
			// 
			// radioButton2
			// 
			this.radioButton2.Location = new System.Drawing.Point(320, 27);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(72, 24);
			this.radioButton2.TabIndex = 2;
			this.radioButton2.Text = "�ͷ����";
			this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
			// 
			// textBox1
			// 
			this.textBox1.Enabled = false;
			this.textBox1.Location = new System.Drawing.Point(104, 27);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(176, 21);
			this.textBox1.TabIndex = 1;
			this.textBox1.Text = "";
			// 
			// label24
			// 
			this.label24.Location = new System.Drawing.Point(624, 48);
			this.label24.Name = "label24";
			this.label24.TabIndex = 86;
			this.label24.Text = "��¼����";
			this.label24.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// label23
			// 
			this.label23.Location = new System.Drawing.Point(16, 48);
			this.label23.Name = "label23";
			this.label23.TabIndex = 85;
			this.label23.Text = "��ǰ��¼��";
			this.label23.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// dataGrid1
			// 
			this.dataGrid1.DataMember = "�ʵ���ϸ��ʷ";
			this.dataGrid1.DataSource = this.ds;
			this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGrid1.Location = new System.Drawing.Point(16, 72);
			this.dataGrid1.Name = "dataGrid1";
			this.dataGrid1.ReadOnly = true;
			this.dataGrid1.Size = new System.Drawing.Size(712, 328);
			this.dataGrid1.TabIndex = 84;
			// 
			// ds
			// 
			this.ds.DataSetName = "HotelDataSet";
			this.ds.Locale = new System.Globalization.CultureInfo("en-US");
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(536, 32);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.TabIndex = 83;
			this.btnCancel.Text = "�˳�";
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnEnd
			// 
			this.btnEnd.Location = new System.Drawing.Point(456, 32);
			this.btnEnd.Name = "btnEnd";
			this.btnEnd.TabIndex = 82;
			this.btnEnd.Text = "���";
			this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
			// 
			// btnNext
			// 
			this.btnNext.Location = new System.Drawing.Point(376, 32);
			this.btnNext.Name = "btnNext";
			this.btnNext.TabIndex = 81;
			this.btnNext.Text = "��һ��";
			this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
			// 
			// btnBack
			// 
			this.btnBack.Location = new System.Drawing.Point(288, 32);
			this.btnBack.Name = "btnBack";
			this.btnBack.TabIndex = 80;
			this.btnBack.Text = "��һ��";
			this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
			// 
			// btnFirst
			// 
			this.btnFirst.Location = new System.Drawing.Point(208, 32);
			this.btnFirst.Name = "btnFirst";
			this.btnFirst.TabIndex = 79;
			this.btnFirst.Text = "��ǰ";
			this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
			// 
			// btnAll
			// 
			this.btnAll.Location = new System.Drawing.Point(128, 32);
			this.btnAll.Name = "btnAll";
			this.btnAll.TabIndex = 78;
			this.btnAll.Text = "��ѯ����";
			this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
			// 
			// da
			// 
			this.da.DeleteCommand = this.sqlDeleteCommand1;
			this.da.InsertCommand = this.sqlInsertCommand1;
			this.da.SelectCommand = this.sqlSelectCommand1;
			this.da.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																						 new System.Data.Common.DataTableMapping("Table", "�ʵ���ϸ��ʷ", new System.Data.Common.DataColumnMapping[] {
																																																   new System.Data.Common.DataColumnMapping("�ʵ����", "�ʵ����"),
																																																   new System.Data.Common.DataColumnMapping("��ס����", "��ס����"),
																																																   new System.Data.Common.DataColumnMapping("�ͷ����", "�ͷ����"),
																																																   new System.Data.Common.DataColumnMapping("�ͷ�����", "�ͷ�����"),
																																																   new System.Data.Common.DataColumnMapping("�ͷ�λ��", "�ͷ�λ��"),
																																																   new System.Data.Common.DataColumnMapping("�ͷ��۸�", "�ͷ��۸�"),
																																																   new System.Data.Common.DataColumnMapping("�˿�����", "�˿�����"),
																																																   new System.Data.Common.DataColumnMapping("���֤", "���֤"),
																																																   new System.Data.Common.DataColumnMapping("��������", "��������"),
																																																   new System.Data.Common.DataColumnMapping("���ѽ��", "���ѽ��"),
																																																   new System.Data.Common.DataColumnMapping("��סʱ��", "��סʱ��"),
																																																   new System.Data.Common.DataColumnMapping("�ۿ�", "�ۿ�"),
																																																   new System.Data.Common.DataColumnMapping("��������", "��������"),
																																																   new System.Data.Common.DataColumnMapping("��ע", "��ע")})});
			this.da.UpdateCommand = this.sqlUpdateCommand1;
			// 
			// sqlDeleteCommand1
			// 
			this.sqlDeleteCommand1.CommandText = @"DELETE FROM �ʵ���ϸ��ʷ WHERE (�ʵ���� = @Original_�ʵ����) AND (��ס���� = @Original_��ס����) AND (��סʱ�� = @Original_��סʱ�� OR @Original_��סʱ�� IS NULL AND ��סʱ�� IS NULL) AND (��ע = @Original_��ע OR @Original_��ע IS NULL AND ��ע IS NULL) AND (�ͷ��۸� = @Original_�ͷ��۸� OR @Original_�ͷ��۸� IS NULL AND �ͷ��۸� IS NULL) AND (�ͷ�λ�� = @Original_�ͷ�λ�� OR @Original_�ͷ�λ�� IS NULL AND �ͷ�λ�� IS NULL) AND (�ͷ����� = @Original_�ͷ����� OR @Original_�ͷ����� IS NULL AND �ͷ����� IS NULL) AND (�ͷ���� = @Original_�ͷ����) AND (�ۿ� = @Original_�ۿ� OR @Original_�ۿ� IS NULL AND �ۿ� IS NULL) AND (�������� = @Original_�������� OR @Original_�������� IS NULL AND �������� IS NULL) AND (���ѽ�� = @Original_���ѽ�� OR @Original_���ѽ�� IS NULL AND ���ѽ�� IS NULL) AND (�������� = @Original_�������� OR @Original_�������� IS NULL AND �������� IS NULL) AND (���֤ = @Original_���֤ OR @Original_���֤ IS NULL AND ���֤ IS NULL) AND (�˿����� = @Original_�˿����� OR @Original_�˿����� IS NULL AND �˿����� IS NULL)";
			this.sqlDeleteCommand1.Connection = this.conn;
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_�ʵ����", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "�ʵ����", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_��ס����", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "��ס����", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_��סʱ��", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "��סʱ��", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_��ע", System.Data.SqlDbType.VarChar, 40, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "��ע", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_�ͷ��۸�", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "�ͷ��۸�", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_�ͷ�λ��", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "�ͷ�λ��", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_�ͷ�����", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "�ͷ�����", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_�ͷ����", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "�ͷ����", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_�ۿ�", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "�ۿ�", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_��������", System.Data.SqlDbType.VarChar, 40, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "��������", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_���ѽ��", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "���ѽ��", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_��������", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "��������", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_���֤", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "���֤", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_�˿�����", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "�˿�����", System.Data.DataRowVersion.Original, null));
			// 
			// sqlInsertCommand1
			// 
			this.sqlInsertCommand1.CommandText = @"INSERT INTO �ʵ���ϸ��ʷ(�ʵ����, ��ס����, �ͷ����, �ͷ�����, �ͷ�λ��, �ͷ��۸�, �˿�����, ���֤, ��������, ���ѽ��, ��סʱ��, �ۿ�, ��������, ��ע) VALUES (@�ʵ����, @��ס����, @�ͷ����, @�ͷ�����, @�ͷ�λ��, @�ͷ��۸�, @�˿�����, @���֤, @��������, @���ѽ��, @��סʱ��, @�ۿ�, @��������, @��ע); SELECT �ʵ����, ��ס����, �ͷ����, �ͷ�����, �ͷ�λ��, �ͷ��۸�, �˿�����, ���֤, ��������, ���ѽ��, ��סʱ��, �ۿ�, ��������, ��ע FROM �ʵ���ϸ��ʷ WHERE (�ʵ���� = @�ʵ����)";
			this.sqlInsertCommand1.Connection = this.conn;
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@�ʵ����", System.Data.SqlDbType.VarChar, 10, "�ʵ����"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@��ס����", System.Data.SqlDbType.VarChar, 10, "��ס����"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@�ͷ����", System.Data.SqlDbType.VarChar, 10, "�ͷ����"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@�ͷ�����", System.Data.SqlDbType.VarChar, 20, "�ͷ�����"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@�ͷ�λ��", System.Data.SqlDbType.VarChar, 10, "�ͷ�λ��"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@�ͷ��۸�", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "�ͷ��۸�", System.Data.DataRowVersion.Current, null));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@�˿�����", System.Data.SqlDbType.VarChar, 10, "�˿�����"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@���֤", System.Data.SqlDbType.VarChar, 20, "���֤"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@��������", System.Data.SqlDbType.VarChar, 40, "��������"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@���ѽ��", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "���ѽ��", System.Data.DataRowVersion.Current, null));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@��סʱ��", System.Data.SqlDbType.DateTime, 4, "��סʱ��"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@�ۿ�", System.Data.SqlDbType.Float, 8, "�ۿ�"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@��������", System.Data.SqlDbType.DateTime, 4, "��������"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@��ע", System.Data.SqlDbType.VarChar, 40, "��ע"));
			// 
			// sqlSelectCommand1
			// 
			this.sqlSelectCommand1.CommandText = "SELECT �ʵ����, ��ס����, �ͷ����, �ͷ�����, �ͷ�λ��, �ͷ��۸�, �˿�����, ���֤, ��������, ���ѽ��, ��סʱ��, �ۿ�, ��������," +
				" ��ע FROM �ʵ���ϸ��ʷ";
			this.sqlSelectCommand1.Connection = this.conn;
			// 
			// sqlUpdateCommand1
			// 
			this.sqlUpdateCommand1.CommandText = @"UPDATE �ʵ���ϸ��ʷ SET �ʵ���� = @�ʵ����, ��ס���� = @��ס����, �ͷ���� = @�ͷ����, �ͷ����� = @�ͷ�����, �ͷ�λ�� = @�ͷ�λ��, �ͷ��۸� = @�ͷ��۸�, �˿����� = @�˿�����, ���֤ = @���֤, �������� = @��������, ���ѽ�� = @���ѽ��, ��סʱ�� = @��סʱ��, �ۿ� = @�ۿ�, �������� = @��������, ��ע = @��ע WHERE (�ʵ���� = @Original_�ʵ����) AND (��ס���� = @Original_��ס����) AND (��סʱ�� = @Original_��סʱ�� OR @Original_��סʱ�� IS NULL AND ��סʱ�� IS NULL) AND (��ע = @Original_��ע OR @Original_��ע IS NULL AND ��ע IS NULL) AND (�ͷ��۸� = @Original_�ͷ��۸� OR @Original_�ͷ��۸� IS NULL AND �ͷ��۸� IS NULL) AND (�ͷ�λ�� = @Original_�ͷ�λ�� OR @Original_�ͷ�λ�� IS NULL AND �ͷ�λ�� IS NULL) AND (�ͷ����� = @Original_�ͷ����� OR @Original_�ͷ����� IS NULL AND �ͷ����� IS NULL) AND (�ͷ���� = @Original_�ͷ����) AND (�ۿ� = @Original_�ۿ� OR @Original_�ۿ� IS NULL AND �ۿ� IS NULL) AND (�������� = @Original_�������� OR @Original_�������� IS NULL AND �������� IS NULL) AND (���ѽ�� = @Original_���ѽ�� OR @Original_���ѽ�� IS NULL AND ���ѽ�� IS NULL) AND (�������� = @Original_�������� OR @Original_�������� IS NULL AND �������� IS NULL) AND (���֤ = @Original_���֤ OR @Original_���֤ IS NULL AND ���֤ IS NULL) AND (�˿����� = @Original_�˿����� OR @Original_�˿����� IS NULL AND �˿����� IS NULL); SELECT �ʵ����, ��ס����, �ͷ����, �ͷ�����, �ͷ�λ��, �ͷ��۸�, �˿�����, ���֤, ��������, ���ѽ��, ��סʱ��, �ۿ�, ��������, ��ע FROM �ʵ���ϸ��ʷ WHERE (�ʵ���� = @�ʵ����)";
			this.sqlUpdateCommand1.Connection = this.conn;
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@�ʵ����", System.Data.SqlDbType.VarChar, 10, "�ʵ����"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@��ס����", System.Data.SqlDbType.VarChar, 10, "��ס����"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@�ͷ����", System.Data.SqlDbType.VarChar, 10, "�ͷ����"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@�ͷ�����", System.Data.SqlDbType.VarChar, 20, "�ͷ�����"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@�ͷ�λ��", System.Data.SqlDbType.VarChar, 10, "�ͷ�λ��"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@�ͷ��۸�", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "�ͷ��۸�", System.Data.DataRowVersion.Current, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@�˿�����", System.Data.SqlDbType.VarChar, 10, "�˿�����"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@���֤", System.Data.SqlDbType.VarChar, 20, "���֤"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@��������", System.Data.SqlDbType.VarChar, 40, "��������"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@���ѽ��", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "���ѽ��", System.Data.DataRowVersion.Current, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@��סʱ��", System.Data.SqlDbType.DateTime, 4, "��סʱ��"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@�ۿ�", System.Data.SqlDbType.Float, 8, "�ۿ�"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@��������", System.Data.SqlDbType.DateTime, 4, "��������"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@��ע", System.Data.SqlDbType.VarChar, 40, "��ע"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_�ʵ����", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "�ʵ����", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_��ס����", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "��ס����", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_��סʱ��", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "��סʱ��", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_��ע", System.Data.SqlDbType.VarChar, 40, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "��ע", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_�ͷ��۸�", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "�ͷ��۸�", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_�ͷ�λ��", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "�ͷ�λ��", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_�ͷ�����", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "�ͷ�����", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_�ͷ����", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "�ͷ����", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_�ۿ�", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "�ۿ�", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_��������", System.Data.SqlDbType.VarChar, 40, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "��������", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_���ѽ��", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "���ѽ��", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_��������", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "��������", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_���֤", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "���֤", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_�˿�����", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "�˿�����", System.Data.DataRowVersion.Original, null));
			// 
			// BillHistoryManagement
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(744, 502);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.label24);
			this.Controls.Add(this.label23);
			this.Controls.Add(this.dataGrid1);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnEnd);
			this.Controls.Add(this.btnNext);
			this.Controls.Add(this.btnBack);
			this.Controls.Add(this.btnFirst);
			this.Controls.Add(this.btnAll);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(752, 536);
			this.MinimumSize = new System.Drawing.Size(752, 536);
			this.Name = "BillHistoryManagement";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "�ʵ���ϸ��ʷ��ѯ";
			this.Load += new System.EventHandler(this.BillHistoryManagement_Load);
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void btnAll_Click(object sender, System.EventArgs e)
		{
			this.sqlSelectCommand1.CommandText = "Select * from �ʵ���ϸ��ʷ";
			ds.Clear();
			da.Fill(this.ds,"�ʵ���ϸ��ʷ");
			bmb = this.BindingContext[ds,"�ʵ���ϸ��ʷ"];
			this.label23.Text = "��ǰ��¼��"+(this.dataGrid1.CurrentRowIndex+1);
			this.label24.Text = "��¼����"+this.bmb.Count;
		}

		private void btnFirst_Click(object sender, System.EventArgs e)
		{
			try
			{
				bmb.Position =0;
				this.label23.Text = "��ǰ��¼��"+(this.dataGrid1.CurrentRowIndex+1);
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
				this.label23.Text = "��ǰ��¼��"+(this.dataGrid1.CurrentRowIndex+1);
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
				this.label23.Text = "��ǰ��¼��"+(this.dataGrid1.CurrentRowIndex+1);
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
				this.label23.Text = "��ǰ��¼��"+(this.dataGrid1.CurrentRowIndex+1);
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
					str = "Select * from �ʵ���ϸ��ʷ where �ʵ���� like '%"+this.textBox1.Text.Trim()+"%'";
					this.sqlSelectCommand1.CommandText = str;
					this.ds.Clear();
					da.Fill(this.ds,"�ʵ���ϸ��ʷ");
					bmb=this.BindingContext[ds,"�ʵ���ϸ��ʷ"];
					this.label23.Text = "��ǰ��¼��"+(this.dataGrid1.CurrentRowIndex+1);
					this.label24.Text = "��¼����"+this.bmb.Count;
		
				}
				if(this.textBox2.Enabled == true && this.textBox2.Text.Trim() != "")
				{
					str = "Select * from �ʵ���ϸ��ʷ where �ͷ���� like '%"+this.textBox2.Text.Trim()+"%'";
					this.sqlSelectCommand1.CommandText = str;
					this.ds.Clear();
					da.Fill(this.ds,"�ʵ���ϸ��ʷ");
					bmb=this.BindingContext[ds,"�ʵ���ϸ��ʷ"];
					this.label23.Text = "��ǰ��¼��"+(this.dataGrid1.CurrentRowIndex+1);
					this.label24.Text = "��¼����"+this.bmb.Count;
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

		private void BillHistoryManagement_Load(object sender, System.EventArgs e)
		{
			this.conn.ConnectionString = Config.Settings.ConnStr;
		}
	}
}
