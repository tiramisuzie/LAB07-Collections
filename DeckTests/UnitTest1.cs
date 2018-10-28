using LAB07_Collections;
using Xunit;

namespace DeckTests
{
    public class UnitTest1
    {
        [Fact]
        public void ShouldAddCardToDeck()
        {
            Deck<Card> deck = new Deck<Card>();
            Assert.Equal(0, deck.count);

            deck.Add(new Card("2", Suits.Heart));

            Assert.Equal("2", deck.deck[0].Value);
            Assert.Equal(Suits.Heart, deck.deck[0].CardSuit);
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
            Card card = new Card("2", Suits.Heart);
            Deck<Card> deck = new Deck<Card>();
            deck.Add(card);
            Assert.Single(deck.deck);

            Card removed = deck.Remove(card);
            Assert.Null(deck.deck[0]);
        }

        [Fact]
        public void ShouldUnknownRemoveCardFromDeck()
        {
            Deck<Card> deck = new Deck<Card>();
            deck.Add(new Card("2", Suits.Heart));
            Assert.Single(deck.deck);

            Card removed = deck.Remove(new Card("3", Suits.Heart));
            Assert.Single(deck.deck);
            Assert.Null(removed);
        }
    }
}
