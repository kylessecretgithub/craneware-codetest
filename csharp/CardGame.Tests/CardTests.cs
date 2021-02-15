using CodingChallenge.CardGame;
using NUnit.Framework;

namespace CardGame.Tests
{
    [TestFixture]
    public class CardTests
    {
        [Test]
        public void Equality_returns_true_when_cards_are_the_same()
        {
            var aceOfClubs = new Card(Value.Ace, Suit.Clubs);
            var aceOfClubs2 = new Card(Value.Ace, Suit.Clubs);
            Assert.True(aceOfClubs.Equals(aceOfClubs2));
        }

        [Test]
        public void Equality_returns_false_when_cards_are_different_suit_same_value()
        {
            var aceOfClubs = new Card(Value.Ace, Suit.Clubs);
            var aceOfHearts = new Card(Value.Ace, Suit.Hearts);
            Assert.False(aceOfClubs.Equals(aceOfHearts));
        }

        [Test]
        public void Equality_returns_false_when_cards_are_same_suit_different_value()
        {
            var queenOfClubs = new Card(Value.Queen, Suit.Clubs);
            var aceOfClubs = new Card(Value.Ace, Suit.Clubs);
            Assert.False(aceOfClubs.Equals(queenOfClubs));
        }

        [Test]
        public void Equality_returns_false_when_cards_are_different_suit_and_value()
        {
            var twoOfHearts = new Card(Value.Two, Suit.Hearts);
            var aceOfClubs = new Card(Value.Ace, Suit.Clubs);
            Assert.False(twoOfHearts.Equals(aceOfClubs));
        }
    }
}
