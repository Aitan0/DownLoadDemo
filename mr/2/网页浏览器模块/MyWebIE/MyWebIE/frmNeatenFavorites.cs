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
        /// ��ȡ�ղؼ����е��ļ�
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
        /// ɾ��ָ�����ղ��ļ�
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count == 0)             //�ж��Ƿ�ѡ����Ŀ
            { }
            else
            {
                //��ȡѡ�����·��
                string Path = path + "\\" + listBox1.SelectedItem.ToString();
                //��ȡѡ����Ŀ����չ��
                string Stype = Path.Substring(Path.LastIndexOf(".") + 1);
                if (Stype == "url")                             //�����չ��Ϊ��url��
                {
                    FileInfo info = new FileInfo(Path);         //����ѡ�����·��ʵ����FileInfo
                    info.Delete();                              //Ȼ�����FileInfo���Delete��������ɾ��  
                    listBox1.Items.Clear();                     //���ListBox�ؼ�����Ŀ
                    scan(path);                                 //���±����ղؼ�
                }
                else
                { }
            }
        }
        /// <summary>
        /// �ر�
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// ��ȡ�ղؼ�·��
        /// </summary>
        public string path = Environment.GetFolderPath(Environment.SpecialFolder.Favorites);
        private void frmNeatenFavorites_Load(object sender, EventArgs e)
        {
            scan(path);
        }
    }
}