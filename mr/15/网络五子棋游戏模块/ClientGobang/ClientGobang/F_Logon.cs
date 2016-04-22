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

        #region  声名变量
        Publec_Class PubClass = new Publec_Class();
        ClientClass frmClient = new ClientClass();
        #endregion

        #region  使Label控件透明
        /// <summary>
        /// 使Label控件透明.
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
            if (Publec_Class.ServerPort != "" && Publec_Class.ServerIP != "")   //当读取到服务器的IP和端口号时
            {
                udpSocket1.LocalPort = Convert.ToInt32(Publec_Class.ServerPort);
                udpSocket1.Active = true;   //启动自定义的udpSocket1控件
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
            //如果程序启动目录中没有Server.ini文件

            if (System.IO.File.Exists(PubClass.Get_windows() + "\\Gobang.ini") == false)
            {
                F_SerSetup FrmSerSetup = new F_SerSetup();  //创建并引用注册窗体
                FrmSerSetup.Text = "用户注册";  //设置注册窗体的名称
                if (FrmSerSetup.ShowDialog(this) == DialogResult.OK)    //当注册窗体的对话框返回值为OK时
                {
                    FrmSerSetup.Dispose();  //释放注册窗体的所有资源
                }
                else
                {
                    FrmSerSetup.Dispose();
                    DialogResult = DialogResult.Cancel;//将当前窗体的对话框返回值设为Cancel
                }
            }
            //如果Windows目录中有Server.ini文件
            if (System.IO.File.Exists(PubClass.Get_windows() + "\\Gobang.ini") == true)
            {
                Publec_Class.ServerIP = "";
                Publec_Class.ServerPort = "";
                //读取INI文件
                
                StringBuilder temp = new StringBuilder(255);
                //读取服务器的IP地址
                GetPrivateProfileString("MyGobang", "IP", "服务器地址读取错误。", temp, 255, PubClass.Get_windows() + "\\Gobang.ini");
                Publec_Class.ServerIP = temp.ToString();
                //读取端口号
                GetPrivateProfileString("MyGobang", "Port", "服务器端口号读取错误。", temp, 255, PubClass.Get_windows() + "\\Gobang.ini");
                Publec_Class.ServerPort = temp.ToString();
                //读取用户名称
                GetPrivateProfileString("MyGobang", "Name", "服务器端口号读取错误。", temp, 255, PubClass.Get_windows() + "\\Gobang.ini");
                Publec_Class.ClientName = temp.ToString();
                //读取用户头像
                GetPrivateProfileString("MyGobang", "Caput", "服务器端口号读取错误。", temp, 255, PubClass.Get_windows() + "\\Gobang.ini");
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

        private void DataArrival(byte[] Data, System.Net.IPAddress Ip, int Port) //当有数据到达后的处理进程
        {
            Publec_Class Pub_class = new Publec_Class();
            try
            {
                ClassMsg msg = new ClassSerializers().DeSerializeBinary((new System.IO.MemoryStream(Data))) as ClassMsg;
                switch (msg.msgCommand)
                {
                    case  MsgCommand.Logined://登录成功
                        Publec_Class.UserID = msg.SID;
                        Publec_Class.Fraction = msg.Fraction;
                        Publec_Class.UserSex = msg.Sex;
                        Publec_Class.ClientIP = Pub_class.MyHostIP();//获取当前计算机的IP地址
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