using System;
using System.Collections.Generic;
using System.Linq;


namespace BestHand
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Card> deck = new List<Card>();

            for (int face = 2; face <= 14; face++)
            {
                for (int suits = 0; suits <= 3; suits++)
                {
                    Card card = new Card(face, suits);
                    deck.Add(card);
                }
            }

            foreach (var card in deck)
            {
                Console.WriteLine("{0} of {1}",card.Value,card.SuitSym());
            }
        }
    }
}
