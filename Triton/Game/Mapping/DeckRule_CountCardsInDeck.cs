namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("DeckRule_CountCardsInDeck")]
    public class DeckRule_CountCardsInDeck : DeckRule
    {
        public DeckRule_CountCardsInDeck(IntPtr address) : this(address, "DeckRule_CountCardsInDeck")
        {
        }

        public DeckRule_CountCardsInDeck(IntPtr address, string className) : base(address, className)
        {
        }
    }
}

