namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game.Mono;

    [Attribute38("AttackImpactDef")]
    public class AttackImpactDef : MonoClass
    {
        public AttackImpactDef(IntPtr address) : this(address, "AttackImpactDef")
        {
        }

        public AttackImpactDef(IntPtr address, string className) : base(address, className)
        {
        }

        public float m_MaxAttack
        {
            get
            {
                return base.method_2<float>("m_MaxAttack");
            }
        }

        public float m_MinAttack
        {
            get
            {
                return base.method_2<float>("m_MinAttack");
            }
        }

        public Spell m_SpellPrefab
        {
            get
            {
                return base.method_3<Spell>("m_SpellPrefab");
            }
        }
    }
}

