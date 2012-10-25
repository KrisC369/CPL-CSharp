using System;
using System.Collections.Generic;

namespace CPL
{
	public class CardSorter : Sorter<Card>
	{
		CardDeck cards;

		public CardSorter (CardDeck cards)
		{
			this.cards = cards;
		}
	}
}

