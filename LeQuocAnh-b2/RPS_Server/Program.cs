using RPS_Server.GUI;
using System;
using System.Windows.Forms;

namespace RPS_Server
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
			Application.Run(new RPS_ServerForm());
		}
	}
}
