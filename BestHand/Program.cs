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

            List<Card> p1Hand=p1.Hand();

            int total;

            foreach (var item in p1Hand)
            {
               // total = +item.Value;
                Console.WriteLine("Cards:   {0} of {1}", item.Value, item.SuitSym());
            }

            total = p1Hand.Count();
            Console.WriteLine("Total Hand:  {0}",total);
            

        }
    }
}
