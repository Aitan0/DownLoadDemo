using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data.SqlClient;
using HotelManagementSystem.Data;
using HotelManagementSystem.Config;
//�ͷ���׼�޸�
namespace HotelManagementSystem.RoomStandardManagement
{
	/// <summary>
	/// ChangeRoomStandardManagement ��ժҪ˵����
	/// </summary>
	public class ChangeRoomStandardManagement : System.Windows.Forms.Form
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
		private System.Windows.Forms.CheckBox checkBox4;
		private System.Windows.Forms.CheckBox checkBox3;
		private System.Windows.Forms.CheckBox checkBox2;
		private System.Windows.Forms.CheckBox checkBox1;
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
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.CheckBox checkBox5;
		protected BindingManagerBase bmb;

		public ChangeRoomStandardManagement()
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
			this.checkBox4 = new System.Windows.Forms.CheckBox();
			this.checkBox3 = new System.Windows.Forms.CheckBox();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
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
			this.conn = new System.Data.SqlClient.SqlConnection();
			this.da = new System.Data.SqlClient.SqlDataAdapter();
			this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.checkBox5 = new System.Windows.Forms.CheckBox();
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
			this.groupBox2.Location = new System.Drawing.Point(57, 400);
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
			this.radioButton2.Text = "�ͷ�����";
			this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
			// 
			// radioButton1
			// 
			this.radioButton1.Location = new System.Drawing.Point(24, 24);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(73, 24);
			this.radioButton1.TabIndex = 9;
			this.radioButton1.Text = "���ͱ��";
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
			this.btnFind.Text = "��ѯ";
			this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(490, 32);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.TabIndex = 36;
			this.btnCancel.Text = "�˳�";
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnEnd
			// 
			this.btnEnd.Location = new System.Drawing.Point(415, 32);
			this.btnEnd.Name = "btnEnd";
			this.btnEnd.TabIndex = 35;
			this.btnEnd.Text = "���";
			this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
			// 
			// btnNext
			// 
			this.btnNext.Location = new System.Drawing.Point(340, 32);
			this.btnNext.Name = "btnNext";
			this.btnNext.TabIndex = 34;
			this.btnNext.Text = "��һ��";
			this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
			// 
			// btnBack
			// 
			this.btnBack.Location = new System.Drawing.Point(265, 32);
			this.btnBack.Name = "btnBack";
			this.btnBack.TabIndex = 33;
			this.btnBack.Text = "��һ��";
			this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
			// 
			// btnFirst
			// 
			this.btnFirst.Location = new System.Drawing.Point(190, 32);
			this.btnFirst.Name = "btnFirst";
			this.btnFirst.TabIndex = 32;
			this.btnFirst.Text = "��ǰ";
			this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
			// 
			// btnAll
			// 
			this.btnAll.Location = new System.Drawing.Point(115, 32);
			this.btnAll.Name = "btnAll";
			this.btnAll.TabIndex = 31;
			this.btnAll.Text = "��ѯ����";
			this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
			// 
			// dataGrid1
			// 
			this.dataGrid1.DataMember = "�ͷ���׼��Ϣ";
			this.dataGrid1.DataSource = this.ds;
			this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGrid1.Location = new System.Drawing.Point(57, 72);
			this.dataGrid1.Name = "dataGrid1";
			this.dataGrid1.ReadOnly = true;
			this.dataGrid1.Size = new System.Drawing.Size(576, 150);
			this.dataGrid1.TabIndex = 30;
			// 
			// ds
			// 
			this.ds.DataSetName = "HotelDataSet";
			this.ds.Locale = new System.Globalization.CultureInfo("en-US");
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.checkBox4);
			this.groupBox1.Controls.Add(this.checkBox3);
			this.groupBox1.Controls.Add(this.checkBox2);
			this.groupBox1.Controls.Add(this.checkBox1);
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
			this.groupBox1.Enabled = false;
			this.groupBox1.Location = new System.Drawing.Point(57, 256);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(576, 144);
			this.groupBox1.TabIndex = 29;
			this.groupBox1.TabStop = false;
			// 
			// checkBox4
			// 
			this.checkBox4.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.ds, "�ͷ���׼��Ϣ.����������"));
			this.checkBox4.Location = new System.Drawing.Point(456, 112);
			this.checkBox4.Name = "checkBox4";
			this.checkBox4.TabIndex = 35;
			this.checkBox4.Text = "����������";
			// 
			// checkBox3
			// 
			this.checkBox3.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.ds, "�ͷ���׼��Ϣ.�绰"));
			this.checkBox3.Location = new System.Drawing.Point(304, 112);
			this.checkBox3.Name = "checkBox3";
			this.checkBox3.TabIndex = 34;
			this.checkBox3.Text = "�绰";
			// 
			// checkBox2
			// 
			this.checkBox2.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.ds, "�ͷ���׼��Ϣ.���ӻ�"));
			this.checkBox2.Location = new System.Drawing.Point(456, 88);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.TabIndex = 33;
			this.checkBox2.Text = "���ӻ�";
			// 
			// checkBox1
			// 
			this.checkBox1.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.ds, "�ͷ���׼��Ϣ.�յ�"));
			this.checkBox1.Location = new System.Drawing.Point(304, 88);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.TabIndex = 32;
			this.checkBox1.Text = "�յ�";
			// 
			// txtPrice
			// 
			this.txtPrice.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ds, "�ͷ���׼��Ϣ.�ͷ��۸�"));
			this.txtPrice.Location = new System.Drawing.Point(400, 62);
			this.txtPrice.Name = "txtPrice";
			this.txtPrice.Size = new System.Drawing.Size(152, 21);
			this.txtPrice.TabIndex = 31;
			this.txtPrice.Text = "";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(288, 62);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(104, 23);
			this.label5.TabIndex = 30;
			this.label5.Text = "�ͷ��۸�";
			// 
			// txtNum
			// 
			this.txtNum.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ds, "�ͷ���׼��Ϣ.��λ����"));
			this.txtNum.Location = new System.Drawing.Point(400, 23);
			this.txtNum.Name = "txtNum";
			this.txtNum.Size = new System.Drawing.Size(152, 21);
			this.txtNum.TabIndex = 29;
			this.txtNum.Text = "";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(288, 25);
			this.label4.Name = "label4";
			this.label4.TabIndex = 28;
			this.label4.Text = "��λ����";
			// 
			// txtArea
			// 
			this.txtArea.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ds, "�ͷ���׼��Ϣ.�ͷ�����"));
			this.txtArea.Location = new System.Drawing.Point(120, 64);
			this.txtArea.Name = "txtArea";
			this.txtArea.Size = new System.Drawing.Size(152, 21);
			this.txtArea.TabIndex = 27;
			this.txtArea.Text = "";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(8, 106);
			this.label3.Name = "label3";
			this.label3.TabIndex = 26;
			this.label3.Text = "�������";
			// 
			// txtname
			// 
			this.txtname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ds, "�ͷ���׼��Ϣ.�������"));
			this.txtname.Location = new System.Drawing.Point(120, 104);
			this.txtname.Name = "txtname";
			this.txtname.Size = new System.Drawing.Size(152, 21);
			this.txtname.TabIndex = 25;
			this.txtname.Text = "";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(8, 66);
			this.label2.Name = "label2";
			this.label2.TabIndex = 24;
			this.label2.Text = "�ͷ�����";
			// 
			// txtID
			// 
			this.txtID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ds, "�ͷ���׼��Ϣ.���ͱ��"));
			this.txtID.Location = new System.Drawing.Point(120, 24);
			this.txtID.Name = "txtID";
			this.txtID.Size = new System.Drawing.Size(152, 21);
			this.txtID.TabIndex = 23;
			this.txtID.Text = "";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 24);
			this.label1.TabIndex = 22;
			this.label1.Text = "���ͱ��";
			// 
			// conn
			// 
			this.conn.ConnectionString = Config.Settings.ConnStr;
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
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(544, 232);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.TabIndex = 38;
			this.btnDelete.Text = "ɾ��";
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnSave
			// 
			this.btnSave.Enabled = false;
			this.btnSave.Location = new System.Drawing.Point(120, 232);
			this.btnSave.Name = "btnSave";
			this.btnSave.TabIndex = 39;
			this.btnSave.Text = "����";
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(8, 48);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(104, 23);
			this.label6.TabIndex = 42;
			this.label6.Text = "��ǰ��¼��";
			this.label6.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(568, 47);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(104, 23);
			this.label7.TabIndex = 43;
			this.label7.Text = "��¼����";
			this.label7.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// checkBox5
			// 
			this.checkBox5.Location = new System.Drawing.Point(56, 232);
			this.checkBox5.Name = "checkBox5";
			this.checkBox5.Size = new System.Drawing.Size(56, 24);
			this.checkBox5.TabIndex = 44;
			this.checkBox5.Text = "�޸�";
			this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
			// 
			// ChangeRoomStandardManagement
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(692, 486);
			this.Controls.Add(this.checkBox5);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.btnDelete);
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
			this.MaximumSize = new System.Drawing.Size(700, 520);
			this.MinimumSize = new System.Drawing.Size(700, 520);
			this.Name = "ChangeRoomStandardManagement";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "�ͷ���׼�޸�";
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void btnAll_Click(object sender, System.EventArgs e)
		{
			this.sqlSelectCommand1.CommandText = "Select * from �ͷ���׼��Ϣ";
			this.ds.Clear();
		    da.Fill(ds,"�ͷ���׼��Ϣ");
			bmb = this.BindingContext[ds,"�ͷ���׼��Ϣ"];
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
				if(bmb.Position != 0)
					bmb.Position -= 1;
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
				if(bmb.Position != bmb.Count)
					bmb.Position +=1 ;
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

		private void btnSave_Click(object sender, System.EventArgs e)
		{
			try
			{
				bmb.EndCurrentEdit();
				da.Update(ds,"�ͷ���׼��Ϣ");
				ds.Clear();
				da.Fill(ds,"�ͷ���׼��Ϣ");
				bmb = this.BindingContext[ds,"�ͷ���׼��Ϣ"];
				this.label6.Text = "��ǰ��¼��"+(this.dataGrid1.CurrentRowIndex+1);
				this.label7.Text = "��¼����"+this.bmb.Count;
				MessageBox.Show("��¼�޸ĳɹ�");
			}
			catch(Exception ex)
			{
				MessageBox.Show("�޸�ʧ��:"+ex.Message.ToString());
			}

		}

		private void btnDelete_Click(object sender, System.EventArgs e)
		{
			try
			{
				if(DialogResult.OK == MessageBox.Show("ȷ��ɾ����¼?","ȷ��",MessageBoxButtons.OKCancel,MessageBoxIcon.Question))
				{
					this.ds.�ͷ���׼��Ϣ.Rows[this.bmb.Position].Delete();
					da.Update(ds,"�ͷ���׼��Ϣ");
					ds.Clear();
					da.Fill(ds,"�ͷ���׼��Ϣ");
					bmb = this.BindingContext[ds,"�ͷ���׼��Ϣ"];
					this.label6.Text = "��ǰ��¼��"+(this.dataGrid1.CurrentRowIndex+1);
					this.label7.Text = "��¼����"+this.bmb.Count;
					MessageBox.Show("��¼ɾ���ɹ�");
				}
				else
				{

				}
			}
			catch(Exception ex)
			{
				MessageBox.Show("ɾ����Ч:"+ex.Message.ToString());
			}
		}

		private void checkBox5_CheckedChanged(object sender, System.EventArgs e)
		{
			if(this.checkBox5.Checked ==true)
			{
				this.groupBox1.Enabled = true;
				this.btnSave.Enabled = true;
			}
			else
			{
				this.groupBox1.Enabled = false;
				this.btnSave.Enabled = false;
				this.ds.RejectChanges();
			}
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
					str = "Select * from �ͷ���׼��Ϣ where ���ͱ��  like '%"+this.textBox1.Text.Trim()+"%'";
					this.sqlSelectCommand1.CommandText = str;
					this.ds.Clear();
					da.Fill(this.ds,"�ͷ���׼��Ϣ");
					bmb=this.BindingContext[ds,"�ͷ���׼��Ϣ"];
					this.label6.Text = "��ǰ��¼��"+(this.dataGrid1.CurrentRowIndex+1);
					this.label7.Text = "��¼����"+this.bmb.Count;
				}
				if(this.textBox2.Enabled == true && this.textBox2.Text.Trim() != "")
				{
					str = "Select * from �ͷ���׼��Ϣ where �ͷ����� like '%"+this.textBox2.Text.Trim()+"%'";
					this.sqlSelectCommand1.CommandText = str;
					this.ds.Clear();
					da.Fill(this.ds,"�ͷ���׼��Ϣ");
					bmb=this.BindingContext[ds,"�ͷ���׼��Ϣ"];
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
	}
}
