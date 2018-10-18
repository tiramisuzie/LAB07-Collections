using System;
using System.Collections.Generic;
using System.Text;

namespace LAB07_Collections
{
    class Card
    {
        public string Value;
        public Suits CardSuit;
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
