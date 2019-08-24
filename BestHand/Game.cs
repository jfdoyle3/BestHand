using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace BestHand
{
   public class Game
    {
        // public Card DealtCard= new Card();
        public List<Card> Deck = new List<Card>();
        private List<Card> p1Hand = new List<Card>();
        public List<Card> p2Hand = new List<Card>();

        public Card DrawCard()
        {
            Card aCard = new Card();
           
            return aCard;
        }

        public bool Compare (Card aCard, Card DealtCard)
        { 
            return (aCard.Value == DealtCard.Value && aCard.SuitSym() == DealtCard.SuitSym());
        }

        public List<Card> Hand()
        {
            for (int index = 0; index < 7; index++)
                this.p1Hand.Add(new Card());

            return p1Hand;
        }
        public int HandTotal(List<Card> playerHand)
        {

            int total = playerHand.Sum(face => face.Value);
            return total;
        }

        public List<Card> CreateDeck()
        {
           
            for (int face=2; face<= 14; face++)
            {

              for (int suits = 0; suits <= 3; suits++)
              {
                Card card = new Card(face,suits);
                Deck.Add(card);
              }
            }
            return Deck;
        }
        

    }

    
}