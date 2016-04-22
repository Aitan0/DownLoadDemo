using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace study_and_test
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
        private static extern bool AnimateWindow(IntPtr hwnd, int dwTime, int dwFlags);
        public Form t2 = new Form();
        delegate double ProcessDelegate(double parm1, double parm2);

        public Form1()
        {
            InitializeComponent();
        }
        static double Multiply(double parm1,double parm2)
        {
            return parm1 * parm2;
        }
        static double Divide(double parm1,double parm2)
        {
            return parm1 / parm2;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            t2.Name = "this is a new form";
            t2.Text = "unname title";
            t2.Location = new Point(200, 200);
            t2.Size = new System.Drawing.Size(400, 400);
            t2.StartPosition = FormStartPosition.CenterParent;
            Button ok = new Button();
            ok.Location = new Point(20, 10);
            ok.Text = "test";
            ok.Click += ok_Click;
            ok.MouseEnter += ok_MouseEnter;
            t2.Controls.Add(ok);
            t2.Load += t2_Load;
            
            t2.Show();
        }

        void t2_Load(object sender, EventArgs e)
        {
            AnimateWindow(t2.Handle, 1000, 0x40002);
            ToolStripMenuItem tsmadd = new ToolStripMenuItem("File");
           
            t2.MainMenuStrip.Items.Add(tsmadd);
            

           // throw new NotImplementedException();
        }

        void ok_MouseEnter(object sender, EventArgs e)
        {
            Button ok = new Button();
            ok.Text = "Enter";
            ok.BackColor = Color.Red;
            this.Controls.Add(ok);
           
            //throw new NotImplementedException();
        }

        void ok_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hahhahhahha");
            ProcessDelegate process;
            double parm1 = 2.0;
            double parm2 = 5.0;
            process = new ProcessDelegate(Multiply);
            double result = process(parm1, parm2);
            MessageBox.Show(result.ToString(), "The result is");

            //throw new NotImplementedException();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AnimateWindow(this.Handle, 1000, 0x40002);
        }
    }
}
