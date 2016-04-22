using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace SMS.BaseClass
{
    class GSM
    {
        #region ��ʼ��gsm modem,������gsm modem
        /// <summary>
        /// ��ʼ��gsm modem,������gsm modem
        /// </summary>
        /// <param name="device">�˿ں�</param>
        /// <param name="baudrate">������</param>
        /// <param name="initstring">at ��ʼ������</param>
        /// <param name="charset">��GSM Modem ͨѶ���ַ��� GSM,UCS2</param>
        /// <param name="swHandshake">�������</param>
        /// <param name="sn">ͨѶ���֤��</param>
        /// <returns>�����Ƿ�ɹ�</returns>
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

        #region ��ȡ����è�µı�ʶ����
        /// <summary>
        /// ��ȡ����è�µı�ʶ����
        /// </summary>
        /// <param name="device">�˿ں�</param>
        /// <param name="baudrate">������</param>
        /// <returns>���ű�ʶ��</returns>
        [DllImport("dllforvc.dll",
             EntryPoint = "GSMModemGetSnInfoNew",
             CharSet = CharSet.Ansi,
             CallingConvention = CallingConvention.StdCall)]
        public static extern string GSMModemGetSnInfoNew(string device, string baudrate);
        #endregion

        #region ��ȡ��ǰͨѶ�˿�
        /// <summary>
        /// ��ȡ��ǰͨѶ�˿�
        /// </summary>
        /// <returns>�˿������磺��COM1��</returns>
        [DllImport("dllforvc.dll",
             EntryPoint = "GSMModemGetDevice",
             CharSet = CharSet.Ansi,
             CallingConvention = CallingConvention.StdCall)]
        public static extern string GSMModemGetDevice();
        #endregion

        #region ��ȡ��ǰͨѶ������
        /// <summary>
        /// ��ȡ��ǰͨѶ������
        /// </summary>
        /// <returns>�����ʣ��磺��9600��</returns>
        [DllImport("dllforvc.dll",
             EntryPoint = "GSMModemGetBaudrate",
             CharSet = CharSet.Ansi,
             CallingConvention = CallingConvention.StdCall)]
        public static extern string GSMModemGetBaudrate();
        #endregion

        #region �Ͽ����Ӳ��ͷ��ڴ�ռ�
        /// <summary>
        /// �Ͽ����Ӳ��ͷ��ڴ�ռ�
        /// </summary>
        [DllImport("dllforvc.dll",
             EntryPoint = "GSMModemRelease",
             CharSet = CharSet.Ansi,
             CallingConvention = CallingConvention.StdCall)]
        public static extern void GSMModemRelease();
        #endregion

        #region ȡ�ô�����Ϣ
        /// <summary>
        /// ȡ�ô�����Ϣ
        /// </summary>
        /// <returns>����˵������</returns>
        [DllImport("dllforvc.dll",
             EntryPoint = "GSMModemGetErrorMsg",
             CharSet = CharSet.Ansi,
             CallingConvention = CallingConvention.StdCall)]
        public static extern string GSMModemGetErrorMsg();
        #endregion

        #region ���Ͷ���Ϣ
        /// <summary>
        /// ���Ͷ���Ϣ
        /// </summary>
        /// <param name="serviceCenterAddress">ͨѶ���֤��</param>
        /// <param name="encodeval">�ı������ʽ,0-7bit;4-8bit,8-16bit</param>
        /// <param name="text">�����ı�</param>
        /// <param name="textlen">���͵��ı�����</param>
        /// <param name="phonenumber">�绰����</param>
        /// <param name="requestStatusReport">״̬����</param>
        /// <returns>�����Ƿ��ͳɹ�</returns>
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

        #region ���ն���Ϣ�����ַ�����ʽΪ:�ֻ�����|��������||�ֻ�����|��������||RD_optΪ�����ն���Ϣ�����κδ�����Ϊ���պ�ɾ����Ϣ
        /// <summary>
        /// ���ն���Ϣ�����ַ�����ʽΪ:�ֻ�����|��������||�ֻ�����|��������||RD_optΪ�����ն���Ϣ�����κδ�����Ϊ���պ�ɾ����Ϣ
        /// </summary>
        /// <param name="RD_opt">�Զ���Ϣ�Ĵ���0-ɾ����1-��������</param>
        /// <returns>���ŵ��ַ�����ʽ</returns>
        [DllImport("dllforvc.dll",
             EntryPoint = "GSMModemSMSReadAll",
             CharSet = CharSet.Ansi,
             CallingConvention = CallingConvention.StdCall)]
        public static extern string GSMModemSMSReadAll(int RD_opt);
        #endregion
    }
}
