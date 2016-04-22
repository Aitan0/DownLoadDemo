using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace NetCommunitiesServer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public static int senddata(Socket s, byte[] data)
        {
            int total = 0;
            int len = data.Length;
            int dataleft = len;
            int sent;
            while(total<len)
            {
                sent = s.Send(data, total, SocketFlags.None);
                total += sent;
                dataleft -= sent;
            }

            return total;
        }
        public static byte[] receiveddata(Socket s, int size)
        {
            int total = 0;
            int dataleft = size;
            byte[] data = new byte[size];
            int rece;
            while (total < size)
            {
                rece = s.Receive(data, total, dataleft, 0);
if(rece==0)
{
    data = Encoding.ASCII.GetBytes("exit");
    break;
}
total += rece;
dataleft -= rece;
            }

            return data;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte[] data = new byte[1024];
            IPAddress ip=IPAddress.Parse("127.0.0.1");
            IPEndPoint ipes = new IPEndPoint(ip, 9050);
            Socket soc = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            soc.Bind(ipes);
            soc.Listen(10);
            this.textBox1.AppendText("Wait for a client...\r\n");
            Socket client = soc.Accept();
            IPEndPoint newclient = (IPEndPoint)client.RemoteEndPoint;
            this.textBox1.AppendText("Connected With" + newclient.Address.ToString() + "At Port" + newclient.Port.ToString());
            string str = "Welcome To My TestServer\r\n";
            data = Encoding.ASCII.GetBytes(str);
            int sent = senddata(client, data);
            for(int i=0;i<5;i++)
            {
                data = receiveddata(client, 9);
                
            }
            this.textBox1.AppendText(Encoding.ASCII.GetString(data)+"\r\n");
            this.textBox1.AppendText( "Disconnected from server...\r\n");
            client.Close();
            soc.Close();


        }
    }

   


}
