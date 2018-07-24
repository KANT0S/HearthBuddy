namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game.Mono;

    [Attribute38("DeckInfoManaBar")]
    public class DeckInfoManaBar : MonoClass
    {
        public DeckInfoManaBar(IntPtr address) : this(address, "DeckInfoManaBar")
        {
        }

        public DeckInfoManaBar(IntPtr address, string className) : base(address, className)
        {
        }

        public GameObject m_barFill
        {
            get
            {
                return base.method_3<GameObject>("m_barFill");
            }
        }

        public UberText m_costText
        {
            get
            {
                return base.method_3<UberText>("m_costText");
            }
        }

        public int m_manaCostID
        {
            get
            {
                return base.method_2<int>("m_manaCostID");
            }
        }

        public int m_numCards
        {
            get
            {
                return base.method_2<int>("m_numCards");
            }
        }

        public UberText m_numCardsText
        {
            get
            {
                return base.method_3<UberText>("m_numCardsText");
            }
        }
    }
}

