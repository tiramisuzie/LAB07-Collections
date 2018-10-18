using System;
using System.Collections.Generic;

namespace LAB07_Collections
{
    public class Deck<T>
    {
        public List<Card> DeckCollection = new List<Card>();
       
        public void PrintDeck()
        {
            foreach (Card C in DeckCollection)
            {
                Console.WriteLine(C.ToString());
            }
        }

        public void Add(Card card)
        {
            DeckCollection.Add(card);
        }

        public Card Remove(Card card)
        {
            Card [] temp = DeckCollection.ToArray();
            foreach( Card c in temp)
            {
                if (c.CardSuit == card.CardSuit && c.Value == card.Value)
                {
                    DeckCollection.Remove(c);
                    return card;
                }
            }
            return null;
        }

        public void ReturnSuit(Suits s)
        {
            Card[] temp = DeckCollection.ToArray();
            foreach(Card c in temp)
            {
                if (c.CardSuit == s)
                {
                    Console.WriteLine(c.ToString());
                }
            }

        }
    }

    public enum Suits
    {
        Club,
        Spade,
        Diamond,
        Heart
    };

}
