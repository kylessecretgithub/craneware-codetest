namespace CodingChallenge.CardGame
{
    public class Card : ICard
    {
        public Card(Value value, Suit suit)
        {
            Value = value;
            Suit = suit;
        }

        public Suit Suit { get; }

        public Value Value { get; }

        public bool Equals(ICard other)
        {
            return this.Value == other.Value && this.Suit == other.Suit;
        }
    }
}
