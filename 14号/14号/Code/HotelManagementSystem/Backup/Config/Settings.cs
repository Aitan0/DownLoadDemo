using System;
using System.Data.SqlClient;
namespace HotelManagementSystem.Config
{
	/// <summary>
	/// Settings ��ժҪ˵����
	/// </summary>
	public class Settings
	{
		public Settings()
		{
			//
			// TODO: �ڴ˴���ӹ��캯���߼�
			//
		}
		public static string ConnStr
		{
			get
			{
				return	 "workstation id=(local);packet size=4096;integrated security=SSPI;"+
					"data source=(local);persist security info=False;initial catalog=�Ƶ����ϵͳ";
			}
		}	    
	}
}
