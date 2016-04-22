using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data.SqlClient;
using HotelManagementSystem.Config;
using HotelManagementSystem.Data;
//�ͷ���Ϣ��ѯ
namespace HotelManagementSystem.OrderRoomInfoManagement
{
	/// <summary>
	/// SelectOrderRoomInfoManagement ��ժҪ˵����
	/// </summary>
	public class SelectOrderRoomInfoManagement : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnEnd;
		private System.Windows.Forms.Button btnNext;
		private System.Windows.Forms.Button btnBack;
		private System.Windows.Forms.Button btnFirst;
		private System.Windows.Forms.Button btnAll;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.TextBox txtAddBedPrice;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.TextBox txtOperator;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.TextBox txtRemark;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.TextBox txtPhone;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.TextBox txtCompany;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.TextBox txtClient;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.TextBox txtMoney;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.TextBox txtReasom;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox txtLPrice;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox txtRPrice;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox txtPNum;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txtState;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtEndtime;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtStrtime;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtPlace;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtRoomID;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtVipID;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtOrderID;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.Button btnFind;
		/// <summary>
		/// ����������������
		/// </summary>
		private System.ComponentModel.Container components = null;
		private HotelManagementSystem.Data.HotelDataSet ds;
		private System.Windows.Forms.DataGrid dataGrid1;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.Label label24;
		private System.Data.SqlClient.SqlConnection conn;
		private System.Data.SqlClient.SqlDataAdapter da;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
		private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
		private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
		private System.Windows.Forms.TextBox txtSalesman;
		private System.Windows.Forms.TextBox txtID;
		private System.Windows.Forms.TextBox txtDiscount;
		protected BindingManagerBase bmb;

		public SelectOrderRoomInfoManagement()
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
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnEnd = new System.Windows.Forms.Button();
			this.btnNext = new System.Windows.Forms.Button();
			this.btnBack = new System.Windows.Forms.Button();
			this.btnFirst = new System.Windows.Forms.Button();
			this.btnAll = new System.Windows.Forms.Button();
			this.ds = new HotelManagementSystem.Data.HotelDataSet();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
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
			this.txtEndtime = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txtStrtime = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtPlace = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtRoomID = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtVipID = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtOrderID = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.btnFind = new System.Windows.Forms.Button();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.dataGrid1 = new System.Windows.Forms.DataGrid();
			this.label23 = new System.Windows.Forms.Label();
			this.label24 = new System.Windows.Forms.Label();
			this.conn = new System.Data.SqlClient.SqlConnection();
			this.da = new System.Data.SqlClient.SqlDataAdapter();
			this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
			((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(552, 23);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.TabIndex = 52;
			this.btnCancel.Text = "�˳�";
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnEnd
			// 
			this.btnEnd.Location = new System.Drawing.Point(464, 23);
			this.btnEnd.Name = "btnEnd";
			this.btnEnd.TabIndex = 51;
			this.btnEnd.Text = "���";
			this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
			// 
			// btnNext
			// 
			this.btnNext.Location = new System.Drawing.Point(384, 23);
			this.btnNext.Name = "btnNext";
			this.btnNext.TabIndex = 50;
			this.btnNext.Text = "��һ��";
			this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
			// 
			// btnBack
			// 
			this.btnBack.Location = new System.Drawing.Point(304, 23);
			this.btnBack.Name = "btnBack";
			this.btnBack.TabIndex = 49;
			this.btnBack.Text = "��һ��";
			this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
			// 
			// btnFirst
			// 
			this.btnFirst.Location = new System.Drawing.Point(224, 23);
			this.btnFirst.Name = "btnFirst";
			this.btnFirst.TabIndex = 48;
			this.btnFirst.Text = "��ǰ";
			this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
			// 
			// btnAll
			// 
			this.btnAll.Location = new System.Drawing.Point(144, 23);
			this.btnAll.Name = "btnAll";
			this.btnAll.TabIndex = 47;
			this.btnAll.Text = "��ѯ����";
			this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
			// 
			// ds
			// 
			this.ds.DataSetName = "HotelDataSet";
			this.ds.Locale = new System.Globalization.CultureInfo("en-US");
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.checkBox1);
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
			this.groupBox1.Controls.Add(this.txtEndtime);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.txtStrtime);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.txtPlace);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.txtName);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.txtRoomID);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.txtVipID);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.txtOrderID);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(29, 200);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(712, 336);
			this.groupBox1.TabIndex = 53;
			this.groupBox1.TabStop = false;
			// 
			// checkBox1
			// 
			this.checkBox1.AutoCheck = false;
			this.checkBox1.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.ds, "Ԥ����.�Ƿ�Ӵ�"));
			this.checkBox1.Location = new System.Drawing.Point(568, 288);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.TabIndex = 44;
			this.checkBox1.Text = "�Ƿ�Ӵ�";
			// 
			// txtAddBedPrice
			// 
			this.txtAddBedPrice.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ds, "Ԥ����.�Ӵ��۸�"));
			this.txtAddBedPrice.Location = new System.Drawing.Point(568, 230);
			this.txtAddBedPrice.Name = "txtAddBedPrice";
			this.txtAddBedPrice.ReadOnly = true;
			this.txtAddBedPrice.Size = new System.Drawing.Size(128, 21);
			this.txtAddBedPrice.TabIndex = 43;
			this.txtAddBedPrice.Text = "";
			// 
			// label22
			// 
			this.label22.Location = new System.Drawing.Point(480, 233);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(80, 23);
			this.label22.TabIndex = 42;
			this.label22.Text = "�Ӵ��۸�";
			// 
			// txtSalesman
			// 
			this.txtSalesman.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ds, "Ԥ����.ҵ��Ա"));
			this.txtSalesman.Location = new System.Drawing.Point(568, 190);
			this.txtSalesman.Name = "txtSalesman";
			this.txtSalesman.ReadOnly = true;
			this.txtSalesman.Size = new System.Drawing.Size(128, 21);
			this.txtSalesman.TabIndex = 41;
			this.txtSalesman.Text = "";
			// 
			// label21
			// 
			this.label21.Location = new System.Drawing.Point(480, 192);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(80, 23);
			this.label21.TabIndex = 40;
			this.label21.Text = "ҵ��Ա";
			// 
			// txtOperator
			// 
			this.txtOperator.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ds, "Ԥ����.����Ա"));
			this.txtOperator.Location = new System.Drawing.Point(568, 151);
			this.txtOperator.Name = "txtOperator";
			this.txtOperator.ReadOnly = true;
			this.txtOperator.Size = new System.Drawing.Size(128, 21);
			this.txtOperator.TabIndex = 39;
			this.txtOperator.Text = "";
			// 
			// label20
			// 
			this.label20.Location = new System.Drawing.Point(480, 152);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(80, 23);
			this.label20.TabIndex = 38;
			this.label20.Text = "����Ա";
			// 
			// txtRemark
			// 
			this.txtRemark.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ds, "Ԥ����.��ע"));
			this.txtRemark.Location = new System.Drawing.Point(568, 112);
			this.txtRemark.Name = "txtRemark";
			this.txtRemark.ReadOnly = true;
			this.txtRemark.Size = new System.Drawing.Size(128, 21);
			this.txtRemark.TabIndex = 37;
			this.txtRemark.Text = "";
			// 
			// label19
			// 
			this.label19.Location = new System.Drawing.Point(480, 112);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(80, 23);
			this.label19.TabIndex = 36;
			this.label19.Text = "��ע";
			// 
			// txtPhone
			// 
			this.txtPhone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ds, "Ԥ����.��ϵ�绰"));
			this.txtPhone.Location = new System.Drawing.Point(568, 72);
			this.txtPhone.Name = "txtPhone";
			this.txtPhone.ReadOnly = true;
			this.txtPhone.Size = new System.Drawing.Size(128, 21);
			this.txtPhone.TabIndex = 35;
			this.txtPhone.Text = "";
			// 
			// label18
			// 
			this.label18.Location = new System.Drawing.Point(480, 72);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(80, 23);
			this.label18.TabIndex = 34;
			this.label18.Text = "��ϵ�绰";
			// 
			// txtCompany
			// 
			this.txtCompany.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ds, "Ԥ����.Ԥ����˾"));
			this.txtCompany.Location = new System.Drawing.Point(568, 32);
			this.txtCompany.Name = "txtCompany";
			this.txtCompany.ReadOnly = true;
			this.txtCompany.Size = new System.Drawing.Size(128, 21);
			this.txtCompany.TabIndex = 33;
			this.txtCompany.Text = "";
			// 
			// label17
			// 
			this.label17.Location = new System.Drawing.Point(480, 32);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(80, 23);
			this.label17.TabIndex = 32;
			this.label17.Text = "Ԥ����˾";
			// 
			// txtID
			// 
			this.txtID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ds, "Ԥ����.���֤"));
			this.txtID.Location = new System.Drawing.Point(336, 298);
			this.txtID.Name = "txtID";
			this.txtID.ReadOnly = true;
			this.txtID.Size = new System.Drawing.Size(128, 21);
			this.txtID.TabIndex = 31;
			this.txtID.Text = "";
			// 
			// label16
			// 
			this.label16.Location = new System.Drawing.Point(248, 301);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(80, 24);
			this.label16.TabIndex = 30;
			this.label16.Text = "���֤";
			// 
			// txtClient
			// 
			this.txtClient.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ds, "Ԥ����.Ԥ����"));
			this.txtClient.Location = new System.Drawing.Point(336, 264);
			this.txtClient.Name = "txtClient";
			this.txtClient.ReadOnly = true;
			this.txtClient.Size = new System.Drawing.Size(128, 21);
			this.txtClient.TabIndex = 29;
			this.txtClient.Text = "";
			// 
			// label15
			// 
			this.label15.Location = new System.Drawing.Point(248, 265);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(80, 24);
			this.label15.TabIndex = 28;
			this.label15.Text = "Ԥ����";
			// 
			// txtMoney
			// 
			this.txtMoney.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ds, "Ԥ����.Ԥ�տ�"));
			this.txtMoney.Location = new System.Drawing.Point(336, 220);
			this.txtMoney.Name = "txtMoney";
			this.txtMoney.ReadOnly = true;
			this.txtMoney.Size = new System.Drawing.Size(128, 21);
			this.txtMoney.TabIndex = 27;
			this.txtMoney.Text = "";
			// 
			// label14
			// 
			this.label14.Location = new System.Drawing.Point(248, 223);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(80, 24);
			this.label14.TabIndex = 26;
			this.label14.Text = "Ԥ�տ�";
			// 
			// txtReasom
			// 
			this.txtReasom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ds, "Ԥ����.�ۿ�ԭ��"));
			this.txtReasom.Location = new System.Drawing.Point(336, 181);
			this.txtReasom.Name = "txtReasom";
			this.txtReasom.ReadOnly = true;
			this.txtReasom.Size = new System.Drawing.Size(128, 21);
			this.txtReasom.TabIndex = 25;
			this.txtReasom.Text = "";
			// 
			// label13
			// 
			this.label13.Location = new System.Drawing.Point(248, 184);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(80, 24);
			this.label13.TabIndex = 24;
			this.label13.Text = "�ۿ�ԭ��";
			// 
			// txtDiscount
			// 
			this.txtDiscount.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ds, "Ԥ����.�ۿ�"));
			this.txtDiscount.Location = new System.Drawing.Point(336, 144);
			this.txtDiscount.Name = "txtDiscount";
			this.txtDiscount.ReadOnly = true;
			this.txtDiscount.Size = new System.Drawing.Size(128, 21);
			this.txtDiscount.TabIndex = 23;
			this.txtDiscount.Text = "";
			// 
			// label12
			// 
			this.label12.Location = new System.Drawing.Point(248, 146);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(80, 24);
			this.label12.TabIndex = 22;
			this.label12.Text = "�ۿ�";
			// 
			// txtLPrice
			// 
			this.txtLPrice.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ds, "Ԥ����.��ס�۸�"));
			this.txtLPrice.Location = new System.Drawing.Point(336, 107);
			this.txtLPrice.Name = "txtLPrice";
			this.txtLPrice.ReadOnly = true;
			this.txtLPrice.Size = new System.Drawing.Size(128, 21);
			this.txtLPrice.TabIndex = 21;
			this.txtLPrice.Text = "";
			// 
			// label11
			// 
			this.label11.Location = new System.Drawing.Point(248, 108);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(80, 24);
			this.label11.TabIndex = 20;
			this.label11.Text = "��ס�۸�";
			// 
			// txtRPrice
			// 
			this.txtRPrice.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ds, "Ԥ����.�ͷ��۸�"));
			this.txtRPrice.Location = new System.Drawing.Point(336, 70);
			this.txtRPrice.Name = "txtRPrice";
			this.txtRPrice.ReadOnly = true;
			this.txtRPrice.Size = new System.Drawing.Size(128, 21);
			this.txtRPrice.TabIndex = 19;
			this.txtRPrice.Text = "";
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(248, 70);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(80, 24);
			this.label10.TabIndex = 18;
			this.label10.Text = "�ͷ��۸�";
			// 
			// txtPNum
			// 
			this.txtPNum.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ds, "Ԥ����.��ס����"));
			this.txtPNum.Location = new System.Drawing.Point(336, 32);
			this.txtPNum.Name = "txtPNum";
			this.txtPNum.ReadOnly = true;
			this.txtPNum.Size = new System.Drawing.Size(128, 21);
			this.txtPNum.TabIndex = 17;
			this.txtPNum.Text = "";
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(248, 32);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(80, 24);
			this.label9.TabIndex = 16;
			this.label9.Text = "��ס����";
			// 
			// txtState
			// 
			this.txtState.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ds, "Ԥ����.����״̬"));
			this.txtState.Location = new System.Drawing.Point(104, 298);
			this.txtState.Name = "txtState";
			this.txtState.ReadOnly = true;
			this.txtState.Size = new System.Drawing.Size(128, 21);
			this.txtState.TabIndex = 15;
			this.txtState.Text = "";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(16, 304);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(80, 23);
			this.label8.TabIndex = 14;
			this.label8.Text = "����״̬";
			// 
			// txtEndtime
			// 
			this.txtEndtime.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ds, "Ԥ����.���ʱ��"));
			this.txtEndtime.Location = new System.Drawing.Point(104, 260);
			this.txtEndtime.Name = "txtEndtime";
			this.txtEndtime.ReadOnly = true;
			this.txtEndtime.Size = new System.Drawing.Size(128, 21);
			this.txtEndtime.TabIndex = 13;
			this.txtEndtime.Text = "";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(16, 264);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(80, 23);
			this.label7.TabIndex = 12;
			this.label7.Text = "���ʱ��";
			// 
			// txtStrtime
			// 
			this.txtStrtime.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ds, "Ԥ����.�ֵ�ʱ��"));
			this.txtStrtime.Location = new System.Drawing.Point(104, 222);
			this.txtStrtime.Name = "txtStrtime";
			this.txtStrtime.ReadOnly = true;
			this.txtStrtime.Size = new System.Drawing.Size(128, 21);
			this.txtStrtime.TabIndex = 11;
			this.txtStrtime.Text = "";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(16, 224);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(80, 23);
			this.label6.TabIndex = 10;
			this.label6.Text = "�ֵ�ʱ��";
			// 
			// txtPlace
			// 
			this.txtPlace.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ds, "Ԥ����.�ͷ�λ��"));
			this.txtPlace.Location = new System.Drawing.Point(104, 184);
			this.txtPlace.Name = "txtPlace";
			this.txtPlace.ReadOnly = true;
			this.txtPlace.Size = new System.Drawing.Size(128, 21);
			this.txtPlace.TabIndex = 9;
			this.txtPlace.Text = "";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(16, 184);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(80, 23);
			this.label5.TabIndex = 8;
			this.label5.Text = "�ͷ�λ��";
			// 
			// txtName
			// 
			this.txtName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ds, "Ԥ����.�ͷ�����"));
			this.txtName.Location = new System.Drawing.Point(104, 146);
			this.txtName.Name = "txtName";
			this.txtName.ReadOnly = true;
			this.txtName.Size = new System.Drawing.Size(128, 21);
			this.txtName.TabIndex = 7;
			this.txtName.Text = "";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(16, 152);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(80, 23);
			this.label4.TabIndex = 6;
			this.label4.Text = "�ͷ�����";
			// 
			// txtRoomID
			// 
			this.txtRoomID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ds, "Ԥ����.�ͷ����"));
			this.txtRoomID.Location = new System.Drawing.Point(104, 108);
			this.txtRoomID.Name = "txtRoomID";
			this.txtRoomID.ReadOnly = true;
			this.txtRoomID.Size = new System.Drawing.Size(128, 21);
			this.txtRoomID.TabIndex = 5;
			this.txtRoomID.Text = "";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(16, 112);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(80, 23);
			this.label3.TabIndex = 4;
			this.label3.Text = "�ͷ����";
			// 
			// txtVipID
			// 
			this.txtVipID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ds, "Ԥ����.��Ա���"));
			this.txtVipID.Location = new System.Drawing.Point(104, 70);
			this.txtVipID.Name = "txtVipID";
			this.txtVipID.ReadOnly = true;
			this.txtVipID.Size = new System.Drawing.Size(128, 21);
			this.txtVipID.TabIndex = 3;
			this.txtVipID.Text = "";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(16, 72);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(80, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "��Ա���";
			// 
			// txtOrderID
			// 
			this.txtOrderID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ds, "Ԥ����.Ԥ������"));
			this.txtOrderID.Location = new System.Drawing.Point(104, 32);
			this.txtOrderID.Name = "txtOrderID";
			this.txtOrderID.ReadOnly = true;
			this.txtOrderID.Size = new System.Drawing.Size(128, 21);
			this.txtOrderID.TabIndex = 1;
			this.txtOrderID.Text = "";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(16, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(80, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Ԥ������";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.radioButton1);
			this.groupBox2.Controls.Add(this.btnFind);
			this.groupBox2.Controls.Add(this.textBox2);
			this.groupBox2.Controls.Add(this.radioButton2);
			this.groupBox2.Controls.Add(this.textBox1);
			this.groupBox2.Location = new System.Drawing.Point(30, 536);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(712, 64);
			this.groupBox2.TabIndex = 54;
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
			// dataGrid1
			// 
			this.dataGrid1.DataMember = "Ԥ����";
			this.dataGrid1.DataSource = this.ds;
			this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGrid1.Location = new System.Drawing.Point(30, 57);
			this.dataGrid1.Name = "dataGrid1";
			this.dataGrid1.ReadOnly = true;
			this.dataGrid1.Size = new System.Drawing.Size(712, 133);
			this.dataGrid1.TabIndex = 55;
			// 
			// label23
			// 
			this.label23.Location = new System.Drawing.Point(32, 32);
			this.label23.Name = "label23";
			this.label23.TabIndex = 56;
			this.label23.Text = "��ǰ��¼��";
			this.label23.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// label24
			// 
			this.label24.Location = new System.Drawing.Point(640, 32);
			this.label24.Name = "label24";
			this.label24.TabIndex = 57;
			this.label24.Text = "��¼����";
			this.label24.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// da
			// 
			this.da.DeleteCommand = this.sqlDeleteCommand1;
			this.da.InsertCommand = this.sqlInsertCommand1;
			this.da.SelectCommand = this.sqlSelectCommand1;
			this.da.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																						 new System.Data.Common.DataTableMapping("Table", "Ԥ����", new System.Data.Common.DataColumnMapping[] {
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
			this.sqlDeleteCommand1.CommandText = "DELETE FROM Ԥ���� WHERE (Ԥ������ = @Original_Ԥ������) AND (ҵ��Ա = @Original_ҵ��Ա OR @Origin" +
				"al_ҵ��Ա IS NULL AND ҵ��Ա IS NULL) AND (��Ա��� = @Original_��Ա��� OR @Original_��Ա��� IS " +
				"NULL AND ��Ա��� IS NULL) AND (��ס���� = @Original_��ס���� OR @Original_��ס���� IS NULL AND " +
				"��ס���� IS NULL) AND (��ס�۸� = @Original_��ס�۸� OR @Original_��ס�۸� IS NULL AND ��ס�۸� IS N" +
				"ULL) AND (�Ӵ��۸� = @Original_�Ӵ��۸� OR @Original_�Ӵ��۸� IS NULL AND �Ӵ��۸� IS NULL) AND " +
				"(����״̬ = @Original_����״̬ OR @Original_����״̬ IS NULL AND ����״̬ IS NULL) AND (��ע = @Or" +
				"iginal_��ע OR @Original_��ע IS NULL AND ��ע IS NULL) AND (�ͷ��۸� = @Original_�ͷ��۸� OR " +
				"@Original_�ͷ��۸� IS NULL AND �ͷ��۸� IS NULL) AND (�ͷ�λ�� = @Original_�ͷ�λ�� OR @Original" +
				"_�ͷ�λ�� IS NULL AND �ͷ�λ�� IS NULL) AND (�ͷ����� = @Original_�ͷ����� OR @Original_�ͷ����� IS " +
				"NULL AND �ͷ����� IS NULL) AND (�ͷ���� = @Original_�ͷ����) AND (�ۿ� = @Original_�ۿ� OR @Or" +
				"iginal_�ۿ� IS NULL AND �ۿ� IS NULL) AND (�ۿ�ԭ�� = @Original_�ۿ�ԭ�� OR @Original_�ۿ�ԭ�� I" +
				"S NULL AND �ۿ�ԭ�� IS NULL) AND (�ֵ�ʱ�� = @Original_�ֵ�ʱ�� OR @Original_�ֵ�ʱ�� IS NULL AN" +
				"D �ֵ�ʱ�� IS NULL) AND (����Ա = @Original_����Ա OR @Original_����Ա IS NULL AND ����Ա IS NUL" +
				"L) AND (�Ƿ�Ӵ� = @Original_�Ƿ�Ӵ� OR @Original_�Ƿ�Ӵ� IS NULL AND �Ƿ�Ӵ� IS NULL) AND (��" +
				"��ʱ�� = @Original_���ʱ�� OR @Original_���ʱ�� IS NULL AND ���ʱ�� IS NULL) AND (��ϵ�绰 = @Or" +
				"iginal_��ϵ�绰 OR @Original_��ϵ�绰 IS NULL AND ��ϵ�绰 IS NULL) AND (���֤ = @Original_���֤" +
				" OR @Original_���֤ IS NULL AND ���֤ IS NULL) AND (Ԥ�տ� = @Original_Ԥ�տ� OR @Original" +
				"_Ԥ�տ� IS NULL AND Ԥ�տ� IS NULL) AND (Ԥ���� = @Original_Ԥ���� OR @Original_Ԥ���� IS NULL " +
				"AND Ԥ���� IS NULL) AND (Ԥ����˾ = @Original_Ԥ����˾ OR @Original_Ԥ����˾ IS NULL AND Ԥ����˾ I" +
				"S NULL)";
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
			this.sqlInsertCommand1.CommandText = @"INSERT INTO Ԥ����(Ԥ������, ��Ա���, �ͷ����, �ͷ�����, �ͷ�λ��, �ֵ�ʱ��, ���ʱ��, ����״̬, ��ס����, �ͷ��۸�, ��ס�۸�, �ۿ�, �ۿ�ԭ��, �Ƿ�Ӵ�, �Ӵ��۸�, Ԥ�տ�, Ԥ����, ���֤, Ԥ����˾, ��ϵ�绰, ��ע, ����Ա, ҵ��Ա) VALUES (@Ԥ������, @��Ա���, @�ͷ����, @�ͷ�����, @�ͷ�λ��, @�ֵ�ʱ��, @���ʱ��, @����״̬, @��ס����, @�ͷ��۸�, @��ס�۸�, @�ۿ�, @�ۿ�ԭ��, @�Ƿ�Ӵ�, @�Ӵ��۸�, @Ԥ�տ�, @Ԥ����, @���֤, @Ԥ����˾, @��ϵ�绰, @��ע, @����Ա, @ҵ��Ա); SELECT Ԥ������, ��Ա���, �ͷ����, �ͷ�����, �ͷ�λ��, �ֵ�ʱ��, ���ʱ��, ����״̬, ��ס����, �ͷ��۸�, ��ס�۸�, �ۿ�, �ۿ�ԭ��, �Ƿ�Ӵ�, �Ӵ��۸�, Ԥ�տ�, Ԥ����, ���֤, Ԥ����˾, ��ϵ�绰, ��ע, ����Ա, ҵ��Ա FROM Ԥ���� WHERE (Ԥ������ = @Ԥ������)";
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
				", �Ƿ�Ӵ�, �Ӵ��۸�, Ԥ�տ�, Ԥ����, ���֤, Ԥ����˾, ��ϵ�绰, ��ע, ����Ա, ҵ��Ա FROM Ԥ����";
			this.sqlSelectCommand1.Connection = this.conn;
			// 
			// sqlUpdateCommand1
			// 
			this.sqlUpdateCommand1.CommandText = "UPDATE Ԥ���� SET Ԥ������ = @Ԥ������, ��Ա��� = @��Ա���, �ͷ���� = @�ͷ����, �ͷ����� = @�ͷ�����, �ͷ�λ�� = @�ͷ�" +
				"λ��, �ֵ�ʱ�� = @�ֵ�ʱ��, ���ʱ�� = @���ʱ��, ����״̬ = @����״̬, ��ס���� = @��ס����, �ͷ��۸� = @�ͷ��۸�, ��ס�۸� =" +
				" @��ס�۸�, �ۿ� = @�ۿ�, �ۿ�ԭ�� = @�ۿ�ԭ��, �Ƿ�Ӵ� = @�Ƿ�Ӵ�, �Ӵ��۸� = @�Ӵ��۸�, Ԥ�տ� = @Ԥ�տ�, Ԥ���� = @Ԥ" +
				"����, ���֤ = @���֤, Ԥ����˾ = @Ԥ����˾, ��ϵ�绰 = @��ϵ�绰, ��ע = @��ע, ����Ա = @����Ա, ҵ��Ա = @ҵ��Ա WHE" +
				"RE (Ԥ������ = @Original_Ԥ������) AND (ҵ��Ա = @Original_ҵ��Ա OR @Original_ҵ��Ա IS NULL AND" +
				" ҵ��Ա IS NULL) AND (��Ա��� = @Original_��Ա��� OR @Original_��Ա��� IS NULL AND ��Ա��� IS N" +
				"ULL) AND (��ס���� = @Original_��ס���� OR @Original_��ס���� IS NULL AND ��ס���� IS NULL) AND " +
				"(��ס�۸� = @Original_��ס�۸� OR @Original_��ס�۸� IS NULL AND ��ס�۸� IS NULL) AND (�Ӵ��۸� = @" +
				"Original_�Ӵ��۸� OR @Original_�Ӵ��۸� IS NULL AND �Ӵ��۸� IS NULL) AND (����״̬ = @Original_" +
				"����״̬ OR @Original_����״̬ IS NULL AND ����״̬ IS NULL) AND (��ע = @Original_��ע OR @Orig" +
				"inal_��ע IS NULL AND ��ע IS NULL) AND (�ͷ��۸� = @Original_�ͷ��۸� OR @Original_�ͷ��۸� IS " +
				"NULL AND �ͷ��۸� IS NULL) AND (�ͷ�λ�� = @Original_�ͷ�λ�� OR @Original_�ͷ�λ�� IS NULL AND " +
				"�ͷ�λ�� IS NULL) AND (�ͷ����� = @Original_�ͷ����� OR @Original_�ͷ����� IS NULL AND �ͷ����� IS N" +
				"ULL) AND (�ͷ���� = @Original_�ͷ����) AND (�ۿ� = @Original_�ۿ� OR @Original_�ۿ� IS NULL " +
				"AND �ۿ� IS NULL) AND (�ۿ�ԭ�� = @Original_�ۿ�ԭ�� OR @Original_�ۿ�ԭ�� IS NULL AND �ۿ�ԭ�� IS" +
				" NULL) AND (�ֵ�ʱ�� = @Original_�ֵ�ʱ�� OR @Original_�ֵ�ʱ�� IS NULL AND �ֵ�ʱ�� IS NULL) AN" +
				"D (����Ա = @Original_����Ա OR @Original_����Ա IS NULL AND ����Ա IS NULL) AND (�Ƿ�Ӵ� = @Or" +
				"iginal_�Ƿ�Ӵ� OR @Original_�Ƿ�Ӵ� IS NULL AND �Ƿ�Ӵ� IS NULL) AND (���ʱ�� = @Original_���" +
				"ʱ�� OR @Original_���ʱ�� IS NULL AND ���ʱ�� IS NULL) AND (��ϵ�绰 = @Original_��ϵ�绰 OR @Or" +
				"iginal_��ϵ�绰 IS NULL AND ��ϵ�绰 IS NULL) AND (���֤ = @Original_���֤ OR @Original_���֤ " +
				"IS NULL AND ���֤ IS NULL) AND (Ԥ�տ� = @Original_Ԥ�տ� OR @Original_Ԥ�տ� IS NULL AND Ԥ" +
				"�տ� IS NULL) AND (Ԥ���� = @Original_Ԥ���� OR @Original_Ԥ���� IS NULL AND Ԥ���� IS NULL) A" +
				"ND (Ԥ����˾ = @Original_Ԥ����˾ OR @Original_Ԥ����˾ IS NULL AND Ԥ����˾ IS NULL); SELECT Ԥ��" +
				"����, ��Ա���, �ͷ����, �ͷ�����, �ͷ�λ��, �ֵ�ʱ��, ���ʱ��, ����״̬, ��ס����, �ͷ��۸�, ��ס�۸�, �ۿ�, �ۿ�ԭ��, �Ƿ�Ӵ�, " +
				"�Ӵ��۸�, Ԥ�տ�, Ԥ����, ���֤, Ԥ����˾, ��ϵ�绰, ��ע, ����Ա, ҵ��Ա FROM Ԥ���� WHERE (Ԥ������ = @Ԥ������)";
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
			// SelectOrderRoomInfoManagement
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(768, 614);
			this.Controls.Add(this.label24);
			this.Controls.Add(this.label23);
			this.Controls.Add(this.dataGrid1);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnEnd);
			this.Controls.Add(this.btnNext);
			this.Controls.Add(this.btnBack);
			this.Controls.Add(this.btnFirst);
			this.Controls.Add(this.btnAll);
			this.Controls.Add(this.groupBox2);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(776, 648);
			this.MinimumSize = new System.Drawing.Size(776, 648);
			this.Name = "SelectOrderRoomInfoManagement";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "������Ϣ��ѯ";
			this.Load += new System.EventHandler(this.SelectOrderRoomInfoManagement_Load);
			((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void btnAll_Click(object sender, System.EventArgs e)
		{
			this.sqlSelectCommand1.CommandText = "Select * from Ԥ����";
			ds.Clear();
			da.Fill(this.ds,"Ԥ����");
			bmb = this.BindingContext[ds,"Ԥ����"];
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
					str = "Select * from Ԥ���� where Ԥ������ like '%"+this.textBox1.Text.Trim()+"%'";
					this.sqlSelectCommand1.CommandText = str;
					this.ds.Clear();
					da.Fill(this.ds,"Ԥ����");
					bmb=this.BindingContext[ds,"Ԥ����"];
					this.label23.Text = "��ǰ��¼��"+(this.dataGrid1.CurrentRowIndex+1);
					this.label24.Text = "��¼����"+this.bmb.Count;
		
				}
				if(this.textBox2.Enabled == true && this.textBox2.Text.Trim() != "")
				{
					str = "Select * from Ԥ���� where �ͷ���� like '%"+this.textBox2.Text.Trim()+"%'";
					this.sqlSelectCommand1.CommandText = str;
					this.ds.Clear();
					da.Fill(this.ds,"Ԥ����");
					bmb=this.BindingContext[ds,"Ԥ����"];
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

		private void SelectOrderRoomInfoManagement_Load(object sender, System.EventArgs e)
		{
			this.conn.ConnectionString = Config.Settings.ConnStr;
		}
	
	}
}
