using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;//添加代送器的命名空间
using System.Net;//添加主机信息的命名空间
using System.Runtime.InteropServices;//添加"kernel32"API函数

namespace GobangClass
{
    /// <summary>
    /// 获取主机名及windows路径
    /// </summary>
    public class Publec_Class
    {
        #region  全局变量
        public static string ServerIP = "";//服务器IP
        public static string ServerPort = "";//本地的端口号
        public static string ClientIP = "";//当前用户的IP
        public static string ClientPort = "";
        public static string ClientName = "";//当前用户的名称
        public static string UserName;
        public static string UserID;//当前用户的IP
        public static int CaputID = 0;//当前用户的头像

        public static int UserSex = 0;//当前用户的性别
        public static int Fraction = 0;//当前用户的分数
        public static int TAreaM = 0;//区号
        public static int TRoomM = 0;//房间号
        public static string DeskM = "";//桌号
        public static string SeatM = "";//坐位号
        public static string UserCaption;//坐位号中的用户名称
        public static string UserSeat = "";//当前用户的坐位名
        public static string SubtenseIP = "";//记录对决中对方的IP地址
        #endregion

        #region  获取主机名
        /// <summary>
        /// 获取主机名
        /// </summary>
        public string MyHostIP()
        {
            // 显示主机名
            string hostname = Dns.GetHostName();
            // 显示每个IP地址
            IPHostEntry hostent = Dns.GetHostEntry(hostname); // 主机信息
            Array addrs = hostent.AddressList;            // IP地址数组
            IEnumerator it = addrs.GetEnumerator();       // 迭代器，添加名命空间using System.Collections;
            while (it.MoveNext())
            {   // 循环到下一个IP 地址
                IPAddress ip = (IPAddress)it.Current;      //获得IP地址，添加名命空间using System.Net;
                return ip.ToString();
            }
            return "";
        }
        #endregion

        #region  获取windows路径
        /// <summary>
        /// 获取windows路径.
        /// </summary>
 
        [DllImport("kernel32")]
        public static extern void GetWindowsDirectory(StringBuilder WinDir, int count);

        public string Get_windows()
        {
            const int nChars = 255;
            StringBuilder Buff = new StringBuilder(nChars);
            GetWindowsDirectory(Buff, nChars);
            return Buff.ToString();
        }
        #endregion
    }
}
