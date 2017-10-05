using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI03
{
    class Program
    {
        private static string strIP;		//input from user
        private static int inpMask;	//input from user

        private static List<int> ip;
        private static List<int> mask;
        private static List<int> netID;
        private static List<int> broadcast;

        private static void input()
        {
            Console.Write("Nhap dia chi IP: ");
            strIP = Console.ReadLine();
            Console.Write("Nhap dia chi broadcast: ");
            inpMask = Convert.ToInt32(Console.ReadLine());
        }
        static void Main(string[] args)
        {
            input();
        }
    }
}
