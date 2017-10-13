using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace Oantuxi_Server
{
    class Program
    {
        static void Main(string[] args)
        {
            IPEndPoint ipServer = new IPEndPoint(IPAddress.Any, 12345);
            UdpClient server = new UdpClient(ipServer);

            IPEndPoint ipClient = new IPEndPoint(IPAddress.Any, 0);
            byte[] rec = server.Receive(ref ipClient);
        }
    }
}
