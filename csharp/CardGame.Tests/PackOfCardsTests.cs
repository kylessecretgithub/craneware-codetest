using CardGame.Tests.Utilities;
using CodingChallenge.CardGame;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace CardGame.Tests
{
    [TestFixture]
    internal class PackOfCardsTests
    {
        [Test]
        public void Initialises_with_empty_list_if_passed_null_list()
        {
            var pack = new PackOfCards(new Random(), null);
            Assert.That(pack.Count == 0);
        }

        [Test]
        public void Does_not_throw_exception_if_passed_null_random()
        {
            var pack = new PackOfCards(null, SortedListOfCardsGenerator.Generate());
            Assert.DoesNotThrow(pack.Shuffle);
        }

        [Test]
        public void Shuffles_cards_randomly()
        {
            var randomMock = new Mock<Random>();
            randomMock.SetupSequence(rm => rm.Next(It.IsAny<int>(), It.IsAny<int>()))
                .Returns(1)
                .Returns(1);
            var twoCards = new List<ICard>
            {
                new Card(Value.Ace, Suit.Clubs),
                new Card(Value.Eight, Suit.Diamonds)
            };
            var pack = new PackOfCards(randomMock.Object, twoCards);
            pack.Shuffle();
            var firstCard = pack.TakeCardFromTopOfPack();
            var secondCard = pack.TakeCardFromTopOfPack();

            Assert.That(firstCard.Suit, Is.EqualTo(Suit.Diamonds));
            Assert.That(firstCard.Value, Is.EqualTo(Value.Eight));
            Assert.That(secondCard.Suit, Is.EqualTo(Suit.Clubs));
            Assert.That(secondCard.Value, Is.EqualTo(Value.Ace));
        }

        [Test]
        public void Count_returns_amount_of_cards_in_deck()
        {
            var pack = new PackOfCards(new Random(), new List<ICard> {new Card(Value.Two, Suit.Clubs)});
            Assert.That(pack.Count, Is.EqualTo(1));
        }

        [Test]
        public void Take_card_from_top_of_pack_removes_top_card()
        {
            var pack = new PackOfCards(new Random(), new List<ICard> { new Card(Value.Two, Suit.Clubs) });
            var topCard = pack.TakeCardFromTopOfPack();
            Assert.That(topCard.Value, Is.EqualTo(Value.Two));
            Assert.That(topCard.Suit, Is.EqualTo(Suit.Clubs));
            Assert.That(pack.Count, Is.EqualTo(0));
        }

        [Test]
        public void Take_card_from_top_of_pack_returns_null_when_empty_deck()
        {
            var pack = new PackOfCards(new Random(), new List<ICard>());
            var topCard = pack.TakeCardFromTopOfPack();
            Assert.Null(topCard);            
        }
    }
}
