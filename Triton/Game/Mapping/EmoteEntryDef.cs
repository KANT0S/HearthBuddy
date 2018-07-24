namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game.Mono;

    [Attribute38("EmoteEntryDef")]
    public class EmoteEntryDef : MonoClass
    {
        public EmoteEntryDef(IntPtr address) : this(address, "EmoteEntryDef")
        {
        }

        public EmoteEntryDef(IntPtr address, string className) : base(address, className)
        {
        }

        public string m_emoteGameStringKey
        {
            get
            {
                return base.method_4("m_emoteGameStringKey");
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
    }
}

