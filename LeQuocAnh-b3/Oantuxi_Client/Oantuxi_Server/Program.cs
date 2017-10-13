using System;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace Oantuxi_Server
{
    class Program
    {
        static void Main(string[] args)
        {
            IPEndPoint ipep = new IPEndPoint(IPAddress.Any, 9050);
            Socket server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            server.Bind(ipep);
            Console.WriteLine("Waiting for a client...");

            IPEndPoint sender = new IPEndPoint(IPAddress.Any, 0);
            EndPoint Remote = (EndPoint)(sender);

            byte[] data = new byte[4];
            server.ReceiveFrom(data, ref Remote);
            int clientChoosen = BitConverter.ToInt32(data, 0);
            Random rand = new Random();
            int serverChoosen = rand.Next(0, 2);
            if (clientChoosen == serverChoosen)
            {
                byte[] gui = Encoding.ASCII.GetBytes("Hoa");
                server.SendTo(gui, Remote);
            }
            if (clientChoosen == 0 && serverChoosen == 1)
            {
                byte[] gui = Encoding.ASCII.GetBytes("Thua");
            }
            if (clientChoosen == 0 && serverChoosen == 2)
            {
                byte[] gui = Encoding.ASCII.GetBytes("Thang");
            }
            if (clientChoosen == 1 && serverChoosen == 0)
            {
                byte[] gui = Encoding.ASCII.GetBytes("Thang");
            }
            if (clientChoosen == 1 && serverChoosen == 2)
            {
                byte[] gui = Encoding.ASCII.GetBytes("Thua");
            }
            if (clientChoosen == 2 && serverChoosen == 0)
            {
                byte[] gui = Encoding.ASCII.GetBytes("Thua");
            }
            if (clientChoosen == 2 && serverChoosen == 1)
            {
                byte[] gui = Encoding.ASCII.GetBytes("Thang");
            }
            server.Close();
        }
    }
}
