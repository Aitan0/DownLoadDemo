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
            TreeNode tn2 = new TreeNode("CPU与主板");
            TreeNode tn3 = new TreeNode("视频设备");
            TreeNode tn4 = new TreeNode("音频设备");
            TreeNode tn5 = new TreeNode("存储设备");
            TreeNode tn6 = new TreeNode("网络设备");
            TreeNode tn8 = new TreeNode("总线与接口");
            TreeNode tn9 = new TreeNode("输入设备");
            TreeNode tn10 = new TreeNode("打印与传真");


            #region Windows父节点的子节点
            tn1.Nodes.Add("Windows信息");
            tn1.Nodes.Add("Windows用户");
            tn1.Nodes.Add("用户组别");
            tn1.Nodes.Add("当前进程");
            tn1.Nodes.Add("系统服务");
            tn1.Nodes.Add("系统驱动");
            #endregion

            #region CPU与主板父节点的子节点
            tn2.Nodes.Add("中央处理器");
            tn2.Nodes.Add("主板");
            tn2.Nodes.Add("BIOS信息");
            #endregion

            #region 视频设备父节点的子节点
            tn3.Nodes.Add("显卡");
            #endregion

            #region 存储设备父节点的子节点
            tn5.Nodes.Add("物理内存");
            tn5.Nodes.Add("磁盘");
            #endregion


            tn6.Nodes.Add("网络适配器");
            tn6.Nodes.Add("网络协议");
            
            tn8.Nodes.Add("串口");
            tn8.Nodes.Add("IDE控制器");
            tn8.Nodes.Add("软驱控制器");
            tn8.Nodes.Add("USB控制器");
            tn8.Nodes.Add("SCSI控制器");
            tn8.Nodes.Add("PCMCIA卡控制器");
            tn8.Nodes.Add("1394控制器");
            tn8.Nodes.Add("即插即用设备");

            tn9.Nodes.Add("鼠标");
            tn9.Nodes.Add("键盘");


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
                case "Windows信息":
                    pc.getInfo1(listView1);
                    break;
                case "Windows用户":
                    pc.InsertInfo("Win32_UserAccount", ref listView1, true);
                    break;
                case "用户组别":
                    pc.InsertInfo("Win32_Group", ref listView1, true);
                    break;
                case "当前进程":
                    pc.InsertInfo("Win32_Process", ref listView1, true);
                    break;
                case "系统服务":
                    pc.InsertInfo("Win32_Service", ref listView1, true);
                    break;
                case "系统驱动":
                    pc.InsertInfo("Win32_SystemDriver", ref listView1, true);
                    break;
                case "中央处理器":
                    pc.InsertInfo("Win32_Processor", ref listView1, true);
                    break;
                case "主板":
                    pc.InsertInfo("Win32_BaseBoard", ref listView1, true);
                    break;
                case "BIOS信息":
                    pc.InsertInfo("Win32_BIOS", ref listView1, true);
                    break;
                case "显卡":
                    pc.InsertInfo("Win32_VideoController", ref listView1, true);
                    break;
                case "音频设备":
                    pc.InsertInfo("Win32_SoundDevice", ref listView1, true);
                    break;
                case "物理内存":
                    pc.InsertInfo("Win32_PhysicalMemory", ref listView1, true);
                    break;
                case "磁盘":
                    pc.InsertInfo("Win32_LogicalDisk", ref listView1, true);
                    break;
                case "网络适配器":
                    pc.InsertInfo("Win32_NetworkAdapter", ref listView1, true);
                    break;
                case "网络协议":
                    pc.InsertInfo("Win32_NetworkProtocol", ref listView1, true);
                    break;
                case "打印与传真":
                    pc.InsertInfo("Win32_Printer", ref listView1, true);
                    break;
                case "键盘":
                    pc.InsertInfo("Win32_Keyboard", ref listView1, true);
                    break;
                case "鼠标":
                    pc.InsertInfo("Win32_PointingDevice", ref listView1, true);
                    break;
                case "串口":
                    pc.InsertInfo("Win32_SerialPort", ref listView1, true);
                    break;
                case "IDE控制器":
                    pc.InsertInfo("Win32_IDEController", ref listView1, true);
                    break;
                case "软驱控制器":
                    pc.InsertInfo("Win32_FloppyController", ref listView1, true);
                    break;
                case "USB控制器":
                    pc.InsertInfo("Win32_USBController", ref listView1, true);
                    break;
                case "SCSI控制器":
                    pc.InsertInfo("Win32_SCSIController", ref listView1, true);
                    break;
                case "PCMCIA卡控制器":
                    pc.InsertInfo("Win32_PCMCIAController", ref listView1, true);
                    break;
                case "1394控制器":
                    pc.InsertInfo("Win32_1394Controller", ref listView1, true);
                    break;
                case "即插即用设备":
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