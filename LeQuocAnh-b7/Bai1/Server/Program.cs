using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;
using System.Threading;

namespace Server
{
    class Program
    {
        static Socket listen;
        static Socket client;
        static IPEndPoint ipe;
        static int connections = 0;
        static void Main(string[] args)
        {
            listen = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            ipe = new IPEndPoint(IPAddress.Any, 9050);
            listen.Bind(ipe);
            listen.Listen(10);
            Console.WriteLine("Waiting for clients...");
            while (true)
            {
                if (listen.Poll(100000, SelectMode.SelectWrite))
                {
                    client = listen.Accept();
                    Thread newthreat = new Thread(new ThreadStart(HandleConnetion));
                    newthreat.Start();
                }
            }
        }
        static void HandleConnetion()
        {
            int recv;
            byte[] data = new byte[1024];
            NetworkStream ns = new NetworkStream(client);
            connections++;
            Console.WriteLine("New client accepted: {0} active connections",connections);
            string welcome = "Welcome to my test server";
            data = Encoding.ASCII.GetBytes(welcome);
            ns.Write(data, 0, data.Length);
            while (true)
            {
                data = new byte[1024];
                recv = ns.Read(data, 0, data.Length);
                if (recv == 0) ;
                break;
                ns.Write(data, 0, recv);
            }
            ns.Close();
            client.Close();
            connections--;
            Console.WriteLine("Client disconnected: {0} active connections", connections);
        }
    }
}
