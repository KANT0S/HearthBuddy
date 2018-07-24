namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game.Mono;

    [Attribute38("AllyAttackDef")]
    public class AllyAttackDef : MonoClass
    {
        public AllyAttackDef(IntPtr address) : this(address, "AllyAttackDef")
        {
        }

        public AllyAttackDef(IntPtr address, string className) : base(address, className)
        {
        }

        public float m_MoveToTargetDuration
        {
            get
            {
                return base.method_2<float>("m_MoveToTargetDuration");
            }
        }

        public iTween.EaseType m_MoveToTargetEaseType
        {
            get
            {
                return base.method_2<iTween.EaseType>("m_MoveToTargetEaseType");
            }
        }
    }
}

