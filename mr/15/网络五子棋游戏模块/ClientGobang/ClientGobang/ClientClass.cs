using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;//��������ռ�
using GobangClass;
using System.IO;//��ӵ������ռ�:Directory


namespace ClientGobang
{
    class ClientClass
    {
        #region  ����ȫ�ֱ���
        Publec_Class PublecClass = new Publec_Class();
        public static string ImaDir = "";//�洢ͼƬ��·��
        public Point CPoint;  //��������ռ�using System.Drawing;
        public static string GameIP = "";//�Է���ҵ�IP
        public static string GamePort = "";//�Է���ҵĶ˿ں�
        public static string GameName = "";//�Է���ҵ�����
        public static string GameFraction = "";//�Է���ҵķ���
        public static string GameCaput = "";//�Է���ҵ�ͷ��
        public static string GameSex = "";//�Է���ҵ��Ա�
        public static bool BeginGame = false;
        #endregion

        #region  ��ȡͼƬ·��
        /// <summary>
        /// ��ȡͼƬ·��
        /// </summary>
        public void ImageDir()
        {
            string Tem_Imadir = "";
            Tem_Imadir = UpAndDown_Dir(System.AppDomain.CurrentDomain.BaseDirectory);
            Tem_Imadir = UpAndDown_Dir(Tem_Imadir);
            Tem_Imadir = UpAndDown_Dir(Tem_Imadir);
            ImaDir = Tem_Imadir;
        }
        #endregion

        #region  ����Panel�ؼ�
        /// <summary>
        /// ����Panel�ؼ�
        /// </summary>
        public void HidePanel(Panel PanelPlock)
        {
            if (PanelPlock.Visible)
                PanelPlock.Visible = false;
            else
                PanelPlock.Visible = true;
        }
        #endregion

        #region  �ж϶˿ں��Ƿ���ȷ
        /// <summary>
        /// �ж϶˿ں��Ƿ���ȷ
        /// </summary>
        public void TextValue(TextBox Textb)
        {
            if (Textb.Text == "11000")
                Textb.Text = "1100";
        }
        #endregion

        #region  ������һ��Ŀ¼
        /// <summary>
        /// ������һ��Ŀ¼
        /// </summary>
        /// <param dir="string">Ŀ¼</param>
        /// <returns>����String����</returns>
        public string UpAndDown_Dir(string dir)
        {
            string Change_dir = "";
            Change_dir = Directory.GetParent(dir).FullName;
            return Change_dir;
        }
        #endregion

        #region  �����������������
        /// <summary>
        /// �����������������
        /// </summary>
        public void SetLabelModule(FlowLayoutPanel FLPanel, ImageList ImaList)
        {
            string d_1 = "";
            int Ptag = 0;
            //string Imadir = "";
            foreach (Control FP in FLPanel.Controls)
            {
                foreach (Control P in ((Panel)FP).Controls)
                {
                    if (P is Label)
                    {
                        P.Font = new Font("����", 9);
                        P.ForeColor = Color.Black;
                        P.BackColor = Color.Transparent;
                        d_1 = P.Name;
                        if (d_1.LastIndexOf("_1") >= 0 || d_1.LastIndexOf("_2") >= 0)
                        {
                            P.Text = "";
                        }
                    }
                    if (P is PictureBox)
                    {
                        PictureBox pb = (PictureBox)P;
                        Ptag = Convert.ToInt32(pb.Tag.ToString());

                        if (Ptag == 1 || Ptag == 2)
                        {
                            pb.Enabled = true;
                            pb.Image = ImaList.Images[ImaList.Images.Count - 1];

                        }
                    }
                }
            }
        }
        #endregion

        #region  �Ե�ǰ�����в���
        /// <summary>
        /// �Ե�ǰ�����в���
        /// </summary>
        public ClassMsg DeskHandle(PictureBox PictBox, ImageList ImageLs, int n)
        {
            ClassUserInfo CUInfo = new ClassUserInfo();
            Publec_Class.UserSeat = PictBox.Name;
            ClassMsg msg = new ClassMsg();
            PictBox.Image = null;
            int nTag = Convert.ToInt32(PictBox.Tag.ToString());
            string Cauda = "";
            string d_1 = "";
            Publec_Class.DeskM = ((Panel)PictBox.Parent).Name;
            Publec_Class.SeatM = PictBox.Name;
            if (n == 1)
            {
                PictBox.Image = ImageLs.Images[Publec_Class.CaputID];
                PictBox.Enabled = false;
            }
            if (n == 0)
            {
                PictBox.Image = ImageLs.Images[ImageLs.Images.Count - 1];
                PictBox.Enabled = true;
            }
            switch (nTag)
            {
                case 1:
                    {
                        Cauda = "_1";
                        break;
                    }
                case 2:
                    {
                        Cauda = "_2";
                        break;
                    }
            }

            foreach (Control P in (PictBox.Parent).Controls)
            {
                if (P is Label)
                {
                    d_1 = P.Name;
                    if (d_1.LastIndexOf(Cauda) >= 0)
                    {
                        Publec_Class.UserCaption = d_1;
                        if (n == 1)
                        {
                            P.Text = Publec_Class.UserName;
                            if (nTag == 2)
                            {
                                P.Left = 134 - P.Width;
                            }
                        }
                        if (n == 0)
                        {
                            P.Text = "";
                        }
                        break;
                    }
                }
            }
            msg.RID = Publec_Class.ClientIP;//��ǰ�������IP
            msg.UserName = Publec_Class.UserName;//��ǰ�û�������
            msg.Fraction = Convert.ToInt32(Publec_Class.Fraction);//��ǰ�û��ķ���
            msg.AreaMark = Publec_Class.TAreaM.ToString();//����
            msg.RoomMark = Publec_Class.TRoomM.ToString();//�����
            msg.DeskMark = Publec_Class.DeskM;//����
            msg.SeatMark = Publec_Class.SeatM;//��λ��
            msg.UserCaption = Publec_Class.UserCaption;//�û�����
            msg.CPhoto = Convert.ToInt32(Publec_Class.CaputID);//ͷ��
            msg.Sex = Publec_Class.UserSex;

            msg.Data = new ClassSerializers().SerializeBinary(CUInfo).ToArray();//���û��б�д�뵽����������
            msg.sendKind = SendKind.SendCommand;
            msg.msgCommand = MsgCommand.BeginToGame;
            return msg;
        }
        #endregion

        #region  ���ô����ϵĿؼ��ƶ�����
        /// <summary>
        /// ���ÿؼ��ƶ�����
        /// </summary>
        /// <param Frm="Form">����</param>
        /// <param e="MouseEventArgs">�ؼ����ƶ��¼�</param>
        public void FrmMove(Form Frm, MouseEventArgs e)  //Form��MouseEventArgs��������ռ�using System.Windows.Forms;
        {
            if (e.Button == MouseButtons.Left)
            {
                Point myPosittion = Control.MousePosition;//��ȡ��ǰ������Ļ����
                myPosittion.Offset(CPoint.X, CPoint.Y);//���ص�ǰ����λ��
                Frm.DesktopLocation = myPosittion;//���õ�ǰ��������Ļ�ϵ�λ��
            }
        }
        #endregion

        #region  �������û��б�������û���Ϣ
        /// <summary>
        /// ��ListView�ؼ����и�ʽ��
        /// </summary>
        /// <param LV="ListView">ListView�ؼ�</param>
        public void Format_ListV(ListView LV, ImageList ImageL)
        {
            LV.Items.Clear();//���������ļ���
            LV.Columns.Clear();//��������еļ���
            LV.SmallImageList = ImageL;
            LV.GridLines = true;//�ڸ�����֮���γ�������
            LV.View = View.Details;//��ʾ������
            LV.FullRowSelect = true;//�ڵ���ĳ��ʱ���������ѡ��
            LV.HeaderStyle = ColumnHeaderStyle.None;//�����б���

            LV.Columns.Add(" ", 40, HorizontalAlignment.Right);//����ͷ��
            LV.Columns.Add("�û���", 110, HorizontalAlignment.Center);//����ͷ��
            LV.Columns.Add("����", 70, HorizontalAlignment.Left);//����ͷ��
        }


        /// <summary>
        /// �������û��б�������û���Ϣ
        /// </summary>
        /// <param LV="ListView">ListView�ؼ�</param>
        /// <param UName="string">�û���</param>
        /// <param F="string">����</param>
        /// <param nC="string">ͷ��</param>
        public void Data_List(ListView LV, string UName, string F, string nC)  //Form��MouseEventArgs��������ռ�using System.Windows.Forms;
        {
            ListViewItem item = new ListViewItem("", Convert.ToInt32(nC));
            item.SubItems.Add(UName);
            item.SubItems.Add(F);
            LV.Items.Add(item);
        }
        #endregion

        #region  ���б����Ƴ��û���Ϣ
        /// <summary>
        /// ���б����Ƴ��û���Ϣ
        /// </summary>
        /// <param LV="ListView">ListView�ؼ�</param>
        /// <param UName="string">�Ƴ����û�����</param>
        public void ReMove_List(ListView LV, string UName)
        {

            for (int i = 0; i < LV.Items.Count; i++)
            {
                if (LV.Items[i].SubItems[1].Text == UName)
                {
                    LV.Items[i].Remove();
                    break;
                }
            }
        }
        #endregion

        #region  ���б����޸��û���Ϣ
        /// <summary>
        /// ���б����޸��û���Ϣ
        /// </summary>
        /// <param LV="ListView">ListView�ؼ�</param>
        /// <param DS="DataSet">���ز��ҵ����ݼ�</param>
        public void Amend_List(ListView LV, string UName, string F)
        {

            for (int i = 0; i < LV.Items.Count; i++)
            {
                if (LV.Items[i].SubItems[1].Text == UName)
                {
                    LV.Items[i].SubItems[2].Text = F;
                    break;
                }
            }
        }
        #endregion

        #region  ������������û�ͼ�꼰�����Ϣ
        /// <summary>
        /// ������������û�ͼ�꼰�����Ϣ
        /// </summary>
        /// <param FLPanel="FlowLayoutPanel">FLPanel�ؼ�</param>
        /// <param userItem="ClassUserInfo">ClassUserInfo�ࣨ���û���Ϣ��</param>
        /// <param ImaList="ImageList">ImageList���</param>
        public void UserAdd_List(FlowLayoutPanel FLPanel, ClassUserInfo userItem, ImageList ImaList)
        {
            foreach (Control FP in FLPanel.Controls)
            {
                if (FP is Panel && FP.Name == userItem.DeskMark)
                {
                    foreach (Control P in ((Panel)FP).Controls)
                    {
                        if (P is PictureBox && P.Name == userItem.SeatMart)
                        {
                            ((PictureBox)P).Image = ImaList.Images[Convert.ToInt32(userItem.Caput)];
                            
                            ((PictureBox)P).AccessibleName = userItem.UserIP+"|"+userItem.UserName+"|"+userItem.Fraction+"|"+userItem.Caput+"|"+userItem.Sex;
                            ((PictureBox)P).Enabled = false;
                        }
                        if (P is Label && P.Name == userItem.UserCaption)
                        {
                            ((Label)P).Text = userItem.UserName;
                        }
                    }
                }
            }
        }
        #endregion

        #region  ��ָ���������Ϸ�û�
        /// <summary>
        /// ����������Ϸ�û�
        /// </summary>
        /// <param FLPanel="FlowLayoutPanel">FlowLayoutPanel�ؼ�</param>
        /// <param CUInfo="ClassMsg">ClassUserInfo�ࣨ���û���Ϣ��</param>
        /// <param ImaList="ImageList">ImageList���</param>
        /// <param IP="string">IP��ַ</param>
        /// <param MsgSign="MsgCommand">���պ���Ϣ����</param>
        public void AddDeskMsg(FlowLayoutPanel FLPanel, ClassMsg CUInfo, ImageList ImaList, string IP, MsgCommand MsgSign)
        {
         
            if (Convert.ToInt32(CUInfo.AreaMark) == Publec_Class.TAreaM || Convert.ToInt32(CUInfo.RoomMark) == Publec_Class.TRoomM)
            {

                foreach (Control FP in FLPanel.Controls)
                {
                    if (FP is Panel && FP.Name == CUInfo.DeskMark)
                    {
                        foreach (Control P in ((Panel)FP).Controls)
                        {
                            if (P is PictureBox && P.Name == CUInfo.SeatMark)
                            {
                                if (MsgSign == MsgCommand.BeginToGameH)
                                {
                                    ((PictureBox)P).Image = ImaList.Images[Convert.ToInt32(CUInfo.CPhoto)];
                                    ((PictureBox)P).AccessibleName = IP + "|" + CUInfo.UserName + "|" + CUInfo.Fraction.ToString() + "|" + CUInfo.CPhoto.ToString() + "|" + CUInfo.Sex.ToString();
                                    ((PictureBox)P).Enabled = false;
                                }
                                if (MsgSign == MsgCommand.EndToGameH)
                                {
                                    ((PictureBox)P).Image = ImaList.Images[ImaList.Images.Count - 1];
                                    ((PictureBox)P).AccessibleName = "";
                                    ((PictureBox)P).Enabled = true;
                                }
                            }
                            if (P is Label && P.Name == CUInfo.UserCaption)
                            {
                                if (MsgSign == MsgCommand.BeginToGameH)
                                    ((Label)P).Text = CUInfo.UserName;
                                if (MsgSign == MsgCommand.EndToGameH)
                                    ((Label)P).Text = "";
                            }
                        }
                    }
                }
            }
        }
        #endregion

        #region  ������ĵ���Ϣ
        /// <summary>
        /// ������ĵ���Ϣ
        /// </summary>
        /// <param RTX="RichTextBox">RichTextBox�ؼ�</param>
        /// <param CUInfo="ClassMsg">���͵���Ϣ</param>
        /// <param MsgSign="MsgCommand">��Ϣ����</param>
        public void AddMsgText(RichTextBox RTX, ClassMsg CUInfo, MsgCommand MsgSign)
        {
            RTX.ReadOnly = true;//��Ϊֻ��
            RTX.ForeColor = Color.SlateGray;//����������ɫ
            RTX.AppendText(CUInfo.UserName);//��ӷ�����Ϣ���û���
            RTX.AppendText("\r\n");//����
            RTX.AppendText(CUInfo.MsgText);//��ӷ��͵���Ϣ
            RTX.AppendText("\r\n");//����
            RTX.ScrollToCaret();//����Ϣ��ӵ��ؼ�
        }
        #endregion

        #region  ��ȡ�Է���ҵ�IP��ַ
        /// <summary>
        /// ��ȡ�Է���ҵ�IP��ַ
        /// </summary>
        /// <param GameP="Panel">Panel�ؼ�</param>
        public string ToGameIP(PictureBox GameP)
        {
            int PTag = Convert.ToInt32(GameP.Tag.ToString());
            string temIP = "";
            string Gname = GameP.Name;
            Control panPar = GameP.Parent;
            if (PTag == 1)
                PTag = 2;
            else
            {
                if (PTag == 2)
                    PTag = 1;
            }
            foreach (Control P in panPar.Controls)
            {
                if (P is PictureBox && Convert.ToInt32(P.Tag.ToString()) == PTag)
                {
                    temIP = P.AccessibleName;
                    break;
                }
            }
            return temIP;

        }
        #endregion

        #region  ��ȡ�Է���ҵ���Ϣ
        /// <summary>
        /// ��ȡ�Է���ҵ���Ϣ
        /// </summary>
        /// <param Data="byte[]">�û���Ϣ</param>
        public void Game_TerraInfo(byte[] Data)
        {
            ClassUsers users = new ClassUsers();
            ClassMsg msg = (ClassMsg)new ClassSerializers().DeSerializeBinary(new MemoryStream(Data));
            users = (ClassUsers)new ClassSerializers().DeSerializeBinary(new MemoryStream(msg.Data));//��ȡ�����û���Ϣ

            ClassUserInfo userItem = new ClassUserInfo();
            for (int i = 0; i < users.Count; i++)
            {
                userItem = users[i];
                if (userItem.UserIP != "")
                {
                    GameIP = userItem.UserIP;//��¼�û���IP��ַ
                    GamePort = userItem.UserPort;//��¼�û��Ķ˿ں�
                    GameName = userItem.UserName;//��¼�û�����
                    GameFraction = userItem.Fraction;//��ǰ����
                    GameCaput = userItem.Caput;//ͷ��
                    GameSex = userItem.Sex;//�Ա�
                }
                break;
            }
        }
        #endregion

        #region  ��Է����ͱ����û�����Ϣ
        /// <summary>
        /// ��Է����ͱ����û�����Ϣ
        /// </summary>
        public ClassMsg Game_FarInfo(String G_ToIP)
        {
            ClassMsg msg = new ClassMsg();
            ClassUsers Users = new ClassUsers();
            ClassUserInfo UserItem = new ClassUserInfo();//����������ClassUserInfo��
            UserItem.UserIP = Publec_Class.ClientIP;//��¼�û���IP��ַ
            UserItem.UserPort = Publec_Class.ServerPort;//��¼�˿ں�
            UserItem.UserName = Publec_Class.ClientName;//��¼�û�����
            UserItem.Fraction = Publec_Class.Fraction.ToString();//��ǰ����
            UserItem.Caput = Publec_Class.CaputID.ToString();//ͷ��
            UserItem.Sex = Publec_Class.UserSex.ToString();//ͷ��
            Users.add(UserItem);//�����û���Ϣ��ӵ��û��б���
            
            msg.Data = new ClassSerializers().SerializeBinary(Users).ToArray();//���û��б�д�뵽����������
            msg.msgCommand = MsgCommand.EndRival;
            return msg;
        }
        #endregion

    }
}
