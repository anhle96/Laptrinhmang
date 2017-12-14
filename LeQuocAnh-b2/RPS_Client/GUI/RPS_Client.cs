using RPS_Server.Signal;
using System;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;

namespace RPS_Client.GUI
{
	public partial class RPS_ClientForm : Form
	{
		private TcpClient client;

		private NetworkStream dataStream;

		private byte signalReceive;

		private byte mySelection, opponentSelection, myResult;


		public RPS_ClientForm()
		{
			InitializeComponent();

			setInit();
		}

		private void setInit()
		{
			//throw new NotImplementedException();
			client = new TcpClient(new IPEndPoint(IPAddress.Parse("127.0.0.1"), 1724));
			dataStream = client.GetStream();

			//init game
			Console.WriteLine("Client initialising game");
			mySelection = Signal_Game.NEUTRAL;
			myResult = Signal_Game.DRAW;
			opponentSelection = Signal_Game.NEUTRAL;
		}

		private void btnScissor_Click(object sender, EventArgs e)
		{
			mySelection = Signal_Game.SCISSOR;
		}

		private void btnPaper_Click(object sender, EventArgs e)
		{
			mySelection = Signal_Game.PAPER;
		}

		private void btnRock_Click(object sender, EventArgs e)
		{
			mySelection = Signal_Game.ROCK;
		}
	}
}
