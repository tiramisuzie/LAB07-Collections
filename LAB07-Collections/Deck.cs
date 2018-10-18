using System;
using System.Collections.Generic;
using System.Text;

namespace LAB07_Collections
{
    class Deck
    {
        public string[] CardValue = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
        public Suits[] SuitValue = { Suits.Club, Suits.Spade, Suits.Diamond, Suits.Heart };
        public Card[] DeckCollection = new Card[52];
        public Deck()
        {
            int Counter = 0; 
            for (int i = 0; i < CardValue.Length; i++)
            {
                for (int j = 0; j < SuitValue.Length; j++)
                {
                    DeckCollection[Counter] = new Card(CardValue[i], SuitValue[j]);
                    Counter++;
                }
            }
        }

        public void PrintDeck()
        {
            foreach (Card C in DeckCollection)
            {
                Console.WriteLine(C.ToString());
            }
        }
    }

    enum Suits
    {
        Club,
        Spade,
        Diamond,
        Heart
    };

}
