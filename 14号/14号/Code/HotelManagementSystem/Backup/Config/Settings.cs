using System;
using System.Data.SqlClient;
namespace HotelManagementSystem.Config
{
	/// <summary>
	/// Settings 的摘要说明。
	/// </summary>
	public class Settings
	{
		public Settings()
		{
			//
			// TODO: 在此处添加构造函数逻辑
			//
		}
		public static string ConnStr
		{
			get
			{
				return	 "workstation id=(local);packet size=4096;integrated security=SSPI;"+
					"data source=(local);persist security info=False;initial catalog=酒店管理系统";
			}
		}	    
	}
}
