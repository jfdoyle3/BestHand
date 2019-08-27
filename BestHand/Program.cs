using System;
using System.Collections.Generic;
using System.Linq;


namespace BestHand
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();


            Deck deck = new Deck();

           // IEnumerable<Card> shuffled= game.Shuffle();
           // IEnumerable<Card> deal = shuffled.Take(7);

            foreach (var card in deck)
            {
                Console.WriteLine("Hand: {0} of {1}",card.Value,card.SuitSym());
            }

         //  Output.ConsoleIt(deal);

            



        }
    }
}
