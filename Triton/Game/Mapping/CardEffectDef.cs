namespace Triton.Game.Mapping
{
    using ns25;
    using ns26;
    using System;
    using System.Collections.Generic;
    using Triton.Game.Mono;

    [Attribute38("CardEffectDef")]
    public class CardEffectDef : MonoClass
    {
        public CardEffectDef(IntPtr address) : this(address, "CardEffectDef")
        {
        }

        public CardEffectDef(IntPtr address, string className) : base(address, className)
        {
        }

        public List<string> m_SoundSpellPaths
        {
            get
            {
                Class268 class2 = base.method_3<Class268>("m_SoundSpellPaths");
                if (class2 != null)
                {
                    return class2.method_25();
                }
                return null;
            }
        }

        public string m_SpellPath
        {
            get
            {
                return base.method_4("m_SpellPath");
            }
        }
    }
}

