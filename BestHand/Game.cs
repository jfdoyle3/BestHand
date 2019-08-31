﻿using System;
using System.Collections.Generic;

namespace BestHand
{
    public class Game
    {
        public List<List<Card>> hands = new List<List<Card>>();
        private Deck deck = new Deck();
        public List<Card> shuffled;
        public Game()
        {
            this.shuffled = deck.Shuffle();
        }
        private List<List<Card>> Deal(int players, int hand)
        {
        //    // need a Jagged List/Array to put/remove any amount of cards on the Table in any position/cell/index.
        //    // need a Jagged List/Array to have any amount of players from 1 - 52 / Hand amout 1 - 52 cards.
            
            //List<List<Card>>  outer List Players  /  inner List Hands
            
            //List A: Loop A:  Make new List B -> Loop B: Add items to List B :End Loop B -> Add ListB to List A : End Loop A
            // Need to pass card by Index to Players  ..   All players Index 0 from the dck the 1,2,3 .. etc
            for (int plyr=0; plyr<players; plyr++)
            {
                List<Card> cDealt = new List<Card>();

                for (int crd=0; crd<hand; crd++)
                {
                    cDealt.Add(shuffled[crd]);
                    shuffled.Remove(shuffled[crd]);
                }
                    hands.Add(cDealt);
            }

            return hands;
        }

        public void Play()
        {
            List<List<Card>> hands=Deal(2,7);

            

            int cCount = 0;
            for (int i = 0; i < hands.Count; i++)
            {
                for (int j = 0; j < hands[i].Count; j++)
                {
                    cCount++;
                    Console.WriteLine("Player {2} Card {3}:  {0} {1}", hands[i][j].Value, hands[i][j].SuitSym(), i, cCount);
                }
            }

        }
    }
}