using System;
using System.Collections.Generic;
using System.Text;

namespace LAB07_Collections
{
    public class Card
    {
        public string Value { get; set; }
        public Suits CardSuit { get; set; }
        public Card (string Val, Suits Suit)
        {
            Value = Val;
            CardSuit = Suit;
        }
        public string ToString()
        {
            return Value + " " + CardSuit;
        }
    }

   
}
