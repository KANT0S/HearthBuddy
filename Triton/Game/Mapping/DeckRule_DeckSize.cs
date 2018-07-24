namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("DeckRule_DeckSize")]
    public class DeckRule_DeckSize : DeckRule
    {
        public DeckRule_DeckSize(IntPtr address) : this(address, "DeckRule_DeckSize")
        {
        }

        public DeckRule_DeckSize(IntPtr address, string className) : base(address, className)
        {
        }

        public int GetDeckSize()
        {
            return base.method_11<int>("GetDeckSize", Array.Empty<object>());
        }
    }
}

