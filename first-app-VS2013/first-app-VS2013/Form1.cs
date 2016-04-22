using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;


namespace first_app_VS2013
{
    public partial class Form1 : Form
    {
        //设置全局串口名称
        static string portname;
        //建立委托，使用委托接收串口数据
        public delegate void rece(List<byte> temp);
        //建立委托函数
        public rece recemes;
        public first1 xxxx = new first1();
       
        
      
        
        
        
        

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // in this select open or close com;
            if (serialPort1.IsOpen)
            {
                //if the com is open,close it,and set the different font
                serialPort1.Close();
                this.button1.Text = "Open Com";
                this.button1.Font = new Font("宋体", 12);
            }
            else
            {
                //if the com is close,open it with,9600,8,1,none,and then set the different font
                serialPort1.PortName = portname;
                serialPort1.BaudRate = 9600;
                serialPort1.StopBits = System.IO.Ports.StopBits.One;
                serialPort1.DataBits = 8;
                serialPort1.Parity = System.IO.Ports.Parity.None;
                serialPort1.Open();
                this.button1.Text = "Close Com";
                this.button1.Font = new Font("黑体", 12);
            }



        }

        public void Form1_Load(object sender, EventArgs e)
        {
            //this is  allow the form receive the keyborad message,only open this,the key event is valid 
            this.KeyPreview = true;
            //list the com list in present computer,then send the list into combbox;
            //and last set the first value as the default selectedvalue
            string[] port;
            port = SerialPort.GetPortNames();
            xxxx.Baudrate = 9600;
            for (int i = 0; i < port.Length; i++)
            {
                this.comboBox1.Items.Add(port[i]);
                this.comboBox1.SelectedIndex = 0;
                portname = this.comboBox1.SelectedItem.ToString();

            }
            //define the event
            recemes = delegate(List<byte> temp)
            {

                string tem = "";
                for (int i = 0; i < temp.Count; i++)
                {
                    tem += Convert.ToString(temp[i], 16);
                }
                textBox1.Text = tem;

            };

           

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if the com changed,need change the portname with the selected 
            portname = this.comboBox1.SelectedText;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            //if (serialPort1.IsOpen)
            //{
            //    int index = 0;
            //    byte[] sear = new byte[] { 0x06, 0x50, 0x60 };
            //    string searchstr = sear[0].ToString("X2") + sear[1].ToString("X2") + sear[2].ToString("X2");
            //    byte[] mode1 = new byte[] { 0x02, 0x10, 0x60, 0xff, 0xff, 0xff, 0xff, 0xff };
            //    serialPort1.Write(mode1, 0, 8);
            //    if (this.textBox1.Text.Length > 1)
            //    {
            //        index = this.textBox1.Text.IndexOf(searchstr);
            //        if (index < 0)
            //        {
            //            MessageBox.Show("出现错误，请检查");
            //        }
            //        else
            //        {
            //            System.Threading.Thread.Sleep(100);
            //            mode1[0] = 0x02;
            //            mode1[1] = 0x11;
            //            mode1[2] = 0x03;
            //            mode1[3] = 0xff;
            //            mode1[4] = 0xff;
            //            mode1[5] = 0xff;
            //            mode1[6] = 0xff;
            //            mode1[7] = 0xff;
            //            serialPort1.Write(mode1, 0, 8);

            //            System.Threading.Thread.Sleep(100);
            //            sear[0] = 0x06;
            //            sear[1] = 0x67;
            //            sear[2] = 0x05;
            //            searchstr = sear[0].ToString("X2") + sear[1].ToString("X2") + sear[2].ToString("X2");
            //            index = this.textBox1.Text.IndexOf(searchstr);
            //            if (index < 0)
            //            {
            //                MessageBox.Show("出现错误，请检查");
            //            }
            //            else
            //            {
            //                sendsecuritry(this.textBox1.Text, index);
            //            }


            //        }


            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Please Open Com At First!", "Warn Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}

          Form1 p = new Form1();
               //    Thread testthread = new Thread(new ThreadStart(p.send)); 
          Thread testthread = new Thread(new ThreadStart(
          delegate
          {
              send();
          }));
            testthread.Start();
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            List<byte> temp = new List<byte>();
            int count;
            System.Threading.Thread.Sleep(50);
            count = serialPort1.ReadBufferSize;
            byte[] tem = new byte[count];
            serialPort1.Read(tem, 0, count);
            this.Invoke(recemes);


        }
        public void sendsecuritry(string message, int index)
        {
            string temp;
            Int64 sh, sl, ss;
            Int64 pin = 2271560481;
            byte[] tem = new byte[4];
            byte[] tem2 = new byte[4];
            temp = message.Substring(index, 4);

            tem = System.Text.Encoding.GetEncoding(28591).GetBytes(temp);

            sh = tem[0] * 256 + tem[1];

            sl = tem[2] * 256 + tem[3];

            sh = sh * 36125 + 12343;
            sl = sl * 32125 + 12343;
            ss = sh ^ sl ^ pin;

            tem2[0] = (byte)(ss / (256 * 256 * 256));
            tem2[1] = (byte)((ss % (256 * 256 * 256)) / (256 * 256));
            tem2[2] = (byte)((ss % (256 * 256) / 256));
            tem2[3] = (byte)(ss % 256);
            byte[] sendsecr = new byte[8];
            sendsecr[0] = 0x06;
            sendsecr[1] = 0x27;
            sendsecr[2] = 0x06;
            sendsecr[3] = tem2[0];
            sendsecr[4] = tem2[1];
            sendsecr[5] = tem2[2];
            sendsecr[6] = tem2[3];
            sendsecr[7] = 0xff;
            serialPort1.Write(sendsecr, 0, 8);
            System.Threading.Thread.Sleep(100);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult quit = DialogResult.OK;
                if (quit == MessageBox.Show("Are you sure to quit this app?", "warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning))
                {
                    Application.Exit();

                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Escape")
            {
                DialogResult quit = DialogResult.OK;
                if (quit == MessageBox.Show("Are you sure to quit this app?", "warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning))
                {
                   
                    Application.Exit();

                }
                else
                {

                }
            }
        }
        public void send()
        {
            if (serialPort1.IsOpen)
            {
                int index = 0;
                byte[] sear = new byte[] { 0x06, 0x50, 0x60 };
                string searchstr = sear[0].ToString("X2") + sear[1].ToString("X2") + sear[2].ToString("X2");
                byte[] mode1 = new byte[] { 0x02, 0x10, 0x60, 0xff, 0xff, 0xff, 0xff, 0xff };
                serialPort1.Write(mode1, 0, 8);
                if (this.textBox1.Text.Length > 1)
                {
                    index = this.textBox1.Text.IndexOf(searchstr);
                    if (index < 0)
                    {
                        MessageBox.Show("出现错误，请检查");
                    }
                    else
                    {
                        System.Threading.Thread.Sleep(100);
                        mode1[0] = 0x02;
                        mode1[1] = 0x11;
                        mode1[2] = 0x03;
                        mode1[3] = 0xff;
                        mode1[4] = 0xff;
                        mode1[5] = 0xff;
                        mode1[6] = 0xff;
                        mode1[7] = 0xff;
                        serialPort1.Write(mode1, 0, 8);

                        System.Threading.Thread.Sleep(100);
                        sear[0] = 0x06;
                        sear[1] = 0x67;
                        sear[2] = 0x05;
                        searchstr = sear[0].ToString("X2") + sear[1].ToString("X2") + sear[2].ToString("X2");
                        index = this.textBox1.Text.IndexOf(searchstr);
                        if (index < 0)
                        {
                            MessageBox.Show("出现错误，请检查");
                        }
                        else
                        {
                            sendsecuritry(this.textBox1.Text, index);
                        }


                    }


                }
                else
                {
                    MessageBox.Show("Please Open Com At First!", "Warn Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }
    }
}

