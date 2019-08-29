using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace BestHand
{
    public class Deck
    {
        public List<Card> deck = new List<Card>();

        public Deck()
        {
            for (int face = 2; face <= 14; face++)
            {
                for (int suits = 0; suits <= 3; suits++)
                {
                   Card card = new Card(face, suits);
                    this.deck.Add(card);
                }
            }
        }

        public Deck (int minCard, int maxCard)
        {
            for (int face = minCard; face <=maxCard; face++)
            {
                for (int suits = 0; suits <= 3; suits++)
                {
                    Card card = new Card(face, suits);
                    this.deck.Add(card);
                }
            }
        }

        public IEnumerable<Card> Shuffle()
        {
            Random rnd = new Random();
            IOrderedEnumerable<Card> shuffled = deck.OrderBy(Card => rnd.Next());

            return shuffled.ToList<Card>();
        }

    }
}
