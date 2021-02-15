using System;
using System.Collections;
using System.Collections.Generic;

namespace CodingChallenge.CardGame
{
    public class PackOfCards : IPackOfCards
    {
        private List<ICard> deck;
        private Random randomNumberGenerator;

        public PackOfCards(Random randomNumberGenerator, List<ICard> deck)
        {
            this.deck = deck == null ? new List<ICard>() : deck;
            this.randomNumberGenerator = randomNumberGenerator == null ? new Random() : randomNumberGenerator;
        }

        public int Count => deck.Count;

        public void Shuffle()
        {
            for(int i = 0; i < deck.Count; i++)
            {
                int randomIndex = randomNumberGenerator.Next(0, deck.Count - 1);
                ICard tempCard = deck[randomIndex];
                deck[randomIndex] = deck[i];
                deck[i] = tempCard;
            }
        }

        public ICard TakeCardFromTopOfPack()
        {
            if (deck.Count == 0)
            {
                return null;
            }
            ICard topCard = deck[0];
            deck.RemoveAt(0);
            return topCard;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return deck.GetEnumerator();
        }

        public IEnumerator<ICard> GetEnumerator()
        {
            return deck.GetEnumerator();
        }
    }
}
