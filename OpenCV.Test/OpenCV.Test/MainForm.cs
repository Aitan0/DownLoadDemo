using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.Util;
using Emgu.CV.UI;
using Emgu.CV.CvEnum;
using System.Threading;
using System.Diagnostics;
using SURFFeatureExample;


namespace OpenCV.Test
{
    public partial class MainForm : Form
    {
        bool CaptureStatus = false;
        Capture Capsession = null;
        Thread CapThread;
        bool ThreadFlag = false;
        Mat frame = new Mat();
        long matchtime;
        Mat model = CvInvoke.Imread("model.png", LoadImageType.Grayscale);
        Mat result;
       public  ImageBox imagebox1 = new ImageBox();
       
        Stopwatch sw1; 

        public MainForm()
        {
            InitializeComponent();
          
        }

        private void start_Click(object sender, EventArgs e)
        {
            if(ThreadFlag)
            {
                CapThread.Abort();
                CaptureStatus=false;
                start.Text = "Start";
                ThreadFlag = false;
            }
            else
            {

                CapThread = new Thread(new ThreadStart(ProcessCap));
                CaptureStatus=true;
                CapThread.Start();
                start.Text = "Stop";
                ThreadFlag = true;
            }

        }

        public void ProcessCap()
        {
           //hrow new NotImplementedException();
            if(Capsession!=null)
            {
                Capsession.Start();
                while(ThreadFlag)
                {
                  //  frame = Capsession.QueryFrame();
                    Capsession.Retrieve(frame, 0);
               //   imagebox1.Width = frame.Width * 2 / 3;
             //    imagebox1.Height=frame.Height*2/3;
                    if (checkBox1.Checked == true)
                    {
                        //   imagebox1.Image = frame;
                        result = DrawMatches.Draw(model, frame, out matchtime);
                        imagebox1.Image = result;
                        toolStripStatusLabel1.Text=string.Format("the matchtime is {0},the result is {1}",matchtime.ToString(),result.ToString());
                    }
                    else
                        imagebox1.Image = frame;
                }
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                Capsession = new Emgu.CV.Capture();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Capsession.SetCaptureProperty(Emgu.CV.CvEnum.CapProp.Fps, 5);
            Capsession.SetCaptureProperty(Emgu.CV.CvEnum.CapProp.FrameHeight,640);
            Capsession.SetCaptureProperty(Emgu.CV.CvEnum.CapProp.FrameWidth,480);
            imagebox1.Location = new Point(100, 10);
            imagebox1.Height = 640;
            imagebox1.Width = 480;
            imagebox1.ContextMenuStrip = contextMenuStrip1;
            
            this.Controls.Add(imagebox1);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
           if(ThreadFlag)
           {
               start_Click(this, null);
           }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog savedata = new SaveFileDialog();
            savedata.Filter = "图片文件.jpg(*.jpg)|*.jpg";
            savedata.Title = "保存当前图片";
            savedata.FilterIndex = 0;
            string localpath;
            if(savedata.ShowDialog()==DialogResult.OK)
            {
                localpath = savedata.FileName.ToString();
                imagebox1.Image.Save(localpath);
            }
       }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            imagebox1.ClearOperation();

        }

        private void 旋转ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void 处理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

   
    }
}
