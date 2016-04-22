using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using IWshRuntimeLibrary;
using System.IO;
namespace MyWebIE
{
    public partial class frmNeatenFavorites : Form
    {
        public frmNeatenFavorites()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 获取收藏夹所有的文件
        /// </summary>
        /// <param name="Dpath"></param>
        private void scan(string Dpath)
        {
            DirectoryInfo DInfo = new DirectoryInfo(Dpath);
            FileSystemInfo[] FSInfo = DInfo.GetFiles();
            for (int i = 0; i < FSInfo.Length; i++)
            {
                listBox1.Items.Add(FSInfo[i].ToString());
            }
        }
        /// <summary>
        /// 删除指定的收藏文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count == 0)             //判断是否选择项目
            { }
            else
            {
                //获取选择项的路径
                string Path = path + "\\" + listBox1.SelectedItem.ToString();
                //获取选择项目的扩展名
                string Stype = Path.Substring(Path.LastIndexOf(".") + 1);
                if (Stype == "url")                             //如果扩展名为“url”
                {
                    FileInfo info = new FileInfo(Path);         //根据选择项的路径实例化FileInfo
                    info.Delete();                              //然后调用FileInfo类的Delete方法进行删除  
                    listBox1.Items.Clear();                     //清空ListBox控件的项目
                    scan(path);                                 //重新遍历收藏夹
                }
                else
                { }
            }
        }
        /// <summary>
        /// 关闭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// 获取收藏夹路径
        /// </summary>
        public string path = Environment.GetFolderPath(Environment.SpecialFolder.Favorites);
        private void frmNeatenFavorites_Load(object sender, EventArgs e)
        {
            scan(path);
        }
    }
}