using CardGame.Tests.Utilities;
using CodingChallenge.CardGame;
using NUnit.Framework;
using System.Linq;

namespace CardGame.Tests
{
    [TestFixture]
    internal class PackOfCardsCreatorTests
    {
        private IPackOfCards deck; 

        [OneTimeSetUp]
        public void SetUp()
        {
            var packOfCardsCreator = new PackOfCardsCreator();
            deck = packOfCardsCreator.Create();
        }

        [Test]
        public void Deck_has_52_cards()
        {
            Assert.That(deck.Count, Is.EqualTo(52));
        }

        [Test]
        public void Deck_has_all_combinations_of_52_cards()
        {
            var sortedCards = SortedListOfCardsGenerator.Generate();
            foreach(var card in deck)
            {
                Assert.That(sortedCards.Count(c => c.Suit == card.Suit && c.Value == card.Value), Is.EqualTo(1));
            }
        }
    }
}
