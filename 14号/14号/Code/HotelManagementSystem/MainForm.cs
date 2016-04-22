using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data.SqlClient;
using HotelManagementSystem.Data;
using HotelManagementSystem.Config;
using HotelManagementSystem.HistoryManagement;
using HotelManagementSystem.AccountInfoManagement;
using HotelManagementSystem.OrderRoomInfoManagement;
using HotelManagementSystem.RoomInfoManagement;
using HotelManagementSystem.RoomStandardManagement;
using HotelManagementSystem.SystemManagement;
using HotelManagementSystem.LiveListManagement;

//主窗体

namespace HotelManagementSystem
{
	/// <summary>
	/// MainForm 的摘要说明。
	/// </summary>
	public class MainForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.MenuItem menuItem21;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.MainMenu HotelSystemmainMenu;
		private System.Windows.Forms.MenuItem SystemmenuItem;
		private System.Windows.Forms.MenuItem RoomStandardmenuItem;
		private System.Windows.Forms.MenuItem SelectRoomStandardmenuItem;
		private System.Windows.Forms.MenuItem ChangeRoomStandardmenuItem;
		private System.Windows.Forms.MenuItem RoomInfomenuItem;
		private System.Windows.Forms.MenuItem SelectRoomInfomenuItem;
		private System.Windows.Forms.MenuItem ChangeRoomInfomenuItem;
		private System.Windows.Forms.MenuItem AddRoomInfomenuItem;
		private System.Windows.Forms.MenuItem OrderRoomInfomenuItem;
		private System.Windows.Forms.MenuItem SelectOrderRoomInfomenuItem;
		private System.Windows.Forms.MenuItem ChangeOrderRoomInfomenuItem;
		private System.Windows.Forms.MenuItem AddOrderRoomInfomenuItem;
		private System.Windows.Forms.MenuItem SelectSurplusOfRoommenuItem;
		private System.Windows.Forms.MenuItem AccountInfomenuItem;
		private System.Windows.Forms.MenuItem SelectAccountInfomenuItem;
		private System.Windows.Forms.MenuItem ChangeAccountInfomenuItem;
		private System.Windows.Forms.MenuItem AddAccountInfomenuItem;
		private System.Windows.Forms.MenuItem AddRoomStandardmenuItem;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label lbDate;
		private System.Windows.Forms.Label lbTime;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.MenuItem SelectUsermenuItem;
		private System.Windows.Forms.MenuItem ChangeUsermenuItem;
		private System.Windows.Forms.MenuItem AddUsermenuItem;
		private System.ComponentModel.IContainer components;
		private System.Windows.Forms.MenuItem HistorymenuItem;
		private System.Windows.Forms.MenuItem OrderHistorymenuItem;
		private System.Windows.Forms.MenuItem LiveHistorymenuItem;
		private System.Windows.Forms.MenuItem BillHistorymenuItem;
		private System.Windows.Forms.MenuItem ChangePasswordmenuItem;
		private System.Windows.Forms.MenuItem LiveListmenuItem;
		private System.Windows.Forms.MenuItem AddLiveListmenuItem;
		private System.Windows.Forms.MenuItem SelectAndChangeLiveListmenuItem;
		private System.Windows.Forms.MenuItem HelpmenuItem;
		private System.Windows.Forms.MenuItem UpdatemenuItem;
		private System.Windows.Forms.MenuItem ContactmenuItem;
		private System.Windows.Forms.MenuItem SponsormenuItem;
		private System.Windows.Forms.MenuItem ConcerninHotelManagementSystemmenuItem;


		public MainForm()
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
				if (components != null) 
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
			this.components = new System.ComponentModel.Container();
			this.HotelSystemmainMenu = new System.Windows.Forms.MainMenu();
			this.SystemmenuItem = new System.Windows.Forms.MenuItem();
			this.SelectUsermenuItem = new System.Windows.Forms.MenuItem();
			this.ChangeUsermenuItem = new System.Windows.Forms.MenuItem();
			this.AddUsermenuItem = new System.Windows.Forms.MenuItem();
			this.RoomStandardmenuItem = new System.Windows.Forms.MenuItem();
			this.SelectRoomStandardmenuItem = new System.Windows.Forms.MenuItem();
			this.ChangeRoomStandardmenuItem = new System.Windows.Forms.MenuItem();
			this.AddRoomStandardmenuItem = new System.Windows.Forms.MenuItem();
			this.RoomInfomenuItem = new System.Windows.Forms.MenuItem();
			this.SelectRoomInfomenuItem = new System.Windows.Forms.MenuItem();
			this.ChangeRoomInfomenuItem = new System.Windows.Forms.MenuItem();
			this.AddRoomInfomenuItem = new System.Windows.Forms.MenuItem();
			this.SelectSurplusOfRoommenuItem = new System.Windows.Forms.MenuItem();
			this.OrderRoomInfomenuItem = new System.Windows.Forms.MenuItem();
			this.SelectOrderRoomInfomenuItem = new System.Windows.Forms.MenuItem();
			this.ChangeOrderRoomInfomenuItem = new System.Windows.Forms.MenuItem();
			this.AddOrderRoomInfomenuItem = new System.Windows.Forms.MenuItem();
			this.LiveListmenuItem = new System.Windows.Forms.MenuItem();
			this.SelectAndChangeLiveListmenuItem = new System.Windows.Forms.MenuItem();
			this.AddLiveListmenuItem = new System.Windows.Forms.MenuItem();
			this.AccountInfomenuItem = new System.Windows.Forms.MenuItem();
			this.SelectAccountInfomenuItem = new System.Windows.Forms.MenuItem();
			this.ChangeAccountInfomenuItem = new System.Windows.Forms.MenuItem();
			this.AddAccountInfomenuItem = new System.Windows.Forms.MenuItem();
			this.HistorymenuItem = new System.Windows.Forms.MenuItem();
			this.OrderHistorymenuItem = new System.Windows.Forms.MenuItem();
			this.LiveHistorymenuItem = new System.Windows.Forms.MenuItem();
			this.BillHistorymenuItem = new System.Windows.Forms.MenuItem();
			this.ChangePasswordmenuItem = new System.Windows.Forms.MenuItem();
			this.menuItem21 = new System.Windows.Forms.MenuItem();
			this.HelpmenuItem = new System.Windows.Forms.MenuItem();
			this.UpdatemenuItem = new System.Windows.Forms.MenuItem();
			this.ContactmenuItem = new System.Windows.Forms.MenuItem();
			this.SponsormenuItem = new System.Windows.Forms.MenuItem();
			this.ConcerninHotelManagementSystemmenuItem = new System.Windows.Forms.MenuItem();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.lbDate = new System.Windows.Forms.Label();
			this.lbTime = new System.Windows.Forms.Label();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.SuspendLayout();
			// 
			// HotelSystemmainMenu
			// 
			this.HotelSystemmainMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																								this.SystemmenuItem,
																								this.RoomStandardmenuItem,
																								this.RoomInfomenuItem,
																								this.OrderRoomInfomenuItem,
																								this.LiveListmenuItem,
																								this.AccountInfomenuItem,
																								this.HistorymenuItem,
																								this.ChangePasswordmenuItem,
																								this.menuItem21});
			// 
			// SystemmenuItem
			// 
			this.SystemmenuItem.Index = 0;
			this.SystemmenuItem.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																						   this.SelectUsermenuItem,
																						   this.ChangeUsermenuItem,
																						   this.AddUsermenuItem});
			this.SystemmenuItem.Text = "系统管理";
			// 
			// SelectUsermenuItem
			// 
			this.SelectUsermenuItem.Index = 0;
			this.SelectUsermenuItem.Text = "用户查询";
			this.SelectUsermenuItem.Click += new System.EventHandler(this.SelectUsermenuItem_Click);
			// 
			// ChangeUsermenuItem
			// 
			this.ChangeUsermenuItem.Index = 1;
			this.ChangeUsermenuItem.Text = "用户修改";
			this.ChangeUsermenuItem.Click += new System.EventHandler(this.ChangeUsermenuItem_Click);
			// 
			// AddUsermenuItem
			// 
			this.AddUsermenuItem.Index = 2;
			this.AddUsermenuItem.Text = "用户添加";
			this.AddUsermenuItem.Click += new System.EventHandler(this.AddUsermenuItem_Click);
			// 
			// RoomStandardmenuItem
			// 
			this.RoomStandardmenuItem.Index = 1;
			this.RoomStandardmenuItem.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																								 this.SelectRoomStandardmenuItem,
																								 this.ChangeRoomStandardmenuItem,
																								 this.AddRoomStandardmenuItem});
			this.RoomStandardmenuItem.Text = "设置客房标准";
			// 
			// SelectRoomStandardmenuItem
			// 
			this.SelectRoomStandardmenuItem.Index = 0;
			this.SelectRoomStandardmenuItem.Text = "客房标准查询";
			this.SelectRoomStandardmenuItem.Click += new System.EventHandler(this.SelectRoomStandardmenuItem_Click);
			// 
			// ChangeRoomStandardmenuItem
			// 
			this.ChangeRoomStandardmenuItem.Index = 1;
			this.ChangeRoomStandardmenuItem.Text = "客房标准修改";
			this.ChangeRoomStandardmenuItem.Click += new System.EventHandler(this.ChangeRoomStandardmenuItem_Click);
			// 
			// AddRoomStandardmenuItem
			// 
			this.AddRoomStandardmenuItem.Index = 2;
			this.AddRoomStandardmenuItem.Text = "客房标准添加";
			this.AddRoomStandardmenuItem.Click += new System.EventHandler(this.AddRoomStandardmenuItem_Click);
			// 
			// RoomInfomenuItem
			// 
			this.RoomInfomenuItem.Index = 2;
			this.RoomInfomenuItem.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																							 this.SelectRoomInfomenuItem,
																							 this.ChangeRoomInfomenuItem,
																							 this.AddRoomInfomenuItem,
																							 this.SelectSurplusOfRoommenuItem});
			this.RoomInfomenuItem.Text = "设置客房信息";
			// 
			// SelectRoomInfomenuItem
			// 
			this.SelectRoomInfomenuItem.Index = 0;
			this.SelectRoomInfomenuItem.Text = "客房信息查询";
			this.SelectRoomInfomenuItem.Click += new System.EventHandler(this.SelectRoomInfomenuItem_Click);
			// 
			// ChangeRoomInfomenuItem
			// 
			this.ChangeRoomInfomenuItem.Index = 1;
			this.ChangeRoomInfomenuItem.Text = "客房信息修改";
			this.ChangeRoomInfomenuItem.Click += new System.EventHandler(this.ChangeRoomInfomenuItem_Click);
			// 
			// AddRoomInfomenuItem
			// 
			this.AddRoomInfomenuItem.Index = 2;
			this.AddRoomInfomenuItem.Text = "客房信息添加";
			this.AddRoomInfomenuItem.Click += new System.EventHandler(this.AddRoomInfomenuItem_Click);
			// 
			// SelectSurplusOfRoommenuItem
			// 
			this.SelectSurplusOfRoommenuItem.Index = 3;
			this.SelectSurplusOfRoommenuItem.Text = "剩余客房查询";
			this.SelectSurplusOfRoommenuItem.Click += new System.EventHandler(this.SelectSurplusOfRoommenuItem_Click);
			// 
			// OrderRoomInfomenuItem
			// 
			this.OrderRoomInfomenuItem.Index = 3;
			this.OrderRoomInfomenuItem.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																								  this.SelectOrderRoomInfomenuItem,
																								  this.ChangeOrderRoomInfomenuItem,
																								  this.AddOrderRoomInfomenuItem});
			this.OrderRoomInfomenuItem.Text = "订房信息管理";
			// 
			// SelectOrderRoomInfomenuItem
			// 
			this.SelectOrderRoomInfomenuItem.Index = 0;
			this.SelectOrderRoomInfomenuItem.Text = "订房信息查询";
			this.SelectOrderRoomInfomenuItem.Click += new System.EventHandler(this.SelectOrderRoomInfomenuItem_Click);
			// 
			// ChangeOrderRoomInfomenuItem
			// 
			this.ChangeOrderRoomInfomenuItem.Index = 1;
			this.ChangeOrderRoomInfomenuItem.Text = "订房信息修改";
			this.ChangeOrderRoomInfomenuItem.Click += new System.EventHandler(this.ChangeOrderRoomInfomenuItem_Click);
			// 
			// AddOrderRoomInfomenuItem
			// 
			this.AddOrderRoomInfomenuItem.Index = 2;
			this.AddOrderRoomInfomenuItem.Text = "订房信息添加";
			this.AddOrderRoomInfomenuItem.Click += new System.EventHandler(this.AddOrderRoomInfomenuItem_Click);
			// 
			// LiveListmenuItem
			// 
			this.LiveListmenuItem.Index = 4;
			this.LiveListmenuItem.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																							 this.SelectAndChangeLiveListmenuItem,
																							 this.AddLiveListmenuItem});
			this.LiveListmenuItem.Text = "入住单管理";
			// 
			// SelectAndChangeLiveListmenuItem
			// 
			this.SelectAndChangeLiveListmenuItem.Index = 0;
			this.SelectAndChangeLiveListmenuItem.Text = "入住单查改";
			this.SelectAndChangeLiveListmenuItem.Click += new System.EventHandler(this.SelectAndChangeLiveListmenuItem_Click);
			// 
			// AddLiveListmenuItem
			// 
			this.AddLiveListmenuItem.Index = 1;
			this.AddLiveListmenuItem.Text = "入住单添加";
			this.AddLiveListmenuItem.Click += new System.EventHandler(this.AddLiveListmenuItem_Click);
			// 
			// AccountInfomenuItem
			// 
			this.AccountInfomenuItem.Index = 5;
			this.AccountInfomenuItem.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																								this.SelectAccountInfomenuItem,
																								this.ChangeAccountInfomenuItem,
																								this.AddAccountInfomenuItem});
			this.AccountInfomenuItem.Text = "结算信息管理";
			// 
			// SelectAccountInfomenuItem
			// 
			this.SelectAccountInfomenuItem.Index = 0;
			this.SelectAccountInfomenuItem.Text = "结算信息查询";
			this.SelectAccountInfomenuItem.Click += new System.EventHandler(this.SelectAccountInfomenuItem_Click);
			// 
			// ChangeAccountInfomenuItem
			// 
			this.ChangeAccountInfomenuItem.Index = 1;
			this.ChangeAccountInfomenuItem.Text = "结算信息修改";
			this.ChangeAccountInfomenuItem.Click += new System.EventHandler(this.ChangeAccountInfomenuItem_Click);
			// 
			// AddAccountInfomenuItem
			// 
			this.AddAccountInfomenuItem.Index = 2;
			this.AddAccountInfomenuItem.Text = "结算信息添加";
			this.AddAccountInfomenuItem.Click += new System.EventHandler(this.AddAccountInfomenuItem_Click);
			// 
			// HistorymenuItem
			// 
			this.HistorymenuItem.Index = 6;
			this.HistorymenuItem.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																							this.OrderHistorymenuItem,
																							this.LiveHistorymenuItem,
																							this.BillHistorymenuItem});
			this.HistorymenuItem.Text = "历史查询";
			// 
			// OrderHistorymenuItem
			// 
			this.OrderHistorymenuItem.Index = 0;
			this.OrderHistorymenuItem.Text = "预订单历史查询";
			this.OrderHistorymenuItem.Click += new System.EventHandler(this.OrderHistorymenuItem_Click);
			// 
			// LiveHistorymenuItem
			// 
			this.LiveHistorymenuItem.Index = 1;
			this.LiveHistorymenuItem.Text = "入住单历史查询";
			this.LiveHistorymenuItem.Click += new System.EventHandler(this.LiveHistorymenuItem_Click);
			// 
			// BillHistorymenuItem
			// 
			this.BillHistorymenuItem.Index = 2;
			this.BillHistorymenuItem.Text = "帐单明细历史查询";
			this.BillHistorymenuItem.Click += new System.EventHandler(this.BillHistorymenuItem_Click);
			// 
			// ChangePasswordmenuItem
			// 
			this.ChangePasswordmenuItem.Index = 7;
			this.ChangePasswordmenuItem.Text = "修改密码";
			this.ChangePasswordmenuItem.Click += new System.EventHandler(this.ChangePasswordmenuItem_Click);
			// 
			// menuItem21
			// 
			this.menuItem21.Index = 8;
			this.menuItem21.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					   this.HelpmenuItem,
																					   this.UpdatemenuItem,
																					   this.ContactmenuItem,
																					   this.SponsormenuItem,
																					   this.ConcerninHotelManagementSystemmenuItem});
			this.menuItem21.Text = "帮助";
			// 
			// HelpmenuItem
			// 
			this.HelpmenuItem.Index = 0;
			this.HelpmenuItem.Text = "HotelManagementSystem帮助";
			this.HelpmenuItem.Click += new System.EventHandler(this.HelpmenuItem_Click);
			// 
			// UpdatemenuItem
			// 
			this.UpdatemenuItem.Index = 1;
			this.UpdatemenuItem.Text = "检查更新";
			this.UpdatemenuItem.Click += new System.EventHandler(this.UpdatemenuItem_Click);
			// 
			// ContactmenuItem
			// 
			this.ContactmenuItem.Index = 2;
			this.ContactmenuItem.Text = "与我们联系";
			this.ContactmenuItem.Click += new System.EventHandler(this.ContactmenuItem_Click);
			// 
			// SponsormenuItem
			// 
			this.SponsormenuItem.Index = 3;
			this.SponsormenuItem.Text = "赞助！";
			this.SponsormenuItem.Click += new System.EventHandler(this.SponsormenuItem_Click);
			// 
			// ConcerninHotelManagementSystemmenuItem
			// 
			this.ConcerninHotelManagementSystemmenuItem.Index = 4;
			this.ConcerninHotelManagementSystemmenuItem.Text = "关于HotelManagementSystem";
			this.ConcerninHotelManagementSystemmenuItem.Click += new System.EventHandler(this.ConcerninHotelManagementSystemmenuItem_Click);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Georgia", 42F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(88, 152);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(520, 96);
			this.label1.TabIndex = 0;
			this.label1.Text = "Hotel";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("宋体", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.Location = new System.Drawing.Point(584, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(104, 56);
			this.label2.TabIndex = 1;
			this.label2.Text = "WinCAM";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Georgia", 42F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.Location = new System.Drawing.Point(0, 8);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(360, 72);
			this.label3.TabIndex = 2;
			this.label3.Text = "Welcome！";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label4
			// 
			this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
			this.label4.Font = new System.Drawing.Font("Book Antiqua", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label4.Location = new System.Drawing.Point(560, 352);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 48);
			this.label4.TabIndex = 3;
			this.label4.Text = "Exit";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label4.Click += new System.EventHandler(this.label4_Click);
			// 
			// lbDate
			// 
			this.lbDate.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.lbDate.Location = new System.Drawing.Point(0, 393);
			this.lbDate.Name = "lbDate";
			this.lbDate.Size = new System.Drawing.Size(224, 40);
			this.lbDate.TabIndex = 4;
			this.lbDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbTime
			// 
			this.lbTime.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(134)));
			this.lbTime.Location = new System.Drawing.Point(0, 353);
			this.lbTime.Name = "lbTime";
			this.lbTime.Size = new System.Drawing.Size(224, 40);
			this.lbTime.TabIndex = 5;
			this.lbTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// MainForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(692, 427);
			this.Controls.Add(this.lbTime);
			this.Controls.Add(this.lbDate);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(700, 480);
			this.Menu = this.HotelSystemmainMenu;
			this.MinimumSize = new System.Drawing.Size(700, 480);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "酒店管理系统";
			this.Closing += new System.ComponentModel.CancelEventHandler(this.MainForm_Closing);
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// 应用程序的主入口点。
		/// </summary>
		[STAThread]
		static void Main() 
		{ 
			Login login = new Login();
			login.ShowDialog();
			if(login.Loginvalue == true)
			{
				Application.Run(new MainForm());
			}
			else
			{
				Application.Exit();
			}
		}

        // 打开客房标准查询
		private void SelectRoomStandardmenuItem_Click(object sender, System.EventArgs e)
		{
			this.Hide();
			RoomStandardManagement.SelectRoomStandardManagement SRS = new SelectRoomStandardManagement();
			SRS.ShowDialog();
			this.Show();
		}
        // 打开客房标准修改
		private void ChangeRoomStandardmenuItem_Click(object sender, System.EventArgs e)
		{
			this.Hide();
			RoomStandardManagement.ChangeRoomStandardManagement CRS = new ChangeRoomStandardManagement();
			CRS.ShowDialog();
			this.Show();
		}
        // 打开客房标准添加
		private void AddRoomStandardmenuItem_Click(object sender, System.EventArgs e)
		{
			this.Hide();
			RoomStandardManagement.AddRoomStandardManagement ARS = new AddRoomStandardManagement();
			ARS.ShowDialog();
			this.Show();
		
		}
        // 打开客房信息查询
		private void SelectRoomInfomenuItem_Click(object sender, System.EventArgs e)
		{
			this.Hide();
			RoomInfoManagement.SelectRoomInfoManagement SRI = new SelectRoomInfoManagement();
			SRI.ShowDialog();
			this.Show();
		}
        // 打开客房信息修改
		private void ChangeRoomInfomenuItem_Click(object sender, System.EventArgs e)
		{
			this.Hide();
			RoomInfoManagement.ChangeRoomInfoManagement CRI = new ChangeRoomInfoManagement();
			CRI.ShowDialog();
			this.Show();
		}
        // 打开客房信息添加
		private void AddRoomInfomenuItem_Click(object sender, System.EventArgs e)
		{
			this.Hide();
			RoomInfoManagement.AddRoomInfoManagement ARI= new AddRoomInfoManagement();
			ARI.ShowDialog();
			this.Show();
		}
        // 打开订房信息查询
		private void SelectOrderRoomInfomenuItem_Click(object sender, System.EventArgs e)
		{
			this.Hide();
			OrderRoomInfoManagement.SelectOrderRoomInfoManagement SOR = new SelectOrderRoomInfoManagement();
			SOR.ShowDialog();
			this.Show();
		}
        // 打开订房信息修改
		private void ChangeOrderRoomInfomenuItem_Click(object sender, System.EventArgs e)
		{
			this.Hide();
			OrderRoomInfoManagement.ChangeOrderRoomInfoManagement COR = new ChangeOrderRoomInfoManagement();
			COR.ShowDialog();
			this.Show();
		}
        // 打开订房信息添加
		private void AddOrderRoomInfomenuItem_Click(object sender, System.EventArgs e)
		{
			this.Hide();
			OrderRoomInfoManagement.AddOrderRoomInfoManagement AOR = new AddOrderRoomInfoManagement();
			AOR.ShowDialog();
			this.Show();
		}
        // 打开剩余房间查询
		private void SelectSurplusOfRoommenuItem_Click(object sender, System.EventArgs e)
		{
			this.Hide();
			RoomInfoManagement.SelectEmptyRoomManagement SER = new SelectEmptyRoomManagement();
			SER.ShowDialog();
			this.Show();
		}
        // 打开结算信息查询
		private void SelectAccountInfomenuItem_Click(object sender, System.EventArgs e)
		{
			this.Hide();
			AccountInfoManagement.SelectAccountInfoManagement SAI = new SelectAccountInfoManagement();
			SAI.ShowDialog();
			this.Show();
		}
        // 打开结算信息修改
		private void ChangeAccountInfomenuItem_Click(object sender, System.EventArgs e)
		{
		    this.Hide();
			AccountInfoManagement.ChangeAccountInfoManagement CAI = new ChangeAccountInfoManagement();
			CAI.ShowDialog();
			this.Show();
		}
        // 打开结算信息添加
		private void AddAccountInfomenuItem_Click(object sender, System.EventArgs e)
		{
			this.Hide();
			AccountInfoManagement.AddAccountInfoManagement AAI = new AddAccountInfoManagement();
			AAI.ShowDialog();
			this.Show();
		}
		
		private void MainForm_Load(object sender, System.EventArgs e)
		{
			if(Login.LoginGrade == true)
			{
				SystemmenuItem.Visible = true;
			}
			else
			{
				SystemmenuItem.Visible = false;
			}
		}

		//退出系统
		private void label4_Click(object sender, System.EventArgs e)
		{			
			this.Close();
		}

		private void timer1_Tick(object sender, System.EventArgs e)
		{
			this.lbTime.Text = System.DateTime.Now.ToLongTimeString();
			this.lbDate.Text = System.DateTime.Now.ToLongDateString();
		}
        // 打开用户查询
		private void SelectUsermenuItem_Click(object sender, System.EventArgs e)
		{
			this.Hide();
		    SystemManagement.SelectUserManagement SUM = new SelectUserManagement();
			SUM.ShowDialog();
			this.Show();
		}
        //打开用户修改
		private void ChangeUsermenuItem_Click(object sender, System.EventArgs e)
		{
			this.Hide();
			SystemManagement.ChangeUserManagement CUM = new ChangeUserManagement();
			CUM.ShowDialog();
			this.Show();
		}
        //打开用户添加 
		private void AddUsermenuItem_Click(object sender, System.EventArgs e)
		{
			this.Hide();
			SystemManagement.AddUserManagement  AUM = new AddUserManagement();
			AUM.ShowDialog();
			this.Show();
		}

		private void MainForm_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			if(DialogResult.OK == MessageBox.Show("确定退出系统?","确定",MessageBoxButtons.OKCancel,MessageBoxIcon.Question))
			{
				e.Cancel = false;
			}
			else
			{
				e.Cancel = true;
			}
		}
        //打开预订单历史查询
		private void OrderHistorymenuItem_Click(object sender, System.EventArgs e)
		{
			this.Hide();
			HistoryManagement.OrderHistoryManagement  OHM = new OrderHistoryManagement();
			OHM.ShowDialog();
			this.Show();
		}
		//打开入住单历史查询
		private void LiveHistorymenuItem_Click(object sender, System.EventArgs e)
		{
			this.Hide();
			HistoryManagement.LiveHistoryManagement  LHM = new LiveHistoryManagement();
			LHM.ShowDialog();
			this.Show();
		}
		//打开帐单明细历史查询
		private void BillHistorymenuItem_Click(object sender, System.EventArgs e)
		{
			this.Hide();
			HistoryManagement.BillHistoryManagement  BHM = new BillHistoryManagement();
			BHM.ShowDialog();
			this.Show();
		}
        //打开密码修改
		private void ChangePasswordmenuItem_Click(object sender, System.EventArgs e)
		{
			ChangePassword  CP = new ChangePassword();
			CP.ShowDialog();
		}
        //打开入住单查改
		private void SelectAndChangeLiveListmenuItem_Click(object sender, System.EventArgs e)
		{
			this.Hide();
			LiveListManagement.SelectAndChangeLiveListManagement  SACLL = new SelectAndChangeLiveListManagement();
			SACLL.ShowDialog();
			this.Show();
		}
        //打开入住单添加
		private void AddLiveListmenuItem_Click(object sender, System.EventArgs e)
		{
			this.Hide();
			LiveListManagement.AddLiveListManagement  ALL = new AddLiveListManagement();
			ALL.ShowDialog();
			this.Show();
		}
        //系统帮助
		private void HelpmenuItem_Click(object sender, System.EventArgs e)
		{
			string output = "";
			output += "本系统功能齐全、界面朴素、容易操作"+"\n";
			output += "你只需根据控件的文字的提示进行操作"+"\n";
			output += "即可实现所有功能：查询、修改、添加";
		    MessageBox.Show(output);
		}
        //系统更新信息
		private void UpdatemenuItem_Click(object sender, System.EventArgs e)
		{
		    MessageBox.Show("本系统提供免费网上升级，详情请登录本系统首页!");
		}
        //联系方式
		private void ContactmenuItem_Click(object sender, System.EventArgs e)
		{
			string output = "E-Mail：kxjsmx@163.com"+"\n";
			output += "QQ:574631991"+"\n"+"\n";
			output += "        欢迎!";
			MessageBox.Show(output);
		
		}
        //赞助
		private void SponsormenuItem_Click(object sender, System.EventArgs e)
		{
			string output = "";
			output += "中国工商银行帐户：6222 0219 8888 8888 8888 "+"\n"+"\n";
			output += "                   谢谢!";
			MessageBox.Show(output);
		}
        //关于系统
		private void ConcerninHotelManagementSystemmenuItem_Click(object sender, System.EventArgs e)
		{
			string output = "";
			output += "本系统是鄙人在两个星期实训中所完成的"+"\n";
			output += "这是第一个本版，也是鄙人的第一个作品"+"\n";
			output += "它功能齐全、容易操作，希望它物有所值";
			MessageBox.Show(output);
		}
	}
}
