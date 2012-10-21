using System;
using System.Net;
using System.Net.Sockets;
using System.Collections.Generic;
namespace DGRepCSharp
{
	/**
	 *<summary>
	 * This class represents the application logic for creating,
	 * running and stopping replayer threads.
	 * </summary>
	 * <remarks>
	 * This class should implement the replayerAPI which doesn't exist yet.
	 * When it does exist, it can be used by some sort of UI for ease of control
	 * throught the API.
	 * </remarks>
	 */
	public class DatagramReplayer
	{
		private int listenStart;
		private int listenEnd;
		private IPAddress listenAdd;
		private List<IPEndPoint> hosts;
		private List<IReplay> runningThreads;
				
		public DatagramReplayer ()
		{
			RunningThreads = new List<IReplay>(); //No sets available?	
			Hosts = new List<IPEndPoint>();
			this.ReadCFG();
		}
		
		private void ReadCFG(){
			//should normally read a config file for entries.
			Hosts.Add(new IPEndPoint(System.Net.IPAddress.Parse("192.168.1.5"),3005));
			Hosts.Add(new IPEndPoint(System.Net.IPAddress.Parse("192.168.1.17"),3005));
			Hosts.Add(new IPEndPoint(System.Net.IPAddress.Parse("192.168.1.2"),3005));
			Hosts.Add(new IPEndPoint(System.Net.IPAddress.Parse("192.168.1.7"),3333));
			Hosts.Add(new IPEndPoint(System.Net.IPAddress.Parse("192.168.1.7"),3333));
			Hosts.Add(new IPEndPoint(System.Net.IPAddress.Parse("192.168.1.7"),3333));
			Hosts.Add(new IPEndPoint(System.Net.IPAddress.Parse("192.168.1.7"),3333));
			Hosts.Add(new IPEndPoint(System.Net.IPAddress.Parse("192.168.1.7"),3333));
			Hosts.Add(new IPEndPoint(System.Net.IPAddress.Parse("192.168.1.7"),3333));
			Hosts.Add(new IPEndPoint(System.Net.IPAddress.Parse("192.168.1.7"),3333));
			Hosts.Add(new IPEndPoint(System.Net.IPAddress.Parse("192.168.1.7"),3333));
			Hosts.Add(new IPEndPoint(System.Net.IPAddress.Parse("192.168.1.7"),3333));
			Hosts.Add(new IPEndPoint(System.Net.IPAddress.Parse("192.168.1.7"),3333));
			ListenStart = 3333;
			ListenEnd = 3335;
			ListenAdd = System.Net.IPAddress.Parse("192.168.1.7");
		}
		
		public void StartListen(){
			Replayer current;
			for (int p = listenStart; p<= listenEnd; p++){
				current = new Replayer(new IPEndPoint(listenAdd,p),3010,hosts);
				current.Start();
				RunningThreads.Add(current);
			}
		}	
		/**
		 * C#'s way of creating getter and setter combo's. 
		 * for .NET version as soon as 2.5.
		 */
		public List<IPEndPoint> Hosts {
			get {
				return this.hosts;
			}
			private set {
				hosts = value;
			}
		}

		public IPAddress ListenAdd {
			get {
				return this.listenAdd;
			}
			private set {
				listenAdd = value;
			}
		}

		public int ListenEnd {
			get {
				return this.listenEnd;
			}
			private set {
				listenEnd = value;
			}
		}

		public int ListenStart {
			get {
				return this.listenStart;
			}
			private set {
				listenStart = value;
			}
		}

		public List<IReplay> RunningThreads {
			get {
				return this.runningThreads;
			}
			set {
				runningThreads = value;
			}
		}
	}
}
