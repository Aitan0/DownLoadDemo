using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;
namespace MyWebIE
{
    public partial class frmSource : Form
    {
        public frmSource()
        {
            InitializeComponent();
        }
        public string address;
        private void frmSource_Load(object sender, EventArgs e)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(address);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader objReader = new StreamReader(response.GetResponseStream(), Encoding.Default);
            this.richTextBox1.Text = objReader.ReadToEnd();// 这个获取网页代码
            response.Close();
        }
    }
}