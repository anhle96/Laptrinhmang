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

namespace Oantuxi_Client
{
    public partial class Form1 : Form
    {
        Socket client;
        IPEndPoint ipep;
        EndPoint remote;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            client = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            ipep = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9050);
            remote = (EndPoint)ipep;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Keo";
            int a = 0;
            byte[] gui = BitConverter.GetBytes(a);
            client.SendTo(gui, remote);

            byte[] rec = new byte[20];
            remote = (EndPoint)ipep;
            client.ReceiveFrom(rec, ref remote);
            textBox2.Text = Encoding.ASCII.GetString(rec);

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
