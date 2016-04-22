using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Management;
using Microsoft.VisualBasic.Devices;
using System.Threading;
namespace MagicCony
{
    public partial class frmSystemCheck : Form
    {
        public frmSystemCheck()
        {
            InitializeComponent();
        }

        private void frmSystemCheck_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            TreeNode tn1 = new TreeNode("Windows");
            TreeNode tn2 = new TreeNode("CPU������");
            TreeNode tn3 = new TreeNode("��Ƶ�豸");
            TreeNode tn4 = new TreeNode("��Ƶ�豸");
            TreeNode tn5 = new TreeNode("�洢�豸");
            TreeNode tn6 = new TreeNode("�����豸");
            TreeNode tn8 = new TreeNode("������ӿ�");
            TreeNode tn9 = new TreeNode("�����豸");
            TreeNode tn10 = new TreeNode("��ӡ�봫��");


            #region Windows���ڵ���ӽڵ�
            tn1.Nodes.Add("Windows��Ϣ");
            tn1.Nodes.Add("Windows�û�");
            tn1.Nodes.Add("�û����");
            tn1.Nodes.Add("��ǰ����");
            tn1.Nodes.Add("ϵͳ����");
            tn1.Nodes.Add("ϵͳ����");
            #endregion

            #region CPU�����常�ڵ���ӽڵ�
            tn2.Nodes.Add("���봦����");
            tn2.Nodes.Add("����");
            tn2.Nodes.Add("BIOS��Ϣ");
            #endregion

            #region ��Ƶ�豸���ڵ���ӽڵ�
            tn3.Nodes.Add("�Կ�");
            #endregion

            #region �洢�豸���ڵ���ӽڵ�
            tn5.Nodes.Add("�����ڴ�");
            tn5.Nodes.Add("����");
            #endregion


            tn6.Nodes.Add("����������");
            tn6.Nodes.Add("����Э��");
            
            tn8.Nodes.Add("����");
            tn8.Nodes.Add("IDE������");
            tn8.Nodes.Add("����������");
            tn8.Nodes.Add("USB������");
            tn8.Nodes.Add("SCSI������");
            tn8.Nodes.Add("PCMCIA��������");
            tn8.Nodes.Add("1394������");
            tn8.Nodes.Add("���弴���豸");

            tn9.Nodes.Add("���");
            tn9.Nodes.Add("����");


            treeView1.Nodes.Add(tn1);
            treeView1.Nodes.Add(tn10);
            treeView1.Nodes.Add(tn2);
            treeView1.Nodes.Add(tn3);
            treeView1.Nodes.Add(tn4);
            treeView1.Nodes.Add(tn5);
            treeView1.Nodes.Add(tn6);
            treeView1.Nodes.Add(tn8);
            treeView1.Nodes.Add(tn9);
        }
        public string selectTxt;
        private void GetInfo()
        {
            PublicClass pc = new PublicClass();
            switch (selectTxt)
            {
                case "Windows��Ϣ":
                    pc.getInfo1(listView1);
                    break;
                case "Windows�û�":
                    pc.InsertInfo("Win32_UserAccount", ref listView1, true);
                    break;
                case "�û����":
                    pc.InsertInfo("Win32_Group", ref listView1, true);
                    break;
                case "��ǰ����":
                    pc.InsertInfo("Win32_Process", ref listView1, true);
                    break;
                case "ϵͳ����":
                    pc.InsertInfo("Win32_Service", ref listView1, true);
                    break;
                case "ϵͳ����":
                    pc.InsertInfo("Win32_SystemDriver", ref listView1, true);
                    break;
                case "���봦����":
                    pc.InsertInfo("Win32_Processor", ref listView1, true);
                    break;
                case "����":
                    pc.InsertInfo("Win32_BaseBoard", ref listView1, true);
                    break;
                case "BIOS��Ϣ":
                    pc.InsertInfo("Win32_BIOS", ref listView1, true);
                    break;
                case "�Կ�":
                    pc.InsertInfo("Win32_VideoController", ref listView1, true);
                    break;
                case "��Ƶ�豸":
                    pc.InsertInfo("Win32_SoundDevice", ref listView1, true);
                    break;
                case "�����ڴ�":
                    pc.InsertInfo("Win32_PhysicalMemory", ref listView1, true);
                    break;
                case "����":
                    pc.InsertInfo("Win32_LogicalDisk", ref listView1, true);
                    break;
                case "����������":
                    pc.InsertInfo("Win32_NetworkAdapter", ref listView1, true);
                    break;
                case "����Э��":
                    pc.InsertInfo("Win32_NetworkProtocol", ref listView1, true);
                    break;
                case "��ӡ�봫��":
                    pc.InsertInfo("Win32_Printer", ref listView1, true);
                    break;
                case "����":
                    pc.InsertInfo("Win32_Keyboard", ref listView1, true);
                    break;
                case "���":
                    pc.InsertInfo("Win32_PointingDevice", ref listView1, true);
                    break;
                case "����":
                    pc.InsertInfo("Win32_SerialPort", ref listView1, true);
                    break;
                case "IDE������":
                    pc.InsertInfo("Win32_IDEController", ref listView1, true);
                    break;
                case "����������":
                    pc.InsertInfo("Win32_FloppyController", ref listView1, true);
                    break;
                case "USB������":
                    pc.InsertInfo("Win32_USBController", ref listView1, true);
                    break;
                case "SCSI������":
                    pc.InsertInfo("Win32_SCSIController", ref listView1, true);
                    break;
                case "PCMCIA��������":
                    pc.InsertInfo("Win32_PCMCIAController", ref listView1, true);
                    break;
                case "1394������":
                    pc.InsertInfo("Win32_1394Controller", ref listView1, true);
                    break;
                case "���弴���豸":
                    pc.InsertInfo("Win32_PnPEntity", ref listView1, true);
                    break;
                    

            }
            
        }
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            listView1.Items.Clear();
            selectTxt = treeView1.SelectedNode.Text;
            GetInfo();
        }

        private void frmSystemCheck_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            frmCony cony = new frmCony();
            cony.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}