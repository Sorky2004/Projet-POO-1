using System;

namespace Pioche.Models
{
    public enum CardValue {As=1, Deux, Trois, Quatre, Cinq, Six, Sept, Huit, Neuf, Dix, Valet, Dame, Roi}
    public struct Card
    {
        public CardColor Color { get; }
        public CardValue Value { get; }

        public Card(CardColor color, CardValue value)
        {
            Color = color;
            Value = value;
        }

        public override string ToString()
        {
            return $"{Value} of {Color}";
        }
    }
}