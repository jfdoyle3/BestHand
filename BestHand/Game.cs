using System;
using System.Collections.Generic;
using System.Text;

namespace High_n_Low
{
   public class Game
    {
       // public Card DealtCard= new Card();

        public Card DrawCard()
        {
            Card aCard = new Card();
           
            return aCard;
        }

        public bool Compare (Card aCard, Card DealtCard)
        { 
            return (aCard.Value == DealtCard.Value && aCard.SuitSym() == DealtCard.SuitSym());
        }

        public static void Play(string Guess, Card playerCard,Card drawnCard)
        {
            Console.WriteLine("Your Card: {0}{1}",playerCard.Value,playerCard.SuitSym());


            if ((Guess.ToLower()=="h") && (playerCard.Value>drawnCard.Value)|| (Guess.ToLower() == "l") && (playerCard.Value < drawnCard.Value))
                Console.WriteLine("You Win" );
            else if (playerCard.Value==drawnCard.Value)
                Console.WriteLine("Draw");
            else
                Console.WriteLine("You Lose");
          
               
        }

        public string Guess()
        {
            Console.WriteLine("Is your card going to be (H)igher, (L)ower");
            string guess = Console.ReadLine();

            return guess;
        }
    }
}