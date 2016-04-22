using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
namespace MyWebIE
{
    public partial class frmIE : Form
    {
        //每页标题显示字符数
        private int TITLE_COUNT = 8;
        public frmIE()
        {
            InitializeComponent();
        }

        #region 工具栏
        /// <summary>
        /// 后退按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btngoback_Click(object sender, EventArgs e)
        {
            getCurrentBrowser().GoBack();
            setStatusButton();
        }
        /// <summary>
        /// 前进按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnforword_Click(object sender, EventArgs e)
        {
            getCurrentBrowser().GoForward();
            setStatusButton();
        }
        /// <summary>
        /// 停止按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStop_Click(object sender, EventArgs e)
        {
            getCurrentBrowser().Stop();
        }
        /// <summary>
        /// 刷新按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnrefresh_Click(object sender, EventArgs e)
        {
            getCurrentBrowser().Refresh();
        }
        /// <summary>
        /// 主页按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnhome_Click(object sender, EventArgs e)
        {
            getCurrentBrowser().GoHome();
        }
        /// <summary>
        /// 搜索按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnsearch_Click(object sender, EventArgs e)
        {
            getCurrentBrowser().GoSearch();
        }
        /// <summary>
        /// 打印按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnprint_Click(object sender, EventArgs e)
        {
            getCurrentBrowser().ShowPrintDialog();
        }
        /// <summary>
        /// 新建按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNew_Click(object sender, EventArgs e)
        {
            newPage();
        }
        /// <summary>
        /// 转到按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            newCurrentPageUrl(tscburl.Text);
        }
        /// <summary>
        /// 使地址栏中的地址处于选择状态
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            tscburl.Select();
        }
        #endregion

        #region 常用方法
        /// <summary>
        /// 设置前进、后退按钮状态
        /// </summary>
        private void setStatusButton()
        {
            btngoback.Enabled = getCurrentBrowser().CanGoBack;
            btnforword.Enabled = getCurrentBrowser().CanGoForward;
        }
        /// <summary>
        /// 当在地址栏中输入网址之后回车打开网址
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tscburl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                newCurrentPageUrl(tscburl.Text);
            }
        }
        /// <summary>
        /// 新建一个空白页面
        /// </summary>
        private void newPage()
        {
            tscburl.Text= "about:blank";
            TabPage mypage = new TabPage();
            WebBrowser tempBrowser = new WebBrowser();
            tempBrowser.Navigated += new WebBrowserNavigatedEventHandler(tempBrowser_Navigated);
            tempBrowser.NewWindow += new CancelEventHandler(tempBrowser_NewWindow);
            tempBrowser.ProgressChanged += new WebBrowserProgressChangedEventHandler(tempBrowser_ProgressChanged);
            tempBrowser.StatusTextChanged += new EventHandler(tempBrowser_StatusTextChanged);
            tempBrowser.Dock = DockStyle.Fill;
            mypage.Controls.Add(tempBrowser);
            tabControl1.TabPages.Add(mypage);
            tabControl1.SelectedTab = mypage;
        }
        /// <summary>
        /// 控制进度条变化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void tempBrowser_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {
            toolStripProgressBar1.Visible = true;
            toolStripProgressBar1.Maximum = (int)e.MaximumProgress;
            toolStripProgressBar1.Value = (int)e.CurrentProgress;
            toolStripProgressBar1.Visible = false;
            setStatusButton();
        }
        /// <summary>
        /// 新建一个页面并打开指定的网址
        /// </summary>
        /// <param name="address"></param>
        private void newPage(string address)
        {
            TabPage mypage = new TabPage();
            WebBrowser tempBrowser = new WebBrowser();
            tempBrowser.Navigated += new WebBrowserNavigatedEventHandler(tempBrowser_Navigated);
            tempBrowser.NewWindow += new CancelEventHandler(tempBrowser_NewWindow);
            tempBrowser.StatusTextChanged += new EventHandler(tempBrowser_StatusTextChanged);
            tempBrowser.ProgressChanged += new WebBrowserProgressChangedEventHandler(tempBrowser_ProgressChanged);
            tempBrowser.Url = getUrl(address);
            tempBrowser.Dock = DockStyle.Fill;
            mypage.Controls.Add(tempBrowser);
            tabControl1.TabPages.Add(mypage);
        }
        /// <summary>
        /// 获取当前的浏览器
        /// </summary>
        /// <returns></returns>
        private WebBrowser getCurrentBrowser()
        {
            WebBrowser currentBrowser = (WebBrowser)tabControl1.SelectedTab.Controls[0];
            return currentBrowser;
        }
        /// <summary>
        /// 处理地址栏中的字符串
        /// </summary>
        /// <param name="address"></param>
        /// <returns></returns>
        private Uri getUrl(string address)
        {
            string tempaddress = address;
            if ((!address.StartsWith("http://")) && (!address.StartsWith("https://")) && (!address.StartsWith("ftp://")))
            {
                tempaddress = "http://" + address;
            }
            Uri myurl;
            try
            {
                myurl = new Uri(tempaddress);
            }
            catch
            {
                myurl = new Uri("about:blank");
            }
            return myurl;
        }
        /// <summary>
        /// 截取字符串为指定长度
        /// </summary>
        /// <param name="oldstring"></param>
        /// <returns></returns>
        private string newstring(string oldstring)
        {
            string temp;
            if (oldstring.Length < TITLE_COUNT)
            {
                temp = oldstring;
            }
            else
            {
                temp = oldstring.Substring(0, TITLE_COUNT);
            }
            return temp;
        }
        /// <summary>
        /// 将浏览过的网址写入记事本中
        /// </summary>
        /// <param name="s"></param>
        public void WriteText(string s)
        {
            string strg = Application.StartupPath.ToString();
            strg = strg.Substring(0, strg.LastIndexOf("\\"));
            strg = strg.Substring(0, strg.LastIndexOf("\\"));
            strg += @"\UrlTxt.txt";
            System.IO.StreamWriter sw = new StreamWriter(strg, true);
            sw.WriteLine(s);
            sw.Close();
        }
        /// <summary>
        /// 读取记事本中的文件
        /// </summary>
        public void ReadText()
        {
            string strg = Application.StartupPath.ToString();
            strg = strg.Substring(0, strg.LastIndexOf("\\"));
            strg = strg.Substring(0, strg.LastIndexOf("\\"));
            strg += @"\UrlTxt.txt";
            try
            {
                StreamReader sr = new StreamReader(strg);
                while (sr.ReadLine() != null)
                {
                    tscburl.Items.Add(sr.ReadLine().ToString());
                }
                sr.Close();
            }
            catch
            { }
        }
        #endregion

        #region 临时浏览器的事件
        /// <summary>
        /// 临时浏览器状态变化事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void tempBrowser_StatusTextChanged(object sender, EventArgs e)
        {
            WebBrowser myBrowser = (WebBrowser)sender;
            if (myBrowser != getCurrentBrowser())
            {
                return;
            }
            else
            {
                toolStripStatusLabel1.Text = myBrowser.StatusText;
            }
        }
        /// <summary>
        /// 在当前页面上重新定向
        /// </summary>
        /// <param name="address">url</param>
        private void newCurrentPageUrl(String address)
        {
            getCurrentBrowser().Navigate(getUrl(address));
        }
        /// <summary>
        /// 临时浏览器产生新窗体事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void tempBrowser_NewWindow(object sender, CancelEventArgs e)
        {
            //获取触发tempBrowser_NewWindow事件的浏览器
            WebBrowser myBrowser = (WebBrowser)sender;
            //获取触发tempBrowser_NewWindow事件的浏览器所在TabPage
            TabPage mypage = (TabPage)myBrowser.Parent;
            //通过StatusText属性获得新的url
            string NewURL = ((WebBrowser)sender).StatusText;
            //生成新的一页
            TabPage TabPageTemp = new TabPage();
            //生成新的tempBrowser
            WebBrowser tempBrowser = new WebBrowser();
            //临时浏览器定向到新的url
            tempBrowser.Navigate(NewURL);
            tempBrowser.Dock = DockStyle.Fill;
            //为临时浏览器关联NewWindow等事件
            tempBrowser.NewWindow += new CancelEventHandler(tempBrowser_NewWindow);
            tempBrowser.Navigated += new WebBrowserNavigatedEventHandler(tempBrowser_Navigated);
            tempBrowser.ProgressChanged += new WebBrowserProgressChangedEventHandler(tempBrowser_ProgressChanged);
            tempBrowser.StatusTextChanged += new EventHandler(tempBrowser_StatusTextChanged);
            //将临时浏览器添加到临时TabPage中
            TabPageTemp.Controls.Add(tempBrowser);
            //将临时TabPage添加到主窗体中
            this.tabControl1.TabPages.Add(TabPageTemp);
            //使外部无法捕获此事件
            e.Cancel = true;
        }
        /// <summary>
        /// 临时浏览器定向完毕
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tempBrowser_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            tscburl.Text = getCurrentBrowser().Url.ToString();
            WebBrowser mybrowser = (WebBrowser)sender;
            TabPage mypage = (TabPage)mybrowser.Parent;
            //设置临时浏览器所在tab标题
            mypage.Text = newstring(mybrowser.DocumentTitle);
        }
        #endregion

        #region tabControl1控件的常用事件
        /// <summary>
        /// 切换不同的tab事出发此事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            WebBrowser mybor = (WebBrowser)tabControl1.SelectedTab.Controls[0];
            if (mybor.Url != null)
            {
                //地址输入框
                tscburl.Text = mybor.Url.ToString();
                tabControl1.SelectedTab.Text = newstring(mybor.DocumentTitle);
            }
            else
            {
                tscburl.Text = "about:blank";
                tabControl1.SelectedTab.Text = "空白页";
            }
            setStatusButton();
        }
        /// <summary>
        /// 关闭指定的tab
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabControl1_DoubleClick(object sender, EventArgs e)
        {
            //仅仅剩下一个tab时返回
            if (tabControl1.TabPages.Count <= 1)
            {
                tabControl1.SelectedTab.Text = "空白页";
                getCurrentBrowser().Navigate("about:blank");
            }
            else
            {
                //先将tabControl1隐藏然后remove掉目标tab（如果不隐藏则出现闪烁，即系统自动调转到tabControl1的第一个tab然后跳会。）最后显示tabControl1。
                tabControl1.Visible = false;
                WebBrowser mybor = getCurrentBrowser();
                //释放资源
                mybor.Dispose();
                mybor.Controls.Clear();
                this.tabControl1.TabPages.Remove(this.tabControl1.SelectedTab);
                //重新设置当前tab
                tabControl1.SelectedTab = tabControl1.TabPages[tabControl1.TabPages.Count - 1];
                tabControl1.Visible = true;
            }
        }
        #endregion

        #region 初始化当前的浏览器窗体
        /// <summary>
        /// 加载窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmIE_Load(object sender, EventArgs e)
        {
            initMainForm();
            ReadText();
        }
        /// <summary>
        /// 初始化浏览器
        /// </summary>
        private void initMainForm()
        {
            TabPage mypage = new TabPage();
            WebBrowser tempBrowser = new WebBrowser();
            tempBrowser.Navigated += new WebBrowserNavigatedEventHandler(tempBrowser_Navigated);
            tempBrowser.NewWindow += new CancelEventHandler(tempBrowser_NewWindow);
            tempBrowser.StatusTextChanged += new EventHandler(tempBrowser_StatusTextChanged);
            tempBrowser.ProgressChanged += new WebBrowserProgressChangedEventHandler(tempBrowser_ProgressChanged);
            tempBrowser.Dock = DockStyle.Fill;
            tempBrowser.GoHome();//和新建空白页不同
            mypage.Controls.Add(tempBrowser);
            tabControl1.TabPages.Add(mypage);
        }
        #endregion

        #region 菜单栏
        /// <summary>
        /// 新建网页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 新建ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newPage();
        }
        /// <summary>
        /// 另存为
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 另存为ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            getCurrentBrowser().ShowSaveAsDialog();
        }
        /// <summary>
        /// 打印
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 打印ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            getCurrentBrowser().ShowPrintDialog();
        }
        /// <summary>
        /// 打印预览
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 打印预览ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            getCurrentBrowser().ShowPrintPreviewDialog();
        }
        /// <summary>
        /// 页面设置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 页面设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            getCurrentBrowser().ShowPageSetupDialog();
        }
        /// <summary>
        /// 属性
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 属性ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            getCurrentBrowser().ShowPropertiesDialog();
        }
        /// <summary>
        /// 关闭浏览器
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 关闭ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// 停止
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 停止PToolStripMenuItem_Click(object sender, EventArgs e)
        {
            getCurrentBrowser().Stop();
        }
        /// <summary>
        /// 刷新
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 刷新ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            getCurrentBrowser().Refresh();
        }
        /// <summary>
        /// 源文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 源文件CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tscburl.Text.Trim() != "about:blank")
            {
                frmSource source = new frmSource();
                source.address = tscburl.Text.Trim();
                source.ShowDialog();
            }
        }
        /// <summary>
        /// 添加到收藏夹
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 添加到收藏夹AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tscburl.Text.Trim() == "about:blank" || tscburl.Text.Trim() == "" || !tscburl.Text.Trim().StartsWith("http://"))
            { }
            else
            {
                frmOpenFavorites open = new frmOpenFavorites();
                open.IUrl = tscburl.Text.Trim();
                open.ITitle = getCurrentBrowser().DocumentTitle;
                open.ShowDialog();
            }
        }
        /// <summary>
        /// 整理收藏夹
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 整理收藏夹OToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNeatenFavorites neaten = new frmNeatenFavorites();
            neaten.ShowDialog();
        }
        #endregion 
    }
}