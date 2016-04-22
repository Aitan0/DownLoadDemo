using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Net;
using System.IO;
using GobangClass;

namespace ClientGobang
{
    public partial class F_SerSetup : Form
    {
        public F_SerSetup()
        {
            InitializeComponent();
        }

        ClientClass frmClass = new ClientClass();
        Publec_Class PubClass =new Publec_Class();
        string serID = "";

        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);


        private void button_Close_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            if (text_PassWord.Text.Trim() == text_PassWord2.Text.Trim())    //当密码输入相同
            {
                udpSocket1.LocalPort = Convert.ToInt32(text_IP5.Text.Trim());
                udpSocket1.Active = true;
                ClassMsg msg = new ClassMsg();
                msg.UserName = text_Name.Text;
                msg.PassWord = text_PassWord.Text;
                msg.sendKind = SendKind.SendCommand;
                msg.msgCommand = MsgCommand.Registering;
                serID = text_IP.Text.Trim();
                msg.RIP = serID.Trim();
                msg.RPort = text_IP5.Text.Trim();
                msg.CPhoto = comboBox_CPhoto.SelectedIndex;
                if (comboBox_Sex.SelectedIndex <= 0)
                    msg.Sex = 0;
                else
                    msg.Sex = 1;
                udpSocket1.Send(IPAddress.Parse(serID), 11000, new ClassSerializers().SerializeBinary(msg).ToArray());
            }
            else
            {
                text_PassWord.Text = "";
                text_PassWord2.Text = "";
                MessageBox.Show("密码与确认密码不匹配，请重新输入。");
            }
        }

        private delegate void DataArrivaldelegate(byte[] Data, System.Net.IPAddress Ip, int Port);

        private void sockUDP1_DataArrival(byte[] Data, System.Net.IPAddress Ip, int Port)
        {
            DataArrivaldelegate outdelegate = new DataArrivaldelegate(DataArrival); //托管
            this.BeginInvoke(outdelegate, new object[] { Data, Ip, Port }); //异步执行托管
        }

        private void DataArrival(byte[] Data, System.Net.IPAddress Ip, int Port) //当有数据到达后的处理进程
        {
            try
            {
                ClassMsg msg = new ClassSerializers().DeSerializeBinary((new System.IO.MemoryStream(Data))) as ClassMsg;

                switch (msg.msgCommand)
                {
                    case MsgCommand.Registered://注册成功
                        {
                            DialogResult = DialogResult.OK;
                            WritePrivateProfileString("MyGobang", "IP", serID, PubClass.Get_windows() + "\\Gobang.ini");
                            WritePrivateProfileString("MyGobang", "Port", text_IP5.Text.Trim(), PubClass.Get_windows() + "\\Gobang.ini");
                            WritePrivateProfileString("MyGobang", "Name", text_Name.Text.Trim(), PubClass.Get_windows() + "\\Gobang.ini");
                            WritePrivateProfileString("MyGobang", "Caput", comboBox_CPhoto.SelectedIndex.ToString(), PubClass.Get_windows() + "\\Gobang.ini");
                            udpSocket1.Active = false;
                            this.Close();
                            break;
                        }
                    case MsgCommand.RegisterAt:
                        {
                            MessageBox.Show("用户名已被注册，请重新输入！");
                            text_Name.Text = "";
                            text_PassWord.Text = "";
                            text_PassWord2.Text = "";
                            break;
                        }
                }
            }
            catch { }
        }

        private void F_SerSetup_FormClosed(object sender, FormClosedEventArgs e)
        {
            udpSocket1.Active = false;
        }

        private void comboBox_CPhoto_DrawItem(object sender, DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle r = e.Bounds;
            Size imageSize = imageList1.ImageSize;

            if (e.Index >= 0)
            {
                string s = (string)comboBox_CPhoto.Items[e.Index];
                StringFormat sf = new StringFormat();
                sf.Alignment = StringAlignment.Near;
                if (e.State == (DrawItemState.NoAccelerator | DrawItemState.NoFocusRect))
                {
                    //绘制图像 
                    imageList1.Draw(e.Graphics, r.Left, r.Top, e.Index);
                    //显示取得焦点时的虚线框 
                    e.DrawFocusRectangle();
                }
                else
                {
                    e.Graphics.FillRectangle(new SolidBrush(Color.White), r);
                    imageList1.Draw(e.Graphics, r.Left, r.Top, e.Index);
                    e.DrawFocusRectangle();
                }
            }
        }

        private void F_SerSetup_Shown(object sender, EventArgs e)
        {
            comboBox_CPhoto.Items.Clear();
            comboBox_CPhoto.DrawMode = DrawMode.OwnerDrawFixed;
            comboBox_CPhoto.DropDownStyle = ComboBoxStyle.DropDownList;
            for (int i = 0; i < imageList1.Images.Count; i++)
            {
                comboBox_CPhoto.Items.Add("");
            }
        }
    }
}