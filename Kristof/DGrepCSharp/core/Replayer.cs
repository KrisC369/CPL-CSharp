using System;
using System.Threading;
using System.Net;
using System.Net.Sockets;
using System.Collections.Generic;
namespace DGRepCSharp
{
	/** <summary>
	* This class models a replayer instance. this instance runs in 
	* its own thread and replays packets from one port to a list of hosts.
	* </summary>
	*/
	public class Replayer : IReplay
	{
		//public Boolean CanRun {get;set;} //also works
		private Boolean canRun; 
		private IPEndPoint listenAddress;
		
		private int destinationPort;
		private List<IPEndPoint> hosts;
		private int datagramSize;	
		public Replayer (IPEndPoint listenA, int destP, List<IPEndPoint> hostlist)
		{
			CanRun = true;
			ListenAddress = listenA;
			DestinationPort = destP;
			Hosts = hostlist;
			DatagramSize = 0xFFFF;
		}
		
		
		public void Start(){
			Thread oThread = new Thread(this.Run);
			oThread.Start();
		}
		
		public void Stop(){
			this.CanRun = false;
		}
		
		public void Run(){
			byte[] data = new byte[DatagramSize];
			UdpClient listenSock = new UdpClient(ListenAddress);
			UdpClient sendSock = new UdpClient(DestinationPort);
			IPEndPoint sender = new IPEndPoint(IPAddress.Any, 0);
			Console.WriteLine("Started listening and replaying...");
			while(CanRun){
				data = listenSock.Receive(ref sender);
				foreach (IPEndPoint ipep in Hosts){
					sendSock.Send(data,data.Length,ipep);					             				
				}	   
			
			}
			listenSock.Close();
			sendSock.Close();
			Console.WriteLine("Stopped listening and replaying gracefully...");
		}
		
		public Boolean CanRun {
			get {
				return this.canRun;
			}
			private set {
				canRun = value;
			}
		}

		public int DestinationPort {
			get {
				return this.destinationPort;
			}
			private set {
				destinationPort = value;
			}
		}

		public List<IPEndPoint> Hosts {
			get {
				return this.hosts;
			}
			private set {
				hosts = value;
			}
		}

		public IPEndPoint ListenAddress {
			get {
				return this.listenAddress;
			}
			private set {
				listenAddress = value;
			}
		}

		public int DatagramSize {
			get {
				return this.datagramSize;
			}
			private set {
				datagramSize = value;
			}
		}
	};
}

