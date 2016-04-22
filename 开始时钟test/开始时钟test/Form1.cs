using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 开始时钟test
{
    public partial class Form1 : Form
    {
        Bitmap paintImage; //用来缓冲画图的区域
        public Graphics paintDevice;

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int second;
            int minute;
            int hour;
            this.label1.Text = System.DateTime.Now.ToLongDateString() + "  " + System.DateTime.Now.ToLongTimeString();
            second = System.DateTime.Now.Second;
            minute = System.DateTime.Now.Minute;
            hour = System.DateTime.Now.Hour;
            paintDevice.DrawLine(new Pen(Color.Red, 5), new Point(150, 150), new Point(150, 50));
            paintDevice.DrawLine(new Pen(Color.Yellow, 7), new Point(150, 150), new Point(250, 230));
            paintDevice.DrawLine(new Pen(Color.Blue, 10), new Point(150, 150), new Point(150, 200));
            this.pictureBox1.Image = paintImage;
            this.pictureBox1.Refresh();
            //Graphics time = this.pictureBox1.CreateGraphics();
            //time.DrawLine(new Pen(Color.Red, 15), new Point(200, 50), new Point(50, 800));
            
            //this.pictureBox1.Refresh();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.timer1.Interval = 1000;
            this.timer1.Enabled = true;
            paintImage = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            paintDevice = Graphics.FromImage(paintImage);

          

        }
    }
}
