using System;
using System.Collections.Generic;
using System.Reflection;

namespace LAB07_Collections
{
    public class Deck<T>
    {
        public T[] deck = new T[1];
        public int count = 0;

        public void Add(T card)
        {
            if (count == deck.Length)
            {
                Array.Resize(ref deck, deck.Length * 2);
            }

            deck[count++] = card;
        }
        
        public T Remove(T card)
        {
            for (int i = 0; i < count; i++)
            {
                if (deck[i].Equals(card))
                {
                    deck[i] = default(T);
                    count--;
                    return card;
                }
            }

            return default(T);
        }

        public T[] ReturnSuit(Suits s)
        {
            T[] cardsOfSameSuit = new T[1];


            int counter = 0;

            for (int i = 0; i < deck.Length; i++)
            {
                if (deck[i] != null)
                {

                    Type c = deck[i].GetType();
                    PropertyInfo prop = c.GetProperty("CardSuit");

                    Suits suit = (Suits) prop.GetValue(deck[i]);
                    
                    if (suit == s)
                    {
                        if (counter >= cardsOfSameSuit.Length)
                        {
                            Array.Resize(ref cardsOfSameSuit, cardsOfSameSuit.Length+1);
                        }

                        cardsOfSameSuit[counter] = deck[i];
                        counter++;
                    }
                }
            }
            return cardsOfSameSuit;

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
