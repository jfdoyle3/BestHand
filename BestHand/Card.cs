using System;
using System.Collections.Generic;
using System.Text;

namespace High_n_Low
{
    public class Card
    {
        public int Value;
        public int Suit;
      //  public int Face;
        // private string[] Suits = { "Spades", "Hearts", "Diamonds", "Clubs" };
        private string[] Suits = { "♠", "♥", "♣", "♦" };
      //  private string[] Faces = { "J", "Q", "K", "A" };

        public Card()
        {
            Random newCard = new Random();
            Random newSuit = new Random();
            this.Value = newCard.Next(2,15);
            this.Suit = newSuit.Next(0, 4);
          //  if (this.Value>10)


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
