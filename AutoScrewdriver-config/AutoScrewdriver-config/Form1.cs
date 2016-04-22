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
using System.IO;


namespace fileRW
{
    public partial class AutoScrew : Form
    {
        string portname;
        public DataTable dt = new DataTable();
       
        public AutoScrew()
        {
            InitializeComponent();
        }

        private void AutoScrew_Load(object sender, EventArgs e)
        {
            string path = Application.StartupPath;
            path += "\\config.ini";
            string[] port = SerialPort.GetPortNames();
            dt.Columns.Add("序号");
            dt.Columns.Add("Min");
            dt.Columns.Add("Max");
            dataGridView1.DataSource = dt;

            for(int i=0;i<port.Length;i++)
            {
                this.Comnum.Items.Add(port[i]);
                this.Comnum.SelectedIndex = 0;
                portname = this.Comnum.SelectedItem.ToString();
            }
            this.Baud.Items.Add(9600);
            this.Baud.Items.Add(19200);
            this.Baud.Items.Add(38400);
            this.Baud.Items.Add(57600);
            this.Baud.Items.Add(115200);
            
            this.Data.Items.Add(5);
            this.Data.Items.Add(6);
            this.Data.Items.Add(7);
            this.Data.Items.Add(8);
            
            this.Parit.Items.Add(Parity.Even);
            this.Parit.Items.Add(Parity.Mark);
            this.Parit.Items.Add(Parity.None);
            this.Parit.Items.Add(Parity.Odd);
            this.Parit.Items.Add(Parity.Space);
            
            this.stop.Items.Add(StopBits.None);
            this.stop.Items.Add(StopBits.One);
            this.stop.Items.Add(StopBits.OnePointFive);
            this.stop.Items.Add(StopBits.Two);
            
           
            if (File.Exists(path))
            {
                StringBuilder strb=new StringBuilder(512);
               // int temp;
                ini.GetPrivateProfileString("Com", "comname", "", strb, 16,path);
                this.Comnum.SelectedItem = strb.ToString();
             this.Baud.SelectedItem=   ini.GetPrivateProfileInt("Com", "BaudRate", 512, path);
             this.Data.SelectedItem = ini.GetPrivateProfileInt("Com", "DataBits", 512, path);
             ini.GetPrivateProfileString("Com", "stop", "", strb, 16, path);
            // this.stop.SelectedItem = strb.ToString();
                switch(strb.ToString())
                {
                    case "None":
                        this.stop.SelectedItem = StopBits.None;
                        break;
                    case "One":
                        this.stop.SelectedItem = StopBits.One;
                        break;
                    case "OnePointFive":
                        this.stop.SelectedItem = StopBits.OnePointFive;
                        break;
                    case "Two":
                        this.stop.SelectedItem = StopBits.Two;
                        break;
                    default:
                        this.stop.SelectedItem = StopBits.One;
                        break;
                       

                }
             ini.GetPrivateProfileString("Com", "parity", "", strb, 16, path);
           //  this.Parit.SelectedItem = strb.ToString();
             switch (strb.ToString())
             {
                 case "None":
                     this.Parit.SelectedItem = Parity.None;
                     break;

                 case "Even":
                     this.Parit.SelectedItem = Parity.Even;
                     break;
                 case "Mark":
                     this.Parit.SelectedItem = Parity.Mark;
                     break;
                 case "Odd":
                     this.Parit.SelectedItem = Parity.Odd;
                     break;
                 case "Space":
                     this.Parit.SelectedItem = Parity.Space;
                     break;
                 default:
                     this.Parit.SelectedItem = Parity.None;
                     break;


             }
           this.Mod1.Value = ini.GetPrivateProfileInt("Com", "Mod1addr", 512, path);
           this.Mod2.Value = ini.GetPrivateProfileInt("Com", "Mod2addr", 512, path);
           this.dataGridView1.DataSource = dt;
           this.amount.Value = ini.GetPrivateProfileInt("Position", "amount", 512, path);
         // this.dataGridView1.RowCount = Convert.ToInt32(this.amount.Value);
                
                for(int i=0;i<this.amount.Value;i++)
                {
                    DataRow dr = dt.NewRow();
                    dt.Rows.Add(dr);
                    int sn;
                    int min, max;
                   sn= ini.GetPrivateProfileInt("Position", i.ToString() + "sn", 512, path);
                   min = ini.GetPrivateProfileInt("Position", i.ToString() + "min", 512, path);
                   max = ini.GetPrivateProfileInt("Position", i.ToString() + "max", 512, path);
                   this.dataGridView1.Rows[i].Cells[0].Value = sn;
                   this.dataGridView1.Rows[i].Cells[1].Value = min;
                   this.dataGridView1.Rows[i].Cells[2].Value = max;
                }

            }
            else
            {
                FileStream temp = File.Create(path);
                temp.Close();
                this.Baud.SelectedIndex = 0;
                this.Data.SelectedIndex = 3;
                this.Data.SelectedIndex = 3;
                this.Parit.SelectedIndex = 2;
                this.stop.SelectedIndex = 1;

            }
            
        }

        private void OK_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath;
            path += "\\config.ini";
            if(File.Exists(path))
            {

            }
            else
            {
                FileStream temp = File.Create(path);
                temp.Close();
            }
            string comname, buad, data, parity, stop, mod1addr, mod2addr, amounts;
            comname = this.Comnum.SelectedItem.ToString();
            buad = this.Baud.SelectedItem.ToString();
            data = this.Data.SelectedItem.ToString();
            parity = this.Parit.SelectedItem.ToString();
            stop = this.stop.SelectedItem.ToString();
            mod1addr = this.Mod1.Value.ToString();
            mod2addr = this.Mod2.Value.ToString();
            amounts = this.amount.Value.ToString();
            ini.WritePrivateProfileString("Com", "comname", comname, path);
            ini.WritePrivateProfileString("Com", "BaudRate", buad, path);
            ini.WritePrivateProfileString("Com", "DataBits", data, path);
            ini.WritePrivateProfileString("Com", "stop", stop, path);
            ini.WritePrivateProfileString("Com", "parity", parity, path);
            ini.WritePrivateProfileString("Com", "Mod1addr", mod1addr, path);
            ini.WritePrivateProfileString("Com", "Mod2addr", mod2addr, path);
            ini.WritePrivateProfileString("Position", "amount", amounts, path);
            for(int i=0;i<dt.Rows.Count;i++)
            {
                string sn,min, max;
                sn = this.dataGridView1.Rows[i].Cells[0].Value.ToString();
                min=this.dataGridView1.Rows[i].Cells[1].Value.ToString();
                max = this.dataGridView1.Rows[i].Cells[2].Value.ToString();
                ini.WritePrivateProfileString("Position", i.ToString() + "sn", sn, path);
                ini.WritePrivateProfileString("Position", i.ToString() + "min", min, path);
                ini.WritePrivateProfileString("Position", i.ToString() + "max", max, path);
            }


        }

        private void Test_Click(object sender, EventArgs e)
        {
            serialPort1.PortName = this.Comnum.SelectedItem.ToString();
            serialPort1.BaudRate = Convert.ToInt32(this.Baud.SelectedItem.ToString());
            serialPort1.DataBits = Convert.ToInt16(this.Data.SelectedItem.ToString());
            switch (this.stop.SelectedItem.ToString())
            {
                case "None":
                    serialPort1.StopBits = StopBits.None;
                    break;
                case "One":
                    serialPort1.StopBits = StopBits.One;
                    break;
                case "OnePointFive":
                    serialPort1.StopBits = StopBits.OnePointFive;
                    break;
                case "Two":
                    serialPort1.StopBits = StopBits.Two;
                    break;
                default:
                    serialPort1.StopBits = StopBits.One;
                    break;


            }
            switch (this.Parit.SelectedItem.ToString())
            {
                case "None":
                   serialPort1.Parity = Parity.None;
                    break;

                case "Even":
                    serialPort1.Parity = Parity.Even;
                    break;
                case "Mark":
                    serialPort1.Parity = Parity.Mark;
                    break;
                case "Odd":
                    serialPort1.Parity = Parity.Odd;
                    break;
                case "Space":
                    serialPort1.Parity = Parity.Space;
                    break;
                default:
                    serialPort1.Parity = Parity.None;
                    break;


            }
            serialPort1.Open();
            string temp;
            int len;

            temp = "$"+this.Mod1.Value.ToString()+"M\r\n";
            try { 
            serialPort1.WriteLine(temp);
                
                }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            System.Threading.Thread.Sleep(50);
           len = serialPort1.ReadBufferSize;
           if (len > 0)
           {
               byte[] rece = new byte[len];
               serialPort1.Read(rece, 0, len);
               this.listBox1.Items.Add(Convert.ToString(rece));

           }
           else
               MessageBox.Show("Mod1 Comm Fail", "Warning");
           temp = "$0" + this.Mod2.Value.ToString() + "M\r\n";
           serialPort1.WriteLine(temp);
           System.Threading.Thread.Sleep(50);
           len = serialPort1.ReadBufferSize;
           if (len > 0)
           {
               byte[] rece = new byte[len];
               serialPort1.Read(rece, 0, len);
               this.listBox1.Items.Add(Convert.ToString(rece));

           }
           else
               MessageBox.Show("Mod2 Comm Fail", "Warning");

          // Application.Exit();

        }

        private void amount_ValueChanged(object sender, EventArgs e)
        {
            //int temp = Decimal.ToInt32(this.amount.Value);
            //int temp1 = this.dataGridView1.RowCount;
            //int x = temp - temp1;
            //int y = temp1 - temp;
            //dataGridView1.DataSource = dt;
            //DataRow dr = dt.NewRow();

            //if (x > 0)
            //{
            //    for (int i = 0; i < x; i++)
            //    {
            //        dr[0] = (temp1 + i).ToString();
            //        dt.Rows.Add(dr);
            //    }
            //}
            //if (y > 0)
            //{
            //    for (int i = 0; i < y; i++)
            //    {
            //        // dr[0] = temp.ToString();

            //        // dt.Rows.Remove(dr);
            //        temp1--;
            //        temp1--;
            //        //  dt.Rows.RemoveAt(temp1);
            //        dt.Rows[temp1 - i].Delete();
            //    }

            //}

        }
    }
}
