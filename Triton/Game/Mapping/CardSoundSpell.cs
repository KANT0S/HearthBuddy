namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("CardSoundSpell")]
    public class CardSoundSpell : Spell
    {
        public CardSoundSpell(IntPtr address) : this(address, "CardSoundSpell")
        {
        }

        public CardSoundSpell(IntPtr address, string className) : base(address, className)
        {
        }

        public void ForceDefaultAudioSource()
        {
            base.method_8("ForceDefaultAudioSource", Array.Empty<object>());
        }

        public bool HasActiveAudioSource()
        {
            return base.method_11<bool>("HasActiveAudioSource", Array.Empty<object>());
        }

        public void OnBirth(SpellStateType prevStateType)
        {
            object[] objArray1 = new object[] { prevStateType };
            base.method_8("OnBirth", objArray1);
        }

        public void OnNone(SpellStateType prevStateType)
        {
            object[] objArray1 = new object[] { prevStateType };
            base.method_8("OnNone", objArray1);
        }

        public void Play()
        {
            base.method_8("Play", Array.Empty<object>());
        }

        public void PlayNow()
        {
            base.method_8("PlayNow", Array.Empty<object>());
        }

        public void Stop()
        {
            base.method_8("Stop", Array.Empty<object>());
        }

        public CardSoundData m_CardSoundData
        {
            get
            {
                return base.method_3<CardSoundData>("m_CardSoundData");
            }
        }

        public bool m_forceDefaultAudioSource
        {
            get
            {
                return base.method_2<bool>("m_forceDefaultAudioSource");
            }
        }
    }
}

