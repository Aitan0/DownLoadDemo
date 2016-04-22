using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;//域名解析功能的命名空间
using System.Collections;//代送器的命名空间
using System.Runtime.InteropServices;//主机地址容器的命名空间
using System.Net.Sockets;//Sockets命名空间
using System.Threading;//线程命名空
using System.IO;
using GobangClass;

namespace ClientGobang
{
    public partial class Frm_Chessboard : Form
    {
        public Frm_Chessboard()
        {
            InitializeComponent();
        }

        public static int ConnHandle = 0;//对连接、准备、开始按钮的操作标识进行记录
        public static float Mouse_X = 0;//记录鼠标的X坐标
        public static float Mouse_Y = 0;//记录鼠标的Y坐标
        public static int[,] note = new int[15, 15];//记录棋子的摆放位置
        public static bool Conqueror = false;//记录当前是否已决出胜负
        public static int CKind = -1;//记录取胜的棋种
        public static bool dropchild = true;//当前该谁落子
        public static bool StartListen = false;//是否启动了监听
        public static int jlsf = -1;
        public static string LineName = "";//线程名
        public static bool Agin_if = false;//判断是否重新开始
        public static int if_UPdata = 0;//是否更改分数
        public static bool childSgin = true;//棋子类型
        public static bool ChildSgin = true;//对方棋子类型

        public int BBow = 0;
        int BwinCount = 0;
        int WwinCount = 0;
        bool Out = false;
        public bool CanAgin, CanAgins, CanDown, WhoFisrtDown;
        private Socket listener;
        private Thread mainThread;
        ClassUsers users;
        ClientClass frmClient = new ClientClass();

        public static string GIP = ClientClass.GameIP;//IP地址
        public static string GPort = "11003";//端口号
        public static string Gem_N = "";//名称
        public static int Gem_F = 0;//分数
        public static int Gem_C = 0;//头象
        public static int Gem_S = 0;//性别

        public void GetGameInfo(string temInfo)
        {
            if (temInfo.Length == 0)
                return;
            string Tem_Str=GIP;
            if (Tem_Str.IndexOf('|') == -1)
                return;
            try
            {
                GIP = Tem_Str.Substring(0, Tem_Str.IndexOf('|'));
                Tem_Str = Tem_Str.Substring(Tem_Str.IndexOf('|') + 1, Tem_Str.Length - Tem_Str.IndexOf('|') - 1);
                Gem_N = Tem_Str.Substring(0, Tem_Str.IndexOf('|'));
                Tem_Str = Tem_Str.Substring(Tem_Str.IndexOf('|') + 1, Tem_Str.Length - Tem_Str.IndexOf('|') - 1);
                Gem_F = Convert.ToInt32(Tem_Str.Substring(0, Tem_Str.IndexOf('|')));
                Tem_Str = Tem_Str.Substring(Tem_Str.IndexOf('|') + 1, Tem_Str.Length - Tem_Str.IndexOf('|') - 1);
                Gem_C = Convert.ToInt32(Tem_Str.Substring(0, Tem_Str.IndexOf('|')));
                Tem_Str = Tem_Str.Substring(Tem_Str.IndexOf('|') + 1, Tem_Str.Length - Tem_Str.IndexOf('|') - 1);
                Gem_S = Convert.ToInt32(Tem_Str);
            }
            catch
            {
                MessageBox.Show("获取对方的数据时出错");
            }
        }

        private void Frm_Chessboard_Shown(object sender, EventArgs e)
        {
            frmClient.Format_ListV(listView_Battle, imageList2);
            frmClient.Data_List(listView_Battle, Publec_Class.UserName, Publec_Class.Fraction.ToString(), Publec_Class.CaputID.ToString());
            label_N.Text = Publec_Class.UserName;
            label_F.Text = Publec_Class.Fraction.ToString();
            pictureBox_C.Image = null;
            if (Publec_Class.UserSex == 0)
            {
                pictureBox_C.Image = Image.FromFile(ClientClass.ImaDir + "\\Image\\男人.png");
            }
            else
            {
                pictureBox_C.Image = Image.FromFile(ClientClass.ImaDir + "\\Image\\女人.png");
            }
            
            GIP = ClientClass.GameIP.Trim();//IP地址
            if (GIP == "")
            {
                pictureBox2.Enabled = false;
                //label_Genre.Text = GIP;

                pictureBox_Left.Image = null;
                pictureBox_Right.Image = null;
                if (Publec_Class.UserSex == 0)
                {
                    pictureBox_Right.Image = Image.FromFile(ClientClass.ImaDir + "\\Image\\男人.png");
                }
                else
                {
                    pictureBox_Right.Image = Image.FromFile(ClientClass.ImaDir + "\\Image\\女人.png");
                }
                label_Right.Text = Publec_Class.UserName;

                pictureBox_Q_Right.Image = null;
                pictureBox_Q_Right.Image = Image.FromFile(ClientClass.ImaDir + "\\Image\\黑棋.png");

                this.pictureBox2.Image = null;
                this.pictureBox2.Image = Image.FromFile(ClientClass.ImaDir + "\\Image\\开始按钮灰.png");
                this.pictureBox2.Enabled = false;
            }
            else
            {
                
                GetGameInfo(ClientClass.GameIP);
                ClassMsg temMsg = new ClassMsg();
                ClassUsers Users = new ClassUsers();
                ClassUserInfo UserItem = new ClassUserInfo();//创建并引用ClassUserInfo类

                pictureBox_Left.Image = null;
                if (Publec_Class.UserSex == 0)
                {
                    pictureBox_Left.Image = Image.FromFile(ClientClass.ImaDir + "\\Image\\男人.png");
                }
                else
                {
                    pictureBox_Left.Image = Image.FromFile(ClientClass.ImaDir + "\\Image\\女人.png");
                }
                pictureBox_Q_Left.Image = null;
                pictureBox_Q_Left.Image = Image.FromFile(ClientClass.ImaDir + "\\Image\\白棋.png");
                label_Left.Text = Publec_Class.UserName;


                pictureBox_Right.Image = null;
                if (Gem_S == 0)
                {
                    pictureBox_Right.Image = Image.FromFile(ClientClass.ImaDir + "\\Image\\男人.png");
                }
                else
                {
                    pictureBox_Right.Image = Image.FromFile(ClientClass.ImaDir + "\\Image\\女人.png");
                }
                label_Right.Text = Gem_N;

                pictureBox_Q_Right.Image = null;
                pictureBox_Q_Right.Image = Image.FromFile(ClientClass.ImaDir + "\\Image\\黑棋.png");

                frmClient.Data_List(listView_Battle, Gem_N, Gem_F.ToString(), Gem_C.ToString());

                temMsg.sendKind = SendKind.SendCommand;
                temMsg.msgCommand = MsgCommand.GetGameF;
                temMsg.RIP = GIP;

                //原来是11000
                udpSocket1.Send(IPAddress.Parse(Publec_Class.ServerIP), 11001, new ClassSerializers().SerializeBinary(temMsg).ToArray());

                this.pictureBox2.Image = null;
                this.pictureBox2.Enabled = true;
                this.pictureBox2.Image = Image.FromFile(ClientClass.ImaDir + "\\Image\\开始按钮.png");

                UserItem.UserIP = Publec_Class.ClientIP;//记录用户的IP地址
                UserItem.UserPort = Publec_Class.ServerPort;//记录端口号
                UserItem.UserName = Publec_Class.UserName;//记录用户名称
                UserItem.Fraction = Publec_Class.Fraction.ToString();//当前分数
                UserItem.Caput = Publec_Class.CaputID.ToString();//头像
                UserItem.Sex = Publec_Class.UserSex.ToString();//性别
                Users.add(UserItem);//将单用户信息添加到用户列表中

                pictureBox2.Enabled = true;
                ThreadStart ts = new ThreadStart(this.StartServer);
                mainThread = new Thread(ts);
                mainThread.Name = "GOB_Chess";
                LineName = mainThread.Name;
                mainThread.Start();

                temMsg.Data = new ClassSerializers().SerializeBinary(Users).ToArray();//将用户列表写入到二进制流中
                temMsg.msgCommand = MsgCommand.BeginJoin;
                udpSocket1.Send(IPAddress.Parse(GIP), 11001, new ClassSerializers().SerializeBinary(temMsg).ToArray());
                StartListen = true;
                ConnHandle = 1;
            }
            panel_Check.Click += new EventHandler(asd);
            CanDown = false;
            
            for (int i = 0; i < 15; i++)
                for (int j = 0; j < 15; j++)
                    note[i, j] = -1;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            this.pictureBox2.Image = null;
            this.pictureBox2.Image = Image.FromFile(ClientClass.ImaDir + "\\Image\\开始按钮灰.png");
            this.pictureBox2.Enabled = false;

            switch (ConnHandle)
            {
                case 1:
                    {
                        ClientGobang.ChessClass.Client cc = ClientGobang.Program.PublicClientObject;
                        if (cc.Connected)
                        {
                            cc.CloseConnection();
                        }

                        try
                        {
                            if (GIP == "")
                                break;
                            cc.ConnectServer(GIP, int.Parse("11003"));
                        }
                        catch
                        {
                            MessageBox.Show("连接服务器失败");
                            this.pictureBox2.Image = null;
                            this.pictureBox2.Enabled = true;
                            this.pictureBox2.Image = Image.FromFile(ClientClass.ImaDir + "\\Image\\开始按钮.png");
                            return;
                        }
                        WhoFisrtDown = false;
                        cc.SendMessage("FiDn" + "Me");
                        CanDown = true;
                        ConnHandle = 2;
                        break;
                    }
                case 2:
                    {

                        CanAgin = true;
                        WhoFisrtDown = false;
                        dropchild = true;
                        CanDown = true;
                        Conqueror = false;
                        ClientGobang.ChessClass.Client cc = ClientGobang.Program.PublicClientObject;
                        cc.SendMessage("FiDn" + "Me");
                        if (Agin_if == false)
                        {
                            cc.SendMessage("Agin#" + "OK?");
                            Agin();
                        }
                        else
                        {
                            Agin_if = false;
                            if (panel_Check.Controls.Count > 10)
                            {
                                Agin();
                            }
                        }
                        BBow = BBow + 1;
                        pBox_Sign.Visible = false;
                        Conqueror = false;
                        break;
                    }
            }
            childSgin = true;
        }

        private void panel_Check_MouseDown(object sender, MouseEventArgs e)
        {
            Mouse_X = e.X;
            Mouse_Y = e.Y;
        }

        private void panel_Title_MouseDown(object sender, MouseEventArgs e)
        {
            
            frmClient.CPoint = new Point(-e.X, -e.Y);
        }

        private void panel_Title_MouseMove(object sender, MouseEventArgs e)
        {
            frmClient.FrmMove(this, e);
        }

        public ClassMsg temMsg2 = new ClassMsg();
        private void pictureBox1_Click(object sender, EventArgs e)
        {

            ClientGobang.ChessClass.Client cc = ClientGobang.Program.PublicClientObject;
            cc.CloseConnection();
            if (Out == true)
            {
                listener.Close();
            }
            ConnHandle = 0;
            if (GIP.Trim().Length > 4)
            {
                temMsg2.msgCommand = MsgCommand.ExitJoin;
                udpSocket1.Send(IPAddress.Parse(GIP), 11001, new ClassSerializers().SerializeBinary(temMsg2).ToArray());
                MessageBox.Show("是否关闭窗体");
                
            }
            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        //点击棋盘
        public void asd(object sender, EventArgs e)
        {
            if (dropchild == false)
                return;
            if ((Mouse_X <= 30.0 / 2.0) || (Mouse_Y <= 30.0 / 2.0))
                return;
            if (CanDown == true)
            {
                if (Conqueror == true)
                {
                    if (CKind == 0)
                        Bwin();
                    if (CKind == 1)
                        Wwin();
                    return;
                }
                if (WhoFisrtDown == true)
                {
                    int Column = Convert.ToInt32(Math.Round((Mouse_X - 30) / 35));
                    int Row = Convert.ToInt32(Math.Round((Mouse_Y - 30) / 35));
                    int bw = 0;

                    if (note[Convert.ToInt32(Row), Convert.ToInt32(Column)] >= 0)
                        return;

                    PictureBox pictureBoxTem = new PictureBox();
                    pictureBoxTem.Parent = panel_Check;
                    pictureBoxTem.Location = new System.Drawing.Point(Column * 35 + 9, Row * 35 + 9);
                    pictureBoxTem.Name = "pictureBox" + Row.ToString() + "*" + Column.ToString();
                    pBox_Sign.Location = new System.Drawing.Point(Column * 35 + 20, Row * 35 + 20);

                    pictureBoxTem.Size = new System.Drawing.Size(30, 30);
                    pictureBoxTem.SizeMode = PictureBoxSizeMode.StretchImage;
                    ClientGobang.ChessClass.Client cc = Program.PublicClientObject;
                    BBow++;
                    pBox_Sign.Visible = true;
                    pBox_Sign.BringToFront();
                    if (BBow % 2 == 1)
                    {

                        label_Genre.Text = "黑棋";
                        label_Genre.Tag = 0;
                        pictureBoxTem.Image = imageList1.Images[0];
                        bw = 0;
                        note[Row, Column] = 0;
                        cc.SendMessage("Down#" + Row.ToString() + "*" + Column.ToString() + "|" + "0" + "@" + BBow.ToString());
                    }
                    else
                    {

                        label_Genre.Text = "白棋";
                        label_Genre.Tag = 1;
                        pictureBoxTem.Image = imageList1.Images[1];
                        bw = 1;
                        note[Row, Column] = 1;
                        cc.SendMessage("Down#" + Row.ToString() + "*" + Column.ToString() + "|" + "1" + "@" + BBow.ToString());
                    }

                    if (childSgin == true)
                    {
                        if (BBow % 2 == 1)
                        {
                            if (label_Left.Text.Trim() == Publec_Class.UserName)
                            {
                                pictureBox_Q_Left.Image = null;
                                pictureBox_Q_Left.Image = Image.FromFile(ClientClass.ImaDir + "\\Image\\黑棋.png");
                            }
                            else
                            {
                                pictureBox_Q_Right.Image = null;
                                pictureBox_Q_Right.Image = Image.FromFile(ClientClass.ImaDir + "\\Image\\白棋.png");
                            }
                        }
                        else
                        {
                            if (label_Left.Text.Trim() == Publec_Class.UserName)
                            {
                                pictureBox_Q_Left.Image = null;
                                pictureBox_Q_Left.Image = Image.FromFile(ClientClass.ImaDir + "\\Image\\白棋.png");
                            }
                            else
                            {
                                pictureBox_Q_Right.Image = null;
                                pictureBox_Q_Right.Image = Image.FromFile(ClientClass.ImaDir + "\\Image\\黑棋.png");
                            }
                        }
                        childSgin = false;
                    }




                    note[Row, Column] = bw;
                    if_UPdata = 0;
                    Arithmetic(bw, Row, Column);
                }
                else
                {
                    MessageBox.Show("对方还没有落子！");
                    dropchild = true;
                    return;
                }
            }
            else
            {
                MessageBox.Show("本盘棋局没有开始无法下棋！");
                dropchild = true;
                return;
            }
            dropchild = false;
        }

        //添加对方下的棋
        public void AddChess(object sender, ClientGobang.ChessClass.AddChessEventArgs e)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(
                    new EventHandler<ClientGobang.ChessClass.AddChessEventArgs>(this.AddChess),
                    new object[] { sender, e });
            }
            else
            {

                string Cplace = e.Number;
                string Ccolumn = Cplace.Substring(0, Cplace.IndexOf("*"));
                string Crow = Cplace.Substring(Cplace.IndexOf("*") + 1, Cplace.Length - (Cplace.IndexOf("*") + 1));
                PictureBox pictureBoxTem = new PictureBox();
                pictureBoxTem.Parent = panel_Check;
                pictureBoxTem.Location = new System.Drawing.Point(Convert.ToInt32(Crow) * 35 + 9, Convert.ToInt32(Ccolumn) * 35 + 9);
                pictureBoxTem.Name = "pictureBox" + e.Number;
                pictureBoxTem.Size = new System.Drawing.Size(30, 30);
                pictureBoxTem.SizeMode = PictureBoxSizeMode.StretchImage;
                note[Convert.ToInt32(Ccolumn), Convert.ToInt32(Crow)] = Convert.ToInt32(e.Im);
                int num = Int32.Parse(e.Im);
                BBow = Int32.Parse(e.Bow);
                pictureBoxTem.Image = imageList1.Images[num];
                pBox_Sign.Visible = true;
                pBox_Sign.Location = new System.Drawing.Point(Convert.ToInt32(Crow) * 35 + 20, Convert.ToInt32(Ccolumn) * 35 + 20);
                pBox_Sign.BringToFront();
                if_UPdata = 1;
                Arithmetic(num, Convert.ToInt32(Ccolumn), Convert.ToInt32(Crow));
                if_UPdata = 0;

                if (ChildSgin == true)
                {
                    if (BBow % 2 == 1)
                    {
                        if (label_Left.Text.Trim() == Publec_Class.UserName)
                        {
                            pictureBox_Q_Left.Image = null;
                            pictureBox_Q_Left.Image = Image.FromFile(ClientClass.ImaDir + "\\Image\\黑棋.png");
                        }
                        else
                        {
                            pictureBox_Q_Right.Image = null;
                            pictureBox_Q_Right.Image = Image.FromFile(ClientClass.ImaDir + "\\Image\\白棋.png");
                        }
                    }
                    else
                    {
                        if (label_Left.Text.Trim() == Publec_Class.UserName)
                        {
                            pictureBox_Q_Left.Image = null;
                            pictureBox_Q_Left.Image = Image.FromFile(ClientClass.ImaDir + "\\Image\\白棋.png");
                        }
                        else
                        {
                            pictureBox_Q_Right.Image = null;
                            pictureBox_Q_Right.Image = Image.FromFile(ClientClass.ImaDir + "\\Image\\黑棋.png");
                        }
                    }
                    ChildSgin = false;
                }
            }
            WhoFisrtDown = true;
            dropchild = true;
        }
        //判断黑棋是否赢
        public void Bwin()
        {
            MessageBox.Show("黑子赢了!!请重新开始游戏！");

            ClassMsg temMsg = new ClassMsg();
            if (label_Genre.Text == "黑棋")
            {
                for (int i = 0; i < listView_Battle.Items.Count; i++)
                {
                    if (listView_Battle.Items[i].SubItems[1].Text.Trim() == Publec_Class.UserName.Trim())
                    {
                        Publec_Class.Fraction = Publec_Class.Fraction + 10;
                        listView_Battle.Items[i].SubItems[2].Text = Publec_Class.Fraction.ToString();
                        label_F.Text = Publec_Class.Fraction.ToString();
                    }
                    if (listView_Battle.Items[i].SubItems[1].Text.Trim() == Gem_N)
                    {
                        Gem_F = Gem_F - 10;
                        listView_Battle.Items[i].SubItems[2].Text = Gem_F.ToString();
                    }
                }

            }
            else
            {
                for (int i = 0; i < listView_Battle.Items.Count; i++)
                {
                    if (listView_Battle.Items[i].SubItems[1].Text.Trim() == Publec_Class.UserName.Trim())
                    {
                        Publec_Class.Fraction = Publec_Class.Fraction - 10;
                        listView_Battle.Items[i].SubItems[2].Text = Publec_Class.Fraction.ToString();
                        label_F.Text = Publec_Class.Fraction.ToString();
                    }
                    if (listView_Battle.Items[i].SubItems[1].Text.Trim() == Gem_N)
                    {
                        Gem_F = Gem_F + 10;
                        listView_Battle.Items[i].SubItems[2].Text = Gem_F.ToString();
                    }
                }
            }
            if (if_UPdata == 0)
            {
                temMsg.RIP = Publec_Class.ClientIP;//记录用户的IP地址
                temMsg.RPort = Publec_Class.ServerPort;//记录端口号
                temMsg.Fraction = Publec_Class.Fraction;//当前分数
                temMsg.sendKind = SendKind.SendCommand;
                temMsg.msgCommand = MsgCommand.UPDataFract;
                udpSocket1.Send(IPAddress.Parse(Publec_Class.ServerIP), 11000, new ClassSerializers().SerializeBinary(temMsg).ToArray());

                temMsg.RIP = GIP;//记录用户的IP地址
                temMsg.RPort = GPort;//记录端口号
                temMsg.Fraction = Gem_F;//当前分数
                temMsg.sendKind = SendKind.SendCommand;
                temMsg.msgCommand = MsgCommand.UPDataFract;
                udpSocket1.Send(IPAddress.Parse(Publec_Class.ServerIP), 11000, new ClassSerializers().SerializeBinary(temMsg).ToArray());
            }
            BwinCount++;
            CanAgins = false;
            Conqueror = true;
            CKind = 0;
            CanAgin = false;
            WhoFisrtDown = false;
            dropchild = true;
            this.pictureBox2.Image = null;
            this.pictureBox2.Enabled = true;
            this.pictureBox2.Image = Image.FromFile(ClientClass.ImaDir + "\\Image\\开始按钮.png");
        }
        //判断白棋是否赢
        public void Wwin()
        {
            MessageBox.Show("白子赢了!!请重新开始游戏！");

            ClassMsg temMsg = new ClassMsg();
            if (label_Genre.Text == "白棋")
            {
                for (int i = 0; i < listView_Battle.Items.Count; i++)
                {
                    if (listView_Battle.Items[i].SubItems[1].Text.Trim() == Publec_Class.UserName.Trim())
                    { 
                        Publec_Class.Fraction=Publec_Class.Fraction+10;
                        listView_Battle.Items[i].SubItems[2].Text = Publec_Class.Fraction.ToString();
                        label_F.Text = Publec_Class.Fraction.ToString();
                    }
                    if (listView_Battle.Items[i].SubItems[1].Text.Trim() == Gem_N)
                    {
                        Gem_F = Gem_F - 10;
                        listView_Battle.Items[i].SubItems[2].Text = Gem_F.ToString();
                    }
                }

            }
            else
            {
                for (int i = 0; i < listView_Battle.Items.Count; i++)
                {
                    if (listView_Battle.Items[i].SubItems[1].Text.Trim() == Publec_Class.UserName.Trim())
                    {
                        Publec_Class.Fraction = Publec_Class.Fraction - 10;
                        listView_Battle.Items[i].SubItems[2].Text = Publec_Class.Fraction.ToString();
                        label_F.Text = Publec_Class.Fraction.ToString();
                    }
                    if (listView_Battle.Items[i].SubItems[1].Text.Trim() == Gem_N)
                    {
                        Gem_F = Gem_F + 10;
                        listView_Battle.Items[i].SubItems[2].Text = Gem_F.ToString();
                    }
                }
            }

            if (if_UPdata == 0)
            {
                temMsg.RIP = Publec_Class.ClientIP;//记录用户的IP地址
                temMsg.RPort = Publec_Class.ServerPort;//记录端口号
                temMsg.Fraction = Publec_Class.Fraction;//当前分数
                temMsg.sendKind = SendKind.SendCommand;
                temMsg.msgCommand = MsgCommand.UPDataFract;
                udpSocket1.Send(IPAddress.Parse(Publec_Class.ServerIP), 11000, new ClassSerializers().SerializeBinary(temMsg).ToArray());

                temMsg.RIP = GIP;//记录用户的IP地址
                temMsg.RPort = GPort;//记录端口号
                temMsg.Fraction = Gem_F;//当前分数
                temMsg.sendKind = SendKind.SendCommand;
                temMsg.msgCommand = MsgCommand.UPDataFract;
                udpSocket1.Send(IPAddress.Parse(Publec_Class.ServerIP), 11000, new ClassSerializers().SerializeBinary(temMsg).ToArray());
            }
            WwinCount++;
            CanAgins = false;
            Conqueror = true;
            CKind = 1;
            CanAgin = false;
            WhoFisrtDown = false;
            dropchild = true;
            this.pictureBox2.Image = null;
            this.pictureBox2.Enabled = true;
            this.pictureBox2.Image = Image.FromFile(ClientClass.ImaDir + "\\Image\\开始按钮.png");
        }

        //启动服务
        public void StartServer()
        {

            listener = new Socket(AddressFamily.InterNetwork,
                SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint ep = new IPEndPoint(IPAddress.Any, 11003);
            try
            {
                listener.Bind(ep);
            }
            catch
            {
                if (listener != null)
                    listener.Close();
                if (mainThread != null)
                {
                    Thread.Sleep(30);                                //睡眠主线程
                    mainThread.Abort();         //关闭子线程
                }
                //listener.Bind(ep);
                ThreadStart ts = new ThreadStart(this.StartServer);
                mainThread = new Thread(ts);
                mainThread.Name = "GOB_Chess";
                LineName = mainThread.Name;
                mainThread.Start();
            }

            //mainThread.Name
            listener.Listen(100);

            Out = true;
            while (true)
            {
                //接收连接请求
                Socket server;
                try
                {
                    server = listener.Accept();
                }
                catch
                {
                    break;
                }

                //创建客户端对象
                ClientGobang.ChessClass.ClientObject client = new ClientGobang.ChessClass.ClientObject();
                client.ClientSocket = server;
                client.OnAddChess += new EventHandler<ClientGobang.ChessClass.AddChessEventArgs>(this.AddChess);
                client.OnAddMessage += new EventHandler<ClientGobang.ChessClass.AddMessageEventArgs>(this.AddMessage);
                client.OnAginMessage += new EventHandler<ClientGobang.ChessClass.AginMessageEventArgs>(this.AginMessage);
                client.OnFiDnMessage += new EventHandler<ClientGobang.ChessClass.FiDnMessageEventArgs>(this.FiDnMessage);
                client.receiveMessage();
            }
        }

        //添加对方发来的信息
        public void AddMessage(object sender, ClientGobang.ChessClass.AddMessageEventArgs e)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(
                    new EventHandler<ClientGobang.ChessClass.AddMessageEventArgs>(this.AddMessage),
                    new object[] { sender, e });
            }
            else
            {

            }

        }
        public void First()
        {
            if (WhoFisrtDown == true)
            {
                MessageBox.Show("游戏开始，请先下。");
            }
            else
            {
                MessageBox.Show("游戏开始，请后下。");
            }
        }
        public void FiDnMessage(object sender, ClientGobang.ChessClass.FiDnMessageEventArgs e)//谁先下棋的判断
        {
            if (this.InvokeRequired)
            {
                this.Invoke(
                    new EventHandler<ClientGobang.ChessClass.FiDnMessageEventArgs>(this.FiDnMessage),
                    new object[] { sender, e });
            }
            else
            {
                WhoFisrtDown = true;
            }
            //First();

        }

        //判断重新开始的条件
        public void Agin()
        {
            if (CanAgins == false && CanAgin == true)
            {
                for (int i = 0; i < panel_Check.Controls.Count; i++)
                {
                    if (panel_Check.Controls[i] is PictureBox)
                    {
                        panel_Check.Controls.RemoveAt(i);
                        i = -1;
                    }
                }

                for (int i = 0; i < 15; i++)
                    for (int j = 0; j < 15; j++)
                        note[i, j] = -1;
            }
        }
        //重新开始
        public void AginMessage(object sender, ClientGobang.ChessClass.AginMessageEventArgs e)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(
                    new EventHandler<ClientGobang.ChessClass.AginMessageEventArgs>(this.AginMessage),
                    new object[] { sender, e });
            }
            else
            {
                if (e.Agin == "OK?")
                {
                    CanAgins = false;
                    Conqueror = false;
                    CanAgin = true;
                    CanDown = true;
                    Agin_if = true;

                }
                Agin();
            }

        }

        public void Arithmetic(int n, int Arow, int Acolumn)//算法
        {
            int BCount = 1;
            CKind = -1;

            //横向查找
            bool Lbol = true;
            bool Rbol = true;
            int jlsf = 0;
            BCount = 1;
            for (int i = 1; i <= 5; i++)
            {
                if ((Acolumn + i) > 14)
                    Rbol = false;
                if ((Acolumn - i) < 0)
                    Lbol = false;
                if (Rbol == true)
                {
                    if (note[Arow, Acolumn + i] == n)
                        ++BCount;
                    else
                        Rbol = false;
                }
                if (Lbol == true)
                {
                    if (note[Arow, Acolumn - i] == n)
                        ++BCount;
                    else
                        Lbol = false;
                }
                if (BCount >= 5)
                {
                    if (n == 0)
                        Bwin();
                    if (n == 1)
                        Wwin();
                    jlsf = n;
                    break;
                }
            }

            //纵向查找
            bool Ubol = true;
            bool Dbol = true;
            BCount = 1;
            for (int i = 1; i <= 5; i++)
            {
                if ((Arow + i) > 14)
                    Dbol = false;
                if ((Arow - i) < 0)
                    Ubol = false;
                if (Dbol == true)
                {
                    if (note[Arow + i, Acolumn] == n)
                        ++BCount;
                    else
                        Dbol = false;
                }
                if (Ubol == true)
                {
                    if (note[Arow - i, Acolumn] == n)
                        ++BCount;
                    else
                        Ubol = false;
                }
                if (BCount >= 5)
                {
                    if (n == 0)
                        Bwin();
                    if (n == 1)
                        Wwin();
                    jlsf = n;
                    break;
                }
            }

            //正斜查找
            bool LUbol = true;
            bool RDbol = true;
            BCount = 1;
            for (int i = 1; i <= 5; i++)
            {
                if ((Arow - i) < 0 || (Acolumn - i < 0))
                    LUbol = false;
                if ((Arow + i) > 14 || (Acolumn + i > 14))
                    RDbol = false;
                if (LUbol == true)
                {
                    if (note[Arow - i, Acolumn - i] == n)
                        ++BCount;
                    else
                        LUbol = false;
                }
                if (RDbol == true)
                {
                    if (note[Arow + i, Acolumn + i] == n)
                        ++BCount;
                    else
                        RDbol = false;
                }
                if (BCount >= 5)
                {
                    if (n == 0)
                        Bwin();
                    if (n == 1)
                        Wwin();
                    jlsf = n;
                    break;
                }
            }
            //反斜查找
            bool RUbol = true;
            bool LDbol = true;
            BCount = 1;
            for (int i = 1; i <= 5; i++)
            {
                if ((Arow - i) < 0 || (Acolumn + i > 14))
                    RUbol = false;
                if ((Arow + i) > 14 || (Acolumn - i < 0))
                    LDbol = false;
                if (RUbol == true)
                {
                    if (note[Arow - i, Acolumn + i] == n)
                        ++BCount;
                    else
                        RUbol = false;
                }
                if (LDbol == true)
                {
                    if (note[Arow + i, Acolumn - i] == n)
                        ++BCount;
                    else
                        LDbol = false;
                }
                if (BCount >= 5)
                {
                    if (n == 0)
                        Bwin();
                    if (n == 1)
                        Wwin();
                    jlsf = n;
                    break;
                }
            }
        }

        //发送消息
        public void sendMessage(string message)
        {
            byte[] buffer = Encoding.Default.GetBytes(message + "\r\n\r\n");
            listener.Send(buffer);
        }

        private void Frm_Chessboard_Load(object sender, EventArgs e)
        {
            udpSocket1.LocalHost = Publec_Class.ClientIP;
            udpSocket1.LocalPort = 11001;
            udpSocket1.Active = true;
        }

        private void udpSocket1_DataArrival(byte[] Data, IPAddress Ip, int Port)
        {
            DataArrivaldelegate outdelegate = new DataArrivaldelegate(DataArrival);
            this.BeginInvoke(outdelegate, new object[] { Data, Ip, Port }); //设置托管
        }

        private delegate void DataArrivaldelegate(byte[] Data, System.Net.IPAddress Ip, int Port);


        private void DataArrival(byte[] Data, System.Net.IPAddress Ip, int Port) //当有数据到达后的处理进程
        {
            try
            {
                //string Tem_Gip = "";
                ClassMsg msg = (ClassMsg)new ClassSerializers().DeSerializeBinary(new MemoryStream(Data));
                switch (msg.msgCommand)
                {
                    case MsgCommand.BeginJoin://进入大厅获取在线用户列表
                        {

                            users = (ClassUsers)new ClassSerializers().DeSerializeBinary(new MemoryStream(msg.Data));//获取所有用户信息
                            ClassUserInfo UserItem = new ClassUserInfo();
                            UserItem = users[0];
                            GIP = UserItem.UserIP;//记录用户的IP地址
                            GPort = UserItem.UserPort;//记录端口号
                            Gem_N = UserItem.UserName;//记录用户名称
                            Gem_F = Convert.ToInt32(UserItem.Fraction);//当前分数
                            Gem_C = Convert.ToInt32(UserItem.Caput);//头像
                            Gem_S = Convert.ToInt32(UserItem.Sex);//性别

                            ThreadStart ts = new ThreadStart(this.StartServer);
                            mainThread = new Thread(ts);
                            mainThread.Name = "GOB_Chess";
                            LineName = mainThread.Name;
                            mainThread.Start();
                            StartListen = true;
                            ConnHandle = 1;

                            label_Left.Text = Gem_N;
                            frmClient.Data_List(listView_Battle, Gem_N, Gem_F.ToString(), Gem_C.ToString());

                            pictureBox_Left.Image = null;
                            if (Gem_S == 0)
                            {
                                pictureBox_Left.Image = Image.FromFile(ClientClass.ImaDir + "\\Image\\男人.png");
                            }
                            else
                            {
                                pictureBox_Left.Image = Image.FromFile(ClientClass.ImaDir + "\\Image\\女人.png");
                            }

                            pictureBox_Q_Left.Image = Image.FromFile(ClientClass.ImaDir + "\\Image\\黑棋.png");

                            this.pictureBox2.Image = null;
                            this.pictureBox2.Enabled = true;
                            this.pictureBox2.Image = Image.FromFile(ClientClass.ImaDir + "\\Image\\开始按钮.png");
                            break;
                        }
                    case MsgCommand.OddLittle:
                        {
                            richTextBox1.ReadOnly = true;//设为只读
                            richTextBox1.ForeColor = Color.SlateGray;//设置字体颜色
                            richTextBox1.AppendText(msg.UserName);//添加发送信息的用户名
                            richTextBox1.AppendText("\r\n");//换行
                            richTextBox1.AppendText(msg.MsgText);//添加发送的信息
                            richTextBox1.AppendText("\r\n");//换行
                            richTextBox1.ScrollToCaret();//将信息添加到控件
                            break;
                        }
                    case MsgCommand.GetGameF:
                        {
                            Gem_N = msg.Fraction.ToString();
                            for (int i = 0; i < listView_Battle.Items.Count; i++)
                            {
                                if (listView_Battle.Items[i].SubItems[1].Text.Trim() == Gem_N.Trim())
                                {
                                    listView_Battle.Items[i].SubItems[2].Text = Gem_N;
                                }
                            }
                            break;
                        }
                    case MsgCommand.ExitJoin:
                        {
                            if (label_Left.Text.Trim() == Publec_Class.UserName)
                            {
                                pictureBox_Q_Right.Image = null;
                                pictureBox_Right.Image = null;
                                label_Right.Text = "";
                            }
                            else
                            {
                                pictureBox_Q_Left.Image = null;
                                pictureBox_Left.Image = null;
                                label_Left.Text = "";
                            }
                            GIP = "";
                            int ListCount = listView_Battle.Items.Count;
                            for (int i = 0; i < ListCount; i++)
                            {
                                if (listView_Battle.Items[i].SubItems[1].Text.Trim() == Gem_N.Trim())
                                {
                                    listView_Battle.Items[i].Remove();
                                    i = i - 1;
                                    ListCount = ListCount - 1;
                                }
                            }
                            CanAgins = false;
                            CanAgin = true;
                            Agin();

                            this.pictureBox2.Image = null;
                            this.pictureBox2.Image = Image.FromFile(ClientClass.ImaDir + "\\Image\\开始按钮灰.png");
                            dropchild = true;

                            if (listener != null)
                                listener.Close();
                            if (mainThread != null)
                            {
                                Thread.Sleep(30);       //睡眠主线程
                                mainThread.Abort();         //关闭子线程
                            }

                            break;
                        }
                }
            }
            catch { }
        }

        private void Frm_Chessboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (listener != null)
                listener.Close();
            if (mainThread != null)
            {
                Thread.Sleep(30);       //睡眠主线程
                mainThread.Abort();         //关闭子线程
            }

            if (udpSocket1.Active == true)
            {
                udpSocket1.Active = false;
                udpSocket1.LocalHost = "127.0.0.1";
                udpSocket1.LocalPort = 11000;
            }
        }

        private void pictureBox_Min_Click_1(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Minimized)
                this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox_Min_MouseEnter(object sender, EventArgs e)
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

        private void pictureBox_Min_MouseLeave(object sender, EventArgs e)
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
        public ClassMsg OddtemMsg = new ClassMsg();
        public string OddText = "";
        private void pictureBox_Chart_Click(object sender, EventArgs e)
        {

            OddtemMsg.msgCommand = MsgCommand.OddLittle;
            OddtemMsg.UserName = Publec_Class.UserName;
            OddtemMsg.MsgText = comboBox_Hair.Text;
            if (GIP == "")
                return;
            udpSocket1.Send(IPAddress.Parse(GIP), 11001, new ClassSerializers().SerializeBinary(OddtemMsg).ToArray());

            richTextBox1.ReadOnly = true;//设为只读
            richTextBox1.ForeColor = Color.SlateGray;//设置字体颜色
            richTextBox1.AppendText(Publec_Class.UserName);//添加发送信息的用户名
            richTextBox1.AppendText("\r\n");//换行
            richTextBox1.AppendText(comboBox_Hair.Text);//添加发送的信息
            richTextBox1.AppendText("\r\n");//换行
            richTextBox1.ScrollToCaret();//将信息添加到控件

            comboBox_Hair.Text = "";
        }

        private void comboBox_Hair_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                pictureBox_Chart_Click(sender, e);
            }
        }

    }
}