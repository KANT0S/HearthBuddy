namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game.Mono;

    [Attribute38("AttackRangePrefabs")]
    public class AttackRangePrefabs : MonoClass
    {
        public AttackRangePrefabs(IntPtr address) : this(address, "AttackRangePrefabs")
        {
        }

        public AttackRangePrefabs(IntPtr address, string className) : base(address, className)
        {
        }

        public int m_MaxAtk
        {
            get
            {
                return base.method_2<int>("m_MaxAtk");
            }
        }

        public int m_MinAtk
        {
            get
            {
                return base.method_2<int>("m_MinAtk");
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

