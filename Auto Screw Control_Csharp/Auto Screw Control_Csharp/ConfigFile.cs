using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.IO;
using System.IO.Ports;

namespace Auto_Screw_Control_Csharp
{
    public partial class ConfigFile : Component
    {
        
        [DllImport("kernel32")]//返回0表示失败，非0为成功
        private static extern long WritePrivateProfileString(string section, string key,
            string val, string filePath);

        [DllImport("kernel32")]//返回取得字符串缓冲区的长度
        private static extern long GetPrivateProfileString(string section, string key,
            string def, StringBuilder retVal, int size, string filePath);
        public ConfigFile()
        {
            InitializeComponent();
        }

        public ConfigFile(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

      //读Ini文件
        public static string ReadIniData(string Section, string Key, string NoText, string iniFilePath)
        {
            if (File.Exists(iniFilePath))
            {
                StringBuilder temp = new StringBuilder(1024);
                GetPrivateProfileString(Section, Key, NoText, temp, 1024, iniFilePath);
                return temp.ToString();
            }
            else
            {
                return String.Empty;
            }
        }
        //写ini文件
        public static bool WriteIniData(string Section, string Key, string Value, string iniFilePath)
        {
            if (File.Exists(iniFilePath))
            {
                long OpStation = WritePrivateProfileString(Section, Key, Value, iniFilePath);
                if (OpStation == 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return false;
            }
        }
        //获取当前PC存在的串口
        public static void GetPortNames(out string [] Names)
        {
            Names = SerialPort.GetPortNames();
        }
        //获取当前系统配置文件路径
        public static string GetConfigPath()
        {
            string temp = Directory.GetCurrentDirectory();
            temp += "\\config.ini";
            if (File.Exists(temp))
            {

            }
            else
                File.Create(temp);
            return temp;
        }
      
    

    }
}
