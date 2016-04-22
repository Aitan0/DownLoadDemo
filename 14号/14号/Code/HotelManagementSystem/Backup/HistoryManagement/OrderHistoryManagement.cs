using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data.SqlClient;
using HotelManagementSystem.Data;
using HotelManagementSystem.Config;

//Ԥ������ʷ��ѯ
namespace HotelManagementSystem.HistoryManagement
{
	/// <summary>
	/// OrderHistoryManagement ��ժҪ˵����
	/// </summary>
	public class OrderHistoryManagement : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.DataGrid dataGrid1;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnEnd;
		private System.Windows.Forms.Button btnNext;
		private System.Windows.Forms.Button btnBack;
		private System.Windows.Forms.Button btnFirst;
		private System.Windows.Forms.Button btnAll;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.Button btnFind;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.TextBox textBox1;
		private HotelManagementSystem.Data.HotelDataSet ds;
		/// <summary>
		/// ����������������
		/// </summary>
		private System.ComponentModel.Container components = null;
		private System.Data.SqlClient.SqlConnection conn;
		private System.Data.SqlClient.SqlDataAdapter da;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
		private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
		private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
		BindingManagerBase bmb;

		public OrderHistoryManagement()
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
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.btnFind = new System.Windows.Forms.Button();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.conn = new System.Data.SqlClient.SqlConnection();
			this.da = new System.Data.SqlClient.SqlDataAdapter();
			this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// label24
			// 
			this.label24.Location = new System.Drawing.Point(626, 40);
			this.label24.Name = "label24";
			this.label24.TabIndex = 66;
			this.label24.Text = "��¼����";
			this.label24.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// label23
			// 
			this.label23.Location = new System.Drawing.Point(18, 40);
			this.label23.Name = "label23";
			this.label23.TabIndex = 65;
			this.label23.Text = "��ǰ��¼��";
			this.label23.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// dataGrid1
			// 
			this.dataGrid1.DataMember = "Ԥ������ʷ";
			this.dataGrid1.DataSource = this.ds;
			this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGrid1.Location = new System.Drawing.Point(16, 64);
			this.dataGrid1.Name = "dataGrid1";
			this.dataGrid1.ReadOnly = true;
			this.dataGrid1.Size = new System.Drawing.Size(712, 328);
			this.dataGrid1.TabIndex = 64;
			// 
			// ds
			// 
			this.ds.DataSetName = "HotelDataSet";
			this.ds.Locale = new System.Globalization.CultureInfo("en-US");
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(535, 24);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.TabIndex = 63;
			this.btnCancel.Text = "�˳�";
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnEnd
			// 
			this.btnEnd.Location = new System.Drawing.Point(454, 24);
			this.btnEnd.Name = "btnEnd";
			this.btnEnd.TabIndex = 62;
			this.btnEnd.Text = "���";
			this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
			// 
			// btnNext
			// 
			this.btnNext.Location = new System.Drawing.Point(373, 24);
			this.btnNext.Name = "btnNext";
			this.btnNext.TabIndex = 61;
			this.btnNext.Text = "��һ��";
			this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
			// 
			// btnBack
			// 
			this.btnBack.Location = new System.Drawing.Point(292, 24);
			this.btnBack.Name = "btnBack";
			this.btnBack.TabIndex = 60;
			this.btnBack.Text = "��һ��";
			this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
			// 
			// btnFirst
			// 
			this.btnFirst.Location = new System.Drawing.Point(211, 24);
			this.btnFirst.Name = "btnFirst";
			this.btnFirst.TabIndex = 59;
			this.btnFirst.Text = "��ǰ";
			this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
			// 
			// btnAll
			// 
			this.btnAll.Location = new System.Drawing.Point(130, 24);
			this.btnAll.Name = "btnAll";
			this.btnAll.TabIndex = 58;
			this.btnAll.Text = "��ѯ����";
			this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.radioButton1);
			this.groupBox2.Controls.Add(this.btnFind);
			this.groupBox2.Controls.Add(this.textBox2);
			this.groupBox2.Controls.Add(this.radioButton2);
			this.groupBox2.Controls.Add(this.textBox1);
			this.groupBox2.Location = new System.Drawing.Point(16, 408);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(712, 64);
			this.groupBox2.TabIndex = 67;
			this.groupBox2.TabStop = false;
			// 
			// radioButton1
			// 
			this.radioButton1.Location = new System.Drawing.Point(16, 27);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(80, 24);
			this.radioButton1.TabIndex = 5;
			this.radioButton1.Text = "Ԥ������";
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
			// da
			// 
			this.da.DeleteCommand = this.sqlDeleteCommand1;
			this.da.InsertCommand = this.sqlInsertCommand1;
			this.da.SelectCommand = this.sqlSelectCommand1;
			this.da.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																						 new System.Data.Common.DataTableMapping("Table", "Ԥ������ʷ", new System.Data.Common.DataColumnMapping[] {
																																																  new System.Data.Common.DataColumnMapping("Ԥ������", "Ԥ������"),
																																																  new System.Data.Common.DataColumnMapping("��Ա���", "��Ա���"),
																																																  new System.Data.Common.DataColumnMapping("�ͷ����", "�ͷ����"),
																																																  new System.Data.Common.DataColumnMapping("�ͷ�����", "�ͷ�����"),
																																																  new System.Data.Common.DataColumnMapping("�ͷ�λ��", "�ͷ�λ��"),
																																																  new System.Data.Common.DataColumnMapping("�ֵ�ʱ��", "�ֵ�ʱ��"),
																																																  new System.Data.Common.DataColumnMapping("���ʱ��", "���ʱ��"),
																																																  new System.Data.Common.DataColumnMapping("����״̬", "����״̬"),
																																																  new System.Data.Common.DataColumnMapping("��ס����", "��ס����"),
																																																  new System.Data.Common.DataColumnMapping("�ͷ��۸�", "�ͷ��۸�"),
																																																  new System.Data.Common.DataColumnMapping("��ס�۸�", "��ס�۸�"),
																																																  new System.Data.Common.DataColumnMapping("�ۿ�", "�ۿ�"),
																																																  new System.Data.Common.DataColumnMapping("�ۿ�ԭ��", "�ۿ�ԭ��"),
																																																  new System.Data.Common.DataColumnMapping("�Ƿ�Ӵ�", "�Ƿ�Ӵ�"),
																																																  new System.Data.Common.DataColumnMapping("�Ӵ��۸�", "�Ӵ��۸�"),
																																																  new System.Data.Common.DataColumnMapping("Ԥ�տ�", "Ԥ�տ�"),
																																																  new System.Data.Common.DataColumnMapping("Ԥ����", "Ԥ����"),
																																																  new System.Data.Common.DataColumnMapping("���֤", "���֤"),
																																																  new System.Data.Common.DataColumnMapping("Ԥ����˾", "Ԥ����˾"),
																																																  new System.Data.Common.DataColumnMapping("��ϵ�绰", "��ϵ�绰"),
																																																  new System.Data.Common.DataColumnMapping("��ע", "��ע"),
																																																  new System.Data.Common.DataColumnMapping("����Ա", "����Ա"),
																																																  new System.Data.Common.DataColumnMapping("ҵ��Ա", "ҵ��Ա")})});
			this.da.UpdateCommand = this.sqlUpdateCommand1;
			// 
			// sqlDeleteCommand1
			// 
			this.sqlDeleteCommand1.CommandText = "DELETE FROM Ԥ������ʷ WHERE (Ԥ������ = @Original_Ԥ������) AND (ҵ��Ա = @Original_ҵ��Ա OR @Orig" +
				"inal_ҵ��Ա IS NULL AND ҵ��Ա IS NULL) AND (��Ա��� = @Original_��Ա��� OR @Original_��Ա��� I" +
				"S NULL AND ��Ա��� IS NULL) AND (��ס���� = @Original_��ס���� OR @Original_��ס���� IS NULL AN" +
				"D ��ס���� IS NULL) AND (��ס�۸� = @Original_��ס�۸� OR @Original_��ס�۸� IS NULL AND ��ס�۸� IS" +
				" NULL) AND (�Ӵ��۸� = @Original_�Ӵ��۸� OR @Original_�Ӵ��۸� IS NULL AND �Ӵ��۸� IS NULL) AN" +
				"D (����״̬ = @Original_����״̬ OR @Original_����״̬ IS NULL AND ����״̬ IS NULL) AND (��ע = @" +
				"Original_��ע OR @Original_��ע IS NULL AND ��ע IS NULL) AND (�ͷ��۸� = @Original_�ͷ��۸� O" +
				"R @Original_�ͷ��۸� IS NULL AND �ͷ��۸� IS NULL) AND (�ͷ�λ�� = @Original_�ͷ�λ�� OR @Origin" +
				"al_�ͷ�λ�� IS NULL AND �ͷ�λ�� IS NULL) AND (�ͷ����� = @Original_�ͷ����� OR @Original_�ͷ����� I" +
				"S NULL AND �ͷ����� IS NULL) AND (�ͷ���� = @Original_�ͷ����) AND (�ۿ� = @Original_�ۿ� OR @" +
				"Original_�ۿ� IS NULL AND �ۿ� IS NULL) AND (�ۿ�ԭ�� = @Original_�ۿ�ԭ�� OR @Original_�ۿ�ԭ��" +
				" IS NULL AND �ۿ�ԭ�� IS NULL) AND (�ֵ�ʱ�� = @Original_�ֵ�ʱ�� OR @Original_�ֵ�ʱ�� IS NULL " +
				"AND �ֵ�ʱ�� IS NULL) AND (����Ա = @Original_����Ա OR @Original_����Ա IS NULL AND ����Ա IS N" +
				"ULL) AND (�Ƿ�Ӵ� = @Original_�Ƿ�Ӵ� OR @Original_�Ƿ�Ӵ� IS NULL AND �Ƿ�Ӵ� IS NULL) AND " +
				"(���ʱ�� = @Original_���ʱ�� OR @Original_���ʱ�� IS NULL AND ���ʱ�� IS NULL) AND (��ϵ�绰 = @" +
				"Original_��ϵ�绰 OR @Original_��ϵ�绰 IS NULL AND ��ϵ�绰 IS NULL) AND (���֤ = @Original_��" +
				"��֤ OR @Original_���֤ IS NULL AND ���֤ IS NULL) AND (Ԥ�տ� = @Original_Ԥ�տ� OR @Origin" +
				"al_Ԥ�տ� IS NULL AND Ԥ�տ� IS NULL) AND (Ԥ���� = @Original_Ԥ���� OR @Original_Ԥ���� IS NUL" +
				"L AND Ԥ���� IS NULL) AND (Ԥ����˾ = @Original_Ԥ����˾ OR @Original_Ԥ����˾ IS NULL AND Ԥ����˾" +
				" IS NULL)";
			this.sqlDeleteCommand1.Connection = this.conn;
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Ԥ������", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Ԥ������", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_ҵ��Ա", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ҵ��Ա", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_��Ա���", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "��Ա���", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_��ס����", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "��ס����", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_��ס�۸�", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "��ס�۸�", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_�Ӵ��۸�", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "�Ӵ��۸�", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_����״̬", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "����״̬", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_��ע", System.Data.SqlDbType.VarChar, 40, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "��ע", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_�ͷ��۸�", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "�ͷ��۸�", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_�ͷ�λ��", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "�ͷ�λ��", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_�ͷ�����", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "�ͷ�����", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_�ͷ����", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "�ͷ����", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_�ۿ�", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "�ۿ�", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_�ۿ�ԭ��", System.Data.SqlDbType.VarChar, 40, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "�ۿ�ԭ��", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_�ֵ�ʱ��", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "�ֵ�ʱ��", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_����Ա", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "����Ա", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_�Ƿ�Ӵ�", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "�Ƿ�Ӵ�", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_���ʱ��", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "���ʱ��", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_��ϵ�绰", System.Data.SqlDbType.VarChar, 13, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "��ϵ�绰", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_���֤", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "���֤", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Ԥ�տ�", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "Ԥ�տ�", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Ԥ����", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Ԥ����", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Ԥ����˾", System.Data.SqlDbType.VarChar, 40, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Ԥ����˾", System.Data.DataRowVersion.Original, null));
			// 
			// sqlInsertCommand1
			// 
			this.sqlInsertCommand1.CommandText = @"INSERT INTO Ԥ������ʷ(Ԥ������, ��Ա���, �ͷ����, �ͷ�����, �ͷ�λ��, �ֵ�ʱ��, ���ʱ��, ����״̬, ��ס����, �ͷ��۸�, ��ס�۸�, �ۿ�, �ۿ�ԭ��, �Ƿ�Ӵ�, �Ӵ��۸�, Ԥ�տ�, Ԥ����, ���֤, Ԥ����˾, ��ϵ�绰, ��ע, ����Ա, ҵ��Ա) VALUES (@Ԥ������, @��Ա���, @�ͷ����, @�ͷ�����, @�ͷ�λ��, @�ֵ�ʱ��, @���ʱ��, @����״̬, @��ס����, @�ͷ��۸�, @��ס�۸�, @�ۿ�, @�ۿ�ԭ��, @�Ƿ�Ӵ�, @�Ӵ��۸�, @Ԥ�տ�, @Ԥ����, @���֤, @Ԥ����˾, @��ϵ�绰, @��ע, @����Ա, @ҵ��Ա); SELECT Ԥ������, ��Ա���, �ͷ����, �ͷ�����, �ͷ�λ��, �ֵ�ʱ��, ���ʱ��, ����״̬, ��ס����, �ͷ��۸�, ��ס�۸�, �ۿ�, �ۿ�ԭ��, �Ƿ�Ӵ�, �Ӵ��۸�, Ԥ�տ�, Ԥ����, ���֤, Ԥ����˾, ��ϵ�绰, ��ע, ����Ա, ҵ��Ա FROM Ԥ������ʷ WHERE (Ԥ������ = @Ԥ������)";
			this.sqlInsertCommand1.Connection = this.conn;
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Ԥ������", System.Data.SqlDbType.VarChar, 10, "Ԥ������"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@��Ա���", System.Data.SqlDbType.VarChar, 10, "��Ա���"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@�ͷ����", System.Data.SqlDbType.VarChar, 10, "�ͷ����"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@�ͷ�����", System.Data.SqlDbType.VarChar, 20, "�ͷ�����"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@�ͷ�λ��", System.Data.SqlDbType.VarChar, 10, "�ͷ�λ��"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@�ֵ�ʱ��", System.Data.SqlDbType.DateTime, 4, "�ֵ�ʱ��"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@���ʱ��", System.Data.SqlDbType.DateTime, 4, "���ʱ��"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@����״̬", System.Data.SqlDbType.VarChar, 10, "����״̬"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@��ס����", System.Data.SqlDbType.Int, 4, "��ס����"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@�ͷ��۸�", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "�ͷ��۸�", System.Data.DataRowVersion.Current, null));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@��ס�۸�", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "��ס�۸�", System.Data.DataRowVersion.Current, null));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@�ۿ�", System.Data.SqlDbType.Float, 8, "�ۿ�"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@�ۿ�ԭ��", System.Data.SqlDbType.VarChar, 40, "�ۿ�ԭ��"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@�Ƿ�Ӵ�", System.Data.SqlDbType.Bit, 1, "�Ƿ�Ӵ�"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@�Ӵ��۸�", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "�Ӵ��۸�", System.Data.DataRowVersion.Current, null));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Ԥ�տ�", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "Ԥ�տ�", System.Data.DataRowVersion.Current, null));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Ԥ����", System.Data.SqlDbType.VarChar, 10, "Ԥ����"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@���֤", System.Data.SqlDbType.VarChar, 20, "���֤"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Ԥ����˾", System.Data.SqlDbType.VarChar, 40, "Ԥ����˾"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@��ϵ�绰", System.Data.SqlDbType.VarChar, 13, "��ϵ�绰"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@��ע", System.Data.SqlDbType.VarChar, 40, "��ע"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@����Ա", System.Data.SqlDbType.VarChar, 10, "����Ա"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ҵ��Ա", System.Data.SqlDbType.VarChar, 10, "ҵ��Ա"));
			// 
			// sqlSelectCommand1
			// 
			this.sqlSelectCommand1.CommandText = "SELECT Ԥ������, ��Ա���, �ͷ����, �ͷ�����, �ͷ�λ��, �ֵ�ʱ��, ���ʱ��, ����״̬, ��ס����, �ͷ��۸�, ��ס�۸�, �ۿ�, �ۿ�ԭ��" +
				", �Ƿ�Ӵ�, �Ӵ��۸�, Ԥ�տ�, Ԥ����, ���֤, Ԥ����˾, ��ϵ�绰, ��ע, ����Ա, ҵ��Ա FROM Ԥ������ʷ";
			this.sqlSelectCommand1.Connection = this.conn;
			// 
			// sqlUpdateCommand1
			// 
			this.sqlUpdateCommand1.CommandText = "UPDATE Ԥ������ʷ SET Ԥ������ = @Ԥ������, ��Ա��� = @��Ա���, �ͷ���� = @�ͷ����, �ͷ����� = @�ͷ�����, �ͷ�λ�� = @" +
				"�ͷ�λ��, �ֵ�ʱ�� = @�ֵ�ʱ��, ���ʱ�� = @���ʱ��, ����״̬ = @����״̬, ��ס���� = @��ס����, �ͷ��۸� = @�ͷ��۸�, ��ס�۸�" +
				" = @��ס�۸�, �ۿ� = @�ۿ�, �ۿ�ԭ�� = @�ۿ�ԭ��, �Ƿ�Ӵ� = @�Ƿ�Ӵ�, �Ӵ��۸� = @�Ӵ��۸�, Ԥ�տ� = @Ԥ�տ�, Ԥ���� = " +
				"@Ԥ����, ���֤ = @���֤, Ԥ����˾ = @Ԥ����˾, ��ϵ�绰 = @��ϵ�绰, ��ע = @��ע, ����Ա = @����Ա, ҵ��Ա = @ҵ��Ա W" +
				"HERE (Ԥ������ = @Original_Ԥ������) AND (ҵ��Ա = @Original_ҵ��Ա OR @Original_ҵ��Ա IS NULL A" +
				"ND ҵ��Ա IS NULL) AND (��Ա��� = @Original_��Ա��� OR @Original_��Ա��� IS NULL AND ��Ա��� IS" +
				" NULL) AND (��ס���� = @Original_��ס���� OR @Original_��ס���� IS NULL AND ��ס���� IS NULL) AN" +
				"D (��ס�۸� = @Original_��ס�۸� OR @Original_��ס�۸� IS NULL AND ��ס�۸� IS NULL) AND (�Ӵ��۸� =" +
				" @Original_�Ӵ��۸� OR @Original_�Ӵ��۸� IS NULL AND �Ӵ��۸� IS NULL) AND (����״̬ = @Origina" +
				"l_����״̬ OR @Original_����״̬ IS NULL AND ����״̬ IS NULL) AND (��ע = @Original_��ע OR @Or" +
				"iginal_��ע IS NULL AND ��ע IS NULL) AND (�ͷ��۸� = @Original_�ͷ��۸� OR @Original_�ͷ��۸� I" +
				"S NULL AND �ͷ��۸� IS NULL) AND (�ͷ�λ�� = @Original_�ͷ�λ�� OR @Original_�ͷ�λ�� IS NULL AN" +
				"D �ͷ�λ�� IS NULL) AND (�ͷ����� = @Original_�ͷ����� OR @Original_�ͷ����� IS NULL AND �ͷ����� IS" +
				" NULL) AND (�ͷ���� = @Original_�ͷ����) AND (�ۿ� = @Original_�ۿ� OR @Original_�ۿ� IS NUL" +
				"L AND �ۿ� IS NULL) AND (�ۿ�ԭ�� = @Original_�ۿ�ԭ�� OR @Original_�ۿ�ԭ�� IS NULL AND �ۿ�ԭ�� " +
				"IS NULL) AND (�ֵ�ʱ�� = @Original_�ֵ�ʱ�� OR @Original_�ֵ�ʱ�� IS NULL AND �ֵ�ʱ�� IS NULL) " +
				"AND (����Ա = @Original_����Ա OR @Original_����Ա IS NULL AND ����Ա IS NULL) AND (�Ƿ�Ӵ� = @" +
				"Original_�Ƿ�Ӵ� OR @Original_�Ƿ�Ӵ� IS NULL AND �Ƿ�Ӵ� IS NULL) AND (���ʱ�� = @Original_" +
				"���ʱ�� OR @Original_���ʱ�� IS NULL AND ���ʱ�� IS NULL) AND (��ϵ�绰 = @Original_��ϵ�绰 OR @" +
				"Original_��ϵ�绰 IS NULL AND ��ϵ�绰 IS NULL) AND (���֤ = @Original_���֤ OR @Original_���" +
				"֤ IS NULL AND ���֤ IS NULL) AND (Ԥ�տ� = @Original_Ԥ�տ� OR @Original_Ԥ�տ� IS NULL AND" +
				" Ԥ�տ� IS NULL) AND (Ԥ���� = @Original_Ԥ���� OR @Original_Ԥ���� IS NULL AND Ԥ���� IS NULL)" +
				" AND (Ԥ����˾ = @Original_Ԥ����˾ OR @Original_Ԥ����˾ IS NULL AND Ԥ����˾ IS NULL); SELECT " +
				"Ԥ������, ��Ա���, �ͷ����, �ͷ�����, �ͷ�λ��, �ֵ�ʱ��, ���ʱ��, ����״̬, ��ס����, �ͷ��۸�, ��ס�۸�, �ۿ�, �ۿ�ԭ��, �Ƿ�Ӵ�" +
				", �Ӵ��۸�, Ԥ�տ�, Ԥ����, ���֤, Ԥ����˾, ��ϵ�绰, ��ע, ����Ա, ҵ��Ա FROM Ԥ������ʷ WHERE (Ԥ������ = @Ԥ������)";
			this.sqlUpdateCommand1.Connection = this.conn;
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Ԥ������", System.Data.SqlDbType.VarChar, 10, "Ԥ������"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@��Ա���", System.Data.SqlDbType.VarChar, 10, "��Ա���"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@�ͷ����", System.Data.SqlDbType.VarChar, 10, "�ͷ����"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@�ͷ�����", System.Data.SqlDbType.VarChar, 20, "�ͷ�����"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@�ͷ�λ��", System.Data.SqlDbType.VarChar, 10, "�ͷ�λ��"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@�ֵ�ʱ��", System.Data.SqlDbType.DateTime, 4, "�ֵ�ʱ��"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@���ʱ��", System.Data.SqlDbType.DateTime, 4, "���ʱ��"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@����״̬", System.Data.SqlDbType.VarChar, 10, "����״̬"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@��ס����", System.Data.SqlDbType.Int, 4, "��ס����"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@�ͷ��۸�", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "�ͷ��۸�", System.Data.DataRowVersion.Current, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@��ס�۸�", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "��ס�۸�", System.Data.DataRowVersion.Current, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@�ۿ�", System.Data.SqlDbType.Float, 8, "�ۿ�"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@�ۿ�ԭ��", System.Data.SqlDbType.VarChar, 40, "�ۿ�ԭ��"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@�Ƿ�Ӵ�", System.Data.SqlDbType.Bit, 1, "�Ƿ�Ӵ�"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@�Ӵ��۸�", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "�Ӵ��۸�", System.Data.DataRowVersion.Current, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Ԥ�տ�", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "Ԥ�տ�", System.Data.DataRowVersion.Current, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Ԥ����", System.Data.SqlDbType.VarChar, 10, "Ԥ����"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@���֤", System.Data.SqlDbType.VarChar, 20, "���֤"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Ԥ����˾", System.Data.SqlDbType.VarChar, 40, "Ԥ����˾"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@��ϵ�绰", System.Data.SqlDbType.VarChar, 13, "��ϵ�绰"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@��ע", System.Data.SqlDbType.VarChar, 40, "��ע"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@����Ա", System.Data.SqlDbType.VarChar, 10, "����Ա"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ҵ��Ա", System.Data.SqlDbType.VarChar, 10, "ҵ��Ա"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Ԥ������", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Ԥ������", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_ҵ��Ա", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ҵ��Ա", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_��Ա���", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "��Ա���", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_��ס����", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "��ס����", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_��ס�۸�", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "��ס�۸�", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_�Ӵ��۸�", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "�Ӵ��۸�", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_����״̬", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "����״̬", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_��ע", System.Data.SqlDbType.VarChar, 40, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "��ע", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_�ͷ��۸�", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "�ͷ��۸�", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_�ͷ�λ��", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "�ͷ�λ��", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_�ͷ�����", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "�ͷ�����", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_�ͷ����", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "�ͷ����", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_�ۿ�", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "�ۿ�", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_�ۿ�ԭ��", System.Data.SqlDbType.VarChar, 40, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "�ۿ�ԭ��", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_�ֵ�ʱ��", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "�ֵ�ʱ��", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_����Ա", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "����Ա", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_�Ƿ�Ӵ�", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "�Ƿ�Ӵ�", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_���ʱ��", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "���ʱ��", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_��ϵ�绰", System.Data.SqlDbType.VarChar, 13, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "��ϵ�绰", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_���֤", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "���֤", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Ԥ�տ�", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "Ԥ�տ�", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Ԥ����", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Ԥ����", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Ԥ����˾", System.Data.SqlDbType.VarChar, 40, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Ԥ����˾", System.Data.DataRowVersion.Original, null));
			// 
			// OrderHistoryManagement
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(744, 494);
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
			this.MaximumSize = new System.Drawing.Size(752, 528);
			this.MinimumSize = new System.Drawing.Size(752, 528);
			this.Name = "OrderHistoryManagement";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Ԥ������ʷ��ѯ";
			this.Load += new System.EventHandler(this.OrderHistoryManagement_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void btnAll_Click(object sender, System.EventArgs e)
		{
			this.sqlSelectCommand1.CommandText = "Select * from Ԥ������ʷ";
			ds.Clear();
			da.Fill(this.ds,"Ԥ������ʷ");
			bmb = this.BindingContext[ds,"Ԥ������ʷ"];
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
					str = "Select * from Ԥ������ʷ where Ԥ������ like '%"+this.textBox1.Text.Trim()+"%'";
					this.sqlSelectCommand1.CommandText = str;
					this.ds.Clear();
					da.Fill(this.ds,"Ԥ������ʷ");
					bmb=this.BindingContext[ds,"Ԥ������ʷ"];
					this.label23.Text = "��ǰ��¼��"+(this.dataGrid1.CurrentRowIndex+1);
					this.label24.Text = "��¼����"+this.bmb.Count;
		
				}
				if(this.textBox2.Enabled == true && this.textBox2.Text.Trim() != "")
				{
					str = "Select * from Ԥ������ʷ where �ͷ���� like '%"+this.textBox2.Text.Trim()+"%'";
					this.sqlSelectCommand1.CommandText = str;
					this.ds.Clear();
					da.Fill(this.ds,"Ԥ������ʷ");
					bmb=this.BindingContext[ds,"Ԥ������ʷ"];
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

		private void OrderHistoryManagement_Load(object sender, System.EventArgs e)
		{
			this.conn.ConnectionString = Config.Settings.ConnStr;
		}
	}
}
