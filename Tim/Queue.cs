using System;

namespace Application
{
	public class Node
	{
		public Node Next{ get; set; }

		public int Value{ get; set; }

		public Node (int value)
		{
			this.Next = null;
			this.Value = value;
		}

	}

	public class Queue
	{
		public Node Front { get; set; }
		public Node Back {get; set;}

		public void Enqueue (int value)
		{
			if (Back == null) {
				Back = new Node (value);
				Front = Back;
			} else {
				Node n = new Node (value);
				Back.Next = n;
				Back = n;
			}
		}

		public int Dequeue ()
		{
			Node temp = Front;
			Front = temp.Next;
			return temp.Value;
		}

		public override string ToString(){
			return ToString(Front);
		}

		private string ToString (Node n)
		{
			if (n == null) {
				return "";
			} else {
				return "[" + n.Value + "] " + ToString (n.Next);
			}
		}

		public Queue ()
		{
			Front = null;
			Back = null;
		}
		
		public static void Main ()
		{
			Queue q = new Queue();
			q.Enqueue(2);
			q.Enqueue(4);
			q.Enqueue(8);
			q.Enqueue(16);
			Console.WriteLine(q.ToString());
			Console.WriteLine(q.Dequeue());
			Console.WriteLine(q.ToString());
			Console.WriteLine(q.Dequeue());
			Console.WriteLine(q.ToString());
		}
	}
}

