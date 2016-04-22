using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReadHBMclass
{
    public partial class HBMtestDemo : Form
    {
        public string error;
        public HBMtestDemo()
        {
            InitializeComponent();
        }
        public ReadHBM TestDemo = new ReadHBM();

        private void button1_Click(object sender, EventArgs e)
        {
            TestDemo.Init(out error);
            AddTolog(error);
            AddTolog("Init...");
            while (!TestDemo.Scan(out error))
            {
                System.Threading.Thread.Sleep(1000);
                AddTolog(error);
                AddTolog("Scan...");
            }
            TestDemo.Connect(out error);
            AddTolog(error);
            AddTolog("Scan ok");

        }
        public void AddTolog(string message)
        {
            this.textBox2.AppendText(message+"\n");
        }
    }
}
