namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game.Mono;

    [Attribute38("AttackInfo")]
    public class AttackInfo : MonoClass
    {
        public AttackInfo(IntPtr address) : this(address, "AttackInfo")
        {
        }

        public AttackInfo(IntPtr address, string className) : base(address, className)
        {
        }

        public Triton.Game.Mapping.Entity m_attacker
        {
            get
            {
                return base.method_3<Triton.Game.Mapping.Entity>("m_attacker");
            }
        }

        public Triton.Game.Mapping.Entity m_defender
        {
            get
            {
                return base.method_3<Triton.Game.Mapping.Entity>("m_defender");
            }
        }

        public Triton.Game.Mapping.Entity m_proposedAttacker
        {
            get
            {
                return base.method_3<Triton.Game.Mapping.Entity>("m_proposedAttacker");
            }
        }

        public Triton.Game.Mapping.Entity m_proposedDefender
        {
            get
            {
                return base.method_3<Triton.Game.Mapping.Entity>("m_proposedDefender");
            }
        }
    }
}

