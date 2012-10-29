using System;

namespace Application
{
	public class Node<T> //where T: Nullable
	{
		// public T? value = null;
		public T value;
		public Node<T> prev = null;
		
		public Node (T value)
		{
			this.value = value;
		}
	}

	public class Stack<T>
	{
		private Node<T> head = null;
		
		public void Push (T value)
		{
			var node = new Node<T> (value);
			
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


	}

	public class Generisch
	{
		public static void Main ()
		{
			Stack<int> s = new Stack<int> ();
			s.Push (5);
		}
	}
}

