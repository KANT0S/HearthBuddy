namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game.Mono;

    [Attribute38("SpellTableEntry")]
    public class SpellTableEntry : MonoClass
    {
        public SpellTableEntry(IntPtr address) : this(address, "SpellTableEntry")
        {
        }

        public SpellTableEntry(IntPtr address, string className) : base(address, className)
        {
        }

        public Spell m_Spell
        {
            get
            {
                return base.method_3<Spell>("m_Spell");
            }
        }

        public string m_SpellPrefabName
        {
            get
            {
                return base.method_4("m_SpellPrefabName");
            }
        }

        public SpellType m_Type
        {
            get
            {
                return base.method_2<SpellType>("m_Type");
            }
        }
    }
}

