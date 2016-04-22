using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Collections;
using System.Threading;
using System.Runtime.InteropServices;
using GobangClass;

namespace ClientGobang
{
    public partial class F_Logon : Form
    {
        public F_Logon()
        {
            InitializeComponent();
        }

        #region  ��������
        Publec_Class PubClass = new Publec_Class();
        ClientClass frmClient = new ClientClass();
        #endregion

        #region  ʹLabel�ؼ�͸��
        /// <summary>
        /// ʹLabel�ؼ�͸��.
        /// </summary>
        public void Trans(Label lab, PictureBox pic)
        {
            lab.BackColor = Color.Transparent;
            lab.Parent = pic;
        }
        #endregion

        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);

        private void button_QQLogon_Click(object sender, EventArgs e)
        {
            if (Publec_Class.ServerPort != "" && Publec_Class.ServerIP != "")   //����ȡ����������IP�Ͷ˿ں�ʱ
            {
                udpSocket1.LocalPort = Convert.ToInt32(Publec_Class.ServerPort);
                udpSocket1.Active = true;   //�����Զ����udpSocket1�ؼ�
                ClassMsg msg = new ClassMsg();
                msg.UserName = text_Name.Text;
                msg.PassWord = text_PassWord.Text;
                msg.sendKind = SendKind.SendCommand;
                msg.msgCommand = MsgCommand.Logining;
                string IP = Publec_Class.ServerIP;
                string Port = Publec_Class.ServerPort;
                udpSocket1.LocalPort = Convert.ToInt32(Port);
                udpSocket1.Send(IPAddress.Parse(IP.Trim()), 11000, new ClassSerializers().SerializeBinary(msg).ToArray());
                Publec_Class.UserName = text_Name.Text;

             }
        }

        private void F_Logon_Load(object sender, EventArgs e)
        {
            //�����������Ŀ¼��û��Server.ini�ļ�

            if (System.IO.File.Exists(PubClass.Get_windows() + "\\Gobang.ini") == false)
            {
                F_SerSetup FrmSerSetup = new F_SerSetup();  //����������ע�ᴰ��
                FrmSerSetup.Text = "�û�ע��";  //����ע�ᴰ�������
                if (FrmSerSetup.ShowDialog(this) == DialogResult.OK)    //��ע�ᴰ��ĶԻ��򷵻�ֵΪOKʱ
                {
                    FrmSerSetup.Dispose();  //�ͷ�ע�ᴰ���������Դ
                }
                else
                {
                    FrmSerSetup.Dispose();
                    DialogResult = DialogResult.Cancel;//����ǰ����ĶԻ��򷵻�ֵ��ΪCancel
                }
            }
            //���WindowsĿ¼����Server.ini�ļ�
            if (System.IO.File.Exists(PubClass.Get_windows() + "\\Gobang.ini") == true)
            {
                Publec_Class.ServerIP = "";
                Publec_Class.ServerPort = "";
                //��ȡINI�ļ�
                
                StringBuilder temp = new StringBuilder(255);
                //��ȡ��������IP��ַ
                GetPrivateProfileString("MyGobang", "IP", "��������ַ��ȡ����", temp, 255, PubClass.Get_windows() + "\\Gobang.ini");
                Publec_Class.ServerIP = temp.ToString();
                //��ȡ�˿ں�
                GetPrivateProfileString("MyGobang", "Port", "�������˿ںŶ�ȡ����", temp, 255, PubClass.Get_windows() + "\\Gobang.ini");
                Publec_Class.ServerPort = temp.ToString();
                //��ȡ�û�����
                GetPrivateProfileString("MyGobang", "Name", "�������˿ںŶ�ȡ����", temp, 255, PubClass.Get_windows() + "\\Gobang.ini");
                Publec_Class.ClientName = temp.ToString();
                //��ȡ�û�ͷ��
                GetPrivateProfileString("MyGobang", "Caput", "�������˿ںŶ�ȡ����", temp, 255, PubClass.Get_windows() + "\\Gobang.ini");
                Publec_Class.CaputID = Convert.ToInt32(temp.ToString());
            }
            else
            {
                DialogResult = DialogResult.Cancel;
            }
            
        }
        
        private void button_QQClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            udpSocket1.Active = false;
        }

        private void udpSocket1_DataArrival(byte[] Data, IPAddress Ip, int Port)
        {
            DataArrivaldelegate outdelegate = new DataArrivaldelegate(DataArrival);
            this.BeginInvoke(outdelegate, new object[] { Data, Ip, Port }); 
        }

        private delegate void DataArrivaldelegate(byte[] Data, System.Net.IPAddress Ip, int Port);

        private void DataArrival(byte[] Data, System.Net.IPAddress Ip, int Port) //�������ݵ����Ĵ������
        {
            Publec_Class Pub_class = new Publec_Class();
            try
            {
                ClassMsg msg = new ClassSerializers().DeSerializeBinary((new System.IO.MemoryStream(Data))) as ClassMsg;
                switch (msg.msgCommand)
                {
                    case  MsgCommand.Logined://��¼�ɹ�
                        Publec_Class.UserID = msg.SID;
                        Publec_Class.Fraction = msg.Fraction;
                        Publec_Class.UserSex = msg.Sex;
                        Publec_Class.ClientIP = Pub_class.MyHostIP();//��ȡ��ǰ�������IP��ַ
                        DialogResult = DialogResult.OK;
                        udpSocket1.Active = false;
                        this.Close();
                        break;

                }
            }
            catch { }
        }

        private void F_Logon_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (udpSocket1.Active)
                udpSocket1.Active = false;
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            frmClient.CPoint = new Point(-e.X, -e.Y);
        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            frmClient.FrmMove(this, e);
        }
    }
}