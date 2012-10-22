using System;
using System.Collections.Generic;

namespace Sorting
{
	public class CardDeck : Sorter<Card>
	{
		public IList<Card> Cards { get; set; }

		public CardDeck(){
			this.Cards = new List<Card>(52);
			for(Sorting.Suit curSuit = Sorting.Suit.Diamonds; curSuit <= Sorting.Suit.Spades; curSuit++ )
				for( int i = 1; i <= 13; ++i )
					this.Cards.Add(new Card(i, curSuit));
		}

		public void Sort(){
			Sort(this.Cards);
		}

		public void Shuffle(){
			Random random = new Random();
			for(int i=0;i<Cards.Count;i++){
				int newPos = random.Next(52);
				Swap (i,newPos,this.Cards);
			}
		}

		public override String ToString ()
		{
			String result = "";
			foreach (Card c in this.Cards) {
				result += c.ToString();
			}
			return result;
		}
	}
}

