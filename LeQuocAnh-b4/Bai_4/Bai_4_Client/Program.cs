using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Diagnostics;

namespace Bai_4_Client
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] data = new byte[1024];
            String input, stringData;
            IPEndPoint ip = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9050);
            TcpClient server;
            try
            {
                server = new TcpClient();
            }
            catch (SocketException)
            {
                Console.WriteLine("Unable to connect to server!");
                return;
            }
            server.Connect(ip);
            NetworkStream ns = server.GetStream();

            int recv = ns.Read(data, 0, data.Length);
            stringData = Encoding.ASCII.GetString(data, 0, recv);
            if (stringData == "shutdown")
            {
                Process.Start("shutdown", "/s /t 0");
            }
            if (stringData == "restart")
            {
                Process.Start("shutdown", "/r /t 0");
            }
        }
    }
}
