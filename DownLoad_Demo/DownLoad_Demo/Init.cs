using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DownLoad_Demo
{
   public  class Init
    {
        public static string FileCheck()
        {
            //检查配置文件是否存在，不存在创建
            #region
            string Path = DotNet.Utilities.DirFile.GetDateDir();
            Path += "\\Config";
            if (DotNet.Utilities.DirFile.IsExistDirectory(Path))
            {

            }
            else
            {
                DotNet.Utilities.DirFile.CreateDirectory(Path);
               
            }
            Path += "\\SelectModel.ini";
            if (DotNet.Utilities.DirFile.IsExistFile(Path))
            {

            }
            else
            {
                DotNet.Utilities.DirFile.CreateFile(Path);

            }
            #endregion
            //检查配置文件是否有效
            //通过文件大小检查
          if(DotNet.Utilities.DirFile.GetFileSize(Path)>0)
            {
                return Path;
            }
            else
            {
                return "invalid File,Please Check the ConfigFile @" + Path; 
            }
            
        }
        public static void StuasCheck(string TempPath)
        {
            DotNet.Utilities.INIFile RdConf = new DotNet.Utilities.INIFile(TempPath);
            RdConf.IniReadValue("Model", "SN");


        }
    }
}
