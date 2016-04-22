using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GobangClass;
using System.Net;
using System.Collections;
using System.IO;


namespace ClientGobang
{
    public partial class Frm_Hall : Form
    {
        public Frm_Hall()
        {
            InitializeComponent();
        }

        #region  全局变量
        ClientClass frmClient = new ClientClass();
        Publec_Class PubClass = new Publec_Class();
        ClassUsers users;
        public static bool PressGame = false;
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            frmClient.ImageDir();
            pictureBox_Back.Dock = DockStyle.Fill;
            F_Logon FrmLogon = new F_Logon();   //创建并引用登录窗体
            if (FrmLogon.ShowDialog(this) == DialogResult.OK)   //当登窗体的对话框的返回值为OK时
            {
                FrmLogon.Dispose();
                this.WindowState = FormWindowState.Maximized;
                //frmClient.BrushChar(panel_Public);
                udpSocket1.LocalHost = Publec_Class.ServerIP;
                udpSocket1.LocalPort = Convert.ToInt32(Publec_Class.ServerPort);
                udpSocket1.Active = true;
            }
            else
            {
                FrmLogon.Dispose();
                Close();
            }
        }

        private void Image_Close_Click(object sender, EventArgs e)
        {
            ClassMsg msg = new ClassMsg();//实例化ClassMsg类

            msg.UserName = Publec_Class.ClientName;
            msg.RoomMark = Publec_Class.TRoomM.ToString();
            msg.AreaMark = Publec_Class.TAreaM.ToString();

            msg.sendKind = SendKind.SendCommand;//当前为消息发送命令
            msg.msgCommand = MsgCommand.ExitToHall;//退出大厅
            //发送消息
            udpSocket1.Send(IPAddress.Parse(Publec_Class.ServerIP.Trim()), 11000, new ClassSerializers().SerializeBinary(msg).ToArray());
        }

        private void pictureBox_LA_Click(object sender, EventArgs e)
        {
            frmClient.HidePanel(panel_Tree);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmClient.HidePanel(panel_Public);
        }
        private static ClassMsg temMsg = new ClassMsg();
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            string GIP = "";
            if (PressGame == false)
            {
                GIP = frmClient.ToGameIP((PictureBox)sender);
                if (GIP == null)
                    GIP = "";
                if (GIP != "")
                {
                    temMsg.sendKind = SendKind.SendCommand;
                    temMsg.msgCommand = MsgCommand.BegingRival;
                    temMsg.DeskMark = ((PictureBox)sender).Name;
                    ClientClass.GameIP = GIP;
                    GIP = GIP.Substring(0, GIP.IndexOf('|'));
                    
                    temMsg.SIP = GIP.Trim();

                    udpSocket1.Send(IPAddress.Parse(GIP), 11001, new ClassSerializers().SerializeBinary(frmClient.Game_FarInfo(GIP)).ToArray());
                }
                else
                {
                    ClientClass.GameIP = "";
                    ClientClass.GamePort = "11001";
                    ClientClass.GameName = "";
                    ClientClass.GameFraction = "";
                    ClientClass.GameCaput = "";
                    ClientClass.GameSex = "";
                }
                temMsg = null;
                temMsg = frmClient.DeskHandle(((PictureBox)sender), imageList1, 1);
                PressGame = true;

                //发送消息
                udpSocket1.Send(IPAddress.Parse(Publec_Class.ServerIP), 11000, new ClassSerializers().SerializeBinary(temMsg).ToArray());


            }
        }

        private void Frm_Hall_Shown(object sender, EventArgs e)
        {
            TreeNode BNode = treeView_Area.Nodes[0];
            BNode.Expand();
            BNode.EndEdit(false);
        }

        private void Image_Max_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
            {
                if (this.WindowState == FormWindowState.Maximized)
                    this.WindowState = FormWindowState.Normal;
            }
            //frmClient.BrushChar(panel_Public);
        }

        private void Image_Min_Click(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Minimized)
                this.WindowState = FormWindowState.Minimized;
            else
            {
                //frmClient.BrushChar(panel_Public);
            }

        }

        private void panel_Title_MouseDown(object sender, MouseEventArgs e)
        {
            frmClient.CPoint = new Point(-e.X, -e.Y);
        }

        private void panel_Title_MouseMove(object sender, MouseEventArgs e)
        {
            frmClient.FrmMove(this, e);
        }

        private void udpSocket1_DataArrival(byte[] Data, IPAddress Ip, int Port)
        {
            DataArrivaldelegate outdelegate = new DataArrivaldelegate(DataArrival);
            this.BeginInvoke(outdelegate, new object[] { Data, Ip, Port });
        }

        private delegate void DataArrivaldelegate(byte[] Data, System.Net.IPAddress Ip, int Port);

        private void DataArrival(byte[] Data, System.Net.IPAddress Ip, int Port) //当有数据到达后的处理进程
        {
            try
            {
                ClassMsg msg = new ClassSerializers().DeSerializeBinary((new System.IO.MemoryStream(Data))) as ClassMsg;
                switch (msg.msgCommand)
                {
                    case MsgCommand.UserList://进入大厅获取在线用户列表
                        {
                            frmClient.Format_ListV(listView_user, imageList2);
                            GetUserList(Data, Ip, Port);
                            break;
                        }
                    case MsgCommand.Close://退出大厅
                        {
                            udpSocket1.Active = false;
                            this.Close();
                            break;
                        }
                    case MsgCommand.ComeToHallH:
                        {
                            frmClient.Data_List(listView_user, msg.UserName, msg.Fraction.ToString(), msg.CPhoto.ToString());
                            break;
                        }
                    case MsgCommand.ExitToHall:
                        {
                            frmClient.ReMove_List(listView_user, msg.UserName);
                            break;
                        }
                    case MsgCommand.BeginToGameL:
                        {
                            Frm_Chessboard FrmChessboard = new Frm_Chessboard();



                            if (FrmChessboard.ShowDialog() == DialogResult.OK)
                            {
                                //frmClient.Format_ListV(listView_user, imageList2);

                                ClassMsg msg1 = new ClassMsg();
                                msg1.AreaMark = Publec_Class.TAreaM.ToString();
                                msg1.RoomMark = Publec_Class.TRoomM.ToString();
                                msg1.RIP = PubClass.MyHostIP();
                                msg1.RPort = Publec_Class.ServerPort;
                                msg1.SIP = Publec_Class.ServerIP;
                                msg1.SPort = "11000";
                                msg1.sendKind = SendKind.SendCommand;
                                msg1.msgCommand = MsgCommand.ComeToHall;
                                msg1.CPhoto = Publec_Class.CaputID;
                                //发送消息
                                udpSocket1.Send(IPAddress.Parse(Publec_Class.ServerIP), 11000, new ClassSerializers().SerializeBinary(msg1).ToArray());

                                msg.sendKind = SendKind.SendCommand;
                                msg.msgCommand = MsgCommand.EndToGame;
                                udpSocket1.Send(IPAddress.Parse(Publec_Class.ServerIP), 11000, new ClassSerializers().SerializeBinary(msg).ToArray());
                            }
                            break;
                        }
                    case MsgCommand.ExitToArea:
                        {
                            if (Convert.ToInt32(msg.AreaMark) == Publec_Class.TAreaM && Convert.ToInt32(msg.RoomMark) == Publec_Class.TRoomM)
                                frmClient.ReMove_List(listView_user, msg.UserName);
                            break;
                        }
                    case MsgCommand.BeginToGameH:
                        {
                            frmClient.AddDeskMsg(flowPanel_Oppose, msg, imageList1,Ip.ToString(), msg.msgCommand);
                            break;
                        }
                    case MsgCommand.EndToGameH:
                        {
                            frmClient.AddDeskMsg(flowPanel_Oppose, msg, imageList1,Ip.ToString(), msg.msgCommand);
                            PressGame = false;
                            break;
                        }
                    case MsgCommand.EndRival:
                        {
                            frmClient.Game_TerraInfo(Data);
                            break;
                        }
                    case MsgCommand.ComeToSay:
                        {
                            frmClient.AddMsgText(RTB_Dialog, msg, msg.msgCommand);
                            break;
                        }
                }
            }
            catch { }
        }

        /// <summary>
        /// 获取当前房间的用户信息
        /// </summary>
        /// <param Data="byte[]">数据流</param>
        /// <param Ip="System.Net.IPAddress ">IP地址</param>
        /// <param Port="int">端口号</param>
        private void GetUserList(byte[] Data, System.Net.IPAddress Ip, int Port)
        {
            ClassMsg msg = (ClassMsg)new ClassSerializers().DeSerializeBinary(new MemoryStream(Data));
            users = (ClassUsers)new ClassSerializers().DeSerializeBinary(new MemoryStream(msg.Data));//获取所有用户信息

            ClassUserInfo userItem = new ClassUserInfo();
            frmClient.Data_List(listView_user,Publec_Class.ClientName , Publec_Class.Fraction.ToString(), Publec_Class.CaputID.ToString());
            for (int i = 0; i < users.Count; i++)
            {
                userItem = users[i];
                if (userItem.Borough == Publec_Class.TAreaM.ToString() && userItem.RoomMark == Publec_Class.TRoomM.ToString())
                {
                    if (userItem.State == (Convert.ToInt32(MsgCommand.ComeToHall)).ToString())
                    {
                        if (Publec_Class.ClientName != userItem.UserName)
                            frmClient.Data_List(listView_user, userItem.UserName, userItem.Fraction, userItem.Caput);
                    }
                    if (userItem.State == (Convert.ToInt32(MsgCommand.BeginToGame)).ToString())
                    {
                        if (Publec_Class.ClientName != userItem.UserName)
                        {
                            frmClient.Data_List(listView_user, userItem.UserName, userItem.Fraction, userItem.Caput);
                            frmClient.UserAdd_List(flowPanel_Oppose, userItem,imageList1);
                        }
                    }
                }
            }

        }


        private static int IAreaM = 0;
        private static int IRoomM = 0;
        private void treeView_Area_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            ClientClass CClass = new ClientClass();
            string TemNodeS = e.Node.Name;
            TreeNode tNode = new TreeNode();
            if (TemNodeS.IndexOf("Room_") >= 0)
            {
                tNode = e.Node;
                Publec_Class.TRoomM = Convert.ToInt32(tNode.Tag.ToString());
                TreeNode t2Node = new TreeNode();
                t2Node = (TreeNode)tNode.Parent;
                Publec_Class.TAreaM = Convert.ToInt32(t2Node.Tag.ToString());
                if (IAreaM == Publec_Class.TAreaM && IRoomM == Publec_Class.TRoomM)//如果进入的是同一个房间 
                    return;

                if (Publec_Class.TAreaM > 0 && Publec_Class.TRoomM > 0)
                {
                    //listView_user.Items.Clear();
                    ClassMsg TeMsg = new ClassMsg();
                    TeMsg.sendKind = SendKind.SendCommand;
                    TeMsg.msgCommand = MsgCommand.ExitToArea;
                    TeMsg.AreaMark = IAreaM.ToString();
                    TeMsg.RoomMark = IRoomM.ToString();
                    TeMsg.UserName = Publec_Class.UserName;
                    udpSocket1.Send(IPAddress.Parse(Publec_Class.ServerIP), 11000, new ClassSerializers().SerializeBinary(TeMsg).ToArray());
                }

                if (pictureBox_Back.Visible == true)
                {
                    pictureBox_Back.Visible = false;
                    flowPanel_Oppose.Visible = true;
                    //frmClient.BrushChar(panel_Public);
                }

                //设置要传递的信息
                ClassMsg msg = new ClassMsg();
                msg.AreaMark = Publec_Class.TAreaM.ToString();
                msg.RoomMark = Publec_Class.TRoomM.ToString();
                msg.RIP = PubClass.MyHostIP();
                msg.RPort = Publec_Class.ServerPort;
                msg.SIP = Publec_Class.ServerIP;
                msg.SPort = "11000";
                msg.sendKind = SendKind.SendCommand;
                msg.msgCommand = MsgCommand.ComeToHall;
                msg.CPhoto = Publec_Class.CaputID;
                //发送消息
                udpSocket1.Send(IPAddress.Parse(Publec_Class.ServerIP), 11000, new ClassSerializers().SerializeBinary(msg).ToArray());
                CClass.SetLabelModule(flowPanel_Oppose, imageList1);
                IAreaM = Publec_Class.TAreaM;
                IRoomM = Publec_Class.TRoomM;
            }
        }

        private void treeView_Area_BeforeCollapse(object sender, TreeViewCancelEventArgs e)
        {
            if (Convert.ToInt32(e.Node.Tag.ToString()) == 0)
            {
                e.Cancel = true;
            }
        }



        private void pictureBox_Hair_Click(object sender, EventArgs e)
        {
            //设置要传递的信息
            ClassMsg msg = new ClassMsg();
            msg.sendKind = SendKind.SendCommand;
            msg.msgCommand = MsgCommand.ComeToSay;
            msg.UserName = Publec_Class.UserName+"：";
            msg.MsgText = comboBox_Hair.Text.Trim();

            //发送消息
            udpSocket1.Send(IPAddress.Parse(Publec_Class.ServerIP), 11000, new ClassSerializers().SerializeBinary(msg).ToArray());
            comboBox_Hair.Text = "";
        }

        private void comboBox_Hair_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                pictureBox_Hair_Click(sender, e);
            }
        }

        private void Image_Min_MouseEnter(object sender, EventArgs e)
        {
            switch (Convert.ToInt32(((PictureBox)sender).Tag.ToString()))
            {
                case 1:
                    {
                        ((PictureBox)sender).Image = null;
                        ((PictureBox)sender).Image = Image.FromFile(ClientClass.ImaDir + "\\Image\\最小化变色.jpg");
                        break;
                    }
                case 2:
                    {
                        ((PictureBox)sender).Image = null;
                        ((PictureBox)sender).Image = Image.FromFile(ClientClass.ImaDir + "\\Image\\最大化变色.jpg");
                        break;
                    }
                case 3:
                    {
                        ((PictureBox)sender).Image = null;
                        ((PictureBox)sender).Image = Image.FromFile(ClientClass.ImaDir + "\\Image\\关闭变色.jpg");
                        break;
                    }
                case 4:
                    {
                        ((PictureBox)sender).Image = null;
                        ((PictureBox)sender).Image = Image.FromFile(ClientClass.ImaDir + "\\Image\\发送按钮变色.png");
                        break;
                    }
            }
        }

        private void Image_Min_MouseLeave(object sender, EventArgs e)
        {
            switch (Convert.ToInt32(((PictureBox)sender).Tag.ToString()))
            {
                case 1:
                    {
                        ((PictureBox)sender).Image = null;
                        ((PictureBox)sender).Image = Image.FromFile(ClientClass.ImaDir + "\\Image\\最小化按钮.jpg");
                        break;
                    }
                case 2:
                    {
                        ((PictureBox)sender).Image = null;
                        ((PictureBox)sender).Image = Image.FromFile(ClientClass.ImaDir + "\\Image\\最大化按钮.jpg");
                        break;
                    }
                case 3:
                    {
                        ((PictureBox)sender).Image = null;
                        ((PictureBox)sender).Image = Image.FromFile(ClientClass.ImaDir + "\\Image\\关闭按钮.jpg");
                        break;
                    }
                case 4:
                    {
                        ((PictureBox)sender).Image = null;
                        ((PictureBox)sender).Image = Image.FromFile(ClientClass.ImaDir + "\\Image\\发送按钮.png");
                        break;
                    }
            }
        }

    }
}