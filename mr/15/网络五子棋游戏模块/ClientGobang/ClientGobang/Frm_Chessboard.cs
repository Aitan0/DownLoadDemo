using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;//�����������ܵ������ռ�
using System.Collections;//�������������ռ�
using System.Runtime.InteropServices;//������ַ�����������ռ�
using System.Net.Sockets;//Sockets�����ռ�
using System.Threading;//�߳�������
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

        public static int ConnHandle = 0;//�����ӡ�׼������ʼ��ť�Ĳ�����ʶ���м�¼
        public static float Mouse_X = 0;//��¼����X����
        public static float Mouse_Y = 0;//��¼����Y����
        public static int[,] note = new int[15, 15];//��¼���ӵİڷ�λ��
        public static bool Conqueror = false;//��¼��ǰ�Ƿ��Ѿ���ʤ��
        public static int CKind = -1;//��¼ȡʤ������
        public static bool dropchild = true;//��ǰ��˭����
        public static bool StartListen = false;//�Ƿ������˼���
        public static int jlsf = -1;
        public static string LineName = "";//�߳���
        public static bool Agin_if = false;//�ж��Ƿ����¿�ʼ
        public static int if_UPdata = 0;//�Ƿ���ķ���
        public static bool childSgin = true;//��������
        public static bool ChildSgin = true;//�Է���������

        public int BBow = 0;
        int BwinCount = 0;
        int WwinCount = 0;
        bool Out = false;
        public bool CanAgin, CanAgins, CanDown, WhoFisrtDown;
        private Socket listener;
        private Thread mainThread;
        ClassUsers users;
        ClientClass frmClient = new ClientClass();

        public static string GIP = ClientClass.GameIP;//IP��ַ
        public static string GPort = "11003";//�˿ں�
        public static string Gem_N = "";//����
        public static int Gem_F = 0;//����
        public static int Gem_C = 0;//ͷ��
        public static int Gem_S = 0;//�Ա�

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
                MessageBox.Show("��ȡ�Է�������ʱ����");
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
                pictureBox_C.Image = Image.FromFile(ClientClass.ImaDir + "\\Image\\����.png");
            }
            else
            {
                pictureBox_C.Image = Image.FromFile(ClientClass.ImaDir + "\\Image\\Ů��.png");
            }
            
            GIP = ClientClass.GameIP.Trim();//IP��ַ
            if (GIP == "")
            {
                pictureBox2.Enabled = false;
                //label_Genre.Text = GIP;

                pictureBox_Left.Image = null;
                pictureBox_Right.Image = null;
                if (Publec_Class.UserSex == 0)
                {
                    pictureBox_Right.Image = Image.FromFile(ClientClass.ImaDir + "\\Image\\����.png");
                }
                else
                {
                    pictureBox_Right.Image = Image.FromFile(ClientClass.ImaDir + "\\Image\\Ů��.png");
                }
                label_Right.Text = Publec_Class.UserName;

                pictureBox_Q_Right.Image = null;
                pictureBox_Q_Right.Image = Image.FromFile(ClientClass.ImaDir + "\\Image\\����.png");

                this.pictureBox2.Image = null;
                this.pictureBox2.Image = Image.FromFile(ClientClass.ImaDir + "\\Image\\��ʼ��ť��.png");
                this.pictureBox2.Enabled = false;
            }
            else
            {
                
                GetGameInfo(ClientClass.GameIP);
                ClassMsg temMsg = new ClassMsg();
                ClassUsers Users = new ClassUsers();
                ClassUserInfo UserItem = new ClassUserInfo();//����������ClassUserInfo��

                pictureBox_Left.Image = null;
                if (Publec_Class.UserSex == 0)
                {
                    pictureBox_Left.Image = Image.FromFile(ClientClass.ImaDir + "\\Image\\����.png");
                }
                else
                {
                    pictureBox_Left.Image = Image.FromFile(ClientClass.ImaDir + "\\Image\\Ů��.png");
                }
                pictureBox_Q_Left.Image = null;
                pictureBox_Q_Left.Image = Image.FromFile(ClientClass.ImaDir + "\\Image\\����.png");
                label_Left.Text = Publec_Class.UserName;


                pictureBox_Right.Image = null;
                if (Gem_S == 0)
                {
                    pictureBox_Right.Image = Image.FromFile(ClientClass.ImaDir + "\\Image\\����.png");
                }
                else
                {
                    pictureBox_Right.Image = Image.FromFile(ClientClass.ImaDir + "\\Image\\Ů��.png");
                }
                label_Right.Text = Gem_N;

                pictureBox_Q_Right.Image = null;
                pictureBox_Q_Right.Image = Image.FromFile(ClientClass.ImaDir + "\\Image\\����.png");

                frmClient.Data_List(listView_Battle, Gem_N, Gem_F.ToString(), Gem_C.ToString());

                temMsg.sendKind = SendKind.SendCommand;
                temMsg.msgCommand = MsgCommand.GetGameF;
                temMsg.RIP = GIP;

                //ԭ����11000
                udpSocket1.Send(IPAddress.Parse(Publec_Class.ServerIP), 11001, new ClassSerializers().SerializeBinary(temMsg).ToArray());

                this.pictureBox2.Image = null;
                this.pictureBox2.Enabled = true;
                this.pictureBox2.Image = Image.FromFile(ClientClass.ImaDir + "\\Image\\��ʼ��ť.png");

                UserItem.UserIP = Publec_Class.ClientIP;//��¼�û���IP��ַ
                UserItem.UserPort = Publec_Class.ServerPort;//��¼�˿ں�
                UserItem.UserName = Publec_Class.UserName;//��¼�û�����
                UserItem.Fraction = Publec_Class.Fraction.ToString();//��ǰ����
                UserItem.Caput = Publec_Class.CaputID.ToString();//ͷ��
                UserItem.Sex = Publec_Class.UserSex.ToString();//�Ա�
                Users.add(UserItem);//�����û���Ϣ��ӵ��û��б���

                pictureBox2.Enabled = true;
                ThreadStart ts = new ThreadStart(this.StartServer);
                mainThread = new Thread(ts);
                mainThread.Name = "GOB_Chess";
                LineName = mainThread.Name;
                mainThread.Start();

                temMsg.Data = new ClassSerializers().SerializeBinary(Users).ToArray();//���û��б�д�뵽����������
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
            this.pictureBox2.Image = Image.FromFile(ClientClass.ImaDir + "\\Image\\��ʼ��ť��.png");
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
                            MessageBox.Show("���ӷ�����ʧ��");
                            this.pictureBox2.Image = null;
                            this.pictureBox2.Enabled = true;
                            this.pictureBox2.Image = Image.FromFile(ClientClass.ImaDir + "\\Image\\��ʼ��ť.png");
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
                MessageBox.Show("�Ƿ�رմ���");
                
            }
            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        //�������
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

                        label_Genre.Text = "����";
                        label_Genre.Tag = 0;
                        pictureBoxTem.Image = imageList1.Images[0];
                        bw = 0;
                        note[Row, Column] = 0;
                        cc.SendMessage("Down#" + Row.ToString() + "*" + Column.ToString() + "|" + "0" + "@" + BBow.ToString());
                    }
                    else
                    {

                        label_Genre.Text = "����";
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
                                pictureBox_Q_Left.Image = Image.FromFile(ClientClass.ImaDir + "\\Image\\����.png");
                            }
                            else
                            {
                                pictureBox_Q_Right.Image = null;
                                pictureBox_Q_Right.Image = Image.FromFile(ClientClass.ImaDir + "\\Image\\����.png");
                            }
                        }
                        else
                        {
                            if (label_Left.Text.Trim() == Publec_Class.UserName)
                            {
                                pictureBox_Q_Left.Image = null;
                                pictureBox_Q_Left.Image = Image.FromFile(ClientClass.ImaDir + "\\Image\\����.png");
                            }
                            else
                            {
                                pictureBox_Q_Right.Image = null;
                                pictureBox_Q_Right.Image = Image.FromFile(ClientClass.ImaDir + "\\Image\\����.png");
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
                    MessageBox.Show("�Է���û�����ӣ�");
                    dropchild = true;
                    return;
                }
            }
            else
            {
                MessageBox.Show("�������û�п�ʼ�޷����壡");
                dropchild = true;
                return;
            }
            dropchild = false;
        }

        //��ӶԷ��µ���
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
                            pictureBox_Q_Left.Image = Image.FromFile(ClientClass.ImaDir + "\\Image\\����.png");
                        }
                        else
                        {
                            pictureBox_Q_Right.Image = null;
                            pictureBox_Q_Right.Image = Image.FromFile(ClientClass.ImaDir + "\\Image\\����.png");
                        }
                    }
                    else
                    {
                        if (label_Left.Text.Trim() == Publec_Class.UserName)
                        {
                            pictureBox_Q_Left.Image = null;
                            pictureBox_Q_Left.Image = Image.FromFile(ClientClass.ImaDir + "\\Image\\����.png");
                        }
                        else
                        {
                            pictureBox_Q_Right.Image = null;
                            pictureBox_Q_Right.Image = Image.FromFile(ClientClass.ImaDir + "\\Image\\����.png");
                        }
                    }
                    ChildSgin = false;
                }
            }
            WhoFisrtDown = true;
            dropchild = true;
        }
        //�жϺ����Ƿ�Ӯ
        public void Bwin()
        {
            MessageBox.Show("����Ӯ��!!�����¿�ʼ��Ϸ��");

            ClassMsg temMsg = new ClassMsg();
            if (label_Genre.Text == "����")
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
                temMsg.RIP = Publec_Class.ClientIP;//��¼�û���IP��ַ
                temMsg.RPort = Publec_Class.ServerPort;//��¼�˿ں�
                temMsg.Fraction = Publec_Class.Fraction;//��ǰ����
                temMsg.sendKind = SendKind.SendCommand;
                temMsg.msgCommand = MsgCommand.UPDataFract;
                udpSocket1.Send(IPAddress.Parse(Publec_Class.ServerIP), 11000, new ClassSerializers().SerializeBinary(temMsg).ToArray());

                temMsg.RIP = GIP;//��¼�û���IP��ַ
                temMsg.RPort = GPort;//��¼�˿ں�
                temMsg.Fraction = Gem_F;//��ǰ����
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
            this.pictureBox2.Image = Image.FromFile(ClientClass.ImaDir + "\\Image\\��ʼ��ť.png");
        }
        //�жϰ����Ƿ�Ӯ
        public void Wwin()
        {
            MessageBox.Show("����Ӯ��!!�����¿�ʼ��Ϸ��");

            ClassMsg temMsg = new ClassMsg();
            if (label_Genre.Text == "����")
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
                temMsg.RIP = Publec_Class.ClientIP;//��¼�û���IP��ַ
                temMsg.RPort = Publec_Class.ServerPort;//��¼�˿ں�
                temMsg.Fraction = Publec_Class.Fraction;//��ǰ����
                temMsg.sendKind = SendKind.SendCommand;
                temMsg.msgCommand = MsgCommand.UPDataFract;
                udpSocket1.Send(IPAddress.Parse(Publec_Class.ServerIP), 11000, new ClassSerializers().SerializeBinary(temMsg).ToArray());

                temMsg.RIP = GIP;//��¼�û���IP��ַ
                temMsg.RPort = GPort;//��¼�˿ں�
                temMsg.Fraction = Gem_F;//��ǰ����
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
            this.pictureBox2.Image = Image.FromFile(ClientClass.ImaDir + "\\Image\\��ʼ��ť.png");
        }

        //��������
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
                    Thread.Sleep(30);                                //˯�����߳�
                    mainThread.Abort();         //�ر����߳�
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
                //������������
                Socket server;
                try
                {
                    server = listener.Accept();
                }
                catch
                {
                    break;
                }

                //�����ͻ��˶���
                ClientGobang.ChessClass.ClientObject client = new ClientGobang.ChessClass.ClientObject();
                client.ClientSocket = server;
                client.OnAddChess += new EventHandler<ClientGobang.ChessClass.AddChessEventArgs>(this.AddChess);
                client.OnAddMessage += new EventHandler<ClientGobang.ChessClass.AddMessageEventArgs>(this.AddMessage);
                client.OnAginMessage += new EventHandler<ClientGobang.ChessClass.AginMessageEventArgs>(this.AginMessage);
                client.OnFiDnMessage += new EventHandler<ClientGobang.ChessClass.FiDnMessageEventArgs>(this.FiDnMessage);
                client.receiveMessage();
            }
        }

        //��ӶԷ���������Ϣ
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
                MessageBox.Show("��Ϸ��ʼ�������¡�");
            }
            else
            {
                MessageBox.Show("��Ϸ��ʼ������¡�");
            }
        }
        public void FiDnMessage(object sender, ClientGobang.ChessClass.FiDnMessageEventArgs e)//˭��������ж�
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

        //�ж����¿�ʼ������
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
        //���¿�ʼ
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

        public void Arithmetic(int n, int Arow, int Acolumn)//�㷨
        {
            int BCount = 1;
            CKind = -1;

            //�������
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

            //�������
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

            //��б����
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
            //��б����
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

        //������Ϣ
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
            this.BeginInvoke(outdelegate, new object[] { Data, Ip, Port }); //�����й�
        }

        private delegate void DataArrivaldelegate(byte[] Data, System.Net.IPAddress Ip, int Port);


        private void DataArrival(byte[] Data, System.Net.IPAddress Ip, int Port) //�������ݵ����Ĵ������
        {
            try
            {
                //string Tem_Gip = "";
                ClassMsg msg = (ClassMsg)new ClassSerializers().DeSerializeBinary(new MemoryStream(Data));
                switch (msg.msgCommand)
                {
                    case MsgCommand.BeginJoin://���������ȡ�����û��б�
                        {

                            users = (ClassUsers)new ClassSerializers().DeSerializeBinary(new MemoryStream(msg.Data));//��ȡ�����û���Ϣ
                            ClassUserInfo UserItem = new ClassUserInfo();
                            UserItem = users[0];
                            GIP = UserItem.UserIP;//��¼�û���IP��ַ
                            GPort = UserItem.UserPort;//��¼�˿ں�
                            Gem_N = UserItem.UserName;//��¼�û�����
                            Gem_F = Convert.ToInt32(UserItem.Fraction);//��ǰ����
                            Gem_C = Convert.ToInt32(UserItem.Caput);//ͷ��
                            Gem_S = Convert.ToInt32(UserItem.Sex);//�Ա�

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
                                pictureBox_Left.Image = Image.FromFile(ClientClass.ImaDir + "\\Image\\����.png");
                            }
                            else
                            {
                                pictureBox_Left.Image = Image.FromFile(ClientClass.ImaDir + "\\Image\\Ů��.png");
                            }

                            pictureBox_Q_Left.Image = Image.FromFile(ClientClass.ImaDir + "\\Image\\����.png");

                            this.pictureBox2.Image = null;
                            this.pictureBox2.Enabled = true;
                            this.pictureBox2.Image = Image.FromFile(ClientClass.ImaDir + "\\Image\\��ʼ��ť.png");
                            break;
                        }
                    case MsgCommand.OddLittle:
                        {
                            richTextBox1.ReadOnly = true;//��Ϊֻ��
                            richTextBox1.ForeColor = Color.SlateGray;//����������ɫ
                            richTextBox1.AppendText(msg.UserName);//��ӷ�����Ϣ���û���
                            richTextBox1.AppendText("\r\n");//����
                            richTextBox1.AppendText(msg.MsgText);//��ӷ��͵���Ϣ
                            richTextBox1.AppendText("\r\n");//����
                            richTextBox1.ScrollToCaret();//����Ϣ��ӵ��ؼ�
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
                            this.pictureBox2.Image = Image.FromFile(ClientClass.ImaDir + "\\Image\\��ʼ��ť��.png");
                            dropchild = true;

                            if (listener != null)
                                listener.Close();
                            if (mainThread != null)
                            {
                                Thread.Sleep(30);       //˯�����߳�
                                mainThread.Abort();         //�ر����߳�
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
                Thread.Sleep(30);       //˯�����߳�
                mainThread.Abort();         //�ر����߳�
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
                        ((PictureBox)sender).Image = Image.FromFile(ClientClass.ImaDir + "\\Image\\��С����ɫ.jpg");
                        break;
                    }
                case 2:
                    {
                        ((PictureBox)sender).Image = null;
                        ((PictureBox)sender).Image = Image.FromFile(ClientClass.ImaDir + "\\Image\\��󻯱�ɫ.jpg");
                        break;
                    }
                case 3:
                    {
                        ((PictureBox)sender).Image = null;
                        ((PictureBox)sender).Image = Image.FromFile(ClientClass.ImaDir + "\\Image\\�رձ�ɫ.jpg");
                        break;
                    }
                case 4:
                    {
                        ((PictureBox)sender).Image = null;
                        ((PictureBox)sender).Image = Image.FromFile(ClientClass.ImaDir + "\\Image\\���Ͱ�ť��ɫ.png");
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
                        ((PictureBox)sender).Image = Image.FromFile(ClientClass.ImaDir + "\\Image\\��С����ť.jpg");
                        break;
                    }
                case 2:
                    {
                        ((PictureBox)sender).Image = null;
                        ((PictureBox)sender).Image = Image.FromFile(ClientClass.ImaDir + "\\Image\\��󻯰�ť.jpg");
                        break;
                    }
                case 3:
                    {
                        ((PictureBox)sender).Image = null;
                        ((PictureBox)sender).Image = Image.FromFile(ClientClass.ImaDir + "\\Image\\�رհ�ť.jpg");
                        break;
                    }
                case 4:
                    {
                        ((PictureBox)sender).Image = null;
                        ((PictureBox)sender).Image = Image.FromFile(ClientClass.ImaDir + "\\Image\\���Ͱ�ť.png");
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

            richTextBox1.ReadOnly = true;//��Ϊֻ��
            richTextBox1.ForeColor = Color.SlateGray;//����������ɫ
            richTextBox1.AppendText(Publec_Class.UserName);//��ӷ�����Ϣ���û���
            richTextBox1.AppendText("\r\n");//����
            richTextBox1.AppendText(comboBox_Hair.Text);//��ӷ��͵���Ϣ
            richTextBox1.AppendText("\r\n");//����
            richTextBox1.ScrollToCaret();//����Ϣ��ӵ��ؼ�

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