namespace Triton.Game.Mapping
{
    using ns26;
    using System;

    [Attribute38("SummonInForge")]
    public class SummonInForge : SpellImpl
    {
        public SummonInForge(IntPtr address) : this(address, "SummonInForge")
        {
        }

        public SummonInForge(IntPtr address, string className) : base(address, className)
        {
        }

        public void OnBirth(SpellStateType prevStateType)
        {
            object[] objArray1 = new object[] { prevStateType };
            base.method_8("OnBirth", objArray1);
        }

        public GameObject m_blackBits
        {
            get
            {
                return base.method_3<GameObject>("m_blackBits");
            }
        }

        public GameObject m_burnIn
        {
            get
            {
                return base.method_3<GameObject>("m_burnIn");
            }
        }

        public float m_burnInAnimationSpeed
        {
            get
            {
                return base.method_2<float>("m_burnInAnimationSpeed");
            }
        }

        public bool m_isHeroActor
        {
            get
            {
                return base.method_2<bool>("m_isHeroActor");
            }
        }

        public GameObject m_smokePuff
        {
            get
            {
                return base.method_3<GameObject>("m_smokePuff");
            }
        }
    }
}

