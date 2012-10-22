using System;
using System.Collections.Generic;

namespace Sorting
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			CardDeck deck = new CardDeck();
			deck.Shuffle();
			deck.Sort();
			Console.Write(deck);
		}
	}
}
