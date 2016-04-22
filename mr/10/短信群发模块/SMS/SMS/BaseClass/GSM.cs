using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace SMS.BaseClass
{
    class GSM
    {
        #region 初始化gsm modem,并连接gsm modem
        /// <summary>
        /// 初始化gsm modem,并连接gsm modem
        /// </summary>
        /// <param name="device">端口号</param>
        /// <param name="baudrate">波特率</param>
        /// <param name="initstring">at 初始化命令</param>
        /// <param name="charset">与GSM Modem 通讯的字符集 GSM,UCS2</param>
        /// <param name="swHandshake">软件握手</param>
        /// <param name="sn">通讯许可证书</param>
        /// <returns>连接是否成功</returns>
        [DllImport("dllforvc.dll",
             EntryPoint = "GSMModemInitNew",
             CharSet = CharSet.Ansi,
             CallingConvention = CallingConvention.StdCall)]
        public static extern bool GSMModemInitNew(
            string device,
            string baudrate,
            string initstring,
            string charset,
            bool swHandshake,
            string sn);
        #endregion

        #region 获取短信猫新的标识号码
        /// <summary>
        /// 获取短信猫新的标识号码
        /// </summary>
        /// <param name="device">端口号</param>
        /// <param name="baudrate">波特率</param>
        /// <returns>短信标识码</returns>
        [DllImport("dllforvc.dll",
             EntryPoint = "GSMModemGetSnInfoNew",
             CharSet = CharSet.Ansi,
             CallingConvention = CallingConvention.StdCall)]
        public static extern string GSMModemGetSnInfoNew(string device, string baudrate);
        #endregion

        #region 获取当前通讯端口
        /// <summary>
        /// 获取当前通讯端口
        /// </summary>
        /// <returns>端口名称如：“COM1”</returns>
        [DllImport("dllforvc.dll",
             EntryPoint = "GSMModemGetDevice",
             CharSet = CharSet.Ansi,
             CallingConvention = CallingConvention.StdCall)]
        public static extern string GSMModemGetDevice();
        #endregion

        #region 获取当前通讯波特率
        /// <summary>
        /// 获取当前通讯波特率
        /// </summary>
        /// <returns>波特率，如：“9600”</returns>
        [DllImport("dllforvc.dll",
             EntryPoint = "GSMModemGetBaudrate",
             CharSet = CharSet.Ansi,
             CallingConvention = CallingConvention.StdCall)]
        public static extern string GSMModemGetBaudrate();
        #endregion

        #region 断开连接并释放内存空间
        /// <summary>
        /// 断开连接并释放内存空间
        /// </summary>
        [DllImport("dllforvc.dll",
             EntryPoint = "GSMModemRelease",
             CharSet = CharSet.Ansi,
             CallingConvention = CallingConvention.StdCall)]
        public static extern void GSMModemRelease();
        #endregion

        #region 取得错误信息
        /// <summary>
        /// 取得错误信息
        /// </summary>
        /// <returns>错误说明文字</returns>
        [DllImport("dllforvc.dll",
             EntryPoint = "GSMModemGetErrorMsg",
             CharSet = CharSet.Ansi,
             CallingConvention = CallingConvention.StdCall)]
        public static extern string GSMModemGetErrorMsg();
        #endregion

        #region 发送短信息
        /// <summary>
        /// 发送短信息
        /// </summary>
        /// <param name="serviceCenterAddress">通讯许可证书</param>
        /// <param name="encodeval">文本编码格式,0-7bit;4-8bit,8-16bit</param>
        /// <param name="text">发送文本</param>
        /// <param name="textlen">发送的文本长度</param>
        /// <param name="phonenumber">电话号码</param>
        /// <param name="requestStatusReport">状态报告</param>
        /// <returns>短信是否发送成功</returns>
        [DllImport("dllforvc.dll",
             EntryPoint = "GSMModemSMSsend",
             CharSet = CharSet.Ansi,
             CallingConvention = CallingConvention.StdCall)]
        public static extern bool GSMModemSMSsend(
            string serviceCenterAddress,
            int encodeval,
            string text,
            int textlen,
            string phonenumber,
            bool requestStatusReport);
        #endregion

        #region 接收短信息返回字符串格式为:手机号码|短信内容||手机号码|短信内容||RD_opt为１接收短信息后不做任何处理，０为接收后删除信息
        /// <summary>
        /// 接收短信息返回字符串格式为:手机号码|短信内容||手机号码|短信内容||RD_opt为１接收短信息后不做任何处理，０为接收后删除信息
        /// </summary>
        /// <param name="RD_opt">对短信息的处理，0-删除，1-不做处理</param>
        /// <returns>短信的字符串格式</returns>
        [DllImport("dllforvc.dll",
             EntryPoint = "GSMModemSMSReadAll",
             CharSet = CharSet.Ansi,
             CallingConvention = CallingConvention.StdCall)]
        public static extern string GSMModemSMSReadAll(int RD_opt);
        #endregion
    }
}
