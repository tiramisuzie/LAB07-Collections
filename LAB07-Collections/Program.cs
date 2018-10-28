using System;

namespace LAB07_Collections
{
    class Program
    {
        static void Main(string[] args)
        {

            Card card1 = new Card("A", Suits.Heart);
            Card card2 = new Card("K", Suits.Diamond);
            Card card3 = new Card("Q", Suits.Spade);
            Card card4 = new Card("J", Suits.Club);
            Card card5 = new Card("10", Suits.Heart);
            Card card6 = new Card("9", Suits.Diamond);
            Card card7 = new Card("8", Suits.Spade);
            Card card8 = new Card("7", Suits.Club);
            Card card9 = new Card("6", Suits.Heart);
            Card card10 = new Card("5", Suits.Diamond);

            Deck<Card> deck = new Deck<Card>();
            deck.Add(card1);
            deck.Add(card2);
            deck.Add(card3);
            deck.Add(card4);
            deck.Add(card5);
            deck.Add(card6);
            deck.Add(card7);
            deck.Add(card8);
            deck.Add(card9);
            deck.Add(card10);

            Console.WriteLine("The cards in your deck are:");

            PrintDeck(deck);
            Console.WriteLine();

            Console.WriteLine("Add 4 of Spade");

            Card card11 = new Card("4", Suits.Spade);
            deck.Add(card11);
            PrintDeck(deck);

            Console.WriteLine("Remove Ace of Heart");
            deck.Remove(card1);
            PrintDeck(deck);

            Console.WriteLine("Returning suit Heart in deck");
            Card[] cards = deck.ReturnSuit(Suits.Heart);
            foreach (Card c in cards)
            {
                Console.WriteLine($"{c.Value} of {c.CardSuit}");
            }
        }


        public static void PrintDeck(Deck<Card> deck)
        {
            foreach (Card card in deck.deck)
            {
                if (card != null)
                {
                    Console.WriteLine($"{card.Value} of {card.CardSuit}");
                }
            }
        }


    }
}
