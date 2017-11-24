using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace Broadcast_Nhan
{
    class Program
    {
        public static void Main(string[] args)
        {
            Socket sock = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            IPEndPoint iep = new IPEndPoint(IPAddress.Any, 9050);
            sock.Bind(iep);
            EndPoint ep = (EndPoint)iep;
            Console.WriteLine("Readt to recieve...");
            byte[] data = new byte[1024];
            int recv = sock.ReceiveFrom(data, ref ep);
            string stringData = Encoding.ASCII.GetString(data, 0, recv);
            Console.WriteLine("Received: {0} from {1}", stringData, ep.ToString());
            data = new byte[1024];
            recv = sock.EndReceiveFrom(data, ref ep);
            stringData = Encoding.ASCII.GetString(data, 0, recv);
            Console.WriteLine("recevied: {0} from: {1}", stringData, ep.ToString());
            sock.Close()
;        }
    }
}
