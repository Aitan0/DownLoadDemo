using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data.SqlClient;
using HotelManagementSystem.Data;
using HotelManagementSystem.Config;

//��ס����ѯ

namespace HotelManagementSystem.LiveListManagement
{
	/// <summary>
	/// SelectLiveListManagement ��ժҪ˵����
	/// </summary>
	public class SelectAndChangeLiveListManagement : System.Windows.Forms.Form
	{
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
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnChange;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGrid dataGrid1;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnEnd;
		private System.Windows.Forms.Button btnNext;
		private System.Windows.Forms.Button btnBack;
		private System.Windows.Forms.Button btnFirst;
		private System.Windows.Forms.Button btnAll;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button btnFind;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txtLiveID;
		private System.Windows.Forms.Label label31;
		private System.Windows.Forms.DateTimePicker dtAccountTime;
		private System.Windows.Forms.CheckBox cbAccount;
		private System.Windows.Forms.CheckBox cbVIP;
		private System.Windows.Forms.CheckBox cbKSecret;
		private System.Windows.Forms.CheckBox cbWake;
		private System.Windows.Forms.CheckBox cbBreakfast;
		private System.Windows.Forms.TextBox txtPayType;
		private System.Windows.Forms.Label label30;
		private System.Windows.Forms.Label label29;
		private System.Windows.Forms.TextBox txtAccountMoney;
		private System.Windows.Forms.Label label28;
		private System.Windows.Forms.TextBox txtBillMoney;
		private System.Windows.Forms.Label label27;
		private System.Windows.Forms.TextBox txtSay;
		private System.Windows.Forms.Label label26;
		private System.Windows.Forms.TextBox txtPhoneGrade;
		private System.Windows.Forms.Label label25;
		private System.Windows.Forms.DateTimePicker dtEndTime;
		private System.Windows.Forms.DateTimePicker dtArrTime;
		private System.Windows.Forms.CheckBox cbBed;
		private System.Windows.Forms.TextBox txtAddBedPrice;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.TextBox txtSalesman;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.TextBox txtOperator;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.TextBox txtRemark;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.TextBox txtPhone;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.TextBox txtCompany;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.TextBox txtID;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.TextBox txtClient;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.TextBox txtMoney;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.TextBox txtReasom;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.TextBox txtDiscount;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox txtLPrice;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox txtRPrice;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox txtPNum;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txtState;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtPlace;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtRoomID;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtVipID;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.TextBox txtOrderID;
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.CheckBox checkBox1;
		BindingManagerBase bmb;

		public SelectAndChangeLiveListManagement()
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
			this.ds = new HotelManagementSystem.Data.HotelDataSet();
			this.conn = new System.Data.SqlClient.SqlConnection();
			this.da = new System.Data.SqlClient.SqlDataAdapter();
			this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnChange = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.dataGrid1 = new System.Windows.Forms.DataGrid();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnEnd = new System.Windows.Forms.Button();
			this.btnNext = new System.Windows.Forms.Button();
			this.btnBack = new System.Windows.Forms.Button();
			this.btnFirst = new System.Windows.Forms.Button();
			this.btnAll = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.btnFind = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtLiveID = new System.Windows.Forms.TextBox();
			this.label31 = new System.Windows.Forms.Label();
			this.dtAccountTime = new System.Windows.Forms.DateTimePicker();
			this.cbAccount = new System.Windows.Forms.CheckBox();
			this.cbVIP = new System.Windows.Forms.CheckBox();
			this.cbKSecret = new System.Windows.Forms.CheckBox();
			this.cbWake = new System.Windows.Forms.CheckBox();
			this.cbBreakfast = new System.Windows.Forms.CheckBox();
			this.txtPayType = new System.Windows.Forms.TextBox();
			this.label30 = new System.Windows.Forms.Label();
			this.label29 = new System.Windows.Forms.Label();
			this.txtAccountMoney = new System.Windows.Forms.TextBox();
			this.label28 = new System.Windows.Forms.Label();
			this.txtBillMoney = new System.Windows.Forms.TextBox();
			this.label27 = new System.Windows.Forms.Label();
			this.txtSay = new System.Windows.Forms.TextBox();
			this.label26 = new System.Windows.Forms.Label();
			this.txtPhoneGrade = new System.Windows.Forms.TextBox();
			this.label25 = new System.Windows.Forms.Label();
			this.dtEndTime = new System.Windows.Forms.DateTimePicker();
			this.dtArrTime = new System.Windows.Forms.DateTimePicker();
			this.cbBed = new System.Windows.Forms.CheckBox();
			this.txtAddBedPrice = new System.Windows.Forms.TextBox();
			this.label22 = new System.Windows.Forms.Label();
			this.txtSalesman = new System.Windows.Forms.TextBox();
			this.label21 = new System.Windows.Forms.Label();
			this.txtOperator = new System.Windows.Forms.TextBox();
			this.label20 = new System.Windows.Forms.Label();
			this.txtRemark = new System.Windows.Forms.TextBox();
			this.label19 = new System.Windows.Forms.Label();
			this.txtPhone = new System.Windows.Forms.TextBox();
			this.label18 = new System.Windows.Forms.Label();
			this.txtCompany = new System.Windows.Forms.TextBox();
			this.label17 = new System.Windows.Forms.Label();
			this.txtID = new System.Windows.Forms.TextBox();
			this.label16 = new System.Windows.Forms.Label();
			this.txtClient = new System.Windows.Forms.TextBox();
			this.label15 = new System.Windows.Forms.Label();
			this.txtMoney = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.txtReasom = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.txtDiscount = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.txtLPrice = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.txtRPrice = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.txtPNum = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.txtState = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txtPlace = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtRoomID = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtVipID = new System.Windows.Forms.TextBox();
			this.label23 = new System.Windows.Forms.Label();
			this.txtOrderID = new System.Windows.Forms.TextBox();
			this.label24 = new System.Windows.Forms.Label();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
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
																						 new System.Data.Common.DataTableMapping("Table", "��ס��", new System.Data.Common.DataColumnMapping[] {
																																																new System.Data.Common.DataColumnMapping("��ס����", "��ס����"),
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
																																																new System.Data.Common.DataColumnMapping("ҵ��Ա", "ҵ��Ա"),
																																																new System.Data.Common.DataColumnMapping("���", "���"),
																																																new System.Data.Common.DataColumnMapping("����", "����"),
																																																new System.Data.Common.DataColumnMapping("����", "����"),
																																																new System.Data.Common.DataColumnMapping("VIP", "VIP"),
																																																new System.Data.Common.DataColumnMapping("�绰�ȼ�", "�绰�ȼ�"),
																																																new System.Data.Common.DataColumnMapping("��Ҫ˵��", "��Ҫ˵��"),
																																																new System.Data.Common.DataColumnMapping("Ӧ���ʿ�", "Ӧ���ʿ�"),
																																																new System.Data.Common.DataColumnMapping("�Ƿ����", "�Ƿ����"),
																																																new System.Data.Common.DataColumnMapping("���ʽ��", "���ʽ��"),
																																																new System.Data.Common.DataColumnMapping("��������", "��������"),
																																																new System.Data.Common.DataColumnMapping("���ʷ�ʽ", "���ʷ�ʽ")})});
			this.da.UpdateCommand = this.sqlUpdateCommand1;
			// 
			// sqlDeleteCommand1
			// 
			this.sqlDeleteCommand1.CommandText = "DELETE FROM ��ס�� WHERE (��ס���� = @Original_��ס����) AND (VIP = @Original_VIP OR @Origin" +
				"al_VIP IS NULL AND VIP IS NULL) AND (ҵ��Ա = @Original_ҵ��Ա OR @Original_ҵ��Ա IS NUL" +
				"L AND ҵ��Ա IS NULL) AND (���ʷ�ʽ = @Original_���ʷ�ʽ OR @Original_���ʷ�ʽ IS NULL AND ���ʷ�ʽ" +
				" IS NULL) AND (��Ա��� = @Original_��Ա��� OR @Original_��Ա��� IS NULL AND ��Ա��� IS NULL)" +
				" AND (���� = @Original_���� OR @Original_���� IS NULL AND ���� IS NULL) AND (��ס���� = @Ori" +
				"ginal_��ס���� OR @Original_��ס���� IS NULL AND ��ס���� IS NULL) AND (��ס�۸� = @Original_��ס��" +
				"�� OR @Original_��ס�۸� IS NULL AND ��ס�۸� IS NULL) AND (�Ӵ��۸� = @Original_�Ӵ��۸� OR @Ori" +
				"ginal_�Ӵ��۸� IS NULL AND �Ӵ��۸� IS NULL) AND (����״̬ = @Original_����״̬ OR @Original_����״" +
				"̬ IS NULL AND ����״̬ IS NULL) AND (���� = @Original_���� OR @Original_���� IS NULL AND ��" +
				"�� IS NULL) AND (��ע = @Original_��ע OR @Original_��ע IS NULL AND ��ע IS NULL) AND (��" +
				"���۸� = @Original_�ͷ��۸� OR @Original_�ͷ��۸� IS NULL AND �ͷ��۸� IS NULL) AND (�ͷ�λ�� = @Or" +
				"iginal_�ͷ�λ�� OR @Original_�ͷ�λ�� IS NULL AND �ͷ�λ�� IS NULL) AND (�ͷ����� = @Original_�ͷ�" +
				"���� OR @Original_�ͷ����� IS NULL AND �ͷ����� IS NULL) AND (�ͷ���� = @Original_�ͷ����) AND (" +
				"Ӧ���ʿ� = @Original_Ӧ���ʿ� OR @Original_Ӧ���ʿ� IS NULL AND Ӧ���ʿ� IS NULL) AND (�ۿ� = @Ori" +
				"ginal_�ۿ� OR @Original_�ۿ� IS NULL AND �ۿ� IS NULL) AND (�ۿ�ԭ�� = @Original_�ۿ�ԭ�� OR @" +
				"Original_�ۿ�ԭ�� IS NULL AND �ۿ�ԭ�� IS NULL) AND (�ֵ�ʱ�� = @Original_�ֵ�ʱ�� OR @Original_" +
				"�ֵ�ʱ�� IS NULL AND �ֵ�ʱ�� IS NULL) AND (����Ա = @Original_����Ա OR @Original_����Ա IS NULL" +
				" AND ����Ա IS NULL) AND (��� = @Original_��� OR @Original_��� IS NULL AND ��� IS NULL)" +
				" AND (�Ƿ�Ӵ� = @Original_�Ƿ�Ӵ� OR @Original_�Ƿ�Ӵ� IS NULL AND �Ƿ�Ӵ� IS NULL) AND (�Ƿ��" +
				"�� = @Original_�Ƿ���� OR @Original_�Ƿ���� IS NULL AND �Ƿ���� IS NULL) AND (��Ҫ˵�� = @Orig" +
				"inal_��Ҫ˵�� OR @Original_��Ҫ˵�� IS NULL AND ��Ҫ˵�� IS NULL) AND (�绰�ȼ� = @Original_�绰�ȼ�" +
				" OR @Original_�绰�ȼ� IS NULL AND �绰�ȼ� IS NULL) AND (���ʱ�� = @Original_���ʱ�� OR @Orig" +
				"inal_���ʱ�� IS NULL AND ���ʱ�� IS NULL) AND (�������� = @Original_�������� OR @Original_��������" +
				" IS NULL AND �������� IS NULL) AND (���ʽ�� = @Original_���ʽ�� OR @Original_���ʽ�� IS NULL " +
				"AND ���ʽ�� IS NULL) AND (��ϵ�绰 = @Original_��ϵ�绰 OR @Original_��ϵ�绰 IS NULL AND ��ϵ�绰 " +
				"IS NULL) AND (���֤ = @Original_���֤ OR @Original_���֤ IS NULL AND ���֤ IS NULL) AND " +
				"(Ԥ�տ� = @Original_Ԥ�տ� OR @Original_Ԥ�տ� IS NULL AND Ԥ�տ� IS NULL) AND (Ԥ���� = @Origi" +
				"nal_Ԥ���� OR @Original_Ԥ���� IS NULL AND Ԥ���� IS NULL) AND (Ԥ����˾ = @Original_Ԥ����˾ OR " +
				"@Original_Ԥ����˾ IS NULL AND Ԥ����˾ IS NULL) AND (Ԥ������ = @Original_Ԥ������ OR @Original" +
				"_Ԥ������ IS NULL AND Ԥ������ IS NULL)";
			this.sqlDeleteCommand1.Connection = this.conn;
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_��ס����", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "��ס����", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_VIP", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "VIP", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_ҵ��Ա", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ҵ��Ա", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_���ʷ�ʽ", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "���ʷ�ʽ", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_��Ա���", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "��Ա���", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_����", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "����", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_��ס����", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "��ס����", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_��ס�۸�", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "��ס�۸�", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_�Ӵ��۸�", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "�Ӵ��۸�", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_����״̬", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "����״̬", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_����", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "����", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_��ע", System.Data.SqlDbType.VarChar, 40, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "��ע", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_�ͷ��۸�", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "�ͷ��۸�", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_�ͷ�λ��", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "�ͷ�λ��", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_�ͷ�����", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "�ͷ�����", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_�ͷ����", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "�ͷ����", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Ӧ���ʿ�", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "Ӧ���ʿ�", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_�ۿ�", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "�ۿ�", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_�ۿ�ԭ��", System.Data.SqlDbType.VarChar, 40, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "�ۿ�ԭ��", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_�ֵ�ʱ��", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "�ֵ�ʱ��", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_����Ա", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "����Ա", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_���", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "���", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_�Ƿ�Ӵ�", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "�Ƿ�Ӵ�", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_�Ƿ����", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "�Ƿ����", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_��Ҫ˵��", System.Data.SqlDbType.VarChar, 40, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "��Ҫ˵��", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_�绰�ȼ�", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "�绰�ȼ�", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_���ʱ��", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "���ʱ��", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_��������", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "��������", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_���ʽ��", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "���ʽ��", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_��ϵ�绰", System.Data.SqlDbType.VarChar, 13, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "��ϵ�绰", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_���֤", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "���֤", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Ԥ�տ�", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "Ԥ�տ�", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Ԥ����", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Ԥ����", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Ԥ����˾", System.Data.SqlDbType.VarChar, 40, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Ԥ����˾", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Ԥ������", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Ԥ������", System.Data.DataRowVersion.Original, null));
			// 
			// sqlInsertCommand1
			// 
			this.sqlInsertCommand1.CommandText = @"INSERT INTO ��ס��(��ס����, Ԥ������, ��Ա���, �ͷ����, �ͷ�����, �ͷ�λ��, �ֵ�ʱ��, ���ʱ��, ����״̬, ��ס����, �ͷ��۸�, ��ס�۸�, �ۿ�, �ۿ�ԭ��, �Ƿ�Ӵ�, �Ӵ��۸�, Ԥ�տ�, Ԥ����, ���֤, Ԥ����˾, ��ϵ�绰, ��ע, ����Ա, ҵ��Ա, ���, ����, ����, VIP, �绰�ȼ�, ��Ҫ˵��, Ӧ���ʿ�, �Ƿ����, ���ʽ��, ��������, ���ʷ�ʽ) VALUES (@��ס����, @Ԥ������, @��Ա���, @�ͷ����, @�ͷ�����, @�ͷ�λ��, @�ֵ�ʱ��, @���ʱ��, @����״̬, @��ס����, @�ͷ��۸�, @��ס�۸�, @�ۿ�, @�ۿ�ԭ��, @�Ƿ�Ӵ�, @�Ӵ��۸�, @Ԥ�տ�, @Ԥ����, @���֤, @Ԥ����˾, @��ϵ�绰, @��ע, @����Ա, @ҵ��Ա, @���, @����, @����, @VIP, @�绰�ȼ�, @��Ҫ˵��, @Ӧ���ʿ�, @�Ƿ����, @���ʽ��, @��������, @���ʷ�ʽ); SELECT ��ס����, Ԥ������, ��Ա���, �ͷ����, �ͷ�����, �ͷ�λ��, �ֵ�ʱ��, ���ʱ��, ����״̬, ��ס����, �ͷ��۸�, ��ס�۸�, �ۿ�, �ۿ�ԭ��, �Ƿ�Ӵ�, �Ӵ��۸�, Ԥ�տ�, Ԥ����, ���֤, Ԥ����˾, ��ϵ�绰, ��ע, ����Ա, ҵ��Ա, ���, ����, ����, VIP, �绰�ȼ�, ��Ҫ˵��, Ӧ���ʿ�, �Ƿ����, ���ʽ��, ��������, ���ʷ�ʽ FROM ��ס�� WHERE (��ס���� = @��ס����)";
			this.sqlInsertCommand1.Connection = this.conn;
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@��ס����", System.Data.SqlDbType.VarChar, 10, "��ס����"));
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
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@���", System.Data.SqlDbType.Bit, 1, "���"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@����", System.Data.SqlDbType.Bit, 1, "����"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@����", System.Data.SqlDbType.Bit, 1, "����"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@VIP", System.Data.SqlDbType.Bit, 1, "VIP"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@�绰�ȼ�", System.Data.SqlDbType.VarChar, 10, "�绰�ȼ�"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@��Ҫ˵��", System.Data.SqlDbType.VarChar, 40, "��Ҫ˵��"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Ӧ���ʿ�", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "Ӧ���ʿ�", System.Data.DataRowVersion.Current, null));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@�Ƿ����", System.Data.SqlDbType.Bit, 1, "�Ƿ����"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@���ʽ��", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "���ʽ��", System.Data.DataRowVersion.Current, null));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@��������", System.Data.SqlDbType.DateTime, 4, "��������"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@���ʷ�ʽ", System.Data.SqlDbType.VarChar, 10, "���ʷ�ʽ"));
			// 
			// sqlSelectCommand1
			// 
			this.sqlSelectCommand1.CommandText = "SELECT ��ס����, Ԥ������, ��Ա���, �ͷ����, �ͷ�����, �ͷ�λ��, �ֵ�ʱ��, ���ʱ��, ����״̬, ��ס����, �ͷ��۸�, ��ס�۸�, �ۿ�" +
				", �ۿ�ԭ��, �Ƿ�Ӵ�, �Ӵ��۸�, Ԥ�տ�, Ԥ����, ���֤, Ԥ����˾, ��ϵ�绰, ��ע, ����Ա, ҵ��Ա, ���, ����, ����, VIP, �绰" +
				"�ȼ�, ��Ҫ˵��, Ӧ���ʿ�, �Ƿ����, ���ʽ��, ��������, ���ʷ�ʽ FROM ��ס��";
			this.sqlSelectCommand1.Connection = this.conn;
			// 
			// sqlUpdateCommand1
			// 
			this.sqlUpdateCommand1.CommandText = "UPDATE ��ס�� SET ��ס���� = @��ס����, Ԥ������ = @Ԥ������, ��Ա��� = @��Ա���, �ͷ���� = @�ͷ����, �ͷ����� = @�ͷ�" +
				"����, �ͷ�λ�� = @�ͷ�λ��, �ֵ�ʱ�� = @�ֵ�ʱ��, ���ʱ�� = @���ʱ��, ����״̬ = @����״̬, ��ס���� = @��ס����, �ͷ��۸� =" +
				" @�ͷ��۸�, ��ס�۸� = @��ס�۸�, �ۿ� = @�ۿ�, �ۿ�ԭ�� = @�ۿ�ԭ��, �Ƿ�Ӵ� = @�Ƿ�Ӵ�, �Ӵ��۸� = @�Ӵ��۸�, Ԥ�տ� = " +
				"@Ԥ�տ�, Ԥ���� = @Ԥ����, ���֤ = @���֤, Ԥ����˾ = @Ԥ����˾, ��ϵ�绰 = @��ϵ�绰, ��ע = @��ע, ����Ա = @����Ա, " +
				"ҵ��Ա = @ҵ��Ա, ��� = @���, ���� = @����, ���� = @����, VIP = @VIP, �绰�ȼ� = @�绰�ȼ�, ��Ҫ˵�� = @��Ҫ˵��" +
				", Ӧ���ʿ� = @Ӧ���ʿ�, �Ƿ���� = @�Ƿ����, ���ʽ�� = @���ʽ��, �������� = @��������, ���ʷ�ʽ = @���ʷ�ʽ WHERE (��ס" +
				"���� = @Original_��ס����) AND (VIP = @Original_VIP OR @Original_VIP IS NULL AND VIP I" +
				"S NULL) AND (ҵ��Ա = @Original_ҵ��Ա OR @Original_ҵ��Ա IS NULL AND ҵ��Ա IS NULL) AND (" +
				"���ʷ�ʽ = @Original_���ʷ�ʽ OR @Original_���ʷ�ʽ IS NULL AND ���ʷ�ʽ IS NULL) AND (��Ա��� = @O" +
				"riginal_��Ա��� OR @Original_��Ա��� IS NULL AND ��Ա��� IS NULL) AND (���� = @Original_���� " +
				"OR @Original_���� IS NULL AND ���� IS NULL) AND (��ס���� = @Original_��ס���� OR @Original_" +
				"��ס���� IS NULL AND ��ס���� IS NULL) AND (��ס�۸� = @Original_��ס�۸� OR @Original_��ס�۸� IS N" +
				"ULL AND ��ס�۸� IS NULL) AND (�Ӵ��۸� = @Original_�Ӵ��۸� OR @Original_�Ӵ��۸� IS NULL AND ��" +
				"���۸� IS NULL) AND (����״̬ = @Original_����״̬ OR @Original_����״̬ IS NULL AND ����״̬ IS NU" +
				"LL) AND (���� = @Original_���� OR @Original_���� IS NULL AND ���� IS NULL) AND (��ע = @Or" +
				"iginal_��ע OR @Original_��ע IS NULL AND ��ע IS NULL) AND (�ͷ��۸� = @Original_�ͷ��۸� OR " +
				"@Original_�ͷ��۸� IS NULL AND �ͷ��۸� IS NULL) AND (�ͷ�λ�� = @Original_�ͷ�λ�� OR @Original" +
				"_�ͷ�λ�� IS NULL AND �ͷ�λ�� IS NULL) AND (�ͷ����� = @Original_�ͷ����� OR @Original_�ͷ����� IS " +
				"NULL AND �ͷ����� IS NULL) AND (�ͷ���� = @Original_�ͷ����) AND (Ӧ���ʿ� = @Original_Ӧ���ʿ� OR" +
				" @Original_Ӧ���ʿ� IS NULL AND Ӧ���ʿ� IS NULL) AND (�ۿ� = @Original_�ۿ� OR @Original_�ۿ�" +
				" IS NULL AND �ۿ� IS NULL) AND (�ۿ�ԭ�� = @Original_�ۿ�ԭ�� OR @Original_�ۿ�ԭ�� IS NULL AN" +
				"D �ۿ�ԭ�� IS NULL) AND (�ֵ�ʱ�� = @Original_�ֵ�ʱ�� OR @Original_�ֵ�ʱ�� IS NULL AND �ֵ�ʱ�� IS" +
				" NULL) AND (����Ա = @Original_����Ա OR @Original_����Ա IS NULL AND ����Ա IS NULL) AND (��" +
				"�� = @Original_��� OR @Original_��� IS NULL AND ��� IS NULL) AND (�Ƿ�Ӵ� = @Original_��" +
				"��Ӵ� OR @Original_�Ƿ�Ӵ� IS NULL AND �Ƿ�Ӵ� IS NULL) AND (�Ƿ���� = @Original_�Ƿ���� OR @O" +
				"riginal_�Ƿ���� IS NULL AND �Ƿ���� IS NULL) AND (��Ҫ˵�� = @Original_��Ҫ˵�� OR @Original_��" +
				"Ҫ˵�� IS NULL AND ��Ҫ˵�� IS NULL) AND (�绰�ȼ� = @Original_�绰�ȼ� OR @Original_�绰�ȼ� IS NU" +
				"LL AND �绰�ȼ� IS NULL) AND (���ʱ�� = @Original_���ʱ�� OR @Original_���ʱ�� IS NULL AND ���" +
				"ʱ�� IS NULL) AND (�������� = @Original_�������� OR @Original_�������� IS NULL AND �������� IS NUL" +
				"L) AND (���ʽ�� = @Original_���ʽ�� OR @Original_���ʽ�� IS NULL AND ���ʽ�� IS NULL) AND (��" +
				"ϵ�绰 = @Original_��ϵ�绰 OR @Original_��ϵ�绰 IS NULL AND ��ϵ�绰 IS NULL) AND (���֤ = @Ori" +
				"ginal_���֤ OR @Original_���֤ IS NULL AND ���֤ IS NULL) AND (Ԥ�տ� = @Original_Ԥ�տ� OR " +
				"@Original_Ԥ�տ� IS NULL AND Ԥ�տ� IS NULL) AND (Ԥ���� = @Original_Ԥ���� OR @Original_Ԥ����" +
				" IS NULL AND Ԥ���� IS NULL) AND (Ԥ����˾ = @Original_Ԥ����˾ OR @Original_Ԥ����˾ IS NULL A" +
				"ND Ԥ����˾ IS NULL) AND (Ԥ������ = @Original_Ԥ������ OR @Original_Ԥ������ IS NULL AND Ԥ������ I" +
				"S NULL); SELECT ��ס����, Ԥ������, ��Ա���, �ͷ����, �ͷ�����, �ͷ�λ��, �ֵ�ʱ��, ���ʱ��, ����״̬, ��ס����, �ͷ��۸�" +
				", ��ס�۸�, �ۿ�, �ۿ�ԭ��, �Ƿ�Ӵ�, �Ӵ��۸�, Ԥ�տ�, Ԥ����, ���֤, Ԥ����˾, ��ϵ�绰, ��ע, ����Ա, ҵ��Ա, ���, ����, ��" +
				"��, VIP, �绰�ȼ�, ��Ҫ˵��, Ӧ���ʿ�, �Ƿ����, ���ʽ��, ��������, ���ʷ�ʽ FROM ��ס�� WHERE (��ס���� = @��ס����)";
			this.sqlUpdateCommand1.Connection = this.conn;
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@��ס����", System.Data.SqlDbType.VarChar, 10, "��ס����"));
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
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@���", System.Data.SqlDbType.Bit, 1, "���"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@����", System.Data.SqlDbType.Bit, 1, "����"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@����", System.Data.SqlDbType.Bit, 1, "����"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@VIP", System.Data.SqlDbType.Bit, 1, "VIP"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@�绰�ȼ�", System.Data.SqlDbType.VarChar, 10, "�绰�ȼ�"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@��Ҫ˵��", System.Data.SqlDbType.VarChar, 40, "��Ҫ˵��"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Ӧ���ʿ�", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "Ӧ���ʿ�", System.Data.DataRowVersion.Current, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@�Ƿ����", System.Data.SqlDbType.Bit, 1, "�Ƿ����"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@���ʽ��", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "���ʽ��", System.Data.DataRowVersion.Current, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@��������", System.Data.SqlDbType.DateTime, 4, "��������"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@���ʷ�ʽ", System.Data.SqlDbType.VarChar, 10, "���ʷ�ʽ"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_��ס����", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "��ס����", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_VIP", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "VIP", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_ҵ��Ա", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ҵ��Ա", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_���ʷ�ʽ", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "���ʷ�ʽ", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_��Ա���", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "��Ա���", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_����", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "����", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_��ס����", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "��ס����", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_��ס�۸�", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "��ס�۸�", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_�Ӵ��۸�", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "�Ӵ��۸�", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_����״̬", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "����״̬", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_����", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "����", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_��ע", System.Data.SqlDbType.VarChar, 40, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "��ע", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_�ͷ��۸�", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "�ͷ��۸�", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_�ͷ�λ��", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "�ͷ�λ��", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_�ͷ�����", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "�ͷ�����", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_�ͷ����", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "�ͷ����", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Ӧ���ʿ�", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "Ӧ���ʿ�", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_�ۿ�", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "�ۿ�", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_�ۿ�ԭ��", System.Data.SqlDbType.VarChar, 40, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "�ۿ�ԭ��", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_�ֵ�ʱ��", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "�ֵ�ʱ��", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_����Ա", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "����Ա", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_���", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "���", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_�Ƿ�Ӵ�", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "�Ƿ�Ӵ�", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_�Ƿ����", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "�Ƿ����", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_��Ҫ˵��", System.Data.SqlDbType.VarChar, 40, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "��Ҫ˵��", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_�绰�ȼ�", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "�绰�ȼ�", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_���ʱ��", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "���ʱ��", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_��������", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "��������", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_���ʽ��", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "���ʽ��", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_��ϵ�绰", System.Data.SqlDbType.VarChar, 13, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "��ϵ�绰", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_���֤", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "���֤", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Ԥ�տ�", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "Ԥ�տ�", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Ԥ����", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Ԥ����", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Ԥ����˾", System.Data.SqlDbType.VarChar, 40, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Ԥ����˾", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Ԥ������", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Ԥ������", System.Data.DataRowVersion.Original, null));
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(608, 40);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(80, 64);
			this.btnDelete.TabIndex = 94;
			this.btnDelete.Text = "ɾ��";
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnChange
			// 
			this.btnChange.Location = new System.Drawing.Point(456, 40);
			this.btnChange.Name = "btnChange";
			this.btnChange.Size = new System.Drawing.Size(80, 64);
			this.btnChange.TabIndex = 93;
			this.btnChange.Text = "��ϸ";
			this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(600, 160);
			this.label2.Name = "label2";
			this.label2.TabIndex = 92;
			this.label2.Text = "��¼����";
			this.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 160);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(104, 23);
			this.label1.TabIndex = 91;
			this.label1.Text = "��ǰ��¼��";
			this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// dataGrid1
			// 
			this.dataGrid1.DataMember = "��ס��";
			this.dataGrid1.DataSource = this.ds;
			this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGrid1.Location = new System.Drawing.Point(0, 200);
			this.dataGrid1.Name = "dataGrid1";
			this.dataGrid1.ReadOnly = true;
			this.dataGrid1.Size = new System.Drawing.Size(712, 352);
			this.dataGrid1.TabIndex = 90;
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(507, 136);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 48);
			this.btnCancel.TabIndex = 88;
			this.btnCancel.Text = "�˳�";
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnEnd
			// 
			this.btnEnd.Location = new System.Drawing.Point(432, 136);
			this.btnEnd.Name = "btnEnd";
			this.btnEnd.Size = new System.Drawing.Size(75, 48);
			this.btnEnd.TabIndex = 87;
			this.btnEnd.Text = "���";
			this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
			// 
			// btnNext
			// 
			this.btnNext.Location = new System.Drawing.Point(357, 136);
			this.btnNext.Name = "btnNext";
			this.btnNext.Size = new System.Drawing.Size(75, 48);
			this.btnNext.TabIndex = 86;
			this.btnNext.Text = "��һ��";
			this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
			// 
			// btnBack
			// 
			this.btnBack.Location = new System.Drawing.Point(282, 136);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(75, 48);
			this.btnBack.TabIndex = 85;
			this.btnBack.Text = "��һ��";
			this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
			// 
			// btnFirst
			// 
			this.btnFirst.Location = new System.Drawing.Point(207, 136);
			this.btnFirst.Name = "btnFirst";
			this.btnFirst.Size = new System.Drawing.Size(75, 48);
			this.btnFirst.TabIndex = 84;
			this.btnFirst.Text = "��ǰ";
			this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
			// 
			// btnAll
			// 
			this.btnAll.Location = new System.Drawing.Point(132, 136);
			this.btnAll.Name = "btnAll";
			this.btnAll.Size = new System.Drawing.Size(75, 48);
			this.btnAll.TabIndex = 83;
			this.btnAll.Text = "��ѯ����";
			this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.radioButton1);
			this.groupBox2.Controls.Add(this.textBox2);
			this.groupBox2.Controls.Add(this.radioButton2);
			this.groupBox2.Controls.Add(this.textBox1);
			this.groupBox2.Controls.Add(this.btnFind);
			this.groupBox2.Location = new System.Drawing.Point(16, 16);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(432, 104);
			this.groupBox2.TabIndex = 89;
			this.groupBox2.TabStop = false;
			// 
			// radioButton1
			// 
			this.radioButton1.Location = new System.Drawing.Point(32, 27);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(80, 24);
			this.radioButton1.TabIndex = 5;
			this.radioButton1.Text = "��ס����";
			this.radioButton1.Click += new System.EventHandler(this.radioButton1_CheckedChanged);
			// 
			// textBox2
			// 
			this.textBox2.Enabled = false;
			this.textBox2.Location = new System.Drawing.Point(120, 64);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(176, 21);
			this.textBox2.TabIndex = 3;
			this.textBox2.Text = "";
			// 
			// radioButton2
			// 
			this.radioButton2.Location = new System.Drawing.Point(32, 64);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(80, 24);
			this.radioButton2.TabIndex = 2;
			this.radioButton2.Text = "�ͷ����";
			this.radioButton2.Click += new System.EventHandler(this.radioButton2_CheckedChanged);
			// 
			// textBox1
			// 
			this.textBox1.Enabled = false;
			this.textBox1.Location = new System.Drawing.Point(120, 27);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(176, 21);
			this.textBox1.TabIndex = 1;
			this.textBox1.Text = "";
			// 
			// btnFind
			// 
			this.btnFind.Location = new System.Drawing.Point(328, 24);
			this.btnFind.Name = "btnFind";
			this.btnFind.Size = new System.Drawing.Size(80, 64);
			this.btnFind.TabIndex = 4;
			this.btnFind.Text = "��ѯ";
			this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
			// 
			// btnSave
			// 
			this.btnSave.Enabled = false;
			this.btnSave.Location = new System.Drawing.Point(536, 40);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 64);
			this.btnSave.TabIndex = 99;
			this.btnSave.Text = "����";
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtLiveID);
			this.groupBox1.Controls.Add(this.label31);
			this.groupBox1.Controls.Add(this.dtAccountTime);
			this.groupBox1.Controls.Add(this.cbAccount);
			this.groupBox1.Controls.Add(this.cbVIP);
			this.groupBox1.Controls.Add(this.cbKSecret);
			this.groupBox1.Controls.Add(this.cbWake);
			this.groupBox1.Controls.Add(this.cbBreakfast);
			this.groupBox1.Controls.Add(this.txtPayType);
			this.groupBox1.Controls.Add(this.label30);
			this.groupBox1.Controls.Add(this.label29);
			this.groupBox1.Controls.Add(this.txtAccountMoney);
			this.groupBox1.Controls.Add(this.label28);
			this.groupBox1.Controls.Add(this.txtBillMoney);
			this.groupBox1.Controls.Add(this.label27);
			this.groupBox1.Controls.Add(this.txtSay);
			this.groupBox1.Controls.Add(this.label26);
			this.groupBox1.Controls.Add(this.txtPhoneGrade);
			this.groupBox1.Controls.Add(this.label25);
			this.groupBox1.Controls.Add(this.dtEndTime);
			this.groupBox1.Controls.Add(this.dtArrTime);
			this.groupBox1.Controls.Add(this.cbBed);
			this.groupBox1.Controls.Add(this.txtAddBedPrice);
			this.groupBox1.Controls.Add(this.label22);
			this.groupBox1.Controls.Add(this.txtSalesman);
			this.groupBox1.Controls.Add(this.label21);
			this.groupBox1.Controls.Add(this.txtOperator);
			this.groupBox1.Controls.Add(this.label20);
			this.groupBox1.Controls.Add(this.txtRemark);
			this.groupBox1.Controls.Add(this.label19);
			this.groupBox1.Controls.Add(this.txtPhone);
			this.groupBox1.Controls.Add(this.label18);
			this.groupBox1.Controls.Add(this.txtCompany);
			this.groupBox1.Controls.Add(this.label17);
			this.groupBox1.Controls.Add(this.txtID);
			this.groupBox1.Controls.Add(this.label16);
			this.groupBox1.Controls.Add(this.txtClient);
			this.groupBox1.Controls.Add(this.label15);
			this.groupBox1.Controls.Add(this.txtMoney);
			this.groupBox1.Controls.Add(this.label14);
			this.groupBox1.Controls.Add(this.txtReasom);
			this.groupBox1.Controls.Add(this.label13);
			this.groupBox1.Controls.Add(this.txtDiscount);
			this.groupBox1.Controls.Add(this.label12);
			this.groupBox1.Controls.Add(this.txtLPrice);
			this.groupBox1.Controls.Add(this.label11);
			this.groupBox1.Controls.Add(this.txtRPrice);
			this.groupBox1.Controls.Add(this.label10);
			this.groupBox1.Controls.Add(this.txtPNum);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.txtState);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.txtPlace);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.txtName);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.txtRoomID);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.txtVipID);
			this.groupBox1.Controls.Add(this.label23);
			this.groupBox1.Controls.Add(this.txtOrderID);
			this.groupBox1.Controls.Add(this.label24);
			this.groupBox1.Enabled = false;
			this.groupBox1.Location = new System.Drawing.Point(0, 200);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(712, 352);
			this.groupBox1.TabIndex = 100;
			this.groupBox1.TabStop = false;
			this.groupBox1.Visible = false;
			// 
			// txtLiveID
			// 
			this.txtLiveID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ds, "��ס��.��ס����"));
			this.txtLiveID.Location = new System.Drawing.Point(104, 24);
			this.txtLiveID.Name = "txtLiveID";
			this.txtLiveID.Size = new System.Drawing.Size(128, 21);
			this.txtLiveID.TabIndex = 68;
			this.txtLiveID.Text = "";
			// 
			// label31
			// 
			this.label31.Location = new System.Drawing.Point(16, 26);
			this.label31.Name = "label31";
			this.label31.Size = new System.Drawing.Size(80, 23);
			this.label31.TabIndex = 67;
			this.label31.Text = "��ס����";
			// 
			// dtAccountTime
			// 
			this.dtAccountTime.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ds, "��ס��.��������"));
			this.dtAccountTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtAccountTime.Location = new System.Drawing.Point(568, 148);
			this.dtAccountTime.Name = "dtAccountTime";
			this.dtAccountTime.Size = new System.Drawing.Size(128, 21);
			this.dtAccountTime.TabIndex = 66;
			// 
			// cbAccount
			// 
			this.cbAccount.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.ds, "��ס��.�Ƿ����"));
			this.cbAccount.Location = new System.Drawing.Point(616, 312);
			this.cbAccount.Name = "cbAccount";
			this.cbAccount.Size = new System.Drawing.Size(80, 24);
			this.cbAccount.TabIndex = 65;
			this.cbAccount.Text = "�Ƿ����";
			// 
			// cbVIP
			// 
			this.cbVIP.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.ds, "��ס��.VIP"));
			this.cbVIP.Location = new System.Drawing.Point(504, 312);
			this.cbVIP.Name = "cbVIP";
			this.cbVIP.Size = new System.Drawing.Size(80, 24);
			this.cbVIP.TabIndex = 64;
			this.cbVIP.Text = "VIP";
			// 
			// cbKSecret
			// 
			this.cbKSecret.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.ds, "��ס��.����"));
			this.cbKSecret.Location = new System.Drawing.Point(616, 280);
			this.cbKSecret.Name = "cbKSecret";
			this.cbKSecret.Size = new System.Drawing.Size(80, 24);
			this.cbKSecret.TabIndex = 63;
			this.cbKSecret.Text = "����";
			// 
			// cbWake
			// 
			this.cbWake.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.ds, "��ס��.����"));
			this.cbWake.Location = new System.Drawing.Point(504, 280);
			this.cbWake.Name = "cbWake";
			this.cbWake.Size = new System.Drawing.Size(80, 24);
			this.cbWake.TabIndex = 62;
			this.cbWake.Text = "����";
			// 
			// cbBreakfast
			// 
			this.cbBreakfast.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.ds, "��ס��.���"));
			this.cbBreakfast.Location = new System.Drawing.Point(616, 248);
			this.cbBreakfast.Name = "cbBreakfast";
			this.cbBreakfast.Size = new System.Drawing.Size(80, 24);
			this.cbBreakfast.TabIndex = 61;
			this.cbBreakfast.Text = "���";
			// 
			// txtPayType
			// 
			this.txtPayType.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ds, "��ס��.���ʷ�ʽ"));
			this.txtPayType.Location = new System.Drawing.Point(568, 180);
			this.txtPayType.Name = "txtPayType";
			this.txtPayType.Size = new System.Drawing.Size(128, 21);
			this.txtPayType.TabIndex = 58;
			this.txtPayType.Text = "";
			// 
			// label30
			// 
			this.label30.Location = new System.Drawing.Point(480, 184);
			this.label30.Name = "label30";
			this.label30.Size = new System.Drawing.Size(80, 23);
			this.label30.TabIndex = 57;
			this.label30.Text = "���ʷ�ʽ";
			// 
			// label29
			// 
			this.label29.Location = new System.Drawing.Point(480, 151);
			this.label29.Name = "label29";
			this.label29.Size = new System.Drawing.Size(80, 23);
			this.label29.TabIndex = 55;
			this.label29.Text = "��������";
			// 
			// txtAccountMoney
			// 
			this.txtAccountMoney.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ds, "��ס��.���ʽ��"));
			this.txtAccountMoney.Location = new System.Drawing.Point(568, 117);
			this.txtAccountMoney.Name = "txtAccountMoney";
			this.txtAccountMoney.Size = new System.Drawing.Size(128, 21);
			this.txtAccountMoney.TabIndex = 54;
			this.txtAccountMoney.Text = "";
			// 
			// label28
			// 
			this.label28.Location = new System.Drawing.Point(480, 122);
			this.label28.Name = "label28";
			this.label28.Size = new System.Drawing.Size(80, 23);
			this.label28.TabIndex = 53;
			this.label28.Text = "���ʽ��";
			// 
			// txtBillMoney
			// 
			this.txtBillMoney.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ds, "��ס��.Ӧ���ʿ�"));
			this.txtBillMoney.Location = new System.Drawing.Point(568, 86);
			this.txtBillMoney.Name = "txtBillMoney";
			this.txtBillMoney.Size = new System.Drawing.Size(128, 21);
			this.txtBillMoney.TabIndex = 52;
			this.txtBillMoney.Text = "";
			// 
			// label27
			// 
			this.label27.Location = new System.Drawing.Point(480, 91);
			this.label27.Name = "label27";
			this.label27.Size = new System.Drawing.Size(80, 23);
			this.label27.TabIndex = 51;
			this.label27.Text = "Ӧ���ʿ�";
			// 
			// txtSay
			// 
			this.txtSay.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ds, "��ס��.��Ҫ˵��"));
			this.txtSay.Location = new System.Drawing.Point(568, 55);
			this.txtSay.Name = "txtSay";
			this.txtSay.Size = new System.Drawing.Size(128, 21);
			this.txtSay.TabIndex = 50;
			this.txtSay.Text = "";
			// 
			// label26
			// 
			this.label26.Location = new System.Drawing.Point(480, 58);
			this.label26.Name = "label26";
			this.label26.Size = new System.Drawing.Size(80, 23);
			this.label26.TabIndex = 49;
			this.label26.Text = "��Ҫ˵��";
			// 
			// txtPhoneGrade
			// 
			this.txtPhoneGrade.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ds, "��ס��.�绰�ȼ�"));
			this.txtPhoneGrade.Location = new System.Drawing.Point(568, 24);
			this.txtPhoneGrade.Name = "txtPhoneGrade";
			this.txtPhoneGrade.Size = new System.Drawing.Size(128, 21);
			this.txtPhoneGrade.TabIndex = 48;
			this.txtPhoneGrade.Text = "";
			// 
			// label25
			// 
			this.label25.Location = new System.Drawing.Point(480, 25);
			this.label25.Name = "label25";
			this.label25.Size = new System.Drawing.Size(80, 23);
			this.label25.TabIndex = 47;
			this.label25.Text = "�绰�ȼ�";
			// 
			// dtEndTime
			// 
			this.dtEndTime.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ds, "��ס��.���ʱ��"));
			this.dtEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtEndTime.Location = new System.Drawing.Point(104, 227);
			this.dtEndTime.Name = "dtEndTime";
			this.dtEndTime.Size = new System.Drawing.Size(128, 21);
			this.dtEndTime.TabIndex = 46;
			// 
			// dtArrTime
			// 
			this.dtArrTime.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ds, "��ס��.�ֵ�ʱ��"));
			this.dtArrTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtArrTime.Location = new System.Drawing.Point(104, 198);
			this.dtArrTime.Name = "dtArrTime";
			this.dtArrTime.Size = new System.Drawing.Size(128, 21);
			this.dtArrTime.TabIndex = 45;
			// 
			// cbBed
			// 
			this.cbBed.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.ds, "��ס��.�Ƿ�Ӵ�"));
			this.cbBed.Location = new System.Drawing.Point(504, 248);
			this.cbBed.Name = "cbBed";
			this.cbBed.Size = new System.Drawing.Size(80, 24);
			this.cbBed.TabIndex = 44;
			this.cbBed.Text = "�Ƿ�Ӵ�";
			// 
			// txtAddBedPrice
			// 
			this.txtAddBedPrice.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ds, "��ס��.�Ӵ��۸�"));
			this.txtAddBedPrice.Location = new System.Drawing.Point(568, 213);
			this.txtAddBedPrice.Name = "txtAddBedPrice";
			this.txtAddBedPrice.Size = new System.Drawing.Size(128, 21);
			this.txtAddBedPrice.TabIndex = 43;
			this.txtAddBedPrice.Text = "";
			// 
			// label22
			// 
			this.label22.Location = new System.Drawing.Point(480, 217);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(80, 23);
			this.label22.TabIndex = 42;
			this.label22.Text = "�Ӵ��۸�";
			// 
			// txtSalesman
			// 
			this.txtSalesman.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ds, "��ס��.ҵ��Ա"));
			this.txtSalesman.Location = new System.Drawing.Point(336, 313);
			this.txtSalesman.Name = "txtSalesman";
			this.txtSalesman.Size = new System.Drawing.Size(128, 21);
			this.txtSalesman.TabIndex = 41;
			this.txtSalesman.Text = "";
			// 
			// label21
			// 
			this.label21.Location = new System.Drawing.Point(248, 317);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(80, 23);
			this.label21.TabIndex = 40;
			this.label21.Text = "ҵ��Ա";
			// 
			// txtOperator
			// 
			this.txtOperator.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ds, "��ס��.����Ա"));
			this.txtOperator.Location = new System.Drawing.Point(336, 285);
			this.txtOperator.Name = "txtOperator";
			this.txtOperator.Size = new System.Drawing.Size(128, 21);
			this.txtOperator.TabIndex = 39;
			this.txtOperator.Text = "";
			// 
			// label20
			// 
			this.label20.Location = new System.Drawing.Point(248, 288);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(80, 23);
			this.label20.TabIndex = 38;
			this.label20.Text = "����Ա";
			// 
			// txtRemark
			// 
			this.txtRemark.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ds, "��ס��.��ע"));
			this.txtRemark.Location = new System.Drawing.Point(336, 256);
			this.txtRemark.Name = "txtRemark";
			this.txtRemark.Size = new System.Drawing.Size(128, 21);
			this.txtRemark.TabIndex = 37;
			this.txtRemark.Text = "";
			// 
			// label19
			// 
			this.label19.Location = new System.Drawing.Point(248, 257);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(80, 23);
			this.label19.TabIndex = 36;
			this.label19.Text = "��ע";
			// 
			// txtPhone
			// 
			this.txtPhone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ds, "��ס��.��ϵ�绰"));
			this.txtPhone.Location = new System.Drawing.Point(336, 227);
			this.txtPhone.Name = "txtPhone";
			this.txtPhone.Size = new System.Drawing.Size(128, 21);
			this.txtPhone.TabIndex = 35;
			this.txtPhone.Text = "";
			// 
			// label18
			// 
			this.label18.Location = new System.Drawing.Point(248, 230);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(80, 23);
			this.label18.TabIndex = 34;
			this.label18.Text = "��ϵ�绰";
			// 
			// txtCompany
			// 
			this.txtCompany.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ds, "��ס��.Ԥ����˾"));
			this.txtCompany.Location = new System.Drawing.Point(336, 198);
			this.txtCompany.Name = "txtCompany";
			this.txtCompany.Size = new System.Drawing.Size(128, 21);
			this.txtCompany.TabIndex = 33;
			this.txtCompany.Text = "";
			// 
			// label17
			// 
			this.label17.Location = new System.Drawing.Point(248, 201);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(80, 23);
			this.label17.TabIndex = 32;
			this.label17.Text = "Ԥ����˾";
			// 
			// txtID
			// 
			this.txtID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ds, "��ס��.���֤"));
			this.txtID.Location = new System.Drawing.Point(336, 170);
			this.txtID.Name = "txtID";
			this.txtID.Size = new System.Drawing.Size(128, 21);
			this.txtID.TabIndex = 31;
			this.txtID.Text = "";
			// 
			// label16
			// 
			this.label16.Location = new System.Drawing.Point(248, 176);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(80, 24);
			this.label16.TabIndex = 30;
			this.label16.Text = "���֤";
			// 
			// txtClient
			// 
			this.txtClient.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ds, "��ס��.Ԥ����"));
			this.txtClient.Location = new System.Drawing.Point(336, 141);
			this.txtClient.Name = "txtClient";
			this.txtClient.Size = new System.Drawing.Size(128, 21);
			this.txtClient.TabIndex = 29;
			this.txtClient.Text = "";
			// 
			// label15
			// 
			this.label15.Location = new System.Drawing.Point(248, 144);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(80, 24);
			this.label15.TabIndex = 28;
			this.label15.Text = "Ԥ����";
			// 
			// txtMoney
			// 
			this.txtMoney.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ds, "��ס��.Ԥ�տ�"));
			this.txtMoney.Location = new System.Drawing.Point(336, 111);
			this.txtMoney.Name = "txtMoney";
			this.txtMoney.Size = new System.Drawing.Size(128, 21);
			this.txtMoney.TabIndex = 27;
			this.txtMoney.Text = "";
			// 
			// label14
			// 
			this.label14.Location = new System.Drawing.Point(248, 113);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(80, 24);
			this.label14.TabIndex = 26;
			this.label14.Text = "Ԥ�տ�";
			// 
			// txtReasom
			// 
			this.txtReasom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ds, "��ס��.�ۿ�ԭ��"));
			this.txtReasom.Location = new System.Drawing.Point(336, 82);
			this.txtReasom.Name = "txtReasom";
			this.txtReasom.Size = new System.Drawing.Size(128, 21);
			this.txtReasom.TabIndex = 25;
			this.txtReasom.Text = "";
			// 
			// label13
			// 
			this.label13.Location = new System.Drawing.Point(248, 87);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(80, 24);
			this.label13.TabIndex = 24;
			this.label13.Text = "�ۿ�ԭ��";
			// 
			// txtDiscount
			// 
			this.txtDiscount.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ds, "��ס��.�ۿ�"));
			this.txtDiscount.Location = new System.Drawing.Point(336, 53);
			this.txtDiscount.Name = "txtDiscount";
			this.txtDiscount.Size = new System.Drawing.Size(128, 21);
			this.txtDiscount.TabIndex = 23;
			this.txtDiscount.Text = "";
			// 
			// label12
			// 
			this.label12.Location = new System.Drawing.Point(248, 56);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(80, 24);
			this.label12.TabIndex = 22;
			this.label12.Text = "�ۿ�";
			// 
			// txtLPrice
			// 
			this.txtLPrice.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ds, "��ס��.��ס�۸�"));
			this.txtLPrice.Location = new System.Drawing.Point(336, 24);
			this.txtLPrice.Name = "txtLPrice";
			this.txtLPrice.Size = new System.Drawing.Size(128, 21);
			this.txtLPrice.TabIndex = 21;
			this.txtLPrice.Text = "";
			// 
			// label11
			// 
			this.label11.Location = new System.Drawing.Point(248, 27);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(80, 24);
			this.label11.TabIndex = 20;
			this.label11.Text = "��ס�۸�";
			// 
			// txtRPrice
			// 
			this.txtRPrice.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ds, "��ס��.�ͷ��۸�"));
			this.txtRPrice.Location = new System.Drawing.Point(104, 314);
			this.txtRPrice.Name = "txtRPrice";
			this.txtRPrice.Size = new System.Drawing.Size(128, 21);
			this.txtRPrice.TabIndex = 19;
			this.txtRPrice.Text = "";
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(16, 317);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(80, 24);
			this.label10.TabIndex = 18;
			this.label10.Text = "�ͷ��۸�";
			// 
			// txtPNum
			// 
			this.txtPNum.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ds, "��ס��.��ס����"));
			this.txtPNum.Location = new System.Drawing.Point(104, 285);
			this.txtPNum.Name = "txtPNum";
			this.txtPNum.Size = new System.Drawing.Size(128, 21);
			this.txtPNum.TabIndex = 17;
			this.txtPNum.Text = "";
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(16, 288);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(80, 24);
			this.label9.TabIndex = 16;
			this.label9.Text = "��ס����";
			// 
			// txtState
			// 
			this.txtState.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ds, "��ס��.����״̬"));
			this.txtState.Location = new System.Drawing.Point(104, 256);
			this.txtState.Name = "txtState";
			this.txtState.Size = new System.Drawing.Size(128, 21);
			this.txtState.TabIndex = 15;
			this.txtState.Text = "";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(16, 258);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(80, 23);
			this.label8.TabIndex = 14;
			this.label8.Text = "����״̬";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(16, 228);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(80, 23);
			this.label7.TabIndex = 12;
			this.label7.Text = "���ʱ��";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(16, 201);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(80, 23);
			this.label6.TabIndex = 10;
			this.label6.Text = "�ֵ�ʱ��";
			// 
			// txtPlace
			// 
			this.txtPlace.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ds, "��ס��.�ͷ�λ��"));
			this.txtPlace.Location = new System.Drawing.Point(104, 169);
			this.txtPlace.Name = "txtPlace";
			this.txtPlace.Size = new System.Drawing.Size(128, 21);
			this.txtPlace.TabIndex = 9;
			this.txtPlace.Text = "";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(16, 171);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(80, 23);
			this.label5.TabIndex = 8;
			this.label5.Text = "�ͷ�λ��";
			// 
			// txtName
			// 
			this.txtName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ds, "��ס��.�ͷ�����"));
			this.txtName.Location = new System.Drawing.Point(104, 140);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(128, 21);
			this.txtName.TabIndex = 7;
			this.txtName.Text = "";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(16, 143);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(80, 23);
			this.label4.TabIndex = 6;
			this.label4.Text = "�ͷ�����";
			// 
			// txtRoomID
			// 
			this.txtRoomID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ds, "��ס��.�ͷ����"));
			this.txtRoomID.Location = new System.Drawing.Point(104, 111);
			this.txtRoomID.Name = "txtRoomID";
			this.txtRoomID.Size = new System.Drawing.Size(128, 21);
			this.txtRoomID.TabIndex = 5;
			this.txtRoomID.Text = "";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(16, 114);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(80, 23);
			this.label3.TabIndex = 4;
			this.label3.Text = "�ͷ����";
			// 
			// txtVipID
			// 
			this.txtVipID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ds, "��ס��.��Ա���"));
			this.txtVipID.Location = new System.Drawing.Point(104, 82);
			this.txtVipID.Name = "txtVipID";
			this.txtVipID.Size = new System.Drawing.Size(128, 21);
			this.txtVipID.TabIndex = 3;
			this.txtVipID.Text = "";
			// 
			// label23
			// 
			this.label23.Location = new System.Drawing.Point(16, 85);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(80, 23);
			this.label23.TabIndex = 2;
			this.label23.Text = "��Ա���";
			// 
			// txtOrderID
			// 
			this.txtOrderID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ds, "��ס��.Ԥ������"));
			this.txtOrderID.Location = new System.Drawing.Point(104, 53);
			this.txtOrderID.Name = "txtOrderID";
			this.txtOrderID.Size = new System.Drawing.Size(128, 21);
			this.txtOrderID.TabIndex = 1;
			this.txtOrderID.Text = "";
			// 
			// label24
			// 
			this.label24.Location = new System.Drawing.Point(16, 56);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(80, 23);
			this.label24.TabIndex = 0;
			this.label24.Text = "Ԥ������";
			// 
			// checkBox1
			// 
			this.checkBox1.Location = new System.Drawing.Point(19, 184);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(56, 24);
			this.checkBox1.TabIndex = 101;
			this.checkBox1.Text = "�޸�";
			this.checkBox1.Visible = false;
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// SelectAndChangeLiveListManagement
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(712, 550);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnChange);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dataGrid1);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnEnd);
			this.Controls.Add(this.btnNext);
			this.Controls.Add(this.btnBack);
			this.Controls.Add(this.btnFirst);
			this.Controls.Add(this.btnAll);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.checkBox1);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(720, 584);
			this.MinimumSize = new System.Drawing.Size(720, 584);
			this.Name = "SelectAndChangeLiveListManagement";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "��ס�����";
			this.Load += new System.EventHandler(this.SelectLiveListManagement_Load);
			((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void SelectLiveListManagement_Load(object sender, System.EventArgs e)
		{
			this.conn.ConnectionString = Config.Settings.ConnStr;
		}

		private void btnAll_Click(object sender, System.EventArgs e)
		{
			this.sqlSelectCommand1.CommandText = "Select * from ��ס��";
			ds.Clear();
			da.Fill(this.ds,"��ס��");
			bmb = this.BindingContext[ds,"��ס��"];
			this.label1.Text = "��ǰ��¼��"+(this.dataGrid1.CurrentRowIndex+1);
			this.label2.Text = "��¼����"+this.bmb.Count;
		}

		private void btnFirst_Click(object sender, System.EventArgs e)
		{
			try
			{
				bmb.Position =0;
				this.label1.Text = "��ǰ��¼��"+(this.dataGrid1.CurrentRowIndex+1);
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
					bmb.Position -=1;
				this.label1.Text = "��ǰ��¼��"+(this.dataGrid1.CurrentRowIndex+1);
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
					bmb.Position +=1;
				this.label1.Text = "��ǰ��¼��"+(this.dataGrid1.CurrentRowIndex+1);
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
				this.label1.Text = "��ǰ��¼��"+(this.dataGrid1.CurrentRowIndex+1);
			}
			catch
			{
			}
		}

		private void btnCancel_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void btnChange_Click(object sender, System.EventArgs e)
		{
	
			if(this.btnChange.Text.Trim() == "��ϸ")
			{
				this.dataGrid1.Visible = false;
				this.groupBox1.Visible = true;				
				this.checkBox1.Visible = true;
				this.checkBox1.Checked = false;
				this.btnChange.Text = "����";
				return;
			}
			if(this.btnChange.Text.Trim() == "����")
			{
				this.groupBox1.Visible = false;
				this.dataGrid1.Visible = true;
				this.checkBox1.Visible = false;
				this.btnChange.Text = "��ϸ";
				return;
			}
	

		}

		private void btnDelete_Click(object sender, System.EventArgs e)
		{
			try
			{
				if(DialogResult.OK == MessageBox.Show("ȷ��ɾ����¼?","ȷ��",MessageBoxButtons.OKCancel,MessageBoxIcon.Question))
				{
					ds.��ס��.Rows[bmb.Position].Delete();
					da.Update(ds,"��ס��");
					this.ds.Clear();
					da.Fill(this.ds,"��ס��");
					bmb=this.BindingContext[ds,"��ס��"];
					this.label1.Text = "��ǰ��¼��"+(this.dataGrid1.CurrentRowIndex+1);
					this.label2.Text = "��¼����"+this.bmb.Count;
					MessageBox.Show("��¼ɾ���ɹ�");
				}
				else
				{

				}
			}
			catch(Exception ex)
			{
				MessageBox.Show("ɾ����Ч"+ex.Message.ToString());
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
					str = "Select * from ��ס�� where ��ס���� like '%"+this.textBox1.Text.Trim()+"%'";
					this.sqlSelectCommand1.CommandText = str;
					this.ds.Clear();
					da.Fill(this.ds,"��ס��");
					bmb=this.BindingContext[ds,"��ס��"];
					this.label1.Text = "��ǰ��¼��"+(this.dataGrid1.CurrentRowIndex+1);
					this.label2.Text = "��¼����"+this.bmb.Count;
		
				}
				if(this.textBox2.Enabled == true && this.textBox2.Text.Trim() != "")
				{
					str = "Select * from ��ס�� where �ͷ���� like '%"+this.textBox2.Text.Trim()+"%'";
					this.sqlSelectCommand1.CommandText = str;
					this.ds.Clear();
					da.Fill(this.ds,"��ס��");
					bmb=this.BindingContext[ds,"��ס��"];
					this.label1.Text = "��ǰ��¼��"+(this.dataGrid1.CurrentRowIndex+1);
					this.label2.Text = "��¼����"+this.bmb.Count;
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

		private void btnSave_Click(object sender, System.EventArgs e)
		{
			try
			{
				bmb.EndCurrentEdit();
				da.Update(ds,"��ס��");
				this.ds.Clear();
				da.Fill(this.ds,"��ס��");
				bmb=this.BindingContext[ds,"��ס��"];
				this.label1.Text = "��ǰ��¼��"+(this.dataGrid1.CurrentRowIndex+1);
				this.label2.Text = "��¼����"+this.bmb.Count;
				MessageBox.Show("�����޸ĳɹ�");
			}
			catch(Exception ex)
			{
				MessageBox.Show("�޸�ʧ��"+ex.Message.ToString());
			}		
		}

		private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
		{
			if(this.checkBox1.Checked == true)
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
	}
}
