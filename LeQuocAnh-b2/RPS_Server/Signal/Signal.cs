namespace RPS_Server.Signal
{
	public class Signal_Server		//signals sent from and to server
	{
		public const byte SERVER_ACK = 1;		//server acknowledge signals from client
		public const byte SERVER_SEND_REQ = 2;	//server request to send to client
	}

	public class Signal_Client {		//signals sent from and to client
		public const byte CLIENT_ACK = 1;		//client acknowledge signals from server
		public const byte CLIENT_SEND_REQ = 2;	//client request to send to server
	}

	public class Signal_Game
	{
		public const byte FINISH = 98;		//the game has finished
		public const byte START = 99;		//the game has started

		public const byte LOSE = 100;		//you lost
		public const byte DRAW = 101;		//you drawn
		public const byte WIN = 102;		//you won

		public const byte ROCK = 255;		//player using rock
		public const byte PAPER = 254;		//player using paper
		public const byte SCISSOR = 253;	//player using scissor
		public const byte NEUTRAL = 252;	//player has not sent rock or paper or scissor

	}
}
