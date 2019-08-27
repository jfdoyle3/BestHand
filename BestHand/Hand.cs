using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace BestHand
{
    public class Hand
    {
        private List<Card> hand = new List<Card>();
        public Hand()
        {
            for (int index = 0; index < 7; index++)
                this.hand.Add(new Card());
    
        }
        public int HandTotal(List<Card> hand)
        {
            int total = hand.Sum(face => face.Value);

            return total;
        }

    }
}
