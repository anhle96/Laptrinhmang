using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace Multicast_nhan
{
    class Program
    {
        public static void Main(string[] args)
        {
            Socket sock = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            Console.WriteLine("Ready to Recieve..");
            IPEndPoint iep = new IPEndPoint(IPAddress.Any, 9050);
            EndPoint ep = (Endpoint)iep;
            sock.Bind(iep);
            sock.SetSocketOption(SocketOptionLevel.IP, SocketOptionName.AddMembership, new MulticastOption(IPAddress.Parse("224.100.0.1")));
            byte[] data = new byte[1024];
            int recv = sock.EndReceiveFrom(data, ref ep);
            string stringData = Encoding.ASCII.GetString(data, 0, recv);
            Console.WriteLine("recevied: {0} from : {1}", stringData, ep.ToString());
            sock.Close();
        }
    }
}
