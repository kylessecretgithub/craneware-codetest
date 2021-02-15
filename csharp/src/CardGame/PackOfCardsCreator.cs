using System;
using System.Collections.Generic;

namespace CodingChallenge.CardGame
{
    public class PackOfCardsCreator : IPackOfCardsCreator
    {
        public IPackOfCards Create()
        {
            var pack = new List<ICard>();
            for(int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 13; j++)
                {
                    pack.Add(new Card((Value)j, (Suit)i));
                }
            }
            return new PackOfCards(new Random(), pack);
        }
    }
}
