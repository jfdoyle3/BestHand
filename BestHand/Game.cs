using System;
using System.Collections.Generic;
using System.Text;

namespace BestHand
{
   public class Game
    {
       // public Card DealtCard= new Card();
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
        

    }

    
}