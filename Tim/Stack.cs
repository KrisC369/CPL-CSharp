using System;

namespace Application
{
	public class Node
	{
		public int? value = null;
		public Node prev = null;
		
		public Node (int value)
		{
			this.value = value;
		}
	}

	public class Stack
	{
		private Node head = null;

		public void push (int value)
		{
			var node = new Node (value);

			if (isEmpty ()) {
				head = node;
			} else {
				node.prev = head;
				head = node;
			}
		}

		public bool isEmpty ()
		{
			return (head == null);
		}

		public int? pop ()
		{
			if (isEmpty ()) {
				return null;
			} else {
				var toReturn = head;
				head = toReturn.prev;
				return toReturn.value;
			}
		}

		public int? top ()
		{
			if (isEmpty ()) {
				return null;
			} else {
				return this.head.value;
			}
		}

		public string toString ()
		{
			return toString (this.head);
		}

		private string toString (Node n)
		{
			if (n == null) {
				return "";
			} else {
				return "[" + n.value + "] " + toString (n.prev);
			}
		}

		static void Main ()
		{
			Stack s = new Stack ();
			s.push (2);
			s.push (4);
			s.push (8);
			Console.WriteLine (s.toString ());
			s.pop ();
			s.pop ();
			s.pop ();
			s.pop ();
			Console.WriteLine (s.toString ());
			s.push (16);
			s.push (32);
			Console.WriteLine (s.toString ());
			Console.WriteLine (s.top ());
			Console.WriteLine (s.toString ());
		}
	}
}

