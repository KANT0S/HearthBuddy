namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game.Mono;

    [Attribute38("SpellImpactPrefabs")]
    public class SpellImpactPrefabs : MonoClass
    {
        public SpellImpactPrefabs(IntPtr address) : this(address, "SpellImpactPrefabs")
        {
        }

        public SpellImpactPrefabs(IntPtr address, string className) : base(address, className)
        {
        }

        public int m_MaxDamage
        {
            get
            {
                return base.method_2<int>("m_MaxDamage");
            }
        }

        public int m_MinDamage
        {
            get
            {
                return base.method_2<int>("m_MinDamage");
            }
        }

        public Spell m_Prefab
        {
            get
            {
                return base.method_3<Spell>("m_Prefab");
            }
        }
    }
}

