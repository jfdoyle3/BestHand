using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace BestHand
{
    public class Game
    {
        public Hand p1;
        public Hand p2;
        public Deck deck;
        public IEnumerable<Card> shuffled;
        public Game()
        {
            this.deck = new Deck();
            this.shuffled = deck.Shuffle();
            //this.p1= new Hand();
           // this.p2 = new Hand();  
        }
        public void Deal()
        {

            Output.ConsoleIt(deck);
      
        }          
        public void Play()
        {
           

        }
    }
}