namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("CardSpecificVoSpell")]
    public class CardSpecificVoSpell : CardSoundSpell
    {
        public CardSpecificVoSpell(IntPtr address) : this(address, "CardSpecificVoSpell")
        {
        }

        public CardSpecificVoSpell(IntPtr address, string className) : base(address, className)
        {
        }

        public bool SearchForCard()
        {
            return base.method_11<bool>("SearchForCard", Array.Empty<object>());
        }

        public CardSpecificVoData m_CardSpecificVoData
        {
            get
            {
                return base.method_3<CardSpecificVoData>("m_CardSpecificVoData");
            }
        }
    }
}

