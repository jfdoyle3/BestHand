using System;
using System.Collections.Generic;

namespace BestHand
{
    public class Game
    {
        //public Hand p1=new Hand();
      //public Hand p2;
        private Deck deck = new Deck();
        public List<Card> shuffled;
        public Game()
        {
            this.shuffled = deck.Shuffle();  
        }
        private void Deal()
        {
            List<Card> p1 = new List<Card>();
            int numCards = 1;
            _Output.ConsoleIt("Deck Start",shuffled);
            for (int c = 0; c < numCards; c++)
            {
                p1.Add(shuffled[c]);
                shuffled.Remove(shuffled[c]);
            }

            _Output.ConsoleIt("Deck after Deal",shuffled);
            _Output.ConsoleIt("Hand:  ",p1);

        }          
        public void Play()
        {
            Deal();
            
        }
    }
}