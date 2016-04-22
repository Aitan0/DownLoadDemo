using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data.SqlClient;
using HotelManagementSystem.Data;
using HotelManagementSystem.Config;
//�ͷ���Ϣ�޸�
namespace HotelManagementSystem.RoomInfoManagement
{
	/// <summary>
	/// ChangeRoomInfoManagement ��ժҪ˵����
	/// </summary>
	public class ChangeRoomInfoManagement : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox textBox2;
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
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.TextBox txtState;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtSay;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtBedNum;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtNum;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtPlace;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtRoomType;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtTypeID;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtRoomID;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.CheckBox checkBox2;
		private HotelManagementSystem.Data.HotelDataSet ds;
		private System.Data.SqlClient.SqlConnection conn;
		private System.Data.SqlClient.SqlDataAdapter da;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
		private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
		private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnDelete;
		/// <summary>
		/// ����������������
		/// </summary>
		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.RadioButton radioButton1;
		protected BindingManagerBase bmb;

		public ChangeRoomInfoManagement()
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
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.textBox2 = new System.Windows.Forms.TextBox();
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
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
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
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.radioButton2);
			this.groupBox2.Controls.Add(this.radioButton1);
			this.groupBox2.Controls.Add(this.textBox2);
			this.groupBox2.Controls.Add(this.textBox1);
			this.groupBox2.Controls.Add(this.btnFind);
			this.groupBox2.Location = new System.Drawing.Point(56, 432);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(576, 64);
			this.groupBox2.TabIndex = 46;
			this.groupBox2.TabStop = false;
			// 
			// radioButton2
			// 
			this.radioButton2.Location = new System.Drawing.Point(248, 24);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(73, 24);
			this.radioButton2.TabIndex = 13;
			this.radioButton2.Text = "�ͷ�����";
			this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
			// 
			// radioButton1
			// 
			this.radioButton1.Location = new System.Drawing.Point(24, 24);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(73, 24);
			this.radioButton1.TabIndex = 12;
			this.radioButton1.Text = "�ͷ����";
			this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
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
			// textBox1
			// 
			this.textBox1.Enabled = false;
			this.textBox1.Location = new System.Drawing.Point(104, 24);
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
			this.btnCancel.Location = new System.Drawing.Point(495, 32);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.TabIndex = 45;
			this.btnCancel.Text = "�˳�";
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnEnd
			// 
			this.btnEnd.Location = new System.Drawing.Point(420, 32);
			this.btnEnd.Name = "btnEnd";
			this.btnEnd.TabIndex = 44;
			this.btnEnd.Text = "���";
			this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
			// 
			// btnNext
			// 
			this.btnNext.Location = new System.Drawing.Point(345, 32);
			this.btnNext.Name = "btnNext";
			this.btnNext.TabIndex = 43;
			this.btnNext.Text = "��һ��";
			this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
			// 
			// btnBack
			// 
			this.btnBack.Location = new System.Drawing.Point(270, 32);
			this.btnBack.Name = "btnBack";
			this.btnBack.TabIndex = 42;
			this.btnBack.Text = "��һ��";
			this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
			// 
			// btnFirst
			// 
			this.btnFirst.Location = new System.Drawing.Point(195, 32);
			this.btnFirst.Name = "btnFirst";
			this.btnFirst.TabIndex = 41;
			this.btnFirst.Text = "��ǰ";
			this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
			// 
			// btnAll
			// 
			this.btnAll.Location = new System.Drawing.Point(120, 32);
			this.btnAll.Name = "btnAll";
			this.btnAll.TabIndex = 40;
			this.btnAll.Text = "��ѯ����";
			this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
			// 
			// dataGrid1
			// 
			this.dataGrid1.DataMember = "�ͷ���Ϣ";
			this.dataGrid1.DataSource = this.ds;
			this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGrid1.Location = new System.Drawing.Point(56, 72);
			this.dataGrid1.Name = "dataGrid1";
			this.dataGrid1.ReadOnly = true;
			this.dataGrid1.Size = new System.Drawing.Size(576, 151);
			this.dataGrid1.TabIndex = 39;
			// 
			// ds
			// 
			this.ds.DataSetName = "HotelDataSet";
			this.ds.Locale = new System.Globalization.CultureInfo("en-US");
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
			this.groupBox1.Enabled = false;
			this.groupBox1.Location = new System.Drawing.Point(56, 261);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(576, 168);
			this.groupBox1.TabIndex = 38;
			this.groupBox1.TabStop = false;
			// 
			// checkBox1
			// 
			this.checkBox1.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.ds, "�ͷ���Ϣ.�Ƿ��ƴ��"));
			this.checkBox1.Location = new System.Drawing.Point(384, 120);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.TabIndex = 33;
			this.checkBox1.Text = "�Ƿ��ƴ��";
			// 
			// txtState
			// 
			this.txtState.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ds, "�ͷ���Ϣ.״̬"));
			this.txtState.Location = new System.Drawing.Point(384, 80);
			this.txtState.Name = "txtState";
			this.txtState.Size = new System.Drawing.Size(168, 21);
			this.txtState.TabIndex = 32;
			this.txtState.Text = "";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(296, 80);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(72, 23);
			this.label8.TabIndex = 31;
			this.label8.Text = "״̬";
			// 
			// txtSay
			// 
			this.txtSay.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ds, "�ͷ���Ϣ.�ͷ�����"));
			this.txtSay.Location = new System.Drawing.Point(384, 48);
			this.txtSay.Name = "txtSay";
			this.txtSay.Size = new System.Drawing.Size(168, 21);
			this.txtSay.TabIndex = 30;
			this.txtSay.Text = "";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(296, 48);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(72, 23);
			this.label7.TabIndex = 29;
			this.label7.Text = "�ͷ�����";
			// 
			// txtBedNum
			// 
			this.txtBedNum.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ds, "�ͷ���Ϣ.����"));
			this.txtBedNum.Location = new System.Drawing.Point(384, 16);
			this.txtBedNum.Name = "txtBedNum";
			this.txtBedNum.Size = new System.Drawing.Size(168, 21);
			this.txtBedNum.TabIndex = 28;
			this.txtBedNum.Text = "";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(296, 16);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(72, 23);
			this.label6.TabIndex = 27;
			this.label6.Text = "����";
			// 
			// txtNum
			// 
			this.txtNum.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ds, "�ͷ���Ϣ.�����"));
			this.txtNum.Location = new System.Drawing.Point(104, 136);
			this.txtNum.Name = "txtNum";
			this.txtNum.Size = new System.Drawing.Size(168, 21);
			this.txtNum.TabIndex = 26;
			this.txtNum.Text = "";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(16, 136);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(72, 23);
			this.label5.TabIndex = 25;
			this.label5.Text = "�����";
			// 
			// txtPlace
			// 
			this.txtPlace.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ds, "�ͷ���Ϣ.�ͷ�λ��"));
			this.txtPlace.Location = new System.Drawing.Point(104, 109);
			this.txtPlace.Name = "txtPlace";
			this.txtPlace.Size = new System.Drawing.Size(168, 21);
			this.txtPlace.TabIndex = 24;
			this.txtPlace.Text = "";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(16, 112);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(72, 24);
			this.label4.TabIndex = 23;
			this.label4.Text = "�ͷ�λ��";
			// 
			// txtRoomType
			// 
			this.txtRoomType.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ds, "�ͷ���Ϣ.�ͷ�����"));
			this.txtRoomType.Location = new System.Drawing.Point(104, 77);
			this.txtRoomType.Name = "txtRoomType";
			this.txtRoomType.Size = new System.Drawing.Size(168, 21);
			this.txtRoomType.TabIndex = 22;
			this.txtRoomType.Text = "";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(16, 80);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(72, 24);
			this.label3.TabIndex = 21;
			this.label3.Text = "�ͷ�����";
			// 
			// txtTypeID
			// 
			this.txtTypeID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ds, "�ͷ���Ϣ.���ͱ��"));
			this.txtTypeID.Location = new System.Drawing.Point(104, 47);
			this.txtTypeID.Name = "txtTypeID";
			this.txtTypeID.Size = new System.Drawing.Size(168, 21);
			this.txtTypeID.TabIndex = 20;
			this.txtTypeID.Text = "";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(16, 48);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(72, 24);
			this.label2.TabIndex = 19;
			this.label2.Text = "���ͱ��";
			// 
			// txtRoomID
			// 
			this.txtRoomID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ds, "�ͷ���Ϣ.�ͷ����"));
			this.txtRoomID.Location = new System.Drawing.Point(104, 16);
			this.txtRoomID.Name = "txtRoomID";
			this.txtRoomID.Size = new System.Drawing.Size(168, 21);
			this.txtRoomID.TabIndex = 18;
			this.txtRoomID.Text = "";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(16, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(72, 24);
			this.label1.TabIndex = 17;
			this.label1.Text = "�ͷ����";
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(16, 48);
			this.label9.Name = "label9";
			this.label9.TabIndex = 47;
			this.label9.Text = "��ǰ��¼��";
			this.label9.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(576, 48);
			this.label10.Name = "label10";
			this.label10.TabIndex = 48;
			this.label10.Text = "��¼����";
			this.label10.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// checkBox2
			// 
			this.checkBox2.Location = new System.Drawing.Point(56, 237);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(56, 24);
			this.checkBox2.TabIndex = 49;
			this.checkBox2.Text = "�޸�";
			this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
			// 
			// btnSave
			// 
			this.btnSave.Enabled = false;
			this.btnSave.Location = new System.Drawing.Point(120, 237);
			this.btnSave.Name = "btnSave";
			this.btnSave.TabIndex = 50;
			this.btnSave.Text = "����";
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(528, 237);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.TabIndex = 51;
			this.btnDelete.Text = "ɾ��";
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// da
			// 
			this.da.DeleteCommand = this.sqlDeleteCommand1;
			this.da.InsertCommand = this.sqlInsertCommand1;
			this.da.SelectCommand = this.sqlSelectCommand1;
			this.da.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																						 new System.Data.Common.DataTableMapping("Table", "�ͷ���Ϣ", new System.Data.Common.DataColumnMapping[] {
																																																 new System.Data.Common.DataColumnMapping("�ͷ����", "�ͷ����"),
																																																 new System.Data.Common.DataColumnMapping("���ͱ��", "���ͱ��"),
																																																 new System.Data.Common.DataColumnMapping("�ͷ�����", "�ͷ�����"),
																																																 new System.Data.Common.DataColumnMapping("�ͷ�λ��", "�ͷ�λ��"),
																																																 new System.Data.Common.DataColumnMapping("�����", "�����"),
																																																 new System.Data.Common.DataColumnMapping("����", "����"),
																																																 new System.Data.Common.DataColumnMapping("�ͷ�����", "�ͷ�����"),
																																																 new System.Data.Common.DataColumnMapping("״̬", "״̬"),
																																																 new System.Data.Common.DataColumnMapping("�Ƿ��ƴ��", "�Ƿ��ƴ��")})});
			this.da.UpdateCommand = this.sqlUpdateCommand1;
			// 
			// sqlDeleteCommand1
			// 
			this.sqlDeleteCommand1.CommandText = @"DELETE FROM �ͷ���Ϣ WHERE (�ͷ���� = @Original_�ͷ����) AND (�ͷ�λ�� = @Original_�ͷ�λ�� OR @Original_�ͷ�λ�� IS NULL AND �ͷ�λ�� IS NULL) AND (�ͷ����� = @Original_�ͷ����� OR @Original_�ͷ����� IS NULL AND �ͷ����� IS NULL) AND (�ͷ����� = @Original_�ͷ����� OR @Original_�ͷ����� IS NULL AND �ͷ����� IS NULL) AND (���� = @Original_���� OR @Original_���� IS NULL AND ���� IS NULL) AND (�Ƿ��ƴ�� = @Original_�Ƿ��ƴ�� OR @Original_�Ƿ��ƴ�� IS NULL AND �Ƿ��ƴ�� IS NULL) AND (״̬ = @Original_״̬ OR @Original_״̬ IS NULL AND ״̬ IS NULL) AND (���ͱ�� = @Original_���ͱ��) AND (����� = @Original_����� OR @Original_����� IS NULL AND ����� IS NULL)";
			this.sqlDeleteCommand1.Connection = this.conn;
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_�ͷ����", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "�ͷ����", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_�ͷ�λ��", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "�ͷ�λ��", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_�ͷ�����", System.Data.SqlDbType.VarChar, 40, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "�ͷ�����", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_�ͷ�����", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "�ͷ�����", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_����", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "����", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_�Ƿ��ƴ��", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "�Ƿ��ƴ��", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_״̬", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "״̬", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_���ͱ��", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "���ͱ��", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_�����", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "�����", System.Data.DataRowVersion.Original, null));
			// 
			// sqlInsertCommand1
			// 
			this.sqlInsertCommand1.CommandText = "INSERT INTO �ͷ���Ϣ(�ͷ����, ���ͱ��, �ͷ�����, �ͷ�λ��, �����, ����, �ͷ�����, ״̬, �Ƿ��ƴ��) VALUES (@�ͷ����" +
				", @���ͱ��, @�ͷ�����, @�ͷ�λ��, @�����, @����, @�ͷ�����, @״̬, @�Ƿ��ƴ��); SELECT �ͷ����, ���ͱ��, �ͷ�����," +
				" �ͷ�λ��, �����, ����, �ͷ�����, ״̬, �Ƿ��ƴ�� FROM �ͷ���Ϣ WHERE (�ͷ���� = @�ͷ����)";
			this.sqlInsertCommand1.Connection = this.conn;
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@�ͷ����", System.Data.SqlDbType.VarChar, 10, "�ͷ����"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@���ͱ��", System.Data.SqlDbType.VarChar, 10, "���ͱ��"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@�ͷ�����", System.Data.SqlDbType.VarChar, 10, "�ͷ�����"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@�ͷ�λ��", System.Data.SqlDbType.VarChar, 10, "�ͷ�λ��"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@�����", System.Data.SqlDbType.Int, 4, "�����"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@����", System.Data.SqlDbType.Int, 4, "����"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@�ͷ�����", System.Data.SqlDbType.VarChar, 40, "�ͷ�����"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@״̬", System.Data.SqlDbType.VarChar, 10, "״̬"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@�Ƿ��ƴ��", System.Data.SqlDbType.Bit, 1, "�Ƿ��ƴ��"));
			// 
			// sqlSelectCommand1
			// 
			this.sqlSelectCommand1.CommandText = "SELECT �ͷ����, ���ͱ��, �ͷ�����, �ͷ�λ��, �����, ����, �ͷ�����, ״̬, �Ƿ��ƴ�� FROM �ͷ���Ϣ";
			this.sqlSelectCommand1.Connection = this.conn;
			// 
			// sqlUpdateCommand1
			// 
			this.sqlUpdateCommand1.CommandText = @"UPDATE �ͷ���Ϣ SET �ͷ���� = @�ͷ����, ���ͱ�� = @���ͱ��, �ͷ����� = @�ͷ�����, �ͷ�λ�� = @�ͷ�λ��, ����� = @�����, ���� = @����, �ͷ����� = @�ͷ�����, ״̬ = @״̬, �Ƿ��ƴ�� = @�Ƿ��ƴ�� WHERE (�ͷ���� = @Original_�ͷ����) AND (�ͷ�λ�� = @Original_�ͷ�λ�� OR @Original_�ͷ�λ�� IS NULL AND �ͷ�λ�� IS NULL) AND (�ͷ����� = @Original_�ͷ����� OR @Original_�ͷ����� IS NULL AND �ͷ����� IS NULL) AND (�ͷ����� = @Original_�ͷ����� OR @Original_�ͷ����� IS NULL AND �ͷ����� IS NULL) AND (���� = @Original_���� OR @Original_���� IS NULL AND ���� IS NULL) AND (�Ƿ��ƴ�� = @Original_�Ƿ��ƴ�� OR @Original_�Ƿ��ƴ�� IS NULL AND �Ƿ��ƴ�� IS NULL) AND (״̬ = @Original_״̬ OR @Original_״̬ IS NULL AND ״̬ IS NULL) AND (���ͱ�� = @Original_���ͱ��) AND (����� = @Original_����� OR @Original_����� IS NULL AND ����� IS NULL); SELECT �ͷ����, ���ͱ��, �ͷ�����, �ͷ�λ��, �����, ����, �ͷ�����, ״̬, �Ƿ��ƴ�� FROM �ͷ���Ϣ WHERE (�ͷ���� = @�ͷ����)";
			this.sqlUpdateCommand1.Connection = this.conn;
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@�ͷ����", System.Data.SqlDbType.VarChar, 10, "�ͷ����"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@���ͱ��", System.Data.SqlDbType.VarChar, 10, "���ͱ��"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@�ͷ�����", System.Data.SqlDbType.VarChar, 10, "�ͷ�����"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@�ͷ�λ��", System.Data.SqlDbType.VarChar, 10, "�ͷ�λ��"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@�����", System.Data.SqlDbType.Int, 4, "�����"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@����", System.Data.SqlDbType.Int, 4, "����"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@�ͷ�����", System.Data.SqlDbType.VarChar, 40, "�ͷ�����"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@״̬", System.Data.SqlDbType.VarChar, 10, "״̬"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@�Ƿ��ƴ��", System.Data.SqlDbType.Bit, 1, "�Ƿ��ƴ��"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_�ͷ����", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "�ͷ����", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_�ͷ�λ��", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "�ͷ�λ��", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_�ͷ�����", System.Data.SqlDbType.VarChar, 40, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "�ͷ�����", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_�ͷ�����", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "�ͷ�����", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_����", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "����", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_�Ƿ��ƴ��", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "�Ƿ��ƴ��", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_״̬", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "״̬", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_���ͱ��", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "���ͱ��", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_�����", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "�����", System.Data.DataRowVersion.Original, null));
			// 
			// ChangeRoomInfoManagement
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(692, 516);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.checkBox2);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label9);
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
			this.MaximumSize = new System.Drawing.Size(700, 550);
			this.Name = "ChangeRoomInfoManagement";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "�ͷ���Ϣ�޸�";
			this.Load += new System.EventHandler(this.ChangeRoomInfoManagement_Load);
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void btnAll_Click(object sender, System.EventArgs e)
		{
			this.sqlSelectCommand1.CommandText = "Select * from �ͷ���Ϣ";
			this.ds.Clear();
			da.Fill(ds,"�ͷ���Ϣ");
			bmb = this.BindingContext[ds,"�ͷ���Ϣ"];
			this.label9.Text = "��ǰ��¼��"+(this.dataGrid1.CurrentRowIndex+1);
			this.label10.Text = "��¼����"+this.bmb.Count;
		}

		private void btnFirst_Click(object sender, System.EventArgs e)
		{
			try
			{
				bmb.Position = 0;
				this.label9.Text = "��ǰ��¼��"+(this.dataGrid1.CurrentRowIndex+1);
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
				this.label9.Text = "��ǰ��¼��"+(this.dataGrid1.CurrentRowIndex+1);
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
				this.label9.Text = "��ǰ��¼��"+(this.dataGrid1.CurrentRowIndex+1);
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
				this.label9.Text = "��ǰ��¼��"+(this.dataGrid1.CurrentRowIndex+1);
			}
			catch
			{
			}
		}

		private void btnCancel_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void checkBox2_CheckedChanged(object sender, System.EventArgs e)
		{
			if(this.checkBox2.Checked ==true)
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

		private void btnSave_Click(object sender, System.EventArgs e)
		{
			try
			{
				bmb.EndCurrentEdit();
				da.Update(ds,"�ͷ���Ϣ");
				this.ds.Clear();
				da.Fill(this.ds,"�ͷ���Ϣ");
				bmb=this.BindingContext[ds,"�ͷ���Ϣ"];
				this.label9.Text = "��ǰ��¼��"+(this.dataGrid1.CurrentRowIndex+1);
				this.label10.Text = "��¼����"+this.bmb.Count;
				MessageBox.Show("�����޸ĳɹ�");
			}
			catch(Exception ex)
			{
				MessageBox.Show("�޸�ʧ�ܣ�"+ex.Message.ToString());
			}
		}

		private void btnDelete_Click(object sender, System.EventArgs e)
		{
			try
			{
				if(DialogResult.OK == MessageBox.Show("ȷ��ɾ����¼?","ȷ��",MessageBoxButtons.OKCancel,MessageBoxIcon.Question))
				{
					ds.�ͷ���Ϣ.Rows[bmb.Position].Delete();
					da.Update(ds,"�ͷ���Ϣ");
					this.ds.Clear();
					da.Fill(this.ds,"�ͷ���Ϣ");
					bmb=this.BindingContext[ds,"�ͷ���Ϣ"];
					this.label9.Text = "��ǰ��¼��"+(this.dataGrid1.CurrentRowIndex+1);
					this.label10.Text = "��¼����"+this.bmb.Count;
					MessageBox.Show("��¼ɾ���ɹ�");
				}
				else
				{

				}			
			}
			catch(Exception ex)
			{
				MessageBox.Show("ɾ����Ч��"+ex.Message.ToString());
			}
		}

		private void btnFind_Click(object sender, System.EventArgs e)
		{
			string str = "";
			
			try
			{
				if(this.textBox1.Enabled == true && this.textBox1.Text.Trim() != "")
				{
					str = "Select * from �ͷ���Ϣ where �ͷ����  like '%"+this.textBox1.Text.Trim()+"%'";
					this.sqlSelectCommand1.CommandText = str;
					this.ds.Clear();
					da.Fill(this.ds,"�ͷ���Ϣ");
					bmb=this.BindingContext[ds,"�ͷ���Ϣ"];
					this.label9.Text = "��ǰ��¼��"+(this.dataGrid1.CurrentRowIndex+1);
					this.label10.Text = "��¼����"+this.bmb.Count;
				}
				if(this.textBox2.Enabled == true && this.textBox2.Text.Trim() != "")
				{
					str = "Select * from �ͷ���Ϣ where �ͷ����� like '%"+this.textBox2.Text.Trim()+"%'";
					this.sqlSelectCommand1.CommandText = str;
					this.ds.Clear();
					da.Fill(this.ds,"�ͷ���Ϣ");
					bmb=this.BindingContext[ds,"�ͷ���Ϣ"];
					this.label9.Text = "��ǰ��¼��"+(this.dataGrid1.CurrentRowIndex+1);
					this.label10.Text = "��¼����"+this.bmb.Count;
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

		private void ChangeRoomInfoManagement_Load(object sender, System.EventArgs e)
		{
			this.conn.ConnectionString = Config.Settings.ConnStr;
		}
	}
}
