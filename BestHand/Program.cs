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

            var p1Hand=p1.Hand();

           List<Card> deck= p1.CreateDeck();







            foreach (var item in deck)
            {

                Console.WriteLine("Cards:   {0} of {1}", item.Value, item.SuitSym());
            }


            // Console.WriteLine("Total Hand:  {0}",p1.HandTotal(p1Hand));


        }
    }
}
