using System;
using System.Collections.Generic;
using System.Linq;

namespace BestHand
{
    public class Game
    {
        public Hand p1=new Hand();
      //public Hand p2;
        private Deck deck = new Deck();
        public List<Card> shuffled;
        public Game()
        {
            this.shuffled = deck.Shuffle();  
        }
        private void Deal()
        {
           
        }          
        public void Play()
        {
            Deal();
            
        }
    }
}