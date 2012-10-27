using System;

namespace DGRepCSharp
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Trying to set up a few threads!");
			DatagramReplayer replay = new DatagramReplayer();
			replay.StartListen();
			
		}
	}
}

