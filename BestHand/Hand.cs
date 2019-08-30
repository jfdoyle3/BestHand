using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace BestHand
{
    public class Hand
    {
        
        public List<Card> _Hand = new List<Card>();
        public Hand(int card)
        {
          //  Card card = new Card(face, suits);
          //  this.hand=_Hand.Add(card);
        }
        public int HandTotal(List<Card> hand)
        {
            int total = hand.Sum(face => face.Value);

            return total;
        }

    }
}
