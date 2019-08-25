using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace BestHand
{
    class Output
    {

        public static void ConsoleIt(dynamic deck)
        {
            foreach (Card item in deck)
            {

                Console.WriteLine("Card:   {0} of {1}", item.Value, item.SuitSym());
            }

            Console.WriteLine("Total Cards:  {0}", deck.Count);
        }
    }
}
