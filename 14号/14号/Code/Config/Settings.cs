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
				//return	 "workstation id=(local);packet size=4096;integrated security=SSPI;"+
				//	"data source=(local);persist security info=False;initial catalog=�Ƶ����ϵͳ";
                return "Data Source=(LocalDB)\\v11.0;AttachDbFilename=C:\\Users\\aliu2197\\Documents\\Visual Studio 2013\\Projects\\14��\\14��\\DB\\�Ƶ����ϵͳ_DATA.MDF;Integrated Security=True;Connect Timeout=30";
			}
		}	    
	}
}
