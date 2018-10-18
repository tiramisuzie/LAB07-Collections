using System;

namespace LAB07_Collections
{
    class Program
    {
        public static string[] CardValue = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
        public static Suits[] SuitValue = { Suits.Club, Suits.Spade, Suits.Diamond, Suits.Heart };

        static void Main(string[] args)
        {
            Deck<Card> deck = new Deck<Card>();
            for (int i = 0; i < CardValue.Length; i++)
            {
                for (int j = 0; j < SuitValue.Length; j++)
                {
                    deck.Add(new Card(CardValue[i], SuitValue[j]));
                }
            }
            Console.WriteLine("The cards in your deck are:");
            deck.PrintDeck();
            Console.WriteLine("Removing " + deck.Remove(new Card("3", Suits.Heart)).ToString());
            Console.WriteLine("Returning suit Heart in deck");
            deck.ReturnSuit(Suits.Heart);

        }

    }
  

}
