using RPS_Client.GUI;
using System;
using System.Windows.Forms;

namespace RPS_Client
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new RPS_ClientForm());
		}
	}
}
