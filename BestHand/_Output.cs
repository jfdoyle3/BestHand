using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace BestHand
{
    class _Output
    {

        public static void ConsoleIt(dynamic deck)
        {
            int count = 0;
            foreach (Card item in deck)
            {
                Console.WriteLine("Card {2}:   {0} of {1}", item.Value, item.SuitSym(),count);
                count++;
            }

           Console.WriteLine("Total Cards:  {0}", deck.Count);
        }
    }
}
