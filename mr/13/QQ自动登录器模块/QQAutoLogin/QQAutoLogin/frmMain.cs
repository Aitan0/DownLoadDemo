using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Xml;
using System.IO;
using QQAutoLogin.CommonClass;

namespace QQAutoLogin
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        public List<QQInfo> qqList = new List<QQInfo>();//声明一个List泛型集合，用来存储QQ账号列表
        private string qqInfoPath = Application.StartupPath + QQRegister.STR_QQ_DATE_FILE_NAME;//记录XML文件路径

        private void frmMain_Load(object sender, EventArgs e)
        {
            qqList.Clear();//清空账号列表
            initQQList();//初始化QQ列表
            initListView();//初始化ListView控件
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            string qqPath = frmSet.GetQQRegistryValue(QQRegister.STR_QQ_REG_KEY_PRGRM_PATH);//获取注册表中QQ路径信息
            if (string.IsNullOrEmpty(qqPath))//判断QQ路径是否为空
            {
                MessageBox.Show(QQRegister.STR_QQ_WARN_PRGRM_PATH_NULL);
                return;
            }
            if (!qqPath.ToLower().EndsWith("qq.exe"))//判断QQ路径是否正确
            {
                MessageBox.Show(QQRegister.STR_QQ_WARN_PRGRM_PATH_ERR);
                return;
            }
            foreach (ListViewItem qqItem in lvInfo.Items)//遍历ListView列表
            {
                QQInfo qqinfo = qqList[qqItem.Index];//记录遍历到的QQ账号
                if (qqItem.Checked)//判断QQ账号是否选中
                {
                    qqinfo.IsChecked = true;//设置选中状态
                    string strNum = qqinfo.Number;//记录QQ账号
                    string strPwd = qqinfo.Pwd;//记录QQ密码，并加密
                    bool blHide = qqinfo.IsHide;//记录QQ隐身状态
                    qqinfo.LastLoginTime = DateTime.Now.ToString();//记录QQ最后登录时间
                    try
                    {
                        Process.Start(qqPath, "/START QQUIN:" + strNum + " PWDHASH:" + strPwd + " /STAT:" + (blHide ? "40" : "41"));//启动遍历到的QQ账号
                    }
                    catch
                    {
                        MessageBox.Show("本机还没有安装QQ，请安装之后再使用本软件！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    qqinfo.IsChecked = false;//设置未选中状态
                }
            }
        }

        private void btnStartQQ_Click(object sender, EventArgs e)
        {
            string qqPath = frmSet.GetQQRegistryValue(QQRegister.STR_QQ_REG_KEY_PRGRM_PATH);//获取注册表中QQ路径信息
            if (string.IsNullOrEmpty(qqPath))//判断QQ路径是否为空
            {
                MessageBox.Show(QQRegister.STR_QQ_WARN_PRGRM_PATH_NULL);
                return;
            }
            if (!qqPath.ToLower().EndsWith("qq.exe"))//判断QQ路径是否正确
            {
                MessageBox.Show(QQRegister.STR_QQ_WARN_PRGRM_PATH_ERR);
                return;
            }
            try
            {
                Process.Start(qqPath);//启动QQ软件
            }
            catch
            {
                MessageBox.Show("本机还没有安装QQ，请安装之后再使用本软件！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddQQ frmaddqq = new frmAddQQ();                  //实例化“添加QQ账号”窗体
            if (frmaddqq.ShowDialog() == DialogResult.OK)        //判断窗体的返回值
            {
                QQInfo qqinfo = frmaddqq.GetQQInfo();            //获取添加的QQ账号信息
                for (int i = 0; i < lvInfo.Items.Count; i++)     //遍历ListView控件中的所有项
                {
                    if (qqinfo.Number == lvInfo.Items[i].Text)   //判断遍历到的项与要添加的项是否相同
                    {
                        MessageBox.Show("号码已存在");
                        return;
                    }
                }
                this.qqList.Add(qqinfo);                         //将要添加的QQ账号添加到QQ账号列表中
                initListView();                                  //重新初始化ListView控件中的项
                QQFilePath.SetQQList(qqInfoPath, qqList);        //将QQ账号列表中的数据写入到XML文件
            }
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            frmSet frmset = new frmSet();//实例化设置窗体
            frmset.ShowDialog();//以对话框形式显示设置窗体
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            frmAbout frmabout = new frmAbout();//实例化关于窗体
            frmabout.ShowDialog();//以对话框形式显示关于窗体
        }

        private void btnExt_Click(object sender, EventArgs e)
        {
            Application.Exit();//退出当前应用程序
        }

        private void lvInfo_DoubleClick(object sender, EventArgs e)
        {
            if (0 == lvInfo.Items.Count || lvInfo.FocusedItem == null)//判断ListView控件中是否有项
            {
                return;
            }
            string strNum = lvInfo.FocusedItem.Text;//获取选择的项
            frmAddQQ frmaddqq = new frmAddQQ();//实例化“添加QQ账号”窗体
            frmaddqq.ControlsStatus(strNum);//控制窗体中的控件状态
            if (frmaddqq.ShowDialog() == DialogResult.OK)//判断窗体的返回值
            {
                this.qqList.Add(frmaddqq.GetQQInfo());//将要修改的QQ账号添加到QQ账号列表中
                initListView();//重新初始化ListView控件中的项
                QQFilePath.SetQQList(qqInfoPath, qqList);//将QQ账号列表中的数据写入到XML文件
            }
        }

        private void ToolStripMenuChgItem_Click(object sender, EventArgs e)
        {
            lvInfo_DoubleClick(sender, e);//执行ListView控件的双击事件
        }

        private void ToolStripMenuDelItem_Click(object sender, EventArgs e)
        {
            if (0 == lvInfo.Items.Count || lvInfo.FocusedItem == null)//判断ListView控件中是否有项
            {
                return;
            }
            qqList.RemoveAt(lvInfo.FocusedItem.Index);//移除选中项
            initListView();//重新初始化ListView控件中的项
        }

        private void ToolStripMenuShowItem_Click(object sender, EventArgs e)
        {
            if (0 == lvInfo.Items.Count || lvInfo.FocusedItem == null)//判断ListView控件中是否有项
            {
                return;
            }
            int intSelectItem = lvInfo.FocusedItem.Index;//获取选择的项
            this.qqList[intSelectItem].IsHide = !this.qqList[intSelectItem].IsHide;//判断隐身状态
            initListView();//重新初始化ListView控件中的项
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            QQFilePath.SetQQList(qqInfoPath, qqList);//将QQ账号列表中的数据写入到XML文件
        }

        /// <summary>
        /// 初始化ListView控件中的项
        /// </summary>
        private void initListView()
        {
            lvInfo.Items.Clear();//清空ListView列表
            if (null == qqList)//判断QQ账号列表是否为空
            {
                qqList = new List<QQInfo>();//实例化QQ账号列表
                return;
            }
            foreach (QQInfo qqinfo in qqList)//遍历QQ账号列表
            {
                ListViewItem qqItem = new ListViewItem(qqinfo.Number);//使用遍历到的QQ账号实例化ListView项列表
                qqItem.SubItems.Add(qqinfo.LastLoginTime);//添加QQ账号最后登录时间
                qqItem.Checked = qqinfo.IsChecked;//设置QQ账号的默认选中状态
                if (qqinfo.IsHide)//判断QQ账号的隐身状态
                {
                    qqItem.ImageIndex = 0;//设置图像索引为0
                }
                else
                {
                    qqItem.ImageIndex = 1;//设置图像索引为1
                }
                lvInfo.Items.Add(qqItem);//将指定的QQ账号信息添加到ListView控件中
            }
        }

        /// <summary>
        /// 初始化QQ账号列表
        /// </summary>
        private void initQQList()
        {
            if (!File.Exists(qqInfoPath))//判断XML文件是否存在
            {
                File.Create(qqInfoPath).Close();//创建一个XML文件，并关闭文件对象
                XmlTextWriter xmlWriter = new XmlTextWriter(qqInfoPath, Encoding.UTF8);//实例化一个XML文件写入器
                xmlWriter.WriteStartDocument();//编写XML文件声明
                xmlWriter.Close();//关闭XML文件写入器
                qqList = new List<QQInfo>();//实例化QQ账号列表
            }
            else
            {
                qqList = QQFilePath.GetQQList(qqInfoPath);//获取QQ账号列表
            }
        }
    }
}
