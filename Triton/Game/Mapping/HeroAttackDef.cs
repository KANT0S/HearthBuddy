namespace Triton.Game.Mapping
{
    using ns26;
    using System;
    using Triton.Game.Mono;

    [Attribute38("HeroAttackDef")]
    public class HeroAttackDef : MonoClass
    {
        public HeroAttackDef(IntPtr address) : this(address, "HeroAttackDef")
        {
        }

        public HeroAttackDef(IntPtr address, string className) : base(address, className)
        {
        }

        public float m_MoveBackDuration
        {
            get
            {
                return base.method_2<float>("m_MoveBackDuration");
            }
        }

        public iTween.EaseType m_MoveBackEaseType
        {
            get
            {
                return base.method_2<iTween.EaseType>("m_MoveBackEaseType");
            }
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

        public float m_OrientBackDuration
        {
            get
            {
                return base.method_2<float>("m_OrientBackDuration");
            }
        }

        public iTween.EaseType m_OrientBackEaseType
        {
            get
            {
                return base.method_2<iTween.EaseType>("m_OrientBackEaseType");
            }
        }

        public float m_OrientToTargetDuration
        {
            get
            {
                return base.method_2<float>("m_OrientToTargetDuration");
            }
        }

        public iTween.EaseType m_OrientToTargetEaseType
        {
            get
            {
                return base.method_2<iTween.EaseType>("m_OrientToTargetEaseType");
            }
        }
    }
}

