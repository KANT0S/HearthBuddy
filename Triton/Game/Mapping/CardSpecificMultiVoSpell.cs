namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("CardSpecificMultiVoSpell")]
    public class CardSpecificMultiVoSpell : CardSoundSpell
    {
        public CardSpecificMultiVoSpell(IntPtr address) : this(address, "CardSpecificMultiVoSpell")
        {
        }

        public CardSpecificMultiVoSpell(IntPtr address, string className) : base(address, className)
        {
        }

        public void Play()
        {
            base.method_8("Play", Array.Empty<object>());
        }

        public void PlayNowMulti()
        {
            base.method_8("PlayNowMulti", Array.Empty<object>());
        }

        public bool SearchForCard()
        {
            return base.method_11<bool>("SearchForCard", Array.Empty<object>());
        }

        public void Stop()
        {
            base.method_8("Stop", Array.Empty<object>());
        }

        public int m_ActiveAudioIndex
        {
            get
            {
                return base.method_2<int>("m_ActiveAudioIndex");
            }
        }

        public CardSpecificMultiVoData m_CardSpecificVoData
        {
            get
            {
                return base.method_3<CardSpecificMultiVoData>("m_CardSpecificVoData");
            }
        }

        public bool m_SpecificCardFound
        {
            get
            {
                return base.method_2<bool>("m_SpecificCardFound");
            }
        }
    }
}

