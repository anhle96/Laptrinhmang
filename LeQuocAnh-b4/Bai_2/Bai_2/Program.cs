using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace Bai_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string IpAddress;
            int port;
            string protocol;
            Console.WriteLine("Nhap Host IP:");
            IpAddress = Console.ReadLine();
            Console.WriteLine("Nhap Host Port");
            port = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap Protocol:");
            protocol = Console.ReadLine();

            switch (protocol)
            {
                case "TCP":
                    IPEndPoint ip = new IPEndPoint(IPAddress.Parse(IpAddress), port);
                    TcpClient client = new TcpClient();
                    try
                    {
                        client.Connect(ip);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Host: {0}:{1} is close", IpAddress, port);
                        Console.WriteLine(ex);
                        Environment.Exit(0);
                    }
                    Console.WriteLine("Host: {0}:{1} is open", IpAddress, port);
                    break;
                case "UDP":

                    break;
            }
        }
    }
}
