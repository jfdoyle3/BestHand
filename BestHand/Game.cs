using System;
using System.Collections.Generic;

namespace BestHand
{
    public class Game
    {
        //public Hand p1=new Hand();
        //public Hand p2;
        List<Card> p1 = new List<Card>();
        List<Card> p2 = new List<Card>();
        private Deck deck = new Deck();
        public List<Card> shuffled;
        public Game()
        {
            this.shuffled = deck.Shuffle();
        }
        private void Deal()
        {
            // need a Jagged List/Array to put/remove any amount of cards on the Table in any position/cell/index.
            // need a Jagged List/Array to have any amount of players from 1 - 52 / Hand amout 1 - 52 cards.
            int hand = 7;
            int players = 2;
            int numCards = hand * players;

            // _Output.ConsoleIt("Deck Start",shuffled);
            for (int c = 0; c < numCards; c++)
            {

                if (c % players == 1)
                {
                    p1.Add(shuffled[c]);

                }
                else
                {
                    p2.Add(shuffled[c]);
                }

            }


            // _Output.ConsoleIt("Deck after Deal", shuffled);
            // _Output.ConsoleIt("Hand:  ", p1);
        }
                  
       // public dynamic Play()
       // {
          // Deal(7,2);
          // _Output.ConsoleIt("Deck after Deal", shuffled);
          //  _Output.ConsoleIt("P1 Hand:  ", p1);
           // _Output.ConsoleIt("P2 Hand:  ", p2);


       // }
    }
}