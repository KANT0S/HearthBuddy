namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game.Mono;

    [Attribute38("EmoteEntry")]
    public class EmoteEntry : MonoClass
    {
        public EmoteEntry(IntPtr address) : this(address, "EmoteEntry")
        {
        }

        public EmoteEntry(IntPtr address, string className) : base(address, className)
        {
        }

        public void Clear()
        {
            base.method_8("Clear", Array.Empty<object>());
        }

        public EmoteType GetEmoteType()
        {
            return base.method_11<EmoteType>("GetEmoteType", Array.Empty<object>());
        }

        public string GetGameStringKey()
        {
            return base.method_13("GetGameStringKey", Array.Empty<object>());
        }

        public CardSoundSpell GetSpell(bool loadIfNeeded)
        {
            object[] objArray1 = new object[] { loadIfNeeded };
            return base.method_14<CardSoundSpell>("GetSpell", objArray1);
        }

        public CardSoundSpell GetSpellIfLoaded()
        {
            return base.method_14<CardSoundSpell>("GetSpellIfLoaded", Array.Empty<object>());
        }

        public void LoadSpell()
        {
            base.method_8("LoadSpell", Array.Empty<object>());
        }

        public string m_emoteGameStringKey
        {
            get
            {
                return base.method_4("m_emoteGameStringKey");
            }
        }

        public CardSoundSpell m_emoteSoundSpell
        {
            get
            {
                return base.method_3<CardSoundSpell>("m_emoteSoundSpell");
            }
        }

        public string m_emoteSoundSpellPath
        {
            get
            {
                return base.method_4("m_emoteSoundSpellPath");
            }
        }

        public EmoteType m_emoteType
        {
            get
            {
                return base.method_2<EmoteType>("m_emoteType");
            }
        }

        public Card m_owner
        {
            get
            {
                return base.method_3<Card>("m_owner");
            }
        }
    }
}

