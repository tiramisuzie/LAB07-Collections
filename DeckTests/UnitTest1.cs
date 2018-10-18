using System;
using Xunit;
using LAB07_Collections;

namespace DeckTests
{
    public class UnitTest1
    {
        [Fact]
        public void ShouldAddCardToDeck()
        {
            Deck<Card> deck = new Deck<Card>();
            Assert.Empty(deck.DeckCollection);

            deck.Add(new Card("2", Suits.Heart));

            Assert.Single(deck.DeckCollection);
        }

        [Fact]
        public void ShouldGetCardValue()
        {
            Card card = new Card("2", Suits.Heart);

            Assert.Equal("2", card.Value);
            Assert.Equal(Suits.Heart, card.CardSuit);
        }

        [Fact]
        public void ShouldRemoveCardFromDeck()
        {
            Deck<Card> deck = new Deck<Card>();
            deck.Add(new Card("2", Suits.Heart));
            Assert.Single(deck.DeckCollection);

            Card removed = deck.Remove(new Card("2", Suits.Heart));
            Assert.Empty(deck.DeckCollection);
        }

        [Fact]
        public void ShouldUnknownRemoveCardFromDeck()
        {
            Deck<Card> deck = new Deck<Card>();
            deck.Add(new Card("2", Suits.Heart));
            Assert.Single(deck.DeckCollection);

            Card removed = deck.Remove(new Card("3", Suits.Heart));
            Assert.Single(deck.DeckCollection);
            Assert.Null(removed);
        }
    }
}
