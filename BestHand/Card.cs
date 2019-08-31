using System;

namespace BestHand
{
    public class Card
    {
        public int Value;
        public int Suit;
        private string[] Suits = { "S", "H", "C", "D" };

        public Card()
        {
            Random newCard = new Random();
            Random newSuit = new Random();
            this.Value = newCard.Next(2,15);
            this.Suit = newSuit.Next(0, 4);
        }
        
        public Card(int Value, int Suit)
        {
            this.Value = Value;
            this.Suit = Suit;
        }
        public string SuitSym()
        {
            return this.Suits[this.Suit];
        }
    }
}
