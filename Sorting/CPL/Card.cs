using System;

namespace Sorting
{
	public class Card : IComparable<Card>
	{

		private int Value;
		private Suit Suit;

		public Card (int value, Suit suit)
		{
			this.Value = value;
			this.Suit = suit;
		}

		public int CompareTo(Card other){
			if(((int)(this.Suit)*13+this.Value) > ((int)(other.Suit)*13+other.Value))
				return 1;
			if(((int)(this.Suit)*13+this.Value) == ((int)(other.Suit)*13+other.Value))
				return 0;
			else 
				return -1;
		}

		public override String ToString(){
			return this.Suit + " " + this.Value + "\n"; 
		}
	}
}

