using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;//��Ӵ������������ռ�
using System.Net;//���������Ϣ�������ռ�
using System.Runtime.InteropServices;//���"kernel32"API����

namespace GobangClass
{
    /// <summary>
    /// ��ȡ��������windows·��
    /// </summary>
    public class Publec_Class
    {
        #region  ȫ�ֱ���
        public static string ServerIP = "";//������IP
        public static string ServerPort = "";//���صĶ˿ں�
        public static string ClientIP = "";//��ǰ�û���IP
        public static string ClientPort = "";
        public static string ClientName = "";//��ǰ�û�������
        public static string UserName;
        public static string UserID;//��ǰ�û���IP
        public static int CaputID = 0;//��ǰ�û���ͷ��

        public static int UserSex = 0;//��ǰ�û����Ա�
        public static int Fraction = 0;//��ǰ�û��ķ���
        public static int TAreaM = 0;//����
        public static int TRoomM = 0;//�����
        public static string DeskM = "";//����
        public static string SeatM = "";//��λ��
        public static string UserCaption;//��λ���е��û�����
        public static string UserSeat = "";//��ǰ�û�����λ��
        public static string SubtenseIP = "";//��¼�Ծ��жԷ���IP��ַ
        #endregion

        #region  ��ȡ������
        /// <summary>
        /// ��ȡ������
        /// </summary>
        public string MyHostIP()
        {
            // ��ʾ������
            string hostname = Dns.GetHostName();
            // ��ʾÿ��IP��ַ
            IPHostEntry hostent = Dns.GetHostEntry(hostname); // ������Ϣ
            Array addrs = hostent.AddressList;            // IP��ַ����
            IEnumerator it = addrs.GetEnumerator();       // ����������������ռ�using System.Collections;
            while (it.MoveNext())
            {   // ѭ������һ��IP ��ַ
                IPAddress ip = (IPAddress)it.Current;      //���IP��ַ����������ռ�using System.Net;
                return ip.ToString();
            }
            return "";
        }
        #endregion

        #region  ��ȡwindows·��
        /// <summary>
        /// ��ȡwindows·��.
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
