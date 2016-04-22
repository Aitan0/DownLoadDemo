using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data.SqlClient;
using HotelManagementSystem.Data;
using HotelManagementSystem.Config;

//�ͷ���Ϣ���
namespace HotelManagementSystem.RoomInfoManagement
{
	/// <summary>
	/// AddRoomInfoManagement ��ժҪ˵����
	/// </summary>
	public class AddRoomInfoManagement : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtRoomID;
		private System.Windows.Forms.TextBox txtTypeID;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtRoomType;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtPlace;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtNum;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtBedNum;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtSay;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtState;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.Button btnCancel;
		private HotelManagementSystem.Data.HotelDataSet ds;
		private System.Data.SqlClient.SqlConnection conn;
		private System.Data.SqlClient.SqlDataAdapter da;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
		private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
		private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
		private System.Windows.Forms.Button btnSave;
		/// <summary>
		/// ����������������
		/// </summary>
		private System.ComponentModel.Container components = null;

		public AddRoomInfoManagement()
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
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
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
			this.groupBox1.Location = new System.Drawing.Point(56, 32);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(332, 344);
			this.groupBox1.TabIndex = 24;
			this.groupBox1.TabStop = false;
			// 
			// checkBox1
			// 
			this.checkBox1.Location = new System.Drawing.Point(184, 304);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.TabIndex = 16;
			this.checkBox1.Text = "�Ƿ��ƴ��";
			// 
			// txtState
			// 
			this.txtState.Location = new System.Drawing.Point(136, 262);
			this.txtState.Name = "txtState";
			this.txtState.Size = new System.Drawing.Size(176, 21);
			this.txtState.TabIndex = 15;
			this.txtState.Text = "";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(24, 264);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(80, 23);
			this.label8.TabIndex = 14;
			this.label8.Text = "״̬";
			// 
			// txtSay
			// 
			this.txtSay.Location = new System.Drawing.Point(136, 228);
			this.txtSay.Name = "txtSay";
			this.txtSay.Size = new System.Drawing.Size(176, 21);
			this.txtSay.TabIndex = 13;
			this.txtSay.Text = "";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(24, 232);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(80, 23);
			this.label7.TabIndex = 12;
			this.label7.Text = "�ͷ�����";
			// 
			// txtBedNum
			// 
			this.txtBedNum.Location = new System.Drawing.Point(136, 194);
			this.txtBedNum.Name = "txtBedNum";
			this.txtBedNum.Size = new System.Drawing.Size(176, 21);
			this.txtBedNum.TabIndex = 11;
			this.txtBedNum.Text = "";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(24, 200);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(80, 23);
			this.label6.TabIndex = 10;
			this.label6.Text = "����";
			// 
			// txtNum
			// 
			this.txtNum.Location = new System.Drawing.Point(136, 160);
			this.txtNum.Name = "txtNum";
			this.txtNum.Size = new System.Drawing.Size(176, 21);
			this.txtNum.TabIndex = 9;
			this.txtNum.Text = "";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(24, 166);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(80, 23);
			this.label5.TabIndex = 8;
			this.label5.Text = "�����";
			// 
			// txtPlace
			// 
			this.txtPlace.Location = new System.Drawing.Point(136, 126);
			this.txtPlace.Name = "txtPlace";
			this.txtPlace.Size = new System.Drawing.Size(176, 21);
			this.txtPlace.TabIndex = 7;
			this.txtPlace.Text = "";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(24, 131);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(80, 23);
			this.label4.TabIndex = 6;
			this.label4.Text = "�ͷ�λ��";
			// 
			// txtRoomType
			// 
			this.txtRoomType.Location = new System.Drawing.Point(136, 92);
			this.txtRoomType.Name = "txtRoomType";
			this.txtRoomType.Size = new System.Drawing.Size(176, 21);
			this.txtRoomType.TabIndex = 5;
			this.txtRoomType.Text = "";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(25, 98);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(80, 23);
			this.label3.TabIndex = 4;
			this.label3.Text = "�ͷ�����";
			// 
			// txtTypeID
			// 
			this.txtTypeID.Location = new System.Drawing.Point(136, 58);
			this.txtTypeID.Name = "txtTypeID";
			this.txtTypeID.Size = new System.Drawing.Size(176, 21);
			this.txtTypeID.TabIndex = 3;
			this.txtTypeID.Text = "";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(24, 64);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(80, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "���ͱ��";
			// 
			// txtRoomID
			// 
			this.txtRoomID.Location = new System.Drawing.Point(136, 24);
			this.txtRoomID.Name = "txtRoomID";
			this.txtRoomID.Size = new System.Drawing.Size(176, 21);
			this.txtRoomID.TabIndex = 1;
			this.txtRoomID.Text = "";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(24, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(80, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "�ͷ����";
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(280, 408);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.TabIndex = 23;
			this.btnCancel.Text = "ȡ��";
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(72, 408);
			this.btnSave.Name = "btnSave";
			this.btnSave.TabIndex = 22;
			this.btnSave.Text = "����";
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// ds
			// 
			this.ds.DataSetName = "HotelDataSet";
			this.ds.Locale = new System.Globalization.CultureInfo("en-US");
			// 
			// conn
			// 
			this.conn.ConnectionString = "workstation id=(local);packet size=4096;integrated security=SSPI;data source=(loc" +
				"al);persist security info=False;initial catalog=�Ƶ����ϵͳ";
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
			// AddRoomInfoManagement
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(442, 464);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnSave);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(450, 496);
			this.MinimumSize = new System.Drawing.Size(450, 496);
			this.Name = "AddRoomInfoManagement";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "�ͷ���Ϣ���";
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		
		private void btnSave_Click(object sender, System.EventArgs e)
		{
			if(this.txtRoomID.Text.Trim() == "" || this.txtTypeID.Text.Trim() == "" || 
				this.txtNum.Text.Trim() == "" || this.txtBedNum.Text.Trim() == "")
			{
				MessageBox.Show("�ͷ���š����ͱ�š���������������ܿ�");
			}
			else
			{
				try
				{
					HotelDataSet.�ͷ���ϢRow dr = ds.�ͷ���Ϣ.New�ͷ���ϢRow();
					dr.�ͷ���� = this.txtRoomID.Text.Trim();
					dr.���ͱ�� = this.txtTypeID.Text.Trim();
					dr.�ͷ����� = this.txtRoomType.Text.Trim();
					dr.�ͷ�λ�� = this.txtPlace.Text.Trim();
					dr.����� = Int32.Parse(this.txtNum.Text.Trim());
					dr.���� = Int32.Parse(this.txtBedNum.Text.Trim());
					dr.�ͷ����� = this.txtSay.Text.Trim();
					dr.״̬ = this.txtState.Text.Trim();
					dr.�Ƿ��ƴ�� = this.checkBox1.Checked;
					this.ds.�ͷ���Ϣ.Add�ͷ���ϢRow(dr);
					da.Update(ds,"�ͷ���Ϣ");
					MessageBox.Show("���ݱ���ɹ�");
				}
				catch(Exception ex)
				{
					MessageBox.Show("��������"+ex.Message.ToString());
				}
			}
		}
		private void btnCancel_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		
	}
}
