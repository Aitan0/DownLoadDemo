using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using HotelManagementSystem.Data;
using HotelManagementSystem.Config;
//结算信息查询
namespace HotelManagementSystem.AccountInfoManagement
{
	/// <summary>
	/// SelectAccountInfoManagement 的摘要说明。
	/// </summary>
	public class SelectAccountInfoManagement : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
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
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.TextBox txtBillID;
		private System.Windows.Forms.TextBox txtInID;
		private System.Windows.Forms.TextBox txtRoomID;
		private System.Windows.Forms.TextBox txtType;
		private System.Windows.Forms.TextBox txtPosition;
		private System.Windows.Forms.TextBox txtPrice;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.TextBox txtIDCard;
		private System.Windows.Forms.TextBox txtContents;
		private System.Windows.Forms.TextBox txtMoney;
		private System.Windows.Forms.TextBox txtDiscount;
		private System.Windows.Forms.TextBox txtRemarks;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.RadioButton radioButton3;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.RadioButton radioButton4;
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;
		private HotelManagementSystem.Data.HotelDataSet ds;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.TextBox textBox6;
		private System.Data.SqlClient.SqlConnection conn;
		private System.Data.SqlClient.SqlDataAdapter da;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
		private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
		private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
		BindingManagerBase bmb;

		public SelectAccountInfoManagement()
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
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.radioButton4 = new System.Windows.Forms.RadioButton();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.radioButton3 = new System.Windows.Forms.RadioButton();
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
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.txtRemarks = new System.Windows.Forms.TextBox();
			this.label16 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.txtDiscount = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.txtMoney = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.txtContents = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.txtIDCard = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txtPrice = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtPosition = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtType = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtRoomID = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtInID = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtBillID = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.conn = new System.Data.SqlClient.SqlConnection();
			this.da = new System.Data.SqlClient.SqlDataAdapter();
			this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(608, 40);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(88, 23);
			this.label10.TabIndex = 50;
			this.label10.Text = "记录数：";
			this.label10.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(8, 40);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(88, 23);
			this.label9.TabIndex = 49;
			this.label9.Text = "当前记录：";
			this.label9.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.textBox4);
			this.groupBox2.Controls.Add(this.radioButton4);
			this.groupBox2.Controls.Add(this.textBox3);
			this.groupBox2.Controls.Add(this.radioButton3);
			this.groupBox2.Controls.Add(this.textBox2);
			this.groupBox2.Controls.Add(this.radioButton2);
			this.groupBox2.Controls.Add(this.radioButton1);
			this.groupBox2.Controls.Add(this.textBox1);
			this.groupBox2.Controls.Add(this.btnFind);
			this.groupBox2.Location = new System.Drawing.Point(56, 453);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(616, 80);
			this.groupBox2.TabIndex = 48;
			this.groupBox2.TabStop = false;
			// 
			// textBox4
			// 
			this.textBox4.Enabled = false;
			this.textBox4.Location = new System.Drawing.Point(368, 48);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(144, 21);
			this.textBox4.TabIndex = 15;
			this.textBox4.Text = "";
			// 
			// radioButton4
			// 
			this.radioButton4.Location = new System.Drawing.Point(296, 48);
			this.radioButton4.Name = "radioButton4";
			this.radioButton4.Size = new System.Drawing.Size(73, 24);
			this.radioButton4.TabIndex = 14;
			this.radioButton4.Text = "客房类型";
			this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
			// 
			// textBox3
			// 
			this.textBox3.Enabled = false;
			this.textBox3.Location = new System.Drawing.Point(120, 48);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(144, 21);
			this.textBox3.TabIndex = 13;
			this.textBox3.Text = "";
			// 
			// radioButton3
			// 
			this.radioButton3.Location = new System.Drawing.Point(32, 48);
			this.radioButton3.Name = "radioButton3";
			this.radioButton3.Size = new System.Drawing.Size(73, 24);
			this.radioButton3.TabIndex = 12;
			this.radioButton3.Text = "客房编号";
			this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
			// 
			// textBox2
			// 
			this.textBox2.Enabled = false;
			this.textBox2.Location = new System.Drawing.Point(368, 16);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(144, 21);
			this.textBox2.TabIndex = 11;
			this.textBox2.Text = "";
			// 
			// radioButton2
			// 
			this.radioButton2.Location = new System.Drawing.Point(296, 16);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(73, 24);
			this.radioButton2.TabIndex = 10;
			this.radioButton2.Text = "入住单号";
			this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
			// 
			// radioButton1
			// 
			this.radioButton1.Location = new System.Drawing.Point(32, 16);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(73, 24);
			this.radioButton1.TabIndex = 9;
			this.radioButton1.Text = "帐单编号";
			this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
			// 
			// textBox1
			// 
			this.textBox1.Enabled = false;
			this.textBox1.Location = new System.Drawing.Point(120, 16);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(144, 21);
			this.textBox1.TabIndex = 8;
			this.textBox1.Text = "";
			// 
			// btnFind
			// 
			this.btnFind.Location = new System.Drawing.Point(528, 32);
			this.btnFind.Name = "btnFind";
			this.btnFind.TabIndex = 7;
			this.btnFind.Text = "查询";
			this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(525, 24);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.TabIndex = 47;
			this.btnCancel.Text = "退出";
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnEnd
			// 
			this.btnEnd.Location = new System.Drawing.Point(444, 24);
			this.btnEnd.Name = "btnEnd";
			this.btnEnd.TabIndex = 46;
			this.btnEnd.Text = "最后";
			this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
			// 
			// btnNext
			// 
			this.btnNext.Location = new System.Drawing.Point(363, 24);
			this.btnNext.Name = "btnNext";
			this.btnNext.TabIndex = 45;
			this.btnNext.Text = "下一个";
			this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
			// 
			// btnBack
			// 
			this.btnBack.Location = new System.Drawing.Point(282, 24);
			this.btnBack.Name = "btnBack";
			this.btnBack.TabIndex = 44;
			this.btnBack.Text = "上一个";
			this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
			// 
			// btnFirst
			// 
			this.btnFirst.Location = new System.Drawing.Point(201, 24);
			this.btnFirst.Name = "btnFirst";
			this.btnFirst.TabIndex = 43;
			this.btnFirst.Text = "最前";
			this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
			// 
			// btnAll
			// 
			this.btnAll.Location = new System.Drawing.Point(120, 24);
			this.btnAll.Name = "btnAll";
			this.btnAll.TabIndex = 42;
			this.btnAll.Text = "查询所有";
			this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
			// 
			// dataGrid1
			// 
			this.dataGrid1.DataMember = "帐单明细";
			this.dataGrid1.DataSource = this.ds;
			this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGrid1.Location = new System.Drawing.Point(56, 64);
			this.dataGrid1.Name = "dataGrid1";
			this.dataGrid1.ReadOnly = true;
			this.dataGrid1.Size = new System.Drawing.Size(616, 151);
			this.dataGrid1.TabIndex = 41;
			// 
			// ds
			// 
			this.ds.DataSetName = "HotelDataSet";
			this.ds.Locale = new System.Globalization.CultureInfo("en-US");
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.textBox6);
			this.groupBox1.Controls.Add(this.textBox5);
			this.groupBox1.Controls.Add(this.txtRemarks);
			this.groupBox1.Controls.Add(this.label16);
			this.groupBox1.Controls.Add(this.label15);
			this.groupBox1.Controls.Add(this.txtDiscount);
			this.groupBox1.Controls.Add(this.label14);
			this.groupBox1.Controls.Add(this.label13);
			this.groupBox1.Controls.Add(this.txtMoney);
			this.groupBox1.Controls.Add(this.label12);
			this.groupBox1.Controls.Add(this.txtContents);
			this.groupBox1.Controls.Add(this.label11);
			this.groupBox1.Controls.Add(this.txtIDCard);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.txtName);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.txtPrice);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.txtPosition);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.txtType);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.txtRoomID);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.txtInID);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.txtBillID);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(56, 220);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(616, 232);
			this.groupBox1.TabIndex = 40;
			this.groupBox1.TabStop = false;
			// 
			// textBox6
			// 
			this.textBox6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ds, "帐单明细.结算日期"));
			this.textBox6.Location = new System.Drawing.Point(408, 168);
			this.textBox6.Name = "textBox6";
			this.textBox6.ReadOnly = true;
			this.textBox6.Size = new System.Drawing.Size(184, 21);
			this.textBox6.TabIndex = 29;
			this.textBox6.Text = "";
			// 
			// textBox5
			// 
			this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ds, "帐单明细.入住时间"));
			this.textBox5.Location = new System.Drawing.Point(408, 111);
			this.textBox5.Name = "textBox5";
			this.textBox5.ReadOnly = true;
			this.textBox5.Size = new System.Drawing.Size(184, 21);
			this.textBox5.TabIndex = 28;
			this.textBox5.Text = "";
			// 
			// txtRemarks
			// 
			this.txtRemarks.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ds, "帐单明细.备注"));
			this.txtRemarks.Location = new System.Drawing.Point(408, 198);
			this.txtRemarks.Name = "txtRemarks";
			this.txtRemarks.ReadOnly = true;
			this.txtRemarks.Size = new System.Drawing.Size(184, 21);
			this.txtRemarks.TabIndex = 27;
			this.txtRemarks.Text = "";
			// 
			// label16
			// 
			this.label16.Location = new System.Drawing.Point(320, 200);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(72, 23);
			this.label16.TabIndex = 26;
			this.label16.Text = "备注";
			this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label15
			// 
			this.label15.Location = new System.Drawing.Point(320, 168);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(72, 23);
			this.label15.TabIndex = 24;
			this.label15.Text = "结算日期";
			this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtDiscount
			// 
			this.txtDiscount.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ds, "帐单明细.折扣"));
			this.txtDiscount.Location = new System.Drawing.Point(408, 140);
			this.txtDiscount.Name = "txtDiscount";
			this.txtDiscount.ReadOnly = true;
			this.txtDiscount.Size = new System.Drawing.Size(184, 21);
			this.txtDiscount.TabIndex = 23;
			this.txtDiscount.Text = "";
			// 
			// label14
			// 
			this.label14.Location = new System.Drawing.Point(320, 141);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(72, 23);
			this.label14.TabIndex = 22;
			this.label14.Text = "折扣";
			this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label13
			// 
			this.label13.Location = new System.Drawing.Point(320, 112);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(72, 23);
			this.label13.TabIndex = 20;
			this.label13.Text = "入住时间";
			this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtMoney
			// 
			this.txtMoney.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ds, "帐单明细.消费金额"));
			this.txtMoney.Location = new System.Drawing.Point(408, 82);
			this.txtMoney.Name = "txtMoney";
			this.txtMoney.ReadOnly = true;
			this.txtMoney.Size = new System.Drawing.Size(184, 21);
			this.txtMoney.TabIndex = 19;
			this.txtMoney.Text = "";
			// 
			// label12
			// 
			this.label12.Location = new System.Drawing.Point(320, 80);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(72, 23);
			this.label12.TabIndex = 18;
			this.label12.Text = "消费金额";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtContents
			// 
			this.txtContents.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ds, "帐单明细.消费内容"));
			this.txtContents.Location = new System.Drawing.Point(408, 53);
			this.txtContents.Name = "txtContents";
			this.txtContents.ReadOnly = true;
			this.txtContents.Size = new System.Drawing.Size(184, 21);
			this.txtContents.TabIndex = 17;
			this.txtContents.Text = "";
			// 
			// label11
			// 
			this.label11.Location = new System.Drawing.Point(320, 53);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(72, 23);
			this.label11.TabIndex = 16;
			this.label11.Text = "消费内容";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtIDCard
			// 
			this.txtIDCard.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ds, "帐单明细.身份证"));
			this.txtIDCard.Location = new System.Drawing.Point(408, 24);
			this.txtIDCard.Name = "txtIDCard";
			this.txtIDCard.ReadOnly = true;
			this.txtIDCard.Size = new System.Drawing.Size(184, 21);
			this.txtIDCard.TabIndex = 15;
			this.txtIDCard.Text = "";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(320, 24);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(72, 23);
			this.label8.TabIndex = 14;
			this.label8.Text = "身份证";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtName
			// 
			this.txtName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ds, "帐单明细.顾客姓名"));
			this.txtName.Location = new System.Drawing.Point(96, 198);
			this.txtName.Name = "txtName";
			this.txtName.ReadOnly = true;
			this.txtName.Size = new System.Drawing.Size(184, 21);
			this.txtName.TabIndex = 13;
			this.txtName.Text = "";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(24, 203);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(72, 23);
			this.label7.TabIndex = 12;
			this.label7.Text = "顾客姓名";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtPrice
			// 
			this.txtPrice.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ds, "帐单明细.客房价格"));
			this.txtPrice.Location = new System.Drawing.Point(96, 169);
			this.txtPrice.Name = "txtPrice";
			this.txtPrice.ReadOnly = true;
			this.txtPrice.Size = new System.Drawing.Size(184, 21);
			this.txtPrice.TabIndex = 11;
			this.txtPrice.Text = "";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(24, 172);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(72, 23);
			this.label6.TabIndex = 10;
			this.label6.Text = "客房价格";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtPosition
			// 
			this.txtPosition.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ds, "帐单明细.客房位置"));
			this.txtPosition.Location = new System.Drawing.Point(96, 140);
			this.txtPosition.Name = "txtPosition";
			this.txtPosition.ReadOnly = true;
			this.txtPosition.Size = new System.Drawing.Size(184, 21);
			this.txtPosition.TabIndex = 9;
			this.txtPosition.Text = "";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(24, 141);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(72, 23);
			this.label5.TabIndex = 8;
			this.label5.Text = "客房位置";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtType
			// 
			this.txtType.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ds, "帐单明细.客房类型"));
			this.txtType.Location = new System.Drawing.Point(96, 111);
			this.txtType.Name = "txtType";
			this.txtType.ReadOnly = true;
			this.txtType.Size = new System.Drawing.Size(184, 21);
			this.txtType.TabIndex = 7;
			this.txtType.Text = "";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(24, 110);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(72, 23);
			this.label4.TabIndex = 6;
			this.label4.Text = "客房类型";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtRoomID
			// 
			this.txtRoomID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ds, "帐单明细.客房编号"));
			this.txtRoomID.Location = new System.Drawing.Point(96, 82);
			this.txtRoomID.Name = "txtRoomID";
			this.txtRoomID.ReadOnly = true;
			this.txtRoomID.Size = new System.Drawing.Size(184, 21);
			this.txtRoomID.TabIndex = 5;
			this.txtRoomID.Text = "";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(24, 79);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(72, 23);
			this.label3.TabIndex = 4;
			this.label3.Text = "客房编号";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtInID
			// 
			this.txtInID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ds, "帐单明细.入住单号"));
			this.txtInID.Location = new System.Drawing.Point(96, 53);
			this.txtInID.Name = "txtInID";
			this.txtInID.ReadOnly = true;
			this.txtInID.Size = new System.Drawing.Size(184, 21);
			this.txtInID.TabIndex = 3;
			this.txtInID.Text = "";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(24, 48);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(72, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "入住单号";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtBillID
			// 
			this.txtBillID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ds, "帐单明细.帐单编号"));
			this.txtBillID.Location = new System.Drawing.Point(96, 24);
			this.txtBillID.Name = "txtBillID";
			this.txtBillID.ReadOnly = true;
			this.txtBillID.Size = new System.Drawing.Size(184, 21);
			this.txtBillID.TabIndex = 1;
			this.txtBillID.Text = "";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(24, 17);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(72, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "帐单编号";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// conn
			// 
			this.conn.ConnectionString = "workstation id=KXJSMX;packet size=4096;integrated security=SSPI;data source=kxjsm" +
				"x;persist security info=False;initial catalog=酒店管理系统";
			// 
			// da
			// 
			this.da.DeleteCommand = this.sqlDeleteCommand1;
			this.da.InsertCommand = this.sqlInsertCommand1;
			this.da.SelectCommand = this.sqlSelectCommand1;
			this.da.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																						 new System.Data.Common.DataTableMapping("Table", "帐单明细", new System.Data.Common.DataColumnMapping[] {
																																																 new System.Data.Common.DataColumnMapping("帐单编号", "帐单编号"),
																																																 new System.Data.Common.DataColumnMapping("入住单号", "入住单号"),
																																																 new System.Data.Common.DataColumnMapping("客房编号", "客房编号"),
																																																 new System.Data.Common.DataColumnMapping("客房类型", "客房类型"),
																																																 new System.Data.Common.DataColumnMapping("客房位置", "客房位置"),
																																																 new System.Data.Common.DataColumnMapping("客房价格", "客房价格"),
																																																 new System.Data.Common.DataColumnMapping("顾客姓名", "顾客姓名"),
																																																 new System.Data.Common.DataColumnMapping("身份证", "身份证"),
																																																 new System.Data.Common.DataColumnMapping("消费内容", "消费内容"),
																																																 new System.Data.Common.DataColumnMapping("消费金额", "消费金额"),
																																																 new System.Data.Common.DataColumnMapping("入住时间", "入住时间"),
																																																 new System.Data.Common.DataColumnMapping("折扣", "折扣"),
																																																 new System.Data.Common.DataColumnMapping("结算日期", "结算日期"),
																																																 new System.Data.Common.DataColumnMapping("备注", "备注")})});
			this.da.UpdateCommand = this.sqlUpdateCommand1;
			// 
			// sqlSelectCommand1
			// 
			this.sqlSelectCommand1.CommandText = "SELECT 帐单编号, 入住单号, 客房编号, 客房类型, 客房位置, 客房价格, 顾客姓名, 身份证, 消费内容, 消费金额, 入住时间, 折扣, 结算日期," +
				" 备注 FROM 帐单明细";
			this.sqlSelectCommand1.Connection = this.conn;
			// 
			// sqlInsertCommand1
			// 
			this.sqlInsertCommand1.CommandText = @"INSERT INTO 帐单明细(帐单编号, 入住单号, 客房编号, 客房类型, 客房位置, 客房价格, 顾客姓名, 身份证, 消费内容, 消费金额, 入住时间, 折扣, 结算日期, 备注) VALUES (@帐单编号, @入住单号, @客房编号, @客房类型, @客房位置, @客房价格, @顾客姓名, @身份证, @消费内容, @消费金额, @入住时间, @折扣, @结算日期, @备注); SELECT 帐单编号, 入住单号, 客房编号, 客房类型, 客房位置, 客房价格, 顾客姓名, 身份证, 消费内容, 消费金额, 入住时间, 折扣, 结算日期, 备注 FROM 帐单明细 WHERE (帐单编号 = @帐单编号)";
			this.sqlInsertCommand1.Connection = this.conn;
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@帐单编号", System.Data.SqlDbType.VarChar, 10, "帐单编号"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@入住单号", System.Data.SqlDbType.VarChar, 10, "入住单号"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@客房编号", System.Data.SqlDbType.VarChar, 10, "客房编号"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@客房类型", System.Data.SqlDbType.VarChar, 20, "客房类型"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@客房位置", System.Data.SqlDbType.VarChar, 10, "客房位置"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@客房价格", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "客房价格", System.Data.DataRowVersion.Current, null));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@顾客姓名", System.Data.SqlDbType.VarChar, 10, "顾客姓名"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@身份证", System.Data.SqlDbType.VarChar, 20, "身份证"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@消费内容", System.Data.SqlDbType.VarChar, 40, "消费内容"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@消费金额", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "消费金额", System.Data.DataRowVersion.Current, null));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@入住时间", System.Data.SqlDbType.DateTime, 4, "入住时间"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@折扣", System.Data.SqlDbType.Float, 8, "折扣"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@结算日期", System.Data.SqlDbType.DateTime, 4, "结算日期"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@备注", System.Data.SqlDbType.VarChar, 40, "备注"));
			// 
			// sqlUpdateCommand1
			// 
			this.sqlUpdateCommand1.CommandText = @"UPDATE 帐单明细 SET 帐单编号 = @帐单编号, 入住单号 = @入住单号, 客房编号 = @客房编号, 客房类型 = @客房类型, 客房位置 = @客房位置, 客房价格 = @客房价格, 顾客姓名 = @顾客姓名, 身份证 = @身份证, 消费内容 = @消费内容, 消费金额 = @消费金额, 入住时间 = @入住时间, 折扣 = @折扣, 结算日期 = @结算日期, 备注 = @备注 WHERE (帐单编号 = @Original_帐单编号) AND (入住单号 = @Original_入住单号) AND (入住时间 = @Original_入住时间 OR @Original_入住时间 IS NULL AND 入住时间 IS NULL) AND (备注 = @Original_备注 OR @Original_备注 IS NULL AND 备注 IS NULL) AND (客房价格 = @Original_客房价格 OR @Original_客房价格 IS NULL AND 客房价格 IS NULL) AND (客房位置 = @Original_客房位置 OR @Original_客房位置 IS NULL AND 客房位置 IS NULL) AND (客房类型 = @Original_客房类型 OR @Original_客房类型 IS NULL AND 客房类型 IS NULL) AND (客房编号 = @Original_客房编号) AND (折扣 = @Original_折扣 OR @Original_折扣 IS NULL AND 折扣 IS NULL) AND (消费内容 = @Original_消费内容 OR @Original_消费内容 IS NULL AND 消费内容 IS NULL) AND (消费金额 = @Original_消费金额 OR @Original_消费金额 IS NULL AND 消费金额 IS NULL) AND (结算日期 = @Original_结算日期 OR @Original_结算日期 IS NULL AND 结算日期 IS NULL) AND (身份证 = @Original_身份证 OR @Original_身份证 IS NULL AND 身份证 IS NULL) AND (顾客姓名 = @Original_顾客姓名 OR @Original_顾客姓名 IS NULL AND 顾客姓名 IS NULL); SELECT 帐单编号, 入住单号, 客房编号, 客房类型, 客房位置, 客房价格, 顾客姓名, 身份证, 消费内容, 消费金额, 入住时间, 折扣, 结算日期, 备注 FROM 帐单明细 WHERE (帐单编号 = @帐单编号)";
			this.sqlUpdateCommand1.Connection = this.conn;
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@帐单编号", System.Data.SqlDbType.VarChar, 10, "帐单编号"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@入住单号", System.Data.SqlDbType.VarChar, 10, "入住单号"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@客房编号", System.Data.SqlDbType.VarChar, 10, "客房编号"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@客房类型", System.Data.SqlDbType.VarChar, 20, "客房类型"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@客房位置", System.Data.SqlDbType.VarChar, 10, "客房位置"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@客房价格", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "客房价格", System.Data.DataRowVersion.Current, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@顾客姓名", System.Data.SqlDbType.VarChar, 10, "顾客姓名"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@身份证", System.Data.SqlDbType.VarChar, 20, "身份证"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@消费内容", System.Data.SqlDbType.VarChar, 40, "消费内容"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@消费金额", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "消费金额", System.Data.DataRowVersion.Current, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@入住时间", System.Data.SqlDbType.DateTime, 4, "入住时间"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@折扣", System.Data.SqlDbType.Float, 8, "折扣"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@结算日期", System.Data.SqlDbType.DateTime, 4, "结算日期"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@备注", System.Data.SqlDbType.VarChar, 40, "备注"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_帐单编号", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "帐单编号", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_入住单号", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "入住单号", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_入住时间", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "入住时间", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_备注", System.Data.SqlDbType.VarChar, 40, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "备注", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_客房价格", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "客房价格", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_客房位置", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "客房位置", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_客房类型", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "客房类型", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_客房编号", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "客房编号", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_折扣", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "折扣", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_消费内容", System.Data.SqlDbType.VarChar, 40, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "消费内容", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_消费金额", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "消费金额", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_结算日期", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "结算日期", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_身份证", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "身份证", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_顾客姓名", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "顾客姓名", System.Data.DataRowVersion.Original, null));
			// 
			// sqlDeleteCommand1
			// 
			this.sqlDeleteCommand1.CommandText = @"DELETE FROM 帐单明细 WHERE (帐单编号 = @Original_帐单编号) AND (入住单号 = @Original_入住单号) AND (入住时间 = @Original_入住时间 OR @Original_入住时间 IS NULL AND 入住时间 IS NULL) AND (备注 = @Original_备注 OR @Original_备注 IS NULL AND 备注 IS NULL) AND (客房价格 = @Original_客房价格 OR @Original_客房价格 IS NULL AND 客房价格 IS NULL) AND (客房位置 = @Original_客房位置 OR @Original_客房位置 IS NULL AND 客房位置 IS NULL) AND (客房类型 = @Original_客房类型 OR @Original_客房类型 IS NULL AND 客房类型 IS NULL) AND (客房编号 = @Original_客房编号) AND (折扣 = @Original_折扣 OR @Original_折扣 IS NULL AND 折扣 IS NULL) AND (消费内容 = @Original_消费内容 OR @Original_消费内容 IS NULL AND 消费内容 IS NULL) AND (消费金额 = @Original_消费金额 OR @Original_消费金额 IS NULL AND 消费金额 IS NULL) AND (结算日期 = @Original_结算日期 OR @Original_结算日期 IS NULL AND 结算日期 IS NULL) AND (身份证 = @Original_身份证 OR @Original_身份证 IS NULL AND 身份证 IS NULL) AND (顾客姓名 = @Original_顾客姓名 OR @Original_顾客姓名 IS NULL AND 顾客姓名 IS NULL)";
			this.sqlDeleteCommand1.Connection = this.conn;
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_帐单编号", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "帐单编号", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_入住单号", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "入住单号", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_入住时间", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "入住时间", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_备注", System.Data.SqlDbType.VarChar, 40, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "备注", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_客房价格", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "客房价格", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_客房位置", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "客房位置", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_客房类型", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "客房类型", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_客房编号", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "客房编号", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_折扣", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "折扣", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_消费内容", System.Data.SqlDbType.VarChar, 40, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "消费内容", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_消费金额", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(18)), ((System.Byte)(0)), "消费金额", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_结算日期", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "结算日期", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_身份证", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "身份证", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_顾客姓名", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "顾客姓名", System.Data.DataRowVersion.Original, null));
			// 
			// SelectAccountInfoManagement
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(720, 550);
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
			this.MaximumSize = new System.Drawing.Size(728, 584);
			this.MinimumSize = new System.Drawing.Size(728, 584);
			this.Name = "SelectAccountInfoManagement";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "结算信息查询";
			this.Load += new System.EventHandler(this.SelectAccountInfoManagement_Load);
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void btnAll_Click(object sender, System.EventArgs e)
		{
			this.sqlSelectCommand1.CommandText = "Select * from  帐单明细";
			this.ds.Clear();
			da.Fill(this.ds,"帐单明细");
			bmb = this.BindingContext[ds,"帐单明细"];
			this.label9.Text = "当前记录："+(this.dataGrid1.CurrentRowIndex+1);
			this.label10.Text = "记录数："+bmb.Count;

		}

		private void btnFirst_Click(object sender, System.EventArgs e)
		{
			try
			{
				bmb.Position = 0;
				this.label9.Text = "当前记录："+(this.dataGrid1.CurrentRowIndex+1);
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
				this.label9.Text = "当前记录："+(this.dataGrid1.CurrentRowIndex+1);
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
				this.label9.Text = "当前记录："+(this.dataGrid1.CurrentRowIndex+1);
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
				this.label9.Text = "当前记录："+(this.dataGrid1.CurrentRowIndex+1);
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
			this.textBox3.Enabled = false;
			this.textBox4.Enabled = false;
			this.textBox2.Text = "";
			this.textBox3.Text = "";
			this.textBox4.Text = "";
		}

		private void radioButton2_CheckedChanged(object sender, System.EventArgs e)
		{
			this.textBox1.Enabled = false;
			this.textBox2.Enabled = true;
			this.textBox3.Enabled = false;
			this.textBox4.Enabled = false;
			this.textBox1.Text = "";
			this.textBox3.Text = "";
			this.textBox4.Text = "";
		}

		private void radioButton3_CheckedChanged(object sender, System.EventArgs e)
		{
			this.textBox1.Enabled = false;
			this.textBox2.Enabled = false;
			this.textBox3.Enabled = true;
			this.textBox4.Enabled = false;
			this.textBox1.Text = "";
			this.textBox2.Text = "";
			this.textBox4.Text = "";
		}

		private void radioButton4_CheckedChanged(object sender, System.EventArgs e)
		{
			this.textBox1.Enabled = false;
			this.textBox2.Enabled = false;
			this.textBox3.Enabled = false;
			this.textBox4.Enabled = true;
			this.textBox1.Text = "";
			this.textBox2.Text = "";
			this.textBox3.Text = "";
		}

		private void btnFind_Click(object sender, System.EventArgs e)
		{
			string str = "";
			try
			{
				if(this.textBox1.Enabled == true && this.textBox1.Text.Trim() != "")
				{
					str = "Select * from 帐单明细 where 帐单编号 like '%"+this.textBox1.Text.Trim()+"%'";
					this.sqlSelectCommand1.CommandText = str;
					this.ds.Clear();
					da.Fill(this.ds,"帐单明细");
					bmb=this.BindingContext[ds,"帐单明细"];
					this.label9.Text = "当前记录："+(this.dataGrid1.CurrentRowIndex+1);
					this.label10.Text = "记录数："+bmb.Count;
		
				}
				if(this.textBox2.Enabled == true && this.textBox2.Text.Trim() != "")
				{
					str = "Select * from 帐单明细 where 入住单号 like '%"+this.textBox2.Text.Trim()+"%'";
					this.sqlSelectCommand1.CommandText = str;
					this.ds.Clear();
					da.Fill(this.ds,"帐单明细");
					bmb=this.BindingContext[ds,"帐单明细"];
					this.label9.Text = "当前记录："+(this.dataGrid1.CurrentRowIndex+1);
					this.label10.Text = "记录数："+bmb.Count;
				}
				if(this.textBox3.Enabled == true && this.textBox3.Text.Trim() != "")
				{
					str = "Select * from 帐单明细 where 客房编号 like '%"+this.textBox3.Text.Trim()+"%'";
					this.sqlSelectCommand1.CommandText = str;
					this.ds.Clear();
					da.Fill(this.ds,"帐单明细");
					bmb=this.BindingContext[ds,"帐单明细"];
					this.label9.Text = "当前记录："+(this.dataGrid1.CurrentRowIndex+1);
					this.label10.Text = "记录数："+bmb.Count;
				}
				if(this.textBox4.Enabled == true && this.textBox4.Text.Trim() != "")
				{
					str = "Select * from 帐单明细 where 客房类型 like '%"+this.textBox4.Text.Trim()+"%'";
					this.sqlSelectCommand1.CommandText = str;
					this.ds.Clear();
					da.Fill(this.ds,"帐单明细");
					bmb=this.BindingContext[ds,"帐单明细"];
					this.label9.Text = "当前记录："+(this.dataGrid1.CurrentRowIndex+1);
					this.label10.Text = "记录数："+bmb.Count;
				}
				if(str == "")
				{
					MessageBox.Show("请输入查找条件");;
				}
			}
			catch
			{
				MessageBox.Show("输入有误");
			}
		    
		}

		private void SelectAccountInfoManagement_Load(object sender, System.EventArgs e)
		{
//		    this.conn.ConnectionString = Config.Settings.ConnStr;
		}

	}
}
