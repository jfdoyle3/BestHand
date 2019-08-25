using System;
using System.Collections.Generic;
using System.Linq;


namespace BestHand
{
    class Program
    {
        static void Main(string[] args)
        {
            Game p1 = new Game();

           List<Card> deck= p1.CreateDeck();
           List<Card> p1Hand = new List<Card>();

            


            //IEnumerable<Card> deal = deck.Take(7);

            //Output.ConsoleIt(deal);

            //var hand1 = p1Hand.Add(deal);



        }
    }
}
