using RPS_Server.Signal;
using System;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;

/*
 * Client play the game first
 * then the server
 * Communicating using only 1 byte of signal
 */

namespace RPS_Server.GUI
{
	public partial class RPS_ServerForm : Form
	{
		private TcpListener server;
		private TcpClient client;

		private NetworkStream dataStream;

		private byte signalReceive;

		private byte mySelection, opponentSelection, myResult;

		public RPS_ServerForm()
		{
			Console.WriteLine("Server initialising GUI components");
			InitializeComponent();

			setInit();
		}

		private void setInit()
		{
			Console.WriteLine("Server initialising network components");
			//init server
			server = new TcpListener(IPAddress.Any, 1724);		//server will receive any connection to any interface, port 1724

			//init game
			Console.WriteLine("Server initialising game");
			mySelection = Signal_Game.NEUTRAL;
			myResult = Signal_Game.DRAW;
			opponentSelection = Signal_Game.NEUTRAL;
		}

		private void startListening()
		{
			Console.WriteLine("Server start listening");
			server.Start();		//server start listening
			client = server.AcceptTcpClient();
			dataStream = client.GetStream();
			Console.WriteLine("Server accepted a client and ready to communicate");
		}

		/**
		 * 1. Server send START signal
		 * 2. Server receive ack
		 * 3. Server receive move #1
		 * 4. Server send ack
		 * 5. Server send move #2
		 * 6. Server receive ack
		 * 7. Server send result
		 * 8. Server receive ack
		 * 9. Server send FINISH
		 * 10. Server receive ack
		 * 11. Server close connection
		 * */
		private void startGame()		//game flow implement here
		{
			//throw new NotImplementedException();
			sendSignalToClient(Signal_Game.START);		//inform client that game has started, get ack from client
			signalReceive = receiveSignalFromClient();	//waiting for ack
			if (signalReceive == Signal_Client.CLIENT_ACK)
			{
				opponentSelection = receiveSignalFromClient();		//receive move #1 from client
			}
			sendSignalToClient(Signal_Client.CLIENT_ACK);
			sendSignalToClient(mySelection);
			signalReceive = receiveSignalFromClient();	//waiting for ack
			setGameResult();
			if(myResult == Signal_Game.WIN)
				sendSignalToClient(Signal_Game.LOSE);
			else if(myResult == Signal_Game.LOSE)
				sendSignalToClient(Signal_Game.WIN);
			signalReceive = receiveSignalFromClient();	//waiting for ack
			if (signalReceive == Signal_Client.CLIENT_ACK)
			{
				sendSignalToClient(Signal_Game.FINISH);
			}
			signalReceive = receiveSignalFromClient();	//waiting for ack
			if (signalReceive == Signal_Client.CLIENT_ACK)
			{
				client.Close();
			}
		}

		private void setGameResult()
		{
			if (mySelection == Signal_Game.SCISSOR)
			{
				if (opponentSelection == Signal_Game.ROCK)
					myResult = Signal_Game.LOSE;
				else if (opponentSelection == Signal_Game.PAPER)
					myResult = Signal_Game.WIN;
				else if (opponentSelection == Signal_Game.SCISSOR)
					myResult = Signal_Game.DRAW;
			}
			if (mySelection == Signal_Game.PAPER)
			{
				if (opponentSelection == Signal_Game.ROCK)
					myResult = Signal_Game.WIN;
				else if (opponentSelection == Signal_Game.PAPER)
					myResult = Signal_Game.DRAW;
				else if (opponentSelection == Signal_Game.SCISSOR)
					myResult = Signal_Game.LOSE;
			}
			if (mySelection == Signal_Game.ROCK)
			{
				if (opponentSelection == Signal_Game.ROCK)
					myResult = Signal_Game.DRAW;
				else if (opponentSelection == Signal_Game.PAPER)
					myResult = Signal_Game.LOSE;
				else if (opponentSelection == Signal_Game.SCISSOR)
					myResult = Signal_Game.WIN;
			}
			//throw new NotImplementedException();
		}

		private void sendSignalToClient(byte signal)
		{
			dataStream.WriteByte(signal);		//send signal
		}

		private byte receiveSignalFromClient()
		{
			return Convert.ToByte(dataStream.ReadByte());		//read 1 byte of signal from client
		}

		private void btnScissor_Click(object sender, EventArgs e)
		{
			mySelection = Signal_Game.SCISSOR;
			startListening();
			startGame();
		}

		private void btnPaper_Click(object sender, EventArgs e)
		{
			mySelection = Signal_Game.PAPER;
			startListening();
			startGame();
		}

		private void btnRock_Click(object sender, EventArgs e)
		{
			mySelection = Signal_Game.ROCK;
			startListening();
			startGame();
		}
	}
}
