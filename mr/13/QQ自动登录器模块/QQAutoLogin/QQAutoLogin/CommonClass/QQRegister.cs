using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QQAutoLogin.CommonClass
{
    class QQRegister
    {
        /// <summary>
        /// 注册表路径
        /// </summary>
        public static string STR_QQ_REG_PATH = "Software\\QQLogion\\Settings\\QQPath";
        /// <summary>
        /// 注册表键值：路径
        /// </summary>
        public static string STR_QQ_REG_KEY_PRGRM_PATH = "QQPath";
        /// <summary>
        /// 警告语
        /// </summary>
        public static string STR_QQ_WARN_PRGRM_PATH_NULL = "QQ程序路径未设定";
        /// <summary>
        /// 警告语
        /// </summary>
        public static string STR_QQ_WARN_PRGRM_PATH_ERR = "非法的QQ程序路径";
        /// <summary>
        /// XML文件名
        /// </summary>
        public static string STR_QQ_DATE_FILE_NAME = "\\Date.xml";
    }
}
