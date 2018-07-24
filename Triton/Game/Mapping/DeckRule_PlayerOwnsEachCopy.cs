namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("DeckRule_PlayerOwnsEachCopy")]
    public class DeckRule_PlayerOwnsEachCopy : DeckRule
    {
        public DeckRule_PlayerOwnsEachCopy(IntPtr address) : this(address, "DeckRule_PlayerOwnsEachCopy")
        {
        }

        public DeckRule_PlayerOwnsEachCopy(IntPtr address, string className) : base(address, className)
        {
        }
    }
}

