using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.IO;
using System.Runtime.InteropServices;
using System.Xml;
using System.Collections;
using System.Windows.Forms;
using System.Drawing;
using Microsoft.Win32;
using System.Threading;
using System.Diagnostics;

namespace UpgradeClass
{
    #region 获取系统图标
    /// <summary>
    /// 获取系统图标
    /// </summary>
    public class Win32
    {
        public const uint SHGFI_ICON = 0x100;
        public const uint SHGFI_LARGEICON = 0x0; //大图标
        public const uint SHGFI_SMALLICON = 0x1; //小图标
        [DllImport("shell32.dll", EntryPoint = "ExtractIcon")]
        public static extern int ExtractIcon(IntPtr hInst, string lpFileName, int nIndex);
        [DllImport("shell32.dll", EntryPoint = "SHGetFileInfo")]
        public static extern IntPtr SHGetFileInfo(string pszPath, uint dwFileAttribute, ref SHFILEINFO psfi, uint cbSizeFileInfo, uint Flags);
        [DllImport("User32.dll", EntryPoint = "DestroyIcon")]
        public static extern int DestroyIcon(IntPtr hIcon);
        [DllImport("shell32.dll")]
        public static extern uint ExtractIconEx(string lpszFile, int nIconIndex, int[] phiconLarge, int[] phiconSmall, uint nIcons);
        [StructLayout(LayoutKind.Sequential)]
        public struct SHFILEINFO
        {
            public IntPtr hIcon;
            public IntPtr iIcon;
            public uint dwAttributes;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
            public string szDisplayName;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 80)]
            public string szTypeName;
        }
    }
    #endregion

    #region 系统操作类
    /// <summary>
    /// 系统操作类
    /// </summary>
    public class OperateClass
    {
        FtpWebRequest reqFTP;//实例化FTP客户端对象

        #region 验证登录用户是否合法
        /// <summary>
        /// 验证登录用户是否合法
        /// </summary>
        /// <param name="FTPServerIP">FTP服务器地址</param>
        /// <param name="FtpUserName">登录FTP用户名</param>
        /// <param name="FtpUserPwd">登录FTP密码</param>
        /// <returns>Bool类型，如果为true，表示登录用户合法，否则表示不合法</returns>
        public bool CheckFtp(string FTPServerIP, string FtpUserName, string FtpUserPwd)
        {
            bool ResultValue = true;
            try
            {
                FtpWebRequest ftprequest = (FtpWebRequest)WebRequest.Create("ftp://" + FTPServerIP);//创建FtpWebRequest对象
                ftprequest.Credentials = new NetworkCredential(FtpUserName, FtpUserPwd);//设置FTP登录信息
                ftprequest.Method = WebRequestMethods.Ftp.ListDirectory;//发送一个请求命令
                FtpWebResponse ftpResponse = (FtpWebResponse)ftprequest.GetResponse();//响应一个请求
                ftpResponse.Close();//关闭请求
            }
            catch
            {
                ResultValue = false;
            }
            return ResultValue;
        }
        #endregion

        #region 连接FTP
        /// <summary>
        /// 连接FTP
        /// </summary>
        /// <param name="path">FTP地址</param>
        /// <param name="ftpUserID">登录用户名</param>
        /// <param name="ftpPassword">登录密码</param>
        public void Connect(String path, string ftpUserID, string ftpPassword)
        {
            //根据uri创建FtpWebRequest对象
            reqFTP = (FtpWebRequest)FtpWebRequest.Create(new Uri(path));
            //指定数据传输类型
            reqFTP.UseBinary = true;
            //ftp用户名和密码
            reqFTP.Credentials = new NetworkCredential(ftpUserID, ftpPassword);
        }
        #endregion

        #region 从FTP下载文件
        /// <summary>
        /// 从FTP下载文件
        /// </summary>
        /// <param name="filePath">下载到的本地路径</param>
        /// <param name="fileName">文件名</param>
        /// <param name="ftpServerIP">FTP服务器IP</param>
        /// <param name="ftpUserID">登录用户 </param>
        /// <param name="ftpPassword">登录密码</param>
        /// <param name="path">要下载的FTP服务器上的文件</param>
        /// <returns>Bool类型，如果为ture，则下载成功，否则下载失败</returns>
        public bool Download(string filePath, string fileName, string ftpServerIP, string ftpUserID, string ftpPassword, string path)
        {
            bool check = true;
            FtpWebRequest reqFTP;
            string uri;
            uri = "ftp://" + ftpServerIP + "/" + path + fileName;
            try
            {
                FileStream outputStream = new FileStream(filePath + fileName, FileMode.OpenOrCreate,FileAccess.ReadWrite,FileShare.None);
                reqFTP = (FtpWebRequest)FtpWebRequest.Create(new Uri(uri));
                reqFTP.Method = WebRequestMethods.Ftp.DownloadFile;
                reqFTP.UseBinary = true;
                reqFTP.Credentials = new NetworkCredential(ftpUserID, ftpPassword);
                FtpWebResponse response = (FtpWebResponse)reqFTP.GetResponse();
                Stream ftpStream = response.GetResponseStream();
                long cl = response.ContentLength;
                int bufferSize = 2048;
                int readCount;
                byte[] buffer = new byte[bufferSize];
                readCount = ftpStream.Read(buffer, 0, bufferSize);
                while (readCount > 0)
                {
                    outputStream.Write(buffer, 0, readCount);
                    readCount = ftpStream.Read(buffer, 0, bufferSize);
                }
                ftpStream.Close();
                outputStream.Close();
                response.Close();
            }
            catch
            {
                check = false;
            }
            return check;
        }
        #endregion

        #region 获取FTP服务器上指定路径下的文件列表
        /// <summary>
        /// 获取FTP服务器上指定路径下的文件列表
        /// </summary>
        /// <param name="ftpServerIP">FTP服务器IP</param>
        /// <param name="ftpUserID">登录用户名</param>
        /// <param name="ftpPassword">登录密码</param>
        /// <param name="path">FTP服务器上的指定路径</param>
        /// <returns>字符串数组，表示获得的文件列表</returns>
        public string[] GetFTPList(string ftpServerIP, string ftpUserID, string ftpPassword, string path)//指定路径的文件列表
        {
            if (path == null)
                path = "";
            string[] downloadFiles;
            StringBuilder result = new StringBuilder();
            FtpWebRequest reqFTP;
            try
            {
                reqFTP = (FtpWebRequest)FtpWebRequest.Create(new Uri("ftp://" + ftpServerIP + "/" + path.Remove(path.LastIndexOf("/"))));
                reqFTP.UseBinary = true;
                reqFTP.Credentials = new NetworkCredential(ftpUserID, ftpPassword);
                reqFTP.Method = WebRequestMethods.Ftp.ListDirectoryDetails;
                WebResponse response = reqFTP.GetResponse();
                StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.GetEncoding("GB2312"));
                string line = reader.ReadLine();
                while (line != null)
                {
                    result.Append(line);
                    result.Append("\n");
                    line = reader.ReadLine();
                }
                result.Remove(result.ToString().LastIndexOf('\n'), 1);
                reader.Close();
                response.Close();
                return result.ToString().Split('\n');
            }
            catch
            {
                downloadFiles = null;
                return downloadFiles;
            }
        }
        #endregion

        #region 在XML文件中查找文件版本及更新信息
        /// <summary>
        /// 在XML文件中查找文件版本及更新信息
        /// </summary>
        /// <param name="strPath">XML文件路径</param>
        /// <returns>Hashtable对象，用来记录找到的版本及版本更新信息</returns>
        public Hashtable SelectXML(string strPath)
        {
            Hashtable HTable = new Hashtable();
            XmlDocument doc = new XmlDocument();
            //根据指定的进程名创建进程资源数组
            Process[] myProcesses = Process.GetProcessesByName("Update.xml");
            foreach (Process myProcess in myProcesses)//遍历数组
            {
                myProcess.Kill();//关闭进程
            }
            Thread.Sleep(10);//线程休眠10毫秒
            doc.Load(strPath);
            //获取NewDataSet节点的所有子节点
            XmlNodeList xnl = doc.SelectSingleNode("UpdCfg").ChildNodes;
            string strVersion = "";
            string strInfo = "";
            foreach (XmlNode xn in xnl)//遍历所有子节点
            {
                XmlElement xe = (XmlElement)xn;//将子节点类型转换为XmlElement类型
                if (xe.Name == "Upgrade")//判断节点名为Upgrade
                 {
                    XmlNodeList xnlChild = xe.ChildNodes;//继续获取xe子节点的所有子节点
                    foreach (XmlNode xnChild in xnlChild)//遍历
                    {
                        XmlElement xeChild = (XmlElement)xnChild;//转换类型
                        if (xeChild.Name == "VERSION")
                        {
                            strVersion = xeChild.InnerText;
                        }
                        if (xeChild.Name == "UpdInfo")
                        {
                            strInfo = xeChild.InnerText;
                        }
                    }
                    HTable.Add(strVersion, strInfo);
                }
            }
            return HTable;
        }
        #endregion

        #region 向XML文件中添加节点
        /// <summary>
        /// 向XML文件中添加节点
        /// </summary>
        /// <param name="strPath">XML文件路径</param>
        /// <param name="strNode1">版本</param>
        /// <param name="strNode2">版本信息</param>
        public void AddXML(string strPath,string strNode1,string strNode2)
        {
            XmlDocument doc1 = new XmlDocument();
            doc1.Load(strPath);
            XmlNode newNode1;
            XmlNode newNode2;
            newNode1 = doc1.CreateElement("Upgrade");
            newNode2 = doc1.CreateElement("VERSION");
            newNode2.InnerText = strNode1;
            newNode1.AppendChild(newNode2);
            newNode2 = doc1.CreateElement("UpdInfo");
            newNode2.InnerText = strNode2;
            newNode1.AppendChild(newNode2);
            doc1.DocumentElement.AppendChild(newNode1);
            doc1.Save(strPath);
        }
        #endregion

        #region 为INI文件中指定的节点取得字符串
        /// <summary>
        /// 为INI文件中指定的节点取得字符串
        /// </summary>
        /// <param name="lpAppName">欲在其中查找关键字的节点名称</param>
        /// <param name="lpKeyName">欲获取的项名</param>
        /// <param name="lpDefault">指定的项没有找到时返回的默认值</param>
        /// <param name="lpReturnedString">指定一个字串缓冲区，长度至少为nSize</param>
        /// <param name="nSize">指定装载到lpReturnedString缓冲区的最大字符数量</param>
        /// <param name="lpFileName">INI文件名</param>
        /// <returns>复制到lpReturnedString缓冲区的字节数量，其中不包括那些NULL中止字符</returns>
        [DllImport("kernel32")]
        public static extern int GetPrivateProfileString(
            string lpAppName,
            string lpKeyName,
            string lpDefault,
            StringBuilder lpReturnedString,
            int nSize,
            string lpFileName);
        #endregion

        #region 修改INI文件中内容
        /// <summary>
        /// 修改INI文件中内容
        /// </summary>
        /// <param name="lpApplicationName">欲在其中写入的节点名称</param>
        /// <param name="lpKeyName">欲设置的项名</param>
        /// <param name="lpString">要写入的新字符串</param>
        /// <param name="lpFileName">INI文件名</param>
        /// <returns>非零表示成功，零表示失败</returns>
        [DllImport("kernel32")]
        public static extern int WritePrivateProfileString(
            string lpApplicationName,
            string lpKeyName,
            string lpString,
            string lpFileName);
        #endregion

        #region 从INI文件中读取指定节点的内容
        /// <summary>
        /// 从INI文件中读取指定节点的内容
        /// </summary>
        /// <param name="section">INI节点</param>
        /// <param name="key">节点下的项</param>
        /// <param name="def">没有找到内容时返回的默认值</param>
        /// <param name="def">要读取的INI文件</param>
        /// <returns>读取的节点内容</returns>
        public string ReadString(string section, string key, string def, string fileName)
        {
            StringBuilder temp = new StringBuilder(1024);
            GetPrivateProfileString(section, key, def, temp, 1024, fileName);
            return temp.ToString();
        }
        #endregion

        //获取本地磁盘目录
        public void listFolders(ToolStripComboBox tscb)
        {
            string[] logicdrives = System.IO.Directory.GetLogicalDrives();
            for (int i = 0; i < logicdrives.Length; i++)
            {
                tscb.Items.Add(logicdrives[i]);
                tscb.SelectedIndex = 0;
            }
        }

        #region  获取服务器图标
        /// 给出文件扩展名（.*），返回相应图标
        /// 若不以"."开头则返回文件夹的图标。
        public Icon GetIconByFileType(string fileType, bool isLarge)
        {
            if (fileType == null || fileType.Equals(string.Empty)) return null;
            RegistryKey regVersion = null;
            string regFileType = null;
            string regIconString = null;
            string systemDirectory = Environment.SystemDirectory + "\\";
            if (fileType[0] == '.')
            {
                //读系统注册表中文件类型信息
                regVersion = Registry.ClassesRoot.OpenSubKey(fileType, true);
                if (regVersion != null)
                {
                    regFileType = regVersion.GetValue("") as string;
                    regVersion.Close();
                    regVersion = Registry.ClassesRoot.OpenSubKey(regFileType + @"\DefaultIcon", true);
                    if (regVersion != null)
                    {
                        regIconString = regVersion.GetValue("") as string;
                        regVersion.Close();
                    }
                }
                if (regIconString == null)
                {
                    //没有读取到文件类型注册信息，指定为未知文件类型的图标
                    regIconString = systemDirectory + "shell32.dll,0";
                }
            }
            else
            {
                //直接指定为文件夹图标
                regIconString = systemDirectory + "shell32.dll,3";
            }
            string[] fileIcon = regIconString.Split(new char[] { ',' });
            if (fileIcon.Length != 2)
            {
                //系统注册表中注册的标图不能直接提取，则返回可执行文件的通用图标
                fileIcon = new string[] { systemDirectory + "shell32.dll", "2" };
            }
            Icon resultIcon = null;
            try
            {
                //调用API方法读取图标
                int[] phiconLarge = new int[1];
                int[] phiconSmall = new int[1];
                uint count = Win32.ExtractIconEx(fileIcon[0], Int32.Parse(fileIcon[1]), phiconLarge, phiconSmall, 1);
                IntPtr IconHnd = new IntPtr(isLarge ? phiconLarge[0] : phiconSmall[0]);
                resultIcon = Icon.FromHandle(IconHnd);
            }

            catch
            {
                fileIcon = new string[] { systemDirectory + "shell32.dll", "2" };
                //调用API方法读取图标
                int[] phiconLarge = new int[1];
                int[] phiconSmall = new int[1];
                uint count = Win32.ExtractIconEx(fileIcon[0], Int32.Parse(fileIcon[1]), phiconLarge, phiconSmall, 1);
                IntPtr IconHnd = new IntPtr(isLarge ? phiconLarge[0] : phiconSmall[0]);
                resultIcon = Icon.FromHandle(IconHnd);
            }
            return resultIcon;
        }
        #endregion

        //获取服务器的图标
        public void getFTPServerICO(ImageList il, string ftpip, string user, string pwd, ListView lv, string path)
        {
            try
            {
                string[] a;
                lv.Items.Clear();
                il.Images.Clear();
                if (path.Length == 0)
                    a = GetFileList(ftpip, user, pwd);
                else
                    a = GetFileList(ftpip + "/" + path.Remove(path.LastIndexOf("/")), user, pwd);
                if (a != null)
                {
                    for (int i = 0; i < a.Length; i++)
                    {

                        string[] b = a[i].ToString().Split(' ');
                        string filename = b[b.Length - 1];
                        string filetype = "";
                        if (a[i].IndexOf("DIR") != -1)
                        {
                            filetype = filename;
                        }
                        else
                        {
                            filetype = filename.Substring(filename.LastIndexOf("."), filename.Length - filename.LastIndexOf("."));
                        }
                        il.Images.Add(GetIconByFileType(filetype, true));
                        string[] info = new string[4];
                        FileInfo fi = new FileInfo(filename);
                        info[0] = fi.Name;
                        info[1] = GetFileSize(filename, ftpip, user, pwd, path).ToString();
                        if (a[i].IndexOf("DIR") != -1)
                        {
                            info[2] = "";
                            info[1] = "文件夹";
                        }
                        else
                        {
                            info[2] = GetFileSize(filename, ftpip, user, pwd, path).ToString();
                            info[1] = fi.Extension.ToString();
                        }
                        ListViewItem item = new ListViewItem(info, i);
                        lv.Items.Add(item);
                    }
                }
            }
            catch { }
        }

        public static string AllPath = "";
        public void GetPath(string path, ImageList imglist, ListView lv, int ppath)
        {
            string pp = "";
            string uu = "";
            if (ppath == 0)
            {
                if (AllPath != path)
                {
                    lv.Items.Clear();
                    AllPath = path;
                    GetListViewItem(AllPath, imglist, lv);
                }
            }
            else
            {
                uu = AllPath + path;
                if (Directory.Exists(uu))
                {
                    AllPath = AllPath + path + "\\";
                    pp = AllPath.Substring(0, AllPath.Length - 1);
                    lv.Items.Clear();
                    GetListViewItem(pp, imglist, lv);
                }
                else
                {
                    uu = AllPath + path;
                    System.Diagnostics.Process.Start(uu);
                }
            }
        }

        //返回服务器上级目录
        int k = 0;
        public void GOBack(ListView lv, ImageList il, string path)
        {

            if (AllPath.Length != 3)
            {
                string NewPath = AllPath.Remove(AllPath.LastIndexOf("\\")).Remove(AllPath.Remove(AllPath.LastIndexOf("\\")).LastIndexOf("\\")) + "\\";
                lv.Items.Clear();
                GetListViewItem(NewPath, il, lv);
                AllPath = NewPath;
            }
            else
            {
                if (k == 0)
                {
                    lv.Items.Clear();
                    GetListViewItem(path, il, lv);
                    k++;
                }
            }
        }

        //初始化路径
        public string Mpath()
        {
            string path = AllPath;
            return path;
        }

        //创建目录
        public void MakeDir(string dirName, string ftpServerIP, string ftpUserID, string ftpPassword)
        {
            try
            {
                string uri = "ftp://" + ftpServerIP + "/" + dirName;
                Connect(uri, ftpUserID, ftpPassword);//连接       
                reqFTP.Method = WebRequestMethods.Ftp.MakeDirectory;
                FtpWebResponse response = (FtpWebResponse)reqFTP.GetResponse();
                response.Close();
            }
            catch { }
        }

        //上传文件
        public bool Upload(string filename, string ftpServerIP, string ftpUserID, string ftpPassword, ToolStripProgressBar pb, string path)
        {
            if (path == null)
                path = "";
            bool success = true;
            FileInfo fileInf = new FileInfo(filename);
            int allbye = (int)fileInf.Length;
            int startbye = 0;
            pb.Maximum = allbye;
            pb.Minimum = 0;
            string newFileName;
            if (fileInf.Name.IndexOf("#") == -1)
            {
                newFileName = QCKG(fileInf.Name);
            }
            else
            {
                newFileName = fileInf.Name.Replace("#", "＃");
                newFileName = QCKG(newFileName);
            }
            string uri;
            if (path.Length == 0)
                uri = "ftp://" + ftpServerIP + "/" + newFileName;
            else
                uri = "ftp://" + ftpServerIP + "/" + path + newFileName;
            FtpWebRequest reqFTP;
            // 根据uri创建FtpWebRequest对象 
            reqFTP = (FtpWebRequest)FtpWebRequest.Create(new Uri(uri));
            // ftp用户名和密码 
            reqFTP.Credentials = new NetworkCredential(ftpUserID, ftpPassword);
            // 默认为true，连接不会被关闭 
            // 在一个命令之后被执行 
            reqFTP.KeepAlive = false;
            // 指定执行什么命令 
            reqFTP.Method = WebRequestMethods.Ftp.UploadFile;
            // 指定数据传输类型 
            reqFTP.UseBinary = true;
            // 上传文件时通知服务器文件的大小 
            reqFTP.ContentLength = fileInf.Length;
            int buffLength = 2048;// 缓冲大小设置为2kb 
            byte[] buff = new byte[buffLength];
            // 打开一个文件流 (System.IO.FileStream) 去读上传的文件 
            FileStream fs = fileInf.OpenRead();
            try
            {
                // 把上传的文件写入流 
                Stream strm = reqFTP.GetRequestStream();
                // 每次读文件流的2kb 
                int contentLen = fs.Read(buff, 0, buffLength);
                // 流内容没有结束 
                while (contentLen != 0)
                {
                    // 把内容从file stream 写入 upload stream 
                    strm.Write(buff, 0, contentLen);
                    contentLen = fs.Read(buff, 0, buffLength);
                    startbye += contentLen;
                    pb.Value = startbye;
                }
                // 关闭两个流 
                strm.Close();
                fs.Close();
            }
            catch
            {
                success = false;
            }
            return success;
        }

        //获取指定路径下所有文件及其图标
        public void GetListViewItem(string path, ImageList imglist, ListView lv)
        {
            lv.Items.Clear();
            Win32.SHFILEINFO shfi = new Win32.SHFILEINFO();
            try
            {
                string[] dirs = Directory.GetDirectories(path);
                string[] files = Directory.GetFiles(path);
                for (int i = 0; i < dirs.Length; i++)
                {
                    string[] info = new string[4];
                    DirectoryInfo dir = new DirectoryInfo(dirs[i]);
                    if (dir.Name == "RECYCLER" || dir.Name == "RECYCLED" || dir.Name == "Recycled" || dir.Name == "System Volume Information")
                    { }
                    else
                    {
                        //获得图标
                        Win32.SHGetFileInfo(dirs[i],
                                            (uint)0x80,
                                            ref shfi,
                                            (uint)System.Runtime.InteropServices.Marshal.SizeOf(shfi),
                                            (uint)(0x100 | 0x400)); //取得Icon和TypeName
                        //添加图标
                        imglist.Images.Add(dir.Name, (Icon)Icon.FromHandle(shfi.hIcon).Clone());
                        info[0] = dir.Name;
                        info[1] = "";
                        info[2] = "文件夹";
                        info[3] = dir.LastWriteTime.ToString();
                        ListViewItem item = new ListViewItem(info, dir.Name);
                        lv.Items.Add(item);
                        //销毁图标
                        Win32.DestroyIcon(shfi.hIcon);
                    }
                }
                for (int i = 0; i < files.Length; i++)
                {
                    string[] info = new string[4];
                    FileInfo fi = new FileInfo(files[i]);
                    string Filetype = fi.Name.Substring(fi.Name.LastIndexOf(".") + 1, fi.Name.Length - fi.Name.LastIndexOf(".") - 1);
                    string newtype = Filetype.ToLower();
                    if (newtype == "sys" || newtype == "ini" || newtype == "bin" || newtype == "log" || newtype == "com" || newtype == "bat" || newtype == "db")
                    { }
                    else
                    {


                        //获得图标
                        Win32.SHGetFileInfo(files[i],
                                            (uint)0x80,
                                            ref shfi,
                                            (uint)System.Runtime.InteropServices.Marshal.SizeOf(shfi),
                                            (uint)(0x100 | 0x400)); //取得Icon和TypeName
                        //添加图标
                        imglist.Images.Add(fi.Name, (Icon)Icon.FromHandle(shfi.hIcon).Clone());
                        info[0] = fi.Name;
                        info[1] = fi.Length.ToString();
                        info[2] = fi.Extension.ToString();
                        info[3] = fi.LastWriteTime.ToString();
                        ListViewItem item = new ListViewItem(info, fi.Name);
                        lv.Items.Add(item);
                        //销毁图标
                        Win32.DestroyIcon(shfi.hIcon);
                    }
                }
            }
            catch
            {
            }
        }

        //去除空格
        private string QCKG(string str)
        {
            string a = "";
            CharEnumerator CEnumerator = str.GetEnumerator();
            while (CEnumerator.MoveNext())
            {
                byte[] array = new byte[1];
                array = System.Text.Encoding.ASCII.GetBytes(CEnumerator.Current.ToString());
                int asciicode = (short)(array[0]);
                if (asciicode != 32)
                {
                    a += CEnumerator.Current.ToString();
                }
            }
            return a;
        }

        //从ftp服务器上获得文件列表
        public string[] GetFileList(string ftpServerIP, string ftpUserID, string ftpPassword)
        {
            string[] downloadFiles;
            StringBuilder result = new StringBuilder();
            FtpWebRequest reqFTP;
            try
            {
                reqFTP = (FtpWebRequest)FtpWebRequest.Create(new Uri("ftp://" + ftpServerIP));
                reqFTP.UseBinary = true;
                reqFTP.Credentials = new NetworkCredential(ftpUserID, ftpPassword);
                reqFTP.Method = WebRequestMethods.Ftp.ListDirectoryDetails;
                WebResponse response = reqFTP.GetResponse();
                StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.GetEncoding("GB2312"));
                string line = reader.ReadLine();
                while (line != null)
                {
                    result.Append(line);
                    result.Append("\n");
                    line = reader.ReadLine();

                }
                result.Remove(result.ToString().LastIndexOf('\n'), 1);
                reader.Close();
                response.Close();
                return result.ToString().Split('\n');
            }
            catch
            {
                downloadFiles = null;
                return downloadFiles;
            }
        }

        //获取文件大小
        public long GetFileSize(string filename, string ftpserver, string ftpUserID, string ftpPassword, string path)
        {
            long filesize = 0;
            try
            {
                FileInfo fi = new FileInfo(filename);
                string uri;
                if (path.Length == 0)
                    uri = "ftp://" + ftpserver + "/" + fi.Name;
                else
                    uri = "ftp://" + ftpserver + "/" + path + fi.Name;
                Connect(uri, ftpUserID, ftpPassword);
                reqFTP.Method = WebRequestMethods.Ftp.GetFileSize;
                FtpWebResponse response = (FtpWebResponse)reqFTP.GetResponse();
                filesize = response.ContentLength;
                return filesize;
            }
            catch
            {
                return 0;
            }
        }
    }
    #endregion
}
