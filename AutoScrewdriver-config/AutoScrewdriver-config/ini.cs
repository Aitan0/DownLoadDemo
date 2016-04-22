using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace fileRW
{
   public partial class ini
    {
        [DllImport("kernel32")]
        public static extern bool WritePrivateProfileString(string section, string key, string val, string filePath);
        [DllImport("kernel32")]
        public static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder reval, int size, string filePath);
        [DllImport("kernel32")]
        public static extern int GetPrivateProfileInt(string section, string key, int def, string filePath);
    }
}
