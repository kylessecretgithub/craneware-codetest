using CodingChallenge.CardGame;
using System.Collections.Generic;

namespace CardGame.Tests.Utilities
{
    internal static class SortedListOfCardsGenerator
    {
        public static List<ICard> Generate()
        {
            return new List<ICard>
            {
                new Card(Value.Ace, Suit.Clubs),
                new Card(Value.Two, Suit.Clubs),
                new Card(Value.Three, Suit.Clubs),
                new Card(Value.Four, Suit.Clubs),
                new Card(Value.Five, Suit.Clubs),
                new Card(Value.Six, Suit.Clubs),
                new Card(Value.Seven, Suit.Clubs),
                new Card(Value.Eight, Suit.Clubs),
                new Card(Value.Nine, Suit.Clubs),
                new Card(Value.Ten, Suit.Clubs),
                new Card(Value.Jack, Suit.Clubs),
                new Card(Value.Queen, Suit.Clubs),
                new Card(Value.King, Suit.Clubs),
                new Card(Value.Ace, Suit.Diamonds),
                new Card(Value.Two, Suit.Diamonds),
                new Card(Value.Three, Suit.Diamonds),
                new Card(Value.Four, Suit.Diamonds),
                new Card(Value.Five, Suit.Diamonds),
                new Card(Value.Six, Suit.Diamonds),
                new Card(Value.Seven, Suit.Diamonds),
                new Card(Value.Eight, Suit.Diamonds),
                new Card(Value.Nine, Suit.Diamonds),
                new Card(Value.Ten, Suit.Diamonds),
                new Card(Value.Jack, Suit.Diamonds),
                new Card(Value.Queen, Suit.Diamonds),
                new Card(Value.King, Suit.Diamonds),
                new Card(Value.Ace, Suit.Hearts),
                new Card(Value.Two, Suit.Hearts),
                new Card(Value.Three, Suit.Hearts),
                new Card(Value.Four, Suit.Hearts),
                new Card(Value.Five, Suit.Hearts),
                new Card(Value.Six, Suit.Hearts),
                new Card(Value.Seven, Suit.Hearts),
                new Card(Value.Eight, Suit.Hearts),
                new Card(Value.Nine, Suit.Hearts),
                new Card(Value.Ten, Suit.Hearts),
                new Card(Value.Jack, Suit.Hearts),
                new Card(Value.Queen, Suit.Hearts),
                new Card(Value.King, Suit.Hearts),
                new Card(Value.Ace, Suit.Spades),
                new Card(Value.Two, Suit.Spades),
                new Card(Value.Three, Suit.Spades),
                new Card(Value.Four, Suit.Spades),
                new Card(Value.Five, Suit.Spades),
                new Card(Value.Six, Suit.Spades),
                new Card(Value.Seven, Suit.Spades),
                new Card(Value.Eight, Suit.Spades),
                new Card(Value.Nine, Suit.Spades),
                new Card(Value.Ten, Suit.Spades),
                new Card(Value.Jack, Suit.Spades),
                new Card(Value.Queen, Suit.Spades),
                new Card(Value.King, Suit.Spades)
            };
        }
    }
}
